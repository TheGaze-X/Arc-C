using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act1VHalfIdle
{
	// Token: 0x020077D7 RID: 30679
	[Token(Token = "0x20077D7")]
	public class Act1VHalfIdleRecruitNewbeeGachaDialog : UICompDialog<GachaDialogOption>, ICompDialogCallBack
	{
		// Token: 0x0602B0D3 RID: 176339 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B0D3")]
		[Address(RVA = "0x26DC7D0", Offset = "0x26DB3D0", VA = "0x1826DC7D0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602B0D4 RID: 176340 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B0D4")]
		[Address(RVA = "0x26DCA30", Offset = "0x26DB630", VA = "0x1826DCA30")]
		private void _Render(Act1VHalfIdleRecruitNewbeeGachaDialog.NewbeeGachaViewModel viewModel)
		{
		}

		// Token: 0x0602B0D5 RID: 176341 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B0D5")]
		[Address(RVA = "0x26DC420", Offset = "0x26DB020", VA = "0x1826DC420", Slot = "18")]
		protected override void OnRender(GachaDialogOption input)
		{
		}

		// Token: 0x0602B0D6 RID: 176342 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B0D6")]
		[Address(RVA = "0x26DCDD0", Offset = "0x26DB9D0", VA = "0x1826DCDD0")]
		private void _SendNewbeeGachaRequest()
		{
		}

		// Token: 0x0602B0D7 RID: 176343 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B0D7")]
		[Address(RVA = "0x26DC900", Offset = "0x26DB500", VA = "0x1826DC900")]
		private void _OpenRecruitResultDialog(Act1VHalfIdleRecruitResultDialog.Options options)
		{
		}

		// Token: 0x0602B0D8 RID: 176344 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B0D8")]
		[Address(RVA = "0x26DC110", Offset = "0x26DAD10", VA = "0x1826DC110", Slot = "19")]
		public void HandleCallBack(int instId, ValueBundle output)
		{
		}

		// Token: 0x0602B0D9 RID: 176345 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B0D9")]
		[Address(RVA = "0x26DC2F0", Offset = "0x26DAEF0", VA = "0x1826DC2F0")]
		public void OnBtnGachaClicked()
		{
		}

		// Token: 0x0602B0DA RID: 176346 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B0DA")]
		[Address(RVA = "0x26DD110", Offset = "0x26DBD10", VA = "0x1826DD110")]
		public Act1VHalfIdleRecruitNewbeeGachaDialog()
		{
		}

		// Token: 0x0403E2EC RID: 254700
		[Token(Token = "0x403E2EC")]
		private const int SIGNAL_SEND_RECRUIT_REQ = 0;

		// Token: 0x0403E2ED RID: 254701
		[Token(Token = "0x403E2ED")]
		private const int SIGNAL_OPEN_RESULT_DIALOG = 1;

		// Token: 0x0403E2EE RID: 254702
		[Token(Token = "0x403E2EE")]
		private const string FORMAT_COST_ITEM = "-{0}";

		// Token: 0x0403E2EF RID: 254703
		[Token(Token = "0x403E2EF")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private List<Act1VHalfIdleRecruitNewbeeGachaDialog.CharIcon> _charIcons;

		// Token: 0x0403E2F0 RID: 254704
		[Token(Token = "0x403E2F0")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private UIAnimationLocation _animShow;

		// Token: 0x0403E2F1 RID: 254705
		[Token(Token = "0x403E2F1")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Text _textCurrItemCount;

		// Token: 0x0403E2F2 RID: 254706
		[Token(Token = "0x403E2F2")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Text _textItemCostAvailable;

		// Token: 0x0403E2F3 RID: 254707
		[Token(Token = "0x403E2F3")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Text _textItemCostDisabled;

		// Token: 0x0403E2F4 RID: 254708
		[Token(Token = "0x403E2F4")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private GameObject _pnlAvailable;

		// Token: 0x0403E2F5 RID: 254709
		[Token(Token = "0x403E2F5")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private GameObject _pnlDisabled;

		// Token: 0x0403E2F6 RID: 254710
		[Token(Token = "0x403E2F6")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private Text _gachaItemName;

		// Token: 0x0403E2F7 RID: 254711
		[Token(Token = "0x403E2F7")]
		[FieldOffset(Offset = "0xB8")]
		private Act1VHalfIdleRecruitNewbeeGachaDialog.NewbeeGachaViewModel m_viewModel;

		// Token: 0x0403E2F8 RID: 254712
		[Token(Token = "0x403E2F8")]
		[FieldOffset(Offset = "0xC0")]
		private bool m_inited;

		// Token: 0x0403E2F9 RID: 254713
		[Token(Token = "0x403E2F9")]
		[FieldOffset(Offset = "0xC8")]
		private UIAnimationTween m_showTween;

		// Token: 0x0403E2FA RID: 254714
		[Token(Token = "0x403E2FA")]
		[FieldOffset(Offset = "0xD0")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0403E2FB RID: 254715
		[Token(Token = "0x403E2FB")]
		[FieldOffset(Offset = "0xE0")]
		private int m_resultDialogInstId;

		// Token: 0x0403E2FC RID: 254716
		[Token(Token = "0x403E2FC")]
		[FieldOffset(Offset = "0xE8")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0403E2FD RID: 254717
		[Token(Token = "0x403E2FD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403E2FE RID: 254718
		[Token(Token = "0x403E2FE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__Render;

		// Token: 0x0403E2FF RID: 254719
		[Token(Token = "0x403E2FF")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x0403E300 RID: 254720
		[Token(Token = "0x403E300")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__SendNewbeeGachaRequest;

		// Token: 0x0403E301 RID: 254721
		[Token(Token = "0x403E301")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OpenRecruitResultDialog;

		// Token: 0x0403E302 RID: 254722
		[Token(Token = "0x403E302")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_HandleCallBack;

		// Token: 0x0403E303 RID: 254723
		[Token(Token = "0x403E303")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnBtnGachaClicked;

		// Token: 0x0403E304 RID: 254724
		[Token(Token = "0x403E304")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020077D8 RID: 30680
		[Token(Token = "0x20077D8")]
		[Serializable]
		private class CharIcon : IHotfixable
		{
			// Token: 0x0602B0DD RID: 176349 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602B0DD")]
			[Address(RVA = "0x26EA2F0", Offset = "0x26E8EF0", VA = "0x1826EA2F0")]
			public void Render(Act1VHalfIdleRecruitNewbeeGachaDialog.CharData charData)
			{
			}

			// Token: 0x0602B0DE RID: 176350 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602B0DE")]
			[Address(RVA = "0x26EA450", Offset = "0x26E9050", VA = "0x1826EA450")]
			public CharIcon()
			{
			}

			// Token: 0x0403E305 RID: 254725
			[Token(Token = "0x403E305")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private GameObject _pnlEmpty;

			// Token: 0x0403E306 RID: 254726
			[Token(Token = "0x403E306")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			private GameObject _pnlChar;

			// Token: 0x0403E307 RID: 254727
			[Token(Token = "0x403E307")]
			[FieldOffset(Offset = "0x20")]
			[SerializeField]
			private Image _imgChar;

			// Token: 0x0403E308 RID: 254728
			[Token(Token = "0x403E308")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_Render;

			// Token: 0x0403E309 RID: 254729
			[Token(Token = "0x403E309")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x020077D9 RID: 30681
		[Token(Token = "0x20077D9")]
		public class CharData : IHotfixable
		{
			// Token: 0x0602B0DF RID: 176351 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602B0DF")]
			[Address(RVA = "0x26EA150", Offset = "0x26E8D50", VA = "0x1826EA150")]
			public CharData()
			{
			}

			// Token: 0x0403E30A RID: 254730
			[Token(Token = "0x403E30A")]
			[FieldOffset(Offset = "0x10")]
			public string charId;

			// Token: 0x0403E30B RID: 254731
			[Token(Token = "0x403E30B")]
			[FieldOffset(Offset = "0x18")]
			public int sortId;

			// Token: 0x0403E30C RID: 254732
			[Token(Token = "0x403E30C")]
			[FieldOffset(Offset = "0x1C")]
			public bool hasGained;

			// Token: 0x0403E30D RID: 254733
			[Token(Token = "0x403E30D")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x020077DA RID: 30682
		[Token(Token = "0x20077DA")]
		public class NewbeeGachaViewModel : IHotfixable
		{
			// Token: 0x0602B0E0 RID: 176352 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602B0E0")]
			[Address(RVA = "0x26EB140", Offset = "0x26E9D40", VA = "0x1826EB140")]
			public void LoadData(string actId, string gachaPoolId)
			{
			}

			// Token: 0x0602B0E1 RID: 176353 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602B0E1")]
			[Address(RVA = "0x26EB720", Offset = "0x26EA320", VA = "0x1826EB720")]
			public NewbeeGachaViewModel()
			{
			}

			// Token: 0x0403E30E RID: 254734
			[Token(Token = "0x403E30E")]
			[FieldOffset(Offset = "0x10")]
			public string actId;

			// Token: 0x0403E30F RID: 254735
			[Token(Token = "0x403E30F")]
			[FieldOffset(Offset = "0x18")]
			public string gachaPoolId;

			// Token: 0x0403E310 RID: 254736
			[Token(Token = "0x403E310")]
			[FieldOffset(Offset = "0x20")]
			public int gachaPoolSortId;

			// Token: 0x0403E311 RID: 254737
			[Token(Token = "0x403E311")]
			[FieldOffset(Offset = "0x24")]
			public Act1VHalfIdleGachaPoolType gachaPoolType;

			// Token: 0x0403E312 RID: 254738
			[Token(Token = "0x403E312")]
			[FieldOffset(Offset = "0x28")]
			public List<Act1VHalfIdleRecruitNewbeeGachaDialog.CharData> charDatas;

			// Token: 0x0403E313 RID: 254739
			[Token(Token = "0x403E313")]
			[FieldOffset(Offset = "0x30")]
			public string itemId;

			// Token: 0x0403E314 RID: 254740
			[Token(Token = "0x403E314")]
			[FieldOffset(Offset = "0x38")]
			public string gachaItemName;

			// Token: 0x0403E315 RID: 254741
			[Token(Token = "0x403E315")]
			[FieldOffset(Offset = "0x40")]
			public int currGachaTimes;

			// Token: 0x0403E316 RID: 254742
			[Token(Token = "0x403E316")]
			[FieldOffset(Offset = "0x44")]
			public int currItemCount;

			// Token: 0x0403E317 RID: 254743
			[Token(Token = "0x403E317")]
			[FieldOffset(Offset = "0x48")]
			public int costItemCount;

			// Token: 0x0403E318 RID: 254744
			[Token(Token = "0x403E318")]
			[FieldOffset(Offset = "0x4C")]
			public int ungainedCharCount;

			// Token: 0x0403E319 RID: 254745
			[Token(Token = "0x403E319")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_LoadData;

			// Token: 0x0403E31A RID: 254746
			[Token(Token = "0x403E31A")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
