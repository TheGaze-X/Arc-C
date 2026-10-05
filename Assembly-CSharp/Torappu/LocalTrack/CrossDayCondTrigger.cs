using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.LocalTrack
{
	// Token: 0x0200207F RID: 8319
	[Token(Token = "0x200207F")]
	public class CrossDayCondTrigger : TrackTrigger, ITrackWithTypeVersion
	{
		// Token: 0x0600CD30 RID: 52528 RVA: 0x00049F68 File Offset: 0x00048168
		[Token(Token = "0x600CD30")]
		[Address(RVA = "0x34FD1B0", Offset = "0x34FBDB0", VA = "0x1834FD1B0", Slot = "4")]
		public long GetTypeVersion()
		{
			return 0L;
		}

		// Token: 0x0600CD31 RID: 52529 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CD31")]
		[Address(RVA = "0x34FD210", Offset = "0x34FBE10", VA = "0x1834FD210")]
		public CrossDayCondTrigger()
		{
		}

		// Token: 0x0400D871 RID: 55409
		[Token(Token = "0x400D871")]
		[FieldOffset(Offset = "0x20")]
		public long updateEndTs;

		// Token: 0x0400D872 RID: 55410
		[Token(Token = "0x400D872")]
		[FieldOffset(Offset = "0x28")]
		public long lastUpdateTs;

		// Token: 0x0400D873 RID: 55411
		[Token(Token = "0x400D873")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetTypeVersion;

		// Token: 0x0400D874 RID: 55412
		[Token(Token = "0x400D874")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
