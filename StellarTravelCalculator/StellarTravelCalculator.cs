using System;
using System.Windows.Forms;

namespace STC
{
    public partial class StellarTravelCalculator : Form
    {
        public void saveVal(string valueName, int valueInt, string valueString)
        {
            Properties.Settings settings = Properties.Settings.Default;
            if (valueName == "month")
            {
                settings.defMonthsPassed = valueInt;
            }
            else if (valueName == "departure")
            {
                settings.defDepPlanet = valueString;
            }
            else if (valueName == "arrival")
            {
                settings.defArrPlanet = valueString;
            }
            else if (valueName == "warp")
            {
                settings.defWarpType = valueInt;
            }
            else if (valueName == "weigth")
            {
                settings.defWeight = valueInt;
            }

            settings.Save();
        }

        public StellarTravelCalculator()
        {
            InitializeComponent();

            Properties.Settings settings = Properties.Settings.Default;
            settings.Save();

            if (settings.defMonthsPassed > 0) { monthsPassed.Value = settings.defMonthsPassed; }
            if (!string.IsNullOrWhiteSpace(settings.defDepPlanet)) { planetOne.SelectedItem = settings.defDepPlanet; }
            if (!string.IsNullOrWhiteSpace(settings.defArrPlanet)) { planetTwo.SelectedItem = settings.defArrPlanet; }
            if (settings.defWarpType > 0) { warpType.Value = settings.defWarpType; }
            if (settings.defWeight > 0) { weightVal.Value = settings.defWeight; }

            doCurrentDeg();
        }

        private void monthsPassed_ValueChanged(object sender, EventArgs e)
        {
            doCurrentDeg();
        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            saveVal("month", Convert.ToInt32(monthsPassed.Value), "A");
            saveVal("departure", 0, planetOne.SelectedItem.ToString());
            saveVal("arrival", 0, planetTwo.SelectedItem.ToString());
            saveVal("warp", Convert.ToInt32(warpType.Value), "A");
            saveVal("weigth", Convert.ToInt32(weightVal.Value), "A");
            if (planetOne.SelectedIndex >= 0 && planetTwo.SelectedIndex >= 0 && Convert.ToDouble(monthsPassed.Value) >= 0) { doDistanceCalc(); } else { }
            if (!string.IsNullOrWhiteSpace(distanceVal.Text.ToString()) && !string.IsNullOrWhiteSpace(weightVal.Value.ToString())) { doTravelCalc(); }
        }

        public void doCurrentDeg()
        {
            double mercuryDeg = 34.02 + (122.8 * Convert.ToDouble(monthsPassed.Value));
            while (mercuryDeg > 360) { mercuryDeg = mercuryDeg - 360; }
            mercuryCurDeg.Text = Math.Round(mercuryDeg, 2).ToString();

            double venusDeg = 243.12 + (48.7 * Convert.ToDouble(monthsPassed.Value));
            while (venusDeg > 360) { venusDeg = venusDeg - 360; }
            venusCurDeg.Text = Math.Round(venusDeg, 2).ToString();

            double earthDeg = 144.93 + (29.6 * Convert.ToDouble(monthsPassed.Value));
            while (earthDeg > 360) { earthDeg = earthDeg - 360; }
            earthCurDeg.Text = Math.Round(earthDeg, 2).ToString();

            double marsDeg = 65.29 + (15.7 * Convert.ToDouble(monthsPassed.Value));
            while (marsDeg > 360) { marsDeg = marsDeg - 360; }
            marsCurDeg.Text = Math.Round(marsDeg, 2).ToString();

            double ceresDeg = 42.15 + (6.5 * Convert.ToDouble(monthsPassed.Value));
            while (ceresDeg > 360) { ceresDeg = ceresDeg - 360; }
            ceresCurDeg.Text = Math.Round(ceresDeg, 2).ToString();

            double jupiterDeg = 12.09 + (2.5 * Convert.ToDouble(monthsPassed.Value));
            while (jupiterDeg > 360) { jupiterDeg = jupiterDeg - 360; }
            jupiterCurDeg.Text = Math.Round(jupiterDeg, 2).ToString();

            double saturnDeg = 45.46 + (1.0 * Convert.ToDouble(monthsPassed.Value));
            while (saturnDeg > 360) { saturnDeg = saturnDeg - 360; }
            saturnCurDeg.Text = Math.Round(saturnDeg, 2).ToString();

            double uranusDeg = 127.43 + (0.3 * Convert.ToDouble(monthsPassed.Value));
            while (uranusDeg > 360) { uranusDeg = uranusDeg - 360; }
            uranusCurDeg.Text = Math.Round(uranusDeg, 2).ToString();

            double neptuneDeg = 216.71 + (0.17 * Convert.ToDouble(monthsPassed.Value));
            while (neptuneDeg > 360) { neptuneDeg = neptuneDeg - 360; }
            neptuneCurDeg.Text = Math.Round(neptuneDeg, 2).ToString();

            double plutoDeg = 108.39 + (0.09 * Convert.ToDouble(monthsPassed.Value));
            while (plutoDeg > 360) { plutoDeg = plutoDeg - 360; }
            plutoCurDeg.Text = Math.Round(plutoDeg, 2).ToString();

            double erisDeg = 210.95 + (0.03 * Convert.ToDouble(monthsPassed.Value));
            while (erisDeg > 360) { erisDeg = erisDeg - 360; }
            erisCurDeg.Text = Math.Round(erisDeg, 2).ToString();
        }

