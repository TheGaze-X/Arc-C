using System;
using System.IO;
using System.Text;
using Il2CppDummyDll;

namespace System.Xml
{
	// Token: 0x02000032 RID: 50
	[Token(Token = "0x2000032")]
	internal class XmlEncodedRawTextWriter : XmlRawWriter
	{
		// Token: 0x06000150 RID: 336 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000150")]
		[Address(RVA = "0x4F80CB0", Offset = "0x4F7F8B0", VA = "0x184F80CB0")]
		protected XmlEncodedRawTextWriter(XmlWriterSettings settings)
		{
		}

		// Token: 0x06000151 RID: 337 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000151")]
		[Address(RVA = "0x4F81240", Offset = "0x4F7FE40", VA = "0x184F81240")]
		public XmlEncodedRawTextWriter(TextWriter writer, XmlWriterSettings settings)
		{
		}

		// Token: 0x06000152 RID: 338 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000152")]
		[Address(RVA = "0x4F80DD0", Offset = "0x4F7F9D0", VA = "0x184F80DD0")]
		public XmlEncodedRawTextWriter(Stream stream, XmlWriterSettings settings)
		{
		}

		// Token: 0x06000153 RID: 339 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000153")]
		[Address(RVA = "0x4F80A10", Offset = "0x4F7F610", VA = "0x184F80A10", Slot = "34")]
		internal override void WriteXmlDeclaration(XmlStandalone standalone)
		{
		}

		// Token: 0x06000154 RID: 340 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000154")]
		[Address(RVA = "0x4F80C50", Offset = "0x4F7F850", VA = "0x184F80C50", Slot = "35")]
		internal override void WriteXmlDeclaration(string xmldecl)
		{
		}

		// Token: 0x06000155 RID: 341 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000155")]
		[Address(RVA = "0x4F7F2D0", Offset = "0x4F7DED0", VA = "0x184F7F2D0", Slot = "8")]
		public override void WriteDocType(string name, string pubid, string sysid, string subset)
		{
		}

		// Token: 0x06000156 RID: 342 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000156")]
		[Address(RVA = "0x4F80510", Offset = "0x4F7F110", VA = "0x184F80510", Slot = "9")]
		public override void WriteStartElement(string prefix, string localName, string ns)
		{
		}

		// Token: 0x06000157 RID: 343 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000157")]
		[Address(RVA = "0x4F7DDE0", Offset = "0x4F7C9E0", VA = "0x184F7DDE0", Slot = "36")]
		internal override void StartElementContent()
		{
		}

		// Token: 0x06000158 RID: 344 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000158")]
		[Address(RVA = "0x4F7F980", Offset = "0x4F7E580", VA = "0x184F7F980", Slot = "38")]
		internal override void WriteEndElement(string prefix, string localName, string ns)
		{
		}

		// Token: 0x06000159 RID: 345 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000159")]
		[Address(RVA = "0x4F7FC80", Offset = "0x4F7E880", VA = "0x184F7FC80", Slot = "39")]
		internal override void WriteFullEndElement(string prefix, string localName, string ns)
		{
		}

		// Token: 0x0600015A RID: 346 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600015A")]
		[Address(RVA = "0x4F803C0", Offset = "0x4F7EFC0", VA = "0x184F803C0", Slot = "12")]
		public override void WriteStartAttribute(string prefix, string localName, string ns)
		{
		}

		// Token: 0x0600015B RID: 347 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600015B")]
		[Address(RVA = "0x4F7F910", Offset = "0x4F7E510", VA = "0x184F7F910", Slot = "13")]
		public override void WriteEndAttribute()
		{
		}

