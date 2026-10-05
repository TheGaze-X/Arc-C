using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace System.Text.RegularExpressions
{
	// Token: 0x020000E2 RID: 226
	[Token(Token = "0x20000E2")]
	[Serializable]
	public class Match : Group
	{
		// Token: 0x060004D9 RID: 1241 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60004D9")]
		[Address(RVA = "0x50EC8C0", Offset = "0x50EB4C0", VA = "0x1850EC8C0")]
		internal Match(Regex regex, int capcount, string text, int begpos, int len, int startpos)
		{
		}

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x060004DA RID: 1242 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000E4")]
		public static Match Empty
		{
			[Token(Token = "0x60004DA")]
			[Address(RVA = "0x50ECAB0", Offset = "0x50EB6B0", VA = "0x1850ECAB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x060004DB RID: 1243 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60004DB")]
		[Address(RVA = "0x50EC5A0", Offset = "0x50EB1A0", VA = "0x1850EC5A0", Slot = "4")]
		internal virtual void Reset(Regex regex, string text, int textbeg, int textend, int textstart)
		{
		}

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x060004DC RID: 1244 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000E5")]
		public virtual GroupCollection Groups
		{
			[Token(Token = "0x60004DC")]
			[Address(RVA = "0x50ECB00", Offset = "0x50EB700", VA = "0x1850ECB00", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x060004DD RID: 1245 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004DD")]
		[Address(RVA = "0x50EC520", Offset = "0x50EB120", VA = "0x1850EC520")]
		public Match NextMatch()
		{
			return null;
		}

		// Token: 0x060004DE RID: 1246 RVA: 0x00003C78 File Offset: 0x00001E78
		[Token(Token = "0x60004DE")]
		[Address(RVA = "0x50EC1B0", Offset = "0x50EADB0", VA = "0x1850EC1B0", Slot = "6")]
		internal virtual ReadOnlySpan<char> GroupToStringImpl(int groupnum)
		{
			return default(ReadOnlySpan<char>);
		}

		// Token: 0x060004DF RID: 1247 RVA: 0x00003C90 File Offset: 0x00001E90
		[Token(Token = "0x60004DF")]
		[Address(RVA = "0x50EC3C0", Offset = "0x50EAFC0", VA = "0x1850EC3C0")]
		internal ReadOnlySpan<char> LastGroupToStringImpl()
		{
			return default(ReadOnlySpan<char>);
		}

		// Token: 0x060004E0 RID: 1248 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60004E0")]
		[Address(RVA = "0x50EBDC0", Offset = "0x50EA9C0", VA = "0x1850EBDC0", Slot = "7")]
		internal virtual void AddMatch(int cap, int start, int len)
		{
		}

		// Token: 0x060004E1 RID: 1249 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60004E1")]
		[Address(RVA = "0x50EC020", Offset = "0x50EAC20", VA = "0x1850EC020", Slot = "8")]
		internal virtual void BalanceMatch(int cap)
		{
		}

		// Token: 0x060004E2 RID: 1250 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60004E2")]
		[Address(RVA = "0x50EC570", Offset = "0x50EB170", VA = "0x1850EC570", Slot = "9")]
		internal virtual void RemoveMatch(int cap)
		{
		}

		// Token: 0x060004E3 RID: 1251 RVA: 0x00003CA8 File Offset: 0x00001EA8
		[Token(Token = "0x60004E3")]
		[Address(RVA = "0x50EC350", Offset = "0x50EAF50", VA = "0x1850EC350", Slot = "10")]
		internal virtual bool IsMatched(int cap)
		{
			return default(bool);
		}

		// Token: 0x060004E4 RID: 1252 RVA: 0x00003CC0 File Offset: 0x00001EC0
		[Token(Token = "0x60004E4")]
		[Address(RVA = "0x50EC430", Offset = "0x50EB030", VA = "0x1850EC430", Slot = "11")]
		internal virtual int MatchIndex(int cap)
		{
			return 0;
		}

		// Token: 0x060004E5 RID: 1253 RVA: 0x00003CD8 File Offset: 0x00001ED8
		[Token(Token = "0x60004E5")]
		[Address(RVA = "0x50EC4B0", Offset = "0x50EB0B0", VA = "0x1850EC4B0", Slot = "12")]
		internal virtual int MatchLength(int cap)
		{
			return 0;
		}

		// Token: 0x060004E6 RID: 1254 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60004E6")]
		[Address(RVA = "0x50EC650", Offset = "0x50EB250", VA = "0x1850EC650", Slot = "13")]
		internal virtual void Tidy(int textpos)
		{
		}

		// Token: 0x060004E8 RID: 1256 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60004E8")]
		[Address(RVA = "0x50ECA80", Offset = "0x50EB680", VA = "0x1850ECA80")]
		internal Match()
		{
		}

		// Token: 0x04000357 RID: 855
		[Token(Token = "0x4000357")]
		[FieldOffset(Offset = "0x40")]
		internal GroupCollection _groupcoll;

		// Token: 0x04000358 RID: 856
		[Token(Token = "0x4000358")]
		[FieldOffset(Offset = "0x48")]
		internal Regex _regex;

		// Token: 0x04000359 RID: 857
		[Token(Token = "0x4000359")]
		[FieldOffset(Offset = "0x50")]
		internal int _textbeg;

		// Token: 0x0400035A RID: 858
		[Token(Token = "0x400035A")]
		[FieldOffset(Offset = "0x54")]
		internal int _textpos;

		// Token: 0x0400035B RID: 859
		[Token(Token = "0x400035B")]
		[FieldOffset(Offset = "0x58")]
		internal int _textend;

		// Token: 0x0400035C RID: 860
		[Token(Token = "0x400035C")]
		[FieldOffset(Offset = "0x5C")]
		internal int _textstart;

		// Token: 0x0400035D RID: 861
		[Token(Token = "0x400035D")]
		[FieldOffset(Offset = "0x60")]
		internal int[][] _matches;

		// Token: 0x0400035E RID: 862
		[Token(Token = "0x400035E")]
		[FieldOffset(Offset = "0x68")]
		internal int[] _matchcount;

		// Token: 0x0400035F RID: 863
		[Token(Token = "0x400035F")]
		[FieldOffset(Offset = "0x70")]
		internal bool _balancing;
	}
}
