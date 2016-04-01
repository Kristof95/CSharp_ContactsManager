using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactManager
{
    class Validator
    {
        public bool isNameRight(string name)
        {
             if(isAlpha(name))
            {
               return true;
            }
           MessageBox.Show("Name field must contain only letters!","Warning!",MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
           return false;
        }

        public bool isAddressRight(string address)
        {
            if(!(address.Length > 25))
            {
                return true;
            }
            MessageBox.Show("Maximum address length is 25 characters!", "Warning!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            return false;
        }

        public bool isAgeRight(string age)
        {
            try
            {
                if(Convert.ToInt32(age) < 125) return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Age filed must contain integers!", "Warning!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                return false;
            }
            return false;  
        }

        public bool isMobileNumberRight(string mobilenumber)
        {
            if (mobilenumber.StartsWith("+"))
            {
                if((mobilenumber.Length == 12 || isNumeric(mobilenumber.Substring(1,mobilenumber.Length-1))))
                {
                    return true;
                }
                return true;
            }
            else if (mobilenumber.StartsWith("0630") || mobilenumber.StartsWith("0620") || mobilenumber.StartsWith("0670"))
            {
                if((mobilenumber.Length == 11 || isNumeric(mobilenumber)))
                {
                    return true;
                }
                return true;
            }
            else
            {
                MessageBox.Show("Mobile number filed must contain integers!\nInvalid Phone Number!", "Warning!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                return false;
            }
        }

        public bool isAlpha(string someString)
        {
            int charCounter = 0;
            for (int i = 0; i <= someString.Length - 1; i++)
            {
                Char.IsLetter(someString[i]);
                charCounter++;
                if (charCounter == someString.Length - 1)
                {
                    return true;
                }
            }
            return false;
        }

        public bool isNumeric(string mobilenumber)
        {
            try
            {
                Convert.ToInt64(mobilenumber);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
