namespace Планировщик_рабочего_времени
{
    partial class Настройка
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
            System.Windows.Forms.Label nameUserLabel;
            System.Windows.Forms.Label birthLabel;
            System.Windows.Forms.Label telephoneLabel;
            System.Windows.Forms.Label kodPostLabel;
            System.Windows.Forms.Label roomNumberLabel;
            System.Windows.Forms.Label emailLabel;
            this.button1 = new System.Windows.Forms.Button();
            this.workTimeDataSet = new Планировщик_рабочего_времени.WorkTimeDataSet();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new Планировщик_рабочего_времени.WorkTimeDataSetTableAdapters.UsersTableAdapter();
            this.tableAdapterManager = new Планировщик_рабочего_времени.WorkTimeDataSetTableAdapters.TableAdapterManager();
            this.postsTableAdapter = new Планировщик_рабочего_времени.WorkTimeDataSetTableAdapters.PostsTableAdapter();
            this.nameUserTextBox = new System.Windows.Forms.TextBox();
            this.birthDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.telephoneMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.kodPostComboBox = new System.Windows.Forms.ComboBox();
            this.postsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roomNumberTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            nameUserLabel = new System.Windows.Forms.Label();
            birthLabel = new System.Windows.Forms.Label();
            telephoneLabel = new System.Windows.Forms.Label();
            kodPostLabel = new System.Windows.Forms.Label();
            roomNumberLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.workTimeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nameUserLabel
            // 
            nameUserLabel.AutoSize = true;
            nameUserLabel.BackColor = System.Drawing.Color.Transparent;
            nameUserLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            nameUserLabel.Location = new System.Drawing.Point(20, 27);
            nameUserLabel.Name = "nameUserLabel";
            nameUserLabel.Size = new System.Drawing.Size(154, 20);
            nameUserLabel.TabIndex = 20;
            nameUserLabel.Text = "ФИО пользователя:";
            // 
            // birthLabel
            // 
            birthLabel.AutoSize = true;
            birthLabel.BackColor = System.Drawing.Color.Transparent;
            birthLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            birthLabel.Location = new System.Drawing.Point(20, 67);
            birthLabel.Name = "birthLabel";
            birthLabel.Size = new System.Drawing.Size(127, 20);
            birthLabel.TabIndex = 22;
            birthLabel.Text = "Дата рождения:";
            // 
            // telephoneLabel
            // 
            telephoneLabel.AutoSize = true;
            telephoneLabel.BackColor = System.Drawing.Color.Transparent;
            telephoneLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            telephoneLabel.Location = new System.Drawing.Point(20, 111);
            telephoneLabel.Name = "telephoneLabel";
            telephoneLabel.Size = new System.Drawing.Size(76, 20);
            telephoneLabel.TabIndex = 24;
            telephoneLabel.Text = "Телефон:";
            // 
            // kodPostLabel
            // 
            kodPostLabel.AutoSize = true;
            kodPostLabel.BackColor = System.Drawing.Color.Transparent;
            kodPostLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            kodPostLabel.Location = new System.Drawing.Point(20, 153);
            kodPostLabel.Name = "kodPostLabel";
            kodPostLabel.Size = new System.Drawing.Size(96, 20);
            kodPostLabel.TabIndex = 26;
            kodPostLabel.Text = "Должность:";
            // 
            // roomNumberLabel
            // 
            roomNumberLabel.AutoSize = true;
            roomNumberLabel.BackColor = System.Drawing.Color.Transparent;
            roomNumberLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            roomNumberLabel.Location = new System.Drawing.Point(21, 198);
            roomNumberLabel.Name = "roomNumberLabel";
            roomNumberLabel.Size = new System.Drawing.Size(95, 20);
            roomNumberLabel.TabIndex = 28;
            roomNumberLabel.Text = "Кабинет №:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.BackColor = System.Drawing.Color.Transparent;
            emailLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            emailLabel.Location = new System.Drawing.Point(21, 242);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(51, 20);
            emailLabel.TabIndex = 32;
            emailLabel.Text = "Email:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Image = global::Планировщик_рабочего_времени.Properties.Resources.action_check;
            this.button1.Location = new System.Drawing.Point(158, 322);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 36);
            this.button1.TabIndex = 17;
            this.button1.Text = "Сохранить";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.usersBindingNavigatorSaveItem_Click);
            // 
            // workTimeDataSet
            // 
            this.workTimeDataSet.DataSetName = "WorkTimeDataSet";
            this.workTimeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.workTimeDataSet;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.PostsTableAdapter = this.postsTableAdapter;
            this.tableAdapterManager.RemindingsTableAdapter = null;
            this.tableAdapterManager.SheduleTableAdapter = null;
            this.tableAdapterManager.TasksTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Планировщик_рабочего_времени.WorkTimeDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = this.usersTableAdapter;
            // 
            // postsTableAdapter
            // 
            this.postsTableAdapter.ClearBeforeFill = true;
            // 
            // nameUserTextBox
            // 
            this.nameUserTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "NameUser", true));
            this.nameUserTextBox.Location = new System.Drawing.Point(174, 24);
            this.nameUserTextBox.Name = "nameUserTextBox";
            this.nameUserTextBox.Size = new System.Drawing.Size(266, 27);
            this.nameUserTextBox.TabIndex = 21;
            // 
            // birthDateTimePicker
            // 
            this.birthDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.usersBindingSource, "Birth", true));
            this.birthDateTimePicker.Location = new System.Drawing.Point(174, 62);
            this.birthDateTimePicker.Name = "birthDateTimePicker";
            this.birthDateTimePicker.Size = new System.Drawing.Size(202, 27);
            this.birthDateTimePicker.TabIndex = 23;
            // 
            // telephoneMaskedTextBox
            // 
            this.telephoneMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "Telephone", true));
            this.telephoneMaskedTextBox.Location = new System.Drawing.Point(174, 108);
            this.telephoneMaskedTextBox.Mask = "+375-00-000-00-00";
            this.telephoneMaskedTextBox.Name = "telephoneMaskedTextBox";
            this.telephoneMaskedTextBox.Size = new System.Drawing.Size(202, 27);
            this.telephoneMaskedTextBox.TabIndex = 25;
            // 
            // kodPostComboBox
            // 
            this.kodPostComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "KodPost", true));
            this.kodPostComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.usersBindingSource, "KodPost", true));
            this.kodPostComboBox.DataSource = this.postsBindingSource;
            this.kodPostComboBox.DisplayMember = "NamePost";
            this.kodPostComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kodPostComboBox.FormattingEnabled = true;
            this.kodPostComboBox.Location = new System.Drawing.Point(174, 150);
            this.kodPostComboBox.Name = "kodPostComboBox";
            this.kodPostComboBox.Size = new System.Drawing.Size(200, 28);
            this.kodPostComboBox.TabIndex = 27;
            this.kodPostComboBox.ValueMember = "KodPost";
            // 
            // postsBindingSource
            // 
            this.postsBindingSource.DataMember = "Posts";
            this.postsBindingSource.DataSource = this.workTimeDataSet;
            // 
            // roomNumberTextBox
            // 
            this.roomNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "RoomNumber", true));
            this.roomNumberTextBox.Location = new System.Drawing.Point(174, 195);
            this.roomNumberTextBox.Name = "roomNumberTextBox";
            this.roomNumberTextBox.Size = new System.Drawing.Size(200, 27);
            this.roomNumberTextBox.TabIndex = 29;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(174, 239);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(200, 27);
            this.emailTextBox.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(445, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 20);
            this.label2.TabIndex = 34;
            this.label2.Text = "*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(376, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 20);
            this.label1.TabIndex = 35;
            this.label1.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(376, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 20);
            this.label3.TabIndex = 36;
            this.label3.Text = "*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(376, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 20);
            this.label4.TabIndex = 37;
            this.label4.Text = "*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(31, 281);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(272, 20);
            this.label7.TabIndex = 38;
            this.label7.Text = "- обязательные поля для заполнения";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(20, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 20);
            this.label5.TabIndex = 39;
            this.label5.Text = "*";
            // 
            // Настройка
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = global::Планировщик_рабочего_времени.Properties.Resources.Фон;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(465, 375);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(nameUserLabel);
            this.Controls.Add(this.nameUserTextBox);
            this.Controls.Add(birthLabel);
            this.Controls.Add(this.birthDateTimePicker);
            this.Controls.Add(telephoneLabel);
            this.Controls.Add(this.telephoneMaskedTextBox);
            this.Controls.Add(kodPostLabel);
            this.Controls.Add(this.kodPostComboBox);
            this.Controls.Add(roomNumberLabel);
            this.Controls.Add(this.roomNumberTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Настройка";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Настройка профиля";
            this.Load += new System.EventHandler(this.Настройка_Load);
            ((System.ComponentModel.ISupportInitialize)(this.workTimeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private WorkTimeDataSet workTimeDataSet;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private WorkTimeDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private WorkTimeDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox nameUserTextBox;
        private System.Windows.Forms.DateTimePicker birthDateTimePicker;
        private System.Windows.Forms.MaskedTextBox telephoneMaskedTextBox;
        private System.Windows.Forms.ComboBox kodPostComboBox;
        private System.Windows.Forms.TextBox roomNumberTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private WorkTimeDataSetTableAdapters.PostsTableAdapter postsTableAdapter;
        private System.Windows.Forms.BindingSource postsBindingSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
    }
}