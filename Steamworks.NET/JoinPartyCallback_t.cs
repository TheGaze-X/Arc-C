using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000089 RID: 137
	[Token(Token = "0x2000089")]
	[CallbackIdentity(5301)]
	public struct JoinPartyCallback_t
	{
		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000885 RID: 2181 RVA: 0x000020AE File Offset: 0x000002AE
		// (set) Token: 0x06000886 RID: 2182 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x17000009")]
		public string m_rgchConnectString
		{
			[Token(Token = "0x6000885")]
			[Address(RVA = "0x4EE1D30", Offset = "0x4EE0930", VA = "0x184EE1D30")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000886")]
			[Address(RVA = "0x4EE1DD0", Offset = "0x4EE09D0", VA = "0x184EE1DD0")]
			set
			{
			}
		}

		// Token: 0x04000189 RID: 393
		[Token(Token = "0x4000189")]
		public const int k_iCallback = 5301;

		// Token: 0x0400018A RID: 394
		[Token(Token = "0x400018A")]
		[FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		// Token: 0x0400018B RID: 395
		[Token(Token = "0x400018B")]
		[FieldOffset(Offset = "0x8")]
		public PartyBeaconID_t m_ulBeaconID;

		// Token: 0x0400018C RID: 396
		[Token(Token = "0x400018C")]
		[FieldOffset(Offset = "0x10")]
		public CSteamID m_SteamIDBeaconOwner;

		// Token: 0x0400018D RID: 397
		[Token(Token = "0x400018D")]
		[FieldOffset(Offset = "0x18")]
		private byte[] m_rgchConnectString_;
	}
}
