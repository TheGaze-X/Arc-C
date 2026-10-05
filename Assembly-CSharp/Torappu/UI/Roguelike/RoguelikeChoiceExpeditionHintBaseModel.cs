using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020051B6 RID: 20918
	[Token(Token = "0x20051B6")]
	public abstract class RoguelikeChoiceExpeditionHintBaseModel : RoguelikeChoiceHintModel<RoguelikeDefaultChoiceModel.Context>
	{
		// Token: 0x17004811 RID: 18449
		// (get) Token: 0x0601EE5A RID: 126554
		[Token(Token = "0x17004811")]
		protected abstract string expeditionHintFormat { [Token(Token = "0x601EE5A")] get; }

		// Token: 0x0601EE5B RID: 126555 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601EE5B")]
		[Address(RVA = "0x18A0690", Offset = "0x189F290", VA = "0x1818A0690", Slot = "5")]
		protected override string GetChoiceHint(RoguelikeDefaultChoiceModel.Context context)
		{
			return null;
		}

		// Token: 0x0601EE5C RID: 126556 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601EE5C")]
		[Address(RVA = "0x18A0890", Offset = "0x189F490", VA = "0x1818A0890")]
		private string _GenHintForExpedition()
		{
			return null;
		}

		// Token: 0x0601EE5D RID: 126557 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EE5D")]
		[Address(RVA = "0x18A0A30", Offset = "0x189F630", VA = "0x1818A0A30")]
		protected RoguelikeChoiceExpeditionHintBaseModel()
		{
		}

		// Token: 0x04029745 RID: 169797
		[Token(Token = "0x4029745")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetChoiceHint;

		// Token: 0x04029746 RID: 169798
		[Token(Token = "0x4029746")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__GenHintForExpedition;

		// Token: 0x04029747 RID: 169799
		[Token(Token = "0x4029747")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
