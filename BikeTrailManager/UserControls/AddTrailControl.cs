using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BikeTrailManager.Classes;
using BikeTrailManager;

namespace BikeTrailManager.UserControls
{
    public partial class AddTrailControl : UserControl
    {
        public AddTrailControl()
        {
            InitializeComponent();
        }


        //if none of errors exists, add new trail and reset textboxes
        private void addTrailButton_Click(object sender, EventArgs e)
        {
            if (CheckValidationAndAddTrail(name.Text, description.Text, distance.Text, elevationGain.Text, hours.Text, minutes.Text, day.Text, month.Text, year.Text))
            {
                MessageBox.Show("Trasa została dodana.");
                ResetTextBoxes();
            }
        }
        //if none of errors exists, add new trail and reset textboxes
        private void AddATrail_Click(object sender, EventArgs e)
        {
            if (CheckValidationAndAddTrail(name.Text, description.Text, distance.Text, elevationGain.Text, hours.Text, minutes.Text, day.Text, month.Text, year.Text))
            {
                MessageBox.Show("Trasa została dodana.");
                ResetTextBoxes();
            }
        }

        //
        //resets all textboxes text
        //
        private void ResetTextBoxes()
        {
            distance.Text = "";
            hours.Text = "";
            minutes.Text = "";
            elevationGain.Text = "";
            name.Text = "";
            description.Text = "";
            day.Text = "";
            month.Text = "";
            year.Text = "";
        }



        //loads pictures source
        private void AddTrailControl_Load(object sender, EventArgs e) => LoadPictures();
        private void LoadPictures() => addTrailButton.Image = Properties.Resources.addTrailButton;
        

