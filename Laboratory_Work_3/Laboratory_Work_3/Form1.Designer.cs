namespace OOP_Laboratory_Work_3
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
			this.button_Red_Button = new System.Windows.Forms.Button();
			this.radioButton_Objext_Type_int = new System.Windows.Forms.RadioButton();
			this.radioButton_Object_Type_string = new System.Windows.Forms.RadioButton();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.Text_Box_Right = new System.Windows.Forms.TextBox();
			this.Text_Box_Left = new System.Windows.Forms.TextBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.Text_Box_Lenght = new System.Windows.Forms.TextBox();
			this.Text_Box_Count = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.groupBox_ArrayButton = new System.Windows.Forms.GroupBox();
			this.label_ShowResult = new System.Windows.Forms.Label();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.groupBox6 = new System.Windows.Forms.GroupBox();
			this.label_Array = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox_ArrayButton.SuspendLayout();
			this.groupBox5.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.groupBox6.SuspendLayout();
			this.SuspendLayout();
			// 
			// button_Red_Button
			// 
			this.button_Red_Button.Location = new System.Drawing.Point(278, 348);
			this.button_Red_Button.Name = "button_Red_Button";
			this.button_Red_Button.Size = new System.Drawing.Size(97, 53);
			this.button_Red_Button.TabIndex = 0;
			this.button_Red_Button.Text = "Создать массив";
			this.button_Red_Button.UseVisualStyleBackColor = true;
			this.button_Red_Button.Click += new System.EventHandler(this.button1_Click);
			// 
			// radioButton_Objext_Type_int
			// 
			this.radioButton_Objext_Type_int.AutoSize = true;
			this.radioButton_Objext_Type_int.Location = new System.Drawing.Point(22, 19);
			this.radioButton_Objext_Type_int.Name = "radioButton_Objext_Type_int";
			this.radioButton_Objext_Type_int.Size = new System.Drawing.Size(58, 17);
			this.radioButton_Objext_Type_int.TabIndex = 1;
			this.radioButton_Objext_Type_int.TabStop = true;
			this.radioButton_Objext_Type_int.Text = "Integer";
			this.radioButton_Objext_Type_int.UseVisualStyleBackColor = true;
			this.radioButton_Objext_Type_int.CheckedChanged += new System.EventHandler(this.radioButton_Objext_Type_int_CheckedChanged);
			// 
			// radioButton_Object_Type_string
			// 
			this.radioButton_Object_Type_string.AutoSize = true;
			this.radioButton_Object_Type_string.Location = new System.Drawing.Point(22, 42);
			this.radioButton_Object_Type_string.Name = "radioButton_Object_Type_string";
			this.radioButton_Object_Type_string.Size = new System.Drawing.Size(52, 17);
			this.radioButton_Object_Type_string.TabIndex = 2;
			this.radioButton_Object_Type_string.TabStop = true;
			this.radioButton_Object_Type_string.Text = "String";
			this.radioButton_Object_Type_string.UseVisualStyleBackColor = true;
			this.radioButton_Object_Type_string.CheckedChanged += new System.EventHandler(this.radioButton_Object_Type_string_CheckedChanged);
			// 
			// groupBox1
			// 
			this.groupBox1.AutoSize = true;
			this.groupBox1.Controls.Add(this.radioButton_Object_Type_string);
			this.groupBox1.Controls.Add(this.radioButton_Objext_Type_int);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.groupBox1.Location = new System.Drawing.Point(6, 224);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(97, 78);
			this.groupBox1.TabIndex = 4;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Тип Объекта";
			// 
			// groupBox2
			// 
			this.groupBox2.AutoSize = true;
			this.groupBox2.Controls.Add(this.Text_Box_Right);
			this.groupBox2.Controls.Add(this.Text_Box_Left);
			this.groupBox2.Location = new System.Drawing.Point(6, 124);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(97, 94);
			this.groupBox2.TabIndex = 5;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Диапазон Чисел";
			// 
			// Text_Box_Right
			// 
			this.Text_Box_Right.Location = new System.Drawing.Point(7, 55);
			this.Text_Box_Right.Name = "Text_Box_Right";
			this.Text_Box_Right.Size = new System.Drawing.Size(84, 20);
			this.Text_Box_Right.TabIndex = 1;
			this.Text_Box_Right.Text = "Максимум";
			this.Text_Box_Right.Click += new System.EventHandler(this.Text_Box_Right_Click);
			// 
			// Text_Box_Left
			// 
			this.Text_Box_Left.Location = new System.Drawing.Point(7, 29);
			this.Text_Box_Left.Name = "Text_Box_Left";
			this.Text_Box_Left.Size = new System.Drawing.Size(84, 20);
			this.Text_Box_Left.TabIndex = 0;
			this.Text_Box_Left.Text = "Минимум";
			this.Text_Box_Left.Click += new System.EventHandler(this.Text_Box_Left_Click);
			// 
			// groupBox3
			// 
			this.groupBox3.AutoSize = true;
			this.groupBox3.Controls.Add(this.Text_Box_Lenght);
			this.groupBox3.Controls.Add(this.Text_Box_Count);
			this.groupBox3.Location = new System.Drawing.Point(6, 19);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(97, 99);
			this.groupBox3.TabIndex = 6;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Количество элементов";
			// 
			// Text_Box_Lenght
			// 
			this.Text_Box_Lenght.Location = new System.Drawing.Point(6, 34);
			this.Text_Box_Lenght.Name = "Text_Box_Lenght";
			this.Text_Box_Lenght.Size = new System.Drawing.Size(84, 20);
			this.Text_Box_Lenght.TabIndex = 1;
			this.Text_Box_Lenght.Text = "Строк";
			this.Text_Box_Lenght.Click += new System.EventHandler(this.Text_Box_Lenght_Click);
			// 
			// Text_Box_Count
			// 
			this.Text_Box_Count.Location = new System.Drawing.Point(6, 60);
			this.Text_Box_Count.Name = "Text_Box_Count";
			this.Text_Box_Count.Size = new System.Drawing.Size(84, 20);
			this.Text_Box_Count.TabIndex = 0;
			this.Text_Box_Count.Text = "Столбцов";
			this.Text_Box_Count.Click += new System.EventHandler(this.Text_Box_Count_Click);
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button1.Location = new System.Drawing.Point(6, 19);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 50);
			this.button1.TabIndex = 7;
			this.button1.Text = "Одномерный";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click_1);
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button2.Location = new System.Drawing.Point(87, 19);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 50);
			this.button2.TabIndex = 8;
			this.button2.Text = "Двумерный";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button3.Location = new System.Drawing.Point(168, 19);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(75, 50);
			this.button3.TabIndex = 9;
			this.button3.Text = "Вложенный";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// groupBox_ArrayButton
			// 
			this.groupBox_ArrayButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox_ArrayButton.AutoSize = true;
			this.groupBox_ArrayButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.groupBox_ArrayButton.CausesValidation = false;
			this.groupBox_ArrayButton.Controls.Add(this.button1);
			this.groupBox_ArrayButton.Controls.Add(this.button3);
			this.groupBox_ArrayButton.Controls.Add(this.button2);
			this.groupBox_ArrayButton.Enabled = false;
			this.groupBox_ArrayButton.Location = new System.Drawing.Point(12, 330);
			this.groupBox_ArrayButton.Name = "groupBox_ArrayButton";
			this.groupBox_ArrayButton.Size = new System.Drawing.Size(249, 88);
			this.groupBox_ArrayButton.TabIndex = 10;
			this.groupBox_ArrayButton.TabStop = false;
			this.groupBox_ArrayButton.Text = "Вывод массива";
			// 
			// label_ShowResult
			// 
			this.label_ShowResult.Location = new System.Drawing.Point(6, 16);
			this.label_ShowResult.Name = "label_ShowResult";
			this.label_ShowResult.Size = new System.Drawing.Size(242, 114);
			this.label_ShowResult.TabIndex = 11;
			this.label_ShowResult.Text = "Объект не создан.";
			this.label_ShowResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// groupBox5
			// 
			this.groupBox5.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.groupBox5.AutoSize = true;
			this.groupBox5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.groupBox5.Controls.Add(this.groupBox3);
			this.groupBox5.Controls.Add(this.groupBox2);
			this.groupBox5.Controls.Add(this.groupBox1);
			this.groupBox5.Location = new System.Drawing.Point(272, 12);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(109, 321);
			this.groupBox5.TabIndex = 12;
			this.groupBox5.TabStop = false;
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.label_ShowResult);
			this.groupBox4.Location = new System.Drawing.Point(12, 191);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(254, 133);
			this.groupBox4.TabIndex = 13;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Результат суммы";
			// 
			// groupBox6
			// 
			this.groupBox6.Controls.Add(this.label_Array);
			this.groupBox6.Location = new System.Drawing.Point(12, 12);
			this.groupBox6.Name = "groupBox6";
			this.groupBox6.Size = new System.Drawing.Size(254, 173);
			this.groupBox6.TabIndex = 14;
			this.groupBox6.TabStop = false;
			this.groupBox6.Text = "Вывод массива";
			// 
			// label_Array
			// 
			this.label_Array.Location = new System.Drawing.Point(6, 16);
			this.label_Array.Name = "label_Array";
			this.label_Array.Size = new System.Drawing.Size(242, 154);
			this.label_Array.TabIndex = 11;
			this.label_Array.Text = "Объект не создан.";
			this.label_Array.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(393, 430);
			this.Controls.Add(this.groupBox6);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.groupBox5);
			this.Controls.Add(this.groupBox_ArrayButton);
			this.Controls.Add(this.button_Red_Button);
			this.Name = "Form1";
			this.Text = "Лабораторная работа 3 ООП";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.groupBox_ArrayButton.ResumeLayout(false);
			this.groupBox5.ResumeLayout(false);
			this.groupBox5.PerformLayout();
			this.groupBox4.ResumeLayout(false);
			this.groupBox6.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button_Red_Button;
		private System.Windows.Forms.RadioButton radioButton_Objext_Type_int;
		private System.Windows.Forms.RadioButton radioButton_Object_Type_string;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TextBox Text_Box_Right;
		private System.Windows.Forms.TextBox Text_Box_Left;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.TextBox Text_Box_Count;
		private System.Windows.Forms.TextBox Text_Box_Lenght;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.GroupBox groupBox_ArrayButton;
		private System.Windows.Forms.Label label_ShowResult;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.GroupBox groupBox6;
		private System.Windows.Forms.Label label_Array;
		
	}
}

