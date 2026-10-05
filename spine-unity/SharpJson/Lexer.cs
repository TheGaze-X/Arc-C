using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace SharpJson
{
	// Token: 0x02000002 RID: 2
	[Token(Token = "0x2000002")]
	internal class Lexer
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000001")]
		public bool hasError
		{
			[Token(Token = "0x6000001")]
			[Address(RVA = "0x4BE6480", Offset = "0x4BE5080", VA = "0x184BE6480")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000002 RID: 2 RVA: 0x00002068 File Offset: 0x00000268
		// (set) Token: 0x06000003 RID: 3 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x17000002")]
		public int lineNumber
		{
			[Token(Token = "0x6000002")]
			[Address(RVA = "0x4EA8B0", Offset = "0x4E94B0", VA = "0x1804EA8B0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000003")]
			[Address(RVA = "0x4EAC40", Offset = "0x4E9840", VA = "0x1804EAC40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000004 RID: 4 RVA: 0x00002080 File Offset: 0x00000280
		// (set) Token: 0x06000005 RID: 5 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x17000003")]
		public bool parseNumbersAsFloat
		{
			[Token(Token = "0x6000004")]
			[Address(RVA = "0x4E8AE0", Offset = "0x4E76E0", VA = "0x1804E8AE0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000005")]
			[Address(RVA = "0x4EAC50", Offset = "0x4E9850", VA = "0x1804EAC50")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000006 RID: 6 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000006")]
		[Address(RVA = "0x4E47F20", Offset = "0x4E46B20", VA = "0x184E47F20")]
		public Lexer(string text)
		{
		}

		// Token: 0x06000007 RID: 7 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000007")]
		[Address(RVA = "0x4E47E50", Offset = "0x4E46A50", VA = "0x184E47E50")]
		public void Reset()
		{
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000008")]
		[Address(RVA = "0x4E47A10", Offset = "0x4E46610", VA = "0x184E47A10")]
		public string ParseString()
		{
			return null;
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000009")]
		[Address(RVA = "0x4E47590", Offset = "0x4E46190", VA = "0x184E47590")]
		private string GetNumberString()
		{
			return null;
		}

		// Token: 0x0600000A RID: 10 RVA: 0x0000209C File Offset: 0x0000029C
		[Token(Token = "0x600000A")]
		[Address(RVA = "0x4E47980", Offset = "0x4E46580", VA = "0x184E47980")]
		public float ParseFloatNumber()
		{
			return 0f;
		}

		// Token: 0x0600000B RID: 11 RVA: 0x000020B4 File Offset: 0x000002B4
		[Token(Token = "0x600000B")]
		[Address(RVA = "0x4E478E0", Offset = "0x4E464E0", VA = "0x184E478E0")]
		public double ParseDoubleNumber()
		{
			return 0.0;
		}

		// Token: 0x0600000C RID: 12 RVA: 0x000020CC File Offset: 0x000002CC
		[Token(Token = "0x600000C")]
		[Address(RVA = "0x4E47530", Offset = "0x4E46130", VA = "0x184E47530")]
		private int GetLastIndexOfNumber(int index)
		{
			return 0;
		}

		// Token: 0x0600000D RID: 13 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600000D")]
		[Address(RVA = "0x4E47E70", Offset = "0x4E46A70", VA = "0x184E47E70")]
		private void SkipWhiteSpaces()
		{
		}

		// Token: 0x0600000E RID: 14 RVA: 0x000020E4 File Offset: 0x000002E4
		[Token(Token = "0x600000E")]
		[Address(RVA = "0x4E47620", Offset = "0x4E46220", VA = "0x184E47620")]
		public Lexer.Token LookAhead()
		{
			return Lexer.Token.None;
		}

		// Token: 0x0600000F RID: 15 RVA: 0x000020FC File Offset: 0x000002FC
		[Token(Token = "0x600000F")]
		[Address(RVA = "0x4E478B0", Offset = "0x4E464B0", VA = "0x184E478B0")]
		public Lexer.Token NextToken()
		{
			return Lexer.Token.None;
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002114 File Offset: 0x00000314
		[Token(Token = "0x6000010")]
		[Address(RVA = "0x4E47650", Offset = "0x4E46250", VA = "0x184E47650")]
		private static Lexer.Token NextToken(char[] json, ref int index)
		{
			return Lexer.Token.None;
		}

		// Token: 0x04000003 RID: 3
		[Token(Token = "0x4000003")]
		[FieldOffset(Offset = "0x18")]
		private char[] json;

		// Token: 0x04000004 RID: 4
		[Token(Token = "0x4000004")]
		[FieldOffset(Offset = "0x20")]
		private int index;

		// Token: 0x04000005 RID: 5
		[Token(Token = "0x4000005")]
		[FieldOffset(Offset = "0x24")]
		private bool success;

		// Token: 0x04000006 RID: 6
		[Token(Token = "0x4000006")]
		[FieldOffset(Offset = "0x28")]
		private char[] stringBuffer;

		// Token: 0x02000003 RID: 3
		[Token(Token = "0x2000003")]
		public enum Token
		{
			// Token: 0x04000008 RID: 8
			[Token(Token = "0x4000008")]
			None,
			// Token: 0x04000009 RID: 9
			[Token(Token = "0x4000009")]
			Null,
			// Token: 0x0400000A RID: 10
			[Token(Token = "0x400000A")]
			True,
			// Token: 0x0400000B RID: 11
			[Token(Token = "0x400000B")]
			False,
			// Token: 0x0400000C RID: 12
			[Token(Token = "0x400000C")]
			Colon,
			// Token: 0x0400000D RID: 13
			[Token(Token = "0x400000D")]
			Comma,
			// Token: 0x0400000E RID: 14
			[Token(Token = "0x400000E")]
			String,
			// Token: 0x0400000F RID: 15
			[Token(Token = "0x400000F")]
			Number,
			// Token: 0x04000010 RID: 16
			[Token(Token = "0x4000010")]
			CurlyOpen,
			// Token: 0x04000011 RID: 17
			[Token(Token = "0x4000011")]
			CurlyClose,
			// Token: 0x04000012 RID: 18
			[Token(Token = "0x4000012")]
			SquaredOpen,
			// Token: 0x04000013 RID: 19
			[Token(Token = "0x4000013")]
			SquaredClose
		}
	}
}
