using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020000D0 RID: 208
	[Token(Token = "0x20000D0")]
	[CallbackIdentity(3411)]
	public struct StopPlaytimeTrackingResult_t
	{
		// Token: 0x0400027B RID: 635
		[Token(Token = "0x400027B")]
		public const int k_iCallback = 3411;

		// Token: 0x0400027C RID: 636
		[Token(Token = "0x400027C")]
		[FieldOffset(Offset = "0x0")]
		public EResult m_eResult;
	}
}
