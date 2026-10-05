using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.ActMultiV3
{
	// Token: 0x02006FE5 RID: 28645
	[Token(Token = "0x2006FE5")]
	public class ActMultiV3StageListDetailState : PopupFadeState, IValueMsgReceiver
	{
		// Token: 0x06028AF1 RID: 166641 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028AF1")]
		[Address(RVA = "0x2400190", Offset = "0x23FED90", VA = "0x182400190")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06028AF2 RID: 166642 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6028AF2")]
		[Address(RVA = "0x23FFB80", Offset = "0x23FE780", VA = "0x1823FFB80", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06028AF3 RID: 166643 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028AF3")]
		[Address(RVA = "0x23FFCE0", Offset = "0x23FE8E0", VA = "0x1823FFCE0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x06028AF4 RID: 166644 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6028AF4")]
		[Address(RVA = "0x2400030", Offset = "0x23FEC30", VA = "0x182400030", Slot = "10")]
		public override Dictionary<Type, Action<IStateBean>> RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x06028AF5 RID: 166645 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028AF5")]
		[Address(RVA = "0x2400600", Offset = "0x23FF200", VA = "0x182400600")]
		private void _OnJumpToEnemyHandbook(IStateBean stateBean)
		{
		}

		// Token: 0x06028AF6 RID: 166646 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028AF6")]
		[Address(RVA = "0x23FFE60", Offset = "0x23FEA60", VA = "0x1823FFE60", Slot = "31")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x06028AF7 RID: 166647 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028AF7")]
		[Address(RVA = "0x2400390", Offset = "0x23FEF90", VA = "0x182400390")]
		private void _OnBtnSwitchStageClicked(bool isRight)
		{
		}

		// Token: 0x06028AF8 RID: 166648 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028AF8")]
		[Address(RVA = "0x24002A0", Offset = "0x23FEEA0", VA = "0x1824002A0")]
		private void _OnBtnEnemyHandbookClicked()
		{
		}

		// Token: 0x06028AF9 RID: 166649 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028AF9")]
		[Address(RVA = "0x23FFBE0", Offset = "0x23FE7E0", VA = "0x1823FFBE0")]
		public void OnBackClicked()
		{
		}

		// Token: 0x06028AFA RID: 166650 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028AFA")]
		[Address(RVA = "0x24007F0", Offset = "0x23FF3F0", VA = "0x1824007F0")]
		public ActMultiV3StageListDetailState()
		{
		}

		// Token: 0x06028AFB RID: 166651 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028AFB")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x06028AFC RID: 166652 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6028AFC")]
		[Address(RVA = "0xE63480", Offset = "0xE62080", VA = "0x180E63480")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x04039F9A RID: 237466
		[Token(Token = "0x4039F9A")]
		[NonSerialized]
		public const int MSG_BTN_LEFT_CLICKED = 0;

		// Token: 0x04039F9B RID: 237467
		[Token(Token = "0x4039F9B")]
		[NonSerialized]
		public const int MSG_BTN_RIGHT_CLICKED = 1;

		// Token: 0x04039F9C RID: 237468
		[Token(Token = "0x4039F9C")]
		[NonSerialized]
		public const int MSG_BTN_ENEMY_HANDBOOK_CLICKED = 2;

		// Token: 0x04039F9D RID: 237469
		[Token(Token = "0x4039F9D")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private RectTransform _topMenuContainer;

		// Token: 0x04039F9E RID: 237470
		[Token(Token = "0x4039F9E")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private ActMultiV3StageListDetailView _view;

		// Token: 0x04039F9F RID: 237471
		[Token(Token = "0x4039F9F")]
		[FieldOffset(Offset = "0x80")]
		private bool m_inited;

		// Token: 0x04039FA0 RID: 237472
		[Token(Token = "0x4039FA0")]
		[FieldOffset(Offset = "0x88")]
		private ActMultiV3StageListDetailState.StateBean m_stateBean;

		// Token: 0x04039FA1 RID: 237473
		[Token(Token = "0x4039FA1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04039FA2 RID: 237474
		[Token(Token = "0x4039FA2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04039FA3 RID: 237475
		[Token(Token = "0x4039FA3")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04039FA4 RID: 237476
		[Token(Token = "0x4039FA4")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_RegisterToDataListener;

		// Token: 0x04039FA5 RID: 237477
		[Token(Token = "0x4039FA5")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnJumpToEnemyHandbook;

		// Token: 0x04039FA6 RID: 237478
		[Token(Token = "0x4039FA6")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x04039FA7 RID: 237479
		[Token(Token = "0x4039FA7")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__OnBtnSwitchStageClicked;

		// Token: 0x04039FA8 RID: 237480
		[Token(Token = "0x4039FA8")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__OnBtnEnemyHandbookClicked;

		// Token: 0x04039FA9 RID: 237481
		[Token(Token = "0x4039FA9")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnBackClicked;

		// Token: 0x04039FAA RID: 237482
		[Token(Token = "0x4039FAA")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006FE6 RID: 28646
		[Token(Token = "0x2006FE6")]
		public class StateBean : IStateBean, IHotfixable
		{
			// Token: 0x06028AFD RID: 166653 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6028AFD")]
			[Address(RVA = "0x2403BF0", Offset = "0x24027F0", VA = "0x182403BF0")]
			public StateBean()
			{
			}

			// Token: 0x04039FAB RID: 237483
			[Token(Token = "0x4039FAB")]
			[FieldOffset(Offset = "0x10")]
			public ActMultiV3StageDetailStateProperty property;

			// Token: 0x04039FAC RID: 237484
			[Token(Token = "0x4039FAC")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
