using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.LocalTrack
{
	// Token: 0x02002098 RID: 8344
	[Token(Token = "0x2002098")]
	public class StageCondTrigger : PlayerTrackTrigger
	{
		// Token: 0x0600CD7B RID: 52603 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600CD7B")]
		[Address(RVA = "0x3504D20", Offset = "0x3503920", VA = "0x183504D20", Slot = "4")]
		public override string GetDataID()
		{
			return null;
		}

		// Token: 0x0600CD7C RID: 52604 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CD7C")]
		[Address(RVA = "0x3504D80", Offset = "0x3503980", VA = "0x183504D80")]
		public StageCondTrigger()
		{
		}

		// Token: 0x0400D8C7 RID: 55495
		[Token(Token = "0x400D8C7")]
		[FieldOffset(Offset = "0x20")]
		public string stageId;

		// Token: 0x0400D8C8 RID: 55496
		[Token(Token = "0x400D8C8")]
		[FieldOffset(Offset = "0x28")]
		public PlayerStageState rank;

		// Token: 0x0400D8C9 RID: 55497
		[Token(Token = "0x400D8C9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetDataID;

		// Token: 0x0400D8CA RID: 55498
		[Token(Token = "0x400D8CA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
