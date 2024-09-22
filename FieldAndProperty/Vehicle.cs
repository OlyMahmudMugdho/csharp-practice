using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldAndProperty
{
    class Vehicle
    {
        private string _name;
        private int _wheels;
        private string _description;

        public void SetName(string name)
        {
            this._name = name;
        }

        public string GetName() {
            return this._name;
        }

        public int Wheels
        {
            get { return this._wheels; }
            set { this._wheels = value; }
        }

        public string Description{ get; set; }
    }
}
