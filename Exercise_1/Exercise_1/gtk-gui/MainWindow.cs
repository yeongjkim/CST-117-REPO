
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.Fixed fixed1;

	private global::Gtk.Label lblMainText;

	private global::Gtk.Button btnClickme;

	private global::Gtk.Entry entry1;

	protected virtual void Build()
	{
		global::Stetic.Gui.Initialize(this);
		// Widget MainWindow
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString("MainWindow");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.fixed1 = new global::Gtk.Fixed();
		this.fixed1.Name = "fixed1";
		this.fixed1.HasWindow = false;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.lblMainText = new global::Gtk.Label();
		this.lblMainText.Name = "lblMainText";
		this.fixed1.Add(this.lblMainText);
		global::Gtk.Fixed.FixedChild w1 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.lblMainText]));
		w1.X = 173;
		w1.Y = 192;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.btnClickme = new global::Gtk.Button();
		this.btnClickme.CanFocus = true;
		this.btnClickme.Name = "btnClickme";
		this.btnClickme.UseUnderline = true;
		this.btnClickme.Label = global::Mono.Unix.Catalog.GetString("Click Me");
		this.fixed1.Add(this.btnClickme);
		global::Gtk.Fixed.FixedChild w2 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.btnClickme]));
		w2.X = 150;
		w2.Y = 93;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.entry1 = new global::Gtk.Entry();
		this.entry1.CanFocus = true;
		this.entry1.Name = "entry1";
		this.entry1.Text = global::Mono.Unix.Catalog.GetString("Yeong Kim\'s First GUI");
		this.entry1.IsEditable = true;
		this.entry1.InvisibleChar = '●';
		this.fixed1.Add(this.entry1);
		global::Gtk.Fixed.FixedChild w3 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.entry1]));
		w3.X = 136;
		w3.Y = 22;
		this.Add(this.fixed1);
		if ((this.Child != null))
		{
			this.Child.ShowAll();
		}
		this.DefaultWidth = 400;
		this.DefaultHeight = 300;
		this.Show();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler(this.OnDeleteEvent);
		this.btnClickme.Clicked += new global::System.EventHandler(this.ButtonClickMe_Clicked);
	}
}
