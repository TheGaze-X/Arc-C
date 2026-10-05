using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.ActMultiV3.Prepare
{
	// Token: 0x0200707E RID: 28798
	[Token(Token = "0x200707E")]
	public class ActMultiV3PrepareMainStageChoosePanel : ActMultiV3PrepareMainStepPanelBase
	{
		// Token: 0x170060B6 RID: 24758
		// (get) Token: 0x06028E61 RID: 167521 RVA: 0x000D3830 File Offset: 0x000D1A30
		[Token(Token = "0x170060B6")]
		public override ActMultiV3PrepareStepType step
		{
			[Token(Token = "0x6028E61")]
			[Address(RVA = "0x245CA00", Offset = "0x245B600", VA = "0x18245CA00", Slot = "4")]
			get
			{
				return ActMultiV3PrepareStepType.NONE;
			}
		}

		// Token: 0x06028E62 RID: 167522 RVA: 0x000D3848 File Offset: 0x000D1A48
		[Token(Token = "0x6028E62")]
		[Address(RVA = "0x245C610", Offset = "0x245B210", VA = "0x18245C610", Slot = "10")]
		public override ActMultiV3PrepareMainViewConfig GetMainViewConfig()
		{
			return default(ActMultiV3PrepareMainViewConfig);
		}

		// Token: 0x06028E63 RID: 167523 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028E63")]
		[Address(RVA = "0x245C790", Offset = "0x245B390", VA = "0x18245C790")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06028E64 RID: 167524 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028E64")]
		[Address(RVA = "0x245C6B0", Offset = "0x245B2B0", VA = "0x18245C6B0", Slot = "7")]
		protected override void OnUpdate(ActMultiV3StepUpdateCase updateCase)
		{
		}

		// Token: 0x06028E65 RID: 167525 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028E65")]
		[Address(RVA = "0x245BEE0", Offset = "0x245AAE0", VA = "0x18245BEE0")]
		public void EventOnCopyRoomId()
		{
		}

		// Token: 0x06028E66 RID: 167526 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028E66")]
		[Address(RVA = "0x245BE40", Offset = "0x245AA40", VA = "0x18245BE40")]
		public void EventOnClickGuestReadyBtn()
		{
		}

		// Token: 0x06028E67 RID: 167527 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028E67")]
		[Address(RVA = "0x245BDA0", Offset = "0x245A9A0", VA = "0x18245BDA0")]
		public void EventOnClickGuestCancelReadyBtn()
		{
		}

		// Token: 0x06028E68 RID: 167528 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028E68")]
		[Address(RVA = "0x245C0A0", Offset = "0x245ACA0", VA = "0x18245C0A0")]
		public void EventOnEnterGameBtnClick()
		{
		}

		// Token: 0x06028E69 RID: 167529 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028E69")]
		[Address(RVA = "0x245C2A0", Offset = "0x245AEA0", VA = "0x18245C2A0")]
		public void EventOnFlipModeToggleClick()
		{
		}

		// Token: 0x06028E6A RID: 167530 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028E6A")]
		[Address(RVA = "0x245C4A0", Offset = "0x245B0A0", VA = "0x18245C4A0")]
		public void EventOnOpenStageDetailBtn()
		{
		}

		// Token: 0x06028E6B RID: 167531 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028E6B")]
		[Address(RVA = "0x245BD10", Offset = "0x245A910", VA = "0x18245BD10")]
		public void EventOnBtnChooseStageClicked()
		{
		}

		// Token: 0x06028E6C RID: 167532 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028E6C")]
		[Address(RVA = "0x245C9A0", Offset = "0x245B5A0", VA = "0x18245C9A0")]
		public ActMultiV3PrepareMainStageChoosePanel()
		{
		}

		// Token: 0x06028E6D RID: 167533 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028E6D")]
		[Address(RVA = "0x2436ED0", Offset = "0x2435AD0", VA = "0x182436ED0")]
		private void <>xLuaBaseProxy_OnUpdate(ActMultiV3StepUpdateCase P0)
		{
		}

		// Token: 0x0403A569 RID: 238953
		[Token(Token = "0x403A569")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private ActMultiV3PrepareMainStageChooseView _view;

		// Token: 0x0403A56A RID: 238954
		[Token(Token = "0x403A56A")]
		[FieldOffset(Offset = "0x40")]
		private ActMultiV3PrepareMainStageChooseProperty m_prop;

		// Token: 0x0403A56B RID: 238955
		[Token(Token = "0x403A56B")]
		[FieldOffset(Offset = "0x48")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0403A56C RID: 238956
		[Token(Token = "0x403A56C")]
		[FieldOffset(Offset = "0x58")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0403A56D RID: 238957
		[Token(Token = "0x403A56D")]
		[FieldOffset(Offset = "0x68")]
		private bool m_isInited;

		// Token: 0x0403A56E RID: 238958
		[Token(Token = "0x403A56E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_step;

		// Token: 0x0403A56F RID: 238959
		[Token(Token = "0x403A56F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetMainViewConfig;

		// Token: 0x0403A570 RID: 238960
		[Token(Token = "0x403A570")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403A571 RID: 238961
		[Token(Token = "0x403A571")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnUpdate;

		// Token: 0x0403A572 RID: 238962
		[Token(Token = "0x403A572")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_EventOnCopyRoomId;

		// Token: 0x0403A573 RID: 238963
		[Token(Token = "0x403A573")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_EventOnClickGuestReadyBtn;

		// Token: 0x0403A574 RID: 238964
		[Token(Token = "0x403A574")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_EventOnClickGuestCancelReadyBtn;

		// Token: 0x0403A575 RID: 238965
		[Token(Token = "0x403A575")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_EventOnEnterGameBtnClick;

		// Token: 0x0403A576 RID: 238966
		[Token(Token = "0x403A576")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_EventOnFlipModeToggleClick;

		// Token: 0x0403A577 RID: 238967
		[Token(Token = "0x403A577")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_EventOnOpenStageDetailBtn;

		// Token: 0x0403A578 RID: 238968
		[Token(Token = "0x403A578")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_EventOnBtnChooseStageClicked;

		// Token: 0x0403A579 RID: 238969
		[Token(Token = "0x403A579")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
