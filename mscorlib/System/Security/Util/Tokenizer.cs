using System;
using System.IO;
using System.Text;
using Il2CppDummyDll;

namespace System.Security.Util
{
	// Token: 0x020002C7 RID: 711
	[Token(Token = "0x20002C7")]
	internal sealed class Tokenizer
	{
		// Token: 0x060017DC RID: 6108 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017DC")]
		[Address(RVA = "0x4B1C600", Offset = "0x4B1B200", VA = "0x184B1C600")]
		internal void BasicInitialization()
		{
		}

		// Token: 0x060017DD RID: 6109 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017DD")]
		[Address(RVA = "0x4B1D330", Offset = "0x4B1BF30", VA = "0x184B1D330")]
		public void Recycle()
		{
		}

		// Token: 0x060017DE RID: 6110 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017DE")]
		[Address(RVA = "0x4B1D380", Offset = "0x4B1BF80", VA = "0x184B1D380")]
		internal Tokenizer(string input)
		{
		}

		// Token: 0x060017DF RID: 6111 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017DF")]
		[Address(RVA = "0x4B1C680", Offset = "0x4B1B280", VA = "0x184B1C680")]
		internal void ChangeFormat(System.Text.Encoding encoding)
		{
		}

		// Token: 0x060017E0 RID: 6112 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017E0")]
		[Address(RVA = "0x4B1C940", Offset = "0x4B1B540", VA = "0x184B1C940")]
		internal void GetTokens(TokenizerStream stream, int maxNum, bool endAfterKet)
		{
		}

		// Token: 0x060017E1 RID: 6113 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60017E1")]
		[Address(RVA = "0x4B1C920", Offset = "0x4B1B520", VA = "0x184B1C920")]
		private string GetStringToken()
		{
			return null;
		}

		// Token: 0x04000CDA RID: 3290
		[Token(Token = "0x4000CDA")]
		[FieldOffset(Offset = "0x10")]
		public int LineNo;

		// Token: 0x04000CDB RID: 3291
		[Token(Token = "0x4000CDB")]
		[FieldOffset(Offset = "0x14")]
		private int _inProcessingTag;

		// Token: 0x04000CDC RID: 3292
		[Token(Token = "0x4000CDC")]
		[FieldOffset(Offset = "0x18")]
		private byte[] _inBytes;

		// Token: 0x04000CDD RID: 3293
		[Token(Token = "0x4000CDD")]
		[FieldOffset(Offset = "0x20")]
		private char[] _inChars;

		// Token: 0x04000CDE RID: 3294
		[Token(Token = "0x4000CDE")]
		[FieldOffset(Offset = "0x28")]
		private string _inString;

		// Token: 0x04000CDF RID: 3295
		[Token(Token = "0x4000CDF")]
		[FieldOffset(Offset = "0x30")]
		private int _inIndex;

		// Token: 0x04000CE0 RID: 3296
		[Token(Token = "0x4000CE0")]
		[FieldOffset(Offset = "0x34")]
		private int _inSize;

		// Token: 0x04000CE1 RID: 3297
		[Token(Token = "0x4000CE1")]
		[FieldOffset(Offset = "0x38")]
		private int _inSavedCharacter;

		// Token: 0x04000CE2 RID: 3298
		[Token(Token = "0x4000CE2")]
		[FieldOffset(Offset = "0x3C")]
		private Tokenizer.TokenSource _inTokenSource;

		// Token: 0x04000CE3 RID: 3299
		[Token(Token = "0x4000CE3")]
		[FieldOffset(Offset = "0x40")]
		private Tokenizer.ITokenReader _inTokenReader;

		// Token: 0x04000CE4 RID: 3300
		[Token(Token = "0x4000CE4")]
		[FieldOffset(Offset = "0x48")]
		private Tokenizer.StringMaker _maker;

		// Token: 0x04000CE5 RID: 3301
		[Token(Token = "0x4000CE5")]
		[FieldOffset(Offset = "0x50")]
		private string[] _searchStrings;

		// Token: 0x04000CE6 RID: 3302
		[Token(Token = "0x4000CE6")]
		[FieldOffset(Offset = "0x58")]
		private string[] _replaceStrings;

		// Token: 0x04000CE7 RID: 3303
		[Token(Token = "0x4000CE7")]
		[FieldOffset(Offset = "0x60")]
		private int _inNestedIndex;

		// Token: 0x04000CE8 RID: 3304
		[Token(Token = "0x4000CE8")]
		[FieldOffset(Offset = "0x64")]
		private int _inNestedSize;

		// Token: 0x04000CE9 RID: 3305
		[Token(Token = "0x4000CE9")]
		[FieldOffset(Offset = "0x68")]
		private string _inNestedString;

