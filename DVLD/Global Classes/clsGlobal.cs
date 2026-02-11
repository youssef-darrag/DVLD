using DVLD_Business;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DVLD
{
    internal static class clsGlobal
    {
        public static clsUser CurrentUser;

        private static string _keyPath = @"HKEY_CURRENT_USER\Software\DVLD_Project";
        private static string _valueName = "UserName";
        private static string _valuePassword = "Password";

        //public static bool RememberUserNameAndPassword(string UserName, string Password)
        //{
        //    try
        //    {
        //        //this will get the current project directory folder.
        //        string currentDirectory = System.IO.Directory.GetCurrentDirectory();

        //        // Define the path to the text file where you want to save the data
        //        string filePath = currentDirectory + "\\data.txt";

        //        //incase the username is empty, delete the file
        //        if (UserName == "" && File.Exists(filePath))
        //        {
        //            File.Delete(filePath);
        //            return true;
        //        }

        //        // concatonate username and passwrod withe seperator.
        //        string dataToSave = UserName + "#//#" + Password;

        //        // Create a StreamWriter to write to the file
        //        using (StreamWriter writer = new StreamWriter(filePath))
        //        {
        //            // Write the data to the file
        //            writer.WriteLine(dataToSave);

        //            return true;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"An error occurred: {ex.Message}");
        //        return false;
        //    }
        //}

        //public static bool GetStoredCredential(ref string UserName, ref string Password)
        //{
        //    //this will get the stored username and password and will return true if found and false if not found.
        //    try
        //    {
        //        //gets the current project's directory
        //        string currentDirectory = System.IO.Directory.GetCurrentDirectory();

        //        // Path for the file that contains the credential.
        //        string filePath = currentDirectory + "\\data.txt";

        //        // Check if the file exists before attempting to read it
        //        if (File.Exists(filePath))
        //        {
        //            // Create a StreamReader to read from the file
        //            using (StreamReader reader = new StreamReader(filePath))
        //            {
        //                // Read data line by line until the end of the file
        //                string line;
        //                while ((line = reader.ReadLine()) != null)
        //                {
        //                    Console.WriteLine(line); // Output each line of data to the console
        //                    string[] result = line.Split(new string[] { "#//#" }, StringSplitOptions.None);

        //                    UserName = result[0];
        //                    Password = result[1];
        //                }

        //                return true;
        //            }
        //        }
        //        else
        //        {
        //            return false;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"An error occurred: {ex.Message}");
        //        return false;
        //    }
        //}

        public static bool RememberUserNameAndPassword(string UserName, string Password)
        {
            string valueDataName = UserName;
            string valueDataPassword = Password;

            try
            {
                Registry.SetValue(_keyPath, _valueName, valueDataName, RegistryValueKind.String);
                Registry.SetValue(_keyPath, _valuePassword, valueDataPassword, RegistryValueKind.String);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
                return false;
            }
        }

        public static bool GetStoredCredential(ref string UserName, ref string Password)
        {
            //this will get the stored username and password and will return true if found and false if not found.
            try
            {
                UserName = Registry.GetValue(_keyPath, _valueName, null) as string;
                Password = Registry.GetValue(_keyPath, _valuePassword, null) as string;

                if (UserName != null && Password != null)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
                return false;
            }
        }
    }
}