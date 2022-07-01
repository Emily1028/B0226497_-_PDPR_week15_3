
namespace B0226497_段昱如_PDPR_week15_3
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnEXIT = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.cost = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.music = new System.Windows.Forms.CheckBox();
            this.enviroment = new System.Windows.Forms.CheckBox();
            this.science = new System.Windows.Forms.CheckBox();
            this.art = new System.Windows.Forms.CheckBox();
            this.again = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(355, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "B0226497_段昱如_PDPR_week15_3";
            // 
            // btnEXIT
            // 
            this.btnEXIT.Location = new System.Drawing.Point(339, 393);
            this.btnEXIT.Name = "btnEXIT";
            this.btnEXIT.Size = new System.Drawing.Size(96, 47);
            this.btnEXIT.TabIndex = 10;
            this.btnEXIT.Text = "結束";
            this.btnEXIT.UseVisualStyleBackColor = true;
            this.btnEXIT.Click += new System.EventHandler(this.btnEXIT_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(87, 393);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(96, 47);
            this.btnOK.TabIndex = 11;
            this.btnOK.Text = "執行";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // cost
            // 
            this.cost.AutoSize = true;
            this.cost.Location = new System.Drawing.Point(83, 443);
            this.cost.Name = "cost";
            this.cost.Size = new System.Drawing.Size(154, 24);
            this.cost.TabIndex = 12;
            this.cost.Text = "合計應繳學費";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(87, 98);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(351, 100);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "居民：";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(184, 45);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(103, 28);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "非居民";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 45);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(127, 28);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "本地居民";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.music);
            this.groupBox2.Controls.Add(this.enviroment);
            this.groupBox2.Controls.Add(this.science);
            this.groupBox2.Controls.Add(this.art);
            this.groupBox2.Location = new System.Drawing.Point(87, 226);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(351, 140);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "加修科目：";
            // 
            // music
            // 
            this.music.AutoSize = true;
            this.music.Location = new System.Drawing.Point(183, 34);
            this.music.Name = "music";
            this.music.Size = new System.Drawing.Size(128, 28);
            this.music.TabIndex = 1;
            this.music.Text = "音樂欣賞";
            this.music.UseVisualStyleBackColor = true;
            // 
            // enviroment
            // 
            this.enviroment.AutoSize = true;
            this.enviroment.Location = new System.Drawing.Point(183, 88);
            this.enviroment.Name = "enviroment";
            this.enviroment.Size = new System.Drawing.Size(128, 28);
            this.enviroment.TabIndex = 0;
            this.enviroment.Text = "環境生態";
            this.enviroment.UseVisualStyleBackColor = true;
            // 
            // science
            // 
            this.science.AutoSize = true;
            this.science.Location = new System.Drawing.Point(6, 88);
            this.science.Name = "science";
            this.science.Size = new System.Drawing.Size(128, 28);
            this.science.TabIndex = 0;
            this.science.Text = "科學概論";
            this.science.UseVisualStyleBackColor = true;
            // 
            // art
            // 
            this.art.AutoSize = true;
            this.art.Location = new System.Drawing.Point(6, 34);
            this.art.Name = "art";
            this.art.Size = new System.Drawing.Size(128, 28);
            this.art.TabIndex = 0;
            this.art.Text = "藝術概論";
            this.art.UseVisualStyleBackColor = true;
            // 
            // again
            // 
            this.again.Location = new System.Drawing.Point(213, 393);
            this.again.Name = "again";
            this.again.Size = new System.Drawing.Size(96, 47);
            this.again.TabIndex = 14;
            this.again.Text = "重選";
            this.again.UseVisualStyleBackColor = true;
            this.again.Click += new System.EventHandler(this.again_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 586);
            this.Controls.Add(this.again);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEXIT);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.cost);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("新細明體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "B0226497_段昱如_PDPR_week15_3";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEXIT;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label cost;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox music;
        private System.Windows.Forms.CheckBox enviroment;
        private System.Windows.Forms.CheckBox science;
        private System.Windows.Forms.CheckBox art;
        private System.Windows.Forms.Button again;
    }
}

