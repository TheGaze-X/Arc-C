using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act1VHalfIdle.BattleFinish
{
	// Token: 0x02007835 RID: 30773
	[Token(Token = "0x2007835")]
	public class Act1VHalfIdleBattleFinishView : ActivityBattleFinishView
	{
		// Token: 0x0602B283 RID: 176771 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B283")]
		[Address(RVA = "0x26F86D0", Offset = "0x26F72D0", VA = "0x1826F86D0", Slot = "11")]
		protected override void OnInit()
		{
		}

		// Token: 0x0602B284 RID: 176772 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B284")]
		[Address(RVA = "0x26F88C0", Offset = "0x26F74C0", VA = "0x1826F88C0", Slot = "10")]
		public override IEnumerator ShowEnterEffectCoroutine()
		{
			return null;
		}

		// Token: 0x0602B285 RID: 176773 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B285")]
		[Address(RVA = "0x26F8FE0", Offset = "0x26F7BE0", VA = "0x1826F8FE0")]
		private void _TrySavePassStageSquad()
		{
		}

		// Token: 0x0602B286 RID: 176774 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B286")]
		[Address(RVA = "0x26F8C60", Offset = "0x26F7860", VA = "0x1826F8C60")]
		private void _TrySavePassStagePlotSquad()
		{
		}

		// Token: 0x0602B287 RID: 176775 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B287")]
		[Address(RVA = "0x26F8B40", Offset = "0x26F7740", VA = "0x1826F8B40")]
		private void _EventOnIncomeClick(bool confirm)
		{
		}

		// Token: 0x0602B288 RID: 176776 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B288")]
		[Address(RVA = "0x26F8970", Offset = "0x26F7570", VA = "0x1826F8970")]
		private void _CloseIncomeView()
		{
		}

		// Token: 0x0602B289 RID: 176777 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B289")]
		[Address(RVA = "0x26F9260", Offset = "0x26F7E60", VA = "0x1826F9260")]
		public Act1VHalfIdleBattleFinishView()
		{
		}

		// Token: 0x0602B28A RID: 176778 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B28A")]
		[Address(RVA = "0x248EF30", Offset = "0x248DB30", VA = "0x18248EF30")]
		private IEnumerator <>xLuaBaseProxy_ShowEnterEffectCoroutine()
		{
			return null;
		}

		// Token: 0x0403E635 RID: 255541
		[Token(Token = "0x403E635")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Act1VHalfIdleBattleFinishIncomeView _incomeView;

		// Token: 0x0403E636 RID: 255542
		[Token(Token = "0x403E636")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Act1VHalfIdleBattleFinishNormalView _normalView;

		// Token: 0x0403E637 RID: 255543
		[Token(Token = "0x403E637")]
		[FieldOffset(Offset = "0x40")]
		private Act1VHalfIdleBattleFinishViewModel m_viewModel;

		// Token: 0x0403E638 RID: 255544
		[Token(Token = "0x403E638")]
		[FieldOffset(Offset = "0x48")]
		private Act1VHalfIdleBattleFinishIncomeReplace m_incomeReplace;

		// Token: 0x0403E639 RID: 255545
		[Token(Token = "0x403E639")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x0403E63A RID: 255546
		[Token(Token = "0x403E63A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_ShowEnterEffectCoroutine;

		// Token: 0x0403E63B RID: 255547
		[Token(Token = "0x403E63B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__TrySavePassStageSquad;

		// Token: 0x0403E63C RID: 255548
		[Token(Token = "0x403E63C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__TrySavePassStagePlotSquad;

		// Token: 0x0403E63D RID: 255549
		[Token(Token = "0x403E63D")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__EventOnIncomeClick;

		// Token: 0x0403E63E RID: 255550
		[Token(Token = "0x403E63E")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__CloseIncomeView;

		// Token: 0x0403E63F RID: 255551
		[Token(Token = "0x403E63F")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
