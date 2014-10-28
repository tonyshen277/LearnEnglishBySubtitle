﻿namespace Studyzy.LearnEnglishBySubtitle.Forms
{
    partial class NewWordConfirmForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dgbtnIgnore = new System.Windows.Forms.DataGridViewButtonColumn();
            this.IsNewWord = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Word = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubtitleSentence = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Means = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.NewMean = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgbtnIgnore,
            this.IsNewWord,
            this.Word,
            this.SubtitleSentence,
            this.Means,
            this.NewMean});
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView1.Location = new System.Drawing.Point(12, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.ShowCellErrors = false;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.ShowRowErrors = false;
            this.dataGridView1.Size = new System.Drawing.Size(790, 714);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // dgbtnIgnore
            // 
            this.dgbtnIgnore.FillWeight = 50F;
            this.dgbtnIgnore.HeaderText = "忽略";
            this.dgbtnIgnore.Name = "dgbtnIgnore";
            this.dgbtnIgnore.ReadOnly = true;
            this.dgbtnIgnore.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgbtnIgnore.Text = "X";
            this.dgbtnIgnore.Width = 40;
            // 
            // IsNewWord
            // 
            this.IsNewWord.HeaderText = "是否生词";
            this.IsNewWord.Name = "IsNewWord";
            this.IsNewWord.Width = 40;
            // 
            // Word
            // 
            this.Word.HeaderText = "单词";
            this.Word.Name = "Word";
            this.Word.ReadOnly = true;
            this.Word.Width = 75;
            // 
            // SubtitleSentence
            // 
            this.SubtitleSentence.HeaderText = "原文";
            this.SubtitleSentence.Name = "SubtitleSentence";
            this.SubtitleSentence.ReadOnly = true;
            this.SubtitleSentence.Width = 300;
            // 
            // Means
            // 
            this.Means.HeaderText = "解释";
            this.Means.Name = "Means";
            this.Means.Width = 240;
            // 
            // NewMean
            // 
            this.NewMean.HeaderText = "新解释";
            this.NewMean.Name = "NewMean";
            this.NewMean.Width = 80;
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(631, 741);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 25);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(725, 741);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 25);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.Location = new System.Drawing.Point(9, 741);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(607, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "如果不想记录某单词请点取消按钮，是认识的单词，请取消选中。\r\n选中的单词会记录到用户的生词本中，未选中的单词记录到用户认识的单词中。";
            // 
            // NewWordConfirmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 779);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.dataGridView1);
            this.Name = "NewWordConfirmForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "字幕生词注释";
            this.Load += new System.EventHandler(this.NewWordConfirmForm_Load);
            this.Resize += new System.EventHandler(this.NewWordConfirmForm_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewButtonColumn dgbtnIgnore;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsNewWord;
        private System.Windows.Forms.DataGridViewTextBoxColumn Word;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubtitleSentence;
        private System.Windows.Forms.DataGridViewComboBoxColumn Means;
        private System.Windows.Forms.DataGridViewTextBoxColumn NewMean;
    }
}