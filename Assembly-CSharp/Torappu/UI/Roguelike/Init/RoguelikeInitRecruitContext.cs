using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike.Init
{
	// Token: 0x020057EC RID: 22508
	[Token(Token = "0x20057EC")]
	public abstract class RoguelikeInitRecruitContext : RoguelikeInitStepContext
	{
		// Token: 0x17004D39 RID: 19769
		// (get) Token: 0x06020E92 RID: 134802
		[Token(Token = "0x17004D39")]
		public abstract List<RoguelikeInitRecruit.Model> list { [Token(Token = "0x6020E92")] get; }

		// Token: 0x06020E93 RID: 134803
		[Token(Token = "0x6020E93")]
		public abstract void OnSelect(int idx);

		// Token: 0x06020E94 RID: 134804 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020E94")]
		[Address(RVA = "0x1B3F480", Offset = "0x1B3E080", VA = "0x181B3F480")]
		public void Confirm()
		{
		}

		// Token: 0x06020E95 RID: 134805 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020E95")]
		[Address(RVA = "0x1B3F6D0", Offset = "0x1B3E2D0", VA = "0x181B3F6D0")]
		protected RoguelikeInitRecruitContext()
		{
		}

		// Token: 0x0402CBB7 RID: 183223
		[Token(Token = "0x402CBB7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Confirm;

		// Token: 0x0402CBB8 RID: 183224
		[Token(Token = "0x402CBB8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
