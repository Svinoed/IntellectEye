using System;
using Contract;
using VideoOS.Platform;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.ComponentModel.Composition;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.Reflection;

namespace Model
{
    [Serializable]
    [Export(typeof(Contract.ISerializable))]
    class SerializeDevice : Contract.ISerializable
    {
        string _CameraId;
        string _CameraName;
        string _MicrofoneID = null;
        public string Serialize(ICameraModel camera)
        {
            //Конвертация FQID в строку XML
            _CameraId = ((FQID)camera.Id).ToXmlNode().InnerXml;
            _CameraName = camera.Name;
            if(camera.MicrophoneId != null)
                _MicrofoneID = ((FQID)camera.MicrophoneId).ToXmlNode().InnerXml;
            //Сериализация с помощью строки и бинарного формата
            BinaryFormatter serializer = new BinaryFormatter();
            string serializedCamera;
            using (MemoryStream stream = new MemoryStream())
            {
                serializer.Serialize(stream, this);
                stream.Position = 0;
                //Конвертирования ToBase64 необходимо для правильного преобразования в строку
                //И для корректной десериализации
                serializedCamera = Convert.ToBase64String(stream.ToArray());
            }
            return serializedCamera;
        }

        public ICameraModel Deserialize(string serializedCamera)
        {
            byte[] bytes = Convert.FromBase64String(serializedCamera);
            BinaryFormatter serializer = new BinaryFormatter();
            //Перед десериализацией сделать биндинк сборок и имен
            serializer.Binder = new PreMergeToMergedDeserializationBinder();
            using (MemoryStream stream = new MemoryStream(bytes))
            {
                SerializeDevice device = (SerializeDevice)serializer.Deserialize(stream);
                _CameraId = device._CameraId;
                _CameraName = device._CameraName;
                //Если все нормально, то создается объект камеры
                if (device._MicrofoneID != null)
                    return new Camera(new FQID(_CameraId), _CameraName, new FQID(_MicrofoneID));
                else
                    return new Camera(new FQID(_CameraId), _CameraName);
            }
        }
    }
    /// <summary>
    /// Данный класс нужен для работы COM, если десериализуемый объект находится в той же сборке
    /// необходимо сопоставление имен сборок иначе эта сборка будет не найдена
    /// </summary>
    sealed class PreMergeToMergedDeserializationBinder : SerializationBinder
    {
        public override Type BindToType(string assemblyName, string typeName)
        {
            Type typeToDeserialize = null;

            // For each assemblyName/typeName that you want to deserialize to
            // a different type, set typeToDeserialize to the desired type.
            String exeAssembly = Assembly.GetExecutingAssembly().FullName;

            // The following line of code returns the type.
            typeToDeserialize = Type.GetType(String.Format("{0}, {1}",
                typeName, exeAssembly));

            return typeToDeserialize;
        }
    }
}
