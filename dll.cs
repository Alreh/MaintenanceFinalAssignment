using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegEditTool
{
    public class RegEdit
    {
        //Function
        public int Start()
        {
            Microsoft.Win32.RegistryKey key;
            key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("MaintenanceTesti");

            int state = 0;
            if (key == null) {
                Console.WriteLine("Registry could not be found...");
                state = 1;
                return state;
            }
            else
            {
                Console.WriteLine("Registry found!");
                state = 2;
                return state;
            }
            
        }
        public void End(int state)
        {
            Microsoft.Win32.RegistryKey key;

            if (state == 1)
            {
                key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("MaintenanceTesti");
                key.SetValue("TimesUsed", "1");
                Console.WriteLine("Initial (D) Registery mod made");
                key.Close();
            }
            else if (state == 2)
            {
                key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("MaintenanceTesti");
                Console.WriteLine("Key was found");
                string CurrentValue = (string)key.GetValue("TimesUsed");
                int x = Int32.Parse(CurrentValue) + 1;
                CurrentValue = x.ToString();
                Console.WriteLine("You have used the application: {0} times.", CurrentValue);
                key.SetValue("TimesUsed", CurrentValue);
                key.Close();
            }
        }
        //End Function
    }
}
