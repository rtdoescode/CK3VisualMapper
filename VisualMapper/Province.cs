using NPOI.SS.UserModel;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualMapper {

    public class Province {
        
        public static Dictionary<Color, Province> provincesByColor;

        public Color color;
        public ColorMap mapEntry;
        IRow row;

        public string name, county, duchy, kingdom, empire;
        public string religion, culture;
        public string landscape;
        public string terrain;
        public string holding;

        /// <summary>
        /// Not currently used, but kept in because it's a good idea to
        /// implement somewhere.
        /// This would check all provinces and enforce this provinces's
        /// hierarchy on them
        /// 
        /// i.e. all other provinces with the same duchy as this province
        /// MUST have the same kingdom and empire, etc.
        /// </summary>
        public void PropagateHierarchy() {
            foreach(Province p in Province.provincesByColor.Values) {
                if (p == this) { continue; }
                if(this.county != "" && this.county != null && p.county == this.county) {
                    p.duchy = this.duchy;
                    p.kingdom = this.kingdom;
                    p.empire = this.empire;
                }
                else if(this.duchy != "" && this.duchy != null && p.duchy == this.duchy) {
                    p.kingdom = this.kingdom;
                    p.empire = this.empire;
                }
                else if(this.kingdom != "" &&this.kingdom != null && p.kingdom == this.kingdom) {
                    p.empire = this.empire;
                }
            }
        }

        public override string ToString() {
            if(name == "" || name == null) {
                return "Province["+color.ToString()+"]";
            }
            return name;
        }

        /// <summary>
        /// Generates a spreadsheet row representing this province
        /// </summary>
        public IRow export(ISheet sheet) {
            IRow row = Form1.createRowOfColour(sheet, color);

            row.GetCell(5).SetCellValue(name);
            row.GetCell(10).SetCellValue(county);
            row.GetCell(9).SetCellValue(duchy);
            row.GetCell(8).SetCellValue(kingdom);
            row.GetCell(7).SetCellValue(empire);
            row.GetCell(11).SetCellValue(culture);
            row.GetCell(12).SetCellValue(religion);
            row.GetCell(6).SetCellValue(landscape);
            row.GetCell(13).SetCellValue(terrain);
            row.GetCell(15).SetCellValue(holding);
            
            return row;
        }

        /// <summary>
        /// Returns the province associated with a given colour
        /// </summary>
        public static Province getProvince(Color c) {
            if (provincesByColor.ContainsKey(c)) {
                return provincesByColor[c];
            }
            return null;
        }

        /// <summary>
        /// Creates a province using the given colour
        /// if given a spreadsheet row, populates the data from
        /// the relevant fields
        /// </summary>
        public static Province createProvince(Color c, IRow row = null) {
            Province p = new Province();
            p.color = c;

            if(row != null) {
                p.name = Form1.TryGetCellValue(row, 5);
                p.county = Form1.TryGetCellValue(row, 10);
                p.duchy = Form1.TryGetCellValue(row, 9);
                p.kingdom = Form1.TryGetCellValue(row, 8);
                p.empire = Form1.TryGetCellValue(row, 7);
                p.culture = Form1.TryGetCellValue(row, 11);
                p.religion = Form1.TryGetCellValue(row, 12);
                p.landscape = Form1.TryGetCellValue(row, 6);
                p.terrain = Form1.TryGetCellValue(row, 13);
                p.holding = Form1.TryGetCellValue(row, 15);
            }

            provincesByColor.Add(c, p);

            return p;
        }


    }
}
