using Microsoft.Win32;
using System;

namespace ResetIDM
{
	class Program
	{
		static void Main(string[] args)
		{
			RegistryKey key = Registry.Users.OpenSubKey(@"S-1-5-21-375369516-1860467429-3256839946-1001_Classes\WOW6432Node\CLSID\{07999AC3-058B-40BF-984F-69EB1E554CA7}", true);

			//getting the value
			string data = key.GetValue("Therad").ToString();  //returns the text found in 'someValue'
			key.SetValue("Therad", 1, RegistryValueKind.DWord);

			key.Close();
		}
	}
}
