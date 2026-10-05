using System;
using System.Text;
using Il2CppDummyDll;

namespace System.Xml
{
	// Token: 0x0200009E RID: 158
	[Token(Token = "0x200009E")]
	internal class Ucs4Encoding : Encoding
	{
		// Token: 0x170001BE RID: 446
		// (get) Token: 0x0600074F RID: 1871 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001BE")]
		public override string WebName
		{
			[Token(Token = "0x600074F")]
			[Address(RVA = "0x4D048D0", Offset = "0x4D034D0", VA = "0x184D048D0", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000750 RID: 1872 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000750")]
		[Address(RVA = "0x4EA850", Offset = "0x4E9450", VA = "0x1804EA850", Slot = "32")]
		public override Decoder GetDecoder()
		{
			return null;
		}

		// Token: 0x06000751 RID: 1873 RVA: 0x00004320 File Offset: 0x00002520
		[Token(Token = "0x6000751")]
		[Address(RVA = "0x4FEA6B0", Offset = "0x4FE92B0", VA = "0x184FEA6B0", Slot = "13")]
		public override int GetByteCount(char[] chars, int index, int count)
		{
			return 0;
		}

		// Token: 0x06000752 RID: 1874 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000752")]
		[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "19")]
		public override byte[] GetBytes(string s)
		{
			return null;
		}

		// Token: 0x06000753 RID: 1875 RVA: 0x00004338 File Offset: 0x00002538
		[Token(Token = "0x6000753")]
		[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "18")]
		public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex)
		{
			return 0;
		}

		// Token: 0x06000754 RID: 1876 RVA: 0x00004350 File Offset: 0x00002550
		[Token(Token = "0x6000754")]
		[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "34")]
		public override int GetMaxByteCount(int charCount)
		{
			return 0;
		}

		// Token: 0x06000755 RID: 1877 RVA: 0x00004368 File Offset: 0x00002568
		[Token(Token = "0x6000755")]
		[Address(RVA = "0x4FEA710", Offset = "0x4FE9310", VA = "0x184FEA710", Slot = "23")]
		public override int GetCharCount(byte[] bytes, int index, int count)
		{
			return 0;
		}

		// Token: 0x06000756 RID: 1878 RVA: 0x00004380 File Offset: 0x00002580
		[Token(Token = "0x6000756")]
		[Address(RVA = "0x4FEA790", Offset = "0x4FE9390", VA = "0x184FEA790", Slot = "28")]
		public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex)
		{
			return 0;
		}

		// Token: 0x06000757 RID: 1879 RVA: 0x00004398 File Offset: 0x00002598
		[Token(Token = "0x6000757")]
		[Address(RVA = "0x4FEA7E0", Offset = "0x4FE93E0", VA = "0x184FEA7E0", Slot = "35")]
		public override int GetMaxCharCount(int byteCount)
		{
			return 0;
		}

		// Token: 0x170001BF RID: 447
		// (get) Token: 0x06000758 RID: 1880 RVA: 0x000043B0 File Offset: 0x000025B0
		[Token(Token = "0x170001BF")]
		public override int CodePage
		{
			[Token(Token = "0x6000758")]
			[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "31")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000759 RID: 1881 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000759")]
		[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "33")]
		public override Encoder GetEncoder()
		{
			return null;
		}

		// Token: 0x170001C0 RID: 448
		// (get) Token: 0x0600075A RID: 1882 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001C0")]
		internal static Encoding UCS4_Littleendian
		{
			[Token(Token = "0x600075A")]
			[Address(RVA = "0x4FEAAD0", Offset = "0x4FE96D0", VA = "0x184FEAAD0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170001C1 RID: 449
		// (get) Token: 0x0600075B RID: 1883 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001C1")]
		internal static Encoding UCS4_Bigendian
		{
			[Token(Token = "0x600075B")]
			[Address(RVA = "0x4FEA9E0", Offset = "0x4FE95E0", VA = "0x184FEA9E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170001C2 RID: 450
		// (get) Token: 0x0600075C RID: 1884 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001C2")]
		internal static Encoding UCS4_2143
		{
			[Token(Token = "0x600075C")]
			[Address(RVA = "0x4FEA800", Offset = "0x4FE9400", VA = "0x184FEA800")]
			get
			{
				return null;
			}
		}

		// Token: 0x170001C3 RID: 451
		// (get) Token: 0x0600075D RID: 1885 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001C3")]
		internal static Encoding UCS4_3412
		{
			[Token(Token = "0x600075D")]
			[Address(RVA = "0x4FEA8F0", Offset = "0x4FE94F0", VA = "0x184FEA8F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600075E RID: 1886 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600075E")]
		[Address(RVA = "0x4FEA7F0", Offset = "0x4FE93F0", VA = "0x184FEA7F0")]
		public Ucs4Encoding()
		{
		}

		// Token: 0x040003B9 RID: 953
		[Token(Token = "0x40003B9")]
		[FieldOffset(Offset = "0x38")]
		internal Ucs4Decoder ucs4Decoder;
	}
}
