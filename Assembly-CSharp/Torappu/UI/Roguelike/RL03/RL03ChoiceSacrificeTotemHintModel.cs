using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike.RL03
{
	// Token: 0x0200580F RID: 22543
	[Token(Token = "0x200580F")]
	public class RL03ChoiceSacrificeTotemHintModel : RoguelikeChoiceHintModel<RoguelikeDefaultChoiceModel.Context>
	{
		// Token: 0x06020F2B RID: 134955 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020F2B")]
		[Address(RVA = "0x1B45AB0", Offset = "0x1B446B0", VA = "0x181B45AB0", Slot = "5")]
		protected override string GetChoiceHint(RoguelikeDefaultChoiceModel.Context context)
		{
			return null;
		}

		// Token: 0x06020F2C RID: 134956 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020F2C")]
		[Address(RVA = "0x1B45B40", Offset = "0x1B44740", VA = "0x181B45B40")]
		private string _GenHintForSacrificeTotem(string topicId)
		{
			return null;
		}

		// Token: 0x06020F2D RID: 134957 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020F2D")]
		[Address(RVA = "0x1B45D70", Offset = "0x1B44970", VA = "0x181B45D70")]
		public RL03ChoiceSacrificeTotemHintModel()
		{
		}

		// Token: 0x0402CCCA RID: 183498
		[Token(Token = "0x402CCCA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetChoiceHint;

		// Token: 0x0402CCCB RID: 183499
		[Token(Token = "0x402CCCB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__GenHintForSacrificeTotem;

		// Token: 0x0402CCCC RID: 183500
		[Token(Token = "0x402CCCC")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
