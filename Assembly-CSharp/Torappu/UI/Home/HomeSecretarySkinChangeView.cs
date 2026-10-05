using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Home
{
	// Token: 0x02004C1D RID: 19485
	[Token(Token = "0x2004C1D")]
	public class HomeSecretarySkinChangeView : DataBinder<HomeSecretarySkinChangeViewProperty>
	{
		// Token: 0x0601D436 RID: 119862 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D436")]
		[Address(RVA = "0x16D7390", Offset = "0x16D5F90", VA = "0x1816D7390", Slot = "7")]
		public override void OnValueChanged(HomeSecretarySkinChangeViewProperty property)
		{
		}

		// Token: 0x0601D437 RID: 119863 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D437")]
		[Address(RVA = "0x16D7270", Offset = "0x16D5E70", VA = "0x1816D7270")]
		public void OnConfirmClicked()
		{
		}

		// Token: 0x0601D438 RID: 119864 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D438")]
		[Address(RVA = "0x16D7150", Offset = "0x16D5D50", VA = "0x1816D7150")]
		public void OnCancelClicked()
		{
		}

		// Token: 0x0601D439 RID: 119865 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D439")]
		[Address(RVA = "0x16D71E0", Offset = "0x16D5DE0", VA = "0x1816D71E0")]
		public void OnCleanAllClicked()
		{
		}

		// Token: 0x0601D43A RID: 119866 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D43A")]
		[Address(RVA = "0x16D7970", Offset = "0x16D6570", VA = "0x1816D7970")]
		public void OpenSelectCharState()
		{
		}

		// Token: 0x0601D43B RID: 119867 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D43B")]
		[Address(RVA = "0x16D7300", Offset = "0x16D5F00", VA = "0x1816D7300")]
		public void OnEditIllustClicked()
		{
		}

		// Token: 0x0601D43C RID: 119868 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D43C")]
		[Address(RVA = "0x16D7A00", Offset = "0x16D6600", VA = "0x1816D7A00")]
		public void ResetListToTop()
		{
		}

		// Token: 0x0601D43D RID: 119869 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D43D")]
		[Address(RVA = "0x16D7A70", Offset = "0x16D6670", VA = "0x1816D7A70")]
		public HomeSecretarySkinChangeView()
		{
		}

		// Token: 0x04026797 RID: 157591
		[Token(Token = "0x4026797")]
		private const string SELECTED_CHAR_FORMAT = "{0} {1}";

		// Token: 0x04026798 RID: 157592
		[Token(Token = "0x4026798")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _txtSelectedRealName;

		// Token: 0x04026799 RID: 157593
		[Token(Token = "0x4026799")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _txtSelectedNickName;

		// Token: 0x0402679A RID: 157594
		[Token(Token = "0x402679A")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private HomeSecretarySkinChangeGridAdapter _adapter;

		// Token: 0x0402679B RID: 157595
		[Token(Token = "0x402679B")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private LoopVerticalScrollRect _scrollRect;

		// Token: 0x0402679C RID: 157596
		[Token(Token = "0x402679C")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _selectedSkinNum;

		// Token: 0x0402679D RID: 157597
		[Token(Token = "0x402679D")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Image _skinGroupIcon;

		// Token: 0x0402679E RID: 157598
		[Token(Token = "0x402679E")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Image _selectedSkinBg;

		// Token: 0x0402679F RID: 157599
		[Token(Token = "0x402679F")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Color _selectedSkinSafeBgColor;

		// Token: 0x040267A0 RID: 157600
		[Token(Token = "0x40267A0")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Color _selectedSkinDangerBgColor;

		// Token: 0x040267A1 RID: 157601
		[Token(Token = "0x40267A1")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private HomeSecretarySkinFilterItemView[] _filters;

		// Token: 0x040267A2 RID: 157602
		[Token(Token = "0x40267A2")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Text _selectedCharNum;

		// Token: 0x040267A3 RID: 157603
		[Token(Token = "0x40267A3")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private GameObject _skinGroupBg;

		// Token: 0x040267A4 RID: 157604
		[Token(Token = "0x40267A4")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private GameObject _selectCharBtn;

		// Token: 0x040267A5 RID: 157605
		[Token(Token = "0x40267A5")]
		[FieldOffset(Offset = "0x98")]
		private HomeSecretarySkinChangeViewModel m_viewModel;

		// Token: 0x040267A6 RID: 157606
		[Token(Token = "0x40267A6")]
		[FieldOffset(Offset = "0xA0")]
		private UIStateFinder m_stateFinder;

		// Token: 0x040267A7 RID: 157607
		[Token(Token = "0x40267A7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x040267A8 RID: 157608
		[Token(Token = "0x40267A8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnConfirmClicked;

		// Token: 0x040267A9 RID: 157609
		[Token(Token = "0x40267A9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnCancelClicked;

		// Token: 0x040267AA RID: 157610
		[Token(Token = "0x40267AA")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnCleanAllClicked;

		// Token: 0x040267AB RID: 157611
		[Token(Token = "0x40267AB")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OpenSelectCharState;

		// Token: 0x040267AC RID: 157612
		[Token(Token = "0x40267AC")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnEditIllustClicked;

		// Token: 0x040267AD RID: 157613
		[Token(Token = "0x40267AD")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_ResetListToTop;

		// Token: 0x040267AE RID: 157614
		[Token(Token = "0x40267AE")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
