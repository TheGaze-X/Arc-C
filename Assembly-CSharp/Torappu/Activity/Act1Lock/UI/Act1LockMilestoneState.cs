using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act1Lock.UI
{
	// Token: 0x02007888 RID: 30856
	[Token(Token = "0x2007888")]
	public class Act1LockMilestoneState : PopupFadeState
	{
		// Token: 0x0602B400 RID: 177152 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B400")]
		[Address(RVA = "0x270C1B0", Offset = "0x270ADB0", VA = "0x18270C1B0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0602B401 RID: 177153 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B401")]
		[Address(RVA = "0x270C220", Offset = "0x270AE20", VA = "0x18270C220", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x0602B402 RID: 177154 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B402")]
		[Address(RVA = "0x270C9F0", Offset = "0x270B5F0", VA = "0x18270C9F0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602B403 RID: 177155 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B403")]
		[Address(RVA = "0x270CE40", Offset = "0x270BA40", VA = "0x18270CE40")]
		private void _Refresh(bool afterGet)
		{
		}

		// Token: 0x0602B404 RID: 177156 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B404")]
		[Address(RVA = "0x270BE10", Offset = "0x270AA10", VA = "0x18270BE10")]
		public void EventOnGetAll()
		{
		}

		// Token: 0x0602B405 RID: 177157 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B405")]
		[Address(RVA = "0x270C3A0", Offset = "0x270AFA0", VA = "0x18270C3A0")]
		private void _Get(string milestoneId)
		{
		}

		// Token: 0x0602B406 RID: 177158 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B406")]
		[Address(RVA = "0x270C6F0", Offset = "0x270B2F0", VA = "0x18270C6F0")]
		private void _GotThem(List<ActivityItemModel> items)
		{
		}

		// Token: 0x0602B407 RID: 177159 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B407")]
		[Address(RVA = "0x270C280", Offset = "0x270AE80", VA = "0x18270C280")]
		public static IEnumerator ReceiveItemsCoroutine(List<ActivityItemModel> rewardList, UIGainItemFloatPanel.Style style = UIGainItemFloatPanel.Style.DEFAULT, [Optional] Action onConfirm)
		{
			return null;
		}

		// Token: 0x0602B408 RID: 177160 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B408")]
		[Address(RVA = "0x270C150", Offset = "0x270AD50", VA = "0x18270C150", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0602B409 RID: 177161 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B409")]
		[Address(RVA = "0x270D100", Offset = "0x270BD00", VA = "0x18270D100")]
		public Act1LockMilestoneState()
		{
		}

		// Token: 0x0602B40E RID: 177166 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B40E")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0602B40F RID: 177167 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B40F")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x0403E839 RID: 256057
		[Token(Token = "0x403E839")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private RectTransform _topMenuContainer;

		// Token: 0x0403E83A RID: 256058
		[Token(Token = "0x403E83A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Act1LockMilestoneItem _milestoneItemPrefab;

		// Token: 0x0403E83B RID: 256059
		[Token(Token = "0x403E83B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		private RectTransform _listRoot;

		// Token: 0x0403E83C RID: 256060
		[Token(Token = "0x403E83C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Text _pointCntText;

		// Token: 0x0403E83D RID: 256061
		[Token(Token = "0x403E83D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Button _getBtn;

		// Token: 0x0403E83E RID: 256062
		[Token(Token = "0x403E83E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private List<Act1LockMilestoneItem> m_items;

		// Token: 0x0403E83F RID: 256063
		[Token(Token = "0x403E83F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0403E840 RID: 256064
		[Token(Token = "0x403E840")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x0403E841 RID: 256065
		[Token(Token = "0x403E841")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403E842 RID: 256066
		[Token(Token = "0x403E842")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__Refresh;

		// Token: 0x0403E843 RID: 256067
		[Token(Token = "0x403E843")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_EventOnGetAll;

		// Token: 0x0403E844 RID: 256068
		[Token(Token = "0x403E844")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__Get;

		// Token: 0x0403E845 RID: 256069
		[Token(Token = "0x403E845")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__GotThem;

		// Token: 0x0403E846 RID: 256070
		[Token(Token = "0x403E846")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_ReceiveItemsCoroutine;

		// Token: 0x0403E847 RID: 256071
		[Token(Token = "0x403E847")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0403E848 RID: 256072
		[Token(Token = "0x403E848")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
