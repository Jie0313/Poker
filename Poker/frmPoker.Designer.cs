namespace Poker
{
    partial class frmPoker
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
            this.grpPoker = new System.Windows.Forms.GroupBox();
            this.grpButton = new System.Windows.Forms.GroupBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.btnChangeCard = new System.Windows.Forms.Button();
            this.btnDealCard = new System.Windows.Forms.Button();
            this.grppour = new System.Windows.Forms.GroupBox();
            this.btnpour = new System.Windows.Forms.Button();
            this.txtpourmoney = new System.Windows.Forms.TextBox();
            this.lblpmoney = new System.Windows.Forms.Label();
            this.lbltotal = new System.Windows.Forms.Label();
            this.lblmoney = new System.Windows.Forms.Label();
            this.grpButton.SuspendLayout();
            this.grppour.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpPoker
            // 
            this.grpPoker.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.grpPoker.Location = new System.Drawing.Point(16, 15);
            this.grpPoker.Margin = new System.Windows.Forms.Padding(4);
            this.grpPoker.Name = "grpPoker";
            this.grpPoker.Padding = new System.Windows.Forms.Padding(4);
            this.grpPoker.Size = new System.Drawing.Size(647, 200);
            this.grpPoker.TabIndex = 0;
            this.grpPoker.TabStop = false;
            this.grpPoker.Text = "牌桌";
            // 
            // grpButton
            // 
            this.grpButton.Controls.Add(this.lblResult);
            this.grpButton.Controls.Add(this.btnCheck);
            this.grpButton.Controls.Add(this.btnChangeCard);
            this.grpButton.Controls.Add(this.btnDealCard);
            this.grpButton.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.grpButton.Location = new System.Drawing.Point(16, 346);
            this.grpButton.Margin = new System.Windows.Forms.Padding(4);
            this.grpButton.Name = "grpButton";
            this.grpButton.Padding = new System.Windows.Forms.Padding(4);
            this.grpButton.Size = new System.Drawing.Size(647, 100);
            this.grpButton.TabIndex = 1;
            this.grpButton.TabStop = false;
            this.grpButton.Text = "功能";
            // 
            // lblResult
            // 
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResult.Location = new System.Drawing.Point(336, 35);
            this.lblResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(297, 45);
            this.lblResult.TabIndex = 3;
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCheck
            // 
            this.btnCheck.Enabled = false;
            this.btnCheck.Location = new System.Drawing.Point(219, 35);
            this.btnCheck.Margin = new System.Windows.Forms.Padding(4);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(109, 45);
            this.btnCheck.TabIndex = 2;
            this.btnCheck.Text = "判斷牌型";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // btnChangeCard
            // 
            this.btnChangeCard.Enabled = false;
            this.btnChangeCard.Location = new System.Drawing.Point(125, 35);
            this.btnChangeCard.Margin = new System.Windows.Forms.Padding(4);
            this.btnChangeCard.Name = "btnChangeCard";
            this.btnChangeCard.Size = new System.Drawing.Size(85, 45);
            this.btnChangeCard.TabIndex = 1;
            this.btnChangeCard.Text = "換牌";
            this.btnChangeCard.UseVisualStyleBackColor = true;
            this.btnChangeCard.Click += new System.EventHandler(this.btnChangeCard_Click);
            // 
            // btnDealCard
            // 
            this.btnDealCard.Location = new System.Drawing.Point(28, 35);
            this.btnDealCard.Margin = new System.Windows.Forms.Padding(4);
            this.btnDealCard.Name = "btnDealCard";
            this.btnDealCard.Size = new System.Drawing.Size(89, 45);
            this.btnDealCard.TabIndex = 0;
            this.btnDealCard.Text = "發牌";
            this.btnDealCard.UseVisualStyleBackColor = true;
            this.btnDealCard.Click += new System.EventHandler(this.btnDealCard_Click);
            // 
            // grppour
            // 
            this.grppour.Controls.Add(this.btnpour);
            this.grppour.Controls.Add(this.txtpourmoney);
            this.grppour.Controls.Add(this.lblpmoney);
            this.grppour.Controls.Add(this.lbltotal);
            this.grppour.Controls.Add(this.lblmoney);
            this.grppour.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.grppour.Location = new System.Drawing.Point(16, 238);
            this.grppour.Margin = new System.Windows.Forms.Padding(4);
            this.grppour.Name = "grppour";
            this.grppour.Padding = new System.Windows.Forms.Padding(4);
            this.grppour.Size = new System.Drawing.Size(647, 100);
            this.grppour.TabIndex = 2;
            this.grppour.TabStop = false;
            this.grppour.Text = "下注";
            // 
            // btnpour
            // 
            this.btnpour.Location = new System.Drawing.Point(537, 34);
            this.btnpour.Margin = new System.Windows.Forms.Padding(4);
            this.btnpour.Name = "btnpour";
            this.btnpour.Size = new System.Drawing.Size(80, 45);
            this.btnpour.TabIndex = 0;
            this.btnpour.Text = "押注";
            this.btnpour.UseVisualStyleBackColor = true;
            this.btnpour.Click += new System.EventHandler(this.btnpour_Click);
            // 
            // txtpourmoney
            // 
            this.txtpourmoney.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtpourmoney.Location = new System.Drawing.Point(405, 35);
            this.txtpourmoney.Multiline = true;
            this.txtpourmoney.Name = "txtpourmoney";
            this.txtpourmoney.Size = new System.Drawing.Size(103, 44);
            this.txtpourmoney.TabIndex = 6;
            this.txtpourmoney.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblpmoney
            // 
            this.lblpmoney.AutoSize = true;
            this.lblpmoney.Location = new System.Drawing.Point(307, 45);
            this.lblpmoney.Name = "lblpmoney";
            this.lblpmoney.Size = new System.Drawing.Size(92, 25);
            this.lblpmoney.TabIndex = 5;
            this.lblpmoney.Text = "押注金額";
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Location = new System.Drawing.Point(23, 45);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(72, 25);
            this.lbltotal.TabIndex = 4;
            this.lbltotal.Text = "總資金";
            // 
            // lblmoney
            // 
            this.lblmoney.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblmoney.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblmoney.Location = new System.Drawing.Point(102, 35);
            this.lblmoney.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblmoney.Name = "lblmoney";
            this.lblmoney.Size = new System.Drawing.Size(186, 45);
            this.lblmoney.TabIndex = 3;
            this.lblmoney.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmPoker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 471);
            this.Controls.Add(this.grppour);
            this.Controls.Add(this.grpButton);
            this.Controls.Add(this.grpPoker);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPoker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "五張撲克牌";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmPoker_KeyPress);
            this.grpButton.ResumeLayout(false);
            this.grppour.ResumeLayout(false);
            this.grppour.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpPoker;
        private System.Windows.Forms.GroupBox grpButton;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Button btnChangeCard;
        private System.Windows.Forms.Button btnDealCard;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.GroupBox grppour;
        private System.Windows.Forms.Label lblmoney;
        private System.Windows.Forms.Button btnpour;
        private System.Windows.Forms.TextBox txtpourmoney;
        private System.Windows.Forms.Label lblpmoney;
        private System.Windows.Forms.Label lbltotal;
    }
}