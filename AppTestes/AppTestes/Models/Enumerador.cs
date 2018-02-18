using System;

namespace AppTestes.Models
{
    public class Enumerador
    {

        [FlagsAttribute]
        public enum Grupo
        {
            Users = 1,
            Supervisors = 2,
            Managers = 4,
            Administrators = 8
        }

        public class User : IComparable
        {
            public Grupo UserGrupo { get; set; }

            public int CompareTo(object obj)
            {
                var user = new User();
                user.UserGrupo = Grupo.Users;

                var teste = user.UserGrupo == Grupo.Users;

                return 0;
            }
        }
    }
}
