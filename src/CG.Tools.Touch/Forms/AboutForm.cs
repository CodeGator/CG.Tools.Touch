
namespace CG.Tools.Touch.Forms;

/// <summary>
/// This class is the code-behind for the about form.
/// </summary>
public partial class AboutForm : Form
{
    // *******************************************************************
    // Constructors.
    // *******************************************************************

    #region Constructors

    /// <summary>
    /// This constructor creates a new instance of the <see cref="AboutForm"/>
    /// class.
    /// </summary>
    public AboutForm()
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
        // Set the title.
        label1.Text = "About: " + typeof(AboutForm).Assembly.ReadTitle() +
            "  Version [" + typeof(AboutForm).Assembly.ReadInformationalVersion() +
            "]";

        // Set the description.
        label2.Text = typeof(AboutForm).Assembly.ReadDescription();

        // Set the copyright.
        label3.Text = typeof(AboutForm).Assembly.ReadCopyright();

        // Give the base class a chance.
        base.OnLoad(e);
    }

    #endregion

    // *******************************************************************
    // Private methods.
    // *******************************************************************

    #region Private methods

    /// <summary>
    /// This method handles the link click event.
    /// </summary>
    /// <param name="sender">The event sender</param>
    /// <param name="e">The event arguments</param>
    private void linkLabel1_LinkClicked(
        object sender, 
        LinkLabelLinkClickedEventArgs e
        )
    {
        Process.Start(
            new ProcessStartInfo("https://github.com/codegator/CG.Tools.Touch")
            {
                UseShellExecute = true,
                Verb = "open"
            }); 
    }

    #endregion
}
