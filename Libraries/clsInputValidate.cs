using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace DeskEtu.Libraries
{
    internal class clsInputValidate
    {

        static string RemoveSpace(string FullNumber, string Delim = " ")
        {
            int Position = 0;
            while ((Position = FullNumber.IndexOf(Delim)) != -1)
            {
                FullNumber = FullNumber.Remove(Position, 1);
            }

            return FullNumber;
        }

        static bool CheckLoginInput(string FullName)
        {
            for (int i = 0; i < FullName.Length; i++)
            {
                if (Convert.ToInt32(FullName[i]) < 65 || Convert.ToInt16(FullName[i]) > 90)
                {
                    if (Convert.ToInt32(FullName[i]) < 97 || Convert.ToInt16(FullName[i]) > 122)
                    {
                        if (Convert.ToInt32(FullName[i]) !=  35 )
                        {
                            if (Convert.ToInt32(FullName[i]) != 64)
                            {
                                if (Convert.ToInt32(FullName[i]) != 95)
                                {
                                    return false;
                                }
                            }
                        }
                    }
                }
            }

            return true;
        }
        static bool CheckName(string FullName)
        {

            for (int i = 0; i < FullName.Length; i++)
            {
                if (Convert.ToInt32(FullName[i]) < 65 || Convert.ToInt16(FullName[i]) > 90)
                {
                    return false;
                }
            }

            return true;
        }
        static bool CheckPhone(string Phone)
        {
            string TempPhone = Phone;

            // Should start with zero 
            if (Convert.ToInt32(Phone[0]) != 48)
                return false;

            // The next number should refer to Ooredoo : 5 or Djezzy : 7 or Mobilis : 6
            if (Convert.ToInt32(Phone[1]) != 53 && Convert.ToInt32(Phone[1]) != 54 && Convert.ToInt32(Phone[1]) != 55)
                return false;

            //Check the rest numbers

            TempPhone = TempPhone.Remove(0, 2);

            if (TempPhone.Length < 8 || TempPhone.Length > 8)
                return false;


            for (int i = 0; i < TempPhone.Length; i++)
            {
                if (Convert.ToInt32(TempPhone[i]) < 48 || Convert.ToInt16(TempPhone[i]) > 57)
                {
                    return false;
                }
            }

            return true;
        }
        static bool CheckSalary(string SalryText)
        {
            double Salary = 1.00;
            bool IsAPrice = double.TryParse(SalryText, out Salary);

            return IsAPrice;
        }
        static bool CheckNumber(string NumberText)
        {
            int Number = 1;
            bool IsANumber = Int32.TryParse(NumberText, out Number);

            if (Number < 1)
                return false;

            return IsANumber;
        }

        static bool CheckEmail(string Email)
        {
            // ....@gmail.com
            string TempEmail = Email;

            if (Email == "@gmail.com")
                return false;

            int GmailPosition = TempEmail.IndexOf("@gmail.com");

            if (GmailPosition != -1)
            {
                // Check if it's written more than one time
                // @gmail.com lenth is 10 characters

                TempEmail = TempEmail.Remove(GmailPosition, 10);

                if (TempEmail.IndexOf("@gmail.com") == -1)
                    return true;

            }
            return false;

        }





        static public bool IsLoginValide(string TextValue)
        {
            string FullText = RemoveSpace(TextValue);
            bool IsValid = CheckLoginInput(FullText);
            return IsValid;
        }
        static public bool IsNameValide(string TextValue)
        {
            string FullText = RemoveSpace(TextValue);
            bool IsValid = CheckName(FullText.ToUpper());
            return IsValid;
        }
        static public bool IsEmailValide(string TextValue)
        {
            string FullText = RemoveSpace(TextValue);
            bool IsValid = CheckEmail(FullText.ToLower());
            return IsValid;
        }
        static public bool IsPhoneValide(string TextValue)
        {
            string FullText = RemoveSpace(TextValue);
            bool IsValid = CheckPhone(FullText);
            return IsValid;
        }
        static public bool IsSalaryValide(string TextValue)
        {
            string FullText = RemoveSpace(TextValue);
            bool IsValid = CheckSalary(FullText);
            return IsValid;
        }
        static public bool IsNumberValide(string TextValue)
        {
            string FullText = RemoveSpace(TextValue);
            bool IsValid = CheckNumber(FullText);
            return IsValid;
        }


    }
}
