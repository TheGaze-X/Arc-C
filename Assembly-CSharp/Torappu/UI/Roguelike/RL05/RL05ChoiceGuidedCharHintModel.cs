using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike.RL05
{
	// Token: 0x02005574 RID: 21876
	[Token(Token = "0x2005574")]
	public class RL05ChoiceGuidedCharHintModel : RoguelikeChoiceHintModel<RoguelikeDefaultChoiceModel.Context>
	{
		// Token: 0x06020267 RID: 131687 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020267")]
		[Address(RVA = "0x1A32C20", Offset = "0x1A31820", VA = "0x181A32C20", Slot = "5")]
		protected override string GetChoiceHint(RoguelikeDefaultChoiceModel.Context context)
		{
			return null;
		}

		// Token: 0x06020268 RID: 131688 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020268")]
		[Address(RVA = "0x1A32C90", Offset = "0x1A31890", VA = "0x181A32C90")]
		private string _GenHintForGuidedChar()
		{
			return null;
		}

		// Token: 0x06020269 RID: 131689 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020269")]
		[Address(RVA = "0x1A32EE0", Offset = "0x1A31AE0", VA = "0x181A32EE0")]
		public RL05ChoiceGuidedCharHintModel()
		{
		}

		// Token: 0x0402B6D3 RID: 177875
		[Token(Token = "0x402B6D3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetChoiceHint;

		// Token: 0x0402B6D4 RID: 177876
		[Token(Token = "0x402B6D4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__GenHintForGuidedChar;

		// Token: 0x0402B6D5 RID: 177877
		[Token(Token = "0x402B6D5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
