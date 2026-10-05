using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Activity.ActMultiV3.Prepare
{
	// Token: 0x0200704E RID: 28750
	[Token(Token = "0x200704E")]
	public class ActMultiV3PrepareMainStepView : ActMultiV3PrepareMainViewBase, IPingListener
	{
		// Token: 0x06028D0C RID: 167180 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028D0C")]
		[Address(RVA = "0x2445BF0", Offset = "0x24447F0", VA = "0x182445BF0", Slot = "7")]
		public override void OnValueChanged(ActMultiV3PrepareMainViewModelProperty property)
		{
		}

		// Token: 0x06028D0D RID: 167181 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028D0D")]
		[Address(RVA = "0x2446170", Offset = "0x2444D70", VA = "0x182446170")]
		private void _CleanSwitchCoroutine()
		{
		}

		// Token: 0x06028D0E RID: 167182 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6028D0E")]
		[Address(RVA = "0x2446200", Offset = "0x2444E00", VA = "0x182446200")]
		private IEnumerator _DoSwitchStepPanel(ActMultiV3PrepareMainStepPanelBase from, ActMultiV3PrepareMainStepPanelBase to, ActMultiV3PrepareMainViewModel model)
		{
			return null;
		}

		// Token: 0x06028D0F RID: 167183 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028D0F")]
		[Address(RVA = "0x2446310", Offset = "0x2444F10", VA = "0x182446310")]
		private void _DoUpdatePanel(ActMultiV3PrepareMainStepPanelBase panel, ActMultiV3PrepareMainViewModel model, ActMultiV3StepUpdateCase updateCase)
		{
		}

		// Token: 0x06028D10 RID: 167184 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028D10")]
		[Address(RVA = "0x24459F0", Offset = "0x24445F0", VA = "0x1824459F0")]
		public void InitIfNot(ActMultiV3PrepareMainState hostState)
		{
		}

		// Token: 0x06028D11 RID: 167185 RVA: 0x000D31A0 File Offset: 0x000D13A0
		[Token(Token = "0x6028D11")]
		[Address(RVA = "0x2445830", Offset = "0x2444430", VA = "0x182445830")]
		public ActMultiV3PrepareMainViewConfig GetMainViewConfig(ActMultiV3PrepareMainViewModelProperty prop)
		{
			return default(ActMultiV3PrepareMainViewConfig);
		}

		// Token: 0x06028D12 RID: 167186 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028D12")]
		[Address(RVA = "0x2445710", Offset = "0x2444310", VA = "0x182445710")]
		public void DoBackAction()
		{
		}

		// Token: 0x06028D13 RID: 167187 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028D13")]
		[Address(RVA = "0x2446060", Offset = "0x2444C60", VA = "0x182446060", Slot = "8")]
		public void UpdatePing(int ping)
		{
		}

		// Token: 0x06028D14 RID: 167188 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028D14")]
		[Address(RVA = "0x2445F80", Offset = "0x2444B80", VA = "0x182445F80")]
		public void Stop()
		{
		}

		// Token: 0x06028D15 RID: 167189 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028D15")]
		[Address(RVA = "0x2446460", Offset = "0x2445060", VA = "0x182446460")]
		public ActMultiV3PrepareMainStepView()
		{
		}

		// Token: 0x0403A36E RID: 238446
		[Token(Token = "0x403A36E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ActMultiV3PrepareMainStepPanelBase[] _stepPrefabs;

		// Token: 0x0403A36F RID: 238447
		[Token(Token = "0x403A36F")]
		[FieldOffset(Offset = "0x28")]
		private List<ActMultiV3PrepareMainStepPanelBase> m_stepPanels;

		// Token: 0x0403A370 RID: 238448
		[Token(Token = "0x403A370")]
		[FieldOffset(Offset = "0x30")]
		private ActMultiV3PrepareStepType m_fromStep;

		// Token: 0x0403A371 RID: 238449
		[Token(Token = "0x403A371")]
		[FieldOffset(Offset = "0x38")]
		private Coroutine m_switchItr;

		// Token: 0x0403A372 RID: 238450
		[Token(Token = "0x403A372")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0403A373 RID: 238451
		[Token(Token = "0x403A373")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__CleanSwitchCoroutine;

		// Token: 0x0403A374 RID: 238452
		[Token(Token = "0x403A374")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__DoSwitchStepPanel;

		// Token: 0x0403A375 RID: 238453
		[Token(Token = "0x403A375")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__DoUpdatePanel;

		// Token: 0x0403A376 RID: 238454
		[Token(Token = "0x403A376")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_InitIfNot;

		// Token: 0x0403A377 RID: 238455
		[Token(Token = "0x403A377")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetMainViewConfig;

		// Token: 0x0403A378 RID: 238456
		[Token(Token = "0x403A378")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_DoBackAction;

		// Token: 0x0403A379 RID: 238457
		[Token(Token = "0x403A379")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_UpdatePing;

		// Token: 0x0403A37A RID: 238458
		[Token(Token = "0x403A37A")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_Stop;

		// Token: 0x0403A37B RID: 238459
		[Token(Token = "0x403A37B")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
