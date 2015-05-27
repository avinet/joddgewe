using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Collections;
using System.Windows.Forms;
using System.Globalization;

namespace Joddgewe
{
    /// <summary>
    /// 
    /// </summary>
    class FileHandler
    {
        public static int TYPE_JGW = 1;
        public static int TYPE_MMM = 2;
        public static int TYPE_SOSI = 3;

        private string _pathStyring;
        private string _pathOrto;
        private string _path;
        private HovedStyring _styringsObjekt;

        /// <summary>
        /// Returnerer et styringsobjekt (av klassen Hovedstyring), basert på
        /// filbane. 
        /// 
        /// OBS! Filbanen skal inneholde en komplett sti til fil. 
        /// Funksjonen vil automatisk lette etter passende
        /// filtyper og returnere et objekt basert på dette. 
        /// 
        /// Dersom funksjonen finner flere en én mulig filtype vil den informere
        /// brukeren om dette og spørre etter hvilken den skal benytte.
        /// </summary>
        /// <param name="path">Full bane til styringsfilen minus filtype</param>
        /// <returns>styringsobjekt:Hovedklasse</returns>
        public FileHandler(string pathOrto, double resX, double resY)
        {
            HovedStyring styring;
            styring = null;
            _pathStyring = pathOrto.Substring(0, pathOrto.Length - 4);
            _pathOrto = pathOrto;
            FileInfo fi = new FileInfo(pathOrto);
            _path= fi.DirectoryName;
            
            if (File.Exists(_pathStyring + ".jgw"))
            {
                styring = readJGW(_pathStyring + ".jgw", pathOrto, resX, resY);
            }
            if (File.Exists(_pathStyring + ".tfw"))
            {
                styring = readJGW(_pathStyring + ".tfw", pathOrto, resX, resY);
            }
            if (File.Exists(_pathStyring + ".mmm"))
            {
                styring = readMMM(_pathStyring + ".mmm", pathOrto);
            }
            if (File.Exists(_pathStyring + ".SOSI"))
            {
                styring = readSOSI(_pathStyring + ".SOSI", pathOrto, resX, resY);
            }
            if (File.Exists(_pathStyring + ".SOS"))
            {
                styring = readSOSI(_pathStyring + ".SOS", pathOrto, resX, resY);
            }

            _styringsObjekt = styring;

            //Ikke implementert:
            //Må gi brukeren tilbakemelding om en finner flere enn én type styringsfil 
            //for samme bilde. Spør da hvilken en skal benytte.
        }


