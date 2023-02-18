using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using Newtonsoft.Json;

namespace t10
{
    internal class ReadWrite
    {
        private List<Client> _clientList;
        private ClientGenerator _generator;
        private ChangeLog _changeLog;
        private string _path;
        public ReadWrite(string path)
        {
            _clientList = new List<Client>();
            _generator = new ClientGenerator();
            _changeLog = new ChangeLog();
            _path = path;
        }
        /// <summary>
        /// Запись в json
        /// </summary>
        public void Write()
        {
            string json = String.Empty;
            using (StreamWriter sw = new StreamWriter(_path))
            {
                foreach (var client in _clientList)
                {
                    json += JsonConvert.SerializeObject(client, Formatting.Indented);
                }
                sw.WriteLine(json);
                _clientList.Clear();
                sw.Close();
            }
        }
        public void Write(List<Client> clientList)
        {
            this._clientList = clientList;
            Write();
        }
        /// <summary>
        /// Чтение из json
        /// </summary>
        /// <returns></returns>
        public List<Client> Read()
        {
            JsonSerializer serializer = new JsonSerializer();
            using (StreamReader sr = new StreamReader(_path))
            {
                using (JsonTextReader jsonReader = new JsonTextReader(sr))
                {
                    while (jsonReader.Read())
                    {
                        jsonReader.SupportMultipleContent = true;
                        _clientList.Add(serializer.Deserialize<Client>(jsonReader));
                    }
                }
                sr.Close();
                return _clientList;
            }
        }
        /// <summary>
        /// Инициализация
        /// </summary>
        /// <param name="clients"></param>
        /// <param name="clientListBox"></param>
        public void Initialize(List<Client> clients, ListBox clientList)
        {
            if (!File.Exists(_path))
            {
                _clientList = _generator.ClientListGenerator(30);
                Write(_clientList);
                ListBoxAddItem(_clientList, clientList);
            }
            else
                ListBoxAddItem(clients, clientList);
        }

        public void ListBoxAddItem(List<Client> clients, ListBox clientListBox)
        {
            foreach (var client in clients)
            {
                clientListBox.Items.Add(client.FullName);
            }
        }
    }
}
