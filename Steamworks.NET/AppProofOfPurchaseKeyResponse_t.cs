using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x0200002B RID: 43
	[Token(Token = "0x200002B")]
	[CallbackIdentity(1021)]
	public struct AppProofOfPurchaseKeyResponse_t
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000875 RID: 2165 RVA: 0x000020AE File Offset: 0x000002AE
		// (set) Token: 0x06000876 RID: 2166 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x17000001")]
		public string m_rgchKey
		{
			[Token(Token = "0x6000875")]
			[Address(RVA = "0x4ED76A0", Offset = "0x4ED62A0", VA = "0x184ED76A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000876")]
			[Address(RVA = "0x4ED7740", Offset = "0x4ED6340", VA = "0x184ED7740")]
			set
			{
			}
		}

		// Token: 0x04000006 RID: 6
		[Token(Token = "0x4000006")]
		public const int k_iCallback = 1021;

		// Token: 0x04000007 RID: 7
		[Token(Token = "0x4000007")]
		[FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		// Token: 0x04000008 RID: 8
		[Token(Token = "0x4000008")]
		[FieldOffset(Offset = "0x4")]
		public uint m_nAppID;

		// Token: 0x04000009 RID: 9
		[Token(Token = "0x4000009")]
		[FieldOffset(Offset = "0x8")]
		public uint m_cchKeyLength;

		// Token: 0x0400000A RID: 10
		[Token(Token = "0x400000A")]
		[FieldOffset(Offset = "0x10")]
		private byte[] m_rgchKey_;
	}
}