		// Token: 0x020002C8 RID: 712
		[Token(Token = "0x20002C8")]
		private enum TokenSource
		{
			// Token: 0x04000CEB RID: 3307
			[Token(Token = "0x4000CEB")]
			UnicodeByteArray,
			// Token: 0x04000CEC RID: 3308
			[Token(Token = "0x4000CEC")]
			UTF8ByteArray,
			// Token: 0x04000CED RID: 3309
			[Token(Token = "0x4000CED")]
			ASCIIByteArray,
			// Token: 0x04000CEE RID: 3310
			[Token(Token = "0x4000CEE")]
			CharArray,
			// Token: 0x04000CEF RID: 3311
			[Token(Token = "0x4000CEF")]
			String,
			// Token: 0x04000CF0 RID: 3312
			[Token(Token = "0x4000CF0")]
			NestedStrings,
			// Token: 0x04000CF1 RID: 3313
			[Token(Token = "0x4000CF1")]
			Other
		}

		// Token: 0x020002C9 RID: 713
		[Token(Token = "0x20002C9")]
		[System.Serializable]
		internal sealed class StringMaker
		{
			// Token: 0x060017E2 RID: 6114 RVA: 0x00011250 File Offset: 0x0000F450
			[Token(Token = "0x60017E2")]
			[Address(RVA = "0x4B1B910", Offset = "0x4B1A510", VA = "0x184B1B910")]
			private static uint HashString(string str)
			{
				return 0U;
			}

			// Token: 0x060017E3 RID: 6115 RVA: 0x00011268 File Offset: 0x0000F468
			[Token(Token = "0x60017E3")]
			[Address(RVA = "0x4B1B8B0", Offset = "0x4B1A4B0", VA = "0x184B1B8B0")]
			private static uint HashCharArray(char[] a, int l)
			{
				return 0U;
			}

			// Token: 0x060017E4 RID: 6116 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60017E4")]
			[Address(RVA = "0x4B1BD10", Offset = "0x4B1A910", VA = "0x184B1BD10")]
			public StringMaker()
			{
			}

			// Token: 0x060017E5 RID: 6117 RVA: 0x00011280 File Offset: 0x0000F480
			[Token(Token = "0x60017E5")]
			[Address(RVA = "0x4B1B820", Offset = "0x4B1A420", VA = "0x184B1B820")]
			private bool CompareStringAndChars(string str, char[] a, int l)
			{
				return default(bool);
			}

			// Token: 0x060017E6 RID: 6118 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x60017E6")]
			[Address(RVA = "0x4B1B990", Offset = "0x4B1A590", VA = "0x184B1B990")]
			public string MakeString()
			{
				return null;
			}

			// Token: 0x04000CF2 RID: 3314
			[Token(Token = "0x4000CF2")]
			[FieldOffset(Offset = "0x10")]
			private string[] aStrings;

			// Token: 0x04000CF3 RID: 3315
			[Token(Token = "0x4000CF3")]
			[FieldOffset(Offset = "0x18")]
			private uint cStringsMax;

			// Token: 0x04000CF4 RID: 3316
			[Token(Token = "0x4000CF4")]
			[FieldOffset(Offset = "0x1C")]
			private uint cStringsUsed;

			// Token: 0x04000CF5 RID: 3317
			[Token(Token = "0x4000CF5")]
			[FieldOffset(Offset = "0x20")]
			public System.Text.StringBuilder _outStringBuilder;

			// Token: 0x04000CF6 RID: 3318
			[Token(Token = "0x4000CF6")]
			[FieldOffset(Offset = "0x28")]
			public char[] _outChars;

			// Token: 0x04000CF7 RID: 3319
			[Token(Token = "0x4000CF7")]
			[FieldOffset(Offset = "0x30")]
			public int _outIndex;
		}

		// Token: 0x020002CA RID: 714
		[Token(Token = "0x20002CA")]
		internal interface ITokenReader
		{
			// Token: 0x060017E7 RID: 6119
			[Token(Token = "0x60017E7")]
			int Read();
		}

		// Token: 0x020002CB RID: 715
		[Token(Token = "0x20002CB")]
		internal class StreamTokenReader : Tokenizer.ITokenReader
		{
			// Token: 0x060017E8 RID: 6120 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60017E8")]
			[Address(RVA = "0x61DBA0", Offset = "0x61C7A0", VA = "0x18061DBA0")]
			internal StreamTokenReader(System.IO.StreamReader input)
			{
			}

			// Token: 0x060017E9 RID: 6121 RVA: 0x00011298 File Offset: 0x0000F498
			[Token(Token = "0x60017E9")]
			[Address(RVA = "0x4B1B7B0", Offset = "0x4B1A3B0", VA = "0x184B1B7B0", Slot = "5")]
			public virtual int Read()
			{
				return 0;
			}

			// Token: 0x1700026C RID: 620
			// (get) Token: 0x060017EA RID: 6122 RVA: 0x000112B0 File Offset: 0x0000F4B0
			[Token(Token = "0x1700026C")]
			internal int NumCharEncountered
			{
				[Token(Token = "0x60017EA")]
				[Address(RVA = "0x4EA860", Offset = "0x4E9460", VA = "0x1804EA860")]
				get
				{
					return 0;
				}
			}

			// Token: 0x04000CF8 RID: 3320
			[Token(Token = "0x4000CF8")]
			[FieldOffset(Offset = "0x10")]
			internal System.IO.StreamReader _in;

			// Token: 0x04000CF9 RID: 3321
			[Token(Token = "0x4000CF9")]
			[FieldOffset(Offset = "0x18")]
			internal int _numCharRead;
		}
	}
}
