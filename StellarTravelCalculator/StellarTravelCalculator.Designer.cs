namespace STC
{
    partial class StellarTravelCalculator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StellarTravelCalculator));
            this.monthsName = new System.Windows.Forms.TextBox();
            this.earthName = new System.Windows.Forms.TextBox();
            this.earthCurDeg = new System.Windows.Forms.TextBox();
            this.monthsPassed = new System.Windows.Forms.NumericUpDown();
            this.mercuryCurDeg = new System.Windows.Forms.TextBox();
            this.mercuryName = new System.Windows.Forms.TextBox();
            this.venusCurDeg = new System.Windows.Forms.TextBox();
            this.venusName = new System.Windows.Forms.TextBox();
            this.marsCurDeg = new System.Windows.Forms.TextBox();
            this.marsName = new System.Windows.Forms.TextBox();
            this.ceresCurDeg = new System.Windows.Forms.TextBox();
            this.ceresName = new System.Windows.Forms.TextBox();
            this.jupiterCurDeg = new System.Windows.Forms.TextBox();
            this.jupiterName = new System.Windows.Forms.TextBox();
            this.erisCurDeg = new System.Windows.Forms.TextBox();
            this.erisName = new System.Windows.Forms.TextBox();
            this.plutoCurDeg = new System.Windows.Forms.TextBox();
            this.plutoName = new System.Windows.Forms.TextBox();
            this.neptuneCurDeg = new System.Windows.Forms.TextBox();
            this.neptuneName = new System.Windows.Forms.TextBox();
            this.saturnCurDeg = new System.Windows.Forms.TextBox();
            this.saturnName = new System.Windows.Forms.TextBox();
            this.uranusCurDeg = new System.Windows.Forms.TextBox();
            this.uranusName = new System.Windows.Forms.TextBox();
            this.planetOne = new System.Windows.Forms.ComboBox();
            this.planetTwo = new System.Windows.Forms.ComboBox();
            this.distanceVal = new System.Windows.Forms.TextBox();
            this.distanceBetween = new System.Windows.Forms.TextBox();
            this.warpName = new System.Windows.Forms.TextBox();
            this.fuelName = new System.Windows.Forms.TextBox();
            this.timeName = new System.Windows.Forms.TextBox();
            this.fuelTotalVal = new System.Windows.Forms.TextBox();
            this.timeVal = new System.Windows.Forms.TextBox();
            this.weightName = new System.Windows.Forms.TextBox();
            this.warpType = new System.Windows.Forms.NumericUpDown();
            this.departureName = new System.Windows.Forms.TextBox();
            this.arrivalName = new System.Windows.Forms.TextBox();
            this.weightVal = new System.Windows.Forms.NumericUpDown();
            this.calcButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.monthsPassed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warpType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weightVal)).BeginInit();
            this.SuspendLayout();
            // 
            // monthsName
            // 
            this.monthsName.Location = new System.Drawing.Point(12, 12);
            this.monthsName.Name = "monthsName";
            this.monthsName.ReadOnly = true;
            this.monthsName.Size = new System.Drawing.Size(79, 20);
            this.monthsName.TabIndex = 3;
            this.monthsName.Text = "Months Passed";
            // 
            // earthName
            // 
            this.earthName.Location = new System.Drawing.Point(12, 90);
            this.earthName.Name = "earthName";
            this.earthName.ReadOnly = true;
            this.earthName.Size = new System.Drawing.Size(79, 20);
            this.earthName.TabIndex = 5;
            this.earthName.Text = "Earth";
            // 
            // earthCurDeg
            // 
            this.earthCurDeg.Location = new System.Drawing.Point(97, 90);
            this.earthCurDeg.Name = "earthCurDeg";
            this.earthCurDeg.ReadOnly = true;
            this.earthCurDeg.Size = new System.Drawing.Size(46, 20);
            this.earthCurDeg.TabIndex = 7;
            this.earthCurDeg.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // monthsPassed
            // 
            this.monthsPassed.Location = new System.Drawing.Point(97, 12);
            this.monthsPassed.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.monthsPassed.Name = "monthsPassed";
            this.monthsPassed.Size = new System.Drawing.Size(46, 20);
            this.monthsPassed.TabIndex = 9;
            this.monthsPassed.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.monthsPassed.ValueChanged += new System.EventHandler(this.monthsPassed_ValueChanged);
            // 
            // mercuryCurDeg
            // 
            this.mercuryCurDeg.Location = new System.Drawing.Point(97, 38);
            this.mercuryCurDeg.Name = "mercuryCurDeg";
            this.mercuryCurDeg.ReadOnly = true;
            this.mercuryCurDeg.Size = new System.Drawing.Size(46, 20);
            this.mercuryCurDeg.TabIndex = 12;
            this.mercuryCurDeg.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // mercuryName
            // 
            this.mercuryName.Location = new System.Drawing.Point(12, 38);
            this.mercuryName.Name = "mercuryName";
            this.mercuryName.ReadOnly = true;
            this.mercuryName.Size = new System.Drawing.Size(79, 20);
            this.mercuryName.TabIndex = 10;
            this.mercuryName.Text = "Mercury";
            // 
            // venusCurDeg
            // 
            this.venusCurDeg.Location = new System.Drawing.Point(97, 64);
            this.venusCurDeg.Name = "venusCurDeg";
            this.venusCurDeg.ReadOnly = true;
            this.venusCurDeg.Size = new System.Drawing.Size(46, 20);
            this.venusCurDeg.TabIndex = 16;
            this.venusCurDeg.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // venusName
            // 
            this.venusName.Location = new System.Drawing.Point(12, 64);
            this.venusName.Name = "venusName";
            this.venusName.ReadOnly = true;
            this.venusName.Size = new System.Drawing.Size(79, 20);
            this.venusName.TabIndex = 14;
            this.venusName.Text = "Venus";
            // 
            // marsCurDeg
            // 
            this.marsCurDeg.Location = new System.Drawing.Point(97, 116);
            this.marsCurDeg.Name = "marsCurDeg";
            this.marsCurDeg.ReadOnly = true;
            this.marsCurDeg.Size = new System.Drawing.Size(46, 20);
            this.marsCurDeg.TabIndex = 20;
            this.marsCurDeg.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // marsName
            // 
            this.marsName.Location = new System.Drawing.Point(12, 116);
            this.marsName.Name = "marsName";
            this.marsName.ReadOnly = true;
            this.marsName.Size = new System.Drawing.Size(79, 20);
            this.marsName.TabIndex = 18;
            this.marsName.Text = "Mars";
            // 
            // ceresCurDeg
            // 
            this.ceresCurDeg.Location = new System.Drawing.Point(97, 142);
            this.ceresCurDeg.Name = "ceresCurDeg";
            this.ceresCurDeg.ReadOnly = true;
            this.ceresCurDeg.Size = new System.Drawing.Size(46, 20);
            this.ceresCurDeg.TabIndex = 24;
            this.ceresCurDeg.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ceresName
            // 
            this.ceresName.Location = new System.Drawing.Point(12, 142);
            this.ceresName.Name = "ceresName";
            this.ceresName.ReadOnly = true;
            this.ceresName.Size = new System.Drawing.Size(79, 20);
            this.ceresName.TabIndex = 22;
            this.ceresName.Text = "Ceres";
            // 
            // jupiterCurDeg
            // 
            this.jupiterCurDeg.Location = new System.Drawing.Point(97, 168);
            this.jupiterCurDeg.Name = "jupiterCurDeg";
            this.jupiterCurDeg.ReadOnly = true;
            this.jupiterCurDeg.Size = new System.Drawing.Size(46, 20);
            this.jupiterCurDeg.TabIndex = 28;
            this.jupiterCurDeg.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // jupiterName
            // 
            this.jupiterName.Location = new System.Drawing.Point(12, 168);
            this.jupiterName.Name = "jupiterName";
            this.jupiterName.ReadOnly = true;
            this.jupiterName.Size = new System.Drawing.Size(79, 20);
            this.jupiterName.TabIndex = 26;
            this.jupiterName.Text = "Jupiter";
            // 
            // erisCurDeg
            // 
            this.erisCurDeg.Location = new System.Drawing.Point(97, 298);
            this.erisCurDeg.Name = "erisCurDeg";
            this.erisCurDeg.ReadOnly = true;
            this.erisCurDeg.Size = new System.Drawing.Size(46, 20);
            this.erisCurDeg.TabIndex = 48;
            this.erisCurDeg.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // erisName
            // 
            this.erisName.Location = new System.Drawing.Point(12, 298);
            this.erisName.Name = "erisName";
            this.erisName.ReadOnly = true;
            this.erisName.Size = new System.Drawing.Size(79, 20);
            this.erisName.TabIndex = 46;
            this.erisName.Text = "Eris";
            // 
            // plutoCurDeg
            // 
            this.plutoCurDeg.Location = new System.Drawing.Point(97, 272);
            this.plutoCurDeg.Name = "plutoCurDeg";
            this.plutoCurDeg.ReadOnly = true;
            this.plutoCurDeg.Size = new System.Drawing.Size(46, 20);
            this.plutoCurDeg.TabIndex = 44;
            this.plutoCurDeg.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // plutoName
            // 
            this.plutoName.Location = new System.Drawing.Point(12, 272);
            this.plutoName.Name = "plutoName";
            this.plutoName.ReadOnly = true;
            this.plutoName.Size = new System.Drawing.Size(79, 20);
            this.plutoName.TabIndex = 42;
            this.plutoName.Text = "Pluto";
            // 
            // neptuneCurDeg
            // 
            this.neptuneCurDeg.Location = new System.Drawing.Point(97, 246);
            this.neptuneCurDeg.Name = "neptuneCurDeg";
            this.neptuneCurDeg.ReadOnly = true;
            this.neptuneCurDeg.Size = new System.Drawing.Size(46, 20);
            this.neptuneCurDeg.TabIndex = 40;
            this.neptuneCurDeg.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // neptuneName
            // 
            this.neptuneName.Location = new System.Drawing.Point(12, 246);
            this.neptuneName.Name = "neptuneName";
            this.neptuneName.ReadOnly = true;
            this.neptuneName.Size = new System.Drawing.Size(79, 20);
            this.neptuneName.TabIndex = 38;
            this.neptuneName.Text = "Neptune";
            // 
            // saturnCurDeg
            // 
            this.saturnCurDeg.Location = new System.Drawing.Point(97, 194);
            this.saturnCurDeg.Name = "saturnCurDeg";
            this.saturnCurDeg.ReadOnly = true;
            this.saturnCurDeg.Size = new System.Drawing.Size(46, 20);
            this.saturnCurDeg.TabIndex = 36;
            this.saturnCurDeg.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // saturnName
            // 
            this.saturnName.Location = new System.Drawing.Point(12, 194);
            this.saturnName.Name = "saturnName";
            this.saturnName.ReadOnly = true;
            this.saturnName.Size = new System.Drawing.Size(79, 20);
            this.saturnName.TabIndex = 34;
            this.saturnName.Text = "Saturn";
            // 
            // uranusCurDeg
            // 
            this.uranusCurDeg.Location = new System.Drawing.Point(97, 220);
            this.uranusCurDeg.Name = "uranusCurDeg";
            this.uranusCurDeg.ReadOnly = true;
            this.uranusCurDeg.Size = new System.Drawing.Size(46, 20);
            this.uranusCurDeg.TabIndex = 32;
            this.uranusCurDeg.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // uranusName
            // 
            this.uranusName.Location = new System.Drawing.Point(12, 220);
            this.uranusName.Name = "uranusName";
            this.uranusName.ReadOnly = true;
            this.uranusName.Size = new System.Drawing.Size(79, 20);
            this.uranusName.TabIndex = 30;
            this.uranusName.Text = "Uranus";
            // 
            // planetOne
            // 
            this.planetOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.planetOne.FormattingEnabled = true;
            this.planetOne.Items.AddRange(new object[] {
            "Mercury",
            "Venus",
            "Earth",
            "Mars",
            "Ceres",
            "Jupiter",
            "Saturn",
            "Uranus",
            "Neptune",
            "Pluto",
            "Eris"});
            this.planetOne.Location = new System.Drawing.Point(233, 12);
            this.planetOne.Name = "planetOne";
            this.planetOne.Size = new System.Drawing.Size(99, 20);
            this.planetOne.TabIndex = 50;
            // 
            // planetTwo
            // 
            this.planetTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.planetTwo.FormattingEnabled = true;
            this.planetTwo.Items.AddRange(new object[] {
            "Mercury",
            "Venus",
            "Earth",
            "Mars",
            "Ceres",
            "Jupiter",
            "Saturn",
            "Uranus",
            "Neptune",
            "Pluto",
            "Eris"});
            this.planetTwo.Location = new System.Drawing.Point(233, 38);
            this.planetTwo.Name = "planetTwo";
            this.planetTwo.Size = new System.Drawing.Size(99, 20);
            this.planetTwo.TabIndex = 51;
            // 
            // distanceVal
            // 
            this.distanceVal.Location = new System.Drawing.Point(288, 64);
            this.distanceVal.Name = "distanceVal";
            this.distanceVal.ReadOnly = true;
            this.distanceVal.Size = new System.Drawing.Size(44, 20);
            this.distanceVal.TabIndex = 52;
            this.distanceVal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // distanceBetween
            // 
            this.distanceBetween.Location = new System.Drawing.Point(163, 64);
            this.distanceBetween.Name = "distanceBetween";
            this.distanceBetween.ReadOnly = true;
            this.distanceBetween.Size = new System.Drawing.Size(119, 20);
            this.distanceBetween.TabIndex = 53;
            this.distanceBetween.Text = "Distance (AU)";
            // 
            // warpName
            // 
            this.warpName.Location = new System.Drawing.Point(163, 90);
            this.warpName.Name = "warpName";
            this.warpName.ReadOnly = true;
            this.warpName.Size = new System.Drawing.Size(119, 20);
            this.warpName.TabIndex = 56;
            this.warpName.Text = "Warp Drive Type";
            // 
            // fuelName
            // 
            this.fuelName.Location = new System.Drawing.Point(163, 168);
            this.fuelName.Name = "fuelName";
            this.fuelName.ReadOnly = true;
            this.fuelName.Size = new System.Drawing.Size(119, 20);
            this.fuelName.TabIndex = 57;
            this.fuelName.Text = "Fuel Requirement (Ton)";
            // 
            // timeName
            // 
            this.timeName.Location = new System.Drawing.Point(163, 142);
            this.timeName.Name = "timeName";
            this.timeName.ReadOnly = true;
            this.timeName.Size = new System.Drawing.Size(119, 20);
            this.timeName.TabIndex = 58;
            this.timeName.Text = "Travel Time (Days)";
            // 
            // fuelTotalVal
            // 
            this.fuelTotalVal.Location = new System.Drawing.Point(288, 168);
            this.fuelTotalVal.Name = "fuelTotalVal";
            this.fuelTotalVal.ReadOnly = true;
            this.fuelTotalVal.Size = new System.Drawing.Size(44, 20);
            this.fuelTotalVal.TabIndex = 59;
            this.fuelTotalVal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // timeVal
            // 
            this.timeVal.Location = new System.Drawing.Point(288, 142);
            this.timeVal.Name = "timeVal";
            this.timeVal.ReadOnly = true;
            this.timeVal.Size = new System.Drawing.Size(44, 20);
            this.timeVal.TabIndex = 60;
            this.timeVal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // weightName
            // 
            this.weightName.Location = new System.Drawing.Point(163, 116);
            this.weightName.Name = "weightName";
            this.weightName.ReadOnly = true;
            this.weightName.Size = new System.Drawing.Size(119, 20);
            this.weightName.TabIndex = 61;
            this.weightName.Text = "Ship Weight (Ton)";
            // 
            // warpType
            // 
            this.warpType.Location = new System.Drawing.Point(288, 90);
            this.warpType.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.warpType.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.warpType.Name = "warpType";
            this.warpType.Size = new System.Drawing.Size(44, 20);
            this.warpType.TabIndex = 63;
            this.warpType.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.warpType.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // departureName
            // 
            this.departureName.Location = new System.Drawing.Point(163, 12);
            this.departureName.Name = "departureName";
            this.departureName.ReadOnly = true;
            this.departureName.Size = new System.Drawing.Size(64, 20);
            this.departureName.TabIndex = 76;
            this.departureName.Text = "Departure";
            // 
            // arrivalName
            // 
            this.arrivalName.Location = new System.Drawing.Point(163, 38);
            this.arrivalName.Name = "arrivalName";
            this.arrivalName.ReadOnly = true;
            this.arrivalName.Size = new System.Drawing.Size(64, 20);
            this.arrivalName.TabIndex = 77;
            this.arrivalName.Text = "Arrival";
            // 
            // weightVal
            // 
            this.weightVal.Location = new System.Drawing.Point(288, 116);
            this.weightVal.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.weightVal.Name = "weightVal";
            this.weightVal.Size = new System.Drawing.Size(44, 20);
            this.weightVal.TabIndex = 80;
            this.weightVal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // calcButton
            // 
            this.calcButton.Location = new System.Drawing.Point(163, 295);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(169, 23);
            this.calcButton.TabIndex = 81;
            this.calcButton.Text = "Calculate Fields";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // StellarTravelCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 341);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.weightVal);
            this.Controls.Add(this.arrivalName);
            this.Controls.Add(this.departureName);
            this.Controls.Add(this.warpType);
            this.Controls.Add(this.weightName);
            this.Controls.Add(this.timeVal);
            this.Controls.Add(this.fuelTotalVal);
            this.Controls.Add(this.timeName);
            this.Controls.Add(this.fuelName);
            this.Controls.Add(this.warpName);
            this.Controls.Add(this.distanceBetween);
            this.Controls.Add(this.distanceVal);
            this.Controls.Add(this.planetTwo);
            this.Controls.Add(this.planetOne);
            this.Controls.Add(this.erisCurDeg);
            this.Controls.Add(this.erisName);
            this.Controls.Add(this.plutoCurDeg);
            this.Controls.Add(this.plutoName);
            this.Controls.Add(this.neptuneCurDeg);
            this.Controls.Add(this.neptuneName);
            this.Controls.Add(this.saturnCurDeg);
            this.Controls.Add(this.saturnName);
            this.Controls.Add(this.uranusCurDeg);
            this.Controls.Add(this.uranusName);
            this.Controls.Add(this.jupiterCurDeg);
            this.Controls.Add(this.jupiterName);
            this.Controls.Add(this.ceresCurDeg);
            this.Controls.Add(this.ceresName);
            this.Controls.Add(this.marsCurDeg);
            this.Controls.Add(this.marsName);
            this.Controls.Add(this.venusCurDeg);
            this.Controls.Add(this.venusName);
            this.Controls.Add(this.mercuryCurDeg);
            this.Controls.Add(this.mercuryName);
            this.Controls.Add(this.monthsPassed);
            this.Controls.Add(this.earthCurDeg);
            this.Controls.Add(this.earthName);
            this.Controls.Add(this.monthsName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(490, 400);
            this.Name = "StellarTravelCalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TravelCalculator";
            ((System.ComponentModel.ISupportInitialize)(this.monthsPassed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warpType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weightVal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox monthsName;
        private System.Windows.Forms.TextBox earthName;
        private System.Windows.Forms.TextBox earthCurDeg;
        private System.Windows.Forms.NumericUpDown monthsPassed;
        private System.Windows.Forms.TextBox mercuryCurDeg;
        private System.Windows.Forms.TextBox mercuryName;
        private System.Windows.Forms.TextBox venusCurDeg;
        private System.Windows.Forms.TextBox venusName;
        private System.Windows.Forms.TextBox marsCurDeg;
        private System.Windows.Forms.TextBox marsName;
        private System.Windows.Forms.TextBox ceresCurDeg;
        private System.Windows.Forms.TextBox ceresName;
        private System.Windows.Forms.TextBox jupiterCurDeg;
        private System.Windows.Forms.TextBox jupiterName;
        private System.Windows.Forms.TextBox erisCurDeg;
        private System.Windows.Forms.TextBox erisName;
        private System.Windows.Forms.TextBox plutoCurDeg;
        private System.Windows.Forms.TextBox plutoName;
        private System.Windows.Forms.TextBox neptuneCurDeg;
        private System.Windows.Forms.TextBox neptuneName;
        private System.Windows.Forms.TextBox saturnCurDeg;
        private System.Windows.Forms.TextBox saturnName;
        private System.Windows.Forms.TextBox uranusCurDeg;
        private System.Windows.Forms.TextBox uranusName;
        private System.Windows.Forms.ComboBox planetOne;
        private System.Windows.Forms.ComboBox planetTwo;
        private System.Windows.Forms.TextBox distanceVal;
        private System.Windows.Forms.TextBox distanceBetween;
        private System.Windows.Forms.TextBox warpName;
        private System.Windows.Forms.TextBox fuelName;
        private System.Windows.Forms.TextBox timeName;
        private System.Windows.Forms.TextBox fuelTotalVal;
        private System.Windows.Forms.TextBox timeVal;
        private System.Windows.Forms.TextBox weightName;
        private System.Windows.Forms.NumericUpDown warpType;
        private System.Windows.Forms.TextBox departureName;
        private System.Windows.Forms.TextBox arrivalName;
        private System.Windows.Forms.NumericUpDown weightVal;
        private System.Windows.Forms.Button calcButton;
    }
}

