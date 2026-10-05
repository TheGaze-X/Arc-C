using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020000CF RID: 207
	[Token(Token = "0x20000CF")]
	[CallbackIdentity(3410)]
	public struct StartPlaytimeTrackingResult_t
	{
		// Token: 0x04000279 RID: 633
		[Token(Token = "0x4000279")]
		public const int k_iCallback = 3410;

		// Token: 0x0400027A RID: 634
		[Token(Token = "0x400027A")]
		[FieldOffset(Offset = "0x0")]
		public EResult m_eResult;
	}
}
