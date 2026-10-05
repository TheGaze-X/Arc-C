using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act1VHalfIdle
{
	// Token: 0x020077D5 RID: 30677
	[Token(Token = "0x20077D5")]
	public class Act1VHalfIdleRecruitDirectGachaDialog : UICompDialog<GachaDialogOption>, ICompDialogCallBack
	{
		// Token: 0x0602B0C9 RID: 176329 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B0C9")]
		[Address(RVA = "0x26DB940", Offset = "0x26DA540", VA = "0x1826DB940")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602B0CA RID: 176330 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B0CA")]
		[Address(RVA = "0x26DBE10", Offset = "0x26DAA10", VA = "0x1826DBE10")]
		private void _Render(Act1VHalfIdleRecruitDirectGachaDialog.DirectGachaViewModel viewModel)
		{
		}

		// Token: 0x0602B0CB RID: 176331 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B0CB")]
		[Address(RVA = "0x26DB770", Offset = "0x26DA370", VA = "0x1826DB770", Slot = "18")]
		protected override void OnRender(GachaDialogOption input)
		{
		}

		// Token: 0x0602B0CC RID: 176332 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B0CC")]
		[Address(RVA = "0x26DBA70", Offset = "0x26DA670", VA = "0x1826DBA70")]
		private void _OpenDirectGachaDialog()
		{
		}

		// Token: 0x0602B0CD RID: 176333 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B0CD")]
		[Address(RVA = "0x26DB250", Offset = "0x26D9E50", VA = "0x1826DB250", Slot = "19")]
		public void HandleCallBack(int instId, ValueBundle output)
		{
		}

		// Token: 0x0602B0CE RID: 176334 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B0CE")]
		[Address(RVA = "0x26DBCE0", Offset = "0x26DA8E0", VA = "0x1826DBCE0")]
		private void _OpenRecruitResultDialog(Act1VHalfIdleRecruitResultDialog.Options options)
		{
		}

		// Token: 0x0602B0CF RID: 176335 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B0CF")]
		[Address(RVA = "0x26DB640", Offset = "0x26DA240", VA = "0x1826DB640")]
		public void OnBtnGachaClicked()
		{
		}

		// Token: 0x0602B0D0 RID: 176336 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B0D0")]
		[Address(RVA = "0x26DC010", Offset = "0x26DAC10", VA = "0x1826DC010")]
		public Act1VHalfIdleRecruitDirectGachaDialog()
		{
		}

		// Token: 0x0403E2C7 RID: 254663
		[Token(Token = "0x403E2C7")]
		private const int SIGNAL_OPEN_RESULT_DIALOG = 1;

		// Token: 0x0403E2C8 RID: 254664
		[Token(Token = "0x403E2C8")]
		private const int SIGNAL_OPEN_SELECT_DIALOG = 2;

		// Token: 0x0403E2C9 RID: 254665
		[Token(Token = "0x403E2C9")]
		private const string FORMAT_COST_ITEM = "-{0}";

		// Token: 0x0403E2CA RID: 254666
		[Token(Token = "0x403E2CA")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private UIAnimationLocation _animShow;

		// Token: 0x0403E2CB RID: 254667
		[Token(Token = "0x403E2CB")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Text _textCurrItemCount;

		// Token: 0x0403E2CC RID: 254668
		[Token(Token = "0x403E2CC")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Text _textSelectedItemCostAvailable;

		// Token: 0x0403E2CD RID: 254669
		[Token(Token = "0x403E2CD")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Text _textSelectedItemCostDisabled;

		// Token: 0x0403E2CE RID: 254670
		[Token(Token = "0x403E2CE")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private GameObject _pnlAvailable;

		// Token: 0x0403E2CF RID: 254671
		[Token(Token = "0x403E2CF")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private GameObject _pnlDisabled;

		// Token: 0x0403E2D0 RID: 254672
		[Token(Token = "0x403E2D0")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private Text _gachaItemName;

		// Token: 0x0403E2D1 RID: 254673
		[Token(Token = "0x403E2D1")]
		[FieldOffset(Offset = "0xB0")]
		private bool m_inited;

		// Token: 0x0403E2D2 RID: 254674
		[Token(Token = "0x403E2D2")]
		[FieldOffset(Offset = "0xB8")]
		private UIAnimationTween m_showTween;

		// Token: 0x0403E2D3 RID: 254675
		[Token(Token = "0x403E2D3")]
		[FieldOffset(Offset = "0xC0")]
		private Act1VHalfIdleRecruitDirectGachaDialog.DirectGachaViewModel m_viewModel;

		// Token: 0x0403E2D4 RID: 254676
		[Token(Token = "0x403E2D4")]
		[FieldOffset(Offset = "0xC8")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0403E2D5 RID: 254677
		[Token(Token = "0x403E2D5")]
		[FieldOffset(Offset = "0xD8")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0403E2D6 RID: 254678
		[Token(Token = "0x403E2D6")]
		[FieldOffset(Offset = "0xE8")]
		private int m_selectDialogInstId;

		// Token: 0x0403E2D7 RID: 254679
		[Token(Token = "0x403E2D7")]
		[FieldOffset(Offset = "0xEC")]
		private int m_resultDialogInstId;

		// Token: 0x0403E2D8 RID: 254680
		[Token(Token = "0x403E2D8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403E2D9 RID: 254681
		[Token(Token = "0x403E2D9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__Render;

		// Token: 0x0403E2DA RID: 254682
		[Token(Token = "0x403E2DA")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x0403E2DB RID: 254683
		[Token(Token = "0x403E2DB")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OpenDirectGachaDialog;

		// Token: 0x0403E2DC RID: 254684
		[Token(Token = "0x403E2DC")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_HandleCallBack;

		// Token: 0x0403E2DD RID: 254685
		[Token(Token = "0x403E2DD")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OpenRecruitResultDialog;

		// Token: 0x0403E2DE RID: 254686
		[Token(Token = "0x403E2DE")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnBtnGachaClicked;

		// Token: 0x0403E2DF RID: 254687
		[Token(Token = "0x403E2DF")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020077D6 RID: 30678
		[Token(Token = "0x20077D6")]
		public class DirectGachaViewModel : IHotfixable
		{
			// Token: 0x0602B0D1 RID: 176337 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602B0D1")]
			[Address(RVA = "0x26EA4B0", Offset = "0x26E90B0", VA = "0x1826EA4B0")]
			public void LoadData(string actId, string gachaPoolId)
			{
			}

			// Token: 0x0602B0D2 RID: 176338 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602B0D2")]
			[Address(RVA = "0x26EA710", Offset = "0x26E9310", VA = "0x1826EA710")]
			public DirectGachaViewModel()
			{
			}

			// Token: 0x0403E2E0 RID: 254688
			[Token(Token = "0x403E2E0")]
			[FieldOffset(Offset = "0x10")]
			public string actId;

			// Token: 0x0403E2E1 RID: 254689
			[Token(Token = "0x403E2E1")]
			[FieldOffset(Offset = "0x18")]
			public string gachaPoolId;

			// Token: 0x0403E2E2 RID: 254690
			[Token(Token = "0x403E2E2")]
			[FieldOffset(Offset = "0x20")]
			public int gachaPoolSortId;

			// Token: 0x0403E2E3 RID: 254691
			[Token(Token = "0x403E2E3")]
			[FieldOffset(Offset = "0x24")]
			public Act1VHalfIdleGachaPoolType gachaPoolType;

			// Token: 0x0403E2E4 RID: 254692
			[Token(Token = "0x403E2E4")]
			[FieldOffset(Offset = "0x28")]
			public string itemId;

			// Token: 0x0403E2E5 RID: 254693
			[Token(Token = "0x403E2E5")]
			[FieldOffset(Offset = "0x30")]
			public string gachaItemName;

			// Token: 0x0403E2E6 RID: 254694
			[Token(Token = "0x403E2E6")]
			[FieldOffset(Offset = "0x38")]
			public int currItemCount;

			// Token: 0x0403E2E7 RID: 254695
			[Token(Token = "0x403E2E7")]
			[FieldOffset(Offset = "0x3C")]
			public int currGachaTimes;

			// Token: 0x0403E2E8 RID: 254696
			[Token(Token = "0x403E2E8")]
			[FieldOffset(Offset = "0x40")]
			public int costItemCount;

			// Token: 0x0403E2E9 RID: 254697
			[Token(Token = "0x403E2E9")]
			[FieldOffset(Offset = "0x48")]
			public Act1VHalfIdleGachaPoolData gachaPoolData;

			// Token: 0x0403E2EA RID: 254698
			[Token(Token = "0x403E2EA")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_LoadData;

			// Token: 0x0403E2EB RID: 254699
			[Token(Token = "0x403E2EB")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