        public void doDistanceCalc()
        {
            double firstDist = 10;
            double firstDeg = 10;
            double secondDist = 10;
            double secondDeg = 10;

            var pOItem = planetOne.SelectedItem.ToString();
            if (pOItem == "Mercury") { firstDist = 0.387; firstDeg = Convert.ToDouble(mercuryCurDeg.Text); }
            else if (pOItem == "Venus") { firstDist = 0.723; firstDeg = Convert.ToDouble(venusCurDeg.Text); }
            else if (pOItem == "Earth") { firstDist = 1; firstDeg = Convert.ToDouble(earthCurDeg.Text); }
            else if (pOItem == "Mars") { firstDist = 1.524; firstDeg = Convert.ToDouble(marsCurDeg.Text); }
            else if (pOItem == "Ceres") { firstDist = 2.762; firstDeg = Convert.ToDouble(ceresCurDeg.Text); }
            else if (pOItem == "Jupiter") { firstDist = 5.203; firstDeg = Convert.ToDouble(jupiterCurDeg.Text); }
            else if (pOItem == "Saturn") { firstDist = 9.523; firstDeg = Convert.ToDouble(saturnCurDeg.Text); }
            else if (pOItem == "Uranus") { firstDist = 19.208; firstDeg = Convert.ToDouble(uranusCurDeg.Text); }
            else if (pOItem == "Neptune") { firstDist = 30.087; firstDeg = Convert.ToDouble(neptuneCurDeg.Text); }
            else if (pOItem == "Pluto") { firstDist = 39.746; firstDeg = Convert.ToDouble(plutoCurDeg.Text); }
            else if (pOItem == "Eris") { firstDist = 67.781; firstDeg = Convert.ToDouble(erisCurDeg.Text); }
            else { }


            var pTItem = planetTwo.SelectedItem.ToString();
            if (pTItem == "Mercury") { secondDist = 0.387; secondDeg = Convert.ToDouble(mercuryCurDeg.Text); }
            else if (pTItem == "Venus") { secondDist = 0.723; secondDeg = Convert.ToDouble(venusCurDeg.Text); }
            else if (pTItem == "Earth") { secondDist = 1; secondDeg = Convert.ToDouble(earthCurDeg.Text); }
            else if (pTItem == "Mars") { secondDist = 1.524; secondDeg = Convert.ToDouble(marsCurDeg.Text); }
            else if (pTItem == "Ceres") { secondDist = 2.762; secondDeg = Convert.ToDouble(ceresCurDeg.Text); }
            else if (pTItem == "Jupiter") { secondDist = 5.203; secondDeg = Convert.ToDouble(jupiterCurDeg.Text); }
            else if (pTItem == "Saturn") { secondDist = 9.523; secondDeg = Convert.ToDouble(saturnCurDeg.Text); }
            else if (pTItem == "Uranus") { secondDist = 19.208; secondDeg = Convert.ToDouble(uranusCurDeg.Text); }
            else if (pTItem == "Neptune") { secondDist = 30.087; secondDeg = Convert.ToDouble(neptuneCurDeg.Text); }
            else if (pTItem == "Pluto") { secondDist = 39.746; secondDeg = Convert.ToDouble(plutoCurDeg.Text); }
            else if (pTItem == "Eris") { secondDist = 67.781; secondDeg = Convert.ToDouble(erisCurDeg.Text); }
            else { }

            double distVal = (firstDist * firstDist) + (secondDist * secondDist) - (2 * firstDist * secondDist * Math.Cos(Math.Abs((firstDeg - secondDeg) * Math.PI / 180)));
            distanceVal.Text = Math.Round(distVal, 1).ToString();

            if (!string.IsNullOrWhiteSpace(weightVal.Value.ToString())) { doTravelCalc(); }
        }

        public void doTravelCalc()
        {
            double distance = Convert.ToDouble(distanceVal.Text);
            double weight = Convert.ToDouble(weightVal.Value);
            double warptype = Convert.ToDouble(warpType.Value);

            double travTime = Math.Round(6 + (distance / (warptype + 2)), 1);
            timeVal.Text = travTime.ToString();
            fuelTotalVal.Text = Math.Round(weight * travTime * 0.01).ToString();
        }
    }
}

//MessageBox.Show(settings.defMonthsPassed.ToString(), "Error Title", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);