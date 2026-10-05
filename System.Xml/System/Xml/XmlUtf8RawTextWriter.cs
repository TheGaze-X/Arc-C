using System;
using System.IO;
using System.Text;
using Il2CppDummyDll;

namespace System.Xml
{
	// Token: 0x0200004C RID: 76
	[Token(Token = "0x200004C")]
	internal class XmlUtf8RawTextWriter : XmlRawWriter
	{
		// Token: 0x0600037A RID: 890 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600037A")]
		[Address(RVA = "0x4FB3040", Offset = "0x4FB1C40", VA = "0x184FB3040")]
		protected XmlUtf8RawTextWriter(XmlWriterSettings settings)
		{
		}

		// Token: 0x0600037B RID: 891 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600037B")]
		[Address(RVA = "0x4FB2DB0", Offset = "0x4FB19B0", VA = "0x184FB2DB0")]
		public XmlUtf8RawTextWriter(Stream stream, XmlWriterSettings settings)
		{
		}

		// Token: 0x0600037C RID: 892 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600037C")]
		[Address(RVA = "0x4FB2B30", Offset = "0x4FB1730", VA = "0x184FB2B30", Slot = "34")]
		internal override void WriteXmlDeclaration(XmlStandalone standalone)
		{
		}

		// Token: 0x0600037D RID: 893 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600037D")]
		[Address(RVA = "0x4FB2D50", Offset = "0x4FB1950", VA = "0x184FB2D50", Slot = "35")]
		internal override void WriteXmlDeclaration(string xmldecl)
		{
		}

		// Token: 0x0600037E RID: 894 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600037E")]
		[Address(RVA = "0x4FB1790", Offset = "0x4FB0390", VA = "0x184FB1790", Slot = "8")]
		public override void WriteDocType(string name, string pubid, string sysid, string subset)
		{
		}

		// Token: 0x0600037F RID: 895 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600037F")]
		[Address(RVA = "0x4FB2790", Offset = "0x4FB1390", VA = "0x184FB2790", Slot = "9")]
		public override void WriteStartElement(string prefix, string localName, string ns)
		{
		}

		// Token: 0x06000380 RID: 896 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000380")]
		[Address(RVA = "0x4FB03B0", Offset = "0x4FAEFB0", VA = "0x184FB03B0", Slot = "36")]
		internal override void StartElementContent()
		{
		}

		// Token: 0x06000381 RID: 897 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000381")]
		[Address(RVA = "0x4FB1D80", Offset = "0x4FB0980", VA = "0x184FB1D80", Slot = "38")]
		internal override void WriteEndElement(string prefix, string localName, string ns)
		{
		}

		// Token: 0x06000382 RID: 898 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000382")]
		[Address(RVA = "0x4FB1FF0", Offset = "0x4FB0BF0", VA = "0x184FB1FF0", Slot = "39")]
		internal override void WriteFullEndElement(string prefix, string localName, string ns)
		{
		}

		// Token: 0x06000383 RID: 899 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000383")]
		[Address(RVA = "0x4FB2680", Offset = "0x4FB1280", VA = "0x184FB2680", Slot = "12")]
		public override void WriteStartAttribute(string prefix, string localName, string ns)
		{
		}

		// Token: 0x06000384 RID: 900 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000384")]
		[Address(RVA = "0x4FB1D40", Offset = "0x4FB0940", VA = "0x184FB1D40", Slot = "13")]
		public override void WriteEndAttribute()
		{
		}

