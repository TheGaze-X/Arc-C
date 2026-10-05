using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x02005314 RID: 21268
	[Token(Token = "0x2005314")]
	public class RoguelikeStatusBarKeyObject : RoguelikeMenuObject<RoguelikeMenuKeyViewModel>
	{
		// Token: 0x0601F622 RID: 128546 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F622")]
		[Address(RVA = "0x191BFD0", Offset = "0x191ABD0", VA = "0x18191BFD0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x17004992 RID: 18834
		// (get) Token: 0x0601F623 RID: 128547 RVA: 0x000B1B70 File Offset: 0x000AFD70
		[Token(Token = "0x17004992")]
		public override RoguelikeMenuType menuType
		{
			[Token(Token = "0x601F623")]
			[Address(RVA = "0x191C250", Offset = "0x191AE50", VA = "0x18191C250", Slot = "4")]
			get
			{
				return RoguelikeMenuType.INIT_SQUAD;
			}
		}

		// Token: 0x0601F624 RID: 128548 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F624")]
		[Address(RVA = "0x191BDC0", Offset = "0x191A9C0", VA = "0x18191BDC0", Slot = "16")]
		public override void Render(RoguelikeMenuKeyViewModel viewModel)
		{
		}

		// Token: 0x0601F625 RID: 128549 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F625")]
		[Address(RVA = "0x191C1C0", Offset = "0x191ADC0", VA = "0x18191C1C0")]
		public RoguelikeStatusBarKeyObject()
		{
		}

		// Token: 0x0402A2E0 RID: 172768
		[Token(Token = "0x402A2E0")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Color COLOR_INCREASE;

		// Token: 0x0402A2E1 RID: 172769
		[Token(Token = "0x402A2E1")]
		[FieldOffset(Offset = "0x10")]
		private static readonly Color COLOR_DECREASE;

		// Token: 0x0402A2E2 RID: 172770
		[Token(Token = "0x402A2E2")]
		[FieldOffset(Offset = "0x20")]
		private static readonly Color COLOR_NORMAL;

		// Token: 0x0402A2E3 RID: 172771
		[Token(Token = "0x402A2E3")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textKey;

		// Token: 0x0402A2E4 RID: 172772
		[Token(Token = "0x402A2E4")]
		[FieldOffset(Offset = "0x30")]
		private RoguelikeStatusBarTextTweener m_keyTweener;

		// Token: 0x0402A2E5 RID: 172773
		[Token(Token = "0x402A2E5")]
		[FieldOffset(Offset = "0x38")]
		private bool m_inited;

		// Token: 0x0402A2E6 RID: 172774
		[Token(Token = "0x402A2E6")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402A2E7 RID: 172775
		[Token(Token = "0x402A2E7")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_menuType;

		// Token: 0x0402A2E8 RID: 172776
		[Token(Token = "0x402A2E8")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402A2E9 RID: 172777
		[Token(Token = "0x402A2E9")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
