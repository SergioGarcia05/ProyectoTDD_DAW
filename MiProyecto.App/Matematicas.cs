using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MiProyecto.App
{
    public class Matematicas
    {
        public long CalcularFactorial(int n)
        {
            if (n < 0)
            {
                return -1;
            }

            if (n <= 1)
            {
                return 1;
            }

            long resultado = 1;

            for (int i = 2; i <= n; i++)
            {
                resultado *= i;
            }

            return resultado;
        }

        public bool EsPinValido(string pin)
        {
            // 1. Validar que no sea nulo ni vacío
            if (string.IsNullOrEmpty(pin)) return false;

            // 2. Validar longitud: debe ser estrictamente de 4 o 6 caracteres
            if (pin.Length != 4 && pin.Length != 6) return false;

            // 3. Validar que todos los caracteres sean números
            if (!pin.All(char.IsDigit)) return false;

            // 4. Validar que no sean todos los dígitos iguales (ej: "1111", "888888")
            if (pin.Distinct().Count() == 1) return false;

            return true;
        }
    }
}