using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Imaging;
using AForge;
using AForge.Imaging.Filters;
using AForge.Imaging.ComplexFilters;
using AForge.Imaging.ColorReduction;
using AForge.Imaging.Textures;

namespace Editor_Imágenes
{
    public partial class frmEditarImágenes : Form
    {
        
        public frmEditarImágenes()
        {
            InitializeComponent();
        }

        private void frmEditarImágenes_Load(object sender, EventArgs e)
        {
            
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pcbImagen1.Image = null;
            pcbImagen2.Image = null;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog cargar = new OpenFileDialog();
            cargar.InitialDirectory = "C:\\";
            cargar.Title = "Abrir Imágen";
            cargar.Filter = "Image Files|*.jpg; *.jpeg; *.png; *.gif; *.svg";
            cargar.FilterIndex = 4;
            cargar.RestoreDirectory = true;
            cargar.ShowDialog();

            pcbImagen1.Load(cargar.FileName);
            pcbImagen1.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog guardar = new SaveFileDialog();
                guardar.DefaultExt = "jpeg";
                guardar.Filter = "Image Files|*.jpg; *.jpeg; *.png; *.gif; *.svg";

                if (guardar.ShowDialog() == DialogResult.OK)
                {
                    pcbImagen2.Image.Save(guardar.FileName);
                    MessageBox.Show("Se guardó", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw ex;
            }
        }

        private void adaptiveSmoothingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdaptiveSmoothing adaptiveSmoothing = new AdaptiveSmoothing();
            pcbImagen2.Image = adaptiveSmoothing.Apply((Bitmap)pcbImagen1.Image);
        }

        private void additiveNoiseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdditiveNoise additiveNoise = new AdditiveNoise();
            pcbImagen2.Image = additiveNoise.Apply((Bitmap)pcbImagen1.Image);
        }

