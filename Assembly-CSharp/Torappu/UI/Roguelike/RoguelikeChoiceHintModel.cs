using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020051AE RID: 20910
	[Token(Token = "0x20051AE")]
	public abstract class RoguelikeChoiceHintModel<TContext> : IRoguelikeChoiceHintModel, IHotfixable where TContext : class, IRoguelikeChoiceHintContext
	{
		// Token: 0x0601EE2A RID: 126506 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601EE2A")]
		public string DoGetChoiceHint(IRoguelikeChoiceHintContext context)
		{
			return null;
		}

		// Token: 0x0601EE2B RID: 126507
		[Token(Token = "0x601EE2B")]
		protected abstract string GetChoiceHint(TContext context);

		// Token: 0x0601EE2C RID: 126508 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EE2C")]
		protected RoguelikeChoiceHintModel()
		{
		}

		// Token: 0x040296E8 RID: 169704
		[Token(Token = "0x40296E8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_DoGetChoiceHint;

		// Token: 0x040296E9 RID: 169705
		[Token(Token = "0x40296E9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
