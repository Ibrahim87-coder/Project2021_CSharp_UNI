namespace Start
{
    partial class page_Registration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(page_Registration));
            this.pass = new System.Windows.Forms.PictureBox();
            this.PassTxt = new System.Windows.Forms.TextBox();
            this.nom = new System.Windows.Forms.PictureBox();
            this.NomTxt = new System.Windows.Forms.TextBox();
            this.txtIcon = new System.Windows.Forms.PictureBox();
            this.txtIcon2 = new System.Windows.Forms.PictureBox();
            this.usertxt = new System.Windows.Forms.TextBox();
            this.txtIcon1 = new System.Windows.Forms.PictureBox();
            this.Confpass = new System.Windows.Forms.TextBox();
            this.txtIcon3 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioBtnProf = new System.Windows.Forms.RadioButton();
            this.radioBtnEleve = new System.Windows.Forms.RadioButton();
            this.typeq = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pass1 = new System.Windows.Forms.PictureBox();
            this.btnconf = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.user = new System.Windows.Forms.PictureBox();
            this.male = new System.Windows.Forms.RadioButton();
            this.femelle = new System.Windows.Forms.RadioButton();
            this.motclereg = new System.Windows.Forms.Label();
            this.conf = new System.Windows.Forms.Label();
            this.wrongpass = new System.Windows.Forms.Label();
            this.wronguser = new System.Windows.Forms.Label();
            this.wrongnom = new System.Windows.Forms.Label();
            this.utilisateurDeja = new System.Windows.Forms.Label();
            this.dateq = new System.Windows.Forms.Label();
            this.genreq = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.Datepicker = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIcon2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIcon1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIcon3)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pass1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.user)).BeginInit();
            this.SuspendLayout();
            // 
            // pass
            // 
            this.pass.BackColor = System.Drawing.Color.White;
            this.pass.Image = ((System.Drawing.Image)(resources.GetObject("pass.Image")));
            this.pass.Location = new System.Drawing.Point(279, 401);
            this.pass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(40, 42);
            this.pass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pass.TabIndex = 27;
            this.pass.TabStop = false;
            // 
            // PassTxt
            // 
            this.PassTxt.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.PassTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PassTxt.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassTxt.ForeColor = System.Drawing.Color.DimGray;
            this.PassTxt.Location = new System.Drawing.Point(325, 410);
            this.PassTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PassTxt.Name = "PassTxt";
            this.PassTxt.Size = new System.Drawing.Size(235, 23);
            this.PassTxt.TabIndex = 26;
            this.PassTxt.Text = "Votre mot clé";
            this.PassTxt.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PassTxt_MouseClick);
            this.PassTxt.TextChanged += new System.EventHandler(this.PassTxt_TextChanged);
            // 
            // nom
            // 
            this.nom.BackColor = System.Drawing.SystemColors.GrayText;
            this.nom.Image = ((System.Drawing.Image)(resources.GetObject("nom.Image")));
            this.nom.Location = new System.Drawing.Point(279, 220);
            this.nom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(40, 43);
            this.nom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.nom.TabIndex = 28;
            this.nom.TabStop = false;
            // 
            // NomTxt
            // 
            this.NomTxt.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.NomTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NomTxt.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomTxt.ForeColor = System.Drawing.Color.DimGray;
            this.NomTxt.Location = new System.Drawing.Point(325, 229);
            this.NomTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NomTxt.Name = "NomTxt";
            this.NomTxt.Size = new System.Drawing.Size(235, 23);
            this.NomTxt.TabIndex = 25;
            this.NomTxt.Text = "Votre nom";
            this.NomTxt.MouseClick += new System.Windows.Forms.MouseEventHandler(this.NomTxt_MouseClick);
            this.NomTxt.TextChanged += new System.EventHandler(this.NomTxt_TextChanged);
            this.NomTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NomTxt_KeyDown);
            // 
            // txtIcon
            // 
            this.txtIcon.BackColor = System.Drawing.Color.Transparent;
            this.txtIcon.Image = ((System.Drawing.Image)(resources.GetObject("txtIcon.Image")));
            this.txtIcon.Location = new System.Drawing.Point(247, 190);
            this.txtIcon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIcon.Name = "txtIcon";
            this.txtIcon.Size = new System.Drawing.Size(351, 98);
            this.txtIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.txtIcon.TabIndex = 23;
            this.txtIcon.TabStop = false;
            // 
            // txtIcon2
            // 
            this.txtIcon2.BackColor = System.Drawing.Color.Transparent;
            this.txtIcon2.Image = ((System.Drawing.Image)(resources.GetObject("txtIcon2.Image")));
            this.txtIcon2.Location = new System.Drawing.Point(247, 373);
            this.txtIcon2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIcon2.Name = "txtIcon2";
            this.txtIcon2.Size = new System.Drawing.Size(351, 98);
            this.txtIcon2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.txtIcon2.TabIndex = 24;
            this.txtIcon2.TabStop = false;
            // 
            // usertxt
            // 
            this.usertxt.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.usertxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usertxt.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usertxt.ForeColor = System.Drawing.Color.DimGray;
            this.usertxt.Location = new System.Drawing.Point(325, 322);
            this.usertxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.usertxt.Name = "usertxt";
            this.usertxt.Size = new System.Drawing.Size(235, 23);
            this.usertxt.TabIndex = 31;
            this.usertxt.Text = "Nom utilisateur";
            this.usertxt.MouseClick += new System.Windows.Forms.MouseEventHandler(this.usertxt_MouseClick);
            this.usertxt.TextChanged += new System.EventHandler(this.usertxt_TextChanged);
            this.usertxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.usertxt_KeyDown);
            // 
            // txtIcon1
            // 
            this.txtIcon1.BackColor = System.Drawing.Color.Transparent;
            this.txtIcon1.Image = ((System.Drawing.Image)(resources.GetObject("txtIcon1.Image")));
            this.txtIcon1.Location = new System.Drawing.Point(248, 284);
            this.txtIcon1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIcon1.Name = "txtIcon1";
            this.txtIcon1.Size = new System.Drawing.Size(351, 98);
            this.txtIcon1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.txtIcon1.TabIndex = 29;
            this.txtIcon1.TabStop = false;
            // 
            // Confpass
            // 
            this.Confpass.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Confpass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Confpass.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Confpass.ForeColor = System.Drawing.Color.DimGray;
            this.Confpass.Location = new System.Drawing.Point(325, 500);
            this.Confpass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Confpass.Name = "Confpass";
            this.Confpass.Size = new System.Drawing.Size(235, 23);
            this.Confpass.TabIndex = 43;
            this.Confpass.Text = "Confirmer Votre mot";
            this.Confpass.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Confpass_MouseClick);
            this.Confpass.TextChanged += new System.EventHandler(this.Confpass_TextChanged);
            this.Confpass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Confpass_KeyDown);
            // 
            // txtIcon3
            // 
            this.txtIcon3.BackColor = System.Drawing.Color.Transparent;
            this.txtIcon3.Image = ((System.Drawing.Image)(resources.GetObject("txtIcon3.Image")));
            this.txtIcon3.Location = new System.Drawing.Point(248, 464);
            this.txtIcon3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIcon3.Name = "txtIcon3";
            this.txtIcon3.Size = new System.Drawing.Size(351, 98);
            this.txtIcon3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.txtIcon3.TabIndex = 42;
            this.txtIcon3.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.radioBtnProf);
            this.panel1.Controls.Add(this.radioBtnEleve);
            this.panel1.Location = new System.Drawing.Point(627, 190);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(289, 89);
            this.panel1.TabIndex = 45;
            // 
            // radioBtnProf
            // 
            this.radioBtnProf.AutoSize = true;
            this.radioBtnProf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioBtnProf.Font = new System.Drawing.Font("Cooper Black", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnProf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.radioBtnProf.Location = new System.Drawing.Point(-1, 51);
            this.radioBtnProf.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioBtnProf.Name = "radioBtnProf";
            this.radioBtnProf.Size = new System.Drawing.Size(253, 36);
            this.radioBtnProf.TabIndex = 1;
            this.radioBtnProf.Text = "Une Professeur";
            this.radioBtnProf.UseVisualStyleBackColor = true;
            // 
            // radioBtnEleve
            // 
            this.radioBtnEleve.AutoSize = true;
            this.radioBtnEleve.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioBtnEleve.Font = new System.Drawing.Font("Cooper Black", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnEleve.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.radioBtnEleve.Location = new System.Drawing.Point(0, 18);
            this.radioBtnEleve.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioBtnEleve.Name = "radioBtnEleve";
            this.radioBtnEleve.Size = new System.Drawing.Size(173, 36);
            this.radioBtnEleve.TabIndex = 0;
            this.radioBtnEleve.Text = "Une éléve";
            this.radioBtnEleve.UseVisualStyleBackColor = true;
            this.radioBtnEleve.CheckedChanged += new System.EventHandler(this.radioBtnEleve_CheckedChanged);
            // 
            // typeq
            // 
            this.typeq.AutoSize = true;
            this.typeq.BackColor = System.Drawing.Color.Transparent;
            this.typeq.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeq.ForeColor = System.Drawing.Color.Red;
            this.typeq.Location = new System.Drawing.Point(630, 171);
            this.typeq.Name = "typeq";
            this.typeq.Size = new System.Drawing.Size(185, 27);
            this.typeq.TabIndex = 64;
            this.typeq.Text = "Qui êtes-vous?";
            this.typeq.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.label1.Location = new System.Drawing.Point(438, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(413, 69);
            this.label1.TabIndex = 46;
            this.label1.Text = "Registration";
            // 
            // pass1
            // 
            this.pass1.BackColor = System.Drawing.Color.White;
            this.pass1.Image = ((System.Drawing.Image)(resources.GetObject("pass1.Image")));
            this.pass1.Location = new System.Drawing.Point(279, 491);
            this.pass1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pass1.Name = "pass1";
            this.pass1.Size = new System.Drawing.Size(40, 42);
            this.pass1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pass1.TabIndex = 51;
            this.pass1.TabStop = false;
            // 
            // btnconf
            // 
            this.btnconf.BackColor = System.Drawing.Color.Transparent;
            this.btnconf.BorderColor = System.Drawing.Color.White;
            this.btnconf.BorderRadius = 25;
            this.btnconf.BorderThickness = 5;
            this.btnconf.CheckedState.Parent = this.btnconf;
            this.btnconf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnconf.CustomImages.Parent = this.btnconf;
            this.btnconf.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.btnconf.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnconf.ForeColor = System.Drawing.Color.White;
            this.btnconf.HoverState.Parent = this.btnconf;
            this.btnconf.Location = new System.Drawing.Point(628, 480);
            this.btnconf.Margin = new System.Windows.Forms.Padding(4);
            this.btnconf.Name = "btnconf";
            this.btnconf.PressedColor = System.Drawing.Color.White;
            this.btnconf.ShadowDecoration.Parent = this.btnconf;
            this.btnconf.Size = new System.Drawing.Size(252, 81);
            this.btnconf.TabIndex = 52;
            this.btnconf.Text = "Confirmer";
            this.btnconf.Click += new System.EventHandler(this.btnconf_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(88, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 53;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // user
            // 
            this.user.BackColor = System.Drawing.SystemColors.GrayText;
            this.user.Image = ((System.Drawing.Image)(resources.GetObject("user.Image")));
            this.user.Location = new System.Drawing.Point(279, 313);
            this.user.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(40, 43);
            this.user.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.user.TabIndex = 56;
            this.user.TabStop = false;
            // 
            // male
            // 
            this.male.AutoSize = true;
            this.male.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.male.Cursor = System.Windows.Forms.Cursors.Hand;
            this.male.Font = new System.Drawing.Font("Cooper Black", 13.8F);
            this.male.ForeColor = System.Drawing.Color.Black;
            this.male.Location = new System.Drawing.Point(628, 406);
            this.male.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.male.Name = "male";
            this.male.Size = new System.Drawing.Size(92, 31);
            this.male.TabIndex = 2;
            this.male.Text = "mâle";
            this.male.UseVisualStyleBackColor = false;
            this.male.CheckedChanged += new System.EventHandler(this.male_CheckedChanged);
            // 
            // femelle
            // 
            this.femelle.AutoSize = true;
            this.femelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.femelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.femelle.Font = new System.Drawing.Font("Cooper Black", 13.8F);
            this.femelle.ForeColor = System.Drawing.Color.Black;
            this.femelle.Location = new System.Drawing.Point(745, 406);
            this.femelle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.femelle.Name = "femelle";
            this.femelle.Size = new System.Drawing.Size(123, 31);
            this.femelle.TabIndex = 57;
            this.femelle.Text = "femelle";
            this.femelle.UseVisualStyleBackColor = false;
            this.femelle.CheckedChanged += new System.EventHandler(this.femelle_CheckedChanged);
            // 
            // motclereg
            // 
            this.motclereg.AutoSize = true;
            this.motclereg.BackColor = System.Drawing.Color.Transparent;
            this.motclereg.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.motclereg.ForeColor = System.Drawing.Color.Red;
            this.motclereg.Location = new System.Drawing.Point(293, 372);
            this.motclereg.Name = "motclereg";
            this.motclereg.Size = new System.Drawing.Size(248, 27);
            this.motclereg.TabIndex = 58;
            this.motclereg.Text = "Ecrie Votre mot clé";
            this.motclereg.Visible = false;
            // 
            // conf
            // 
            this.conf.AutoSize = true;
            this.conf.BackColor = System.Drawing.Color.Transparent;
            this.conf.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conf.ForeColor = System.Drawing.Color.Red;
            this.conf.Location = new System.Drawing.Point(293, 462);
            this.conf.Name = "conf";
            this.conf.Size = new System.Drawing.Size(259, 27);
            this.conf.TabIndex = 59;
            this.conf.Text = "Récrie votre mot clé";
            this.conf.Visible = false;
            // 
            // wrongpass
            // 
            this.wrongpass.AutoSize = true;
            this.wrongpass.BackColor = System.Drawing.Color.Transparent;
            this.wrongpass.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wrongpass.ForeColor = System.Drawing.Color.Red;
            this.wrongpass.Location = new System.Drawing.Point(243, 462);
            this.wrongpass.Name = "wrongpass";
            this.wrongpass.Size = new System.Drawing.Size(343, 27);
            this.wrongpass.TabIndex = 60;
            this.wrongpass.Text = "Valider votre mot de passe ";
            this.wrongpass.Visible = false;
            // 
            // wronguser
            // 
            this.wronguser.AutoSize = true;
            this.wronguser.BackColor = System.Drawing.Color.Transparent;
            this.wronguser.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wronguser.ForeColor = System.Drawing.Color.Red;
            this.wronguser.Location = new System.Drawing.Point(242, 284);
            this.wronguser.Name = "wronguser";
            this.wronguser.Size = new System.Drawing.Size(371, 27);
            this.wronguser.TabIndex = 61;
            this.wronguser.Text = "Ecrie Votre nom d\'utilisateur";
            this.wronguser.Visible = false;
            // 
            // wrongnom
            // 
            this.wrongnom.AutoSize = true;
            this.wrongnom.BackColor = System.Drawing.Color.Transparent;
            this.wrongnom.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wrongnom.ForeColor = System.Drawing.Color.Red;
            this.wrongnom.Location = new System.Drawing.Point(274, 181);
            this.wrongnom.Name = "wrongnom";
            this.wrongnom.Size = new System.Drawing.Size(212, 27);
            this.wrongnom.TabIndex = 62;
            this.wrongnom.Text = "Ecrie Votre nom";
            this.wrongnom.Visible = false;
            // 
            // utilisateurDeja
            // 
            this.utilisateurDeja.AutoSize = true;
            this.utilisateurDeja.BackColor = System.Drawing.Color.Transparent;
            this.utilisateurDeja.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.utilisateurDeja.ForeColor = System.Drawing.Color.Red;
            this.utilisateurDeja.Location = new System.Drawing.Point(215, 284);
            this.utilisateurDeja.Name = "utilisateurDeja";
            this.utilisateurDeja.Size = new System.Drawing.Size(402, 27);
            this.utilisateurDeja.TabIndex = 63;
            this.utilisateurDeja.Text = "Ce nom d\'utilisateur déja utilisé";
            this.utilisateurDeja.Visible = false;
            // 
            // dateq
            // 
            this.dateq.AutoSize = true;
            this.dateq.BackColor = System.Drawing.Color.Transparent;
            this.dateq.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateq.ForeColor = System.Drawing.Color.Red;
            this.dateq.Location = new System.Drawing.Point(623, 284);
            this.dateq.Name = "dateq";
            this.dateq.Size = new System.Drawing.Size(378, 27);
            this.dateq.TabIndex = 65;
            this.dateq.Text = "Vous devez avoir plus de 5 ans";
            this.dateq.Visible = false;
            // 
            // genreq
            // 
            this.genreq.AutoSize = true;
            this.genreq.BackColor = System.Drawing.Color.Transparent;
            this.genreq.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genreq.ForeColor = System.Drawing.Color.Red;
            this.genreq.Location = new System.Drawing.Point(630, 377);
            this.genreq.Name = "genreq";
            this.genreq.Size = new System.Drawing.Size(231, 27);
            this.genreq.TabIndex = 66;
            this.genreq.Text = "Votre genre s.v.p?";
            this.genreq.Visible = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.btnExit.FlatAppearance.BorderSize = 2;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.Transparent;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExit.Location = new System.Drawing.Point(961, 9);
            this.btnExit.Margin = new System.Windows.Forms.Padding(0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(70, 70);
            this.btnExit.TabIndex = 67;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Datepicker
            // 
            this.Datepicker.Location = new System.Drawing.Point(635, 334);
            this.Datepicker.Name = "Datepicker";
            this.Datepicker.Size = new System.Drawing.Size(239, 22);
            this.Datepicker.TabIndex = 0;
            // 
            // page_Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1071, 615);
            this.Controls.Add(this.Datepicker);
            this.Controls.Add(this.utilisateurDeja);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.genreq);
            this.Controls.Add(this.dateq);
            this.Controls.Add(this.typeq);
            this.Controls.Add(this.wrongnom);
            this.Controls.Add(this.wronguser);
            this.Controls.Add(this.conf);
            this.Controls.Add(this.wrongpass);
            this.Controls.Add(this.motclereg);
            this.Controls.Add(this.femelle);
            this.Controls.Add(this.male);
            this.Controls.Add(this.user);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnconf);
            this.Controls.Add(this.usertxt);
            this.Controls.Add(this.pass1);
            this.Controls.Add(this.Confpass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtIcon3);
            this.Controls.Add(this.txtIcon1);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.PassTxt);
            this.Controls.Add(this.nom);
            this.Controls.Add(this.NomTxt);
            this.Controls.Add(this.txtIcon);
            this.Controls.Add(this.txtIcon2);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "page_Registration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "page_Registration";
            this.Load += new System.EventHandler(this.RegistrationForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.page_Registration_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIcon2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIcon1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIcon3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pass1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.user)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pass;
        private System.Windows.Forms.PictureBox nom;
        private System.Windows.Forms.PictureBox txtIcon;
        private System.Windows.Forms.PictureBox txtIcon2;
        private System.Windows.Forms.PictureBox txtIcon1;
        private System.Windows.Forms.PictureBox txtIcon3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pass1;
        private Guna.UI2.WinForms.Guna2Button btnconf;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox user;
        private System.Windows.Forms.Label motclereg;
        private System.Windows.Forms.Label conf;
        private System.Windows.Forms.Label wrongpass;
        public System.Windows.Forms.RadioButton male;
        public System.Windows.Forms.RadioButton femelle;
        public System.Windows.Forms.RadioButton radioBtnProf;
        public System.Windows.Forms.RadioButton radioBtnEleve;
        public System.Windows.Forms.TextBox NomTxt;
        public System.Windows.Forms.TextBox usertxt;
        public System.Windows.Forms.TextBox PassTxt;
        public System.Windows.Forms.TextBox Confpass;
        private System.Windows.Forms.Label wronguser;
        private System.Windows.Forms.Label wrongnom;
        private System.Windows.Forms.Label utilisateurDeja;
        private System.Windows.Forms.Label typeq;
        private System.Windows.Forms.Label dateq;
        private System.Windows.Forms.Label genreq;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DateTimePicker Datepicker;
    }
}