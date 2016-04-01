using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactManager
{
    public partial class ContactManager : Form
    {
        List<Person> listOfPersons = new List<Person>();
        Validator isValid = new Validator();
        private static int id;

        //public enum Types
        //{
        //    Home, WorkPlace, Mobile
        //}

        public ContactManager()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //listView1.View = View.Details;
            //PersonsData.TextAlign = HorizontalAlignment.Center;
            //PersonsData.Width = 404;
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            if (isValid.isAddressRight(addresstext.Text) && isValid.isNameRight(nametext.Text) && isValid.isAgeRight(agetext.Text) && isValid.isMobileNumberRight(mobiletext.Text))
            {
                listOfPersons.Add(new Person(nametext.Text, addresstext.Text, agetext.Text, mobiletext.Text, (Person.Types)GetTypeEnumInText()));
            }     
        }

        private void listbtn_Click(object sender, EventArgs e)
        {
            ContactManager.ActiveForm.Width = 783;
            ContactManager.ActiveForm.Height = 315;

            id = 0;
            //dataGridView1.DataSource = listOfPersons;
            dataGridView1.Rows.Clear();
            foreach (Person item in listOfPersons)
            {

                dataGridView1.Rows.Add(item.Name,item.Address,item.Age,item.Mobile,item.Type);
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ContactManager.ActiveForm.Width = 290;
            ContactManager.ActiveForm.Height = 315;
        }

        private Person.Types? GetTypeEnumInText()
        {
            string home = nameof(Person.Types.Home);
            string mobile = nameof(Person.Types.Mobile);
            string workPlace = nameof(Person.Types.WorkPlace);

            if (combobox.Text.Equals(home))
            {
                return Person.Types.Home;
            }
            else if(combobox.Text.Equals(mobile))
            {
                return Person.Types.Mobile;
            }
            else if(combobox.Text.Equals(workPlace))
            {
                return Person.Types.WorkPlace;
            }
            return Person.Types.None;
        }
    }
}