        //checks if any error exists
        public bool CheckValidationAndAddTrail(string Name, string Description, string Distance, string ElevationGain, string Hours, string Minutes, string Day, string Month, string Year)
        {
            //
            //name validation
            //
            //checks if name value isn't empty
            if (Name == "")
            {
                MessageBox.Show("Wpisz nazwę trasy");
                return false;
            }

            //if name length is >90, returns false
            if (Name.Length > 90)
            {
                MessageBox.Show("Przekroczono limit znaków. Maksymalna liczba znaków to 90.");
                return false;
            }

            //changes first letter to capital letter
            Name = char.ToUpper(Name[0]) + Name.Substring(1);

            //
            //description validation
            //
            if (Description == "")
            {
                DialogResult dialogResult = MessageBox.Show("Czy napewno chcesz stworzyc trase bez opisu?", "Uwaga", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.No) return false;
            }

            //if description length is >1250, returns false
            if (Description.Length > 1250)
            {
                MessageBox.Show("Przekroczono limit znaków. Maksymalna liczba znaków to 1250.");
                return false;
            }

            //if description value isn't empty changes first letter to capital letter
            if (Description.Length > 0) Description = char.ToUpper(Description[0]) + Description.Substring(1);


            //
            //distance validation
            //
            try
            {
                if (Convert.ToDouble(Distance) <= 0)
                {
                    MessageBox.Show("Dystans nie może być ujemny lub zerowy.");
                    return false;
                }
                if (Convert.ToDouble(Distance) > 40000)
                {
                    MessageBox.Show("Dystans jest za duży.");
                    return false;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Niepoprawne dane w polu \"Dystans trasy\"");
                return false;
            }
            //
            //hours validation
            //
            try
            {
                if (Hours == "") Hours = "0";

                if (Convert.ToDouble(Hours) < 0)
                {
                    MessageBox.Show("Ilość godzin nie może być ujemna.");
                    return false;
                }
                if (Convert.ToDouble(Hours) > 4500)
                {
                    MessageBox.Show("Ilość godzin jest za duża.");
                    return false;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Niepoprawne dane w polu \"Ilość godzin\"");
                return false;
            }

            //
            //minutes validation
            //
            try
            {
                if (Minutes == "") Minutes = "0";

                if (Convert.ToDouble(Minutes) > 59)
                {
                    MessageBox.Show("Ilość minut nie może być większa niż 59.");
                    return false;
                }
                if (Convert.ToDouble(Minutes) < 0)
                {
                    MessageBox.Show("Ilość minut nie może być ujemna.");
                    return false;
                }
                if (Convert.ToDouble(Minutes) == 0 && Convert.ToDouble(Hours) == 0)
                {
                    MessageBox.Show("Całkowity czas nie może być równy zero.");
                    return false;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Niepoprawne dane w polu \"Ilość minut\"");
                return false;
            }

            //checks if average speed is bigger than 50 km/h
            if(Math.Round(3.6 * 1000 * Convert.ToDouble(Distance) / (3600 * Convert.ToInt32(Hours) + Convert.ToInt32(Minutes)), 2) > 50)
            {
                if(Math.Round(3.6 * 1000 * Convert.ToDouble(Distance) / (3600 * Convert.ToInt32(Hours) + Convert.ToInt32(Minutes)), 2) > 200)
                {
                    MessageBox.Show("Twoja prędkość średnia nie może być większa niż 200 km/h");
                    return false;
                }
                DialogResult dialogResult = MessageBox.Show("Czy napewno dane sa poprawne? Twoja prędkość średnia to ponad 50 km/h", "Uwaga", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.No) return false;
            }

            //
            //elevation gain validation
            //
            try
            {
                if (ElevationGain == "") ElevationGain = "0";
            

                if (Convert.ToInt32(ElevationGain) > 9279 || Convert.ToInt32(ElevationGain) < -9279)
                {
                    MessageBox.Show("Nie istnieje na Ziemi miejsce o takim przewyższeniu. \nWpisz poprawne dane w polu \"Przewyższenie\".");
                    return false;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Niepoprawne dane w polu \"Przewyższenie\"");
                return false;
            }

            //
            //days validation
            //
            //checks if day is a number in range of 1-31 and if day textbox isn't empty
            try
            {
                if (Convert.ToInt32(Day) <= 0 || Convert.ToInt32(Day) > 31 || Day == "") throw new Exception();
            }
            catch (Exception)
            {
                if (Day == "") MessageBox.Show("Wprowadź dzień.");
                else MessageBox.Show("Niepoprawny dzień. Wprowadź wartość z przedziału 1-31");
                return false;
            }

            //
            //months validation
            //
            //checks if month is a number in range of 1-12 and if month textbox isn't empty
            try
            {
                if (Convert.ToInt32(Month) < 1 || Convert.ToInt32(Month) > 12 || Month == "") throw new Exception();
                if (Convert.ToInt32(Month) == 2 && Convert.ToInt32(Day) > 29)
                {
                    MessageBox.Show("Ten miesiąc nie ma tylu dni.");
                    return false;
                }
            }
            catch (Exception)
            {
                if (Month == "") MessageBox.Show("Wprowadź miesiąc");
                else MessageBox.Show("Niepoprawny miesiąc. Wprowadź wartość z przedziału 1-12");
                return false;
            }

            //
            //year validation
            //
            //checks if year is a number in range of 2020-2100 and if year textbox isn't empty
            try
            {
                if (Convert.ToInt32(Year) < 2020 || Convert.ToInt32(Year) > 2100 || Year == "") throw new Exception();
            }
            catch (Exception)
            {
                if (Year == "") MessageBox.Show("Wprowadź rok");
                else MessageBox.Show("Niepoprawny rok. Wprowadź rok z przedziału 2020-2100");
                return false;
            }

            //
            //number of days in month validation
            //
            try
            {
                //if a day value is 29, 30 or 31 check if chosen month has correct amount of days
                switch (Convert.ToInt32(Day))
                {
                    //if day value is 29, check if year value is correct or isn't empty, then check if year is a leap year
                    case 29:
                        if (!((Convert.ToInt32(Year) % 4 == 0 && Convert.ToInt32(Year) % 100 != 0) || Convert.ToInt32(Year) % 400 == 0))
                        {
                            MessageBox.Show("Ten miesiąc w tym roku nie ma tylu dni.");
                            return false;
                        }
                        break;

                    //if a day value is 30, check if month isn't february, because any other month has at least 30 days
                    case 30:
                        if (Convert.ToInt32(Month) == 2)
                        {
                            MessageBox.Show("Ten miesiąc nie ma tylu dni.");
                            return false;
                        }
                        break;

                    //if a day value is 31, check if chosen month has 31 days
                    case 31:
                        if (Convert.ToInt32(Month) == 2 || Convert.ToInt32(Month) == 4 || Convert.ToInt32(Month) == 6 || Convert.ToInt32(Month) == 9 || Convert.ToInt32(Month) == 11)
                        {
                            MessageBox.Show("Ten miesiąc nie ma tylu dni.");
                            return false;
                        }
                        break;

                    default:
                        break;
                }
            }

            //if unknown error exists, show its message
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }

            //if none of validations returns false, add new trail and return true
            TrailsManager.AddTrail(new Trail(Convert.ToDouble(Distance), Convert.ToInt32(Hours), Convert.ToInt32(Minutes), Convert.ToInt32(ElevationGain), Name, Description, Convert.ToInt32(Day), Convert.ToInt32(Month), Convert.ToInt32(Year)));
            return true;
        }
    }
}
