using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace VisualMapper {

    public partial class Form1 : Form {

        static bool ignoreDataChanges = true;

        SplitterPanel mapSurface;

        ImageAttributes attr = new ImageAttributes();
        Bitmap mapImage;
        bool leftDragging = false;
        bool rightDragging = false;
        bool middleDragging = false;
        string savefilename;
        List<Province> selected = new List<Province>();
        Color highlightColor = Color.LawnGreen;

        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {

            splitContainer1.Margin = new Padding(0, 50, 0, 0);
            splitContainer1.Padding = new Padding(0, 50, 0, 0);
            mapSurface = splitContainer1.Panel1;
            mapSurface.Margin = new Padding(0, 50, 0, 0);
            mapSurface.Padding = new Padding(0, 50, 0, 0);

            //Add mouse control functions
            mapSurface.Paint += DrawMap;
            mapSurface.MouseDown += MapMouseDown;
            mapSurface.MouseUp += MapMouseUp;
            mapSurface.MouseMove += MapBox_MouseMove;
            mapSurface.MouseWheel += MapBox_MouseWheel;

            //populate province type options
            cmbType.AllowDrop = false;
            cmbType.DropDownStyle = ComboBoxStyle.DropDown;
            cmbType.Items.Add("");
            cmbType.Items.Add("O");
            cmbType.Items.Add("IS");
            cmbType.Items.Add("IM");
            cmbType.Items.Add("W");
            cmbType.Items.Add("L");
            cmbType.Items.Add("R");

            //populate province terrain options
            cmbTerrain.AllowDrop = false;
            cmbTerrain.DropDownStyle = ComboBoxStyle.DropDown;
            cmbTerrain.Items.Add("plains");
            cmbTerrain.Items.Add("forest");
            cmbTerrain.Items.Add("wetlands");
            cmbTerrain.Items.Add("hills");
            cmbTerrain.Items.Add("mountains");
            cmbTerrain.Items.Add("farmlands");
            cmbTerrain.Items.Add("steppe");
            cmbTerrain.Items.Add("drylands");
            cmbTerrain.Items.Add("desert");
            cmbTerrain.Items.Add("floodplains");
            cmbTerrain.Items.Add("taiga");
            cmbTerrain.Items.Add("jungle");

            //populate holding type options
            cmbHolding.AllowDrop = false;
            cmbHolding.DropDownStyle = ComboBoxStyle.DropDown;
            cmbHolding.Items.Add("");
            cmbHolding.Items.Add("C");
            cmbHolding.Items.Add("B");
            cmbHolding.Items.Add("T");

            //setup tooltips
            toolTip1.SetToolTip(cmbHolding,
                "Type of holding present in this county. Blank is none.");
            toolTip1.SetToolTip(cmbType,
                "Type of province. Blank is normal.");
            toolTip1.SetToolTip(cmbTerrain,
                "Terrain of this county.");

            //add data change listeners to province data fields
            cmbType.TextChanged += LandChanged;
            cmbTerrain.TextChanged += TerrainChanged;
            cmbHolding.TextChanged += HoldingChanged;
            tbName.TextChanged += NameChanged;
            tbCounty.TextChanged += CountyChanged;
            tbDuchy.TextChanged += DuchyChanged;
            tbKingdom.TextChanged += KingdomChanged;
            tbEmpire.TextChanged += EmpireChanged;
            tbCulture.TextChanged += CultureChanged;
            tbReligion.TextChanged += ReligionChanged;


            //
            infoTableLayout.RowStyles.Clear();
            infoTableLayout.ColumnStyles.Clear();

            for (int i = 0; i < infoTableLayout.RowCount; i++) {
                RowStyle rs = new RowStyle(SizeType.Percent, 100F);
                infoTableLayout.RowStyles.Add(rs);
            }
            for (int i = 0; i < infoTableLayout.ColumnCount; i++) {
                ColumnStyle cs = new ColumnStyle(SizeType.Percent, 100F);
                infoTableLayout.ColumnStyles.Add(cs);
            }

            foreach (Control c in infoTableLayout.Controls) {
                c.Dock = DockStyle.Fill;
            }

            infoTableLayout.Refresh();
        }

        /// <summary>
        /// Handler for when name/barony values are changed
        /// </summary>
        public void NameChanged(object sender, EventArgs e) {
            if (!ignoreDataChanges) {
                foreach (Province p in selected) {
                    p.name = tbName.Text;
                }
            }
        }

        /// <summary>
        /// Handler for when holding values are changed
        /// </summary>
        public void HoldingChanged(object sender, EventArgs e) {
            if (!ignoreDataChanges) {
                foreach (Province p in selected) {
                    p.holding = cmbHolding.Text;
                }
            }
        }

        /// <summary>
        /// Handler for when landscape values are changed
        /// </summary>
        public void LandChanged(object sender, EventArgs e) {
            if (!ignoreDataChanges) {
                foreach (Province p in selected) {
                    p.landscape = cmbType.Text;
                }
            }
        }

        /// <summary>
        /// Handler for when terrain values are changed
        /// </summary>
        public void TerrainChanged(object sender, EventArgs e) {
            if (!ignoreDataChanges) {
                foreach (Province p in selected) {
                    p.terrain = cmbTerrain.Text;
                }
            }
        }

        /// <summary>
        /// Handler for when county values are changed
        /// </summary>
        public void CountyChanged(object sender, EventArgs e) {
            if (!ignoreDataChanges) {
                foreach (Province p in selected) {
                    p.county = tbCounty.Text;
                }
            }
        }

        /// <summary>
        /// Handler for when duchy values are changed
        /// </summary>
        public void DuchyChanged(object sender, EventArgs e) {
            if (!ignoreDataChanges) {
                foreach (Province p in selected) {
                    p.duchy = tbDuchy.Text;
                }
            }
        }

        // Handler for when kingdom values are changed
        public void KingdomChanged(object sender, EventArgs e) {
            if (!ignoreDataChanges) {
                foreach (Province p in selected) {
                    p.kingdom = tbKingdom.Text;
                }
            }
        }

        /// <summary>
        /// Handler for when empire values are changed
        /// </summary>
        public void EmpireChanged(object sender, EventArgs e) {
            if (!ignoreDataChanges) {
                foreach (Province p in selected) {
                    p.empire = tbEmpire.Text;
                }
            }
        }

        /// <summary>
        /// Handler for when religion values are changed
        /// </summary>
        public void ReligionChanged(object sender, EventArgs e) {
            if (!ignoreDataChanges) {
                foreach (Province p in selected) {
                    p.religion = tbReligion.Text;
                }
            }
        }

        /// <summary>
        /// Handler for when culture values are changed
        /// </summary>
        public void CultureChanged(object sender, EventArgs e) {
            if (!ignoreDataChanges) {
                foreach (Province p in selected) {
                    p.culture = tbCulture.Text;
                }
            }
        }

        /// <summary>
        /// Called when the user selects a new set of provinces
        /// Clears text boxes and then repopulates matching ones
        /// /// </summary>
        public void SelectionChanged() {

            ignoreDataChanges = true;

            tbName.Text = "";
            tbCounty.Text = "";
            tbDuchy.Text = "";
            tbKingdom.Text = "";
            tbEmpire.Text = "";
            tbReligion.Text = "";
            tbCulture.Text = "";
            cmbType.Text = "";
            cmbTerrain.Text = "";
            cmbHolding.Text = "";

            List<string> datums = new List<string>();
            foreach (Province p in selected) {
                if (!datums.Contains(p.name)) {
                    datums.Add(p.name);
                }
            }
            if (datums.Count == 1) { tbName.Text = datums[0]; }
            datums.Clear();

            foreach (Province p in selected) {
                if (!datums.Contains(p.county)) {
                    datums.Add(p.county);
                }
            }
            if (datums.Count == 1) { tbCounty.Text = datums[0]; }
            datums.Clear();

            foreach (Province p in selected) {
                if (!datums.Contains(p.duchy)) {
                    datums.Add(p.duchy);
                }
            }
            if (datums.Count == 1) { tbDuchy.Text = datums[0]; }
            datums.Clear();

            foreach (Province p in selected) {
                if (!datums.Contains(p.kingdom)) {
                    datums.Add(p.kingdom);
                }
            }
            if (datums.Count == 1) { tbKingdom.Text = datums[0]; }
            datums.Clear();

            foreach (Province p in selected) {
                if (!datums.Contains(p.empire)) {
                    datums.Add(p.empire);
                }
            }
            if (datums.Count == 1) { tbEmpire.Text = datums[0]; }
            datums.Clear();

            foreach (Province p in selected) {
                if (!datums.Contains(p.culture)) {
                    datums.Add(p.culture);
                }
            }
            if (datums.Count == 1) { tbCulture.Text = datums[0]; }
            datums.Clear();

            foreach (Province p in selected) {
                if (!datums.Contains(p.religion)) {
                    datums.Add(p.religion);
                }
            }
            if (datums.Count == 1) { tbReligion.Text = datums[0]; }
            datums.Clear();

            ignoreDataChanges = false;
        }

        Point clickLocation;
        Color? lastPaintedColor;
        Point viewPoint;
        int viewScale;

        /// <summary>
        /// Returns the amount by which 
        /// </summary>
        private double getPanMultiplier(int view) {
            //return Math.Log(viewScale, 2);
            return Math.Log(viewScale, 20);
        }

        /// <summary>
        /// Handles mouse moving
        /// </summary>
        private void MapBox_MouseMove(object sender, MouseEventArgs e) {

            if (middleDragging) {
                //middle click dragging pans the map
                double n = getPanMultiplier(viewScale);

                Point offset = new Point(
                    (int)((e.Location.X - clickLocation.X) * n),
                    (int)((e.Location.Y - clickLocation.Y) * n)
                );

                viewPoint = new Point(
                    viewPoint.X - offset.X,
                    viewPoint.Y - offset.Y
                );

                clickLocation = e.Location;

                mapSurface.Refresh();
            }
            if (leftDragging) {
                //Left click dragging does the same thing as a 
                //single left click - selects all touched provinces

                Color? c = GetColourAtClickPos(e);
                if (c != lastPaintedColor && c != null) {
                    SelectProvince(c);
                }
            }
            else if (rightDragging) {
                //Right click dragging deselects all touched provinces

                Color? c = GetColourAtClickPos(e);
                if (c != lastPaintedColor && c != null) {
                    DeselectProvince(c);
                }
            }
        }

        /// <summary>
        /// Handles mouse wheel scrolling on the map
        /// </summary>
        private void MapBox_MouseWheel(object sender, MouseEventArgs e) {

            if (mapImage == null) { return; }

            int lowzoom = Math.Min(mapImage.Width, mapImage.Height) / 25;
            int topzoom = Math.Max(mapImage.Width, mapImage.Height) * 5;

            if (e.Delta > 0) {
                viewScale = Math.Max(lowzoom, viewScale / 2);
            }
            else {
                viewScale = Math.Min(topzoom, viewScale * 2);
            }

            Console.WriteLine(viewScale + "::" + getPanMultiplier(viewScale));

            mapSurface.Refresh();

        }

        /// <summary>
        /// standard function for mapping one range of values
        /// onto another range
        /// </summary>
        /// <param name="n">The value to map</param>
        /// <param name="a1">The bottom of the input range</param>
        /// <param name="a2">The top of the input range</param>
        /// <param name="b1">The bottom of the output range</param>
        /// <param name="b2">The top of the output range</param>
        /// <returns></returns>
        int nmap(int n, int a1, int a2, int b1, int b2) {
            return (int)(b1 + (float)(n - a1) * (float)(b2 - b1) / (float)(a2 - a1));
        }

        /// <summary>
        /// Converts screen coordinates from a mouse event to
        /// logical map coordinates
        /// </summary>
        private Point ClickedPosToMapPos(MouseEventArgs e) {

            int x1 = (int)(viewPoint.X - viewScale);
            int y1 = (int)(viewPoint.Y - viewScale);
            int x2 = viewScale * 2;
            int y2 = viewScale * 2;

            int x = nmap(e.X, 0, mapSurface.Width, x1, x1 + x2);
            int y = nmap(e.Y, 0, mapSurface.Height, y1, y1 + y2);

            return new Point(x, y);
        }

        /// <summary>
        /// Returns the colour of the map at a given screen location
        /// </summary>
        private Color? GetColourAtClickPos(MouseEventArgs e) {

            Point p = ClickedPosToMapPos(e);

            if (mapImage == null) {
                return null;
            }

            if (p.X < 0 || p.X > mapImage.Width ||
               p.Y < 0 || p.Y > mapImage.Height) {
                return null;
            }

            Color c = mapImage.GetPixel(p.X, p.Y);
            return c;

        }

        private void MapMouseDown(object sender, MouseEventArgs e) {

            if (e.Button == MouseButtons.Left) {
                leftDragging = true;
                if (mapImage == null) { return; }
                Color? clickedColour = GetColourAtClickPos(e);
                SelectProvince(clickedColour);
            }

            if (e.Button == MouseButtons.Right) {
                rightDragging = true;
                if (mapImage == null) { return; }
                Color? clickedColour = GetColourAtClickPos(e);
                DeselectProvince(clickedColour);
            }

            if (e.Button == MouseButtons.Middle) {
                middleDragging = true;
                clickLocation = e.Location;
            }
        }

        private void MapMouseUp(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                leftDragging = false;
            }
            if (e.Button == MouseButtons.Right) {
                rightDragging = false;
            }
            if (e.Button == MouseButtons.Middle) {
                middleDragging = false;
            }
        }

        public static string TryGetCellValue(IRow row, int n) {
            if (row == null) { return ""; }
            ICell c = row.GetCell(n);
            if (c == null) { return ""; }
            return c.StringCellValue;
        }

        public static Color? getRowColour(IRow row) {
            int r, g, b;

            if (row.Cells.Count == 0) {
                return null;
            }

            r = (int)row.GetCell(2).NumericCellValue;
            g = (int)row.GetCell(3).NumericCellValue;
            b = (int)row.GetCell(4).NumericCellValue;

            return Color.FromArgb(r, g, b);
        }

        public static IRow createRowOfColour(ISheet sheet, Color c) {

            IRow row = sheet.CreateRow(sheet.LastRowNum + 1);

            row.CreateCell(1);

            SetOrCreateCell(row, 2, c.R);
            SetOrCreateCell(row, 3, c.G);
            SetOrCreateCell(row, 4, c.B);

            for (int i = 5; i < 16; i++) {
                row.CreateCell(i);
            }

            return row;
        }

        private HSSFWorkbook CreateNewTable() {

            HSSFWorkbook newbook = new HSSFWorkbook();
            ISheet sheet = newbook.CreateSheet("Sheet1");
            IRow titleRow = sheet.CreateRow(0);

            string[] headings = {
                "Comment",
                "Prov. ID",
                "Red",
                "Green",
                "Blue",
                "Province name",
                "",
                "Empire",
                "Kingdom",
                "Duchy",
                "County",
                "Culture",
                "Religion",
                "Terrain",
                "Climate",
                "Type",
                "Holy Sites",
                "Capital"
            };

            foreach (string title in headings) {
                ICell c = titleRow.CreateCell(titleRow.Cells.Count);
                c.SetCellValue(title);
            }

            return newbook;


        }

        private static void SetOrCreateCell(IRow row, int n, object value) {

            if (value == null) { value = ""; }

            ICell cell = row.GetCell(n);
            if (cell == null) {
                cell = row.CreateCell(n);
            }

            if (value is byte) {
                cell.SetCellValue((byte)value);
            }
            else if (value is double) {
                cell.SetCellValue((double)value);
            }
            else if (value is int) {
                cell.SetCellValue((double)value);
            }
            else {
                cell.SetCellValue(value.ToString());
            }
        }

        bool validSaveState = false;

        private void invalidate() {

            if (!validSaveState) { return; }
            validSaveState = false;

            if (Province.provincesByColor != null) {
                Province.provincesByColor = new Dictionary<Color, Province>();
            }

            provinceLoadingSheet = null;
            mapImage = null;
        }

        private void menuItem4_Click(object sender, EventArgs e) {

            string filepath;

            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.InitialDirectory = "c:\\";
            fileDialog.Filter = "png files (*.png)|*.png|All files (*.*)|*.*";
            fileDialog.FilterIndex = 1;
            fileDialog.RestoreDirectory = true;

            if (fileDialog.ShowDialog() == DialogResult.OK) {
                //Get the path of specified file
                filepath = fileDialog.FileName;
                invalidate();
                mapImage = Image.FromFile(filepath) as Bitmap;

                viewPoint = new Point(mapImage.Width / 2, mapImage.Height / 2);
                viewScale = mapImage.Width / 2;

                prepareProvinces();
                mapSurface.Refresh();
            }
        }

        /// <summary>
        /// Reads the province spreadsheet and generates
        /// provinces based on data
        /// </summary>
        private void prepareProvinces() {
            if (mapImage == null) { return; }

            selected = new List<Province>();
            Province.provincesByColor = new Dictionary<Color, Province>();

            if (provinceLoadingSheet != null) {
                readProvinces();
            }
            makeProvinces();

            validSaveState = true;

            Console.WriteLine("Created " + Province.provincesByColor.Count + " provinces");
        }

        /// <summary>
        /// Click handler for the button to load spreadsheets
        /// Handles file navigation and loading then calls
        /// prepareProvinces()
        /// </summary>
        private void loadSpreadsheet_Click(object sender, EventArgs e) {
            string filepath;

            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.InitialDirectory = "c:\\";
            fileDialog.Filter = "Excel files (*.xls)|*.xls|All files (*.*)|*.*";
            fileDialog.FilterIndex = 1;
            fileDialog.RestoreDirectory = true;

            if (fileDialog.ShowDialog() == DialogResult.OK) {
                //Get the path of specified file
                filepath = fileDialog.FileName;
                FileStream file;
                try {
                    file = new FileStream(filepath, FileMode.Open, FileAccess.ReadWrite);
                }
                catch (Exception ex) {
                    MessageBox.Show("Could not open file.");
                    return;
                }

                invalidate();
                HSSFWorkbook workbook = new HSSFWorkbook(file);
                provinceLoadingSheet = workbook.GetSheet("Sheet1");
                savefilename = filepath;
                file.Close();
                prepareProvinces();
            }
        }

        ISheet provinceLoadingSheet;

        private void menuItem2_Click(object sender, EventArgs e) {
            SaveFileDialog fileDialog = new SaveFileDialog();
            //fileDialog.InitialDirectory = "c:\\";
            fileDialog.Filter = "xls files (*.xls)|*.xls|All files (*.*)|*.*";
            fileDialog.FileName = "provinceDef.xls";
            fileDialog.RestoreDirectory = true;
            fileDialog.ShowDialog();
            HSSFWorkbook newbook = null;

            if (fileDialog.FileName != "") {
                newbook = CreateNewTable();

                ISheet sheet = newbook.GetSheet("Sheet1");

                foreach (Province p in Province.provincesByColor.Values) {
                    p.export(sheet);
                }

                FileStream file = File.Create(fileDialog.FileName);
                sheet.Workbook.Write(file);
                file.Close();
            }
        }

        /// <summary>
        /// loops through all pixels in the map image
        /// and generates a province for each unique colour
        /// if that colour doesn't already have an associated province
        /// </summary>
        private void makeProvinces() {
            if (mapImage == null) { return; }

            Console.WriteLine("Building all provinces");

            // Lock the bitmap's bits.  
            Rectangle rect = new Rectangle(0, 0, mapImage.Width, mapImage.Height);
            BitmapData bmpData = mapImage.LockBits(rect, ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

            // Get the address of the first line.
            IntPtr ptr = bmpData.Scan0;

            // Declare an array to hold the bytes of the bitmap.
            int bytes = bmpData.Stride * mapImage.Height;
            byte[] rgbValues = new byte[bytes];

            // Copy the RGB values into the array.
            Marshal.Copy(ptr, rgbValues, 0, bytes);

            int r, g, b;
            Color c;
            int stride = bmpData.Stride;

            for (int column = 0; column < bmpData.Height; column++) {

                if (column % 100 == 0) { Console.WriteLine("Read " + column); }

                for (int row = 0; row < bmpData.Width; row++) {
                    b = rgbValues[(column * stride) + (row * 3)];
                    g = rgbValues[(column * stride) + (row * 3) + 1];
                    r = rgbValues[(column * stride) + (row * 3) + 2];

                    c = Color.FromArgb(r, g, b);
                    if (!Province.provincesByColor.ContainsKey(c)) {
                        Province p = Province.createProvince(c);
                    }
                }
            }

            mapImage.UnlockBits(bmpData);

        }

        /// <summary>
        /// Populates provinces from a specified spreadsheet
        /// </summary>
        private void readProvinces() {
            for (int row = 1; row <= provinceLoadingSheet.LastRowNum; row++) {
                IRow currentRow = provinceLoadingSheet.GetRow(row);
                if (currentRow == null) { continue; }
                Color? rowColor = getRowColour(currentRow);
                if (rowColor != null) {
                    Province.createProvince((Color)rowColor, currentRow);
                }
            }
            return;
        }

        /// <summary>
        /// for deugging only, not used
        /// </summary>
        /// <param name="s"></param>
        public void LogToFile(string s) {
            File.WriteAllText("log.txt", s);
        }

        /// <summary>
        /// Creates colour maps for each of the selected provinces
        /// </summary>
        public void Rehighlight() {

            if (Province.provincesByColor == null) {
                return;
            }

            List<ColorMap> maps = new List<ColorMap>();

            //create a colormap for each selected province
            //and add it to the map list
            foreach (Province p in selected) {
                ColorMap cm = new ColorMap();
                cm.OldColor = p.color;
                cm.NewColor = highlightColor;
                maps.Add(cm);
            }

            //DrawImage() breaks if supplied with 0 colour maps,
            //so in the event that we have no colormaps, create
            //one that does nothing
            if (maps.Count == 0) {
                ColorMap cm = new ColorMap();
                cm.OldColor = Color.Black;
                cm.NewColor = Color.Black;
                maps.Add(cm);
            }

            //apply the colormapping and redraw the map
            ColorMap[] cmap = maps.ToArray();
            attr.SetRemapTable(cmap, ColorAdjustType.Bitmap);
            mapSurface.Refresh();
        }

        /// <summary>
        /// Finds the province associated with a given colour,
        /// adds it to the selected list, and triggers a map
        /// redraw if necessary
        /// </summary>
        private void SelectProvince(Color? c) {

            if (c == null) { return; }

            if (Province.provincesByColor == null) {
                return;
            }

            if (!Province.provincesByColor.ContainsKey((Color)c)) {
                return;
            }

            Province p = Province.provincesByColor[(Color)c];
            lastPaintedColor = c;

            if (!selected.Contains(p)) {
                selected.Add(p);
                Remap();
            }
        }

        /// <summary>
        /// Finds the province associated with a given colour,
        /// removes it from the selected list, and triggers a map
        /// redraw if necessary
        /// </summary>
        private void DeselectProvince(Color? c) {

            if (c == null) { return; }

            if (Province.provincesByColor == null) {
                return;
            }

            if (!Province.provincesByColor.ContainsKey((Color)c)) {
                return;
            }

            Province p = Province.provincesByColor[(Color)c];
            lastPaintedColor = c;

            if (selected.Contains(p)) {
                selected.Remove(p);
                Remap();
            }
        }

        /// <summary>
        /// Calls necessary functions to redraw the map,
        /// and update selection data textboxes
        /// </summary>
        public void Remap() {
            Rehighlight();
            SelectionChanged();
            selectionCountLabel.Text = selected.Count + " selected";
        }

        /// <summary>
        /// The function used to actually draw the map
        /// </summary>
        private void DrawMap(object sender, PaintEventArgs e) {

            Control drawsurface = sender as Control;
            if (mapImage == null) { return; }

            Rectangle destRect = new Rectangle(0, 0, drawsurface.Width, drawsurface.Height);

            int x1 = (int)(viewPoint.X - viewScale);
            int y1 = (int)(viewPoint.Y - viewScale);
            int x2 = viewScale * 2;
            int y2 = viewScale * 2;

            e.Graphics.DrawImage(
                mapImage,
                destRect,
                x1, y1,
                x2, y2,
                GraphicsUnit.Pixel,
                attr);

        }

        /// <summary>
        /// Clears the current selection when clicked
        /// </summary>
        private void btnClear_Click(object sender, EventArgs e) {
            selected.Clear();
            Remap();
        }
    }
}
