using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020000F5 RID: 245
	[Token(Token = "0x20000F5")]
	[CallbackIdentity(702)]
	public struct LowBatteryPower_t
	{
		// Token: 0x04000302 RID: 770
		[Token(Token = "0x4000302")]
		public const int k_iCallback = 702;

		// Token: 0x04000303 RID: 771
		[Token(Token = "0x4000303")]
		[FieldOffset(Offset = "0x0")]
		public byte m_nMinutesBatteryLeft;
	}
}
