using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.LocalTrack
{
	// Token: 0x02002079 RID: 8313
	[Token(Token = "0x2002079")]
	public class CarCondTrigger : PlayerTrackTrigger
	{
		// Token: 0x0600CD1E RID: 52510 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600CD1E")]
		[Address(RVA = "0x34FBD60", Offset = "0x34FA960", VA = "0x1834FBD60", Slot = "4")]
		public override string GetDataID()
		{
			return null;
		}

		// Token: 0x0600CD1F RID: 52511 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CD1F")]
		[Address(RVA = "0x34FBDC0", Offset = "0x34FA9C0", VA = "0x1834FBDC0")]
		public CarCondTrigger()
		{
		}

		// Token: 0x0400D85E RID: 55390
		[Token(Token = "0x400D85E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetDataID;

		// Token: 0x0400D85F RID: 55391
		[Token(Token = "0x400D85F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
