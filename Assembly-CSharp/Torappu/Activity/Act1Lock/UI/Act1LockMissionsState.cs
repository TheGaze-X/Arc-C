using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act1Lock.UI
{
	// Token: 0x0200788B RID: 30859
	[Token(Token = "0x200788B")]
	public class Act1LockMissionsState : PopupFadeState
	{
		// Token: 0x0602B41A RID: 177178 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B41A")]
		[Address(RVA = "0x270D330", Offset = "0x270BF30", VA = "0x18270D330", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0602B41B RID: 177179 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B41B")]
		[Address(RVA = "0x270D3A0", Offset = "0x270BFA0", VA = "0x18270D3A0", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x0602B41C RID: 177180 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B41C")]
		[Address(RVA = "0x270DAD0", Offset = "0x270C6D0", VA = "0x18270DAD0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602B41D RID: 177181 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B41D")]
		[Address(RVA = "0x270E030", Offset = "0x270CC30", VA = "0x18270E030")]
		private void _UpdateStatus()
		{
		}

		// Token: 0x0602B41E RID: 177182 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B41E")]
		[Address(RVA = "0x270D690", Offset = "0x270C290", VA = "0x18270D690")]
		private void _Get(string missionId)
		{
		}

		// Token: 0x0602B41F RID: 177183 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B41F")]
		[Address(RVA = "0x270D160", Offset = "0x270BD60", VA = "0x18270D160")]
		public void EventOnGetAll()
		{
		}

		// Token: 0x0602B420 RID: 177184 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B420")]
		[Address(RVA = "0x270D780", Offset = "0x270C380", VA = "0x18270D780")]
		private void _HandleGet(List<string> msIds)
		{
		}

		// Token: 0x0602B421 RID: 177185 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B421")]
		[Address(RVA = "0x270DF50", Offset = "0x270CB50", VA = "0x18270DF50")]
		private IEnumerator _ReceiveItemsCoroutine(List<RewardItemModel> rewardList, Action onConfirm)
		{
			return null;
		}

		// Token: 0x0602B422 RID: 177186 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B422")]
		[Address(RVA = "0x270D2D0", Offset = "0x270BED0", VA = "0x18270D2D0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0602B423 RID: 177187 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B423")]
		[Address(RVA = "0x270E570", Offset = "0x270D170", VA = "0x18270E570")]
		public Act1LockMissionsState()
		{
		}

		// Token: 0x0602B427 RID: 177191 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B427")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0602B428 RID: 177192 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B428")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x0403E851 RID: 256081
		[Token(Token = "0x403E851")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private RectTransform _topMenuContainer;

		// Token: 0x0403E852 RID: 256082
		[Token(Token = "0x403E852")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Act1LockMissionItem _itemPrefab;

		// Token: 0x0403E853 RID: 256083
		[Token(Token = "0x403E853")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Transform _listRoot;

		// Token: 0x0403E854 RID: 256084
		[Token(Token = "0x403E854")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Text _pointText;

		// Token: 0x0403E855 RID: 256085
		[Token(Token = "0x403E855")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Button _getBtn;

		// Token: 0x0403E856 RID: 256086
		[Token(Token = "0x403E856")]
		[FieldOffset(Offset = "0x98")]
		private List<Act1LockMissionItem> m_items;

		// Token: 0x0403E857 RID: 256087
		[Token(Token = "0x403E857")]
		[FieldOffset(Offset = "0xA0")]
		private List<Act1LockMissionItem.Mission> m_missions;

		// Token: 0x0403E858 RID: 256088
		[Token(Token = "0x403E858")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0403E859 RID: 256089
		[Token(Token = "0x403E859")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x0403E85A RID: 256090
		[Token(Token = "0x403E85A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403E85B RID: 256091
		[Token(Token = "0x403E85B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__UpdateStatus;

		// Token: 0x0403E85C RID: 256092
		[Token(Token = "0x403E85C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__Get;

		// Token: 0x0403E85D RID: 256093
		[Token(Token = "0x403E85D")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_EventOnGetAll;

		// Token: 0x0403E85E RID: 256094
		[Token(Token = "0x403E85E")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__HandleGet;

		// Token: 0x0403E85F RID: 256095
		[Token(Token = "0x403E85F")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__ReceiveItemsCoroutine;

		// Token: 0x0403E860 RID: 256096
		[Token(Token = "0x403E860")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0403E861 RID: 256097
		[Token(Token = "0x403E861")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
