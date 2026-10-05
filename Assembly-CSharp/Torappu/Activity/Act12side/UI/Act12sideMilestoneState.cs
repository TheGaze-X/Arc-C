using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act12side.UI
{
	// Token: 0x02007A96 RID: 31382
	[Token(Token = "0x2007A96")]
	public class Act12sideMilestoneState : Act12sideGenericState
	{
		// Token: 0x0602BF65 RID: 180069 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BF65")]
		[Address(RVA = "0x27DD520", Offset = "0x27DC120", VA = "0x1827DD520", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0602BF66 RID: 180070 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BF66")]
		[Address(RVA = "0x27DD650", Offset = "0x27DC250", VA = "0x1827DD650", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x0602BF67 RID: 180071 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BF67")]
		[Address(RVA = "0x27DD0C0", Offset = "0x27DBCC0", VA = "0x1827DD0C0", Slot = "31")]
		protected override void InitIfNot()
		{
		}

		// Token: 0x0602BF68 RID: 180072 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602BF68")]
		[Address(RVA = "0x27DD060", Offset = "0x27DBC60", VA = "0x1827DD060", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0602BF69 RID: 180073 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602BF69")]
		[Address(RVA = "0x27DD6D0", Offset = "0x27DC2D0", VA = "0x1827DD6D0", Slot = "10")]
		public override Dictionary<Type, Action<IStateBean>> RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x0602BF6A RID: 180074 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BF6A")]
		[Address(RVA = "0x27DD840", Offset = "0x27DC440", VA = "0x1827DD840")]
		private void _OnJumpToPhotoState(IStateBean stateBean)
		{
		}

		// Token: 0x0602BF6B RID: 180075 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BF6B")]
		[Address(RVA = "0x27DDBC0", Offset = "0x27DC7C0", VA = "0x1827DDBC0")]
		private void _OnPhotoClick(Act12SideData.PhotoInfo photoInfo)
		{
		}

		// Token: 0x0602BF6C RID: 180076 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BF6C")]
		[Address(RVA = "0x27DD940", Offset = "0x27DC540", VA = "0x1827DD940")]
		private void _OnMilestoneClick(string milestoneId)
		{
		}

		// Token: 0x0602BF6D RID: 180077 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BF6D")]
		[Address(RVA = "0x27DDC70", Offset = "0x27DC870", VA = "0x1827DDC70")]
		private void _OnRewardAllMilestoneClick()
		{
		}

		// Token: 0x0602BF6E RID: 180078 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BF6E")]
		[Address(RVA = "0x27DE010", Offset = "0x27DCC10", VA = "0x1827DE010")]
		private void _OnRewardMilestoneSuc(ActivityRewardMilestoneResponse response)
		{
		}

		// Token: 0x0602BF6F RID: 180079 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BF6F")]
		[Address(RVA = "0x27DDF70", Offset = "0x27DCB70", VA = "0x1827DDF70")]
		private void _OnRewardAllMilestoneSuc(ActivityRewardAllMilestoneResponse response)
		{
		}

		// Token: 0x0602BF70 RID: 180080 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BF70")]
		[Address(RVA = "0x27DE160", Offset = "0x27DCD60", VA = "0x1827DE160")]
		private void _RefreshMilestoneStatus()
		{
		}

		// Token: 0x0602BF71 RID: 180081 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602BF71")]
		[Address(RVA = "0x27DE0B0", Offset = "0x27DCCB0", VA = "0x1827DE0B0")]
		private IEnumerator _ReceiveItemsCoroutine(List<RewardItemModel> rewardList)
		{
			return null;
		}

		// Token: 0x0602BF72 RID: 180082 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BF72")]
		[Address(RVA = "0x27DD490", Offset = "0x27DC090", VA = "0x1827DD490")]
		public void OnBtnMissionClick()
		{
		}

		// Token: 0x0602BF73 RID: 180083 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BF73")]
		[Address(RVA = "0x27DE2A0", Offset = "0x27DCEA0", VA = "0x1827DE2A0")]
		public Act12sideMilestoneState()
		{
		}

		// Token: 0x0602BF74 RID: 180084 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BF74")]
		[Address(RVA = "0x27DD830", Offset = "0x27DC430", VA = "0x1827DD830")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0602BF75 RID: 180085 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BF75")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x0602BF76 RID: 180086 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BF76")]
		[Address(RVA = "0x27DA570", Offset = "0x27D9170", VA = "0x1827DA570")]
		private void <>xLuaBaseProxy_InitIfNot()
		{
		}

		// Token: 0x0602BF77 RID: 180087 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602BF77")]
		[Address(RVA = "0xE63480", Offset = "0xE62080", VA = "0x180E63480")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x0403FAE4 RID: 260836
		[Token(Token = "0x403FAE4")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Act12sideMilestoneView _view;

		// Token: 0x0403FAE5 RID: 260837
		[Token(Token = "0x403FAE5")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private UICommonTrackPoint _missionTrackPoint;

		// Token: 0x0403FAE6 RID: 260838
		[Token(Token = "0x403FAE6")]
		[FieldOffset(Offset = "0x98")]
		private Act12SideData.PhotoInfo m_bufferedPhotoInfo;

		// Token: 0x0403FAE7 RID: 260839
		[Token(Token = "0x403FAE7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0403FAE8 RID: 260840
		[Token(Token = "0x403FAE8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x0403FAE9 RID: 260841
		[Token(Token = "0x403FAE9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_InitIfNot;

		// Token: 0x0403FAEA RID: 260842
		[Token(Token = "0x403FAEA")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0403FAEB RID: 260843
		[Token(Token = "0x403FAEB")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_RegisterToDataListener;

		// Token: 0x0403FAEC RID: 260844
		[Token(Token = "0x403FAEC")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnJumpToPhotoState;

		// Token: 0x0403FAED RID: 260845
		[Token(Token = "0x403FAED")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__OnPhotoClick;

		// Token: 0x0403FAEE RID: 260846
		[Token(Token = "0x403FAEE")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__OnMilestoneClick;

		// Token: 0x0403FAEF RID: 260847
		[Token(Token = "0x403FAEF")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__OnRewardAllMilestoneClick;

		// Token: 0x0403FAF0 RID: 260848
		[Token(Token = "0x403FAF0")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__OnRewardMilestoneSuc;

		// Token: 0x0403FAF1 RID: 260849
		[Token(Token = "0x403FAF1")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__OnRewardAllMilestoneSuc;

		// Token: 0x0403FAF2 RID: 260850
		[Token(Token = "0x403FAF2")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__RefreshMilestoneStatus;

		// Token: 0x0403FAF3 RID: 260851
		[Token(Token = "0x403FAF3")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__ReceiveItemsCoroutine;

		// Token: 0x0403FAF4 RID: 260852
		[Token(Token = "0x403FAF4")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_OnBtnMissionClick;

		// Token: 0x0403FAF5 RID: 260853
		[Token(Token = "0x403FAF5")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
