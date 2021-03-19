namespace Fam_Trello_Notes_Writing_To_Sql
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
            this.inpt_title = new System.Windows.Forms.TextBox();
            this.inpt_desc = new System.Windows.Forms.RichTextBox();
            this.cbx_users = new System.Windows.Forms.CheckedListBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_read = new System.Windows.Forms.Button();
            this.lbl_notes = new System.Windows.Forms.Label();
            this.btn_delete = new System.Windows.Forms.Button();
            this.inpt_id = new System.Windows.Forms.TextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnUpdtateSQL = new System.Windows.Forms.Button();
            this.btnSPGetNoteID = new System.Windows.Forms.Button();
            this.btnGetNotes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // inpt_title
            // 
            this.inpt_title.Location = new System.Drawing.Point(329, 55);
            this.inpt_title.Name = "inpt_title";
            this.inpt_title.Size = new System.Drawing.Size(100, 20);
            this.inpt_title.TabIndex = 0;
            // 
            // inpt_desc
            // 
            this.inpt_desc.Location = new System.Drawing.Point(329, 101);
            this.inpt_desc.Name = "inpt_desc";
            this.inpt_desc.Size = new System.Drawing.Size(100, 96);
            this.inpt_desc.TabIndex = 1;
            this.inpt_desc.Text = "";
            // 
            // cbx_users
            // 
            this.cbx_users.FormattingEnabled = true;
            this.cbx_users.Items.AddRange(new object[] {
            "Ely",
            "Nir",
            "Zion"});
            this.cbx_users.Location = new System.Drawing.Point(608, 133);
            this.cbx_users.Name = "cbx_users";
            this.cbx_users.Size = new System.Drawing.Size(120, 94);
            this.cbx_users.TabIndex = 2;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(489, 150);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 3;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(489, 99);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(75, 23);
            this.btn_edit.TabIndex = 4;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_read
            // 
            this.btn_read.Location = new System.Drawing.Point(489, 204);
            this.btn_read.Name = "btn_read";
            this.btn_read.Size = new System.Drawing.Size(75, 23);
            this.btn_read.TabIndex = 5;
            this.btn_read.Text = "Read";
            this.btn_read.UseVisualStyleBackColor = true;
            this.btn_read.Click += new System.EventHandler(this.btn_read_Click);
            // 
            // lbl_notes
            // 
            this.lbl_notes.AutoSize = true;
            this.lbl_notes.Location = new System.Drawing.Point(51, 55);
            this.lbl_notes.Name = "lbl_notes";
            this.lbl_notes.Size = new System.Drawing.Size(35, 13);
            this.lbl_notes.TabIndex = 6;
            this.lbl_notes.Text = "Notes";
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(489, 51);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 7;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // inpt_id
            // 
            this.inpt_id.Location = new System.Drawing.Point(329, 12);
            this.inpt_id.Name = "inpt_id";
            this.inpt_id.Size = new System.Drawing.Size(17, 20);
            this.inpt_id.TabIndex = 8;
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(54, 262);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(699, 150);
            this.dataGridView.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(278, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(278, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Title";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(278, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Desc";
            // 
            // btnUpdtateSQL
            // 
            this.btnUpdtateSQL.Location = new System.Drawing.Point(329, 204);
            this.btnUpdtateSQL.Name = "btnUpdtateSQL";
            this.btnUpdtateSQL.Size = new System.Drawing.Size(100, 23);
            this.btnUpdtateSQL.TabIndex = 13;
            this.btnUpdtateSQL.Text = "UpdateSQL";
            this.btnUpdtateSQL.UseVisualStyleBackColor = true;
            this.btnUpdtateSQL.Click += new System.EventHandler(this.btnUpdtateSQL_Click);
            // 
            // btnSPGetNoteID
            // 
            this.btnSPGetNoteID.Location = new System.Drawing.Point(608, 53);
            this.btnSPGetNoteID.Name = "btnSPGetNoteID";
            this.btnSPGetNoteID.Size = new System.Drawing.Size(98, 23);
            this.btnSPGetNoteID.TabIndex = 14;
            this.btnSPGetNoteID.Text = "SPGetNoteID";
            this.btnSPGetNoteID.UseVisualStyleBackColor = true;
            this.btnSPGetNoteID.Click += new System.EventHandler(this.btnSPGetNoteID_Click);
            // 
            // btnGetNotes
            // 
            this.btnGetNotes.Location = new System.Drawing.Point(608, 94);
            this.btnGetNotes.Name = "btnGetNotes";
            this.btnGetNotes.Size = new System.Drawing.Size(98, 23);
            this.btnGetNotes.TabIndex = 15;
            this.btnGetNotes.Text = "SP Show Notes";
            this.btnGetNotes.UseVisualStyleBackColor = true;
            this.btnGetNotes.Click += new System.EventHandler(this.btnGetNotes_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGetNotes);
            this.Controls.Add(this.btnSPGetNoteID);
            this.Controls.Add(this.btnUpdtateSQL);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.inpt_id);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.lbl_notes);
            this.Controls.Add(this.btn_read);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.cbx_users);
            this.Controls.Add(this.inpt_desc);
            this.Controls.Add(this.inpt_title);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inpt_title;
        private System.Windows.Forms.RichTextBox inpt_desc;
        private System.Windows.Forms.CheckedListBox cbx_users;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_read;
        private System.Windows.Forms.Label lbl_notes;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.TextBox inpt_id;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnUpdtateSQL;
        private System.Windows.Forms.Button btnSPGetNoteID;
        private System.Windows.Forms.Button btnGetNotes;
    }
}

