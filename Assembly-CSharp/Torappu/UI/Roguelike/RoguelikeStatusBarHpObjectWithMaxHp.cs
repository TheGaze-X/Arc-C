using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x02005313 RID: 21267
	[Token(Token = "0x2005313")]
	public class RoguelikeStatusBarHpObjectWithMaxHp : RoguelikeMenuObject<RoguelikeStatusBarHpWithMaxHpViewModel>
	{
		// Token: 0x0601F61C RID: 128540 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F61C")]
		[Address(RVA = "0x191AB90", Offset = "0x1919790", VA = "0x18191AB90")]
		private void _InitIfNot()
		{
		}

		// Token: 0x17004991 RID: 18833
		// (get) Token: 0x0601F61D RID: 128541 RVA: 0x000B1B58 File Offset: 0x000AFD58
		[Token(Token = "0x17004991")]
		public override RoguelikeMenuType menuType
		{
			[Token(Token = "0x601F61D")]
			[Address(RVA = "0x191B060", Offset = "0x1919C60", VA = "0x18191B060", Slot = "4")]
			get
			{
				return RoguelikeMenuType.INIT_SQUAD;
			}
		}

		// Token: 0x0601F61E RID: 128542 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F61E")]
		[Address(RVA = "0x191A940", Offset = "0x1919540", VA = "0x18191A940", Slot = "16")]
		public override void Render(RoguelikeStatusBarHpWithMaxHpViewModel viewModel)
		{
		}

		// Token: 0x0601F61F RID: 128543 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F61F")]
		[Address(RVA = "0x191AE00", Offset = "0x1919A00", VA = "0x18191AE00")]
		private void _RenderNormal(RoguelikeStatusBarHpWithMaxHpViewModel viewModel)
		{
		}

		// Token: 0x0601F620 RID: 128544 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F620")]
		[Address(RVA = "0x191AFD0", Offset = "0x1919BD0", VA = "0x18191AFD0")]
		public RoguelikeStatusBarHpObjectWithMaxHp()
		{
		}

		// Token: 0x0402A2CC RID: 172748
		[Token(Token = "0x402A2CC")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Color COLOR_INCREASE;

		// Token: 0x0402A2CD RID: 172749
		[Token(Token = "0x402A2CD")]
		[FieldOffset(Offset = "0x10")]
		private static readonly Color COLOR_DECREASE;

		// Token: 0x0402A2CE RID: 172750
		[Token(Token = "0x402A2CE")]
		[FieldOffset(Offset = "0x20")]
		private static readonly Color COLOR_NORMAL;

		// Token: 0x0402A2CF RID: 172751
		[Token(Token = "0x402A2CF")]
		[FieldOffset(Offset = "0x30")]
		private static readonly Color COLOR_SHIELD;

		// Token: 0x0402A2D0 RID: 172752
		[Token(Token = "0x402A2D0")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textHp;

		// Token: 0x0402A2D1 RID: 172753
		[Token(Token = "0x402A2D1")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textMaxHp;

		// Token: 0x0402A2D2 RID: 172754
		[Token(Token = "0x402A2D2")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _textShield;

		// Token: 0x0402A2D3 RID: 172755
		[Token(Token = "0x402A2D3")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _pnlShield;

		// Token: 0x0402A2D4 RID: 172756
		[Token(Token = "0x402A2D4")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Button _btnHpDetail;

		// Token: 0x0402A2D5 RID: 172757
		[Token(Token = "0x402A2D5")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _panelNormal;

		// Token: 0x0402A2D6 RID: 172758
		[Token(Token = "0x402A2D6")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _panelHidden;

		// Token: 0x0402A2D7 RID: 172759
		[Token(Token = "0x402A2D7")]
		[FieldOffset(Offset = "0x60")]
		private RoguelikeStatusBarTextTweener m_hpTweener;

		// Token: 0x0402A2D8 RID: 172760
		[Token(Token = "0x402A2D8")]
		[FieldOffset(Offset = "0x68")]
		private RoguelikeStatusBarTextTweener m_maxHpTweener;

		// Token: 0x0402A2D9 RID: 172761
		[Token(Token = "0x402A2D9")]
		[FieldOffset(Offset = "0x70")]
		private RoguelikeStatusBarTextTweener m_shieldTweener;

		// Token: 0x0402A2DA RID: 172762
		[Token(Token = "0x402A2DA")]
		[FieldOffset(Offset = "0x78")]
		private bool m_inited;

		// Token: 0x0402A2DB RID: 172763
		[Token(Token = "0x402A2DB")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402A2DC RID: 172764
		[Token(Token = "0x402A2DC")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_menuType;

		// Token: 0x0402A2DD RID: 172765
		[Token(Token = "0x402A2DD")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402A2DE RID: 172766
		[Token(Token = "0x402A2DE")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__RenderNormal;

		// Token: 0x0402A2DF RID: 172767
		[Token(Token = "0x402A2DF")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
