using System;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.Carving
{
	// Token: 0x0200603D RID: 24637
	[Token(Token = "0x200603D")]
	public class CarvingMainBoardView : DataBinder<CarvingMainProperty>
	{
		// Token: 0x06023A10 RID: 145936 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023A10")]
		[Address(RVA = "0x1E4A940", Offset = "0x1E49540", VA = "0x181E4A940", Slot = "7")]
		public override void OnValueChanged(CarvingMainProperty property)
		{
		}

		// Token: 0x06023A11 RID: 145937 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023A11")]
		[Address(RVA = "0x1E4AC60", Offset = "0x1E49860", VA = "0x181E4AC60")]
		public void StateOnlyRegisterTutorialGO()
		{
		}

		// Token: 0x06023A12 RID: 145938 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023A12")]
		[Address(RVA = "0x1E4AF60", Offset = "0x1E49B60", VA = "0x181E4AF60")]
		private void _Render(CarvingMainViewModel model)
		{
		}

		// Token: 0x06023A13 RID: 145939 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023A13")]
		[Address(RVA = "0x1E4AE00", Offset = "0x1E49A00", VA = "0x181E4AE00")]
		private void _PlayProcessAnim(CarvingMainViewModel model)
		{
		}

		// Token: 0x06023A14 RID: 145940 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023A14")]
		[Address(RVA = "0x1E4A8B0", Offset = "0x1E494B0", VA = "0x181E4A8B0")]
		public void OnClickProcessBtn()
		{
		}

		// Token: 0x06023A15 RID: 145941 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023A15")]
		[Address(RVA = "0x1E4A740", Offset = "0x1E49340", VA = "0x181E4A740")]
		public void OnClickChallengeInfoBtn()
		{
		}

		// Token: 0x06023A16 RID: 145942 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023A16")]
		[Address(RVA = "0x1E4A7D0", Offset = "0x1E493D0", VA = "0x181E4A7D0")]
		public void OnClickHandbookBtn()
		{
		}

		// Token: 0x06023A17 RID: 145943 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023A17")]
		[Address(RVA = "0x1E4B0F0", Offset = "0x1E49CF0", VA = "0x181E4B0F0")]
		public CarvingMainBoardView()
		{
		}

		// Token: 0x04031554 RID: 202068
		[Token(Token = "0x4031554")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CarvingInputMaterialAreaView _inputMaterialView;

		// Token: 0x04031555 RID: 202069
		[Token(Token = "0x4031555")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private CarvingTopInfoView _topInfoView;

		// Token: 0x04031556 RID: 202070
		[Token(Token = "0x4031556")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private CarvingMainBoardOutputMaterialView _outputMaterialView;

		// Token: 0x04031557 RID: 202071
		[Token(Token = "0x4031557")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _goProcessBtnObj;

		// Token: 0x04031558 RID: 202072
		[Token(Token = "0x4031558")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UIAnimationLocation _enterProcessAnimLocation;

		// Token: 0x04031559 RID: 202073
		[Token(Token = "0x4031559")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _panelInputMat;

		// Token: 0x0403155A RID: 202074
		[Token(Token = "0x403155A")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _panelOutputMat;

		// Token: 0x0403155B RID: 202075
		[Token(Token = "0x403155B")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _panelCurrScore;

		// Token: 0x0403155C RID: 202076
		[Token(Token = "0x403155C")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _panelBtnProcess;

		// Token: 0x0403155D RID: 202077
		[Token(Token = "0x403155D")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _panelBtnHandbook;

		// Token: 0x0403155E RID: 202078
		[Token(Token = "0x403155E")]
		[FieldOffset(Offset = "0x78")]
		private Tween m_enterProcessTween;

		// Token: 0x0403155F RID: 202079
		[Token(Token = "0x403155F")]
		[FieldOffset(Offset = "0x80")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04031560 RID: 202080
		[Token(Token = "0x4031560")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04031561 RID: 202081
		[Token(Token = "0x4031561")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_StateOnlyRegisterTutorialGO;

		// Token: 0x04031562 RID: 202082
		[Token(Token = "0x4031562")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__Render;

		// Token: 0x04031563 RID: 202083
		[Token(Token = "0x4031563")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__PlayProcessAnim;

		// Token: 0x04031564 RID: 202084
		[Token(Token = "0x4031564")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnClickProcessBtn;

		// Token: 0x04031565 RID: 202085
		[Token(Token = "0x4031565")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnClickChallengeInfoBtn;

		// Token: 0x04031566 RID: 202086
		[Token(Token = "0x4031566")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnClickHandbookBtn;

		// Token: 0x04031567 RID: 202087
		[Token(Token = "0x4031567")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
