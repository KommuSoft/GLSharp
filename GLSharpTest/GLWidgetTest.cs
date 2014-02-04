using System;
using GLSharp;
using Gtk;

namespace GLSharpTest {
	public partial class GLWidgetTest : Window {
		private GLWidget glwidget1;

		public GLWidgetTest () : base (WindowType.Toplevel) {
			Build ();
		}

		protected void OnDeleteEvent (object sender, DeleteEventArgs a) {
			Application.Quit ();
			a.RetVal = true;
		}

		protected virtual void Build () {
			Stetic.Gui.Initialize (this);
			// Widget MainWindow
			this.Name = "MainWindow";
			this.Title = "MainWindow";
			this.WindowPosition = ((Gtk.WindowPosition)(4));
			// Container child MainWindow.Gtk.Container+ContainerChild
			this.glwidget1 = new GLWidget ();
			this.glwidget1.Name = "glwidget1";
			this.glwidget1.SingleBuffer = false;
			this.glwidget1.ColorBPP = 0;
			this.glwidget1.AccumulatorBPP = 0;
			this.glwidget1.DepthBPP = 0;
			this.glwidget1.StencilBPP = 0;
			this.glwidget1.Samples = 0;
			this.glwidget1.Stereo = false;
			this.glwidget1.GlVersionMajor = 0;
			this.glwidget1.GlVersionMinor = 0;
			this.Add (this.glwidget1);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 400;
			this.DefaultHeight = 300;
			this.Show ();
			this.DeleteEvent += new Gtk.DeleteEventHandler (this.OnDeleteEvent);
		}

		public static void Main (string[] args) {
			Application.Init ();
			GLWidgetTest win = new GLWidgetTest ();
			win.Show ();
			Application.Run ();
		}
	}
}

