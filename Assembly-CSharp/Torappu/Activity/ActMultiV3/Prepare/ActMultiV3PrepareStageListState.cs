using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.ActMultiV3.Prepare
{
	// Token: 0x02007083 RID: 28803
	[Token(Token = "0x2007083")]
	public class ActMultiV3PrepareStageListState : ActMultiV3StageListViewState
	{
		// Token: 0x06028EB0 RID: 167600 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028EB0")]
		[Address(RVA = "0x2460F90", Offset = "0x245FB90", VA = "0x182460F90")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06028EB1 RID: 167601 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6028EB1")]
		[Address(RVA = "0x2460950", Offset = "0x245F550", VA = "0x182460950", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06028EB2 RID: 167602 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028EB2")]
		[Address(RVA = "0x2460B40", Offset = "0x245F740", VA = "0x182460B40", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x06028EB3 RID: 167603 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028EB3")]
		[Address(RVA = "0x2460BE0", Offset = "0x245F7E0", VA = "0x182460BE0", Slot = "34")]
		public override void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x06028EB4 RID: 167604 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028EB4")]
		[Address(RVA = "0x24609B0", Offset = "0x245F5B0", VA = "0x1824609B0", Slot = "35")]
		public override void HandleCallBack(int instId, ValueBundle output)
		{
		}

		// Token: 0x06028EB5 RID: 167605 RVA: 0x000D3968 File Offset: 0x000D1B68
		[Token(Token = "0x6028EB5")]
		[Address(RVA = "0x2460ED0", Offset = "0x245FAD0", VA = "0x182460ED0")]
		private bool _CheckUIStable()
		{
			return default(bool);
		}

		// Token: 0x06028EB6 RID: 167606 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028EB6")]
		[Address(RVA = "0x24615E0", Offset = "0x24601E0", VA = "0x1824615E0")]
		private void _OnTabClicked(long msg)
		{
		}

		// Token: 0x06028EB7 RID: 167607 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028EB7")]
		[Address(RVA = "0x2461370", Offset = "0x245FF70", VA = "0x182461370")]
		private void _OnStageClicked(string stageId)
		{
		}

		// Token: 0x06028EB8 RID: 167608 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028EB8")]
		[Address(RVA = "0x2461190", Offset = "0x245FD90", VA = "0x182461190")]
		private void _OnBtnInfoClicked()
		{
		}

		// Token: 0x06028EB9 RID: 167609 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028EB9")]
		[Address(RVA = "0x2460A40", Offset = "0x245F640", VA = "0x182460A40")]
		public void OnBackClicked()
		{
		}

		// Token: 0x06028EBA RID: 167610 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028EBA")]
		[Address(RVA = "0x24616D0", Offset = "0x24602D0", VA = "0x1824616D0")]
		public ActMultiV3PrepareStageListState()
		{
		}

		// Token: 0x06028EBB RID: 167611 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028EBB")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0403A603 RID: 239107
		[Token(Token = "0x403A603")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private RectTransform _viewHolder;

		// Token: 0x0403A604 RID: 239108
		[Token(Token = "0x403A604")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private RectTransform _backPressRt;

		// Token: 0x0403A605 RID: 239109
		[Token(Token = "0x403A605")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private ActMultiV3StageListView _viewPrefab;

		// Token: 0x0403A606 RID: 239110
		[Token(Token = "0x403A606")]
		[FieldOffset(Offset = "0x88")]
		private bool m_inited;

		// Token: 0x0403A607 RID: 239111
		[Token(Token = "0x403A607")]
		[FieldOffset(Offset = "0x90")]
		private ActMultiV3StageListView m_view;

		// Token: 0x0403A608 RID: 239112
		[Token(Token = "0x403A608")]
		[FieldOffset(Offset = "0x98")]
		private ActMultiV3PrepareStageListState.StateBean m_stateBean;

		// Token: 0x0403A609 RID: 239113
		[Token(Token = "0x403A609")]
		[FieldOffset(Offset = "0xA0")]
		private UICompDialogMgr m_dialogMgr;

		// Token: 0x0403A60A RID: 239114
		[Token(Token = "0x403A60A")]
		[FieldOffset(Offset = "0xA8")]
		private int m_infoDialogInst;

		// Token: 0x0403A60B RID: 239115
		[Token(Token = "0x403A60B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403A60C RID: 239116
		[Token(Token = "0x403A60C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0403A60D RID: 239117
		[Token(Token = "0x403A60D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0403A60E RID: 239118
		[Token(Token = "0x403A60E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x0403A60F RID: 239119
		[Token(Token = "0x403A60F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_HandleCallBack;

		// Token: 0x0403A610 RID: 239120
		[Token(Token = "0x403A610")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__CheckUIStable;

		// Token: 0x0403A611 RID: 239121
		[Token(Token = "0x403A611")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__OnTabClicked;

		// Token: 0x0403A612 RID: 239122
		[Token(Token = "0x403A612")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__OnStageClicked;

		// Token: 0x0403A613 RID: 239123
		[Token(Token = "0x403A613")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__OnBtnInfoClicked;

		// Token: 0x0403A614 RID: 239124
		[Token(Token = "0x403A614")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnBackClicked;

		// Token: 0x0403A615 RID: 239125
		[Token(Token = "0x403A615")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02007084 RID: 28804
		[Token(Token = "0x2007084")]
		public class StateBean : IStateBean, IHotfixable
		{
			// Token: 0x06028EBC RID: 167612 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6028EBC")]
			[Address(RVA = "0x24625F0", Offset = "0x24611F0", VA = "0x1824625F0")]
			public StateBean()
			{
			}

			// Token: 0x0403A616 RID: 239126
			[Token(Token = "0x403A616")]
			[FieldOffset(Offset = "0x10")]
			public ActMultiV3StageListProperty property;

			// Token: 0x0403A617 RID: 239127
			[Token(Token = "0x403A617")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
