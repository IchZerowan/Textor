namespace Textor
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.rtbMain = new System.Windows.Forms.RichTextBox();
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.tsmiFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNew = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSave = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSeparetor1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiPrint = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUndo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRedo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiCut = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiSelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiClear = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFont = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFontColor = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBackColor = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTextFont = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiView = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBackground = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiInsert = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDate = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTime = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiTimeNow = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTimeOther = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.dlgColor = new System.Windows.Forms.ColorDialog();
            this.dlgSave = new System.Windows.Forms.SaveFileDialog();
            this.dlgOpen = new System.Windows.Forms.OpenFileDialog();
            this.Calendar = new System.Windows.Forms.MonthCalendar();
            this.cmsCalendar = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiCalendarClose = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDateToday = new System.Windows.Forms.ToolStripMenuItem();
            this.mtbTime = new System.Windows.Forms.MaskedTextBox();
            this.dlgFont = new System.Windows.Forms.FontDialog();
            this.tsMain = new System.Windows.Forms.ToolStrip();
            this.stbtnAlign_left = new System.Windows.Forms.ToolStripButton();
            this.stbtnAlign_center = new System.Windows.Forms.ToolStripButton();
            this.stbtnAlign_right = new System.Windows.Forms.ToolStripButton();
            this.themeColorPickerToolStripSplitButton = new ExHtmlEditor.ColorPicker.ThemeColorPickerToolStripSplitButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.fontComboBox = new FontCombo.FontComboBox();
            this.msMain.SuspendLayout();
            this.cmsCalendar.SuspendLayout();
            this.tsMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtbMain
            // 
            this.rtbMain.AcceptsTab = true;
            this.rtbMain.AutoWordSelection = true;
            this.rtbMain.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rtbMain.Location = new System.Drawing.Point(0, 52);
            this.rtbMain.Name = "rtbMain";
            this.rtbMain.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtbMain.Size = new System.Drawing.Size(618, 308);
            this.rtbMain.TabIndex = 0;
            this.rtbMain.Text = "";
            this.rtbMain.SelectionChanged += new System.EventHandler(this.rtbMain_SelectionChanged);
            this.rtbMain.KeyUp += new System.Windows.Forms.KeyEventHandler(this.rtbMain_KeyUp);
            // 
            // msMain
            // 
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFile,
            this.tsmiEdit,
            this.tsmiFont,
            this.tsmiView,
            this.tsmiInsert,
            this.tsmiHelp});
            this.msMain.Location = new System.Drawing.Point(0, 0);
            this.msMain.Name = "msMain";
            this.msMain.Size = new System.Drawing.Size(618, 24);
            this.msMain.TabIndex = 1;
            this.msMain.Text = "menuStrip1";
            // 
            // tsmiFile
            // 
            this.tsmiFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiNew,
            this.tsmiOpen,
            this.tsmiSave,
            this.tsmiSaveAs,
            this.tsmiSeparetor1,
            this.tsmiPrint,
            this.tsmiExit});
            this.tsmiFile.Name = "tsmiFile";
            this.tsmiFile.Size = new System.Drawing.Size(48, 20);
            this.tsmiFile.Text = "Файл";
            // 
            // tsmiNew
            // 
            this.tsmiNew.Name = "tsmiNew";
            this.tsmiNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.tsmiNew.Size = new System.Drawing.Size(216, 22);
            this.tsmiNew.Text = "Новый";
            this.tsmiNew.Click += new System.EventHandler(this.tsmiNew_Click);
            // 
            // tsmiOpen
            // 
            this.tsmiOpen.Name = "tsmiOpen";
            this.tsmiOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.tsmiOpen.Size = new System.Drawing.Size(216, 22);
            this.tsmiOpen.Text = "Открыть";
            this.tsmiOpen.Click += new System.EventHandler(this.tsmiOpen_Click);
            // 
            // tsmiSave
            // 
            this.tsmiSave.Name = "tsmiSave";
            this.tsmiSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.tsmiSave.Size = new System.Drawing.Size(216, 22);
            this.tsmiSave.Text = "Сохранить";
            this.tsmiSave.Click += new System.EventHandler(this.tsmiSave_Click);
            // 
            // tsmiSaveAs
            // 
            this.tsmiSaveAs.Name = "tsmiSaveAs";
            this.tsmiSaveAs.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.S)));
            this.tsmiSaveAs.Size = new System.Drawing.Size(216, 22);
            this.tsmiSaveAs.Text = "Сохранить как";
            this.tsmiSaveAs.Click += new System.EventHandler(this.tsmiSaveAs_Click);
            // 
            // tsmiSeparetor1
            // 
            this.tsmiSeparetor1.Name = "tsmiSeparetor1";
            this.tsmiSeparetor1.Size = new System.Drawing.Size(213, 6);
            // 
            // tsmiPrint
            // 
            this.tsmiPrint.Name = "tsmiPrint";
            this.tsmiPrint.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.tsmiPrint.Size = new System.Drawing.Size(216, 22);
            this.tsmiPrint.Text = "Печать";
            this.tsmiPrint.Click += new System.EventHandler(this.tsmiPrint_Click);
            // 
            // tsmiExit
            // 
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.tsmiExit.Size = new System.Drawing.Size(216, 22);
            this.tsmiExit.Text = "Выход";
            this.tsmiExit.Click += new System.EventHandler(this.tsmiExit_Click);
            // 
            // tsmiEdit
            // 
            this.tsmiEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiUndo,
            this.tsmiRedo,
            this.tsmiSeparator2,
            this.tsmiCut,
            this.tsmiCopy,
            this.tsmiPaste,
            this.tsmiSeparator3,
            this.tsmiSelectAll,
            this.tsmiClear});
            this.tsmiEdit.Name = "tsmiEdit";
            this.tsmiEdit.Size = new System.Drawing.Size(59, 20);
            this.tsmiEdit.Text = "Правка";
            // 
            // tsmiUndo
            // 
            this.tsmiUndo.Name = "tsmiUndo";
            this.tsmiUndo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.tsmiUndo.Size = new System.Drawing.Size(190, 22);
            this.tsmiUndo.Text = "Отменить";
            this.tsmiUndo.Click += new System.EventHandler(this.tsmiUndo_Click);
            // 
            // tsmiRedo
            // 
            this.tsmiRedo.Name = "tsmiRedo";
            this.tsmiRedo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.tsmiRedo.Size = new System.Drawing.Size(190, 22);
            this.tsmiRedo.Text = "Вернуть";
            this.tsmiRedo.Click += new System.EventHandler(this.tsmiRedo_Click);
            // 
            // tsmiSeparator2
            // 
            this.tsmiSeparator2.Name = "tsmiSeparator2";
            this.tsmiSeparator2.Size = new System.Drawing.Size(187, 6);
            // 
            // tsmiCut
            // 
            this.tsmiCut.Name = "tsmiCut";
            this.tsmiCut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.tsmiCut.Size = new System.Drawing.Size(190, 22);
            this.tsmiCut.Text = "Вырезать";
            this.tsmiCut.Click += new System.EventHandler(this.tsmiCut_Click);
            // 
            // tsmiCopy
            // 
            this.tsmiCopy.Name = "tsmiCopy";
            this.tsmiCopy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.tsmiCopy.Size = new System.Drawing.Size(190, 22);
            this.tsmiCopy.Text = "Копировать";
            this.tsmiCopy.Click += new System.EventHandler(this.tsmiCopy_Click);
            // 
            // tsmiPaste
            // 
            this.tsmiPaste.Name = "tsmiPaste";
            this.tsmiPaste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.tsmiPaste.Size = new System.Drawing.Size(190, 22);
            this.tsmiPaste.Text = "Вставить";
            this.tsmiPaste.Click += new System.EventHandler(this.tsmiPaste_Click);
            // 
            // tsmiSeparator3
            // 
            this.tsmiSeparator3.Name = "tsmiSeparator3";
            this.tsmiSeparator3.Size = new System.Drawing.Size(187, 6);
            // 
            // tsmiSelectAll
            // 
            this.tsmiSelectAll.Name = "tsmiSelectAll";
            this.tsmiSelectAll.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.tsmiSelectAll.Size = new System.Drawing.Size(190, 22);
            this.tsmiSelectAll.Text = "Выделить все";
            this.tsmiSelectAll.Click += new System.EventHandler(this.выделитьВсеToolStripMenuItem_Click);
            // 
            // tsmiClear
            // 
            this.tsmiClear.Name = "tsmiClear";
            this.tsmiClear.Size = new System.Drawing.Size(190, 22);
            this.tsmiClear.Text = "Очистить";
            this.tsmiClear.Click += new System.EventHandler(this.tsmiClear_Click);
            // 
            // tsmiFont
            // 
            this.tsmiFont.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFontColor,
            this.tsmiBackColor,
            this.tsmiTextFont});
            this.tsmiFont.Name = "tsmiFont";
            this.tsmiFont.Size = new System.Drawing.Size(58, 20);
            this.tsmiFont.Text = "Шрифт";
            // 
            // tsmiFontColor
            // 
            this.tsmiFontColor.Name = "tsmiFontColor";
            this.tsmiFontColor.Size = new System.Drawing.Size(137, 22);
            this.tsmiFontColor.Text = "Цвет текста";
            this.tsmiFontColor.Click += new System.EventHandler(this.tsmiFontColor_Click);
            // 
            // tsmiBackColor
            // 
            this.tsmiBackColor.Name = "tsmiBackColor";
            this.tsmiBackColor.Size = new System.Drawing.Size(137, 22);
            this.tsmiBackColor.Text = "Цвет фона";
            this.tsmiBackColor.Click += new System.EventHandler(this.tsmiBackColor_Click);
            // 
            // tsmiTextFont
            // 
            this.tsmiTextFont.Name = "tsmiTextFont";
            this.tsmiTextFont.Size = new System.Drawing.Size(137, 22);
            this.tsmiTextFont.Text = "Шрифт";
            this.tsmiTextFont.Click += new System.EventHandler(this.tsmiTextFont_Click);
            // 
            // tsmiView
            // 
            this.tsmiView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiBackground});
            this.tsmiView.Name = "tsmiView";
            this.tsmiView.Size = new System.Drawing.Size(39, 20);
            this.tsmiView.Text = "Вид";
            // 
            // tsmiBackground
            // 
            this.tsmiBackground.Name = "tsmiBackground";
            this.tsmiBackground.Size = new System.Drawing.Size(97, 22);
            this.tsmiBackground.Text = "Фон";
            this.tsmiBackground.Click += new System.EventHandler(this.tsmiBackground_Click);
            // 
            // tsmiInsert
            // 
            this.tsmiInsert.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiDate,
            this.tsmiTime});
            this.tsmiInsert.Name = "tsmiInsert";
            this.tsmiInsert.Size = new System.Drawing.Size(61, 20);
            this.tsmiInsert.Text = "Вставка";
            // 
            // tsmiDate
            // 
            this.tsmiDate.Name = "tsmiDate";
            this.tsmiDate.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.tsmiDate.Size = new System.Drawing.Size(141, 22);
            this.tsmiDate.Text = "Дата";
            this.tsmiDate.Click += new System.EventHandler(this.tsmiDate_Click);
            // 
            // tsmiTime
            // 
            this.tsmiTime.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmiTimeNow,
            this.tsmiTimeOther});
            this.tsmiTime.Name = "tsmiTime";
            this.tsmiTime.Size = new System.Drawing.Size(141, 22);
            this.tsmiTime.Text = "Время";
            // 
            // TsmiTimeNow
            // 
            this.TsmiTimeNow.Name = "TsmiTimeNow";
            this.TsmiTimeNow.Size = new System.Drawing.Size(114, 22);
            this.TsmiTimeNow.Text = "Сейчас";
            this.TsmiTimeNow.Click += new System.EventHandler(this.TsmiTimeNow_Click);
            // 
            // tsmiTimeOther
            // 
            this.tsmiTimeOther.Name = "tsmiTimeOther";
            this.tsmiTimeOther.Size = new System.Drawing.Size(114, 22);
            this.tsmiTimeOther.Text = "Другое";
            this.tsmiTimeOther.Click += new System.EventHandler(this.tsmiTimeOther_Click);
            // 
            // tsmiHelp
            // 
            this.tsmiHelp.Name = "tsmiHelp";
            this.tsmiHelp.Size = new System.Drawing.Size(65, 20);
            this.tsmiHelp.Text = "Справка";
            // 
            // dlgColor
            // 
            this.dlgColor.AnyColor = true;
            this.dlgColor.Color = System.Drawing.Color.White;
            this.dlgColor.FullOpen = true;
            // 
            // dlgSave
            // 
            this.dlgSave.DefaultExt = "*.rtf";
            this.dlgSave.Filter = "RichTextFiles|*.rtf";
            this.dlgSave.FileOk += new System.ComponentModel.CancelEventHandler(this.dlgSave_FileOk);
            // 
            // dlgOpen
            // 
            this.dlgOpen.FileOk += new System.ComponentModel.CancelEventHandler(this.dlgOpen_FileOk);
            // 
            // Calendar
            // 
            this.Calendar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Calendar.ContextMenuStrip = this.cmsCalendar;
            this.Calendar.Location = new System.Drawing.Point(402, 75);
            this.Calendar.Name = "Calendar";
            this.Calendar.ShowWeekNumbers = true;
            this.Calendar.TabIndex = 2;
            this.Calendar.Visible = false;
            this.Calendar.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.Calendar_DateSelected);
            // 
            // cmsCalendar
            // 
            this.cmsCalendar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCalendarClose,
            this.tsmiDateToday});
            this.cmsCalendar.Name = "cmsCalendar";
            this.cmsCalendar.Size = new System.Drawing.Size(185, 48);
            // 
            // tsmiCalendarClose
            // 
            this.tsmiCalendarClose.Name = "tsmiCalendarClose";
            this.tsmiCalendarClose.Size = new System.Drawing.Size(184, 22);
            this.tsmiCalendarClose.Text = "Закрыть";
            this.tsmiCalendarClose.Click += new System.EventHandler(this.tsmiCalendarClose_Click);
            // 
            // tsmiDateToday
            // 
            this.tsmiDateToday.Name = "tsmiDateToday";
            this.tsmiDateToday.Size = new System.Drawing.Size(184, 22);
            this.tsmiDateToday.Text = "К сегодняшней дате";
            this.tsmiDateToday.Click += new System.EventHandler(this.tsmiDateToday_Click);
            // 
            // mtbTime
            // 
            this.mtbTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mtbTime.Location = new System.Drawing.Point(554, 75);
            this.mtbTime.Mask = "90:00";
            this.mtbTime.Name = "mtbTime";
            this.mtbTime.Size = new System.Drawing.Size(34, 20);
            this.mtbTime.TabIndex = 4;
            this.mtbTime.ValidatingType = typeof(System.DateTime);
            this.mtbTime.Visible = false;
            this.mtbTime.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mtbTime_KeyDown);
            // 
            // tsMain
            // 
            this.tsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.themeColorPickerToolStripSplitButton,
            this.stbtnAlign_left,
            this.stbtnAlign_center,
            this.stbtnAlign_right,
            this.toolStripLabel1});
            this.tsMain.Location = new System.Drawing.Point(0, 24);
            this.tsMain.Name = "tsMain";
            this.tsMain.Size = new System.Drawing.Size(618, 25);
            this.tsMain.TabIndex = 5;
            this.tsMain.Text = "toolStrip1";
            // 
            // stbtnAlign_left
            // 
            this.stbtnAlign_left.Checked = true;
            this.stbtnAlign_left.CheckState = System.Windows.Forms.CheckState.Checked;
            this.stbtnAlign_left.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.stbtnAlign_left.Image = global::Textor.Properties.Resources.edit_alignment_6041;
            this.stbtnAlign_left.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stbtnAlign_left.Name = "stbtnAlign_left";
            this.stbtnAlign_left.Size = new System.Drawing.Size(23, 22);
            this.stbtnAlign_left.Text = "выравнять по левому краю";
            this.stbtnAlign_left.Click += new System.EventHandler(this.stbtnAlign_left_Click);
            // 
            // stbtnAlign_center
            // 
            this.stbtnAlign_center.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.stbtnAlign_center.Image = global::Textor.Properties.Resources.edit_alignment_center;
            this.stbtnAlign_center.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stbtnAlign_center.Name = "stbtnAlign_center";
            this.stbtnAlign_center.Size = new System.Drawing.Size(23, 22);
            this.stbtnAlign_center.Text = "выравнять по центру";
            this.stbtnAlign_center.Click += new System.EventHandler(this.stbtnAlign_center_Click);
            // 
            // stbtnAlign_right
            // 
            this.stbtnAlign_right.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.stbtnAlign_right.Image = global::Textor.Properties.Resources.edit_alignment_right_1840;
            this.stbtnAlign_right.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stbtnAlign_right.Name = "stbtnAlign_right";
            this.stbtnAlign_right.Size = new System.Drawing.Size(23, 22);
            this.stbtnAlign_right.Text = "выравнять по правому краю";
            this.stbtnAlign_right.Click += new System.EventHandler(this.stbtnAlign_right_Click);
            // 
            // themeColorPickerToolStripSplitButton
            // 
            this.themeColorPickerToolStripSplitButton.Color = System.Drawing.Color.Black;
            this.themeColorPickerToolStripSplitButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.themeColorPickerToolStripSplitButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.themeColorPickerToolStripSplitButton.Image = ((System.Drawing.Image)(resources.GetObject("themeColorPickerToolStripSplitButton.Image")));
            this.themeColorPickerToolStripSplitButton.ImageHeight = 16;
            this.themeColorPickerToolStripSplitButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.themeColorPickerToolStripSplitButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.themeColorPickerToolStripSplitButton.ImageWidth = 32;
            this.themeColorPickerToolStripSplitButton.Name = "themeColorPickerToolStripSplitButton";
            this.themeColorPickerToolStripSplitButton.Size = new System.Drawing.Size(32, 22);
            this.themeColorPickerToolStripSplitButton.Text = "Цвет текста";
            this.themeColorPickerToolStripSplitButton.ColorSelected += new ExHtmlEditor.ColorPicker.ThemeColorPickerToolStripSplitButton.colorSelected(this.themeColorPickerToolStripSplitButton_ColorSelected);
            this.themeColorPickerToolStripSplitButton.ButtonClick += new System.EventHandler(this.themeColorPickerToolStripSplitButton_ButtonClick);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(0, 22);
            // 
            // fontComboBox
            // 
            this.fontComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.fontComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fontComboBox.FormattingEnabled = true;
            this.fontComboBox.IntegralHeight = false;
            this.fontComboBox.Location = new System.Drawing.Point(143, 27);
            this.fontComboBox.MaxDropDownItems = 20;
            this.fontComboBox.Name = "fontComboBox";
            this.fontComboBox.Size = new System.Drawing.Size(121, 21);
            this.fontComboBox.TabIndex = 6;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 360);
            this.Controls.Add(this.fontComboBox);
            this.Controls.Add(this.tsMain);
            this.Controls.Add(this.mtbTime);
            this.Controls.Add(this.Calendar);
            this.Controls.Add(this.rtbMain);
            this.Controls.Add(this.msMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msMain;
            this.Name = "MainForm";
            this.Text = "Textor";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            this.cmsCalendar.ResumeLayout(false);
            this.tsMain.ResumeLayout(false);
            this.tsMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbMain;
        private System.Windows.Forms.MenuStrip msMain;
        private System.Windows.Forms.ToolStripMenuItem tsmiFile;
        private System.Windows.Forms.ToolStripMenuItem tsmiNew;
        private System.Windows.Forms.ToolStripMenuItem tsmiOpen;
        private System.Windows.Forms.ToolStripMenuItem tsmiSave;
        private System.Windows.Forms.ToolStripMenuItem tsmiSaveAs;
        private System.Windows.Forms.ToolStripSeparator tsmiSeparetor1;
        private System.Windows.Forms.ToolStripMenuItem tsmiPrint;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private System.Windows.Forms.ToolStripMenuItem tsmiEdit;
        private System.Windows.Forms.ToolStripMenuItem tsmiUndo;
        private System.Windows.Forms.ToolStripSeparator tsmiSeparator2;
        private System.Windows.Forms.ToolStripMenuItem tsmiCut;
        private System.Windows.Forms.ToolStripMenuItem tsmiCopy;
        private System.Windows.Forms.ToolStripMenuItem tsmiPaste;
        private System.Windows.Forms.ToolStripSeparator tsmiSeparator3;
        private System.Windows.Forms.ToolStripMenuItem tsmiClear;
        private System.Windows.Forms.ToolStripMenuItem tsmiView;
        private System.Windows.Forms.ToolStripMenuItem tsmiBackground;
        private System.Windows.Forms.ToolStripMenuItem tsmiHelp;
        private System.Windows.Forms.ToolStripMenuItem tsmiRedo;
        private System.Windows.Forms.ColorDialog dlgColor;
        private System.Windows.Forms.SaveFileDialog dlgSave;
        private System.Windows.Forms.OpenFileDialog dlgOpen;
        private System.Windows.Forms.ToolStripMenuItem tsmiSelectAll;
        private System.Windows.Forms.ToolStripMenuItem tsmiInsert;
        private System.Windows.Forms.ToolStripMenuItem tsmiDate;
        private System.Windows.Forms.MonthCalendar Calendar;
        private System.Windows.Forms.ContextMenuStrip cmsCalendar;
        private System.Windows.Forms.ToolStripMenuItem tsmiCalendarClose;
        private System.Windows.Forms.ToolStripMenuItem tsmiDateToday;
        private System.Windows.Forms.ToolStripMenuItem tsmiTime;
        private System.Windows.Forms.ToolStripMenuItem TsmiTimeNow;
        private System.Windows.Forms.ToolStripMenuItem tsmiTimeOther;
        private System.Windows.Forms.MaskedTextBox mtbTime;
        private System.Windows.Forms.ToolStripMenuItem tsmiFont;
        private System.Windows.Forms.ToolStripMenuItem tsmiFontColor;
        private System.Windows.Forms.ToolStripMenuItem tsmiBackColor;
        private System.Windows.Forms.FontDialog dlgFont;
        private System.Windows.Forms.ToolStripMenuItem tsmiTextFont;
        private System.Windows.Forms.ToolStrip tsMain;
        private System.Windows.Forms.ToolStripButton stbtnAlign_left;
        private System.Windows.Forms.ToolStripButton stbtnAlign_center;
        private System.Windows.Forms.ToolStripButton stbtnAlign_right;
        private ExHtmlEditor.ColorPicker.ThemeColorPickerToolStripSplitButton themeColorPickerToolStripSplitButton;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private FontCombo.FontComboBox fontComboBox;
    }
}

