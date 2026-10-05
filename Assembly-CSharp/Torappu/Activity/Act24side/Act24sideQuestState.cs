using System;
using System.Collections.Generic;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act24side
{
	// Token: 0x02007605 RID: 30213
	[Token(Token = "0x2007605")]
	public class Act24sideQuestState : State, IValueMsgReceiver, ICompDialogCallBack
	{
		// Token: 0x0602A886 RID: 174214 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A886")]
		[Address(RVA = "0x2630C20", Offset = "0x262F820", VA = "0x182630C20", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0602A887 RID: 174215 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A887")]
		[Address(RVA = "0x2630E20", Offset = "0x262FA20", VA = "0x182630E20", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0602A888 RID: 174216 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A888")]
		[Address(RVA = "0x26314C0", Offset = "0x26300C0", VA = "0x1826314C0", Slot = "10")]
		public override Dictionary<Type, Action<IStateBean>> RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x0602A889 RID: 174217 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A889")]
		[Address(RVA = "0x2631A70", Offset = "0x2630670", VA = "0x182631A70")]
		private void _OnJumpToEnemyHandbook(IStateBean stateBean)
		{
		}

		// Token: 0x0602A88A RID: 174218 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A88A")]
		[Address(RVA = "0x26320D0", Offset = "0x2630CD0", VA = "0x1826320D0")]
		private void _OnJumpToRewardDetailView(IStateBean stateBean)
		{
		}

		// Token: 0x0602A88B RID: 174219 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A88B")]
		[Address(RVA = "0x2631250", Offset = "0x262FE50", VA = "0x182631250", Slot = "23")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x0602A88C RID: 174220 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A88C")]
		[Address(RVA = "0x2632240", Offset = "0x2630E40", VA = "0x182632240")]
		private void _OnQuestItemClick(string strVal)
		{
		}

		// Token: 0x0602A88D RID: 174221 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A88D")]
		[Address(RVA = "0x2632320", Offset = "0x2630F20", VA = "0x182632320")]
		private void _OnQuestMultiBattleClicked()
		{
		}

		// Token: 0x0602A88E RID: 174222 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A88E")]
		[Address(RVA = "0x2632420", Offset = "0x2631020", VA = "0x182632420")]
		private void _OnQuestMultiBattleTimesSelectionClicked()
		{
		}

		// Token: 0x0602A88F RID: 174223 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A88F")]
		[Address(RVA = "0x2631920", Offset = "0x2630520", VA = "0x182631920")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602A890 RID: 174224 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A890")]
		[Address(RVA = "0x2632810", Offset = "0x2631410", VA = "0x182632810")]
		private void _OpenSquad(string actId, Act24sideQuestStageItemModel model, bool isPractice)
		{
		}

		// Token: 0x0602A891 RID: 174225 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A891")]
		[Address(RVA = "0x2631830", Offset = "0x2630430", VA = "0x182631830")]
		private void _HandleMultiBattleTimesSelection(int times)
		{
		}

		// Token: 0x0602A892 RID: 174226 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A892")]
		[Address(RVA = "0x2630C80", Offset = "0x262F880", VA = "0x182630C80", Slot = "24")]
		public void HandleCallBack(int instId, ValueBundle output)
		{
		}

		// Token: 0x0602A893 RID: 174227 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A893")]
		[Address(RVA = "0x2630410", Offset = "0x262F010", VA = "0x182630410")]
		public void EventOnBtnExit()
		{
		}

		// Token: 0x0602A894 RID: 174228 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A894")]
		[Address(RVA = "0x2630500", Offset = "0x262F100", VA = "0x182630500")]
		public void EventOnBtnMap()
		{
		}

		// Token: 0x0602A895 RID: 174229 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A895")]
		[Address(RVA = "0x26302C0", Offset = "0x262EEC0", VA = "0x1826302C0")]
		public void EventOnBtnEnemy()
		{
		}

		// Token: 0x0602A896 RID: 174230 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A896")]
		[Address(RVA = "0x2630B30", Offset = "0x262F730", VA = "0x182630B30")]
		public void EventOnRewardDetail()
		{
		}

		// Token: 0x0602A897 RID: 174231 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A897")]
		[Address(RVA = "0x2630890", Offset = "0x262F490", VA = "0x182630890")]
		public void EventOnBtnStart()
		{
		}

		// Token: 0x0602A898 RID: 174232 RVA: 0x000D8DB0 File Offset: 0x000D6FB0
		[Token(Token = "0x602A898")]
		[Address(RVA = "0x2631690", Offset = "0x2630290", VA = "0x182631690")]
		private bool _CheckCostBeforeStartBattle(Act24sideQuestStageItemModel questItemModel)
		{
			return default(bool);
		}

		// Token: 0x0602A899 RID: 174233 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A899")]
		[Address(RVA = "0x2630750", Offset = "0x262F350", VA = "0x182630750")]
		public void EventOnBtnPractice()
		{
		}

		// Token: 0x0602A89A RID: 174234 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A89A")]
		[Address(RVA = "0x2632CE0", Offset = "0x26318E0", VA = "0x182632CE0")]
		public Act24sideQuestState()
		{
		}

		// Token: 0x0602A89B RID: 174235 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A89B")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0602A89C RID: 174236 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A89C")]
		[Address(RVA = "0xE63480", Offset = "0xE62080", VA = "0x180E63480")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x0403D3AB RID: 250795
		[Token(Token = "0x403D3AB")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Act24sideQuestView _view;

		// Token: 0x0403D3AC RID: 250796
		[Token(Token = "0x403D3AC")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private RectTransform _btnExitRt;

		// Token: 0x0403D3AD RID: 250797
		[Token(Token = "0x403D3AD")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private UIAnimationLocation _animEnter;

		// Token: 0x0403D3AE RID: 250798
		[Token(Token = "0x403D3AE")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Act24sideStageMapPreviewPluginView _mapPreviewPrefab;

		// Token: 0x0403D3AF RID: 250799
		[Token(Token = "0x403D3AF")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private RectTransform _mapPreviewContainer;

		// Token: 0x0403D3B0 RID: 250800
		[Token(Token = "0x403D3B0")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Vector2 _dialogOffset;

		// Token: 0x0403D3B1 RID: 250801
		[Token(Token = "0x403D3B1")]
		[NonSerialized]
		public const int MSG_QUEST_CLICK = 1;

		// Token: 0x0403D3B2 RID: 250802
		[Token(Token = "0x403D3B2")]
		[NonSerialized]
		public const int MSG_QUEST_MULTI_BATTLE_CLICK = 2;

		// Token: 0x0403D3B3 RID: 250803
		[Token(Token = "0x403D3B3")]
		[NonSerialized]
		public const int MSG_QUEST_MULTI_BATTLE_TIMES_SELECTION_CLICK = 3;

		// Token: 0x0403D3B4 RID: 250804
		[Token(Token = "0x403D3B4")]
		[FieldOffset(Offset = "0x88")]
		private bool m_hasInited;

		// Token: 0x0403D3B5 RID: 250805
		[Token(Token = "0x403D3B5")]
		[FieldOffset(Offset = "0x90")]
		private Act24sideQuestStateBean m_stateBean;

		// Token: 0x0403D3B6 RID: 250806
		[Token(Token = "0x403D3B6")]
		[FieldOffset(Offset = "0x98")]
		private Act24sideStageMapPreviewPluginView m_mapPreview;

		// Token: 0x0403D3B7 RID: 250807
		[Token(Token = "0x403D3B7")]
		[FieldOffset(Offset = "0xA0")]
		private Tween m_enterTween;

		// Token: 0x0403D3B8 RID: 250808
		[Token(Token = "0x403D3B8")]
		[FieldOffset(Offset = "0xA8")]
		private int m_multipleBattleDialogInstId;

		// Token: 0x0403D3B9 RID: 250809
		[Token(Token = "0x403D3B9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0403D3BA RID: 250810
		[Token(Token = "0x403D3BA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0403D3BB RID: 250811
		[Token(Token = "0x403D3BB")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_RegisterToDataListener;

		// Token: 0x0403D3BC RID: 250812
		[Token(Token = "0x403D3BC")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnJumpToEnemyHandbook;

		// Token: 0x0403D3BD RID: 250813
		[Token(Token = "0x403D3BD")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnJumpToRewardDetailView;

		// Token: 0x0403D3BE RID: 250814
		[Token(Token = "0x403D3BE")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x0403D3BF RID: 250815
		[Token(Token = "0x403D3BF")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__OnQuestItemClick;

		// Token: 0x0403D3C0 RID: 250816
		[Token(Token = "0x403D3C0")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__OnQuestMultiBattleClicked;

		// Token: 0x0403D3C1 RID: 250817
		[Token(Token = "0x403D3C1")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__OnQuestMultiBattleTimesSelectionClicked;

		// Token: 0x0403D3C2 RID: 250818
		[Token(Token = "0x403D3C2")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403D3C3 RID: 250819
		[Token(Token = "0x403D3C3")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__OpenSquad;

		// Token: 0x0403D3C4 RID: 250820
		[Token(Token = "0x403D3C4")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__HandleMultiBattleTimesSelection;

		// Token: 0x0403D3C5 RID: 250821
		[Token(Token = "0x403D3C5")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_HandleCallBack;

		// Token: 0x0403D3C6 RID: 250822
		[Token(Token = "0x403D3C6")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_EventOnBtnExit;

		// Token: 0x0403D3C7 RID: 250823
		[Token(Token = "0x403D3C7")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_EventOnBtnMap;

		// Token: 0x0403D3C8 RID: 250824
		[Token(Token = "0x403D3C8")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_EventOnBtnEnemy;

		// Token: 0x0403D3C9 RID: 250825
		[Token(Token = "0x403D3C9")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_EventOnRewardDetail;

		// Token: 0x0403D3CA RID: 250826
		[Token(Token = "0x403D3CA")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_EventOnBtnStart;

		// Token: 0x0403D3CB RID: 250827
		[Token(Token = "0x403D3CB")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__CheckCostBeforeStartBattle;

		// Token: 0x0403D3CC RID: 250828
		[Token(Token = "0x403D3CC")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_EventOnBtnPractice;

		// Token: 0x0403D3CD RID: 250829
		[Token(Token = "0x403D3CD")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
