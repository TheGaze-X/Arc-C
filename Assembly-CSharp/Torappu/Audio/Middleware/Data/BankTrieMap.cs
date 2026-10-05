using System;
using Il2CppDummyDll;

namespace Torappu.Audio.Middleware.Data
{
	// Token: 0x02001FB7 RID: 8119
	[Token(Token = "0x2001FB7")]
	public class BankTrieMap
	{
		// Token: 0x0600C9AB RID: 51627 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C9AB")]
		[Address(RVA = "0x34A6220", Offset = "0x34A4E20", VA = "0x1834A6220")]
		public void Add(string key, Bank bank)
		{
		}

		// Token: 0x0600C9AC RID: 51628 RVA: 0x00049350 File Offset: 0x00047550
		[Token(Token = "0x600C9AC")]
		[Address(RVA = "0x34A6420", Offset = "0x34A5020", VA = "0x1834A6420")]
		public bool TryGet(string key, out Bank bank)
		{
			return default(bool);
		}

		// Token: 0x0600C9AD RID: 51629 RVA: 0x00049368 File Offset: 0x00047568
		[Token(Token = "0x600C9AD")]
		[Address(RVA = "0x34A64D0", Offset = "0x34A50D0", VA = "0x1834A64D0")]
		public bool TryGet(string key1, string key2, out Bank bank)
		{
			return default(bool);
		}

		// Token: 0x0600C9AE RID: 51630 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C9AE")]
		[Address(RVA = "0x34A63E0", Offset = "0x34A4FE0", VA = "0x1834A63E0")]
		public void Clear()
		{
		}

		// Token: 0x0600C9AF RID: 51631 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C9AF")]
		[Address(RVA = "0x34A6680", Offset = "0x34A5280", VA = "0x1834A6680")]
		public BankTrieMap()
		{
		}

		// Token: 0x0400D20E RID: 53774
		[Token(Token = "0x400D20E")]
		private const int SEPARATOR_CHAR = 46;

		// Token: 0x0400D20F RID: 53775
		[Token(Token = "0x400D20F")]
		private const int ALPHABET_SIZE = 128;

		// Token: 0x0400D210 RID: 53776
		[Token(Token = "0x400D210")]
		[FieldOffset(Offset = "0x10")]
		private BankTrieMap.TrieNode m_root;

		// Token: 0x02001FB8 RID: 8120
		[Token(Token = "0x2001FB8")]
		private class TrieNode
		{
			// Token: 0x0600C9B0 RID: 51632 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C9B0")]
			[Address(RVA = "0x34B58A0", Offset = "0x34B44A0", VA = "0x1834B58A0")]
			public void Reset()
			{
			}

			// Token: 0x0600C9B1 RID: 51633 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C9B1")]
			[Address(RVA = "0x34B58E0", Offset = "0x34B44E0", VA = "0x1834B58E0")]
			public TrieNode()
			{
			}

			// Token: 0x0400D211 RID: 53777
			[Token(Token = "0x400D211")]
			[FieldOffset(Offset = "0x10")]
			public Bank bank;

			// Token: 0x0400D212 RID: 53778
			[Token(Token = "0x400D212")]
			[FieldOffset(Offset = "0x18")]
			public BankTrieMap.TrieNode[] links;
		}
	}
}
