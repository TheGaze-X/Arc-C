using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x0200002D RID: 45
	[Token(Token = "0x200002D")]
	[CallbackIdentity(1030)]
	public struct TimedTrialStatus_t
	{
		// Token: 0x04000010 RID: 16
		[Token(Token = "0x4000010")]
		public const int k_iCallback = 1030;

		// Token: 0x04000011 RID: 17
		[Token(Token = "0x4000011")]
		[FieldOffset(Offset = "0x0")]
		public AppId_t m_unAppID;

		// Token: 0x04000012 RID: 18
		[Token(Token = "0x4000012")]
		[FieldOffset(Offset = "0x4")]
		public bool m_bIsOffline;

		// Token: 0x04000013 RID: 19
		[Token(Token = "0x4000013")]
		[FieldOffset(Offset = "0x8")]
		public uint m_unSecondsAllowed;

		// Token: 0x04000014 RID: 20
		[Token(Token = "0x4000014")]
		[FieldOffset(Offset = "0xC")]
		public uint m_unSecondsPlayed;
	}
}
