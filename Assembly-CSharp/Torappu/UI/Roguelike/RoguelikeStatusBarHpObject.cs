using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x02005312 RID: 21266
	[Token(Token = "0x2005312")]
	public class RoguelikeStatusBarHpObject : RoguelikeMenuObject<RoguelikeMenuHpViewModel>
	{
		// Token: 0x0601F617 RID: 128535 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F617")]
		[Address(RVA = "0x191B390", Offset = "0x1919F90", VA = "0x18191B390")]
		private void _InitIfNot()
		{
		}

		// Token: 0x17004990 RID: 18832
		// (get) Token: 0x0601F618 RID: 128536 RVA: 0x000B1B40 File Offset: 0x000AFD40
		[Token(Token = "0x17004990")]
		public override RoguelikeMenuType menuType
		{
			[Token(Token = "0x601F618")]
			[Address(RVA = "0x191B610", Offset = "0x191A210", VA = "0x18191B610", Slot = "4")]
			get
			{
				return RoguelikeMenuType.INIT_SQUAD;
			}
		}

		// Token: 0x0601F619 RID: 128537 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F619")]
		[Address(RVA = "0x191B0D0", Offset = "0x1919CD0", VA = "0x18191B0D0", Slot = "16")]
		public override void Render(RoguelikeMenuHpViewModel viewModel)
		{
		}

		// Token: 0x0601F61A RID: 128538 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F61A")]
		[Address(RVA = "0x191B580", Offset = "0x191A180", VA = "0x18191B580")]
		public RoguelikeStatusBarHpObject()
		{
		}

		// Token: 0x0402A2BF RID: 172735
		[Token(Token = "0x402A2BF")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Color COLOR_INCREASE;

		// Token: 0x0402A2C0 RID: 172736
		[Token(Token = "0x402A2C0")]
		[FieldOffset(Offset = "0x10")]
		private static readonly Color COLOR_DECREASE;

		// Token: 0x0402A2C1 RID: 172737
		[Token(Token = "0x402A2C1")]
		[FieldOffset(Offset = "0x20")]
		private static readonly Color COLOR_NORMAL;

		// Token: 0x0402A2C2 RID: 172738
		[Token(Token = "0x402A2C2")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textHp;

		// Token: 0x0402A2C3 RID: 172739
		[Token(Token = "0x402A2C3")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textShieldHp;

		// Token: 0x0402A2C4 RID: 172740
		[Token(Token = "0x402A2C4")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Button _btnHpDetail;

		// Token: 0x0402A2C5 RID: 172741
		[Token(Token = "0x402A2C5")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _pnlShieldHp;

		// Token: 0x0402A2C6 RID: 172742
		[Token(Token = "0x402A2C6")]
		[FieldOffset(Offset = "0x48")]
		private RoguelikeStatusBarTextTweener m_hpTweener;

		// Token: 0x0402A2C7 RID: 172743
		[Token(Token = "0x402A2C7")]
		[FieldOffset(Offset = "0x50")]
		private bool m_inited;

		// Token: 0x0402A2C8 RID: 172744
		[Token(Token = "0x402A2C8")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402A2C9 RID: 172745
		[Token(Token = "0x402A2C9")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_menuType;

		// Token: 0x0402A2CA RID: 172746
		[Token(Token = "0x402A2CA")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402A2CB RID: 172747
		[Token(Token = "0x402A2CB")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
