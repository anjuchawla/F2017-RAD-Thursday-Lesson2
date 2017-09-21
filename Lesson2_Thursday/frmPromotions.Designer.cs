namespace Lesson2_Thursday
{
    partial class frmPromotions
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPromotions));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.mtxMemberId = new System.Windows.Forms.MaskedTextBox();
            this.rtbWelcome = new System.Windows.Forms.RichTextBox();
            this.txtPromotion = new System.Windows.Forms.TextBox();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.grpDepartment = new System.Windows.Forms.GroupBox();
            this.rdoClothing = new System.Windows.Forms.RadioButton();
            this.rdoEquipmentAccessories = new System.Windows.Forms.RadioButton();
            this.rdoJuiceBar = new System.Windows.Forms.RadioButton();
            this.rdoMembership = new System.Windows.Forms.RadioButton();
            this.rdoPersonalTraining = new System.Windows.Forms.RadioButton();
            this.picDepartment = new System.Windows.Forms.PictureBox();
            this.chkImageVisible = new System.Windows.Forms.CheckBox();
            this.grpInput = new System.Windows.Forms.GroupBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.printForm1 = new Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(this.components);
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.grpDepartment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDepartment)).BeginInit();
            this.grpInput.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(336, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "Look Sharp Fitness Center";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(841, 738);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Anju Chawla";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(51, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "&Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Member &ID";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(165, 31);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(344, 27);
            this.txtName.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txtName, "Please input your name");
            // 
            // mtxMemberId
            // 
            this.mtxMemberId.Location = new System.Drawing.Point(165, 92);
            this.mtxMemberId.Mask = "00000";
            this.mtxMemberId.Name = "mtxMemberId";
            this.mtxMemberId.Size = new System.Drawing.Size(58, 27);
            this.mtxMemberId.TabIndex = 3;
            this.toolTip1.SetToolTip(this.mtxMemberId, "Please enter your member ID");
            this.mtxMemberId.ValidatingType = typeof(int);
            // 
            // rtbWelcome
            // 
            this.rtbWelcome.Location = new System.Drawing.Point(610, 316);
            this.rtbWelcome.Name = "rtbWelcome";
            this.rtbWelcome.ReadOnly = true;
            this.rtbWelcome.Size = new System.Drawing.Size(344, 65);
            this.rtbWelcome.TabIndex = 9;
            this.rtbWelcome.TabStop = false;
            this.rtbWelcome.Text = "";
            // 
            // txtPromotion
            // 
            this.txtPromotion.Location = new System.Drawing.Point(610, 433);
            this.txtPromotion.Name = "txtPromotion";
            this.txtPromotion.ReadOnly = true;
            this.txtPromotion.Size = new System.Drawing.Size(344, 22);
            this.txtPromotion.TabIndex = 10;
            this.txtPromotion.TabStop = false;
            // 
            // btnSignIn
            // 
            this.btnSignIn.Location = new System.Drawing.Point(879, 495);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(75, 34);
            this.btnSignIn.TabIndex = 1;
            this.btnSignIn.Text = "&Sign In";
            this.btnSignIn.UseVisualStyleBackColor = true;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(879, 601);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 34);
            this.btnPrint.TabIndex = 5;
            this.btnPrint.Text = "&Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(879, 548);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 34);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "C&lear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(879, 654);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 34);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // grpDepartment
            // 
            this.grpDepartment.Controls.Add(this.rdoPersonalTraining);
            this.grpDepartment.Controls.Add(this.rdoMembership);
            this.grpDepartment.Controls.Add(this.rdoJuiceBar);
            this.grpDepartment.Controls.Add(this.rdoEquipmentAccessories);
            this.grpDepartment.Controls.Add(this.rdoClothing);
            this.grpDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDepartment.Location = new System.Drawing.Point(41, 144);
            this.grpDepartment.Name = "grpDepartment";
            this.grpDepartment.Size = new System.Drawing.Size(352, 311);
            this.grpDepartment.TabIndex = 2;
            this.grpDepartment.TabStop = false;
            this.grpDepartment.Text = "Department";
            // 
            // rdoClothing
            // 
            this.rdoClothing.AutoSize = true;
            this.rdoClothing.Location = new System.Drawing.Point(44, 42);
            this.rdoClothing.Name = "rdoClothing";
            this.rdoClothing.Size = new System.Drawing.Size(91, 24);
            this.rdoClothing.TabIndex = 0;
            this.rdoClothing.TabStop = true;
            this.rdoClothing.Text = "&Clothing";
            this.rdoClothing.UseVisualStyleBackColor = true;
            this.rdoClothing.CheckedChanged += new System.EventHandler(this.rdoClothing_CheckedChanged);
            // 
            // rdoEquipmentAccessories
            // 
            this.rdoEquipmentAccessories.AutoSize = true;
            this.rdoEquipmentAccessories.Location = new System.Drawing.Point(44, 95);
            this.rdoEquipmentAccessories.Name = "rdoEquipmentAccessories";
            this.rdoEquipmentAccessories.Size = new System.Drawing.Size(207, 24);
            this.rdoEquipmentAccessories.TabIndex = 1;
            this.rdoEquipmentAccessories.TabStop = true;
            this.rdoEquipmentAccessories.Text = "&Equipment/Accessories";
            this.rdoEquipmentAccessories.UseVisualStyleBackColor = true;
            // 
            // rdoJuiceBar
            // 
            this.rdoJuiceBar.AutoSize = true;
            this.rdoJuiceBar.Location = new System.Drawing.Point(44, 148);
            this.rdoJuiceBar.Name = "rdoJuiceBar";
            this.rdoJuiceBar.Size = new System.Drawing.Size(102, 24);
            this.rdoJuiceBar.TabIndex = 2;
            this.rdoJuiceBar.TabStop = true;
            this.rdoJuiceBar.Text = "&Juice Bar";
            this.rdoJuiceBar.UseVisualStyleBackColor = true;
            // 
            // rdoMembership
            // 
            this.rdoMembership.AutoSize = true;
            this.rdoMembership.Location = new System.Drawing.Point(44, 201);
            this.rdoMembership.Name = "rdoMembership";
            this.rdoMembership.Size = new System.Drawing.Size(122, 24);
            this.rdoMembership.TabIndex = 3;
            this.rdoMembership.TabStop = true;
            this.rdoMembership.Text = "&Membership";
            this.rdoMembership.UseVisualStyleBackColor = true;
            // 
            // rdoPersonalTraining
            // 
            this.rdoPersonalTraining.AutoSize = true;
            this.rdoPersonalTraining.Location = new System.Drawing.Point(44, 254);
            this.rdoPersonalTraining.Name = "rdoPersonalTraining";
            this.rdoPersonalTraining.Size = new System.Drawing.Size(161, 24);
            this.rdoPersonalTraining.TabIndex = 4;
            this.rdoPersonalTraining.TabStop = true;
            this.rdoPersonalTraining.Text = "&Personal &Training";
            this.rdoPersonalTraining.UseVisualStyleBackColor = true;
            // 
            // picDepartment
            // 
            this.picDepartment.Location = new System.Drawing.Point(41, 495);
            this.picDepartment.Name = "picDepartment";
            this.picDepartment.Size = new System.Drawing.Size(382, 193);
            this.picDepartment.TabIndex = 13;
            this.picDepartment.TabStop = false;
            // 
            // chkImageVisible
            // 
            this.chkImageVisible.AutoSize = true;
            this.chkImageVisible.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkImageVisible.Location = new System.Drawing.Point(41, 715);
            this.chkImageVisible.Name = "chkImageVisible";
            this.chkImageVisible.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkImageVisible.Size = new System.Drawing.Size(131, 24);
            this.chkImageVisible.TabIndex = 3;
            this.chkImageVisible.Text = "Image &Visible";
            this.chkImageVisible.UseVisualStyleBackColor = true;
            this.chkImageVisible.CheckedChanged += new System.EventHandler(this.chkImageVisible_CheckedChanged);
            // 
            // grpInput
            // 
            this.grpInput.Controls.Add(this.mtxMemberId);
            this.grpInput.Controls.Add(this.txtName);
            this.grpInput.Controls.Add(this.label4);
            this.grpInput.Controls.Add(this.label3);
            this.grpInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpInput.Location = new System.Drawing.Point(427, 144);
            this.grpInput.Name = "grpInput";
            this.grpInput.Size = new System.Drawing.Size(527, 145);
            this.grpInput.TabIndex = 0;
            this.grpInput.TabStop = false;
            this.grpInput.Text = "Please Input";
            // 
            // printForm1
            // 
            this.printForm1.DocumentName = "document";
            this.printForm1.Form = this;
            this.printForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPreview;
            this.printForm1.PrinterSettings = ((System.Drawing.Printing.PrinterSettings)(resources.GetObject("printForm1.PrinterSettings")));
            this.printForm1.PrintFileName = null;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(994, 767);
            this.shapeContainer1.TabIndex = 14;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 1;
            this.lineShape1.X2 = 995;
            this.lineShape1.Y1 = 78;
            this.lineShape1.Y2 = 78;
            // 
            // frmPromotions
            // 
            this.AcceptButton = this.btnSignIn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(994, 767);
            this.Controls.Add(this.grpInput);
            this.Controls.Add(this.chkImageVisible);
            this.Controls.Add(this.picDepartment);
            this.Controls.Add(this.grpDepartment);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnSignIn);
            this.Controls.Add(this.txtPromotion);
            this.Controls.Add(this.rtbWelcome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmPromotions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Promotions";
            this.Load += new System.EventHandler(this.frmPromotions_Load);
            this.grpDepartment.ResumeLayout(false);
            this.grpDepartment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDepartment)).EndInit();
            this.grpInput.ResumeLayout(false);
            this.grpInput.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.MaskedTextBox mtxMemberId;
        private System.Windows.Forms.RichTextBox rtbWelcome;
        private System.Windows.Forms.TextBox txtPromotion;
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox grpDepartment;
        private System.Windows.Forms.RadioButton rdoPersonalTraining;
        private System.Windows.Forms.RadioButton rdoMembership;
        private System.Windows.Forms.RadioButton rdoJuiceBar;
        private System.Windows.Forms.RadioButton rdoEquipmentAccessories;
        private System.Windows.Forms.RadioButton rdoClothing;
        private System.Windows.Forms.PictureBox picDepartment;
        private System.Windows.Forms.CheckBox chkImageVisible;
        private System.Windows.Forms.GroupBox grpInput;
        private System.Windows.Forms.ToolTip toolTip1;
        private Microsoft.VisualBasic.PowerPacks.Printing.PrintForm printForm1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
    }
}

