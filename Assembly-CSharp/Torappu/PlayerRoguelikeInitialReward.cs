using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000AAB RID: 2731
	[Token(Token = "0x2000AAB")]
	public class PlayerRoguelikeInitialReward
	{
		// Token: 0x06006769 RID: 26473 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006769")]
		[Address(RVA = "0x1EFCA30", Offset = "0x1EFB630", VA = "0x181EFCA30")]
		public PlayerRoguelikeInitialReward()
		{
		}

		// Token: 0x0400398F RID: 14735
		[Token(Token = "0x400398F")]
		[FieldOffset(Offset = "0x10")]
		public RoguelikeReward relic;

		// Token: 0x04003990 RID: 14736
		[Token(Token = "0x4003990")]
		[FieldOffset(Offset = "0x18")]
		public PlayerRoguelikePendingEvent.SceneContent scene;

		// Token: 0x04003991 RID: 14737
		[Token(Token = "0x4003991")]
		[FieldOffset(Offset = "0x20")]
		public RoguelikeReward recruit;
	}
}
