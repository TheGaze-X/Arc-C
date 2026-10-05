using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act1VHalfIdle
{
	// Token: 0x02007723 RID: 30499
	[Token(Token = "0x2007723")]
	public class Act1VHalfIdleCharUpgradeView : DataBinder<Act1VHalfIdleCharUpgradeProperty>
	{
		// Token: 0x17006484 RID: 25732
		// (get) Token: 0x0602ADA2 RID: 175522 RVA: 0x000DA358 File Offset: 0x000D8558
		[Token(Token = "0x17006484")]
		public bool isStable
		{
			[Token(Token = "0x602ADA2")]
			[Address(RVA = "0x26A3570", Offset = "0x26A2170", VA = "0x1826A3570")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0602ADA3 RID: 175523 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602ADA3")]
		[Address(RVA = "0x26A2690", Offset = "0x26A1290", VA = "0x1826A2690")]
		public void ActivateCharIllust()
		{
		}

		// Token: 0x0602ADA4 RID: 175524 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602ADA4")]
		[Address(RVA = "0x26A2970", Offset = "0x26A1570", VA = "0x1826A2970", Slot = "7")]
		public override void OnValueChanged(Act1VHalfIdleCharUpgradeProperty property)
		{
		}

		// Token: 0x0602ADA5 RID: 175525 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602ADA5")]
		[Address(RVA = "0x26A3190", Offset = "0x26A1D90", VA = "0x1826A3190")]
		private void _RenderCharBasicInfo(Act1VHalfIdleCharUpgradeViewModel viewModel)
		{
		}

		// Token: 0x0602ADA6 RID: 175526 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602ADA6")]
		[Address(RVA = "0x26A3290", Offset = "0x26A1E90", VA = "0x1826A3290")]
		private void _RenderCharIllust(Act1VHalfIdleCharUpgradeViewModel viewModel)
		{
		}

		// Token: 0x0602ADA7 RID: 175527 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602ADA7")]
		[Address(RVA = "0x26A2FE0", Offset = "0x26A1BE0", VA = "0x1826A2FE0")]
		private void _LoadCharIllust(CharUISkinStruct skinStruct)
		{
		}

		// Token: 0x0602ADA8 RID: 175528 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602ADA8")]
		[Address(RVA = "0x26A26F0", Offset = "0x26A12F0", VA = "0x1826A26F0")]
		public void OnBtnCharPreviewClicked()
		{
		}

		// Token: 0x0602ADA9 RID: 175529 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602ADA9")]
		[Address(RVA = "0x26A2790", Offset = "0x26A1390", VA = "0x1826A2790")]
		public void OnBtnSwitchCharLeftClicked()
		{
		}

		// Token: 0x0602ADAA RID: 175530 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602ADAA")]
		[Address(RVA = "0x26A2880", Offset = "0x26A1480", VA = "0x1826A2880")]
		public void OnBtnSwitchCharRightClicked()
		{
		}

		// Token: 0x0602ADAB RID: 175531 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602ADAB")]
		[Address(RVA = "0x26A2C30", Offset = "0x26A1830", VA = "0x1826A2C30")]
		public void RegisterTutorialGO()
		{
		}

		// Token: 0x0602ADAC RID: 175532 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602ADAC")]
		[Address(RVA = "0x26A3500", Offset = "0x26A2100", VA = "0x1826A3500")]
		public Act1VHalfIdleCharUpgradeView()
		{
		}

		// Token: 0x0403DC34 RID: 252980
		[Token(Token = "0x403DC34")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Act1VHalfIdleCharUpgradeRewardView[] _upgradeRewardViews;

		// Token: 0x0403DC35 RID: 252981
		[Token(Token = "0x403DC35")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _imgRarity;

		// Token: 0x0403DC36 RID: 252982
		[Token(Token = "0x403DC36")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _imgProfession;

		// Token: 0x0403DC37 RID: 252983
		[Token(Token = "0x403DC37")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _textCharName;

		// Token: 0x0403DC38 RID: 252984
		[Token(Token = "0x403DC38")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Act1VHalfIdleCharLevelUpgradeView _levelUpgradeView;

		// Token: 0x0403DC39 RID: 252985
		[Token(Token = "0x403DC39")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Act1VHalfIdleCharSkillUpgradeView _skillUpgradeView;

		// Token: 0x0403DC3A RID: 252986
		[Token(Token = "0x403DC3A")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _pnlArrowLeft;

		// Token: 0x0403DC3B RID: 252987
		[Token(Token = "0x403DC3B")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _pnlArrowRight;

		// Token: 0x0403DC3C RID: 252988
		[Token(Token = "0x403DC3C")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Transform _illustContainer;

		// Token: 0x0403DC3D RID: 252989
		[Token(Token = "0x403DC3D")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _pnlUpgradeRewardViewGO;

		// Token: 0x0403DC3E RID: 252990
		[Token(Token = "0x403DC3E")]
		[FieldOffset(Offset = "0x70")]
		private string m_cachedCharId;

		// Token: 0x0403DC3F RID: 252991
		[Token(Token = "0x403DC3F")]
		[FieldOffset(Offset = "0x78")]
		private string m_cachedTmplId;

		// Token: 0x0403DC40 RID: 252992
		[Token(Token = "0x403DC40")]
		[FieldOffset(Offset = "0x80")]
		private string m_cachedSkinId;

		// Token: 0x0403DC41 RID: 252993
		[Token(Token = "0x403DC41")]
		[FieldOffset(Offset = "0x88")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0403DC42 RID: 252994
		[Token(Token = "0x403DC42")]
		[FieldOffset(Offset = "0x98")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0403DC43 RID: 252995
		[Token(Token = "0x403DC43")]
		[FieldOffset(Offset = "0xA8")]
		private UICharacterIllust m_illust;

		// Token: 0x0403DC44 RID: 252996
		[Token(Token = "0x403DC44")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isStable;

		// Token: 0x0403DC45 RID: 252997
		[Token(Token = "0x403DC45")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_ActivateCharIllust;

		// Token: 0x0403DC46 RID: 252998
		[Token(Token = "0x403DC46")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0403DC47 RID: 252999
		[Token(Token = "0x403DC47")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__RenderCharBasicInfo;

		// Token: 0x0403DC48 RID: 253000
		[Token(Token = "0x403DC48")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__RenderCharIllust;

		// Token: 0x0403DC49 RID: 253001
		[Token(Token = "0x403DC49")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__LoadCharIllust;

		// Token: 0x0403DC4A RID: 253002
		[Token(Token = "0x403DC4A")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnBtnCharPreviewClicked;

		// Token: 0x0403DC4B RID: 253003
		[Token(Token = "0x403DC4B")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnBtnSwitchCharLeftClicked;

		// Token: 0x0403DC4C RID: 253004
		[Token(Token = "0x403DC4C")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnBtnSwitchCharRightClicked;

		// Token: 0x0403DC4D RID: 253005
		[Token(Token = "0x403DC4D")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_RegisterTutorialGO;

		// Token: 0x0403DC4E RID: 253006
		[Token(Token = "0x403DC4E")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
