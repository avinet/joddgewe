using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Drawing;
using System.Globalization;

namespace Joddgewe
{

    public abstract class HovedStyring
    {
        public abstract string toJGW();
        public abstract string toMMM();
        public abstract string toSOSI();
        public abstract override string ToString();
    }


    public class StyringMMM : HovedStyring
    {
        private double _resX;
        private double _resY;
        private double _minX;
        private double _maxX;
        private double _minY;
        private double _maxY;
        private string _filepath;

        public StyringMMM(double resX, double resY, double minX, double minY,
            double maxX, double maxY, string filepath)
        {
            _resX = resX;
            _resY = resY;
            _minX = minX;
            _minY = minY;
            _maxX = maxX;
            _maxY = maxY;
            _filepath = filepath;
        }

        public override string ToString()
        {
            return toMMM();
        }

        public override string toMMM()
        {
            return
                "0" + " " + "0" + "\r\n" +
                _resX.ToString(NumberFormatInfo.InvariantInfo) + " " + _resY.ToString(NumberFormatInfo.InvariantInfo) + "\r\n" +
                _minX.ToString(NumberFormatInfo.InvariantInfo) + " " + _minY.ToString(NumberFormatInfo.InvariantInfo) + "\r\n" +
                _maxX.ToString(NumberFormatInfo.InvariantInfo) + " " + _maxY.ToString(NumberFormatInfo.InvariantInfo) + "\r\n" +
                "0";
        }

        public override string toJGW()
        {
            try
            {
                double scaleX = (_maxX - _minX) / _resX;
                double scaleY = (_minY - _maxY) / _resY;

                double pixelX = _minX + scaleX / 2;
                double pixelY = _maxY + scaleY / 2;

                //bygger et styringJGW-objekt
                StyringJGW styrJGW = new StyringJGW(pixelX, pixelY, 0, 0, 
                    scaleX, scaleY, _resX, _resY, _filepath);
                return styrJGW.toJGW();
            }
            catch
            {
                return "";
            }
            
        }

        public override string toSOSI()
        {
            try
            {
                double scaleX = (_maxX - _minX) / _resX;
                double scaleY = (_maxY - _minY) / _resY;

                //bygger et StyringSOSI-objekt
                StyringSOSI styrSOSI = new StyringSOSI(scaleX, scaleY, _minX, 
                    _minY, _maxX, _maxY, _resX, _resY, _filepath);
                return styrSOSI.toSOSI();
            }
            catch
            {
                return "";
            }
        }
    }




    /// <summary>
    /// 
    /// </summary>
    public class StyringJGW : HovedStyring
    {
        private double _pixelX;
        private double _pixelY;
        private double _affX;
        private double _affY;
        private double _scaleX;
        private double _scaleY;
        private string _filepath;
        private double _resX;
        private double _resY;

        public StyringJGW(double pixelX, double pixelY, double affX, double affY, 
            double scaleX, double scaleY, double resX, double resY, string filepath)
        {
            _pixelX = pixelX;
            _pixelY = pixelY;
            _affX = affX;
            _affY = affY;
            _scaleX = scaleX;
            _scaleY = scaleY;
            _filepath = filepath;
            _resX = resX;
            _resY = resY;
        }

        public override string ToString()
        {
            return toJGW();
        }

        public override string toJGW()
        {
            return
                _scaleX.ToString(NumberFormatInfo.InvariantInfo) + "\r\n" +
                _affX.ToString(NumberFormatInfo.InvariantInfo) + "\r\n" +
                _affY.ToString(NumberFormatInfo.InvariantInfo) + "\r\n" +
                _scaleY.ToString(NumberFormatInfo.InvariantInfo) + "\r\n" +
                _pixelX.ToString(NumberFormatInfo.InvariantInfo) + "\r\n" +
                _pixelY.ToString(NumberFormatInfo.InvariantInfo);
        }

        public override string toMMM()
        {
            double minX = _pixelX - _scaleX / 2;
            double maxX = minX + _resX * _scaleX;

            double maxY = _pixelY - _scaleY / 2;
            double minY = maxY + _resY * _scaleY;

            //bygger et StyringMMM-objekt
            StyringMMM styrMMM = new StyringMMM(_resX, _resY, minX, minY, 
                maxX, maxY, _filepath);
            return styrMMM.toMMM();
        }

        public override string toSOSI()
        {
            double minX = _pixelX - _scaleX / 2;
            double maxX = minX + _resX * _scaleX;

            double maxY = _pixelY - _scaleY / 2;
            double minY = maxY + _resY * _scaleY;

            //bygger et styrSOSI-objekt
            StyringSOSI styrSOSI = new StyringSOSI(_scaleX, _scaleY*-1, minX, minY, 
                maxX, maxY, _resX, _resY, _filepath);
            return styrSOSI.toSOSI();
        }
    }




