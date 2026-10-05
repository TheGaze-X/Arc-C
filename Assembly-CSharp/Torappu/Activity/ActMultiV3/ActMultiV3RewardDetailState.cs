using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.ActMultiV3
{
	// Token: 0x02006F33 RID: 28467
	[Token(Token = "0x2006F33")]
	public class ActMultiV3RewardDetailState : PopupFloatState
	{
		// Token: 0x060286EC RID: 165612 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60286EC")]
		[Address(RVA = "0x23BAEB0", Offset = "0x23B9AB0", VA = "0x1823BAEB0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060286ED RID: 165613 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60286ED")]
		[Address(RVA = "0x23BADA0", Offset = "0x23B99A0", VA = "0x1823BADA0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x060286EE RID: 165614 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60286EE")]
		[Address(RVA = "0x23BAC40", Offset = "0x23B9840", VA = "0x1823BAC40", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x060286EF RID: 165615 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60286EF")]
		[Address(RVA = "0x23BACA0", Offset = "0x23B98A0", VA = "0x1823BACA0")]
		public void OnBackClicked()
		{
		}

		// Token: 0x060286F0 RID: 165616 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60286F0")]
		[Address(RVA = "0x23BAF50", Offset = "0x23B9B50", VA = "0x1823BAF50")]
		public ActMultiV3RewardDetailState()
		{
		}

		// Token: 0x060286F1 RID: 165617 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60286F1")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x04039832 RID: 235570
		[Token(Token = "0x4039832")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private ActMultiV3RewardDetailView _view;

		// Token: 0x04039833 RID: 235571
		[Token(Token = "0x4039833")]
		[FieldOffset(Offset = "0x78")]
		private ActMultiV3RewardDetailState.StateBean m_stateBean;

		// Token: 0x04039834 RID: 235572
		[Token(Token = "0x4039834")]
		[FieldOffset(Offset = "0x80")]
		private bool m_inited;

		// Token: 0x04039835 RID: 235573
		[Token(Token = "0x4039835")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04039836 RID: 235574
		[Token(Token = "0x4039836")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04039837 RID: 235575
		[Token(Token = "0x4039837")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04039838 RID: 235576
		[Token(Token = "0x4039838")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnBackClicked;

		// Token: 0x04039839 RID: 235577
		[Token(Token = "0x4039839")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006F34 RID: 28468
		[Token(Token = "0x2006F34")]
		public class StateBean : IStateBean, IHotfixable
		{
			// Token: 0x060286F2 RID: 165618 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60286F2")]
			[Address(RVA = "0x23BCC90", Offset = "0x23BB890", VA = "0x1823BCC90")]
			public StateBean()
			{
			}

			// Token: 0x0403983A RID: 235578
			[Token(Token = "0x403983A")]
			[FieldOffset(Offset = "0x10")]
			public ActMultiV3RewardDetailProperty property;

			// Token: 0x0403983B RID: 235579
			[Token(Token = "0x403983B")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
