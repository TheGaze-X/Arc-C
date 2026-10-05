using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act1VHalfIdle
{
	// Token: 0x020077DE RID: 30686
	[Token(Token = "0x20077DE")]
	public class Act1VHalfIdleRecruitPackageGachaDialog : UICompDialog<GachaDialogOption>, ICompDialogCallBack
	{
		// Token: 0x0602B0F9 RID: 176377 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B0F9")]
		[Address(RVA = "0x26DEDF0", Offset = "0x26DD9F0", VA = "0x1826DEDF0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602B0FA RID: 176378 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B0FA")]
		[Address(RVA = "0x26DF050", Offset = "0x26DDC50", VA = "0x1826DF050")]
		private void _Render(Act1VHalfIdleRecruitPackageGachaDialog.PackageGachaViewModel viewModel)
		{
		}

		// Token: 0x0602B0FB RID: 176379 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B0FB")]
		[Address(RVA = "0x26DEA40", Offset = "0x26DD640", VA = "0x1826DEA40", Slot = "18")]
		protected override void OnRender(GachaDialogOption input)
		{
		}

		// Token: 0x0602B0FC RID: 176380 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B0FC")]
		[Address(RVA = "0x26DF290", Offset = "0x26DDE90", VA = "0x1826DF290")]
		private void _SendPackageGachaRequest()
		{
		}

		// Token: 0x0602B0FD RID: 176381 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B0FD")]
		[Address(RVA = "0x26DEF20", Offset = "0x26DDB20", VA = "0x1826DEF20")]
		private void _OpenRecruitResultDialog(Act1VHalfIdleRecruitResultDialog.Options options)
		{
		}

		// Token: 0x0602B0FE RID: 176382 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B0FE")]
		[Address(RVA = "0x26DE7D0", Offset = "0x26DD3D0", VA = "0x1826DE7D0", Slot = "19")]
		public void HandleCallBack(int instId, ValueBundle output)
		{
		}

		// Token: 0x0602B0FF RID: 176383 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B0FF")]
		[Address(RVA = "0x26DE9B0", Offset = "0x26DD5B0", VA = "0x1826DE9B0")]
		public void OnBtnGachaClicked()
		{
		}

		// Token: 0x0602B100 RID: 176384 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B100")]
		[Address(RVA = "0x26DF5D0", Offset = "0x26DE1D0", VA = "0x1826DF5D0")]
		public Act1VHalfIdleRecruitPackageGachaDialog()
		{
		}

		// Token: 0x0403E34F RID: 254799
		[Token(Token = "0x403E34F")]
		private const int SIGNAL_SEND_RECRUIT_REQ = 0;

		// Token: 0x0403E350 RID: 254800
		[Token(Token = "0x403E350")]
		private const int SIGNAL_OPEN_RESULT_DIALOG = 1;

		// Token: 0x0403E351 RID: 254801
		[Token(Token = "0x403E351")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Image _imgBigIcon;

		// Token: 0x0403E352 RID: 254802
		[Token(Token = "0x403E352")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private List<Act1VHalfIdleRecruitPackageGachaDialog.CharIcon> _charIcons;

		// Token: 0x0403E353 RID: 254803
		[Token(Token = "0x403E353")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private UIAnimationLocation _animShow;

		// Token: 0x0403E354 RID: 254804
		[Token(Token = "0x403E354")]
		[FieldOffset(Offset = "0x90")]
		private Act1VHalfIdleRecruitPackageGachaDialog.PackageGachaViewModel m_viewModel;

		// Token: 0x0403E355 RID: 254805
		[Token(Token = "0x403E355")]
		[FieldOffset(Offset = "0x98")]
		private UICompDialogFinder m_dialogFinder;

		// Token: 0x0403E356 RID: 254806
		[Token(Token = "0x403E356")]
		[FieldOffset(Offset = "0xA8")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0403E357 RID: 254807
		[Token(Token = "0x403E357")]
		[FieldOffset(Offset = "0xB8")]
		private bool m_inited;

		// Token: 0x0403E358 RID: 254808
		[Token(Token = "0x403E358")]
		[FieldOffset(Offset = "0xC0")]
		private UIAnimationTween m_showTween;

		// Token: 0x0403E359 RID: 254809
		[Token(Token = "0x403E359")]
		[FieldOffset(Offset = "0xC8")]
		private int m_resultDialogInstId;

		// Token: 0x0403E35A RID: 254810
		[Token(Token = "0x403E35A")]
		[FieldOffset(Offset = "0xD0")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0403E35B RID: 254811
		[Token(Token = "0x403E35B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403E35C RID: 254812
		[Token(Token = "0x403E35C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__Render;

		// Token: 0x0403E35D RID: 254813
		[Token(Token = "0x403E35D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x0403E35E RID: 254814
		[Token(Token = "0x403E35E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__SendPackageGachaRequest;

		// Token: 0x0403E35F RID: 254815
		[Token(Token = "0x403E35F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OpenRecruitResultDialog;

		// Token: 0x0403E360 RID: 254816
		[Token(Token = "0x403E360")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_HandleCallBack;

		// Token: 0x0403E361 RID: 254817
		[Token(Token = "0x403E361")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnBtnGachaClicked;

		// Token: 0x0403E362 RID: 254818
		[Token(Token = "0x403E362")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020077DF RID: 30687
		[Token(Token = "0x20077DF")]
		[Serializable]
		private class CharIcon : IHotfixable
		{
			// Token: 0x0602B103 RID: 176387 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602B103")]
			[Address(RVA = "0x26EA210", Offset = "0x26E8E10", VA = "0x1826EA210")]
			public void Render(Act1VHalfIdleRecruitPackageGachaDialog.CharData charData)
			{
			}

			// Token: 0x0602B104 RID: 176388 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602B104")]
			[Address(RVA = "0x26EA3F0", Offset = "0x26E8FF0", VA = "0x1826EA3F0")]
			public CharIcon()
			{
			}

			// Token: 0x0403E363 RID: 254819
			[Token(Token = "0x403E363")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private GameObject _pnlEmpty;

			// Token: 0x0403E364 RID: 254820
			[Token(Token = "0x403E364")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			private GameObject _pnlChar;

			// Token: 0x0403E365 RID: 254821
			[Token(Token = "0x403E365")]
			[FieldOffset(Offset = "0x20")]
			[SerializeField]
			private Image _imgChar;

			// Token: 0x0403E366 RID: 254822
			[Token(Token = "0x403E366")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_Render;

			// Token: 0x0403E367 RID: 254823
			[Token(Token = "0x403E367")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x020077E0 RID: 30688
		[Token(Token = "0x20077E0")]
		public class CharData : IHotfixable
		{
			// Token: 0x0602B105 RID: 176389 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602B105")]
			[Address(RVA = "0x26EA1B0", Offset = "0x26E8DB0", VA = "0x1826EA1B0")]
			public CharData()
			{
			}

			// Token: 0x0403E368 RID: 254824
			[Token(Token = "0x403E368")]
			[FieldOffset(Offset = "0x10")]
			public string charId;

			// Token: 0x0403E369 RID: 254825
			[Token(Token = "0x403E369")]
			[FieldOffset(Offset = "0x18")]
			public int sortId;

			// Token: 0x0403E36A RID: 254826
			[Token(Token = "0x403E36A")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x020077E1 RID: 30689
		[Token(Token = "0x20077E1")]
		public class PackageGachaViewModel : IHotfixable
		{
			// Token: 0x0602B106 RID: 176390 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602B106")]
			[Address(RVA = "0x26EBCC0", Offset = "0x26EA8C0", VA = "0x1826EBCC0")]
			public void LoadData(string actId, string gachaPoolId)
			{
			}

			// Token: 0x0602B107 RID: 176391 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602B107")]
			[Address(RVA = "0x26EC190", Offset = "0x26EAD90", VA = "0x1826EC190")]
			public PackageGachaViewModel()
			{
			}

			// Token: 0x0403E36B RID: 254827
			[Token(Token = "0x403E36B")]
			[FieldOffset(Offset = "0x10")]
			public string actId;

			// Token: 0x0403E36C RID: 254828
			[Token(Token = "0x403E36C")]
			[FieldOffset(Offset = "0x18")]
			public string gachaPoolId;

			// Token: 0x0403E36D RID: 254829
			[Token(Token = "0x403E36D")]
			[FieldOffset(Offset = "0x20")]
			public int gachaPoolSortId;

			// Token: 0x0403E36E RID: 254830
			[Token(Token = "0x403E36E")]
			[FieldOffset(Offset = "0x24")]
			public Act1VHalfIdleGachaPoolType gachaPoolType;

			// Token: 0x0403E36F RID: 254831
			[Token(Token = "0x403E36F")]
			[FieldOffset(Offset = "0x28")]
			public List<Act1VHalfIdleRecruitPackageGachaDialog.CharData> charDatas;

			// Token: 0x0403E370 RID: 254832
			[Token(Token = "0x403E370")]
			[FieldOffset(Offset = "0x30")]
			public string itemId;

			// Token: 0x0403E371 RID: 254833
			[Token(Token = "0x403E371")]
			[FieldOffset(Offset = "0x38")]
			public int currGachaTimes;

			// Token: 0x0403E372 RID: 254834
			[Token(Token = "0x403E372")]
			[FieldOffset(Offset = "0x3C")]
			public int currItemCount;

			// Token: 0x0403E373 RID: 254835
			[Token(Token = "0x403E373")]
			[FieldOffset(Offset = "0x40")]
			public int costItemCount;

			// Token: 0x0403E374 RID: 254836
			[Token(Token = "0x403E374")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_LoadData;

			// Token: 0x0403E375 RID: 254837
			[Token(Token = "0x403E375")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