    /// <summary>
    /// 
    /// </summary>
    public class StyringSOSI : HovedStyring
    {
        private double _resX;
        private double _resY;
        private string _filepath;

        // det som står i hodet er frivillig. Brukes helst ved lesning.
        #region HODE
           public int? _koordsys;
           public string _origoNØ;
           public double? _enhet;
        #endregion 

        // utstrekning av området er frivillig. Brukes helst ved lesning.
        #region OMRÅDE
            public string _minNØ;
            public string _maxNØ;
        #endregion 

        // info om bildet. 
        #region BILDE
            public int? _bildeSYS;
            private string _bildeType;
            public int? _bildeBitPixel;
            private string _bildeFil;
            private double _pixelX;
            private double _pixelY;
            private double _minX;
            private double _minY;
            private double _maxX;
            private double _maxY;
        #endregion


        public StyringSOSI(double pixelX, double pixelY, double minX, double minY,
             double maxX, double maxY, double resX, double resY, string filepath)
        {
            _pixelX = pixelX;
            _pixelY = pixelY;
            _minX = minX;
            _minY = minY;
            _maxX = maxX;
            _maxY = maxY;
            _resX = resX;
            _resY = resY;

            FileSystemInfo fi = new FileInfo(filepath);
            _filepath = filepath;
            _bildeFil = fi.Name;
            _bildeType = filepath.Substring(filepath.Length - 3).ToUpper();
       }

        public override string ToString()
        {
            return toSOSI();
        }
        
        public override string toSOSI()
        {           
            defineOptionalParameters();
            NumberFormatInfo nfi = new CultureInfo("en-US", false).NumberFormat;
            
            return
                ".HODE" + "\r\n" +
                "..TRANSPAR" + "\r\n" +
                "...KOORDSYS " + _koordsys + "\r\n" +
                "...ORIGO-NØ " + _origoNØ + "\r\n" +
                "...ENHET " + _enhet.Value.ToString(nfi) + "\r\n" +
                "..OMRÅDE" + "\r\n" +
                "...MIN-NØ " + _minNØ.ToString(nfi) + "\r\n" +
                "...MAX-NØ " + _maxNØ.ToString(nfi) + "\r\n" +
                "..TEGNSETT DOSN8" + "\r\n" +
                ".RASTER 1" + "\r\n" +
                "..BILDE" + "\r\n" +
                "...BILDE-SYS " + _bildeSYS + "\r\n" +
                "...BILDE-TYPE " + _bildeType + "\r\n" +
                "...BILDE-BIT-PIXEL " + _bildeBitPixel + "\r\n" +
                "...BILDE-FIL \"" + _bildeFil + "\" " + "\r\n" +
                "...PIXEL-STØRR " + _pixelX.ToString(nfi) + " " + _pixelY.ToString(nfi) + "\r\n" +
                "..NØ" + "\r\n" +
                "" + _minY.ToString(nfi) + " " + _minX.ToString(nfi) + "\r\n" +
                "" + _maxY.ToString(nfi) + " " + _maxX.ToString(nfi) + "\r\n" +
                ".SLUTT";
        }

        private void defineOptionalParameters()
        {
            if (_koordsys==null) _koordsys=99;
            if (_origoNØ == null) _origoNØ = "0 0";
            if (_enhet == null)
            {
                _enhet = 0.01;
                _maxX = _maxX / _enhet.Value;
                _maxY = _maxY / _enhet.Value;
                _minX = _minX / _enhet.Value;
                _minY = _minY / _enhet.Value;
            }
            if (_minNØ == null) _minNØ = "" + Math.Round(_minY * _enhet.Value) 
                + " " + Math.Round(_minX * _enhet.Value);
            if (_maxNØ == null) _maxNØ = "" + Math.Round(_maxY * _enhet.Value)
                + " " + Math.Round(_maxX * _enhet.Value);
            if (_bildeSYS == null) _bildeSYS = _koordsys;
            if (_bildeBitPixel == null) _bildeBitPixel = 24;
        }

        public override string toJGW()
        {
            double minX = _minX * _enhet.Value + _pixelX / 2;
            double maxX = _maxY * _enhet.Value + _pixelY / -2;

            //bygger et StyringJGW-objekt
            StyringJGW styrJGW = new StyringJGW(minX, maxX, 0, 0, _pixelX, _pixelY*-1, _resX, _resY, _filepath);
            return styrJGW.toJGW();
        }

        public override string toMMM()
        {
            //bygger et StyringMMM-objekt
            StyringMMM styrJGW = new StyringMMM(_resX, _resY, _minX * _enhet.Value, _minY * _enhet.Value,
                _maxX * _enhet.Value, _maxY * _enhet.Value, _filepath);
            return styrJGW.toMMM();
        }
    }



}
