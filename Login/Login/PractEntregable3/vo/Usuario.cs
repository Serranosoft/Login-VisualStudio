using System;


namespace PractEntregable3.vo
{
    class Usuario
    {
        private String username;
        private String password;
        private String nombre;
        private String apellidos;
        private int edad;
        private String sexo;
        private String correo;

        public Usuario(string username, string password, string nombre, string apellidos, int edad, string sexo, string correo)
        {
            this.username = username;
            this.password = password;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.edad = edad;
            this.sexo = sexo;
            this.correo = correo;
        }

        public String getUsername()
        {
            return this.username;
        }
        public String getPassword()
        {
            return this.password;
        }
        public String getNombre()
        {
            return this.username;
        }
        public String getApellidos()
        {
            return this.apellidos;
        }
        public int Edad()
        {
            return this.edad;
        }
        public String getSexo()
        {
            return this.sexo;
        }
        public String getCorreo()
        {
            return this.correo;
        }

        public void setUsername(String username)
        {
            this.username = username;
        }
        public void setPassword(String password)
        {
            this.password = password;
        }
        public void setNombre(String nombre)
        {
            this.nombre = nombre;
        }
        public void setApellidos(String apellidos)
        {
            this.apellidos = apellidos;
        }
        public void setEdad(int edad)
        {
            this.edad = edad;
        }
        public void setSexo(String sexo)
        {
            this.sexo = sexo;
        }
        public void setCorreo(String correo)
        {
            this.correo = correo;
        }
    }
}
