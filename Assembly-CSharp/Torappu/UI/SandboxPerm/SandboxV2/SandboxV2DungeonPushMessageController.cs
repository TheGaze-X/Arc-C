using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x020041E6 RID: 16870
	[Token(Token = "0x20041E6")]
	public class SandboxV2DungeonPushMessageController : PageSingleComponent, ICompDialogCallBack
	{
		// Token: 0x0601A06B RID: 106603 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A06B")]
		[Address(RVA = "0x12F0770", Offset = "0x12EF370", VA = "0x1812F0770", Slot = "5")]
		protected override void OnCreate()
		{
		}

		// Token: 0x0601A06C RID: 106604 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A06C")]
		[Address(RVA = "0x12F0F90", Offset = "0x12EFB90", VA = "0x1812F0F90")]
		private void Update()
		{
		}

		// Token: 0x0601A06D RID: 106605 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A06D")]
		[Address(RVA = "0x12F0910", Offset = "0x12EF510", VA = "0x1812F0910", Slot = "11")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x0601A06E RID: 106606 RVA: 0x000A00F8 File Offset: 0x0009E2F8
		[Token(Token = "0x601A06E")]
		[Address(RVA = "0x12F0D90", Offset = "0x12EF990", VA = "0x1812F0D90")]
		public bool TutorialOnly_IsDungeonStable()
		{
			return default(bool);
		}

		// Token: 0x0601A06F RID: 106607 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A06F")]
		[Address(RVA = "0x12EFA10", Offset = "0x12EE610", VA = "0x1812EFA10", Slot = "12")]
		public void HandleCallBack(int instId, ValueBundle output)
		{
		}

		// Token: 0x0601A070 RID: 106608 RVA: 0x000A0110 File Offset: 0x0009E310
		[Token(Token = "0x601A070")]
		[Address(RVA = "0x12F0600", Offset = "0x12EF200", VA = "0x1812F0600")]
		public bool IsInDungeonAndStable()
		{
			return default(bool);
		}

		// Token: 0x0601A071 RID: 106609 RVA: 0x000A0128 File Offset: 0x0009E328
		[Token(Token = "0x601A071")]
		[Address(RVA = "0x12EF570", Offset = "0x12EE170", VA = "0x1812EF570")]
		public bool CheckFrontStateCanShowMonthMsg()
		{
			return default(bool);
		}

		// Token: 0x0601A072 RID: 106610 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A072")]
		[Address(RVA = "0x12F0C60", Offset = "0x12EF860", VA = "0x1812F0C60")]
		public void TutorialOnly_HandleGuideStartPushMsg(SandboxV2DungeonGuideStartMsg msg)
		{
		}

		// Token: 0x0601A073 RID: 106611 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A073")]
		[Address(RVA = "0x12EFDA0", Offset = "0x12EE9A0", VA = "0x1812EFDA0")]
		public void HandleMonthRewardPushMsg(List<ItemGet> rewards)
		{
		}

		// Token: 0x0601A074 RID: 106612 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A074")]
		[Address(RVA = "0x12EFF50", Offset = "0x12EEB50", VA = "0x1812EFF50")]
		public void HandleNotifyDialogMsg(string id, SandboxV2DungeonDialogShowType showType, SandboxV2DungeonDialogQuestProcessType questProcessType = SandboxV2DungeonDialogQuestProcessType.NONE)
		{
		}

		// Token: 0x0601A075 RID: 106613 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A075")]
		[Address(RVA = "0x12F0060", Offset = "0x12EEC60", VA = "0x1812F0060")]
		public void HandleQuestFinishMsgWithToast(List<string> questIds)
		{
		}

		// Token: 0x0601A076 RID: 106614 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A076")]
		[Address(RVA = "0x12F0330", Offset = "0x12EEF30", VA = "0x1812F0330")]
		public void HandleRiftSubFinishMsgWithToast(List<string> subTargetIds)
		{
		}

		// Token: 0x0601A077 RID: 106615 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A077")]
		[Address(RVA = "0x12EFB60", Offset = "0x12EE760", VA = "0x1812EFB60")]
		public void HandleCraftUnlockMsgWithToast(List<string> itemIds)
		{
		}

		// Token: 0x0601A078 RID: 106616 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A078")]
		[Address(RVA = "0x12EF740", Offset = "0x12EE340", VA = "0x1812EF740")]
		public void HandleAchievementWithToast(List<string> achievementIds)
		{
		}

		// Token: 0x0601A079 RID: 106617 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A079")]
		[Address(RVA = "0x12F1050", Offset = "0x12EFC50", VA = "0x1812F1050")]
		public void Watch(SandboxV2DungeonPushMessageElement element, HashSet<SandboxV2DungeonPushMessageObservableType> observableTypes)
		{
		}

		// Token: 0x0601A07A RID: 106618 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A07A")]
		[Address(RVA = "0x12F0E20", Offset = "0x12EFA20", VA = "0x1812F0E20")]
		public void UnWatch(SandboxV2DungeonPushMessageElement element)
		{
		}

		// Token: 0x0601A07B RID: 106619 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A07B")]
		[Address(RVA = "0x12F09A0", Offset = "0x12EF5A0", VA = "0x1812F09A0")]
		public void SetShowStatus(bool isShow, bool isFastMode, SandboxV2DungeonPushMessageObservableType monoType, [Optional] object param)
		{
		}

		// Token: 0x0601A07C RID: 106620 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A07C")]
		[Address(RVA = "0x12F1470", Offset = "0x12F0070", VA = "0x1812F1470")]
		private void _InitController()
		{
		}

		// Token: 0x0601A07D RID: 106621 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A07D")]
		[Address(RVA = "0x12F2040", Offset = "0x12F0C40", VA = "0x1812F2040")]
		private void _TryToDealWithDialogItemWhenUpdate()
		{
		}

		// Token: 0x0601A07E RID: 106622 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A07E")]
		[Address(RVA = "0x12F20C0", Offset = "0x12F0CC0", VA = "0x1812F20C0")]
		private SandboxV2DungeonPushMessageController.SandboxV2DungeonDialogItemInfo _TryToPopPendingDialogItem()
		{
			return null;
		}

		// Token: 0x0601A07F RID: 106623 RVA: 0x000A0140 File Offset: 0x0009E340
		[Token(Token = "0x601A07F")]
		[Address(RVA = "0x12F21D0", Offset = "0x12F0DD0", VA = "0x1812F21D0")]
		private bool _TryToShowDialogByItemInfo(SandboxV2DungeonPushMessageController.SandboxV2DungeonDialogItemInfo dialogItem)
		{
			return default(bool);
		}

		// Token: 0x0601A080 RID: 106624 RVA: 0x000A0158 File Offset: 0x0009E358
		[Token(Token = "0x601A080")]
		[Address(RVA = "0x12F1B40", Offset = "0x12F0740", VA = "0x1812F1B40")]
		private bool _ShowDungeonZoneDialog(SandboxV2DungeonPushMessageController.SandboxV2DungeonDialogItemInfo dialogItemInfo)
		{
			return default(bool);
		}

		// Token: 0x0601A081 RID: 106625 RVA: 0x000A0170 File Offset: 0x0009E370
		[Token(Token = "0x601A081")]
		[Address(RVA = "0x12F16A0", Offset = "0x12F02A0", VA = "0x1812F16A0")]
		private bool _ShowDungeonQuestDialog(SandboxV2DungeonPushMessageController.SandboxV2DungeonDialogItemInfo dialogItemInfo)
		{
			return default(bool);
		}

		// Token: 0x0601A082 RID: 106626 RVA: 0x000A0188 File Offset: 0x0009E388
		[Token(Token = "0x601A082")]
		[Address(RVA = "0x12F1900", Offset = "0x12F0500", VA = "0x1812F1900")]
		private bool _ShowDungeonRiftQuestDialog(SandboxV2DungeonPushMessageController.SandboxV2DungeonDialogItemInfo dialogItemInfo)
		{
			return default(bool);
		}

		// Token: 0x0601A083 RID: 106627 RVA: 0x000A01A0 File Offset: 0x0009E3A0
		[Token(Token = "0x601A083")]
		[Address(RVA = "0x12F2330", Offset = "0x12F0F30", VA = "0x1812F2330")]
		private bool _TutorialOnly_TriggerWhenDialogQueueCompleted(SandboxV2DungeonPushMessageController.SandboxV2DungeonDialogItemInfo dialogItemInfo)
		{
			return default(bool);
		}

		// Token: 0x0601A084 RID: 106628 RVA: 0x000A01B8 File Offset: 0x0009E3B8
		[Token(Token = "0x601A084")]
		[Address(RVA = "0x12F1210", Offset = "0x12EFE10", VA = "0x1812F1210")]
		private bool _CheckUIStable()
		{
			return default(bool);
		}

		// Token: 0x0601A085 RID: 106629 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A085")]
		[Address(RVA = "0x12F13B0", Offset = "0x12EFFB0", VA = "0x1812F13B0")]
		private void _HandleQuestStatusCallback()
		{
		}

		// Token: 0x0601A086 RID: 106630 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A086")]
		[Address(RVA = "0x12F1410", Offset = "0x12F0010", VA = "0x1812F1410")]
		private void _HandleZoneUnlockCallback()
		{
		}

		// Token: 0x0601A087 RID: 106631 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A087")]
		[Address(RVA = "0x12F1ED0", Offset = "0x12F0AD0", VA = "0x1812F1ED0")]
		private void _TryToDealWithDialogItemWhenCallback(SandboxV2DungeonPushMessageObservableType observableType)
		{
		}

		// Token: 0x0601A088 RID: 106632 RVA: 0x000A01D0 File Offset: 0x0009E3D0
		[Token(Token = "0x601A088")]
		[Address(RVA = "0x12F1310", Offset = "0x12EFF10", VA = "0x1812F1310")]
		private SandboxV2DungeonPushMessageObservableType _GetObservableTypeByDialogItem(SandboxV2DungeonPushMessageController.SandboxV2DungeonDialogItemInfo dialogItem)
		{
			return SandboxV2DungeonPushMessageObservableType.ZONE_UNLOCK;
		}

		// Token: 0x0601A089 RID: 106633 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A089")]
		[Address(RVA = "0x12F15D0", Offset = "0x12F01D0", VA = "0x1812F15D0")]
		private IEnumerator _ReceiveItemsCoroutine(List<ItemGet> items)
		{
			return null;
		}

		// Token: 0x0601A08A RID: 106634 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A08A")]
		[Address(RVA = "0x12F23C0", Offset = "0x12F0FC0", VA = "0x1812F23C0")]
		public SandboxV2DungeonPushMessageController()
		{
		}

		// Token: 0x0601A08B RID: 106635 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A08B")]
		[Address(RVA = "0xEE5F30", Offset = "0xEE4B30", VA = "0x180EE5F30")]
		private void <>xLuaBaseProxy_OnCreate()
		{
		}

		// Token: 0x0601A08C RID: 106636 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A08C")]
		[Address(RVA = "0xEDDC40", Offset = "0xEDC840", VA = "0x180EDDC40")]
		private void <>xLuaBaseProxy_OnDestroy()
		{
		}

		// Token: 0x04020C74 RID: 134260
		[Token(Token = "0x4020C74")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private StateEngine _stateEngine;

		// Token: 0x04020C75 RID: 134261
		[Token(Token = "0x4020C75")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private SandboxV2DungeonAVGAdapter _avgAdapter;

		// Token: 0x04020C76 RID: 134262
		[Token(Token = "0x4020C76")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool m_isInited;

		// Token: 0x04020C77 RID: 134263
		[Token(Token = "0x4020C77")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private string m_topicId;

		// Token: 0x04020C78 RID: 134264
		[Token(Token = "0x4020C78")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int m_questStatusDialogInstId;

		// Token: 0x04020C79 RID: 134265
		[Token(Token = "0x4020C79")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private int m_zoneUnlockDialogInstId;

		// Token: 0x04020C7A RID: 134266
		[Token(Token = "0x4020C7A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private PriorityQueue<SandboxV2DungeonPushMessageController.SandboxV2DungeonDialogItemInfo> m_notifyDialogItemQueue;

		// Token: 0x04020C7B RID: 134267
		[Token(Token = "0x4020C7B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private bool m_isShowingDialog;

		// Token: 0x04020C7C RID: 134268
		[Token(Token = "0x4020C7C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private List<SandboxV2DungeonPushMessageController.SandboxV2DungeonPushMessageElementInfo> m_elementInfos;

		// Token: 0x04020C7D RID: 134269
		[Token(Token = "0x4020C7D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnCreate;

		// Token: 0x04020C7E RID: 134270
		[Token(Token = "0x4020C7E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x04020C7F RID: 134271
		[Token(Token = "0x4020C7F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x04020C80 RID: 134272
		[Token(Token = "0x4020C80")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_TutorialOnly_IsDungeonStable;

		// Token: 0x04020C81 RID: 134273
		[Token(Token = "0x4020C81")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_HandleCallBack;

		// Token: 0x04020C82 RID: 134274
		[Token(Token = "0x4020C82")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_IsInDungeonAndStable;

		// Token: 0x04020C83 RID: 134275
		[Token(Token = "0x4020C83")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_CheckFrontStateCanShowMonthMsg;

		// Token: 0x04020C84 RID: 134276
		[Token(Token = "0x4020C84")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_TutorialOnly_HandleGuideStartPushMsg;

		// Token: 0x04020C85 RID: 134277
		[Token(Token = "0x4020C85")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_HandleMonthRewardPushMsg;

		// Token: 0x04020C86 RID: 134278
		[Token(Token = "0x4020C86")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_HandleNotifyDialogMsg;

		// Token: 0x04020C87 RID: 134279
		[Token(Token = "0x4020C87")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_HandleQuestFinishMsgWithToast;

		// Token: 0x04020C88 RID: 134280
		[Token(Token = "0x4020C88")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_HandleRiftSubFinishMsgWithToast;

		// Token: 0x04020C89 RID: 134281
		[Token(Token = "0x4020C89")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_HandleCraftUnlockMsgWithToast;

		// Token: 0x04020C8A RID: 134282
		[Token(Token = "0x4020C8A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_HandleAchievementWithToast;

		// Token: 0x04020C8B RID: 134283
		[Token(Token = "0x4020C8B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_Watch;

		// Token: 0x04020C8C RID: 134284
		[Token(Token = "0x4020C8C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_UnWatch;

		// Token: 0x04020C8D RID: 134285
		[Token(Token = "0x4020C8D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_SetShowStatus;

		// Token: 0x04020C8E RID: 134286
		[Token(Token = "0x4020C8E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__InitController;

		// Token: 0x04020C8F RID: 134287
		[Token(Token = "0x4020C8F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__TryToDealWithDialogItemWhenUpdate;

		// Token: 0x04020C90 RID: 134288
		[Token(Token = "0x4020C90")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__TryToPopPendingDialogItem;

		// Token: 0x04020C91 RID: 134289
		[Token(Token = "0x4020C91")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__TryToShowDialogByItemInfo;

		// Token: 0x04020C92 RID: 134290
		[Token(Token = "0x4020C92")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__ShowDungeonZoneDialog;

		// Token: 0x04020C93 RID: 134291
		[Token(Token = "0x4020C93")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__ShowDungeonQuestDialog;

		// Token: 0x04020C94 RID: 134292
		[Token(Token = "0x4020C94")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__ShowDungeonRiftQuestDialog;

		// Token: 0x04020C95 RID: 134293
		[Token(Token = "0x4020C95")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0__TutorialOnly_TriggerWhenDialogQueueCompleted;

		// Token: 0x04020C96 RID: 134294
		[Token(Token = "0x4020C96")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0__CheckUIStable;

		// Token: 0x04020C97 RID: 134295
		[Token(Token = "0x4020C97")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0__HandleQuestStatusCallback;

		// Token: 0x04020C98 RID: 134296
		[Token(Token = "0x4020C98")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0__HandleZoneUnlockCallback;

		// Token: 0x04020C99 RID: 134297
		[Token(Token = "0x4020C99")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0__TryToDealWithDialogItemWhenCallback;

		// Token: 0x04020C9A RID: 134298
		[Token(Token = "0x4020C9A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0__GetObservableTypeByDialogItem;

		// Token: 0x04020C9B RID: 134299
		[Token(Token = "0x4020C9B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0__ReceiveItemsCoroutine;

		// Token: 0x04020C9C RID: 134300
		[Token(Token = "0x4020C9C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020041E7 RID: 16871
		[Token(Token = "0x20041E7")]
		public class SandboxV2DungeonDialogItemInfo : IComparable<SandboxV2DungeonPushMessageController.SandboxV2DungeonDialogItemInfo>, IHotfixable
		{
			// Token: 0x0601A08D RID: 106637 RVA: 0x000A01E8 File Offset: 0x0009E3E8
			[Token(Token = "0x601A08D")]
			[Address(RVA = "0x12E73A0", Offset = "0x12E5FA0", VA = "0x1812E73A0", Slot = "4")]
			public int CompareTo(SandboxV2DungeonPushMessageController.SandboxV2DungeonDialogItemInfo other)
			{
				return 0;
			}

			// Token: 0x0601A08E RID: 106638 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601A08E")]
			[Address(RVA = "0x12E74C0", Offset = "0x12E60C0", VA = "0x1812E74C0")]
			public SandboxV2DungeonDialogItemInfo()
			{
			}

			// Token: 0x04020C9D RID: 134301
			[Token(Token = "0x4020C9D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string id;

			// Token: 0x04020C9E RID: 134302
			[Token(Token = "0x4020C9E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public SandboxV2DungeonDialogShowType showType;

			// Token: 0x04020C9F RID: 134303
			[Token(Token = "0x4020C9F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public SandboxV2DungeonDialogQuestProcessType questProcessType;

			// Token: 0x04020CA0 RID: 134304
			[Token(Token = "0x4020CA0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_CompareTo;

			// Token: 0x04020CA1 RID: 134305
			[Token(Token = "0x4020CA1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x020041E8 RID: 16872
		[Token(Token = "0x20041E8")]
		private class SandboxV2DungeonPushMessageElementInfo
		{
			// Token: 0x0601A08F RID: 106639 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601A08F")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public SandboxV2DungeonPushMessageElementInfo()
			{
			}

			// Token: 0x04020CA2 RID: 134306
			[Token(Token = "0x4020CA2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public SandboxV2DungeonPushMessageElement element;

			// Token: 0x04020CA3 RID: 134307
			[Token(Token = "0x4020CA3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public HashSet<SandboxV2DungeonPushMessageObservableType> observableTypes;
		}
	}
}
