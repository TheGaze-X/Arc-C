using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.TemplateCharSelect.Common
{
	// Token: 0x02005C1B RID: 23579
	[Token(Token = "0x2005C1B")]
	public class CommonCharSelectShuffleView : TemplateCharSelectShuffleViewBase<CommonCharSelectShuffleViewModel>
	{
		// Token: 0x060222FB RID: 140027 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60222FB")]
		[Address(RVA = "0x1CB1340", Offset = "0x1CAFF40", VA = "0x181CB1340")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060222FC RID: 140028 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60222FC")]
		[Address(RVA = "0x1CB10D0", Offset = "0x1CAFCD0", VA = "0x181CB10D0", Slot = "11")]
		protected override void OnRenderViewModel(TemplateCharSelectMainViewModel mainViewModel)
		{
		}

		// Token: 0x060222FD RID: 140029 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60222FD")]
		[Address(RVA = "0x1CB0FA0", Offset = "0x1CAFBA0", VA = "0x181CB0FA0")]
		public void OnChangeProfShuffleView(ProfessionCategory prof)
		{
		}

		// Token: 0x060222FE RID: 140030 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60222FE")]
		[Address(RVA = "0x1CB0C50", Offset = "0x1CAF850", VA = "0x181CB0C50")]
		public void EventOnFilterAll()
		{
		}

		// Token: 0x060222FF RID: 140031 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60222FF")]
		[Address(RVA = "0x1CB0DC0", Offset = "0x1CAF9C0", VA = "0x181CB0DC0")]
		public void EventOnOpenFilter()
		{
		}

		// Token: 0x06022300 RID: 140032 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022300")]
		[Address(RVA = "0x1CB0B90", Offset = "0x1CAF790", VA = "0x181CB0B90")]
		public void EventOnCloseFilter()
		{
		}

		// Token: 0x06022301 RID: 140033 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022301")]
		[Address(RVA = "0x1CB0E80", Offset = "0x1CAFA80", VA = "0x181CB0E80")]
		public void EventOnSort(CharacterSortType sortType)
		{
		}

		// Token: 0x06022302 RID: 140034 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022302")]
		[Address(RVA = "0x1CB1570", Offset = "0x1CB0170", VA = "0x181CB1570")]
		public CommonCharSelectShuffleView()
		{
		}

		// Token: 0x0402EE39 RID: 192057
		[Token(Token = "0x402EE39")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _filterProfHideGo;

		// Token: 0x0402EE3A RID: 192058
		[Token(Token = "0x402EE3A")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _filterProfShowGo;

		// Token: 0x0402EE3B RID: 192059
		[Token(Token = "0x402EE3B")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _filterProfDetailPartGo;

		// Token: 0x0402EE3C RID: 192060
		[Token(Token = "0x402EE3C")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _filterProfNonePartGo;

		// Token: 0x0402EE3D RID: 192061
		[Token(Token = "0x402EE3D")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _textFilterProfDetail;

		// Token: 0x0402EE3E RID: 192062
		[Token(Token = "0x402EE3E")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private CanvasGroup _professionFilterAlphaHandler;

		// Token: 0x0402EE3F RID: 192063
		[Token(Token = "0x402EE3F")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private float _professionFilterSwitchDuration;

		// Token: 0x0402EE40 RID: 192064
		[Token(Token = "0x402EE40")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private SimpleLayoutContent _professionFilterList;

		// Token: 0x0402EE41 RID: 192065
		[Token(Token = "0x402EE41")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Text _textProfessionAll;

		// Token: 0x0402EE42 RID: 192066
		[Token(Token = "0x402EE42")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Color _colorFilterAllUnselect;

		// Token: 0x0402EE43 RID: 192067
		[Token(Token = "0x402EE43")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Color _colorFilterAllSelect;

		// Token: 0x0402EE44 RID: 192068
		[Token(Token = "0x402EE44")]
		[FieldOffset(Offset = "0x98")]
		private FadeSwitchTween m_professionFilterSwitchTween;

		// Token: 0x0402EE45 RID: 192069
		[Token(Token = "0x402EE45")]
		[FieldOffset(Offset = "0xA0")]
		private TemplateCharSelectShuffleProfessionListAdapter m_charSelectShuffleProfessionListAdapter;

		// Token: 0x0402EE46 RID: 192070
		[Token(Token = "0x402EE46")]
		[FieldOffset(Offset = "0xA8")]
		private bool m_hasInited;

		// Token: 0x0402EE47 RID: 192071
		[Token(Token = "0x402EE47")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402EE48 RID: 192072
		[Token(Token = "0x402EE48")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnRenderViewModel;

		// Token: 0x0402EE49 RID: 192073
		[Token(Token = "0x402EE49")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnChangeProfShuffleView;

		// Token: 0x0402EE4A RID: 192074
		[Token(Token = "0x402EE4A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventOnFilterAll;

		// Token: 0x0402EE4B RID: 192075
		[Token(Token = "0x402EE4B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_EventOnOpenFilter;

		// Token: 0x0402EE4C RID: 192076
		[Token(Token = "0x402EE4C")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_EventOnCloseFilter;

		// Token: 0x0402EE4D RID: 192077
		[Token(Token = "0x402EE4D")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_EventOnSort;

		// Token: 0x0402EE4E RID: 192078
		[Token(Token = "0x402EE4E")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
