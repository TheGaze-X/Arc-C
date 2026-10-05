using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike.RL04
{
	// Token: 0x0200568E RID: 22158
	[Token(Token = "0x200568E")]
	public class RL04ChoiceFragmentHintModel : RoguelikeChoiceHintModel<RoguelikeDefaultChoiceModel.Context>
	{
		// Token: 0x0602081F RID: 133151 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602081F")]
		[Address(RVA = "0x1AA4440", Offset = "0x1AA3040", VA = "0x181AA4440", Slot = "5")]
		protected override string GetChoiceHint(RoguelikeDefaultChoiceModel.Context context)
		{
			return null;
		}

		// Token: 0x06020820 RID: 133152 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020820")]
		[Address(RVA = "0x1AA44D0", Offset = "0x1AA30D0", VA = "0x181AA44D0")]
		private string _GenHintForFragment(string topicId)
		{
			return null;
		}

		// Token: 0x06020821 RID: 133153 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020821")]
		[Address(RVA = "0x1AA4690", Offset = "0x1AA3290", VA = "0x181AA4690")]
		public RL04ChoiceFragmentHintModel()
		{
		}

		// Token: 0x0402C0D6 RID: 180438
		[Token(Token = "0x402C0D6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetChoiceHint;

		// Token: 0x0402C0D7 RID: 180439
		[Token(Token = "0x402C0D7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__GenHintForFragment;

		// Token: 0x0402C0D8 RID: 180440
		[Token(Token = "0x402C0D8")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
