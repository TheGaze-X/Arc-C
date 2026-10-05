using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x02005311 RID: 21265
	[Token(Token = "0x2005311")]
	public class RoguelikeStatusBarGoldObject : RoguelikeMenuObject<RoguelikeMenuGoldViewModel>
	{
		// Token: 0x0601F612 RID: 128530 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F612")]
		[Address(RVA = "0x191A650", Offset = "0x1919250", VA = "0x18191A650")]
		private void _InitIfNot()
		{
		}

		// Token: 0x1700498F RID: 18831
		// (get) Token: 0x0601F613 RID: 128531 RVA: 0x000B1B28 File Offset: 0x000AFD28
		[Token(Token = "0x1700498F")]
		public override RoguelikeMenuType menuType
		{
			[Token(Token = "0x601F613")]
			[Address(RVA = "0x191A8D0", Offset = "0x19194D0", VA = "0x18191A8D0", Slot = "4")]
			get
			{
				return RoguelikeMenuType.INIT_SQUAD;
			}
		}

		// Token: 0x0601F614 RID: 128532 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F614")]
		[Address(RVA = "0x191A3F0", Offset = "0x1918FF0", VA = "0x18191A3F0", Slot = "16")]
		public override void Render(RoguelikeMenuGoldViewModel viewModel)
		{
		}

		// Token: 0x0601F615 RID: 128533 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F615")]
		[Address(RVA = "0x191A840", Offset = "0x1919440", VA = "0x18191A840")]
		public RoguelikeStatusBarGoldObject()
		{
		}

		// Token: 0x0402A2B4 RID: 172724
		[Token(Token = "0x402A2B4")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Color COLOR_INCREASE;

		// Token: 0x0402A2B5 RID: 172725
		[Token(Token = "0x402A2B5")]
		[FieldOffset(Offset = "0x10")]
		private static readonly Color COLOR_DECREASE;

		// Token: 0x0402A2B6 RID: 172726
		[Token(Token = "0x402A2B6")]
		[FieldOffset(Offset = "0x20")]
		private static readonly Color COLOR_NORMAL;

		// Token: 0x0402A2B7 RID: 172727
		[Token(Token = "0x402A2B7")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textGold;

		// Token: 0x0402A2B8 RID: 172728
		[Token(Token = "0x402A2B8")]
		[FieldOffset(Offset = "0x30")]
		private RoguelikeStatusBarTextTweener m_goldTweener;

		// Token: 0x0402A2B9 RID: 172729
		[Token(Token = "0x402A2B9")]
		[FieldOffset(Offset = "0x38")]
		private int m_cachedGold;

		// Token: 0x0402A2BA RID: 172730
		[Token(Token = "0x402A2BA")]
		[FieldOffset(Offset = "0x3C")]
		private bool m_inited;

		// Token: 0x0402A2BB RID: 172731
		[Token(Token = "0x402A2BB")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402A2BC RID: 172732
		[Token(Token = "0x402A2BC")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_menuType;

		// Token: 0x0402A2BD RID: 172733
		[Token(Token = "0x402A2BD")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402A2BE RID: 172734
		[Token(Token = "0x402A2BE")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
