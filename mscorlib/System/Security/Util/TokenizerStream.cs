using System;
using Il2CppDummyDll;

namespace System.Security.Util
{
	// Token: 0x020002CE RID: 718
	[Token(Token = "0x20002CE")]
	internal sealed class TokenizerStream
	{
		// Token: 0x060017ED RID: 6125 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017ED")]
		[Address(RVA = "0x4B1C410", Offset = "0x4B1B010", VA = "0x184B1C410")]
		internal TokenizerStream()
		{
		}

		// Token: 0x060017EE RID: 6126 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017EE")]
		[Address(RVA = "0x4B1BF80", Offset = "0x4B1AB80", VA = "0x184B1BF80")]
		internal void AddToken(short token)
		{
		}

		// Token: 0x060017EF RID: 6127 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017EF")]
		[Address(RVA = "0x4B1BE00", Offset = "0x4B1AA00", VA = "0x184B1BE00")]
		internal void AddString(string str)
		{
		}

		// Token: 0x060017F0 RID: 6128 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017F0")]
		[Address(RVA = "0x4B1C330", Offset = "0x4B1AF30", VA = "0x184B1C330")]
		internal void Reset()
		{
		}

		// Token: 0x060017F1 RID: 6129 RVA: 0x000112C8 File Offset: 0x0000F4C8
		[Token(Token = "0x60017F1")]
		[Address(RVA = "0x4B1C0D0", Offset = "0x4B1ACD0", VA = "0x184B1C0D0")]
		internal short GetNextFullToken()
		{
			return 0;
		}

		// Token: 0x060017F2 RID: 6130 RVA: 0x000112E0 File Offset: 0x0000F4E0
		[Token(Token = "0x60017F2")]
		[Address(RVA = "0x4B1C1F0", Offset = "0x4B1ADF0", VA = "0x184B1C1F0")]
		internal short GetNextToken()
		{
			return 0;
		}

		// Token: 0x060017F3 RID: 6131 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60017F3")]
		[Address(RVA = "0x4B1C170", Offset = "0x4B1AD70", VA = "0x184B1C170")]
		internal string GetNextString()
		{
			return null;
		}

		// Token: 0x060017F4 RID: 6132 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017F4")]
		[Address(RVA = "0x4B1C400", Offset = "0x4B1B000", VA = "0x184B1C400")]
		internal void ThrowAwayNextString()
		{
		}

		// Token: 0x060017F5 RID: 6133 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017F5")]
		[Address(RVA = "0x4B1C380", Offset = "0x4B1AF80", VA = "0x184B1C380")]
		internal void TagLastToken(short tag)
		{
		}

		// Token: 0x060017F6 RID: 6134 RVA: 0x000112F8 File Offset: 0x0000F4F8
		[Token(Token = "0x60017F6")]
		[Address(RVA = "0x4EA8B0", Offset = "0x4E94B0", VA = "0x1804EA8B0")]
		internal int GetTokenCount()
		{
			return 0;
		}

		// Token: 0x060017F7 RID: 6135 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017F7")]
		[Address(RVA = "0x4B1C210", Offset = "0x4B1AE10", VA = "0x184B1C210")]
		internal void GoToPosition(int position)
		{
		}

		// Token: 0x04000CFE RID: 3326
		[Token(Token = "0x4000CFE")]
		[FieldOffset(Offset = "0x10")]
		private int m_countTokens;

		// Token: 0x04000CFF RID: 3327
		[Token(Token = "0x4000CFF")]
		[FieldOffset(Offset = "0x18")]
		private TokenizerShortBlock m_headTokens;

		// Token: 0x04000D00 RID: 3328
		[Token(Token = "0x4000D00")]
		[FieldOffset(Offset = "0x20")]
		private TokenizerShortBlock m_lastTokens;

		// Token: 0x04000D01 RID: 3329
		[Token(Token = "0x4000D01")]
		[FieldOffset(Offset = "0x28")]
		private TokenizerShortBlock m_currentTokens;

		// Token: 0x04000D02 RID: 3330
		[Token(Token = "0x4000D02")]
		[FieldOffset(Offset = "0x30")]
		private int m_indexTokens;

		// Token: 0x04000D03 RID: 3331
		[Token(Token = "0x4000D03")]
		[FieldOffset(Offset = "0x38")]
		private TokenizerStringBlock m_headStrings;

		// Token: 0x04000D04 RID: 3332
		[Token(Token = "0x4000D04")]
		[FieldOffset(Offset = "0x40")]
		private TokenizerStringBlock m_currentStrings;

		// Token: 0x04000D05 RID: 3333
		[Token(Token = "0x4000D05")]
		[FieldOffset(Offset = "0x48")]
		private int m_indexStrings;
	}
}
