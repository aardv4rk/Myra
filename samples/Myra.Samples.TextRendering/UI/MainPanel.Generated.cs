/* Generated by MyraPad at 1/4/2024 7:37:43 AM */
using Myra;
using Myra.Graphics2D;
using Myra.Graphics2D.TextureAtlases;
using Myra.Graphics2D.UI;
using Myra.Graphics2D.Brushes;
using Myra.Graphics2D.UI.Properties;
using FontStashSharp.RichText;
using AssetManagementBase;

#if STRIDE
using Stride.Core.Mathematics;
#elif PLATFORM_AGNOSTIC
using System.Drawing;
using System.Numerics;
using Color = FontStashSharp.FSColor;
#else
// MonoGame/FNA
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
#endif

namespace Myra.Samples.TextRendering.UI
{
	partial class MainPanel: Panel
	{
		private void BuildUI()
		{
			_labelText = new Label();
			_labelText.TransformOrigin = new Vector2();
			_labelText.Id = "_labelText";

			var panel1 = new Panel();
			panel1.Background = new SolidBrush("#404040FF");
			panel1.ClipToBounds = true;
			StackPanel.SetProportionType(panel1, Myra.Graphics2D.UI.ProportionType.Part);
			panel1.Widgets.Add(_labelText);

			var horizontalSeparator1 = new HorizontalSeparator();

			var label1 = new Label();
			label1.Text = "Font:";

			_textBoxFont = new TextBox();
			_textBoxFont.Text = "(default)";
			_textBoxFont.Readonly = true;
			_textBoxFont.Id = "_textBoxFont";
			StackPanel.SetProportionType(_textBoxFont, Myra.Graphics2D.UI.ProportionType.Fill);

			var label2 = new Label();
			label2.Text = "Browse...";

			_buttonBrowseFont = new Button();
			_buttonBrowseFont.Id = "_buttonBrowseFont";
			_buttonBrowseFont.Content = label2;

			var label3 = new Label();
			label3.Text = "Reset";

			_buttonReset = new Button();
			_buttonReset.Id = "_buttonReset";
			_buttonReset.Content = label3;

			var horizontalStackPanel1 = new HorizontalStackPanel();
			horizontalStackPanel1.Spacing = 8;
			horizontalStackPanel1.Widgets.Add(label1);
			horizontalStackPanel1.Widgets.Add(_textBoxFont);
			horizontalStackPanel1.Widgets.Add(_buttonBrowseFont);
			horizontalStackPanel1.Widgets.Add(_buttonReset);

			var label4 = new Label();
			label4.Text = "Font Size:";

			_spinButtonFontSize = new SpinButton();
			_spinButtonFontSize.Value = 32;
			_spinButtonFontSize.Width = 40;
			_spinButtonFontSize.Id = "_spinButtonFontSize";

			var label5 = new Label();
			label5.Text = "Scale:";

			var label6 = new Label();
			label6.Text = "0.1";

			_sliderScale = new HorizontalSlider();
			_sliderScale.Minimum = 0.1f;
			_sliderScale.Maximum = 10;
			_sliderScale.Value = 1;
			_sliderScale.Width = 200;
			_sliderScale.Id = "_sliderScale";

			_labelScaleValue = new Label();
			_labelScaleValue.Text = "5.4";
			_labelScaleValue.HorizontalAlignment = Myra.Graphics2D.UI.HorizontalAlignment.Center;
			_labelScaleValue.Id = "_labelScaleValue";

			var verticalStackPanel1 = new VerticalStackPanel();
			verticalStackPanel1.Widgets.Add(_sliderScale);
			verticalStackPanel1.Widgets.Add(_labelScaleValue);

			var label7 = new Label();
			label7.Text = "10";

			var label8 = new Label();
			label8.Text = "StbTrueType";

			var label9 = new Label();
			label9.Text = "StbTrueType(Old Rasterizer)";

			_comboRasterizer = new ComboView();
			_comboRasterizer.Id = "_comboRasterizer";
			_comboRasterizer.Widgets.Add(label8);
			_comboRasterizer.Widgets.Add(label9);

			var label10 = new Label();
			label10.Text = "Default";

			var label11 = new Label();
			label11.Text = "NoSmoothing";

			_comboRenderer = new ComboView();
			_comboRenderer.Id = "_comboRenderer";
			_comboRenderer.Widgets.Add(label10);
			_comboRenderer.Widgets.Add(label11);

			var label12 = new Label();
			label12.Text = "Smooth Text";

			_checkBoxSmoothText = new CheckButton();
			_checkBoxSmoothText.Id = "_checkBoxSmoothText";
			_checkBoxSmoothText.Content = label12;

			var label13 = new Label();
			label13.Text = "Show Texture";

			_checkBoxShowTexture = new CheckButton();
			_checkBoxShowTexture.Id = "_checkBoxShowTexture";
			_checkBoxShowTexture.Content = label13;

			var horizontalStackPanel2 = new HorizontalStackPanel();
			horizontalStackPanel2.Spacing = 8;
			horizontalStackPanel2.Widgets.Add(label4);
			horizontalStackPanel2.Widgets.Add(_spinButtonFontSize);
			horizontalStackPanel2.Widgets.Add(label5);
			horizontalStackPanel2.Widgets.Add(label6);
			horizontalStackPanel2.Widgets.Add(verticalStackPanel1);
			horizontalStackPanel2.Widgets.Add(label7);
			horizontalStackPanel2.Widgets.Add(_comboRasterizer);
			horizontalStackPanel2.Widgets.Add(_comboRenderer);
			horizontalStackPanel2.Widgets.Add(_checkBoxSmoothText);
			horizontalStackPanel2.Widgets.Add(_checkBoxShowTexture);

			var label14 = new Label();
			label14.Text = "Resolution Factor:";

			_spinButtonResolutionFactor = new SpinButton();
			_spinButtonResolutionFactor.Minimum = 1;
			_spinButtonResolutionFactor.Value = 1;
			_spinButtonResolutionFactor.Width = 40;
			_spinButtonResolutionFactor.Id = "_spinButtonResolutionFactor";

			var label15 = new Label();
			label15.Text = "Kernel Width:";

			_spinButtonKernelWidth = new SpinButton();
			_spinButtonKernelWidth.Minimum = 0;
			_spinButtonKernelWidth.Width = 40;
			_spinButtonKernelWidth.Id = "_spinButtonKernelWidth";

			var label16 = new Label();
			label16.Text = "Kernel Height:";

			_spinButtonKernelHeight = new SpinButton();
			_spinButtonKernelHeight.Minimum = 0;
			_spinButtonKernelHeight.Width = 40;
			_spinButtonKernelHeight.Id = "_spinButtonKernelHeight";

			var horizontalStackPanel3 = new HorizontalStackPanel();
			horizontalStackPanel3.Spacing = 8;
			horizontalStackPanel3.Widgets.Add(label14);
			horizontalStackPanel3.Widgets.Add(_spinButtonResolutionFactor);
			horizontalStackPanel3.Widgets.Add(label15);
			horizontalStackPanel3.Widgets.Add(_spinButtonKernelWidth);
			horizontalStackPanel3.Widgets.Add(label16);
			horizontalStackPanel3.Widgets.Add(_spinButtonKernelHeight);

			var verticalStackPanel2 = new VerticalStackPanel();
			verticalStackPanel2.Spacing = 8;
			verticalStackPanel2.Padding = new Thickness(0, 8);
			verticalStackPanel2.Widgets.Add(horizontalStackPanel1);
			verticalStackPanel2.Widgets.Add(horizontalStackPanel2);
			verticalStackPanel2.Widgets.Add(horizontalStackPanel3);

			var horizontalSeparator2 = new HorizontalSeparator();

			_textBoxText = new TextBox();
			_textBoxText.Text = "/tuThe quick brown/n/ts/c[blue]fox jumps over/n/td/c[green]the lazy dog";
			_textBoxText.Multiline = true;
			_textBoxText.Wrap = true;
			_textBoxText.VerticalAlignment = Myra.Graphics2D.UI.VerticalAlignment.Stretch;
			_textBoxText.Id = "_textBoxText";

			var scrollViewer1 = new ScrollViewer();
			scrollViewer1.Content = _textBoxText;

			_imageTexture = new Image();
			_imageTexture.Id = "_imageTexture";

			var horizontalStackPanel4 = new HorizontalStackPanel();
			horizontalStackPanel4.DefaultProportion = new Proportion
			{
				Type = Myra.Graphics2D.UI.ProportionType.Part,
			};
			StackPanel.SetProportionType(horizontalStackPanel4, Myra.Graphics2D.UI.ProportionType.Part);
			horizontalStackPanel4.Widgets.Add(scrollViewer1);
			horizontalStackPanel4.Widgets.Add(_imageTexture);

			var verticalStackPanel3 = new VerticalStackPanel();
			verticalStackPanel3.Widgets.Add(panel1);
			verticalStackPanel3.Widgets.Add(horizontalSeparator1);
			verticalStackPanel3.Widgets.Add(verticalStackPanel2);
			verticalStackPanel3.Widgets.Add(horizontalSeparator2);
			verticalStackPanel3.Widgets.Add(horizontalStackPanel4);

			
			Widgets.Add(verticalStackPanel3);
		}

		
		public Label _labelText;
		public TextBox _textBoxFont;
		public Button _buttonBrowseFont;
		public Button _buttonReset;
		public SpinButton _spinButtonFontSize;
		public HorizontalSlider _sliderScale;
		public Label _labelScaleValue;
		public ComboView _comboRasterizer;
		public ComboView _comboRenderer;
		public CheckButton _checkBoxSmoothText;
		public CheckButton _checkBoxShowTexture;
		public SpinButton _spinButtonResolutionFactor;
		public SpinButton _spinButtonKernelWidth;
		public SpinButton _spinButtonKernelHeight;
		public TextBox _textBoxText;
		public Image _imageTexture;
	}
}
