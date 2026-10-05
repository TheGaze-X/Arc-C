using System;
using System.Collections;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.ActMultiV3.Prepare
{
	// Token: 0x02007051 RID: 28753
	[Token(Token = "0x2007051")]
	public class ActMultiV3PrepareMainCharPickPanel : ActMultiV3PrepareMainStepPanelBase
	{
		// Token: 0x1700607B RID: 24699
		// (get) Token: 0x06028D26 RID: 167206 RVA: 0x000D31D0 File Offset: 0x000D13D0
		[Token(Token = "0x1700607B")]
		public override ActMultiV3PrepareStepType step
		{
			[Token(Token = "0x6028D26")]
			[Address(RVA = "0x2437A80", Offset = "0x2436680", VA = "0x182437A80", Slot = "4")]
			get
			{
				return ActMultiV3PrepareStepType.NONE;
			}
		}

		// Token: 0x06028D27 RID: 167207 RVA: 0x000D31E8 File Offset: 0x000D13E8
		[Token(Token = "0x6028D27")]
		[Address(RVA = "0x24369E0", Offset = "0x24355E0", VA = "0x1824369E0", Slot = "10")]
		public override ActMultiV3PrepareMainViewConfig GetMainViewConfig()
		{
			return default(ActMultiV3PrepareMainViewConfig);
		}

		// Token: 0x06028D28 RID: 167208 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028D28")]
		[Address(RVA = "0x2436B70", Offset = "0x2435770", VA = "0x182436B70", Slot = "7")]
		protected override void OnUpdate(ActMultiV3StepUpdateCase updateCase)
		{
		}

		// Token: 0x06028D29 RID: 167209 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028D29")]
		[Address(RVA = "0x2436C40", Offset = "0x2435840", VA = "0x182436C40", Slot = "8")]
		protected override void OnVisible(bool v)
		{
		}

		// Token: 0x06028D2A RID: 167210 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6028D2A")]
		[Address(RVA = "0x2436D60", Offset = "0x2435960", VA = "0x182436D60", Slot = "12")]
		protected override IEnumerator PlayEntryAnimation()
		{
			return null;
		}

		// Token: 0x06028D2B RID: 167211 RVA: 0x000D3200 File Offset: 0x000D1400
		[Token(Token = "0x6028D2B")]
		[Address(RVA = "0x24367A0", Offset = "0x24353A0", VA = "0x1824367A0", Slot = "11")]
		public override bool DoBackAction()
		{
			return default(bool);
		}

		// Token: 0x06028D2C RID: 167212 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028D2C")]
		[Address(RVA = "0x2437560", Offset = "0x2436160", VA = "0x182437560")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06028D2D RID: 167213 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028D2D")]
		[Address(RVA = "0x2436A70", Offset = "0x2435670", VA = "0x182436A70", Slot = "6")]
		protected override void OnStop()
		{
		}

		// Token: 0x06028D2E RID: 167214 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028D2E")]
		[Address(RVA = "0x2437100", Offset = "0x2435D00", VA = "0x182437100")]
		private void _HandlePickSucRet(object arg)
		{
		}

		// Token: 0x06028D2F RID: 167215 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028D2F")]
		[Address(RVA = "0x2437030", Offset = "0x2435C30", VA = "0x182437030")]
		private void _EventOnSelectChar(int instId)
		{
		}

		// Token: 0x06028D30 RID: 167216 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028D30")]
		[Address(RVA = "0x2436F00", Offset = "0x2435B00", VA = "0x182436F00")]
		private void _EvenOnSkip()
		{
		}

		// Token: 0x06028D31 RID: 167217 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028D31")]
		[Address(RVA = "0x2436FC0", Offset = "0x2435BC0", VA = "0x182436FC0")]
		private void _EventOnMyTurn()
		{
		}

		// Token: 0x06028D32 RID: 167218 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028D32")]
		[Address(RVA = "0x2436900", Offset = "0x2435500", VA = "0x182436900")]
		public void EventOnShowReserveList()
		{
		}

		// Token: 0x06028D33 RID: 167219 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028D33")]
		[Address(RVA = "0x2436840", Offset = "0x2435440", VA = "0x182436840")]
		public void EventOnHideReserveList()
		{
		}

		// Token: 0x06028D34 RID: 167220 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028D34")]
		[Address(RVA = "0x2437A20", Offset = "0x2436620", VA = "0x182437A20")]
		public ActMultiV3PrepareMainCharPickPanel()
		{
		}

		// Token: 0x06028D36 RID: 167222 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028D36")]
		[Address(RVA = "0x2436ED0", Offset = "0x2435AD0", VA = "0x182436ED0")]
		private void <>xLuaBaseProxy_OnUpdate(ActMultiV3StepUpdateCase P0)
		{
		}

		// Token: 0x06028D37 RID: 167223 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028D37")]
		[Address(RVA = "0x2436EE0", Offset = "0x2435AE0", VA = "0x182436EE0")]
		private void <>xLuaBaseProxy_OnVisible(bool P0)
		{
		}

		// Token: 0x06028D38 RID: 167224 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6028D38")]
		[Address(RVA = "0x2436EF0", Offset = "0x2435AF0", VA = "0x182436EF0")]
		private IEnumerator <>xLuaBaseProxy_PlayEntryAnimation()
		{
			return null;
		}

		// Token: 0x06028D39 RID: 167225 RVA: 0x000D3230 File Offset: 0x000D1430
		[Token(Token = "0x6028D39")]
		[Address(RVA = "0x2436EB0", Offset = "0x2435AB0", VA = "0x182436EB0")]
		private bool <>xLuaBaseProxy_DoBackAction()
		{
			return default(bool);
		}

		// Token: 0x06028D3A RID: 167226 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028D3A")]
		[Address(RVA = "0x2436EC0", Offset = "0x2435AC0", VA = "0x182436EC0")]
		private void <>xLuaBaseProxy_OnStop()
		{
		}

		// Token: 0x0403A3A1 RID: 238497
		[Token(Token = "0x403A3A1")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UIAnimationLocation _entryAnim;

		// Token: 0x0403A3A2 RID: 238498
		[Token(Token = "0x403A3A2")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private ActMultiV3PrepareMainCharPickChooseView _chooseView;

		// Token: 0x0403A3A3 RID: 238499
		[Token(Token = "0x403A3A3")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private ActMultiV3PrepareMainCharPickReserveView _reserveView;

		// Token: 0x0403A3A4 RID: 238500
		[Token(Token = "0x403A3A4")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private ActMultiV3PrepareMainCharPickGotAnimView _gotAnimView;

		// Token: 0x0403A3A5 RID: 238501
		[Token(Token = "0x403A3A5")]
		[FieldOffset(Offset = "0x60")]
		private ActMultiV3PrepareMainCharPickPanelViewModelProperty m_prop;

		// Token: 0x0403A3A6 RID: 238502
		[Token(Token = "0x403A3A6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_step;

		// Token: 0x0403A3A7 RID: 238503
		[Token(Token = "0x403A3A7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetMainViewConfig;

		// Token: 0x0403A3A8 RID: 238504
		[Token(Token = "0x403A3A8")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnUpdate;

		// Token: 0x0403A3A9 RID: 238505
		[Token(Token = "0x403A3A9")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnVisible;

		// Token: 0x0403A3AA RID: 238506
		[Token(Token = "0x403A3AA")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_PlayEntryAnimation;

		// Token: 0x0403A3AB RID: 238507
		[Token(Token = "0x403A3AB")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_DoBackAction;

		// Token: 0x0403A3AC RID: 238508
		[Token(Token = "0x403A3AC")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403A3AD RID: 238509
		[Token(Token = "0x403A3AD")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnStop;

		// Token: 0x0403A3AE RID: 238510
		[Token(Token = "0x403A3AE")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__HandlePickSucRet;

		// Token: 0x0403A3AF RID: 238511
		[Token(Token = "0x403A3AF")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__EventOnSelectChar;

		// Token: 0x0403A3B0 RID: 238512
		[Token(Token = "0x403A3B0")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__EvenOnSkip;

		// Token: 0x0403A3B1 RID: 238513
		[Token(Token = "0x403A3B1")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__EventOnMyTurn;

		// Token: 0x0403A3B2 RID: 238514
		[Token(Token = "0x403A3B2")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_EventOnShowReserveList;

		// Token: 0x0403A3B3 RID: 238515
		[Token(Token = "0x403A3B3")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_EventOnHideReserveList;

		// Token: 0x0403A3B4 RID: 238516
		[Token(Token = "0x403A3B4")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
