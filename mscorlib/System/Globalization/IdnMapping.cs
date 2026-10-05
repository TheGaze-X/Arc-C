using System;
using Il2CppDummyDll;

namespace System.Globalization
{
	// Token: 0x02000599 RID: 1433
	[Token(Token = "0x2000599")]
	public sealed class IdnMapping
	{
		// Token: 0x06002B10 RID: 11024 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B10")]
		[Address(RVA = "0x4C57BB0", Offset = "0x4C567B0", VA = "0x184C57BB0")]
		public IdnMapping()
		{
		}

		// Token: 0x06002B11 RID: 11025 RVA: 0x00017E68 File Offset: 0x00016068
		[Token(Token = "0x6002B11")]
		[Address(RVA = "0x4C56A20", Offset = "0x4C55620", VA = "0x184C56A20", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06002B12 RID: 11026 RVA: 0x00017E80 File Offset: 0x00016080
		[Token(Token = "0x6002B12")]
		[Address(RVA = "0x4C56CB0", Offset = "0x4C558B0", VA = "0x184C56CB0", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06002B13 RID: 11027 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002B13")]
		[Address(RVA = "0x4C56AA0", Offset = "0x4C556A0", VA = "0x184C56AA0")]
		public string GetAscii(string unicode)
		{
			return null;
		}

		// Token: 0x06002B14 RID: 11028 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002B14")]
		[Address(RVA = "0x4C56B80", Offset = "0x4C55780", VA = "0x184C56B80")]
		public string GetAscii(string unicode, int index, int count)
		{
			return null;
		}

		// Token: 0x06002B15 RID: 11029 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002B15")]
		[Address(RVA = "0x4C567C0", Offset = "0x4C553C0", VA = "0x184C567C0")]
		private string Convert(string input, int index, int count, bool toAscii)
		{
			return null;
		}

		// Token: 0x06002B16 RID: 11030 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002B16")]
		[Address(RVA = "0x4C57030", Offset = "0x4C55C30", VA = "0x184C57030")]
		private string ToAscii(string s, int offset)
		{
			return null;
		}

		// Token: 0x06002B17 RID: 11031 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B17")]
		[Address(RVA = "0x4C575A0", Offset = "0x4C561A0", VA = "0x184C575A0")]
		private void VerifyLength(string s, int offset)
		{
		}

		// Token: 0x06002B18 RID: 11032 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002B18")]
		[Address(RVA = "0x4C56EE0", Offset = "0x4C55AE0", VA = "0x184C56EE0")]
		private string NamePrep(string s, int offset)
		{
			return null;
		}

		// Token: 0x06002B19 RID: 11033 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B19")]
		[Address(RVA = "0x4C576F0", Offset = "0x4C562F0", VA = "0x184C576F0")]
		private void VerifyProhibitedCharacters(string s, int offset)
		{
		}

		// Token: 0x06002B1A RID: 11034 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B1A")]
		[Address(RVA = "0x4C57920", Offset = "0x4C56520", VA = "0x184C57920")]
		private void VerifyStd3AsciiRules(string s, int offset)
		{
		}

		// Token: 0x06002B1B RID: 11035 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002B1B")]
		[Address(RVA = "0x4C56E00", Offset = "0x4C55A00", VA = "0x184C56E00")]
		public string GetUnicode(string ascii)
		{
			return null;
		}

		// Token: 0x06002B1C RID: 11036 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002B1C")]
		[Address(RVA = "0x4C56CD0", Offset = "0x4C558D0", VA = "0x184C56CD0")]
		public string GetUnicode(string ascii, int index, int count)
		{
			return null;
		}

		// Token: 0x06002B1D RID: 11037 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002B1D")]
		[Address(RVA = "0x4C573D0", Offset = "0x4C55FD0", VA = "0x184C573D0")]
		private string ToUnicode(string s, int offset)
		{
			return null;
		}

		// Token: 0x0400190E RID: 6414
		[Token(Token = "0x400190E")]
		[FieldOffset(Offset = "0x10")]
		private bool allow_unassigned;

		// Token: 0x0400190F RID: 6415
		[Token(Token = "0x400190F")]
		[FieldOffset(Offset = "0x11")]
		private bool use_std3;

		// Token: 0x04001910 RID: 6416
		[Token(Token = "0x4001910")]
		[FieldOffset(Offset = "0x18")]
		private Punycode puny;
	}
}
