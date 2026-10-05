using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020051B7 RID: 20919
	[Token(Token = "0x20051B7")]
	public class RoguelikeChoiceSacrificeHintModel : RoguelikeChoiceHintModel<RoguelikeDefaultChoiceModel.Context>
	{
		// Token: 0x0601EE5E RID: 126558 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601EE5E")]
		[Address(RVA = "0x18A3860", Offset = "0x18A2460", VA = "0x1818A3860", Slot = "5")]
		protected override string GetChoiceHint(RoguelikeDefaultChoiceModel.Context context)
		{
			return null;
		}

		// Token: 0x0601EE5F RID: 126559 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601EE5F")]
		[Address(RVA = "0x18A3950", Offset = "0x18A2550", VA = "0x1818A3950")]
		private string _GenHintForSacrifice(string topicId)
		{
			return null;
		}

		// Token: 0x0601EE60 RID: 126560 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EE60")]
		[Address(RVA = "0x18A3C10", Offset = "0x18A2810", VA = "0x1818A3C10")]
		public RoguelikeChoiceSacrificeHintModel()
		{
		}

		// Token: 0x04029748 RID: 169800
		[Token(Token = "0x4029748")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetChoiceHint;

		// Token: 0x04029749 RID: 169801
		[Token(Token = "0x4029749")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__GenHintForSacrifice;

		// Token: 0x0402974A RID: 169802
		[Token(Token = "0x402974A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
