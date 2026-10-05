using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act24side
{
	// Token: 0x020075A3 RID: 30115
	[Token(Token = "0x20075A3")]
	public class Act24sideMeldingChoiceItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602A603 RID: 173571 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A603")]
		[Address(RVA = "0x2608EF0", Offset = "0x2607AF0", VA = "0x182608EF0")]
		public void Render(Act24sideMeldingChoiceItemViewModel viewModel)
		{
		}

		// Token: 0x0602A604 RID: 173572 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A604")]
		[Address(RVA = "0x2609720", Offset = "0x2608320", VA = "0x182609720")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602A605 RID: 173573 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A605")]
		[Address(RVA = "0x26094E0", Offset = "0x26080E0", VA = "0x1826094E0")]
		private void _EventOnMinusBtnClick()
		{
		}

		// Token: 0x0602A606 RID: 173574 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A606")]
		[Address(RVA = "0x26092A0", Offset = "0x2607EA0", VA = "0x1826092A0")]
		private void _EventOnAddBtnClick()
		{
		}

		// Token: 0x0602A607 RID: 173575 RVA: 0x000D82E8 File Offset: 0x000D64E8
		[Token(Token = "0x602A607")]
		[Address(RVA = "0x2609600", Offset = "0x2608200", VA = "0x182609600")]
		private bool _EventOnMinusBtnLongPress()
		{
			return default(bool);
		}

		// Token: 0x0602A608 RID: 173576 RVA: 0x000D8300 File Offset: 0x000D6500
		[Token(Token = "0x602A608")]
		[Address(RVA = "0x26093C0", Offset = "0x2607FC0", VA = "0x1826093C0")]
		private bool _EventOnAddBtnLongPress()
		{
			return default(bool);
		}

		// Token: 0x0602A609 RID: 173577 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A609")]
		[Address(RVA = "0x26099D0", Offset = "0x26085D0", VA = "0x1826099D0")]
		public Act24sideMeldingChoiceItemView()
		{
		}

		// Token: 0x0403CF72 RID: 249714
		[Token(Token = "0x403CF72")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform _container;

		// Token: 0x0403CF73 RID: 249715
		[Token(Token = "0x403CF73")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Act24sideMeldingItemView _itemViewPrefab;

		// Token: 0x0403CF74 RID: 249716
		[Token(Token = "0x403CF74")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _txtPrice;

		// Token: 0x0403CF75 RID: 249717
		[Token(Token = "0x403CF75")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _txtHasCount;

		// Token: 0x0403CF76 RID: 249718
		[Token(Token = "0x403CF76")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _txtUseCount;

		// Token: 0x0403CF77 RID: 249719
		[Token(Token = "0x403CF77")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private CanvasGroup _canvasUseDec;

		// Token: 0x0403CF78 RID: 249720
		[Token(Token = "0x403CF78")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _objLine;

		// Token: 0x0403CF79 RID: 249721
		[Token(Token = "0x403CF79")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private UILongPressButtonEx _btnAdd;

		// Token: 0x0403CF7A RID: 249722
		[Token(Token = "0x403CF7A")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private UILongPressButtonEx _btnMinus;

		// Token: 0x0403CF7B RID: 249723
		[Token(Token = "0x403CF7B")]
		[FieldOffset(Offset = "0x60")]
		private string m_cachedItemId;

		// Token: 0x0403CF7C RID: 249724
		[Token(Token = "0x403CF7C")]
		[FieldOffset(Offset = "0x68")]
		private Act24sideMeldingItemView m_itemView;

		// Token: 0x0403CF7D RID: 249725
		[Token(Token = "0x403CF7D")]
		[FieldOffset(Offset = "0x70")]
		private UIStateFinder m_finder;

		// Token: 0x0403CF7E RID: 249726
		[Token(Token = "0x403CF7E")]
		[FieldOffset(Offset = "0x80")]
		private FadeSwitchTween m_tweenCanUseDesc;

		// Token: 0x0403CF7F RID: 249727
		[Token(Token = "0x403CF7F")]
		[FieldOffset(Offset = "0x88")]
		private bool m_hasInited;

		// Token: 0x0403CF80 RID: 249728
		[Token(Token = "0x403CF80")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Color COL_HAS_COUNT_ZERO;

		// Token: 0x0403CF81 RID: 249729
		[Token(Token = "0x403CF81")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403CF82 RID: 249730
		[Token(Token = "0x403CF82")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403CF83 RID: 249731
		[Token(Token = "0x403CF83")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__EventOnMinusBtnClick;

		// Token: 0x0403CF84 RID: 249732
		[Token(Token = "0x403CF84")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__EventOnAddBtnClick;

		// Token: 0x0403CF85 RID: 249733
		[Token(Token = "0x403CF85")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__EventOnMinusBtnLongPress;

		// Token: 0x0403CF86 RID: 249734
		[Token(Token = "0x403CF86")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__EventOnAddBtnLongPress;

		// Token: 0x0403CF87 RID: 249735
		[Token(Token = "0x403CF87")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