        private void grayscaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Grayscale grayscale = new Grayscale(0.2125, 0.7154, 0.0721);
            pcbImagen2.Image = grayscale.Apply((Bitmap)pcbImagen1.Image);
        }

        private void bilateralSmoothingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BilateralSmoothing bilateralSmoothing = new BilateralSmoothing();
            pcbImagen2.Image = bilateralSmoothing.Apply((Bitmap)pcbImagen1.Image);
        }

        private void binaryErosion3x3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BinaryErosion3x3 binaryErosion3X3 = new BinaryErosion3x3();
            pcbImagen2.Image = binaryErosion3X3.Apply((Bitmap)pcbImagen1.Image);
        }

        private void blobsFilteringToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BlobsFiltering blobsFiltering = new BlobsFiltering();
            pcbImagen2.Image = blobsFiltering.Apply((Bitmap)pcbImagen1.Image);
        }

        private void blurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Blur blur = new Blur();
            pcbImagen2.Image = blur.Apply((Bitmap)pcbImagen1.Image);
        }

        private void bottomHatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BottomHat bottomHat = new BottomHat();
            pcbImagen2.Image = bottomHat.Apply((Bitmap)pcbImagen1.Image);
        }

        private void brightnessCorrectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BrightnessCorrection brightnessCorrection = new BrightnessCorrection();
            pcbImagen2.Image = brightnessCorrection.Apply((Bitmap)pcbImagen1.Image);
        }

        private void channelFilteringToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChannelFiltering channelFiltering = new ChannelFiltering();
            pcbImagen2.Image = channelFiltering.Apply((Bitmap)pcbImagen1.Image);
        }

        private void colorFilteringToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorFiltering colorFiltering = new ColorFiltering();
            pcbImagen2.Image = colorFiltering.Apply((Bitmap)pcbImagen1.Image);
        }

        private void colorRemappingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorRemapping colorRemapping = new ColorRemapping();
            pcbImagen2.Image = colorRemapping.Apply((Bitmap)pcbImagen1.Image);
        }

        private void connectedComponentsLabelingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConnectedComponentsLabeling connectedComponentsLabeling = new ConnectedComponentsLabeling();
            pcbImagen2.Image = connectedComponentsLabeling.Apply((Bitmap)pcbImagen1.Image);
        }

        private void conservativeSmoothingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConservativeSmoothing conservativeSmoothing = new ConservativeSmoothing();
            pcbImagen2.Image = conservativeSmoothing.Apply((Bitmap)pcbImagen1.Image);
        }

        private void contrastCorrectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ContrastCorrection contrastCorrection = new ContrastCorrection();
            pcbImagen2.Image = contrastCorrection.Apply((Bitmap)pcbImagen1.Image);
        }

        private void contrastStretchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ContrastStretch contrastStretch = new ContrastStretch();
            pcbImagen2.Image = contrastStretch.Apply((Bitmap)pcbImagen1.Image);
        }

        private void dilatationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dilatation dilatation = new Dilatation();
            pcbImagen2.Image = dilatation.Apply((Bitmap)pcbImagen1.Image);
        }

        private void edgesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Edges edges = new Edges();
            pcbImagen2.Image = edges.Apply((Bitmap)pcbImagen1.Image);
        }

        private void erosionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Erosion erosion = new Erosion();
            pcbImagen2.Image = erosion.Apply((Bitmap)pcbImagen1.Image);
        }

        private void euclidianColorFilteringToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EuclideanColorFiltering euclideanColorFiltering = new EuclideanColorFiltering();
            pcbImagen2.Image = euclideanColorFiltering.Apply((Bitmap)pcbImagen1.Image);
        }

        private void extractBiggestBlobToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExtractBiggestBlob extractBiggestBlob = new ExtractBiggestBlob();
            pcbImagen2.Image = extractBiggestBlob.Apply((Bitmap)pcbImagen1.Image);
        }

        private void extractChannelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExtractChannel extractChannel = new ExtractChannel();
            pcbImagen2.Image = extractChannel.Apply((Bitmap)pcbImagen1.Image);
        }

        private void extractNormalizedRGBChannelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExtractNormalizedRGBChannel extractNormalizedRGBChannel = new ExtractNormalizedRGBChannel();
            pcbImagen2.Image = extractNormalizedRGBChannel.Apply((Bitmap)pcbImagen1.Image);
        }

        private void flatFieldCorrectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FlatFieldCorrection flatFieldCorrection = new FlatFieldCorrection();
            pcbImagen2.Image = flatFieldCorrection.Apply((Bitmap)pcbImagen1.Image);
        }

        private void gammaCorrectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GammaCorrection gammaCorrection = new GammaCorrection();
            pcbImagen2.Image = gammaCorrection.Apply((Bitmap)pcbImagen1.Image);
        }

        private void gaussianBlurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GaussianBlur gaussianBlur = new GaussianBlur();
            pcbImagen2.Image = gaussianBlur.Apply((Bitmap)pcbImagen1.Image);
        }

        private void gaussianSharperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GaussianSharpen gaussianSharpen = new GaussianSharpen();
            pcbImagen2.Image = gaussianSharpen.Apply((Bitmap)pcbImagen1.Image);
        }

        private void histogramEqualizationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HistogramEqualization histogramEqualization = new HistogramEqualization();
            pcbImagen2.Image = histogramEqualization.Apply((Bitmap)pcbImagen1.Image);
        }

        private void hslFilteringToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HSLFiltering hSLFiltering = new HSLFiltering();
            pcbImagen2.Image = hSLFiltering.Apply((Bitmap)pcbImagen1.Image);
        }

        private void hslLinearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HSLLinear hSLLinear = new HSLLinear();
            pcbImagen2.Image = hSLLinear.Apply((Bitmap)pcbImagen1.Image);
        }

        private void hueModifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HueModifier hueModifier = new HueModifier();
            pcbImagen2.Image = hueModifier.Apply((Bitmap)pcbImagen1.Image);
        }

        private void invertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Invert invert = new Invert();
            pcbImagen2.Image = invert.Apply((Bitmap)pcbImagen1.Image);
        }

        private void jitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Jitter jitter = new Jitter();
            pcbImagen2.Image = jitter.Apply((Bitmap)pcbImagen1.Image);
        }

        private void levelsLinearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LevelsLinear levelsLinear = new LevelsLinear();
            pcbImagen2.Image = levelsLinear.Apply((Bitmap)pcbImagen1.Image);
        }

        private void meanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mean mean = new Mean();
            pcbImagen2.Image = mean.Apply((Bitmap)pcbImagen1.Image);
        }

        private void medianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Median median = new Median();
            pcbImagen2.Image = median.Apply((Bitmap)pcbImagen1.Image);
        }

        private void oilPaintingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OilPainting oilPainting = new OilPainting();
            pcbImagen2.Image = oilPainting.Apply((Bitmap)pcbImagen1.Image);
        }

        private void openingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Opening opening = new Opening();
            pcbImagen2.Image = opening.Apply((Bitmap)pcbImagen1.Image);
        }

        private void pixellateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pixellate pixellate = new Pixellate();
            pcbImagen2.Image = pixellate.Apply((Bitmap)pcbImagen1.Image);
        }

        private void pointedColorFloodFillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PointedColorFloodFill pointedColorFloodFill = new PointedColorFloodFill();
            pcbImagen2.Image = pointedColorFloodFill.Apply((Bitmap)pcbImagen1.Image);
        }

        private void pointedMeanFloodFillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PointedMeanFloodFill pointedMeanFloodFill = new PointedMeanFloodFill();
            pcbImagen2.Image = pointedMeanFloodFill.Apply((Bitmap)pcbImagen1.Image);
        }

        private void rotateBicubicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RotateBicubic rotateBicubic = new RotateBicubic(2);
            pcbImagen2.Image = rotateBicubic.Apply((Bitmap)pcbImagen1.Image);
        }

        private void rotateBilinearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RotateBilinear rotateBilinear = new RotateBilinear(2);
            pcbImagen2.Image = rotateBilinear.Apply((Bitmap)pcbImagen1.Image);
        }

        private void rotateChannelsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RotateChannels rotateChannels = new RotateChannels();
            pcbImagen2.Image = rotateChannels.Apply((Bitmap)pcbImagen1.Image);
        }

        private void rotateNearestNeighborToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RotateNearestNeighbor rotateNearestNeighbor = new RotateNearestNeighbor(2);
            pcbImagen2.Image = rotateNearestNeighbor.Apply((Bitmap)pcbImagen1.Image);
        }

        private void saltAndPepperNoiseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaltAndPepperNoise saltAndPepperNoise = new SaltAndPepperNoise();
            pcbImagen2.Image = saltAndPepperNoise.Apply((Bitmap)pcbImagen1.Image);
        }

        private void saturationCorrectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaturationCorrection saturationCorrection = new SaturationCorrection();
            pcbImagen2.Image = saturationCorrection.Apply((Bitmap)pcbImagen1.Image);
        }

        private void sepiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sepia sepia = new Sepia();
            pcbImagen2.Image = sepia.Apply((Bitmap)pcbImagen1.Image);
        }

        private void sharpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sharpen sharpen = new Sharpen();
            pcbImagen2.Image = sharpen.Apply((Bitmap)pcbImagen1.Image);
        }

        private void shrinkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Shrink shrink = new Shrink();
            pcbImagen2.Image = shrink.Apply((Bitmap)pcbImagen1.Image);
        }

        private void simplePosterizationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SimplePosterization simplePosterization = new SimplePosterization();
            pcbImagen2.Image = simplePosterization.Apply((Bitmap)pcbImagen1.Image);
        }

        private void topHatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TopHat topHat = new TopHat();
            pcbImagen2.Image = topHat.Apply((Bitmap)pcbImagen1.Image);
        }

        private void transformFromPolarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TransformFromPolar transformFromPolar = new TransformFromPolar();
            pcbImagen2.Image = transformFromPolar.Apply((Bitmap)pcbImagen1.Image);
        }

        private void transformToPolarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TransformToPolar transformToPolar = new TransformToPolar();
            pcbImagen2.Image = transformToPolar.Apply((Bitmap)pcbImagen1.Image);
        }

        private void waterWaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WaterWave waterWave = new WaterWave();
            pcbImagen2.Image = waterWave.Apply((Bitmap)pcbImagen1.Image);
        }

        private void ycbcrExtractChannelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YCbCrExtractChannel yCbCrExtractChannel = new YCbCrExtractChannel();
            pcbImagen2.Image = yCbCrExtractChannel.Apply((Bitmap)pcbImagen1.Image);
        }

        private void ycbcrFilteringToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YCbCrFiltering yCbCrFiltering = new YCbCrFiltering();
            pcbImagen2.Image = yCbCrFiltering.Apply((Bitmap)pcbImagen1.Image);
        }

        private void ycbcrLinearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YCbCrLinear yCbCrLinear = new YCbCrLinear();
            pcbImagen2.Image = yCbCrLinear.Apply((Bitmap)pcbImagen1.Image);
        }
    }
}
