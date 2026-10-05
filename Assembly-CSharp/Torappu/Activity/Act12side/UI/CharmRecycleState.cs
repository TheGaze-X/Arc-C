using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act12side.UI
{
	// Token: 0x02007A7F RID: 31359
	[Token(Token = "0x2007A7F")]
	public class CharmRecycleState : PopupFadeState
	{
		// Token: 0x0602BEC2 RID: 179906 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BEC2")]
		[Address(RVA = "0x27E42C0", Offset = "0x27E2EC0", VA = "0x1827E42C0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0602BEC3 RID: 179907 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BEC3")]
		[Address(RVA = "0x27E4330", Offset = "0x27E2F30", VA = "0x1827E4330", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x0602BEC4 RID: 179908 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BEC4")]
		[Address(RVA = "0x27E4FB0", Offset = "0x27E3BB0", VA = "0x1827E4FB0")]
		private void _Refresh()
		{
		}

		// Token: 0x0602BEC5 RID: 179909 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BEC5")]
		[Address(RVA = "0x27E48F0", Offset = "0x27E34F0", VA = "0x1827E48F0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602BEC6 RID: 179910 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BEC6")]
		[Address(RVA = "0x27E59B0", Offset = "0x27E45B0", VA = "0x1827E59B0")]
		private void _TriggerRecycleDialog(int recyclePoints, bool isGacha = false)
		{
		}

		// Token: 0x0602BEC7 RID: 179911 RVA: 0x000DDAF0 File Offset: 0x000DBCF0
		[Token(Token = "0x602BEC7")]
		[Address(RVA = "0x27E4790", Offset = "0x27E3390", VA = "0x1827E4790")]
		private int _GetCoinNum(PlayerActivity.PlayerAct12sideActivity status)
		{
			return 0;
		}

		// Token: 0x0602BEC8 RID: 179912 RVA: 0x000DDB08 File Offset: 0x000DBD08
		[Token(Token = "0x602BEC8")]
		[Address(RVA = "0x27E4540", Offset = "0x27E3140", VA = "0x1827E4540")]
		private bool _CheckCanRecycle()
		{
			return default(bool);
		}

		// Token: 0x0602BEC9 RID: 179913 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602BEC9")]
		[Address(RVA = "0x27E4260", Offset = "0x27E2E60", VA = "0x1827E4260", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0602BECA RID: 179914 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BECA")]
		[Address(RVA = "0x27E4150", Offset = "0x27E2D50", VA = "0x1827E4150")]
		public void EventUpdateCurCoin()
		{
		}

		// Token: 0x0602BECB RID: 179915 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BECB")]
		[Address(RVA = "0x27E3CC0", Offset = "0x27E28C0", VA = "0x1827E3CC0")]
		public void EventOnRecycle()
		{
		}

		// Token: 0x0602BECC RID: 179916 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602BECC")]
		[Address(RVA = "0x27E4DE0", Offset = "0x27E39E0", VA = "0x1827E4DE0")]
		private IEnumerator _PlayRecycleAnim(List<RewardItemModel> coinReward, List<RewardItemModel> charmReward)
		{
			return null;
		}

		// Token: 0x0602BECD RID: 179917 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602BECD")]
		[Address(RVA = "0x27E4EE0", Offset = "0x27E3AE0", VA = "0x1827E4EE0")]
		private IEnumerator _ReceiveItemsCoroutine(List<RewardItemModel> rewardList, Action onConfirm)
		{
			return null;
		}

		// Token: 0x0602BECE RID: 179918 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BECE")]
		[Address(RVA = "0x27E3F00", Offset = "0x27E2B00", VA = "0x1827E3F00")]
		public void EventOnShop()
		{
		}

		// Token: 0x0602BECF RID: 179919 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BECF")]
		[Address(RVA = "0x27E40C0", Offset = "0x27E2CC0", VA = "0x1827E40C0")]
		public void EventOnShowRewardList()
		{
		}

		// Token: 0x0602BED0 RID: 179920 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602BED0")]
		[Address(RVA = "0x27E4820", Offset = "0x27E3420", VA = "0x1827E4820")]
		private string _GetTheActivityOpenedMe()
		{
			return null;
		}

		// Token: 0x0602BED1 RID: 179921 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602BED1")]
		[Address(RVA = "0x27E4640", Offset = "0x27E3240", VA = "0x1827E4640")]
		private Act12sideStageController _FindController()
		{
			return null;
		}

		// Token: 0x0602BED2 RID: 179922 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BED2")]
		[Address(RVA = "0x27E5BF0", Offset = "0x27E47F0", VA = "0x1827E5BF0")]
		public CharmRecycleState()
		{
		}

		// Token: 0x0602BED5 RID: 179925 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BED5")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0602BED6 RID: 179926 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BED6")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x0403F9E6 RID: 260582
		[Token(Token = "0x403F9E6")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private RectTransform _topMenuContainer;

		// Token: 0x0403F9E7 RID: 260583
		[Token(Token = "0x403F9E7")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private GameObject _recycle;

		// Token: 0x0403F9E8 RID: 260584
		[Token(Token = "0x403F9E8")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private RectTransform _listRoot;

		// Token: 0x0403F9E9 RID: 260585
		[Token(Token = "0x403F9E9")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private CharmCard _charmCardPrefab;

		// Token: 0x0403F9EA RID: 260586
		[Token(Token = "0x403F9EA")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private GameObject _bottom;

		// Token: 0x0403F9EB RID: 260587
		[Token(Token = "0x403F9EB")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Text _totalExchangeCoin;

		// Token: 0x0403F9EC RID: 260588
		[Token(Token = "0x403F9EC")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private GameObject[] _recycleTips;

		// Token: 0x0403F9ED RID: 260589
		[Token(Token = "0x403F9ED")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private GameObject _empty;

		// Token: 0x0403F9EE RID: 260590
		[Token(Token = "0x403F9EE")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private Text _curCoinNum;

		// Token: 0x0403F9EF RID: 260591
		[Token(Token = "0x403F9EF")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private CharmExchangeBar _exchangeBar;

		// Token: 0x0403F9F0 RID: 260592
		[Token(Token = "0x403F9F0")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private AnimationWrapper _animWrapper;

		// Token: 0x0403F9F1 RID: 260593
		[Token(Token = "0x403F9F1")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private Act12sideJunkdealerView _junkDealerView;

		// Token: 0x0403F9F2 RID: 260594
		[Token(Token = "0x403F9F2")]
		private const string ANIM_TIP_FADEOUT = "recycle_tip_fadeout";

		// Token: 0x0403F9F3 RID: 260595
		[Token(Token = "0x403F9F3")]
		private const string ANIM_SWITCH_EMPTY = "recycle_switch_empty";

		// Token: 0x0403F9F4 RID: 260596
		[Token(Token = "0x403F9F4")]
		[FieldOffset(Offset = "0xD0")]
		private List<CharmModel> m_charmModels;

		// Token: 0x0403F9F5 RID: 260597
		[Token(Token = "0x403F9F5")]
		[FieldOffset(Offset = "0xD8")]
		private List<CharmCard> m_items;

		// Token: 0x0403F9F6 RID: 260598
		[Token(Token = "0x403F9F6")]
		[FieldOffset(Offset = "0xE0")]
		private string m_activity;

		// Token: 0x0403F9F7 RID: 260599
		[Token(Token = "0x403F9F7")]
		[FieldOffset(Offset = "0xE8")]
		private Act12SideData m_actData;

		// Token: 0x0403F9F8 RID: 260600
		[Token(Token = "0x403F9F8")]
		[FieldOffset(Offset = "0xF0")]
		private int m_nextStack;

		// Token: 0x0403F9F9 RID: 260601
		[Token(Token = "0x403F9F9")]
		[FieldOffset(Offset = "0xF4")]
		private int m_rewardThreshold;

		// Token: 0x0403F9FA RID: 260602
		[Token(Token = "0x403F9FA")]
		[FieldOffset(Offset = "0xF8")]
		private bool m_recycling;

		// Token: 0x0403F9FB RID: 260603
		[Token(Token = "0x403F9FB")]
		[FieldOffset(Offset = "0xF9")]
		private bool m_refreshedOnEnter;

		// Token: 0x0403F9FC RID: 260604
		[Token(Token = "0x403F9FC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0403F9FD RID: 260605
		[Token(Token = "0x403F9FD")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x0403F9FE RID: 260606
		[Token(Token = "0x403F9FE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__Refresh;

		// Token: 0x0403F9FF RID: 260607
		[Token(Token = "0x403F9FF")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403FA00 RID: 260608
		[Token(Token = "0x403FA00")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__TriggerRecycleDialog;

		// Token: 0x0403FA01 RID: 260609
		[Token(Token = "0x403FA01")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__GetCoinNum;

		// Token: 0x0403FA02 RID: 260610
		[Token(Token = "0x403FA02")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__CheckCanRecycle;

		// Token: 0x0403FA03 RID: 260611
		[Token(Token = "0x403FA03")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0403FA04 RID: 260612
		[Token(Token = "0x403FA04")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_EventUpdateCurCoin;

		// Token: 0x0403FA05 RID: 260613
		[Token(Token = "0x403FA05")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_EventOnRecycle;

		// Token: 0x0403FA06 RID: 260614
		[Token(Token = "0x403FA06")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__PlayRecycleAnim;

		// Token: 0x0403FA07 RID: 260615
		[Token(Token = "0x403FA07")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__ReceiveItemsCoroutine;

		// Token: 0x0403FA08 RID: 260616
		[Token(Token = "0x403FA08")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_EventOnShop;

		// Token: 0x0403FA09 RID: 260617
		[Token(Token = "0x403FA09")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_EventOnShowRewardList;

		// Token: 0x0403FA0A RID: 260618
		[Token(Token = "0x403FA0A")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__GetTheActivityOpenedMe;

		// Token: 0x0403FA0B RID: 260619
		[Token(Token = "0x403FA0B")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__FindController;

		// Token: 0x0403FA0C RID: 260620
		[Token(Token = "0x403FA0C")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
