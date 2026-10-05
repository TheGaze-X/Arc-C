using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000070 RID: 112
	[Token(Token = "0x2000070")]
	[CallbackIdentity(2804)]
	public struct SteamInputGamepadSlotChange_t
	{
		// Token: 0x0400011B RID: 283
		[Token(Token = "0x400011B")]
		public const int k_iCallback = 2804;

		// Token: 0x0400011C RID: 284
		[Token(Token = "0x400011C")]
		[FieldOffset(Offset = "0x0")]
		public AppId_t m_unAppID;

		// Token: 0x0400011D RID: 285
		[Token(Token = "0x400011D")]
		[FieldOffset(Offset = "0x8")]
		public InputHandle_t m_ulDeviceHandle;

		// Token: 0x0400011E RID: 286
		[Token(Token = "0x400011E")]
		[FieldOffset(Offset = "0x10")]
		public ESteamInputType m_eDeviceType;

		// Token: 0x0400011F RID: 287
		[Token(Token = "0x400011F")]
		[FieldOffset(Offset = "0x14")]
		public int m_nOldGamepadSlot;

		// Token: 0x04000120 RID: 288
		[Token(Token = "0x4000120")]
		[FieldOffset(Offset = "0x18")]
		public int m_nNewGamepadSlot;
	}
}
