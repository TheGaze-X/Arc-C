using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.AutoChess
{
	// Token: 0x0200710E RID: 28942
	[Token(Token = "0x200710E")]
	public class ActAutoChessHandbookBandDetailView : ActAutoChessHandbookDetailBaseView, IHotfixable
	{
		// Token: 0x060291FB RID: 168443 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60291FB")]
		[Address(RVA = "0x2482200", Offset = "0x2480E00", VA = "0x182482200", Slot = "8")]
		protected override void Render(ActAutoChessHandbookViewModel model)
		{
		}

		// Token: 0x060291FC RID: 168444 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60291FC")]
		[Address(RVA = "0x2482420", Offset = "0x2481020", VA = "0x182482420")]
		public ActAutoChessHandbookBandDetailView()
		{
		}

		// Token: 0x0403AB7A RID: 240506
		[Token(Token = "0x403AB7A")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _panelComplete;

		// Token: 0x0403AB7B RID: 240507
		[Token(Token = "0x403AB7B")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _panelVictor;

		// Token: 0x0403AB7C RID: 240508
		[Token(Token = "0x403AB7C")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _textVictor;

		// Token: 0x0403AB7D RID: 240509
		[Token(Token = "0x403AB7D")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _textName;

		// Token: 0x0403AB7E RID: 240510
		[Token(Token = "0x403AB7E")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _panelLocked;

		// Token: 0x0403AB7F RID: 240511
		[Token(Token = "0x403AB7F")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Image _imgIcon;

		// Token: 0x0403AB80 RID: 240512
		[Token(Token = "0x403AB80")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Text _textHp;

		// Token: 0x0403AB81 RID: 240513
		[Token(Token = "0x403AB81")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Text _textDesc;

		// Token: 0x0403AB82 RID: 240514
		[Token(Token = "0x403AB82")]
		[FieldOffset(Offset = "0x80")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0403AB83 RID: 240515
		[Token(Token = "0x403AB83")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403AB84 RID: 240516
		[Token(Token = "0x403AB84")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
