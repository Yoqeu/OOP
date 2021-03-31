namespace OOP
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.AddVisitor = new System.Windows.Forms.Button();
            this.Room_Button = new System.Windows.Forms.Button();
            this.Delete_Visitor = new System.Windows.Forms.Button();
            this.ReserveRoom = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(24, 22);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(633, 167);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // AddVisitor
            // 
            this.AddVisitor.Location = new System.Drawing.Point(24, 305);
            this.AddVisitor.Name = "AddVisitor";
            this.AddVisitor.Size = new System.Drawing.Size(100, 23);
            this.AddVisitor.TabIndex = 4;
            this.AddVisitor.Text = "Add Visitor";
            this.AddVisitor.UseVisualStyleBackColor = true;
            this.AddVisitor.Click += new System.EventHandler(this.AddVisitor_Click);
            // 
            // Room_Button
            // 
            this.Room_Button.Location = new System.Drawing.Point(130, 305);
            this.Room_Button.Name = "Room_Button";
            this.Room_Button.Size = new System.Drawing.Size(100, 23);
            this.Room_Button.TabIndex = 6;
            this.Room_Button.Text = "Rooms";
            this.Room_Button.UseVisualStyleBackColor = true;
            this.Room_Button.Click += new System.EventHandler(this.Room_Button_Click);
            // 
            // Delete_Visitor
            // 
            this.Delete_Visitor.Location = new System.Drawing.Point(243, 305);
            this.Delete_Visitor.Name = "Delete_Visitor";
            this.Delete_Visitor.Size = new System.Drawing.Size(100, 23);
            this.Delete_Visitor.TabIndex = 7;
            this.Delete_Visitor.Text = "Delete Visitor";
            this.Delete_Visitor.UseVisualStyleBackColor = true;
            this.Delete_Visitor.Click += new System.EventHandler(this.Delete_Visitor_Click);
            // 
            // ReserveRoom
            // 
            this.ReserveRoom.Location = new System.Drawing.Point(349, 305);
            this.ReserveRoom.Name = "ReserveRoom";
            this.ReserveRoom.Size = new System.Drawing.Size(100, 23);
            this.ReserveRoom.TabIndex = 8;
            this.ReserveRoom.Text = "Reserve";
            this.ReserveRoom.UseVisualStyleBackColor = true;
            this.ReserveRoom.Click += new System.EventHandler(this.ReserveRoom_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(568, 305);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(100, 23);
            this.ExitButton.TabIndex = 9;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 345);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ReserveRoom);
            this.Controls.Add(this.Delete_Visitor);
            this.Controls.Add(this.Room_Button);
            this.Controls.Add(this.AddVisitor);
            this.Controls.Add(this.textBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Main Page";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button AddVisitor;
        private System.Windows.Forms.Button Room_Button;
        private System.Windows.Forms.Button Delete_Visitor;
        private System.Windows.Forms.Button ReserveRoom;
        private System.Windows.Forms.Button ExitButton;
    }
}

