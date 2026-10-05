using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike.RL03
{
	// Token: 0x02005812 RID: 22546
	[Token(Token = "0x2005812")]
	public class RL03ItemHintModel : RoguelikeChoiceItemHintModel
	{
		// Token: 0x06020F34 RID: 134964 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020F34")]
		[Address(RVA = "0x1B485E0", Offset = "0x1B471E0", VA = "0x181B485E0", Slot = "5")]
		protected override string GetChoiceHint(RoguelikeItemChoiceModel.Context context)
		{
			return null;
		}

		// Token: 0x06020F35 RID: 134965 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020F35")]
		[Address(RVA = "0x1B48930", Offset = "0x1B47530", VA = "0x181B48930")]
		public RL03ItemHintModel()
		{
		}

		// Token: 0x06020F36 RID: 134966 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020F36")]
		[Address(RVA = "0x1B48920", Offset = "0x1B47520", VA = "0x181B48920")]
		private string <>xLuaBaseProxy_GetChoiceHint(RoguelikeItemChoiceModel.Context P0)
		{
			return null;
		}

		// Token: 0x0402CCD3 RID: 183507
		[Token(Token = "0x402CCD3")]
		[FieldOffset(Offset = "0x10")]
		private List<RL03TotemViewModel> m_cachedTotemModels;

		// Token: 0x0402CCD4 RID: 183508
		[Token(Token = "0x402CCD4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetChoiceHint;

		// Token: 0x0402CCD5 RID: 183509
		[Token(Token = "0x402CCD5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