		// Token: 0x0600015C RID: 348 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600015C")]
		[Address(RVA = "0x4F7FDD0", Offset = "0x4F7E9D0", VA = "0x184F7FDD0", Slot = "40")]
		internal override void WriteNamespaceDeclaration(string prefix, string namespaceName)
		{
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x0600015D RID: 349 RVA: 0x00002328 File Offset: 0x00000528
		[Token(Token = "0x1700003A")]
		internal override bool SupportsNamespaceDeclarationInChunks
		{
			[Token(Token = "0x600015D")]
			[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "41")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600015E RID: 350 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600015E")]
		[Address(RVA = "0x4F80610", Offset = "0x4F7F210", VA = "0x184F80610", Slot = "42")]
		internal override void WriteStartNamespaceDeclaration(string prefix)
		{
		}

		// Token: 0x0600015F RID: 351 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600015F")]
		[Address(RVA = "0x4F7FB20", Offset = "0x4F7E720", VA = "0x184F7FB20", Slot = "43")]
		internal override void WriteEndNamespaceDeclaration()
		{
		}

		// Token: 0x06000160 RID: 352 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000160")]
		[Address(RVA = "0x4F7E900", Offset = "0x4F7D500", VA = "0x184F7E900", Slot = "14")]
		public override void WriteCData(string text)
		{
		}

		// Token: 0x06000161 RID: 353 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000161")]
		[Address(RVA = "0x4F7F160", Offset = "0x4F7DD60", VA = "0x184F7F160", Slot = "15")]
		public override void WriteComment(string text)
		{
		}

		// Token: 0x06000162 RID: 354 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000162")]
		[Address(RVA = "0x4F7FF00", Offset = "0x4F7EB00", VA = "0x184F7FF00", Slot = "16")]
		public override void WriteProcessingInstruction(string name, string text)
		{
		}

		// Token: 0x06000163 RID: 355 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000163")]
		[Address(RVA = "0x4F7FB90", Offset = "0x4F7E790", VA = "0x184F7FB90", Slot = "17")]
		public override void WriteEntityRef(string name)
		{
		}

		// Token: 0x06000164 RID: 356 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000164")]
		[Address(RVA = "0x4F7EB70", Offset = "0x4F7D770", VA = "0x184F7EB70", Slot = "18")]
		public override void WriteCharEntity(char ch)
		{
		}

		// Token: 0x06000165 RID: 357 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000165")]
		[Address(RVA = "0x4F80990", Offset = "0x4F7F590", VA = "0x184F80990", Slot = "19")]
		public override void WriteWhitespace(string ws)
		{
		}

		// Token: 0x06000166 RID: 358 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000166")]
		[Address(RVA = "0x4F80790", Offset = "0x4F7F390", VA = "0x184F80790", Slot = "20")]
		public override void WriteString(string text)
		{
		}

		// Token: 0x06000167 RID: 359 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000167")]
		[Address(RVA = "0x4F80810", Offset = "0x4F7F410", VA = "0x184F80810", Slot = "21")]
		public override void WriteSurrogateCharEntity(char lowChar, char highChar)
		{
		}

		// Token: 0x06000168 RID: 360 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000168")]
		[Address(RVA = "0x4F75620", Offset = "0x4F74220", VA = "0x184F75620", Slot = "22")]
		public override void WriteChars(char[] buffer, int index, int count)
		{
		}

		// Token: 0x06000169 RID: 361 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000169")]
		[Address(RVA = "0x4F80330", Offset = "0x4F7EF30", VA = "0x184F80330", Slot = "23")]
		public override void WriteRaw(char[] buffer, int index, int count)
		{
		}

		// Token: 0x0600016A RID: 362 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600016A")]
		[Address(RVA = "0x4F7A2B0", Offset = "0x4F78EB0", VA = "0x184F7A2B0", Slot = "24")]
		public override void WriteRaw(string data)
		{
		}

		// Token: 0x0600016B RID: 363 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600016B")]
		[Address(RVA = "0x4F7D0C0", Offset = "0x4F7BCC0", VA = "0x184F7D0C0", Slot = "28")]
		public override void Close()
		{
		}

		// Token: 0x0600016C RID: 364 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600016C")]
		[Address(RVA = "0x4F7D8D0", Offset = "0x4F7C4D0", VA = "0x184F7D8D0", Slot = "29")]
		public override void Flush()
		{
		}

		// Token: 0x0600016D RID: 365 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600016D")]
		[Address(RVA = "0x4F7D580", Offset = "0x4F7C180", VA = "0x184F7D580", Slot = "46")]
		protected virtual void FlushBuffer()
		{
		}

		// Token: 0x0600016E RID: 366 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600016E")]
		[Address(RVA = "0x4F7D230", Offset = "0x4F7BE30", VA = "0x184F7D230")]
		private void EncodeChars(int startOffset, int endOffset, bool writeAllToStream)
		{
		}

		// Token: 0x0600016F RID: 367 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600016F")]
		[Address(RVA = "0x4F7D7B0", Offset = "0x4F7C3B0", VA = "0x184F7D7B0")]
		private void FlushEncoder()
		{
		}

		// Token: 0x06000170 RID: 368 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000170")]
		[Address(RVA = "0x4F7E210", Offset = "0x4F7CE10", VA = "0x184F7E210")]
		protected unsafe void WriteAttributeTextBlock(char* pSrc, char* pSrcEnd)
		{
		}

		// Token: 0x06000171 RID: 369 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000171")]
		[Address(RVA = "0x4F7F5C0", Offset = "0x4F7E1C0", VA = "0x184F7F5C0")]
		protected unsafe void WriteElementTextBlock(char* pSrc, char* pSrcEnd)
		{
		}

		// Token: 0x06000172 RID: 370 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000172")]
		[Address(RVA = "0x4F7DD90", Offset = "0x4F7C990", VA = "0x184F7DD90")]
		protected void RawText(string s)
		{
		}

		// Token: 0x06000173 RID: 371 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000173")]
		[Address(RVA = "0x4F7DBF0", Offset = "0x4F7C7F0", VA = "0x184F7DBF0")]
		protected unsafe void RawText(char* pSrcBegin, char* pSrcEnd)
		{
		}

		// Token: 0x06000174 RID: 372 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000174")]
		[Address(RVA = "0x4F80070", Offset = "0x4F7EC70", VA = "0x184F80070")]
		protected unsafe void WriteRawWithCharChecking(char* pSrcBegin, char* pSrcEnd)
		{
		}

		// Token: 0x06000175 RID: 373 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000175")]
		[Address(RVA = "0x4F7ED80", Offset = "0x4F7D980", VA = "0x184F7ED80")]
		protected void WriteCommentOrPi(string text, int stopChar)
		{
		}

		// Token: 0x06000176 RID: 374 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000176")]
		[Address(RVA = "0x4F7E530", Offset = "0x4F7D130", VA = "0x184F7E530")]
		protected void WriteCDataSection(string text)
		{
		}

		// Token: 0x06000177 RID: 375 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000177")]
		[Address(RVA = "0x4F7D400", Offset = "0x4F7C000", VA = "0x184F7D400")]
		private unsafe static char* EncodeSurrogate(char* pSrc, char* pSrcEnd, char* pDst)
		{
			return null;
		}

		// Token: 0x06000178 RID: 376 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000178")]
		[Address(RVA = "0x4F7DA30", Offset = "0x4F7C630", VA = "0x184F7DA30")]
		private unsafe char* InvalidXmlChar(int ch, char* pDst, bool entitize)
		{
			return null;
		}

		// Token: 0x06000179 RID: 377 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000179")]
		[Address(RVA = "0x4F7D150", Offset = "0x4F7BD50", VA = "0x184F7D150")]
		internal unsafe void EncodeChar(ref char* pSrc, char* pSrcEnd, ref char* pDst)
		{
		}

		// Token: 0x0600017A RID: 378 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600017A")]
		[Address(RVA = "0x4F7CF30", Offset = "0x4F7BB30", VA = "0x184F7CF30")]
		protected void ChangeTextContentMark(bool value)
		{
		}

		// Token: 0x0600017B RID: 379 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600017B")]
		[Address(RVA = "0x4F7D980", Offset = "0x4F7C580", VA = "0x184F7D980")]
		private void GrowTextContentMarks()
		{
		}

		// Token: 0x0600017C RID: 380 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600017C")]
		[Address(RVA = "0x4F7FE70", Offset = "0x4F7EA70", VA = "0x184F7FE70")]
		protected unsafe char* WriteNewLine(char* pDst)
		{
			return null;
		}

		// Token: 0x0600017D RID: 381 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600017D")]
		[Address(RVA = "0x4F7DB60", Offset = "0x4F7C760", VA = "0x184F7DB60")]
		protected unsafe static char* LtEntity(char* pDst)
		{
			return null;
		}

		// Token: 0x0600017E RID: 382 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600017E")]
		[Address(RVA = "0x4F7DA10", Offset = "0x4F7C610", VA = "0x184F7DA10")]
		protected unsafe static char* GtEntity(char* pDst)
		{
			return null;
		}

		// Token: 0x0600017F RID: 383 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600017F")]
		[Address(RVA = "0x4F7CEF0", Offset = "0x4F7BAF0", VA = "0x184F7CEF0")]
		protected unsafe static char* AmpEntity(char* pDst)
		{
			return null;
		}

		// Token: 0x06000180 RID: 384 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000180")]
		[Address(RVA = "0x4F7DB80", Offset = "0x4F7C780", VA = "0x184F7DB80")]
		protected unsafe static char* QuoteEntity(char* pDst)
		{
			return null;
		}

		// Token: 0x06000181 RID: 385 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000181")]
		[Address(RVA = "0x4F7DE30", Offset = "0x4F7CA30", VA = "0x184F7DE30")]
		protected unsafe static char* TabEntity(char* pDst)
		{
			return null;
		}

		// Token: 0x06000182 RID: 386 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000182")]
		[Address(RVA = "0x4F7DB40", Offset = "0x4F7C740", VA = "0x184F7DB40")]
		protected unsafe static char* LineFeedEntity(char* pDst)
		{
			return null;
		}

		// Token: 0x06000183 RID: 387 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000183")]
		[Address(RVA = "0x4F7CF10", Offset = "0x4F7BB10", VA = "0x184F7CF10")]
		protected unsafe static char* CarriageReturnEntity(char* pDst)
		{
			return null;
		}

		// Token: 0x06000184 RID: 388 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000184")]
		[Address(RVA = "0x4F7D010", Offset = "0x4F7BC10", VA = "0x184F7D010")]
		private unsafe static char* CharEntity(char* pDst, char ch)
		{
			return null;
		}

		// Token: 0x06000185 RID: 389 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000185")]
		[Address(RVA = "0x4F7DBC0", Offset = "0x4F7C7C0", VA = "0x184F7DBC0")]
		protected unsafe static char* RawStartCData(char* pDst)
		{
			return null;
		}

		// Token: 0x06000186 RID: 390 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000186")]
		[Address(RVA = "0x4F7DBA0", Offset = "0x4F7C7A0", VA = "0x184F7DBA0")]
		protected unsafe static char* RawEndCData(char* pDst)
		{
			return null;
		}

		// Token: 0x06000187 RID: 391 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000187")]
		[Address(RVA = "0x4F7DE50", Offset = "0x4F7CA50", VA = "0x184F7DE50")]
		protected void ValidateContentChars(string chars, string propertyName, bool allowOnlyWhitespace)
		{
		}

		// Token: 0x04000087 RID: 135
		[Token(Token = "0x4000087")]
		[FieldOffset(Offset = "0x20")]
		private readonly bool useAsync;

		// Token: 0x04000088 RID: 136
		[Token(Token = "0x4000088")]
		[FieldOffset(Offset = "0x28")]
		protected byte[] bufBytes;

		// Token: 0x04000089 RID: 137
		[Token(Token = "0x4000089")]
		[FieldOffset(Offset = "0x30")]
		protected Stream stream;

		// Token: 0x0400008A RID: 138
		[Token(Token = "0x400008A")]
		[FieldOffset(Offset = "0x38")]
		protected Encoding encoding;

		// Token: 0x0400008B RID: 139
		[Token(Token = "0x400008B")]
		[FieldOffset(Offset = "0x40")]
		protected XmlCharType xmlCharType;

		// Token: 0x0400008C RID: 140
		[Token(Token = "0x400008C")]
		[FieldOffset(Offset = "0x48")]
		protected int bufPos;

		// Token: 0x0400008D RID: 141
		[Token(Token = "0x400008D")]
		[FieldOffset(Offset = "0x4C")]
		protected int textPos;

		// Token: 0x0400008E RID: 142
		[Token(Token = "0x400008E")]
		[FieldOffset(Offset = "0x50")]
		protected int contentPos;

		// Token: 0x0400008F RID: 143
		[Token(Token = "0x400008F")]
		[FieldOffset(Offset = "0x54")]
		protected int cdataPos;

		// Token: 0x04000090 RID: 144
		[Token(Token = "0x4000090")]
		[FieldOffset(Offset = "0x58")]
		protected int attrEndPos;

		// Token: 0x04000091 RID: 145
		[Token(Token = "0x4000091")]
		[FieldOffset(Offset = "0x5C")]
		protected int bufLen;

		// Token: 0x04000092 RID: 146
		[Token(Token = "0x4000092")]
		[FieldOffset(Offset = "0x60")]
		protected bool writeToNull;

		// Token: 0x04000093 RID: 147
		[Token(Token = "0x4000093")]
		[FieldOffset(Offset = "0x61")]
		protected bool hadDoubleBracket;

		// Token: 0x04000094 RID: 148
		[Token(Token = "0x4000094")]
		[FieldOffset(Offset = "0x62")]
		protected bool inAttributeValue;

		// Token: 0x04000095 RID: 149
		[Token(Token = "0x4000095")]
		[FieldOffset(Offset = "0x64")]
		protected int bufBytesUsed;

		// Token: 0x04000096 RID: 150
		[Token(Token = "0x4000096")]
		[FieldOffset(Offset = "0x68")]
		protected char[] bufChars;

		// Token: 0x04000097 RID: 151
		[Token(Token = "0x4000097")]
		[FieldOffset(Offset = "0x70")]
		protected Encoder encoder;

		// Token: 0x04000098 RID: 152
		[Token(Token = "0x4000098")]
		[FieldOffset(Offset = "0x78")]
		protected TextWriter writer;

		// Token: 0x04000099 RID: 153
		[Token(Token = "0x4000099")]
		[FieldOffset(Offset = "0x80")]
		protected bool trackTextContent;

		// Token: 0x0400009A RID: 154
		[Token(Token = "0x400009A")]
		[FieldOffset(Offset = "0x81")]
		protected bool inTextContent;

		// Token: 0x0400009B RID: 155
		[Token(Token = "0x400009B")]
		[FieldOffset(Offset = "0x84")]
		private int lastMarkPos;

		// Token: 0x0400009C RID: 156
		[Token(Token = "0x400009C")]
		[FieldOffset(Offset = "0x88")]
		private int[] textContentMarks;

		// Token: 0x0400009D RID: 157
		[Token(Token = "0x400009D")]
		[FieldOffset(Offset = "0x90")]
		private CharEntityEncoderFallback charEntityFallback;

		// Token: 0x0400009E RID: 158
		[Token(Token = "0x400009E")]
		[FieldOffset(Offset = "0x98")]
		protected NewLineHandling newLineHandling;

		// Token: 0x0400009F RID: 159
		[Token(Token = "0x400009F")]
		[FieldOffset(Offset = "0x9C")]
		protected bool closeOutput;

		// Token: 0x040000A0 RID: 160
		[Token(Token = "0x40000A0")]
		[FieldOffset(Offset = "0x9D")]
		protected bool omitXmlDeclaration;

		// Token: 0x040000A1 RID: 161
		[Token(Token = "0x40000A1")]
		[FieldOffset(Offset = "0xA0")]
		protected string newLineChars;

		// Token: 0x040000A2 RID: 162
		[Token(Token = "0x40000A2")]
		[FieldOffset(Offset = "0xA8")]
		protected bool checkCharacters;

		// Token: 0x040000A3 RID: 163
		[Token(Token = "0x40000A3")]
		[FieldOffset(Offset = "0xAC")]
		protected XmlStandalone standalone;

		// Token: 0x040000A4 RID: 164
		[Token(Token = "0x40000A4")]
		[FieldOffset(Offset = "0xB0")]
		protected XmlOutputMethod outputMethod;

		// Token: 0x040000A5 RID: 165
		[Token(Token = "0x40000A5")]
		[FieldOffset(Offset = "0xB4")]
		protected bool autoXmlDeclaration;

		// Token: 0x040000A6 RID: 166
		[Token(Token = "0x40000A6")]
		[FieldOffset(Offset = "0xB5")]
		protected bool mergeCDataSections;
	}
}
