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
			this.Text_Box_Count = new System.Windows.Forms.TextBox();
			this.Text_Box_Lenght = new System.Windows.Forms.TextBox();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// button_Red_Button
			// 
			this.button_Red_Button.Location = new System.Drawing.Point(513, 376);
			this.button_Red_Button.Name = "button_Red_Button";
			this.button_Red_Button.Size = new System.Drawing.Size(97, 53);
			this.button_Red_Button.TabIndex = 0;
			this.button_Red_Button.Text = "button1";
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
			// 
			// groupBox1
			// 
			this.groupBox1.AutoSize = true;
			this.groupBox1.Controls.Add(this.radioButton_Object_Type_string);
			this.groupBox1.Controls.Add(this.radioButton_Objext_Type_int);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.groupBox1.Location = new System.Drawing.Point(513, 292);
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
			this.groupBox2.Location = new System.Drawing.Point(513, 190);
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
			this.Text_Box_Right.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
			// 
			// Text_Box_Left
			// 
			this.Text_Box_Left.Location = new System.Drawing.Point(7, 29);
			this.Text_Box_Left.Name = "Text_Box_Left";
			this.Text_Box_Left.Size = new System.Drawing.Size(84, 20);
			this.Text_Box_Left.TabIndex = 0;
			this.Text_Box_Left.Text = "Минимум";
			// 
			// groupBox3
			// 
			this.groupBox3.AutoSize = true;
			this.groupBox3.Controls.Add(this.Text_Box_Lenght);
			this.groupBox3.Controls.Add(this.Text_Box_Count);
			this.groupBox3.Location = new System.Drawing.Point(513, 85);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(97, 99);
			this.groupBox3.TabIndex = 6;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Количество элементов";
			// 
			// Text_Box_Count
			// 
			this.Text_Box_Count.Location = new System.Drawing.Point(6, 60);
			this.Text_Box_Count.Name = "Text_Box_Count";
			this.Text_Box_Count.Size = new System.Drawing.Size(84, 20);
			this.Text_Box_Count.TabIndex = 0;
			this.Text_Box_Count.Text = "Столбцов";
			this.Text_Box_Count.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
			// 
			// Text_Box_Lenght
			// 
			this.Text_Box_Lenght.Location = new System.Drawing.Point(6, 34);
			this.Text_Box_Lenght.Name = "Text_Box_Lenght";
			this.Text_Box_Lenght.Size = new System.Drawing.Size(84, 20);
			this.Text_Box_Lenght.TabIndex = 1;
			this.Text_Box_Lenght.Text = "Строк";
			this.Text_Box_Lenght.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(624, 441);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.button_Red_Button);
			this.Name = "Form1";
			this.Text = "Form1";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
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
	}
}

