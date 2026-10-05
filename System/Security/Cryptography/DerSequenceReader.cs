using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text;
using Il2CppDummyDll;

namespace System.Security.Cryptography
{
	// Token: 0x02000121 RID: 289
	[Token(Token = "0x2000121")]
	internal class DerSequenceReader
	{
		// Token: 0x1700013B RID: 315
		// (set) Token: 0x06000705 RID: 1797 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700013B")]
		private int ContentLength
		{
			[Token(Token = "0x6000705")]
			[Address(RVA = "0x4EAC20", Offset = "0x4E9820", VA = "0x1804EAC20")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000706 RID: 1798 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000706")]
		[Address(RVA = "0x5107B20", Offset = "0x5106720", VA = "0x185107B20")]
		internal DerSequenceReader(byte[] data)
		{
		}

		// Token: 0x06000707 RID: 1799 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000707")]
		[Address(RVA = "0x5107B60", Offset = "0x5106760", VA = "0x185107B60")]
		internal DerSequenceReader(byte[] data, int offset, int length)
		{
		}

		// Token: 0x06000708 RID: 1800 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000708")]
		[Address(RVA = "0x51079A0", Offset = "0x51065A0", VA = "0x1851079A0")]
		private DerSequenceReader(DerSequenceReader.DerTag tagToEat, byte[] data, int offset, int length)
		{
		}

		// Token: 0x1700013C RID: 316
		// (get) Token: 0x06000709 RID: 1801 RVA: 0x00004C80 File Offset: 0x00002E80
		[Token(Token = "0x1700013C")]
		internal bool HasData
		{
			[Token(Token = "0x6000709")]
			[Address(RVA = "0x5107B90", Offset = "0x5106790", VA = "0x185107B90")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600070A RID: 1802 RVA: 0x00004C98 File Offset: 0x00002E98
		[Token(Token = "0x600070A")]
		[Address(RVA = "0x5106030", Offset = "0x5104C30", VA = "0x185106030")]
		internal byte PeekTag()
		{
			return 0;
		}

		// Token: 0x0600070B RID: 1803 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600070B")]
		[Address(RVA = "0x51078E0", Offset = "0x51064E0", VA = "0x1851078E0")]
		internal void SkipValue()
		{
		}

		// Token: 0x0600070C RID: 1804 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600070C")]
		[Address(RVA = "0x5106830", Offset = "0x5105430", VA = "0x185106830")]
		internal byte[] ReadNextEncodedValue()
		{
			return null;
		}

		// Token: 0x0600070D RID: 1805 RVA: 0x00004CB0 File Offset: 0x00002EB0
		[Token(Token = "0x600070D")]
		[Address(RVA = "0x51063B0", Offset = "0x5104FB0", VA = "0x1851063B0")]
		internal bool ReadBoolean()
		{
			return default(bool);
		}

		// Token: 0x0600070E RID: 1806 RVA: 0x00004CC8 File Offset: 0x00002EC8
		[Token(Token = "0x600070E")]
		[Address(RVA = "0x5106780", Offset = "0x5105380", VA = "0x185106780")]
		internal int ReadInteger()
		{
			return 0;
		}

		// Token: 0x0600070F RID: 1807 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600070F")]
		[Address(RVA = "0x5106750", Offset = "0x5105350", VA = "0x185106750")]
		internal byte[] ReadIntegerBytes()
		{
			return null;
		}

		// Token: 0x06000710 RID: 1808 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000710")]
		[Address(RVA = "0x5106220", Offset = "0x5104E20", VA = "0x185106220")]
		internal byte[] ReadBitString()
		{
			return null;
		}

		// Token: 0x06000711 RID: 1809 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000711")]
		[Address(RVA = "0x51068E0", Offset = "0x51054E0", VA = "0x1851068E0")]
		internal byte[] ReadOctetString()
		{
			return null;
		}

		// Token: 0x06000712 RID: 1810 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000712")]
		[Address(RVA = "0x5106910", Offset = "0x5105510", VA = "0x185106910")]
		internal string ReadOidAsString()
		{
			return null;
		}

		// Token: 0x06000713 RID: 1811 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000713")]
		[Address(RVA = "0x51073D0", Offset = "0x5105FD0", VA = "0x1851073D0")]
		internal string ReadUtf8String()
		{
			return null;
		}

		// Token: 0x06000714 RID: 1812 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000714")]
		[Address(RVA = "0x5106480", Offset = "0x5105080", VA = "0x185106480")]
		private DerSequenceReader ReadCollectionWithTag(DerSequenceReader.DerTag expected)
		{
			return null;
		}

		// Token: 0x06000715 RID: 1813 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000715")]
		[Address(RVA = "0x5106D90", Offset = "0x5105990", VA = "0x185106D90")]
		internal DerSequenceReader ReadSequence()
		{
			return null;
		}

		// Token: 0x06000716 RID: 1814 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000716")]
		[Address(RVA = "0x5106DA0", Offset = "0x51059A0", VA = "0x185106DA0")]
		internal DerSequenceReader ReadSet()
		{
			return null;
		}

		// Token: 0x06000717 RID: 1815 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000717")]
		[Address(RVA = "0x5106C90", Offset = "0x5105890", VA = "0x185106C90")]
		internal string ReadPrintableString()
		{
			return null;
		}

		// Token: 0x06000718 RID: 1816 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000718")]
		[Address(RVA = "0x5106650", Offset = "0x5105250", VA = "0x185106650")]
		internal string ReadIA5String()
		{
			return null;
		}

		// Token: 0x06000719 RID: 1817 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000719")]
		[Address(RVA = "0x5106DB0", Offset = "0x51059B0", VA = "0x185106DB0")]
		internal string ReadT61String()
		{
			return null;
		}

		// Token: 0x0600071A RID: 1818 RVA: 0x00004CE0 File Offset: 0x00002EE0
		[Token(Token = "0x600071A")]
		[Address(RVA = "0x51074D0", Offset = "0x51060D0", VA = "0x1851074D0")]
		internal DateTime ReadX509Date()
		{
			return default(DateTime);
		}

		// Token: 0x0600071B RID: 1819 RVA: 0x00004CF8 File Offset: 0x00002EF8
		[Token(Token = "0x600071B")]
		[Address(RVA = "0x5107390", Offset = "0x5105F90", VA = "0x185107390")]
		internal DateTime ReadUtcTime()
		{
			return default(DateTime);
		}

		// Token: 0x0600071C RID: 1820 RVA: 0x00004D10 File Offset: 0x00002F10
		[Token(Token = "0x600071C")]
		[Address(RVA = "0x5106610", Offset = "0x5105210", VA = "0x185106610")]
		internal DateTime ReadGeneralizedTime()
		{
			return default(DateTime);
		}

		// Token: 0x0600071D RID: 1821 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600071D")]
		[Address(RVA = "0x5106120", Offset = "0x5104D20", VA = "0x185106120")]
		internal string ReadBMPString()
		{
			return null;
		}

		// Token: 0x0600071E RID: 1822 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600071E")]
		[Address(RVA = "0x5107930", Offset = "0x5106530", VA = "0x185107930")]
		private static string TrimTrailingNulls(string value)
		{
			return null;
		}

		// Token: 0x0600071F RID: 1823 RVA: 0x00004D28 File Offset: 0x00002F28
		[Token(Token = "0x600071F")]
		[Address(RVA = "0x5107100", Offset = "0x5105D00", VA = "0x185107100")]
		private DateTime ReadTime(DerSequenceReader.DerTag timeTag, string formatString)
		{
			return default(DateTime);
		}

		// Token: 0x06000720 RID: 1824 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000720")]
		[Address(RVA = "0x5106560", Offset = "0x5105160", VA = "0x185106560")]
		private byte[] ReadContentAsBytes()
		{
			return null;
		}

		// Token: 0x06000721 RID: 1825 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000721")]
		[Address(RVA = "0x5105FB0", Offset = "0x5104BB0", VA = "0x185105FB0")]
		private void EatTag(DerSequenceReader.DerTag expected)
		{
		}

		// Token: 0x06000722 RID: 1826 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000722")]
		[Address(RVA = "0x5105E20", Offset = "0x5104A20", VA = "0x185105E20")]
		private static void CheckTag(DerSequenceReader.DerTag expected, byte[] data, int position)
		{
		}

		// Token: 0x06000723 RID: 1827 RVA: 0x00004D40 File Offset: 0x00002F40
		[Token(Token = "0x6000723")]
		[Address(RVA = "0x5105F70", Offset = "0x5104B70", VA = "0x185105F70")]
		private int EatLength()
		{
			return 0;
		}

		// Token: 0x06000724 RID: 1828 RVA: 0x00004D58 File Offset: 0x00002F58
		[Token(Token = "0x6000724")]
		[Address(RVA = "0x51075B0", Offset = "0x51061B0", VA = "0x1851075B0")]
		private static int ScanContentLength(byte[] data, int offset, int end, out int bytesConsumed)
		{
			return 0;
		}

		// Token: 0x040004F7 RID: 1271
		[Token(Token = "0x40004F7")]
		[FieldOffset(Offset = "0x0")]
		internal static DateTimeFormatInfo s_validityDateTimeFormatInfo;

		// Token: 0x040004F8 RID: 1272
		[Token(Token = "0x40004F8")]
		[FieldOffset(Offset = "0x8")]
		private static Encoding s_utf8EncodingWithExceptionFallback;

		// Token: 0x040004F9 RID: 1273
		[Token(Token = "0x40004F9")]
		[FieldOffset(Offset = "0x10")]
		private static Encoding s_latin1Encoding;

		// Token: 0x040004FA RID: 1274
		[Token(Token = "0x40004FA")]
		[FieldOffset(Offset = "0x10")]
		private readonly byte[] _data;

		// Token: 0x040004FB RID: 1275
		[Token(Token = "0x40004FB")]
		[FieldOffset(Offset = "0x18")]
		private readonly int _end;

		// Token: 0x040004FC RID: 1276
		[Token(Token = "0x40004FC")]
		[FieldOffset(Offset = "0x1C")]
		private int _position;

		// Token: 0x02000122 RID: 290
		[Token(Token = "0x2000122")]
		internal enum DerTag : byte
		{
			// Token: 0x040004FF RID: 1279
			[Token(Token = "0x40004FF")]
			Boolean = 1,
			// Token: 0x04000500 RID: 1280
			[Token(Token = "0x4000500")]
			Integer,
			// Token: 0x04000501 RID: 1281
			[Token(Token = "0x4000501")]
			BitString,
			// Token: 0x04000502 RID: 1282
			[Token(Token = "0x4000502")]
			OctetString,
			// Token: 0x04000503 RID: 1283
			[Token(Token = "0x4000503")]
			Null,
			// Token: 0x04000504 RID: 1284
			[Token(Token = "0x4000504")]
			ObjectIdentifier,
			// Token: 0x04000505 RID: 1285
			[Token(Token = "0x4000505")]
			UTF8String = 12,
			// Token: 0x04000506 RID: 1286
			[Token(Token = "0x4000506")]
			Sequence = 16,
			// Token: 0x04000507 RID: 1287
			[Token(Token = "0x4000507")]
			Set,
			// Token: 0x04000508 RID: 1288
			[Token(Token = "0x4000508")]
			PrintableString = 19,
			// Token: 0x04000509 RID: 1289
			[Token(Token = "0x4000509")]
			T61String,
			// Token: 0x0400050A RID: 1290
			[Token(Token = "0x400050A")]
			IA5String = 22,
			// Token: 0x0400050B RID: 1291
			[Token(Token = "0x400050B")]
			UTCTime,
			// Token: 0x0400050C RID: 1292
			[Token(Token = "0x400050C")]
			GeneralizedTime,
			// Token: 0x0400050D RID: 1293
			[Token(Token = "0x400050D")]
			BMPString = 30
		}
	}
}
