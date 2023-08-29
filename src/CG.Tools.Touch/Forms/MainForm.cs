
namespace CG.Tools.Touch.Forms
{
    /// <summary>
    /// This class is the code-behind for the main form.
    /// </summary>
    public partial class MainForm : Form
    {
        // *******************************************************************
        // Fields.
        // *******************************************************************

        #region Fields

        /// <summary>
        /// This field contains the current file (if any);
        /// </summary>
        private string _filePath = "";

        #endregion

        // *******************************************************************
        // Constructors.
        // *******************************************************************

        #region Constructors

        /// <summary>
        /// This constructor creates a new instance of the <see cref="MainForm"/>
        /// class.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }

        #endregion

        // *******************************************************************
        // Protected methods.
        // *******************************************************************

        #region Protected methods

        /// <summary>
        /// This method is called to load the form.
        /// </summary>
        /// <param name="e">The event arguments.</param>
        protected override void OnLoad(EventArgs e)
        {
            // Set the caption.
            this.Text = typeof(AboutForm).Assembly.ReadTitle() +
                "  Version [" + typeof(AboutForm).Assembly.ReadInformationalVersion() +
                "]";

            // Fixup the state of the form.
            UpdateUI();

            // Give the base class a chance.
            base.OnLoad(e);
        }

        #endregion

        // *******************************************************************
        // Private methods.
        // *******************************************************************

        #region Private methods

        /// <summary>
        /// This method updates the UI to reflect the current state of the form.
        /// </summary>
        private void UpdateUI()
        {
            // Is a file selected?
            if (string.IsNullOrEmpty(_filePath))
            {
                // Nope, disable everything.
                groupBox2.Enabled = false;
                dateTimePickerLastWriteDate.Enabled = false;
                dateTimePickerLastWriteTime.Enabled = false;
                dateTimePickerCreateDate.Enabled = false;
                dateTimePickerCreateTime.Enabled = false;
                buttonSave.Enabled = false;
            }
            else
            {
                // Yup, enable everything.
                groupBox2.Enabled = true;
                dateTimePickerLastWriteDate.Enabled = true;
                dateTimePickerLastWriteTime.Enabled = true;
                dateTimePickerCreateDate.Enabled = true;
                dateTimePickerCreateTime.Enabled = true;

                var lastWrite = File.GetLastWriteTime(_filePath);
                dateTimePickerLastWriteDate.Value = lastWrite;
                dateTimePickerLastWriteTime.Value = lastWrite;

                var create = File.GetCreationTime(_filePath);
                dateTimePickerCreateDate.Value = create;
                dateTimePickerCreateTime.Value = create;

                buttonSave.Enabled = true;
            }

            // Set the save button colors.
            buttonSave.BackColor = buttonSave.Enabled ? Color.Blue : SystemColors.ButtonFace;
            buttonSave.ForeColor = buttonSave.Enabled ? Color.White : SystemColors.ControlText;
        }

        // *******************************************************************

        /// <summary>
        /// This method handles the About ... menu click.
        /// </summary>
        /// <param name="sender">The event sender.</param>
        /// <param name="e">The event arguments.</param>
        private void toolStripMenuItemAbout_Click(
            object sender,
            EventArgs e
            )
        {
            try
            {
                // Disable the menu item.
                toolStripMenuItemAbout.Enabled = false;

                // Show the about form.
                new AboutForm().ShowDialog();
            }
            catch (Exception ex)
            {
                // Ensure the popup centers over the application.
                using (DialogCenteringService centeringService = new DialogCenteringService(this))
                {
                    MessageBox.Show(
                        this,
                        "Failed to show the about form!",
                        this.Text,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Stop
                        );
                }
            }
            finally
            {
                // Enable the menu item.
                toolStripMenuItemAbout.Enabled = true;
            }
        }

        // *******************************************************************

        /// <summary>
        /// This method handles the browser click event.
        /// </summary>
        /// <param name="sender">The event sender.</param>
        /// <param name="e">The event arguments.</param>
        private void buttonFileBrowse_Click(
            object sender,
            EventArgs e
            )
        {
            if (openFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                _filePath = labelFilePath.Text = openFileDialog1.FileName;
            }
            else
            {
                labelFilePath.Text = "No file selected";
                _filePath = "";
            }

            // Fixup the state of the form.
            UpdateUI();
        }

        // *******************************************************************

        /// <summary>
        /// This method handles the button save event.
        /// </summary>
        /// <param name="sender">The event sender.</param>
        /// <param name="e">The event arguments.</param>
        private void buttonSave_Click(
            object sender,
            EventArgs e
            )
        {
            try
            {
                if (!string.IsNullOrEmpty(_filePath))
                {
                    var lastWrite = new DateTime(
                            dateTimePickerLastWriteDate.Value.Year,
                            dateTimePickerLastWriteDate.Value.Month,
                            dateTimePickerLastWriteDate.Value.Day,
                            dateTimePickerLastWriteTime.Value.Hour,
                            dateTimePickerLastWriteTime.Value.Minute,
                            dateTimePickerLastWriteTime.Value.Second
                            );
                    var create = new DateTime(
                            dateTimePickerCreateDate.Value.Year,
                            dateTimePickerCreateDate.Value.Month,
                            dateTimePickerCreateDate.Value.Day,
                            dateTimePickerCreateTime.Value.Hour,
                            dateTimePickerCreateTime.Value.Minute,
                            dateTimePickerCreateTime.Value.Second
                            );

                    Utility.TouchFile(
                        _filePath,
                        lastWrite,
                        create
                        );

                    // Ensure the popup centers over the application.
                    using (DialogCenteringService centeringService = new DialogCenteringService(this))
                    {
                        MessageBox.Show(
                            this,
                            "Changes were saved.",
                            this.Text,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                            );
                    }
                }
            }
            catch (Exception ex)
            {
                // Ensure the popup centers over the application.
                using (DialogCenteringService centeringService = new DialogCenteringService(this))
                {
                    MessageBox.Show(
                        this,
                        "Failed to save changes!",
                        this.Text,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Stop
                        );
                }
            }
        }

        // *******************************************************************

        /// <summary>
        /// This method handles the form drag/drop enter event.
        /// </summary>
        /// <param name="sender">The event sender.</param>
        /// <param name="e">The event arguments.</param>
        private void MainForm_DragEnter(object sender, DragEventArgs e)
        {
            // Set the drag/drop feedback.
            e.Effect = e.Data.GetDataPresent(DataFormats.FileDrop)
                ? DragDropEffects.Copy : DragDropEffects.None;
        }

        // *******************************************************************

        /// <summary>
        /// This method handles the form drag/drop event.
        /// </summary>
        /// <param name="sender">The event sender.</param>
        /// <param name="e">The event arguments.</param>
        private void MainForm_DragDrop(object sender, DragEventArgs e)
        {
            // Get the data from the drag/drop.
            var files = (e.Data?.GetData(DataFormats.FileDrop) ??
                Array.Empty<string>()) as string[];

            // More than one file?
            if (files?.Length != 1)
            {
                // Ensure the popup centers over the application.
                using (DialogCenteringService centeringService = new DialogCenteringService(this))
                {
                    // Prompt the user.
                    MessageBox.Show(
                        this,
                        "Please drop one file at a time.",
                        this.Text,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                        );
                }
            }
            else
            {
                // Save the path.
                _filePath = labelFilePath.Text = files[0];

                // Fixup the state of the form.
                UpdateUI();
            }
        }

        #endregion
    }
}
