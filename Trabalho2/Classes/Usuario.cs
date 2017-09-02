using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Data.Json;

namespace Trabalho2.Classes
{
    class Usuario
    {
        private const string loginKey = "login" ;
        private const string senhanKey = "senha";


        private string login;
        private string senha;

        public string Login { get => login; set => login = value; }
        public string Senha { get => senha; set => senha = value; }

        public Usuario()
        {
            Login = "";
            Senha = "";
        }

        public Usuario(string Login, string Senha)
        {
            login = Login;
            senha = Senha;
        }

        public Usuario(string jsonString) : this()
        {
            JsonObject jsonObject = JsonObject.Parse(jsonString);
            Login = jsonObject.GetNamedString(loginKey, "");
            Senha = jsonObject.GetNamedString(senhanKey, "");
        }


        public string UsuarioToString()
        {
            JsonObject jsonObject = new JsonObject();
            jsonObject[loginKey] = JsonValue.CreateStringValue(Login);
            jsonObject[senhanKey] = JsonValue.CreateStringValue(Senha);

            return jsonObject.Stringify();

        }
    }
}
