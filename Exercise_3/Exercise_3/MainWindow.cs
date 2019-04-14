using System;
using Gtk;

public partial class MainWindow : Gtk.Window
{
    Double eWeight;
    Double mWeight;

    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();
    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }

    private void ButtonConvert_Clicked(object sender, EventArgs args)
    {
        eWeight = Convert.ToDouble(this.eWeightField.Text);
        mWeight = (eWeight / 9.81) * 3.711;
        mWeightField.Text = mWeight.ToString();
    }
}