        /// <summary>
        /// Skriver objektet til fil.
        /// </summary>
        public bool writeToFile(int TYPE)
        {
            bool suksess = false;
            NumberFormatInfo nfi = new CultureInfo("en-US", false).NumberFormat;
            try
            {
                string filetype = _pathOrto.Substring(_pathOrto.Length - 3);

                if (TYPE == TYPE_JGW && filetype.CompareTo("tif") == 0)
                {
                    TextWriter tw = new StreamWriter(_pathStyring + ".tfw", false, System.Text.Encoding.GetEncoding(1252));
                    tw.WriteLine(_styringsObjekt.toJGW());
                    tw.Close();
                    suksess = true;
                }
                if (TYPE == TYPE_JGW && filetype.CompareTo("jpg") == 0)
                {
                    TextWriter tw = new StreamWriter(_pathStyring + ".jgw", false, System.Text.Encoding.GetEncoding(1252));
                    tw.WriteLine(_styringsObjekt.toJGW());
                    tw.Close();
                    suksess = true;
                }
                if (TYPE == TYPE_MMM)
                {
                    TextWriter tw = new StreamWriter(_pathStyring + ".mmm", false, System.Text.Encoding.GetEncoding(1252));
                    tw.WriteLine(_styringsObjekt.toMMM());
                    tw.Close();
                    suksess = true;
                }
                if (TYPE == TYPE_SOSI)
                {
                    TextWriter tw = new StreamWriter(_pathStyring + ".sos", false, System.Text.Encoding.GetEncoding(1252));
                    tw.WriteLine(_styringsObjekt.toSOSI());
                    tw.Close();
                    suksess = true;
                }
                return suksess;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Skriver objektet til fil.
        /// </summary>
        public bool createFileList(string fileList)
        {
            try
            {
                NumberFormatInfo nfi = new CultureInfo("en-US", false).NumberFormat;
                TextWriter tw = new StreamWriter(_path + "\\Filelist.txt", false, 
                    System.Text.Encoding.GetEncoding(1252));
                tw.WriteLine(fileList);
                tw.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }



        public string toStyring()
        {
            return _styringsObjekt.ToString();
        }

        public override string ToString()
        {
            return _pathOrto;
        }

        public string toJGW()
        {
            return _styringsObjekt.toJGW();
        }

        public string toMMM()
        {
            return _styringsObjekt.toMMM();
        }

        public string toSOSI()
        {
            return _styringsObjekt.toSOSI();
        }
        
        private StyringSOSI readSOSI(string pathStyring, string pathOrto, double resX, double resY)
        {
            StreamReader sr = new StreamReader(pathStyring, System.Text.Encoding.GetEncoding(1252));
            string line;
            Boolean value = false;
            
            int? koordSys=null;
            string origoNØ=null;
            double? enhet=null;
            string minNØ=null;
            string maxNØ=null;
            int? bildeSYS=null;
            int? bildeBitPixel=null;
            double? pixelX=null;
            double? pixelY=null;
            double? minX=null;
            double? minY=null;
            double? maxX=null;
            double? maxY=null;

            while ((line = sr.ReadLine())!=null)
            {
                object[] splits = splitString(line);
                try
                {
                    NumberFormatInfo nfi = new CultureInfo("en-US", false).NumberFormat;
                    string split = (String) splits[0];
               
                    if (split.CompareTo("...KOORDSYS") == 0 && splits.Length > 1)
                    {
                        try
                        {
                            koordSys = int.Parse((String)splits[1]);  
                        } 
                        catch { }
                    }
                    if (split.CompareTo("...ORIGO-NØ") == 0 && splits.Length > 2) 
                        origoNØ = "" + splits[1] + " " + splits[2];
                    if (split.CompareTo("...ENHET") == 0 && splits.Length > 1)
                    {
                        try
                        {
                            enhet = double.Parse((String)splits[1], nfi);
                        }
                        catch { }
                    }
                    if (split.CompareTo("...MIN-NØ") == 0 && splits.Length > 2)
                    {
                        try
                        {
                            minNØ = "" + splits[1] + " " + splits[2];
                        }
                        catch { }
                    }
                    if (split.CompareTo("...MAX-NØ") == 0 && splits.Length > 2)
                    {
                        try
                        {
                            maxNØ = "" + splits[1] + " " + splits[2];
                        }
                        catch { }
                    }
                    if (split.CompareTo("...BILDE-SYS") == 0 && splits.Length > 1)
                    {
                        try
                        {
                            bildeSYS = int.Parse((String)splits[1]);
                        }
                        catch { }
                    }
                    if (split.CompareTo("...BILDE-BIT-PIXEL") == 0 && splits.Length > 1)
                    {
                        try
                        {
                            bildeBitPixel = int.Parse((String)splits[1]);
                        }
                        catch { }
                    }
                    if (split.CompareTo("...PIXEL-STØRR") == 0 && splits.Length > 2)
                    {
                        double test = 0;
                        try
                        {
                            pixelX = double.Parse((String)splits[1], nfi);
                            pixelY = double.Parse((String)splits[2], nfi);
                        }
                        catch { }
                    }

                    try
                    {
                        double[] koords;
                        koords = new double[2];
                        koords[0] = double.Parse(split, nfi);
                        koords[1] = double.Parse((String)splits[1], nfi);
                        if (!value)
                        {
                            minY = koords[0];
                            minX = koords[1];
                            value = true;
                        }
                        else
                        {
                            maxY = koords[0];
                            maxX = koords[1];
                        }

                    }
                    catch { }
                }
                catch { }
            }

            if (pixelX != null && pixelY != null && minX != null && minY != null && maxX != null && maxY != null)
            {
                //bygger et StyringSOSI-objekt
                StyringSOSI styrSOSI = new StyringSOSI(pixelX.Value, pixelY.Value, minX.Value, minY.Value,
                     maxX.Value, maxY.Value, resX, resY, pathOrto);

                if (koordSys != null) styrSOSI._koordsys = koordSys.Value;
                if (origoNØ !=null) styrSOSI._origoNØ = origoNØ;
                if (enhet != null) styrSOSI._enhet = enhet;
                if (minNØ != null) styrSOSI._minNØ = minNØ;
                if (maxNØ != null) styrSOSI._maxNØ = maxNØ;
                if (bildeSYS != null) styrSOSI._bildeSYS = bildeSYS;
                if (bildeBitPixel != null) styrSOSI._bildeBitPixel = bildeBitPixel;
 
                return styrSOSI;
            }
            else return null;

        }

        private StyringMMM readMMM(string pathStyring, string pathOrto) 
        {
            try
            {
                StreamReader sr = new StreamReader(pathStyring, System.Text.Encoding.GetEncoding(1252));
                sr.ReadLine();
                string s_res = sr.ReadLine();
                double[] resolution = splitAndParseString(s_res.Trim());
                s_res = sr.ReadLine();
                double[] xy_min = splitAndParseString(s_res.Trim());
                s_res = sr.ReadLine();
                double[] xy_max = splitAndParseString(s_res.Trim());

                //bygger et styringMMM-objekt
                StyringMMM styrMMM = new StyringMMM(resolution[0], resolution[1],
                    xy_min[0], xy_min[1], xy_max[0], xy_max[1], pathOrto);
                return styrMMM;
            }
            catch
            {
                return null;
            }
        }


        public StyringJGW readJGW(string pathStyring, string pathOrto, double resX, double resY)
        {
            try
            {
                NumberFormatInfo nfi = new CultureInfo("en-US", false).NumberFormat;
                StreamReader sr = new StreamReader(pathStyring, System.Text.Encoding.GetEncoding(1252));
                double scaleX = double.Parse(sr.ReadLine(), nfi);
                double affX = double.Parse(sr.ReadLine(), nfi);
                double affY = double.Parse(sr.ReadLine(), nfi);
                double scaleY = double.Parse(sr.ReadLine(), nfi);
                double pixelX = double.Parse(sr.ReadLine(), nfi);
                double pixelY = double.Parse(sr.ReadLine(), nfi);

                //bygger et styringJGW-objekt
                StyringJGW styrJGW = new StyringJGW(pixelX, pixelY, affX, affY,
                    scaleX, scaleY, resX, resY, pathOrto);
                return styrJGW;
            }
            catch 
            {
                return null;
            }
        }


        private object[] splitString(string input)
        {
            ArrayList nameColl = new ArrayList();

            string[] splits = input.Split(' ');
            for (int i = 0; i < splits.Length; i++)
            {
                if (splits[i].Length > 0)
                {
                    string test = splits[i].Trim();
                    nameColl.Add(splits[i].Trim());
                }
            }
            return nameColl.ToArray();;
        }

       private double[] splitAndParseString(string s_input)
        {
            string s_res1="";
            string s_res2="";
            double[] a_results = new double[2];

            bool verdi = true;

            string[] results = s_input.Split(' ');
            for (int i = 0; i < results.Length; i++)
            {
                string result = results[i].Trim();

                if (!verdi && result.Length > 0)
                {
                    s_res2 = result;
                }
                if (verdi && result.Length > 0)
                {
                    s_res1 = result;
                    verdi = false;
                }
            }
            
            try
            {
                NumberFormatInfo nfi = new CultureInfo( "en-US", false ).NumberFormat;

                a_results[0] = double.Parse(s_res1, nfi);
                a_results[1] = double.Parse(s_res2, nfi);
            }
            catch
            {
                throw new Exception("Error parsing string");
            }
            return a_results;
        }

    }
}
