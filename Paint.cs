using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintToScreen {
    public partial class Paint : Form {
        public Paint() {
            InitializeComponent();
        }

        private Graphics _graphics;
        private Pen _pen;
        private bool _isDrawing;
        private Point _preLocation;

        private void Paint_MouseDown(object sender, MouseEventArgs e) {
            _isDrawing = true;
            this.Opacity = 1 - this.Opacity;
        }

        private void Paint_MouseUp(object sender, MouseEventArgs e) {
            _isDrawing = false;
            _preLocation = Point.Empty;
            this.Opacity = 1 - this.Opacity;
        }

        private void Paint_MouseMove(object sender, MouseEventArgs e) {
            Point curLocation = e.Location;
            if (_isDrawing) {
                if (_preLocation == Point.Empty) {
                    _preLocation = e.Location;
                }
                else {
                    _graphics.DrawLine(_pen, curLocation, _preLocation);
                    _preLocation = curLocation;
                }
            }
            Point _holdLocation = _hold.Location;
            _holdLocation.X -= 5;
            if (_holdLocation.X == -_hold.Width) {
                _holdLocation.X = this.Width;
            }
            _hold.Location = _holdLocation;
        }

        private void _colorPicker_Click(object sender, EventArgs e) {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.Color = this._pen.Color;
            DialogResult dialogResult = colorDialog.ShowDialog();
            if (dialogResult == DialogResult.OK) {
                this._pen.Color = colorDialog.Color;
                if (this._pen.Color == this.BackColor) {
                    this._pen.Color = Color.Red;
                }
            }
        }

        private void Paint_Load(object sender, EventArgs e) {
            _graphics = this.CreateGraphics();
            _pen = new Pen(Color.Red, 5);
            _pen.StartCap = _pen.EndCap = LineCap.Round;
            _isDrawing = false;
            _preLocation = Point.Empty;
            this.Opacity = 0.3;

            _hold.Location = new Point(
                0,
                this.Height - _hold.Height);
        }

        private void _colorPicker_KeyDown(object sender, KeyEventArgs e) {
            switch (e.KeyCode) {
                case Keys.Escape:
                    this.Dispose();
                    break;
                case Keys.Z:
                    this.Refresh();
                    break;
            }
        }

        private void _hold_Click(object sender, EventArgs e) {
            if (this.TransparencyKey == Color.Empty) {
                this.TransparencyKey = this.BackColor;
            }
            else {
                this.TransparencyKey = Color.Empty;
            }
            this._colorPicker.Select();
        }
    }
}
