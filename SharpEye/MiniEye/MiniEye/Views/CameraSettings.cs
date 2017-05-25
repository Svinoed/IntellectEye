using System;
using System.Windows.Forms;
using Settings;
using System.Collections.Generic;

namespace MiniEye.Views
{
    public partial class CameraSettings : Form, ISettingsListener
    {
        #region properties
        ICameraData _CameraData;
        #endregion

        #region events
        /// <summary>
        /// Делегат, определяющий сигнатуру получения списка камер
        /// </summary>
        public delegate List<object> CameraListRequested();
        /// <summary>
        /// Делегат определяющий сигнатуру изменения данных камеры
        /// </summary>
        public delegate void CameraDataChanged(ICameraData data);
        /// <summary>
        /// Делегат определяющий сигнатуру проверки соединения
        /// </summary>
        public delegate void CheckConnectionRequested(string server, Authorization authType, string login, string password);
        /// <summary>
        /// Делегат определяющий сигнатуру того, что камера выбрана
        /// </summary>
        public delegate void CameraSelected(object camera);

        /// <summary>
        /// Событие, возникающее когда пользователь запрашивает список камер
        /// </summary>
        public event CameraListRequested OnGetCameraRequest;
        /// <summary>
        /// Событие, возникающее при запросе пользователя на проверку подключения
        /// </summary>
        public event CheckConnectionRequested OnCheckConnection;
        /// <summary>
        /// Событие, возникающее при принятии настроек
        /// </summary>
        public event CameraDataChanged OnSettingsApplyed;
        /// <summary>
        /// Событие, возникающее при выборе и смене камеры
        /// </summary>
        public event CameraSelected OnCameraSelected;
        #endregion

        /// <summary>
        /// Создает новый компонент, загружает настройки по умолчанию
        /// </summary>
        public CameraSettings(ICameraData data)
        {

            InitializeComponent();
            _CameraData = data;
            //Инициализация типов авторизации, добавление типов в ComboBox
            foreach (var item in Enum.GetValues(typeof(Authorization)))
                this.AuthTypeComboBox.Items.Add(item);
            this.AuthTypeComboBox.SelectedIndex = 0;
            SetSettings(data);


        }
        /// <summary>
        /// Обновляет визуальное состояние компонента.
        /// устанавливает всем визуальным компонентам необходимые значения
        /// </summary>
        public void SetSettings(ICameraData data)
        {
            this.AuthTypeComboBox.SelectedItem = data.AuthType;
            this.LoginTextBox.Text = data.Login;
            this.PasswordTextBox.Text = data.Password;
            this.ServerAddressTextBox.Text = data.ServerName;
            this.CameraNameTextBox.Text = data.CameraName;
            this.DefaultCameraComboBox.Items.Clear();
            //Состояние камеры меняется только если она она есть
            if(!data.SelectedCameraName.Equals(""))
                this.DefaultCameraComboBox.Items.Add(data.SelectedCameraName);
        }
        /// <summary>
        /// Вызывается при изменении состояния глобальных настроек
        /// Вызывает исключение о том, что другим в это время были изменены настройки
        /// </summary>
        public void SettingsChanged(IGlobalData settings)
        {
            throw new Exception("Глобальные настройки были изменены другим компонентом");
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            //TODO: восстановить состояние объекта до изменений
            //Данная форма всегда хранится в памяти и не закрывается
            //По крайней мере пока создатель ее не разрушит
            this.Hide();
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            //TODO: реализовать проверку данных перед применением настроек. Если данные корректны отправить в вызывающий модуль
            OnSettingsApplyed(_CameraData);

        }
        /// <summary>
        /// Проверка соединения с сервером
        /// </summary>
        private void CheckConnectionButton_Click(object sender, EventArgs e)
        {
            //Вызвать событие запроса соединения
            try
            {
                this.OnCheckConnection(
                    this.ServerAddressTextBox.Text,
                    (Authorization)this.AuthTypeComboBox.SelectedItem,
                    this.LoginTextBox.Text,
                    this.PasswordTextBox.Text);
                MessageBox.Show("Подключение успешно");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
        /// <summary>
        /// Выбрать камеру для подключения по умолчанию
        /// </summary>
        private void DefaultCameraComboBox_MouseClick(object sender, MouseEventArgs e)
        {
            //TODO: добавить асинхронность в связи с длинным запросом на получение камер
            try
            {
                //Подключение к серверу
                this.OnCheckConnection(
                    this.ServerAddressTextBox.Text,
                    (Authorization)this.AuthTypeComboBox.SelectedItem,
                    this.LoginTextBox.Text,
                    this.PasswordTextBox.Text);
                //Запросить список камер
                List<object> cameras = OnGetCameraRequest();
                if (cameras.Count == 0)
                    throw new ArgumentOutOfRangeException("Найдено камер: 0");

                this.DefaultCameraComboBox.Items.Clear();
                this.DefaultCameraComboBox.Items.AddRange(cameras.ToArray());
                this.DefaultCameraComboBox.DroppedDown = true;
            }
            catch (ArgumentOutOfRangeException err)
            {
                MessageBox.Show(err.Message);
                this.DefaultCameraComboBox.Items.Clear();
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка при получении списка камер, проверьте соединение");
                this.DefaultCameraComboBox.Items.Clear();
            }

        }
        /// <summary>
        /// Сохранить состояние при изменении формы
        /// </summary>
        private void AuthTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _CameraData.AuthType = (Authorization)this.AuthTypeComboBox.SelectedItem;
        }
        /// <summary>
        /// Сохранить состояние при изменении формы
        /// </summary>
        private void DefaultCameraComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _CameraData.SelectedCameraName = this.DefaultCameraComboBox.SelectedItem.ToString();
            OnCameraSelected(this.DefaultCameraComboBox.SelectedItem);
        }
        /// <summary>
        /// Обновить состояние пароля
        /// </summary>
        private void PasswordTextBox_Leave(object sender, EventArgs e)
        {
            _CameraData.Password = this.PasswordTextBox.Text;
        }
        /// <summary>
        /// Обновить состояние логина
        /// </summary>
        private void LoginTextBox_TextChanged(object sender, EventArgs e)
        {
            _CameraData.Login = this.LoginTextBox.Text;
        }
        /// <summary>
        /// Обновить состояние сервера
        /// </summary>
        private void ServerAddressTextBox_TextChanged(object sender, EventArgs e)
        {
            _CameraData.ServerName = this.ServerAddressTextBox.Text;
        }
        /// <summary>
        /// Обновить состояние имени камеры
        /// </summary>
        private void CameraNameTextBox_TextChanged(object sender, EventArgs e)
        {
            _CameraData.CameraName = this.CameraNameTextBox.Text;
        }
       
    }
}
