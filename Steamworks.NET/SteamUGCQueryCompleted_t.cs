using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020000C6 RID: 198
	[Token(Token = "0x20000C6")]
	[CallbackIdentity(3401)]
	public struct SteamUGCQueryCompleted_t
	{
		// Token: 0x17000014 RID: 20
		// (get) Token: 0x0600089B RID: 2203 RVA: 0x000020AE File Offset: 0x000002AE
		// (set) Token: 0x0600089C RID: 2204 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x17000014")]
		public string m_rgchNextCursor
		{
			[Token(Token = "0x600089B")]
			[Address(RVA = "0x4EE1D30", Offset = "0x4EE0930", VA = "0x184EE1D30")]
			get
			{
				return null;
			}
			[Token(Token = "0x600089C")]
			[Address(RVA = "0x4EE1DD0", Offset = "0x4EE09D0", VA = "0x184EE1DD0")]
			set
			{
			}
		}

		// Token: 0x04000250 RID: 592
		[Token(Token = "0x4000250")]
		public const int k_iCallback = 3401;

		// Token: 0x04000251 RID: 593
		[Token(Token = "0x4000251")]
		[FieldOffset(Offset = "0x0")]
		public UGCQueryHandle_t m_handle;

		// Token: 0x04000252 RID: 594
		[Token(Token = "0x4000252")]
		[FieldOffset(Offset = "0x8")]
		public EResult m_eResult;

		// Token: 0x04000253 RID: 595
		[Token(Token = "0x4000253")]
		[FieldOffset(Offset = "0xC")]
		public uint m_unNumResultsReturned;

		// Token: 0x04000254 RID: 596
		[Token(Token = "0x4000254")]
		[FieldOffset(Offset = "0x10")]
		public uint m_unTotalMatchingResults;

		// Token: 0x04000255 RID: 597
		[Token(Token = "0x4000255")]
		[FieldOffset(Offset = "0x14")]
		public bool m_bCachedData;

		// Token: 0x04000256 RID: 598
		[Token(Token = "0x4000256")]
		[FieldOffset(Offset = "0x18")]
		private byte[] m_rgchNextCursor_;
	}
}
