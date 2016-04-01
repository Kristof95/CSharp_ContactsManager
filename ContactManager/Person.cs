using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager
{
    public struct Person
    {
        private string name;
        private string address;
        private string age;
        private string mobile;
        private Types type;

        public enum Types
        {
            Home, WorkPlace, Mobile, None
        }

        public Person(string name, string address, string  age, string mobile, Types types)
        {
            this.name = name;
            this.address = address;
            this.age = age;
            this.mobile = mobile;
            this.type = types;
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string Address
        {
            get
            {
                return address;
            }

            set
            {
                address = value;
            }
        }

        public string Age
        {
            get
            {
                return age;
            }

            set
            {
                age = value;
            }
        }

        public string Mobile
        {
            get
            {
                return mobile;
            }

            set
            {
                mobile = value;
            }
        }

        public Types Type
        {
            get
            {
                return type;
            }

            set
            {
                type = value;
            }
        }

        public override string ToString()
        {
            return "Name:" + name + "\n" + "Address:" + address + "\n" + "Age:" + age + "\n " + "Mobile:" + mobile + "\n" + "Type:" + nameof(type);
        }

    }
}
