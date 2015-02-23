namespace Laboratory_Work_4
{
	partial class Form1
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
			this.button1 = new System.Windows.Forms.Button();
			this.groupBox_Material = new System.Windows.Forms.GroupBox();
			this.groupBox_WearType = new System.Windows.Forms.GroupBox();
			this.groupBox_Color = new System.Windows.Forms.GroupBox();
			this.groupBox_Size = new System.Windows.Forms.GroupBox();
			this.radioButton_SizeXXS = new System.Windows.Forms.RadioButton();
			this.radioButton_SizeXS = new System.Windows.Forms.RadioButton();
			this.radioButton_SizeS = new System.Windows.Forms.RadioButton();
			this.radioButton_SizeM = new System.Windows.Forms.RadioButton();
			this.radioButton_SizeL = new System.Windows.Forms.RadioButton();
			this.radioButton_SizeXL = new System.Windows.Forms.RadioButton();
			this.radioButton_SizeXXL = new System.Windows.Forms.RadioButton();
			this.radioButton_TypeOutWear = new System.Windows.Forms.RadioButton();
			this.radioButton_TypeUnderWear = new System.Windows.Forms.RadioButton();
			this.radioButton_MaterialLinen = new System.Windows.Forms.RadioButton();
			this.radioButton_MaterialCotton = new System.Windows.Forms.RadioButton();
			this.radioButton_MaterialSilk = new System.Windows.Forms.RadioButton();
			this.radioButton_MaterialWool = new System.Windows.Forms.RadioButton();
			this.radioButton_ColorGreen = new System.Windows.Forms.RadioButton();
			this.radioButton_ColorRed = new System.Windows.Forms.RadioButton();
			this.radioButton_ColorBlack = new System.Windows.Forms.RadioButton();
			this.radioButton_ColorWhite = new System.Windows.Forms.RadioButton();
			this.radioButton_ColorBlue = new System.Windows.Forms.RadioButton();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.radioButton_Constructor1 = new System.Windows.Forms.RadioButton();
			this.radioButton_Constructor2 = new System.Windows.Forms.RadioButton();
			this.groupBox_UnderWear = new System.Windows.Forms.GroupBox();
			this.checkBox_Pants = new System.Windows.Forms.CheckBox();
			this.checkBox_PantsPockets = new System.Windows.Forms.CheckBox();
			this.checkBox_PantsBelt = new System.Windows.Forms.CheckBox();
			this.groupBox_Material.SuspendLayout();
			this.groupBox_WearType.SuspendLayout();
			this.groupBox_Color.SuspendLayout();
			this.groupBox_Size.SuspendLayout();
			this.groupBox5.SuspendLayout();
			this.groupBox_UnderWear.SuspendLayout();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Lime;
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button1.Location = new System.Drawing.Point(105, 445);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(181, 133);
			this.button1.TabIndex = 0;
			this.button1.Text = "Big Red Button";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// groupBox_Material
			// 
			this.groupBox_Material.AutoSize = true;
			this.groupBox_Material.Controls.Add(this.radioButton_MaterialWool);
			this.groupBox_Material.Controls.Add(this.radioButton_MaterialSilk);
			this.groupBox_Material.Controls.Add(this.radioButton_MaterialCotton);
			this.groupBox_Material.Controls.Add(this.radioButton_MaterialLinen);
			this.groupBox_Material.Enabled = false;
			this.groupBox_Material.Location = new System.Drawing.Point(12, 109);
			this.groupBox_Material.Name = "groupBox_Material";
			this.groupBox_Material.Size = new System.Drawing.Size(87, 114);
			this.groupBox_Material.TabIndex = 1;
			this.groupBox_Material.TabStop = false;
			this.groupBox_Material.Text = "Материал";
			// 
			// groupBox_WearType
			// 
			this.groupBox_WearType.AutoSize = true;
			this.groupBox_WearType.Controls.Add(this.radioButton_TypeUnderWear);
			this.groupBox_WearType.Controls.Add(this.radioButton_TypeOutWear);
			this.groupBox_WearType.Enabled = false;
			this.groupBox_WearType.Location = new System.Drawing.Point(12, 12);
			this.groupBox_WearType.Name = "groupBox_WearType";
			this.groupBox_WearType.Size = new System.Drawing.Size(87, 91);
			this.groupBox_WearType.TabIndex = 2;
			this.groupBox_WearType.TabStop = false;
			this.groupBox_WearType.Text = "Тип";
			// 
			// groupBox_Color
			// 
			this.groupBox_Color.AutoSize = true;
			this.groupBox_Color.Controls.Add(this.radioButton_ColorBlue);
			this.groupBox_Color.Controls.Add(this.radioButton_ColorGreen);
			this.groupBox_Color.Controls.Add(this.radioButton_ColorWhite);
			this.groupBox_Color.Controls.Add(this.radioButton_ColorRed);
			this.groupBox_Color.Controls.Add(this.radioButton_ColorBlack);
			this.groupBox_Color.Enabled = false;
			this.groupBox_Color.Location = new System.Drawing.Point(12, 441);
			this.groupBox_Color.Name = "groupBox_Color";
			this.groupBox_Color.Size = new System.Drawing.Size(87, 137);
			this.groupBox_Color.TabIndex = 3;
			this.groupBox_Color.TabStop = false;
			this.groupBox_Color.Text = "Цвет";
			// 
			// groupBox_Size
			// 
			this.groupBox_Size.AutoSize = true;
			this.groupBox_Size.Controls.Add(this.radioButton_SizeXXL);
			this.groupBox_Size.Controls.Add(this.radioButton_SizeXL);
			this.groupBox_Size.Controls.Add(this.radioButton_SizeL);
			this.groupBox_Size.Controls.Add(this.radioButton_SizeM);
			this.groupBox_Size.Controls.Add(this.radioButton_SizeS);
			this.groupBox_Size.Controls.Add(this.radioButton_SizeXS);
			this.groupBox_Size.Controls.Add(this.radioButton_SizeXXS);
			this.groupBox_Size.Enabled = false;
			this.groupBox_Size.Location = new System.Drawing.Point(12, 229);
			this.groupBox_Size.Name = "groupBox_Size";
			this.groupBox_Size.Size = new System.Drawing.Size(87, 206);
			this.groupBox_Size.TabIndex = 4;
			this.groupBox_Size.TabStop = false;
			this.groupBox_Size.Text = "Размер";
			// 
			// radioButton_SizeXXS
			// 
			this.radioButton_SizeXXS.AutoSize = true;
			this.radioButton_SizeXXS.Location = new System.Drawing.Point(7, 20);
			this.radioButton_SizeXXS.Name = "radioButton_SizeXXS";
			this.radioButton_SizeXXS.Size = new System.Drawing.Size(46, 17);
			this.radioButton_SizeXXS.TabIndex = 0;
			this.radioButton_SizeXXS.TabStop = true;
			this.radioButton_SizeXXS.Text = "XXS";
			this.radioButton_SizeXXS.UseVisualStyleBackColor = true;
			// 
			// radioButton_SizeXS
			// 
			this.radioButton_SizeXS.AutoSize = true;
			this.radioButton_SizeXS.Location = new System.Drawing.Point(6, 43);
			this.radioButton_SizeXS.Name = "radioButton_SizeXS";
			this.radioButton_SizeXS.Size = new System.Drawing.Size(39, 17);
			this.radioButton_SizeXS.TabIndex = 1;
			this.radioButton_SizeXS.TabStop = true;
			this.radioButton_SizeXS.Text = "XS";
			this.radioButton_SizeXS.UseVisualStyleBackColor = true;
			// 
			// radioButton_SizeS
			// 
			this.radioButton_SizeS.AutoSize = true;
			this.radioButton_SizeS.Location = new System.Drawing.Point(6, 66);
			this.radioButton_SizeS.Name = "radioButton_SizeS";
			this.radioButton_SizeS.Size = new System.Drawing.Size(32, 17);
			this.radioButton_SizeS.TabIndex = 2;
			this.radioButton_SizeS.TabStop = true;
			this.radioButton_SizeS.Text = "S";
			this.radioButton_SizeS.UseVisualStyleBackColor = true;
			// 
			// radioButton_SizeM
			// 
			this.radioButton_SizeM.AutoSize = true;
			this.radioButton_SizeM.Location = new System.Drawing.Point(6, 89);
			this.radioButton_SizeM.Name = "radioButton_SizeM";
			this.radioButton_SizeM.Size = new System.Drawing.Size(34, 17);
			this.radioButton_SizeM.TabIndex = 3;
			this.radioButton_SizeM.TabStop = true;
			this.radioButton_SizeM.Text = "M";
			this.radioButton_SizeM.UseVisualStyleBackColor = true;
			// 
			// radioButton_SizeL
			// 
			this.radioButton_SizeL.AutoSize = true;
			this.radioButton_SizeL.Location = new System.Drawing.Point(6, 112);
			this.radioButton_SizeL.Name = "radioButton_SizeL";
			this.radioButton_SizeL.Size = new System.Drawing.Size(31, 17);
			this.radioButton_SizeL.TabIndex = 4;
			this.radioButton_SizeL.TabStop = true;
			this.radioButton_SizeL.Text = "L";
			this.radioButton_SizeL.UseVisualStyleBackColor = true;
			// 
			// radioButton_SizeXL
			// 
			this.radioButton_SizeXL.AutoSize = true;
			this.radioButton_SizeXL.Location = new System.Drawing.Point(6, 135);
			this.radioButton_SizeXL.Name = "radioButton_SizeXL";
			this.radioButton_SizeXL.Size = new System.Drawing.Size(38, 17);
			this.radioButton_SizeXL.TabIndex = 5;
			this.radioButton_SizeXL.TabStop = true;
			this.radioButton_SizeXL.Text = "XL";
			this.radioButton_SizeXL.UseVisualStyleBackColor = true;
			// 
			// radioButton_SizeXXL
			// 
			this.radioButton_SizeXXL.AutoSize = true;
			this.radioButton_SizeXXL.Location = new System.Drawing.Point(6, 157);
			this.radioButton_SizeXXL.Name = "radioButton_SizeXXL";
			this.radioButton_SizeXXL.Size = new System.Drawing.Size(45, 17);
			this.radioButton_SizeXXL.TabIndex = 6;
			this.radioButton_SizeXXL.TabStop = true;
			this.radioButton_SizeXXL.Text = "XXL";
			this.radioButton_SizeXXL.UseVisualStyleBackColor = true;
			// 
			// radioButton_TypeOutWear
			// 
			this.radioButton_TypeOutWear.AutoSize = true;
			this.radioButton_TypeOutWear.Location = new System.Drawing.Point(6, 19);
			this.radioButton_TypeOutWear.Name = "radioButton_TypeOutWear";
			this.radioButton_TypeOutWear.Size = new System.Drawing.Size(67, 17);
			this.radioButton_TypeOutWear.TabIndex = 0;
			this.radioButton_TypeOutWear.TabStop = true;
			this.radioButton_TypeOutWear.Text = "Верхняя";
			this.radioButton_TypeOutWear.UseVisualStyleBackColor = true;
			// 
			// radioButton_TypeUnderWear
			// 
			this.radioButton_TypeUnderWear.AutoSize = true;
			this.radioButton_TypeUnderWear.Location = new System.Drawing.Point(6, 42);
			this.radioButton_TypeUnderWear.Name = "radioButton_TypeUnderWear";
			this.radioButton_TypeUnderWear.Size = new System.Drawing.Size(65, 17);
			this.radioButton_TypeUnderWear.TabIndex = 1;
			this.radioButton_TypeUnderWear.TabStop = true;
			this.radioButton_TypeUnderWear.Text = "Нижняя";
			this.radioButton_TypeUnderWear.UseVisualStyleBackColor = true;
			// 
			// radioButton_MaterialLinen
			// 
			this.radioButton_MaterialLinen.AutoSize = true;
			this.radioButton_MaterialLinen.Location = new System.Drawing.Point(6, 19);
			this.radioButton_MaterialLinen.Name = "radioButton_MaterialLinen";
			this.radioButton_MaterialLinen.Size = new System.Drawing.Size(45, 17);
			this.radioButton_MaterialLinen.TabIndex = 0;
			this.radioButton_MaterialLinen.TabStop = true;
			this.radioButton_MaterialLinen.Text = "Лён";
			this.radioButton_MaterialLinen.UseVisualStyleBackColor = true;
			// 
			// radioButton_MaterialCotton
			// 
			this.radioButton_MaterialCotton.AutoSize = true;
			this.radioButton_MaterialCotton.Location = new System.Drawing.Point(6, 40);
			this.radioButton_MaterialCotton.Name = "radioButton_MaterialCotton";
			this.radioButton_MaterialCotton.Size = new System.Drawing.Size(62, 17);
			this.radioButton_MaterialCotton.TabIndex = 1;
			this.radioButton_MaterialCotton.TabStop = true;
			this.radioButton_MaterialCotton.Text = "Хлопок";
			this.radioButton_MaterialCotton.UseVisualStyleBackColor = true;
			// 
			// radioButton_MaterialSilk
			// 
			this.radioButton_MaterialSilk.AutoSize = true;
			this.radioButton_MaterialSilk.Location = new System.Drawing.Point(6, 59);
			this.radioButton_MaterialSilk.Name = "radioButton_MaterialSilk";
			this.radioButton_MaterialSilk.Size = new System.Drawing.Size(52, 17);
			this.radioButton_MaterialSilk.TabIndex = 2;
			this.radioButton_MaterialSilk.TabStop = true;
			this.radioButton_MaterialSilk.Text = "Шёлк";
			this.radioButton_MaterialSilk.UseVisualStyleBackColor = true;
			// 
			// radioButton_MaterialWool
			// 
			this.radioButton_MaterialWool.AutoSize = true;
			this.radioButton_MaterialWool.Location = new System.Drawing.Point(6, 78);
			this.radioButton_MaterialWool.Name = "radioButton_MaterialWool";
			this.radioButton_MaterialWool.Size = new System.Drawing.Size(63, 17);
			this.radioButton_MaterialWool.TabIndex = 3;
			this.radioButton_MaterialWool.TabStop = true;
			this.radioButton_MaterialWool.Text = "Шерсть";
			this.radioButton_MaterialWool.UseVisualStyleBackColor = true;
			// 
			// radioButton_ColorGreen
			// 
			this.radioButton_ColorGreen.AutoSize = true;
			this.radioButton_ColorGreen.Location = new System.Drawing.Point(6, 78);
			this.radioButton_ColorGreen.Name = "radioButton_ColorGreen";
			this.radioButton_ColorGreen.Size = new System.Drawing.Size(70, 17);
			this.radioButton_ColorGreen.TabIndex = 7;
			this.radioButton_ColorGreen.TabStop = true;
			this.radioButton_ColorGreen.Text = "Зелёный";
			this.radioButton_ColorGreen.UseVisualStyleBackColor = true;
			// 
			// radioButton_ColorRed
			// 
			this.radioButton_ColorRed.AutoSize = true;
			this.radioButton_ColorRed.Location = new System.Drawing.Point(6, 59);
			this.radioButton_ColorRed.Name = "radioButton_ColorRed";
			this.radioButton_ColorRed.Size = new System.Drawing.Size(70, 17);
			this.radioButton_ColorRed.TabIndex = 6;
			this.radioButton_ColorRed.TabStop = true;
			this.radioButton_ColorRed.Text = "Красный";
			this.radioButton_ColorRed.UseVisualStyleBackColor = true;
			// 
			// radioButton_ColorBlack
			// 
			this.radioButton_ColorBlack.AutoSize = true;
			this.radioButton_ColorBlack.Location = new System.Drawing.Point(6, 40);
			this.radioButton_ColorBlack.Name = "radioButton_ColorBlack";
			this.radioButton_ColorBlack.Size = new System.Drawing.Size(65, 17);
			this.radioButton_ColorBlack.TabIndex = 5;
			this.radioButton_ColorBlack.TabStop = true;
			this.radioButton_ColorBlack.Text = "Чёрный";
			this.radioButton_ColorBlack.UseVisualStyleBackColor = true;
			// 
			// radioButton_ColorWhite
			// 
			this.radioButton_ColorWhite.AutoSize = true;
			this.radioButton_ColorWhite.Location = new System.Drawing.Point(6, 19);
			this.radioButton_ColorWhite.Name = "radioButton_ColorWhite";
			this.radioButton_ColorWhite.Size = new System.Drawing.Size(58, 17);
			this.radioButton_ColorWhite.TabIndex = 4;
			this.radioButton_ColorWhite.TabStop = true;
			this.radioButton_ColorWhite.Text = "Белый";
			this.radioButton_ColorWhite.UseVisualStyleBackColor = true;
			// 
			// radioButton_ColorBlue
			// 
			this.radioButton_ColorBlue.AutoSize = true;
			this.radioButton_ColorBlue.Location = new System.Drawing.Point(6, 101);
			this.radioButton_ColorBlue.Name = "radioButton_ColorBlue";
			this.radioButton_ColorBlue.Size = new System.Drawing.Size(56, 17);
			this.radioButton_ColorBlue.TabIndex = 8;
			this.radioButton_ColorBlue.TabStop = true;
			this.radioButton_ColorBlue.Text = "Синий";
			this.radioButton_ColorBlue.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(105, 128);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(181, 307);
			this.label1.TabIndex = 5;
			this.label1.Text = "Одежда.\r\n\r\nТип:\r\nМатериал:\r\nРазмер:\r\nЦвет:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// groupBox5
			// 
			this.groupBox5.AutoSize = true;
			this.groupBox5.Controls.Add(this.radioButton_Constructor2);
			this.groupBox5.Controls.Add(this.radioButton_Constructor1);
			this.groupBox5.Location = new System.Drawing.Point(108, 12);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(178, 91);
			this.groupBox5.TabIndex = 6;
			this.groupBox5.TabStop = false;
			this.groupBox5.Text = "Конструктор";
			// 
			// radioButton_Constructor1
			// 
			this.radioButton_Constructor1.AutoSize = true;
			this.radioButton_Constructor1.Location = new System.Drawing.Point(6, 19);
			this.radioButton_Constructor1.Name = "radioButton_Constructor1";
			this.radioButton_Constructor1.Size = new System.Drawing.Size(92, 17);
			this.radioButton_Constructor1.TabIndex = 4;
			this.radioButton_Constructor1.TabStop = true;
			this.radioButton_Constructor1.Text = "Стандартный";
			this.radioButton_Constructor1.UseVisualStyleBackColor = true;
			this.radioButton_Constructor1.CheckedChanged += new System.EventHandler(this.radioButton_Constructor1_CheckedChanged);
			// 
			// radioButton_Constructor2
			// 
			this.radioButton_Constructor2.AutoSize = true;
			this.radioButton_Constructor2.Location = new System.Drawing.Point(6, 42);
			this.radioButton_Constructor2.Name = "radioButton_Constructor2";
			this.radioButton_Constructor2.Size = new System.Drawing.Size(122, 17);
			this.radioButton_Constructor2.TabIndex = 5;
			this.radioButton_Constructor2.TabStop = true;
			this.radioButton_Constructor2.Text = "Пользовательский";
			this.radioButton_Constructor2.UseVisualStyleBackColor = true;
			this.radioButton_Constructor2.CheckedChanged += new System.EventHandler(this.radioButton_Constructor2_CheckedChanged);
			// 
			// groupBox_UnderWear
			// 
			this.groupBox_UnderWear.Controls.Add(this.checkBox_PantsBelt);
			this.groupBox_UnderWear.Controls.Add(this.checkBox_PantsPockets);
			this.groupBox_UnderWear.Enabled = false;
			this.groupBox_UnderWear.Location = new System.Drawing.Point(292, 109);
			this.groupBox_UnderWear.Name = "groupBox_UnderWear";
			this.groupBox_UnderWear.Size = new System.Drawing.Size(87, 469);
			this.groupBox_UnderWear.TabIndex = 7;
			this.groupBox_UnderWear.TabStop = false;
			this.groupBox_UnderWear.Text = "UnderWear_Properties";
			// 
			// checkBox_Pants
			// 
			this.checkBox_Pants.AutoSize = true;
			this.checkBox_Pants.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
			this.checkBox_Pants.Enabled = false;
			this.checkBox_Pants.Location = new System.Drawing.Point(312, 54);
			this.checkBox_Pants.Name = "checkBox_Pants";
			this.checkBox_Pants.Size = new System.Drawing.Size(44, 31);
			this.checkBox_Pants.TabIndex = 8;
			this.checkBox_Pants.Text = "Брюки";
			this.checkBox_Pants.UseVisualStyleBackColor = true;
			this.checkBox_Pants.CheckedChanged += new System.EventHandler(this.checkBox_Pants_CheckedChanged);
			// 
			// checkBox_PantsPockets
			// 
			this.checkBox_PantsPockets.AutoSize = true;
			this.checkBox_PantsPockets.Location = new System.Drawing.Point(6, 40);
			this.checkBox_PantsPockets.Name = "checkBox_PantsPockets";
			this.checkBox_PantsPockets.Size = new System.Drawing.Size(73, 17);
			this.checkBox_PantsPockets.TabIndex = 0;
			this.checkBox_PantsPockets.Text = "Карманы";
			this.checkBox_PantsPockets.UseVisualStyleBackColor = true;
			// 
			// checkBox_PantsBelt
			// 
			this.checkBox_PantsBelt.AutoSize = true;
			this.checkBox_PantsBelt.Location = new System.Drawing.Point(6, 59);
			this.checkBox_PantsBelt.Name = "checkBox_PantsBelt";
			this.checkBox_PantsBelt.Size = new System.Drawing.Size(65, 17);
			this.checkBox_PantsBelt.TabIndex = 1;
			this.checkBox_PantsBelt.Text = "Ремень";
			this.checkBox_PantsBelt.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(389, 600);
			this.Controls.Add(this.checkBox_Pants);
			this.Controls.Add(this.groupBox_UnderWear);
			this.Controls.Add(this.groupBox5);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.groupBox_Size);
			this.Controls.Add(this.groupBox_Color);
			this.Controls.Add(this.groupBox_WearType);
			this.Controls.Add(this.groupBox_Material);
			this.Controls.Add(this.button1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.groupBox_Material.ResumeLayout(false);
			this.groupBox_Material.PerformLayout();
			this.groupBox_WearType.ResumeLayout(false);
			this.groupBox_WearType.PerformLayout();
			this.groupBox_Color.ResumeLayout(false);
			this.groupBox_Color.PerformLayout();
			this.groupBox_Size.ResumeLayout(false);
			this.groupBox_Size.PerformLayout();
			this.groupBox5.ResumeLayout(false);
			this.groupBox5.PerformLayout();
			this.groupBox_UnderWear.ResumeLayout(false);
			this.groupBox_UnderWear.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.GroupBox groupBox_Material;
		private System.Windows.Forms.RadioButton radioButton_MaterialWool;
		private System.Windows.Forms.RadioButton radioButton_MaterialSilk;
		private System.Windows.Forms.RadioButton radioButton_MaterialCotton;
		private System.Windows.Forms.RadioButton radioButton_MaterialLinen;
		private System.Windows.Forms.GroupBox groupBox_WearType;
		private System.Windows.Forms.RadioButton radioButton_TypeUnderWear;
		private System.Windows.Forms.RadioButton radioButton_TypeOutWear;
		private System.Windows.Forms.GroupBox groupBox_Color;
		private System.Windows.Forms.GroupBox groupBox_Size;
		private System.Windows.Forms.RadioButton radioButton_SizeXXL;
		private System.Windows.Forms.RadioButton radioButton_SizeXL;
		private System.Windows.Forms.RadioButton radioButton_SizeL;
		private System.Windows.Forms.RadioButton radioButton_SizeM;
		private System.Windows.Forms.RadioButton radioButton_SizeS;
		private System.Windows.Forms.RadioButton radioButton_SizeXS;
		private System.Windows.Forms.RadioButton radioButton_SizeXXS;
		private System.Windows.Forms.RadioButton radioButton_ColorBlue;
		private System.Windows.Forms.RadioButton radioButton_ColorGreen;
		private System.Windows.Forms.RadioButton radioButton_ColorWhite;
		private System.Windows.Forms.RadioButton radioButton_ColorRed;
		private System.Windows.Forms.RadioButton radioButton_ColorBlack;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.RadioButton radioButton_Constructor2;
		private System.Windows.Forms.RadioButton radioButton_Constructor1;
		private System.Windows.Forms.GroupBox groupBox_UnderWear;
		private System.Windows.Forms.CheckBox checkBox_PantsBelt;
		private System.Windows.Forms.CheckBox checkBox_PantsPockets;
		private System.Windows.Forms.CheckBox checkBox_Pants;
	}
}

