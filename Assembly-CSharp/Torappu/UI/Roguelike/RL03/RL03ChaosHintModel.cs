using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike.RL03
{
	// Token: 0x02005811 RID: 22545
	[Token(Token = "0x2005811")]
	public class RL03ChaosHintModel : RoguelikeChoiceHintModel<RoguelikeDefaultChoiceModel.Context>
	{
		// Token: 0x06020F31 RID: 134961 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020F31")]
		[Address(RVA = "0x1B451B0", Offset = "0x1B43DB0", VA = "0x181B451B0", Slot = "5")]
		protected override string GetChoiceHint(RoguelikeDefaultChoiceModel.Context context)
		{
			return null;
		}

		// Token: 0x06020F32 RID: 134962 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020F32")]
		[Address(RVA = "0x1B45240", Offset = "0x1B43E40", VA = "0x181B45240")]
		private string _GenHintForChaos(string topicId)
		{
			return null;
		}

		// Token: 0x06020F33 RID: 134963 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020F33")]
		[Address(RVA = "0x1B45510", Offset = "0x1B44110", VA = "0x181B45510")]
		public RL03ChaosHintModel()
		{
		}

		// Token: 0x0402CCD0 RID: 183504
		[Token(Token = "0x402CCD0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetChoiceHint;

		// Token: 0x0402CCD1 RID: 183505
		[Token(Token = "0x402CCD1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__GenHintForChaos;

		// Token: 0x0402CCD2 RID: 183506
		[Token(Token = "0x402CCD2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
