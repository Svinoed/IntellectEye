using System;
using Contract;
using VideoOS.Platform;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.ComponentModel.Composition;

namespace Model
{
    [Serializable]
    [Export(typeof(ISerializable))]
    class SerializeDevice : ISerializable
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
}
