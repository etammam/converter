using System;
using System.Drawing;

namespace Converter.HtmlToPdf.Enums
{
    public class PageSize
    {
        /// <property name="flag" value="Finished" />
        /// <summary>Letter format.</summary>
        public static SizeF Letter = new(612f, 792f);
        /// <property name="flag" value="Finished" />
        /// <summary>Note format.</summary>
        public static readonly SizeF Note = new(540f, 720f);
        /// <property name="flag" value="Finished" />
        /// <summary>Legal format.</summary>
        public static readonly SizeF Legal = new(612f, 1008f);
        /// <property name="flag" value="Finished" />
        /// <summary>A0 format.</summary>
        public static readonly SizeF A0 = new SizeF(2380f, 3368f);
        /// <property name="flag" value="Finished" />
        /// <summary>A1 format.</summary>
        public static readonly SizeF A1 = new SizeF(1684f, 2380f);
        /// <property name="flag" value="Finished" />
        /// <summary>A2 format.</summary>
        public static readonly SizeF A2 = new SizeF(1190f, 1684f);
        /// <property name="flag" value="Finished" />
        /// <summary>A3 format.</summary>
        public static readonly SizeF A3 = new SizeF(842f, 1190f);
        /// <property name="flag" value="Finished" />
        /// <summary>A4 format.</summary>
        public static readonly SizeF A4 = new SizeF(595f, 842f);
        /// <property name="flag" value="Finished" />
        /// <summary>A5 format.</summary>
        public static readonly SizeF A5 = new SizeF(421f, 595f);
        /// <property name="flag" value="Finished" />
        /// <summary>A6 format.</summary>
        public static readonly SizeF A6 = new SizeF(297f, 421f);
        /// <property name="flag" value="Finished" />
        /// <summary>A7 format.</summary>
        public static readonly SizeF A7 = new SizeF(210f, 297f);
        /// <property name="flag" value="Finished" />
        /// <summary>A8 format.</summary>
        public static readonly SizeF A8 = new SizeF(148f, 210f);
        /// <property name="flag" value="Finished" />
        /// <summary>A9 format.</summary>
        public static readonly SizeF A9 = new SizeF(105f, 148f);
        /// <property name="flag" value="Finished" />
        /// <summary>A10 format.</summary>
        public static readonly SizeF A10 = new SizeF(74f, 105f);
        /// <property name="flag" value="Finished" />
        /// <summary>B0 format.</summary>
        public static readonly SizeF B0 = new SizeF(2836f, 4008f);
        /// <property name="flag" value="Finished" />
        /// <summary>B1 format.</summary>
        public static readonly SizeF B1 = new SizeF(2004f, 2836f);
        /// <property name="flag" value="Finished" />
        /// <summary>B2 format.</summary>
        public static readonly SizeF B2 = new SizeF(1418f, 2004f);
        /// <property name="flag" value="Finished" />
        /// <summary>B3 format.</summary>
        public static readonly SizeF B3 = new SizeF(1002f, 1418f);
        /// <property name="flag" value="Finished" />
        /// <summary>B4 format.</summary>
        public static readonly SizeF B4 = new SizeF(709f, 1002f);
        /// <property name="flag" value="Finished" />
        /// <summary>B5 format.</summary>
        public static readonly SizeF B5 = new SizeF(501f, 709f);
        /// <property name="flag" value="Finished" />
        /// <summary>ArchE format.</summary>
        public static readonly SizeF ArchE = new SizeF(2592f, 3456f);
        /// <property name="flag" value="Finished" />
        /// <summary>ArchD format.</summary>
        public static readonly SizeF ArchD = new SizeF(1728f, 2592f);
        /// <property name="flag" value="Finished" />
        /// <summary>ArchC format.</summary>
        public static readonly SizeF ArchC = new SizeF(1296f, 1728f);
        /// <property name="flag" value="Finished" />
        /// <summary>ArchB format.</summary>
        public static readonly SizeF ArchB = new SizeF(864f, 1296f);
        /// <property name="flag" value="Finished" />
        /// <summary>ArchA format.</summary>
        public static readonly SizeF ArchA = new SizeF(648f, 864f);
        /// <property name="flag" value="Finished" />
        /// <summary>The American Foolscap format.</summary>
        public static readonly SizeF Flsa = new SizeF(612f, 936f);
        /// <property name="flag" value="Finished" />
        /// <summary>HalfLetter format.</summary>
        public static readonly SizeF HalfLetter = new SizeF(396f, 612f);
        /// <property name="flag" value="Finished" />
        /// <summary>11x17 format.</summary>
        public static readonly SizeF Letter11x17 = new SizeF(792f, 1224f);
        /// <property name="flag" value="Finished" />
        /// <summary>Ledger format.</summary>
        public static readonly SizeF Ledger = new SizeF(1224f, 792f);

        /// <property name="flag" value="Finished" />
        /// <summary>Private constructor.</summary>
        private PageSize() => throw new NotSupportedException();
    }
}