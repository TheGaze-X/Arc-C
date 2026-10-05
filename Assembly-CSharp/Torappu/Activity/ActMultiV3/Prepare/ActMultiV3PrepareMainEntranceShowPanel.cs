using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Activity.ActMultiV3.Prepare
{
	// Token: 0x0200705B RID: 28763
	[Token(Token = "0x200705B")]
	public class ActMultiV3PrepareMainEntranceShowPanel : ActMultiV3PrepareMainStepPanelBase
	{
		// Token: 0x17006090 RID: 24720
		// (get) Token: 0x06028D82 RID: 167298 RVA: 0x000D33C8 File Offset: 0x000D15C8
		[Token(Token = "0x17006090")]
		public override ActMultiV3PrepareStepType step
		{
			[Token(Token = "0x6028D82")]
			[Address(RVA = "0x2438980", Offset = "0x2437580", VA = "0x182438980", Slot = "4")]
			get
			{
				return ActMultiV3PrepareStepType.NONE;
			}
		}

		// Token: 0x06028D83 RID: 167299 RVA: 0x000D33E0 File Offset: 0x000D15E0
		[Token(Token = "0x6028D83")]
		[Address(RVA = "0x2438470", Offset = "0x2437070", VA = "0x182438470", Slot = "10")]
		public override ActMultiV3PrepareMainViewConfig GetMainViewConfig()
		{
			return default(ActMultiV3PrepareMainViewConfig);
		}

		// Token: 0x06028D84 RID: 167300 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028D84")]
		[Address(RVA = "0x24387B0", Offset = "0x24373B0", VA = "0x1824387B0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06028D85 RID: 167301 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028D85")]
		[Address(RVA = "0x24385D0", Offset = "0x24371D0", VA = "0x1824385D0", Slot = "8")]
		protected override void OnVisible(bool v)
		{
		}

		// Token: 0x06028D86 RID: 167302 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028D86")]
		[Address(RVA = "0x2438500", Offset = "0x2437100", VA = "0x182438500", Slot = "7")]
		protected override void OnUpdate(ActMultiV3StepUpdateCase updateCase)
		{
		}

		// Token: 0x06028D87 RID: 167303 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6028D87")]
		[Address(RVA = "0x24386F0", Offset = "0x24372F0", VA = "0x1824386F0", Slot = "13")]
		protected override IEnumerator PlayExitAnimation()
		{
			return null;
		}

		// Token: 0x06028D88 RID: 167304 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028D88")]
		[Address(RVA = "0x24383C0", Offset = "0x2436FC0", VA = "0x1824383C0")]
		public void EventOnConfirmBtnClicked()
		{
		}

		// Token: 0x06028D89 RID: 167305 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028D89")]
		[Address(RVA = "0x2438920", Offset = "0x2437520", VA = "0x182438920")]
		public ActMultiV3PrepareMainEntranceShowPanel()
		{
		}

		// Token: 0x06028D8A RID: 167306 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028D8A")]
		[Address(RVA = "0x2436EE0", Offset = "0x2435AE0", VA = "0x182436EE0")]
		private void <>xLuaBaseProxy_OnVisible(bool P0)
		{
		}

		// Token: 0x06028D8B RID: 167307 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028D8B")]
		[Address(RVA = "0x2436ED0", Offset = "0x2435AD0", VA = "0x182436ED0")]
		private void <>xLuaBaseProxy_OnUpdate(ActMultiV3StepUpdateCase P0)
		{
		}

		// Token: 0x06028D8C RID: 167308 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6028D8C")]
		[Address(RVA = "0x24387A0", Offset = "0x24373A0", VA = "0x1824387A0")]
		private IEnumerator <>xLuaBaseProxy_PlayExitAnimation()
		{
			return null;
		}

		// Token: 0x0403A421 RID: 238625
		[Token(Token = "0x403A421")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private ActMultiV3PrepareMainEntranceShowView _view;

		// Token: 0x0403A422 RID: 238626
		[Token(Token = "0x403A422")]
		[FieldOffset(Offset = "0x40")]
		private ActMultiV3PrepareMainEntranceShowProperty m_prop;

		// Token: 0x0403A423 RID: 238627
		[Token(Token = "0x403A423")]
		[FieldOffset(Offset = "0x48")]
		private GameObject m_entranceShowRoot;

		// Token: 0x0403A424 RID: 238628
		[Token(Token = "0x403A424")]
		[FieldOffset(Offset = "0x50")]
		private bool m_isInited;

		// Token: 0x0403A425 RID: 238629
		[Token(Token = "0x403A425")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_step;

		// Token: 0x0403A426 RID: 238630
		[Token(Token = "0x403A426")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetMainViewConfig;

		// Token: 0x0403A427 RID: 238631
		[Token(Token = "0x403A427")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403A428 RID: 238632
		[Token(Token = "0x403A428")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnVisible;

		// Token: 0x0403A429 RID: 238633
		[Token(Token = "0x403A429")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnUpdate;

		// Token: 0x0403A42A RID: 238634
		[Token(Token = "0x403A42A")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_PlayExitAnimation;

		// Token: 0x0403A42B RID: 238635
		[Token(Token = "0x403A42B")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_EventOnConfirmBtnClicked;

		// Token: 0x0403A42C RID: 238636
		[Token(Token = "0x403A42C")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
