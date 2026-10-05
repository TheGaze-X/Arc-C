using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.LocalTrack
{
	// Token: 0x0200207D RID: 8317
	[Token(Token = "0x200207D")]
	public class BuildingMusicTrigger : PlayerTrackTrigger
	{
		// Token: 0x0600CD2A RID: 52522 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600CD2A")]
		[Address(RVA = "0x34FB990", Offset = "0x34FA590", VA = "0x1834FB990", Slot = "4")]
		public override string GetDataID()
		{
			return null;
		}

		// Token: 0x0600CD2B RID: 52523 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CD2B")]
		[Address(RVA = "0x34FB9F0", Offset = "0x34FA5F0", VA = "0x1834FB9F0")]
		public BuildingMusicTrigger()
		{
		}

		// Token: 0x0400D86B RID: 55403
		[Token(Token = "0x400D86B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetDataID;

		// Token: 0x0400D86C RID: 55404
		[Token(Token = "0x400D86C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
