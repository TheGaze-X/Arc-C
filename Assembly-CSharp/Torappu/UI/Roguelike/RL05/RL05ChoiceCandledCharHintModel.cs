using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike.RL05
{
	// Token: 0x02005572 RID: 21874
	[Token(Token = "0x2005572")]
	public class RL05ChoiceCandledCharHintModel : RoguelikeChoiceHintModel<RoguelikeDefaultChoiceModel.Context>
	{
		// Token: 0x06020261 RID: 131681 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020261")]
		[Address(RVA = "0x1A32330", Offset = "0x1A30F30", VA = "0x181A32330", Slot = "5")]
		protected override string GetChoiceHint(RoguelikeDefaultChoiceModel.Context context)
		{
			return null;
		}

		// Token: 0x06020262 RID: 131682 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020262")]
		[Address(RVA = "0x1A323C0", Offset = "0x1A30FC0", VA = "0x181A323C0")]
		private string _GenHintForCandledChar(string topicId)
		{
			return null;
		}

		// Token: 0x06020263 RID: 131683 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020263")]
		[Address(RVA = "0x1A32780", Offset = "0x1A31380", VA = "0x181A32780")]
		public RL05ChoiceCandledCharHintModel()
		{
		}

		// Token: 0x0402B6CD RID: 177869
		[Token(Token = "0x402B6CD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetChoiceHint;

		// Token: 0x0402B6CE RID: 177870
		[Token(Token = "0x402B6CE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__GenHintForCandledChar;

		// Token: 0x0402B6CF RID: 177871
		[Token(Token = "0x402B6CF")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
