using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike.RL05
{
	// Token: 0x02005571 RID: 21873
	[Token(Token = "0x2005571")]
	public class RL05ChoiceCandleHintModel : RoguelikeChoiceHintModel<RoguelikeDefaultChoiceModel.Context>
	{
		// Token: 0x0602025E RID: 131678 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602025E")]
		[Address(RVA = "0x1A31E70", Offset = "0x1A30A70", VA = "0x181A31E70", Slot = "5")]
		protected override string GetChoiceHint(RoguelikeDefaultChoiceModel.Context context)
		{
			return null;
		}

		// Token: 0x0602025F RID: 131679 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602025F")]
		[Address(RVA = "0x1A31F00", Offset = "0x1A30B00", VA = "0x181A31F00")]
		private string _GenHintForCandle(string topicId)
		{
			return null;
		}

		// Token: 0x06020260 RID: 131680 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020260")]
		[Address(RVA = "0x1A322C0", Offset = "0x1A30EC0", VA = "0x181A322C0")]
		public RL05ChoiceCandleHintModel()
		{
		}

		// Token: 0x0402B6CA RID: 177866
		[Token(Token = "0x402B6CA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetChoiceHint;

		// Token: 0x0402B6CB RID: 177867
		[Token(Token = "0x402B6CB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__GenHintForCandle;

		// Token: 0x0402B6CC RID: 177868
		[Token(Token = "0x402B6CC")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
