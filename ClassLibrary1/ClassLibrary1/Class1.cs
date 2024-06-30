using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ClassLibrary1 {
    public static class Class1 {
        public static string Bell (int times) {
            if (times == 0)
                return "больше 15 минут";

            if (times == 1)
                return "15 минут";
            
            if (times == 2)
                return "10 минут";

            if (times == 3)
                return "5 минут";

            return "Ошибка. Попробуйте снова";
        }

        public static string TotalTime (int acts) {
            if (acts > 0) {
                int totalTime = acts * 55;
                totalTime += (acts - 1) * 20;

                int hours = totalTime / 60;
                int minutes = totalTime - (hours * 60);

                return hours + " часов " + minutes + " минут";
            }

            return "Ошибка. Попробуйте снова";
        }

        public static double GetDays (DateTime today, DateTime eventDate) {
            return (eventDate - today).TotalDays;
        }
    }
}
