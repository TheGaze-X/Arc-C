using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike.RL03
{
	// Token: 0x02005810 RID: 22544
	[Token(Token = "0x2005810")]
	public class RL03VisionHintModel : RoguelikeChoiceHintModel<RoguelikeDefaultChoiceModel.Context>
	{
		// Token: 0x06020F2E RID: 134958 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020F2E")]
		[Address(RVA = "0x1B587A0", Offset = "0x1B573A0", VA = "0x181B587A0", Slot = "5")]
		protected override string GetChoiceHint(RoguelikeDefaultChoiceModel.Context context)
		{
			return null;
		}

		// Token: 0x06020F2F RID: 134959 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020F2F")]
		[Address(RVA = "0x1B58960", Offset = "0x1B57560", VA = "0x181B58960")]
		private string _GenHintForVision()
		{
			return null;
		}

		// Token: 0x06020F30 RID: 134960 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020F30")]
		[Address(RVA = "0x1B58AD0", Offset = "0x1B576D0", VA = "0x181B58AD0")]
		public RL03VisionHintModel()
		{
		}

		// Token: 0x0402CCCD RID: 183501
		[Token(Token = "0x402CCCD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetChoiceHint;

		// Token: 0x0402CCCE RID: 183502
		[Token(Token = "0x402CCCE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__GenHintForVision;

		// Token: 0x0402CCCF RID: 183503
		[Token(Token = "0x402CCCF")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