		// Token: 0x06000385 RID: 901 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000385")]
		[Address(RVA = "0x4F7FDD0", Offset = "0x4F7E9D0", VA = "0x184F7FDD0", Slot = "40")]
		internal override void WriteNamespaceDeclaration(string prefix, string namespaceName)
		{
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x06000386 RID: 902 RVA: 0x00002E80 File Offset: 0x00001080
		[Token(Token = "0x170000C1")]
		internal override bool SupportsNamespaceDeclarationInChunks
		{
			[Token(Token = "0x6000386")]
			[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "41")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000387 RID: 903 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000387")]
		[Address(RVA = "0x4FB2860", Offset = "0x4FB1460", VA = "0x184FB2860", Slot = "42")]
		internal override void WriteStartNamespaceDeclaration(string prefix)
		{
		}

		// Token: 0x06000388 RID: 904 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000388")]
		[Address(RVA = "0x4FB1EE0", Offset = "0x4FB0AE0", VA = "0x184FB1EE0", Slot = "43")]
		internal override void WriteEndNamespaceDeclaration()
		{
		}

		// Token: 0x06000389 RID: 905 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000389")]
		[Address(RVA = "0x4FB0E90", Offset = "0x4FAFA90", VA = "0x184FB0E90", Slot = "14")]
		public override void WriteCData(string text)
		{
		}

		// Token: 0x0600038A RID: 906 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600038A")]
		[Address(RVA = "0x4FB1670", Offset = "0x4FB0270", VA = "0x184FB1670", Slot = "15")]
		public override void WriteComment(string text)
		{
		}

		// Token: 0x0600038B RID: 907 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600038B")]
		[Address(RVA = "0x4FB2180", Offset = "0x4FB0D80", VA = "0x184FB2180", Slot = "16")]
		public override void WriteProcessingInstruction(string name, string text)
		{
		}

		// Token: 0x0600038C RID: 908 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600038C")]
		[Address(RVA = "0x4FB1F20", Offset = "0x4FB0B20", VA = "0x184FB1F20", Slot = "17")]
		public override void WriteEntityRef(string name)
		{
		}

		// Token: 0x0600038D RID: 909 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600038D")]
		[Address(RVA = "0x4FB1080", Offset = "0x4FAFC80", VA = "0x184FB1080", Slot = "18")]
		public override void WriteCharEntity(char ch)
		{
		}

		// Token: 0x0600038E RID: 910 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600038E")]
		[Address(RVA = "0x4FB2990", Offset = "0x4FB1590", VA = "0x184FB2990", Slot = "19")]
		public override void WriteWhitespace(string ws)
		{
		}

		// Token: 0x0600038F RID: 911 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600038F")]
		[Address(RVA = "0x4FB2990", Offset = "0x4FB1590", VA = "0x184FB2990", Slot = "20")]
		public override void WriteString(string text)
		{
		}

		// Token: 0x06000390 RID: 912 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000390")]
		[Address(RVA = "0x4FB29F0", Offset = "0x4FB15F0", VA = "0x184FB29F0", Slot = "21")]
		public override void WriteSurrogateCharEntity(char lowChar, char highChar)
		{
		}

		// Token: 0x06000391 RID: 913 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000391")]
		[Address(RVA = "0x4F77970", Offset = "0x4F76570", VA = "0x184F77970", Slot = "22")]
		public override void WriteChars(char[] buffer, int index, int count)
		{
		}

		// Token: 0x06000392 RID: 914 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000392")]
		[Address(RVA = "0x4FB25E0", Offset = "0x4FB11E0", VA = "0x184FB25E0", Slot = "23")]
		public override void WriteRaw(char[] buffer, int index, int count)
		{
		}

		// Token: 0x06000393 RID: 915 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000393")]
		[Address(RVA = "0x4FB2630", Offset = "0x4FB1230", VA = "0x184FB2630", Slot = "24")]
		public override void WriteRaw(string data)
		{
		}

		// Token: 0x06000394 RID: 916 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000394")]
		[Address(RVA = "0x4FAF9D0", Offset = "0x4FAE5D0", VA = "0x184FAF9D0", Slot = "28")]
		public override void Close()
		{
		}

		// Token: 0x06000395 RID: 917 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000395")]
		[Address(RVA = "0x4FAFED0", Offset = "0x4FAEAD0", VA = "0x184FAFED0", Slot = "29")]
		public override void Flush()
		{
		}

		// Token: 0x06000396 RID: 918 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000396")]
		[Address(RVA = "0x4FAFD30", Offset = "0x4FAE930", VA = "0x184FAFD30", Slot = "46")]
		protected virtual void FlushBuffer()
		{
		}

		// Token: 0x06000397 RID: 919 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000397")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		private void FlushEncoder()
		{
		}

		// Token: 0x06000398 RID: 920 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000398")]
		[Address(RVA = "0x4FB07C0", Offset = "0x4FAF3C0", VA = "0x184FB07C0")]
		protected unsafe void WriteAttributeTextBlock(char* pSrc, char* pSrcEnd)
		{
		}

		// Token: 0x06000399 RID: 921 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000399")]
		[Address(RVA = "0x4FB1A40", Offset = "0x4FB0640", VA = "0x184FB1A40")]
		protected unsafe void WriteElementTextBlock(char* pSrc, char* pSrcEnd)
		{
		}

		// Token: 0x0600039A RID: 922 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600039A")]
		[Address(RVA = "0x4FB0140", Offset = "0x4FAED40", VA = "0x184FB0140")]
		protected void RawText(string s)
		{
		}

		// Token: 0x0600039B RID: 923 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600039B")]
		[Address(RVA = "0x4FB0190", Offset = "0x4FAED90", VA = "0x184FB0190")]
		protected unsafe void RawText(char* pSrcBegin, char* pSrcEnd)
		{
		}

		// Token: 0x0600039C RID: 924 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600039C")]
		[Address(RVA = "0x4FB22A0", Offset = "0x4FB0EA0", VA = "0x184FB22A0")]
		protected unsafe void WriteRawWithCharChecking(char* pSrcBegin, char* pSrcEnd)
		{
		}

		// Token: 0x0600039D RID: 925 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600039D")]
		[Address(RVA = "0x4FB1250", Offset = "0x4FAFE50", VA = "0x184FB1250")]
		protected void WriteCommentOrPi(string text, int stopChar)
		{
		}

		// Token: 0x0600039E RID: 926 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600039E")]
		[Address(RVA = "0x4FB0AA0", Offset = "0x4FAF6A0", VA = "0x184FB0AA0")]
		protected void WriteCDataSection(string text)
		{
		}

		// Token: 0x0600039F RID: 927 RVA: 0x00002E98 File Offset: 0x00001098
		[Token(Token = "0x600039F")]
		[Address(RVA = "0x4FB00C0", Offset = "0x4FAECC0", VA = "0x184FB00C0")]
		private static bool IsSurrogateByte(byte b)
		{
			return default(bool);
		}

		// Token: 0x060003A0 RID: 928 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003A0")]
		[Address(RVA = "0x4FAFB80", Offset = "0x4FAE780", VA = "0x184FAFB80")]
		private unsafe static byte* EncodeSurrogate(char* pSrc, char* pSrcEnd, byte* pDst)
		{
			return null;
		}

		// Token: 0x060003A1 RID: 929 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003A1")]
		[Address(RVA = "0x4FAFF50", Offset = "0x4FAEB50", VA = "0x184FAFF50")]
		private unsafe byte* InvalidXmlChar(int ch, byte* pDst, bool entitize)
		{
			return null;
		}

		// Token: 0x060003A2 RID: 930 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003A2")]
		[Address(RVA = "0x4FAFA50", Offset = "0x4FAE650", VA = "0x184FAFA50")]
		internal unsafe void EncodeChar(ref char* pSrc, char* pSrcEnd, ref byte* pDst)
		{
		}

		// Token: 0x060003A3 RID: 931 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003A3")]
		[Address(RVA = "0x4FAFB30", Offset = "0x4FAE730", VA = "0x184FAFB30")]
		internal unsafe static byte* EncodeMultibyteUTF8(int ch, byte* pDst)
		{
			return null;
		}

		// Token: 0x060003A4 RID: 932 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003A4")]
		[Address(RVA = "0x4FAF920", Offset = "0x4FAE520", VA = "0x184FAF920")]
		internal unsafe static void CharToUTF8(ref char* pSrc, char* pSrcEnd, ref byte* pDst)
		{
		}

		// Token: 0x060003A5 RID: 933 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003A5")]
		[Address(RVA = "0x4FB2100", Offset = "0x4FB0D00", VA = "0x184FB2100")]
		protected unsafe byte* WriteNewLine(byte* pDst)
		{
			return null;
		}

		// Token: 0x060003A6 RID: 934 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003A6")]
		[Address(RVA = "0x4FB00E0", Offset = "0x4FAECE0", VA = "0x184FB00E0")]
		protected unsafe static byte* LtEntity(byte* pDst)
		{
			return null;
		}

		// Token: 0x060003A7 RID: 935 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003A7")]
		[Address(RVA = "0x4FAFF40", Offset = "0x4FAEB40", VA = "0x184FAFF40")]
		protected unsafe static byte* GtEntity(byte* pDst)
		{
			return null;
		}

		// Token: 0x060003A8 RID: 936 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003A8")]
		[Address(RVA = "0x4FAF860", Offset = "0x4FAE460", VA = "0x184FAF860")]
		protected unsafe static byte* AmpEntity(byte* pDst)
		{
			return null;
		}

		// Token: 0x060003A9 RID: 937 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003A9")]
		[Address(RVA = "0x4FB00F0", Offset = "0x4FAECF0", VA = "0x184FB00F0")]
		protected unsafe static byte* QuoteEntity(byte* pDst)
		{
			return null;
		}

		// Token: 0x060003AA RID: 938 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003AA")]
		[Address(RVA = "0x4FB03F0", Offset = "0x4FAEFF0", VA = "0x184FB03F0")]
		protected unsafe static byte* TabEntity(byte* pDst)
		{
			return null;
		}

		// Token: 0x060003AB RID: 939 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003AB")]
		[Address(RVA = "0x4FB00D0", Offset = "0x4FAECD0", VA = "0x184FB00D0")]
		protected unsafe static byte* LineFeedEntity(byte* pDst)
		{
			return null;
		}

		// Token: 0x060003AC RID: 940 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003AC")]
		[Address(RVA = "0x4FAF870", Offset = "0x4FAE470", VA = "0x184FAF870")]
		protected unsafe static byte* CarriageReturnEntity(byte* pDst)
		{
			return null;
		}

		// Token: 0x060003AD RID: 941 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003AD")]
		[Address(RVA = "0x4FAF880", Offset = "0x4FAE480", VA = "0x184FAF880")]
		private unsafe static byte* CharEntity(byte* pDst, char ch)
		{
			return null;
		}

		// Token: 0x060003AE RID: 942 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003AE")]
		[Address(RVA = "0x4FB0120", Offset = "0x4FAED20", VA = "0x184FB0120")]
		protected unsafe static byte* RawStartCData(byte* pDst)
		{
			return null;
		}

		// Token: 0x060003AF RID: 943 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003AF")]
		[Address(RVA = "0x4FB0110", Offset = "0x4FAED10", VA = "0x184FB0110")]
		protected unsafe static byte* RawEndCData(byte* pDst)
		{
			return null;
		}

		// Token: 0x060003B0 RID: 944 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003B0")]
		[Address(RVA = "0x4FB0400", Offset = "0x4FAF000", VA = "0x184FB0400")]
		protected void ValidateContentChars(string chars, string propertyName, bool allowOnlyWhitespace)
		{
		}

		// Token: 0x040001C1 RID: 449
		[Token(Token = "0x40001C1")]
		[FieldOffset(Offset = "0x20")]
		private readonly bool useAsync;

		// Token: 0x040001C2 RID: 450
		[Token(Token = "0x40001C2")]
		[FieldOffset(Offset = "0x28")]
		protected byte[] bufBytes;

		// Token: 0x040001C3 RID: 451
		[Token(Token = "0x40001C3")]
		[FieldOffset(Offset = "0x30")]
		protected Stream stream;

		// Token: 0x040001C4 RID: 452
		[Token(Token = "0x40001C4")]
		[FieldOffset(Offset = "0x38")]
		protected Encoding encoding;

		// Token: 0x040001C5 RID: 453
		[Token(Token = "0x40001C5")]
		[FieldOffset(Offset = "0x40")]
		protected XmlCharType xmlCharType;

		// Token: 0x040001C6 RID: 454
		[Token(Token = "0x40001C6")]
		[FieldOffset(Offset = "0x48")]
		protected int bufPos;

		// Token: 0x040001C7 RID: 455
		[Token(Token = "0x40001C7")]
		[FieldOffset(Offset = "0x4C")]
		protected int textPos;

		// Token: 0x040001C8 RID: 456
		[Token(Token = "0x40001C8")]
		[FieldOffset(Offset = "0x50")]
		protected int contentPos;

		// Token: 0x040001C9 RID: 457
		[Token(Token = "0x40001C9")]
		[FieldOffset(Offset = "0x54")]
		protected int cdataPos;

		// Token: 0x040001CA RID: 458
		[Token(Token = "0x40001CA")]
		[FieldOffset(Offset = "0x58")]
		protected int attrEndPos;

		// Token: 0x040001CB RID: 459
		[Token(Token = "0x40001CB")]
		[FieldOffset(Offset = "0x5C")]
		protected int bufLen;

		// Token: 0x040001CC RID: 460
		[Token(Token = "0x40001CC")]
		[FieldOffset(Offset = "0x60")]
		protected bool writeToNull;

		// Token: 0x040001CD RID: 461
		[Token(Token = "0x40001CD")]
		[FieldOffset(Offset = "0x61")]
		protected bool hadDoubleBracket;

		// Token: 0x040001CE RID: 462
		[Token(Token = "0x40001CE")]
		[FieldOffset(Offset = "0x62")]
		protected bool inAttributeValue;

		// Token: 0x040001CF RID: 463
		[Token(Token = "0x40001CF")]
		[FieldOffset(Offset = "0x64")]
		protected NewLineHandling newLineHandling;

		// Token: 0x040001D0 RID: 464
		[Token(Token = "0x40001D0")]
		[FieldOffset(Offset = "0x68")]
		protected bool closeOutput;

		// Token: 0x040001D1 RID: 465
		[Token(Token = "0x40001D1")]
		[FieldOffset(Offset = "0x69")]
		protected bool omitXmlDeclaration;

		// Token: 0x040001D2 RID: 466
		[Token(Token = "0x40001D2")]
		[FieldOffset(Offset = "0x70")]
		protected string newLineChars;

		// Token: 0x040001D3 RID: 467
		[Token(Token = "0x40001D3")]
		[FieldOffset(Offset = "0x78")]
		protected bool checkCharacters;

		// Token: 0x040001D4 RID: 468
		[Token(Token = "0x40001D4")]
		[FieldOffset(Offset = "0x7C")]
		protected XmlStandalone standalone;

		// Token: 0x040001D5 RID: 469
		[Token(Token = "0x40001D5")]
		[FieldOffset(Offset = "0x80")]
		protected XmlOutputMethod outputMethod;

		// Token: 0x040001D6 RID: 470
		[Token(Token = "0x40001D6")]
		[FieldOffset(Offset = "0x84")]
		protected bool autoXmlDeclaration;

		// Token: 0x040001D7 RID: 471
		[Token(Token = "0x40001D7")]
		[FieldOffset(Offset = "0x85")]
		protected bool mergeCDataSections;
	}
}
