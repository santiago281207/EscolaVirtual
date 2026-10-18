using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaVirtual.Classes
{
    public static class Methods
    {

        public static bool IsEmail(string email)
        {
            if(!email.Contains("@"))
            {
                return false;
            }

            //Posição do primeiro arroba
            int atSign = email.IndexOf('@');
            //Ultima posicao do ponto
            int point = email.LastIndexOf('.');

            int pointCounter = 0;

            for (int i = atSign; i < email.Length; i++)
            {
                if (email[i] == '.')
                {
                    pointCounter++;
                }
            }

            //Validar  se email é válido
            if (email != "" && atSign > 0 && atSign == email.LastIndexOf('@') &&
                point > atSign + 1 && point < email.Length - 1 && !email.Contains(" ") && pointCounter == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }















    }
}
