using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.AutoChess
{
	// Token: 0x02007115 RID: 28949
	[Token(Token = "0x2007115")]
	public class ActAutoChessHandbookBondDetailView : ActAutoChessHandbookDetailBaseView, IHotfixable
	{
		// Token: 0x0602920C RID: 168460 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602920C")]
		[Address(RVA = "0x2482FD0", Offset = "0x2481BD0", VA = "0x182482FD0", Slot = "8")]
		protected override void Render(ActAutoChessHandbookViewModel model)
		{
		}

		// Token: 0x0602920D RID: 168461 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602920D")]
		[Address(RVA = "0x24831E0", Offset = "0x2481DE0", VA = "0x1824831E0")]
		public ActAutoChessHandbookBondDetailView()
		{
		}

		// Token: 0x0403ABA5 RID: 240549
		[Token(Token = "0x403ABA5")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Image _imgIcon;

		// Token: 0x0403ABA6 RID: 240550
		[Token(Token = "0x403ABA6")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _textName;

		// Token: 0x0403ABA7 RID: 240551
		[Token(Token = "0x403ABA7")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _textActiveCount;

		// Token: 0x0403ABA8 RID: 240552
		[Token(Token = "0x403ABA8")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _textDesc;

		// Token: 0x0403ABA9 RID: 240553
		[Token(Token = "0x403ABA9")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private ActAutoChessHandbookBondDetailListAdapter _adapter;

		// Token: 0x0403ABAA RID: 240554
		[Token(Token = "0x403ABAA")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _panelCharList;

		// Token: 0x0403ABAB RID: 240555
		[Token(Token = "0x403ABAB")]
		[FieldOffset(Offset = "0x70")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0403ABAC RID: 240556
		[Token(Token = "0x403ABAC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403ABAD RID: 240557
		[Token(Token = "0x403ABAD")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
