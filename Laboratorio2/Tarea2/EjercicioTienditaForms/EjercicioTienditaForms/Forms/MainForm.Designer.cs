namespace EjercicioTienditaForms.Forms
{
    partial class MainForm
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
            this.VerdurasLabel = new System.Windows.Forms.Label();
            this.VerdurasListBox = new System.Windows.Forms.ListBox();
            this.ListadoVerdurasLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.GuardarVerduraButton = new System.Windows.Forms.Button();
            this.PrecioVerduraTextBox = new System.Windows.Forms.TextBox();
            this.NombreVerduraTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ActualizarVerduraButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.EliminarVerduraButton = new System.Windows.Forms.Button();
            this.TienditaTabControl = new System.Windows.Forms.TabControl();
            this.GestionarVerdurasTabPage = new System.Windows.Forms.TabPage();
            this.GestionarVentasTabPage = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.ProcesarVentaButton = new System.Windows.Forms.Button();
            this.ClienteTextBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.CantidadTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.VerdurasComboBox = new System.Windows.Forms.ComboBox();
            this.VentasListBox = new System.Windows.Forms.ListBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.ClientesFrecuentesLabel = new System.Windows.Forms.Label();
            this.VerdurasmasVendidasLabel = new System.Windows.Forms.Label();
            this.VerdurasmasVendidasListBox = new System.Windows.Forms.ListBox();
            this.ClientesFrecuentesListBox = new System.Windows.Forms.ListBox();
            this.GestionarVentaLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.TienditaTabControl.SuspendLayout();
            this.GestionarVerdurasTabPage.SuspendLayout();
            this.GestionarVentasTabPage.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // VerdurasLabel
            // 
            this.VerdurasLabel.AutoSize = true;
            this.VerdurasLabel.Font = new System.Drawing.Font("Poppins Medium", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.VerdurasLabel.Location = new System.Drawing.Point(6, 3);
            this.VerdurasLabel.Name = "VerdurasLabel";
            this.VerdurasLabel.Size = new System.Drawing.Size(219, 34);
            this.VerdurasLabel.TabIndex = 0;
            this.VerdurasLabel.Text = "Gestionar Verduras";
            // 
            // VerdurasListBox
            // 
            this.VerdurasListBox.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VerdurasListBox.FormattingEnabled = true;
            this.VerdurasListBox.ItemHeight = 23;
            this.VerdurasListBox.Location = new System.Drawing.Point(3, 58);
            this.VerdurasListBox.Name = "VerdurasListBox";
            this.VerdurasListBox.Size = new System.Drawing.Size(215, 188);
            this.VerdurasListBox.TabIndex = 1;
            this.VerdurasListBox.SelectedIndexChanged += new System.EventHandler(this.VerdurasListBox_SelectedIndexChanged);
            // 
            // ListadoVerdurasLabel
            // 
            this.ListadoVerdurasLabel.AutoSize = true;
            this.ListadoVerdurasLabel.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ListadoVerdurasLabel.Location = new System.Drawing.Point(0, 0);
            this.ListadoVerdurasLabel.Name = "ListadoVerdurasLabel";
            this.ListadoVerdurasLabel.Size = new System.Drawing.Size(173, 28);
            this.ListadoVerdurasLabel.TabIndex = 2;
            this.ListadoVerdurasLabel.Text = "Listado de verduras";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.ListadoVerdurasLabel);
            this.panel1.Controls.Add(this.VerdurasListBox);
            this.panel1.Location = new System.Drawing.Point(6, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(229, 339);
            this.panel1.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(3, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 23);
            this.label5.TabIndex = 3;
            this.label5.Text = "Nombre / Precio";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.GuardarVerduraButton);
            this.panel2.Controls.Add(this.PrecioVerduraTextBox);
            this.panel2.Controls.Add(this.NombreVerduraTextBox);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(241, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(349, 209);
            this.panel2.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(3, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(310, 28);
            this.label4.TabIndex = 5;
            this.label4.Text = "Formulario para ingreso de verduras";
            // 
            // GuardarVerduraButton
            // 
            this.GuardarVerduraButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GuardarVerduraButton.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GuardarVerduraButton.Location = new System.Drawing.Point(0, 182);
            this.GuardarVerduraButton.Name = "GuardarVerduraButton";
            this.GuardarVerduraButton.Size = new System.Drawing.Size(347, 25);
            this.GuardarVerduraButton.TabIndex = 4;
            this.GuardarVerduraButton.Text = "Guardar Verdura";
            this.GuardarVerduraButton.UseVisualStyleBackColor = true;
            this.GuardarVerduraButton.Click += new System.EventHandler(this.GuardarVerduraButton_Click);
            // 
            // PrecioVerduraTextBox
            // 
            this.PrecioVerduraTextBox.Location = new System.Drawing.Point(0, 138);
            this.PrecioVerduraTextBox.Name = "PrecioVerduraTextBox";
            this.PrecioVerduraTextBox.Size = new System.Drawing.Size(117, 23);
            this.PrecioVerduraTextBox.TabIndex = 3;
            // 
            // NombreVerduraTextBox
            // 
            this.NombreVerduraTextBox.Location = new System.Drawing.Point(-3, 84);
            this.NombreVerduraTextBox.Name = "NombreVerduraTextBox";
            this.NombreVerduraTextBox.Size = new System.Drawing.Size(200, 23);
            this.NombreVerduraTextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(0, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingresar Precio de la verdura";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingresar nombre de la verdura";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.ActualizarVerduraButton);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.EliminarVerduraButton);
            this.panel3.Location = new System.Drawing.Point(241, 255);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(347, 124);
            this.panel3.TabIndex = 5;
            // 
            // ActualizarVerduraButton
            // 
            this.ActualizarVerduraButton.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ActualizarVerduraButton.Location = new System.Drawing.Point(3, 49);
            this.ActualizarVerduraButton.Name = "ActualizarVerduraButton";
            this.ActualizarVerduraButton.Size = new System.Drawing.Size(157, 25);
            this.ActualizarVerduraButton.TabIndex = 2;
            this.ActualizarVerduraButton.Text = "Actualizar Verdura";
            this.ActualizarVerduraButton.UseVisualStyleBackColor = true;
            this.ActualizarVerduraButton.Click += new System.EventHandler(this.ActualizarVerduraButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins SemiBold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(3, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 28);
            this.label3.TabIndex = 1;
            this.label3.Text = "Acciones";
            // 
            // EliminarVerduraButton
            // 
            this.EliminarVerduraButton.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EliminarVerduraButton.Location = new System.Drawing.Point(3, 80);
            this.EliminarVerduraButton.Name = "EliminarVerduraButton";
            this.EliminarVerduraButton.Size = new System.Drawing.Size(157, 25);
            this.EliminarVerduraButton.TabIndex = 0;
            this.EliminarVerduraButton.Text = "Eliminar Verdura";
            this.EliminarVerduraButton.UseVisualStyleBackColor = true;
            this.EliminarVerduraButton.Click += new System.EventHandler(this.EliminarVerduraButton_Click);
            // 
            // TienditaTabControl
            // 
            this.TienditaTabControl.Controls.Add(this.GestionarVerdurasTabPage);
            this.TienditaTabControl.Controls.Add(this.GestionarVentasTabPage);
            this.TienditaTabControl.Location = new System.Drawing.Point(12, 12);
            this.TienditaTabControl.Name = "TienditaTabControl";
            this.TienditaTabControl.SelectedIndex = 0;
            this.TienditaTabControl.Size = new System.Drawing.Size(608, 447);
            this.TienditaTabControl.TabIndex = 6;
            // 
            // GestionarVerdurasTabPage
            // 
            this.GestionarVerdurasTabPage.Controls.Add(this.panel1);
            this.GestionarVerdurasTabPage.Controls.Add(this.VerdurasLabel);
            this.GestionarVerdurasTabPage.Controls.Add(this.panel3);
            this.GestionarVerdurasTabPage.Controls.Add(this.panel2);
            this.GestionarVerdurasTabPage.Location = new System.Drawing.Point(4, 24);
            this.GestionarVerdurasTabPage.Name = "GestionarVerdurasTabPage";
            this.GestionarVerdurasTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.GestionarVerdurasTabPage.Size = new System.Drawing.Size(600, 419);
            this.GestionarVerdurasTabPage.TabIndex = 0;
            this.GestionarVerdurasTabPage.Text = "Gestionar Verduras";
            this.GestionarVerdurasTabPage.UseVisualStyleBackColor = true;
            // 
            // GestionarVentasTabPage
            // 
            this.GestionarVentasTabPage.Controls.Add(this.panel5);
            this.GestionarVentasTabPage.Controls.Add(this.panel4);
            this.GestionarVentasTabPage.Controls.Add(this.GestionarVentaLabel);
            this.GestionarVentasTabPage.Location = new System.Drawing.Point(4, 24);
            this.GestionarVentasTabPage.Name = "GestionarVentasTabPage";
            this.GestionarVentasTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.GestionarVentasTabPage.Size = new System.Drawing.Size(600, 419);
            this.GestionarVentasTabPage.TabIndex = 1;
            this.GestionarVentasTabPage.Text = "Gestionar Ventas";
            this.GestionarVentasTabPage.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.label14);
            this.panel5.Controls.Add(this.ProcesarVentaButton);
            this.panel5.Controls.Add(this.ClienteTextBox);
            this.panel5.Controls.Add(this.label13);
            this.panel5.Controls.Add(this.label12);
            this.panel5.Controls.Add(this.CantidadTextBox);
            this.panel5.Controls.Add(this.label11);
            this.panel5.Controls.Add(this.label10);
            this.panel5.Controls.Add(this.label9);
            this.panel5.Controls.Add(this.VerdurasComboBox);
            this.panel5.Controls.Add(this.VentasListBox);
            this.panel5.Location = new System.Drawing.Point(6, 40);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(588, 218);
            this.panel5.TabIndex = 5;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(260, 33);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(238, 23);
            this.label14.TabIndex = 14;
            this.label14.Text = "Verdura / Cliente / Cantidad / Total";
            // 
            // ProcesarVentaButton
            // 
            this.ProcesarVentaButton.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ProcesarVentaButton.Location = new System.Drawing.Point(3, 190);
            this.ProcesarVentaButton.Name = "ProcesarVentaButton";
            this.ProcesarVentaButton.Size = new System.Drawing.Size(173, 23);
            this.ProcesarVentaButton.TabIndex = 13;
            this.ProcesarVentaButton.Text = "Procesar Venta";
            this.ProcesarVentaButton.UseVisualStyleBackColor = true;
            this.ProcesarVentaButton.Click += new System.EventHandler(this.ProcesarVentaButton_Click);
            // 
            // ClienteTextBox
            // 
            this.ClienteTextBox.Location = new System.Drawing.Point(3, 152);
            this.ClienteTextBox.Name = "ClienteTextBox";
            this.ClienteTextBox.Size = new System.Drawing.Size(173, 23);
            this.ClienteTextBox.TabIndex = 12;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(260, 3);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(123, 22);
            this.label13.TabIndex = 11;
            this.label13.Text = "Ventas Realizadas";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(3, 127);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(120, 22);
            this.label12.TabIndex = 9;
            this.label12.Text = "Nombre del cliente";
            // 
            // CantidadTextBox
            // 
            this.CantidadTextBox.Location = new System.Drawing.Point(3, 101);
            this.CantidadTextBox.Name = "CantidadTextBox";
            this.CantidadTextBox.Size = new System.Drawing.Size(174, 23);
            this.CantidadTextBox.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(3, 76);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(180, 22);
            this.label11.TabIndex = 7;
            this.label11.Text = "Ingresa la cantidad a vender";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(3, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(151, 22);
            this.label10.TabIndex = 6;
            this.label10.Text = "Selecciona una verdura";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(3, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 22);
            this.label9.TabIndex = 5;
            this.label9.Text = "Realizar venta";
            // 
            // VerdurasComboBox
            // 
            this.VerdurasComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.VerdurasComboBox.FormattingEnabled = true;
            this.VerdurasComboBox.Location = new System.Drawing.Point(3, 50);
            this.VerdurasComboBox.Name = "VerdurasComboBox";
            this.VerdurasComboBox.Size = new System.Drawing.Size(174, 23);
            this.VerdurasComboBox.TabIndex = 4;
            // 
            // VentasListBox
            // 
            this.VentasListBox.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VentasListBox.FormattingEnabled = true;
            this.VentasListBox.ItemHeight = 22;
            this.VentasListBox.Location = new System.Drawing.Point(260, 59);
            this.VentasListBox.Name = "VentasListBox";
            this.VentasListBox.Size = new System.Drawing.Size(325, 136);
            this.VentasListBox.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.ClientesFrecuentesLabel);
            this.panel4.Controls.Add(this.VerdurasmasVendidasLabel);
            this.panel4.Controls.Add(this.VerdurasmasVendidasListBox);
            this.panel4.Controls.Add(this.ClientesFrecuentesListBox);
            this.panel4.Location = new System.Drawing.Point(6, 264);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(588, 149);
            this.panel4.TabIndex = 4;
            // 
            // ClientesFrecuentesLabel
            // 
            this.ClientesFrecuentesLabel.AutoSize = true;
            this.ClientesFrecuentesLabel.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ClientesFrecuentesLabel.Location = new System.Drawing.Point(260, 4);
            this.ClientesFrecuentesLabel.Name = "ClientesFrecuentesLabel";
            this.ClientesFrecuentesLabel.Size = new System.Drawing.Size(144, 22);
            this.ClientesFrecuentesLabel.TabIndex = 5;
            this.ClientesFrecuentesLabel.Text = "Clientes Frecuentes";
            // 
            // VerdurasmasVendidasLabel
            // 
            this.VerdurasmasVendidasLabel.AutoSize = true;
            this.VerdurasmasVendidasLabel.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.VerdurasmasVendidasLabel.Location = new System.Drawing.Point(0, 4);
            this.VerdurasmasVendidasLabel.Name = "VerdurasmasVendidasLabel";
            this.VerdurasmasVendidasLabel.Size = new System.Drawing.Size(177, 22);
            this.VerdurasmasVendidasLabel.TabIndex = 4;
            this.VerdurasmasVendidasLabel.Text = "Verduras mas vendidas:";
            // 
            // VerdurasmasVendidasListBox
            // 
            this.VerdurasmasVendidasListBox.FormattingEnabled = true;
            this.VerdurasmasVendidasListBox.ItemHeight = 15;
            this.VerdurasmasVendidasListBox.Location = new System.Drawing.Point(3, 29);
            this.VerdurasmasVendidasListBox.Name = "VerdurasmasVendidasListBox";
            this.VerdurasmasVendidasListBox.Size = new System.Drawing.Size(237, 109);
            this.VerdurasmasVendidasListBox.TabIndex = 1;
            // 
            // ClientesFrecuentesListBox
            // 
            this.ClientesFrecuentesListBox.FormattingEnabled = true;
            this.ClientesFrecuentesListBox.ItemHeight = 15;
            this.ClientesFrecuentesListBox.Location = new System.Drawing.Point(260, 29);
            this.ClientesFrecuentesListBox.Name = "ClientesFrecuentesListBox";
            this.ClientesFrecuentesListBox.Size = new System.Drawing.Size(237, 109);
            this.ClientesFrecuentesListBox.TabIndex = 2;
            // 
            // GestionarVentaLabel
            // 
            this.GestionarVentaLabel.AutoSize = true;
            this.GestionarVentaLabel.Font = new System.Drawing.Font("Poppins Medium", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.GestionarVentaLabel.Location = new System.Drawing.Point(6, 3);
            this.GestionarVentaLabel.Name = "GestionarVentaLabel";
            this.GestionarVentaLabel.Size = new System.Drawing.Size(197, 34);
            this.GestionarVentaLabel.TabIndex = 0;
            this.GestionarVentaLabel.Text = "Gestionar Ventas";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 463);
            this.Controls.Add(this.TienditaTabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.Text = "VerdurasForms";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.TienditaTabControl.ResumeLayout(false);
            this.GestionarVerdurasTabPage.ResumeLayout(false);
            this.GestionarVerdurasTabPage.PerformLayout();
            this.GestionarVentasTabPage.ResumeLayout(false);
            this.GestionarVentasTabPage.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label VerdurasLabel;
        private ListBox VerdurasListBox;
        private Label ListadoVerdurasLabel;
        private Panel panel1;
        private Panel panel2;
        private Button GuardarVerduraButton;
        private TextBox PrecioVerduraTextBox;
        private TextBox NombreVerduraTextBox;
        private Label label2;
        private Label label1;
        private Panel panel3;
        private Button ActualizarVerduraButton;
        private Label label3;
        private Button EliminarVerduraButton;
        private Label label4;
        private Label label5;
        private TabControl TienditaTabControl;
        private TabPage GestionarVerdurasTabPage;
        private TabPage GestionarVentasTabPage;
        private Label GestionarVentaLabel;
        private ListBox VerdurasmasVendidasListBox;
        private ListBox VentasListBox;
        private ListBox ClientesFrecuentesListBox;
        private Panel panel4;
        private Panel panel5;
        private ComboBox VerdurasComboBox;
        private Label ClientesFrecuentesLabel;
        private Label VerdurasmasVendidasLabel;
        private Label label12;
        private TextBox CantidadTextBox;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label13;
        private TextBox ClienteTextBox;
        private Button ProcesarVentaButton;
        private Label label14;
    }
}