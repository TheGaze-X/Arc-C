using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike.RL05
{
	// Token: 0x02005573 RID: 21875
	[Token(Token = "0x2005573")]
	public class RL05ChoiceCopperLuckHintModel : RoguelikeChoiceHintModel<RoguelikeDefaultChoiceModel.Context>
	{
		// Token: 0x06020264 RID: 131684 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020264")]
		[Address(RVA = "0x1A327F0", Offset = "0x1A313F0", VA = "0x181A327F0", Slot = "5")]
		protected override string GetChoiceHint(RoguelikeDefaultChoiceModel.Context context)
		{
			return null;
		}

		// Token: 0x06020265 RID: 131685 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020265")]
		[Address(RVA = "0x1A32880", Offset = "0x1A31480", VA = "0x181A32880")]
		private string _GenHintForCopperLuck(string topicId)
		{
			return null;
		}

		// Token: 0x06020266 RID: 131686 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020266")]
		[Address(RVA = "0x1A32BB0", Offset = "0x1A317B0", VA = "0x181A32BB0")]
		public RL05ChoiceCopperLuckHintModel()
		{
		}

		// Token: 0x0402B6D0 RID: 177872
		[Token(Token = "0x402B6D0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetChoiceHint;

		// Token: 0x0402B6D1 RID: 177873
		[Token(Token = "0x402B6D1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__GenHintForCopperLuck;

		// Token: 0x0402B6D2 RID: 177874
		[Token(Token = "0x402B6D2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
