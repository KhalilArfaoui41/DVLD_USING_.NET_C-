using BusinessLayer;
using DVLD_Buisness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLDProjevt
{
    public partial class AddUpdatePerson : Form
    {


        public enum enMode{ AddNew=0 , Upadate=1 };
        public enum enGendor { Male=0 , Female=1 };

        private enMode _Mode;
        private int _PersonID = -1;
        clsPerson _Person;

        public AddUpdatePerson()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
        }
        public AddUpdatePerson(int PersonID)
        {
            InitializeComponent();

            _Mode = enMode.Upadate;
            _PersonID = PersonID;
        }


        private void _FillCountriesInComboBox()
        {
            DataTable dtCountries = clsCountry.GetAllCountries();

            foreach (DataRow row in dtCountries.Rows)
            {
                cbCountry.Items.Add(row["CountryName"]);
            }

        }

        private void _ResetDefaultValues()
        {
            _FillCountriesInComboBox();
        }


        private void AddUpdatePerson_Load(object sender, EventArgs e)
        {

            _ResetDefaultValues();

        }

       
    }
}
