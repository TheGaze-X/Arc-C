using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x02005316 RID: 21270
	[Token(Token = "0x2005316")]
	public class RoguelikeStatusBarPopulationObject : RoguelikeMenuObject<RoguelikeMenuPopulationViewModel>
	{
		// Token: 0x17004994 RID: 18836
		// (get) Token: 0x0601F62A RID: 128554 RVA: 0x000B1BA0 File Offset: 0x000AFDA0
		[Token(Token = "0x17004994")]
		public override RoguelikeMenuType menuType
		{
			[Token(Token = "0x601F62A")]
			[Address(RVA = "0x191CD80", Offset = "0x191B980", VA = "0x18191CD80", Slot = "4")]
			get
			{
				return RoguelikeMenuType.INIT_SQUAD;
			}
		}

		// Token: 0x0601F62B RID: 128555 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F62B")]
		[Address(RVA = "0x191CC10", Offset = "0x191B810", VA = "0x18191CC10", Slot = "16")]
		public override void Render(RoguelikeMenuPopulationViewModel viewModel)
		{
		}

		// Token: 0x0601F62C RID: 128556 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F62C")]
		[Address(RVA = "0x191CD10", Offset = "0x191B910", VA = "0x18191CD10")]
		public RoguelikeStatusBarPopulationObject()
		{
		}

		// Token: 0x0402A2F2 RID: 172786
		[Token(Token = "0x402A2F2")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RoguelikePopBarView _popBarView;

		// Token: 0x0402A2F3 RID: 172787
		[Token(Token = "0x402A2F3")]
		[FieldOffset(Offset = "0x30")]
		private RoguelikeMenuPopulationViewModel m_cachedModel;

		// Token: 0x0402A2F4 RID: 172788
		[Token(Token = "0x402A2F4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_menuType;

		// Token: 0x0402A2F5 RID: 172789
		[Token(Token = "0x402A2F5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402A2F6 RID: 172790
		[Token(Token = "0x402A2F6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
