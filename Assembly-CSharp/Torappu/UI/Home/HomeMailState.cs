using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Home
{
	// Token: 0x02004B1C RID: 19228
	[Token(Token = "0x2004B1C")]
	public class HomeMailState : PopupFadeState, IValueMsgReceiver
	{
		// Token: 0x0601CEB5 RID: 118453 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601CEB5")]
		[Address(RVA = "0x165B310", Offset = "0x1659F10", VA = "0x18165B310", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0601CEB6 RID: 118454 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CEB6")]
		[Address(RVA = "0x165B370", Offset = "0x1659F70", VA = "0x18165B370", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0601CEB7 RID: 118455 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CEB7")]
		[Address(RVA = "0x165B830", Offset = "0x165A430", VA = "0x18165B830", Slot = "31")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x0601CEB8 RID: 118456 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CEB8")]
		[Address(RVA = "0x165B8E0", Offset = "0x165A4E0", VA = "0x18165B8E0", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x0601CEB9 RID: 118457 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601CEB9")]
		[Address(RVA = "0x165BBE0", Offset = "0x165A7E0", VA = "0x18165BBE0", Slot = "10")]
		public override Dictionary<Type, Action<IStateBean>> RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x0601CEBA RID: 118458 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601CEBA")]
		[Address(RVA = "0x165BA80", Offset = "0x165A680", VA = "0x18165BA80", Slot = "11")]
		public override Dictionary<Type, Action<IStateBean>> RegisterFromDataListener()
		{
			return null;
		}

		// Token: 0x0601CEBB RID: 118459 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CEBB")]
		[Address(RVA = "0x165B750", Offset = "0x165A350", VA = "0x18165B750")]
		private void OnJumpToDetailView(HomeMailDetailStateBean stateBean)
		{
		}

		// Token: 0x0601CEBC RID: 118460 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CEBC")]
		[Address(RVA = "0x165B650", Offset = "0x165A250", VA = "0x18165B650")]
		private void OnJumpFromDetailView(HomeMailDetailStateBean stateBean)
		{
		}

		// Token: 0x0601CEBD RID: 118461 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CEBD")]
		[Address(RVA = "0x165AE20", Offset = "0x1659A20", VA = "0x18165AE20")]
		public void EventOnDetailClick(HomeMailIndex index)
		{
		}

		// Token: 0x0601CEBE RID: 118462 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CEBE")]
		[Address(RVA = "0x165B210", Offset = "0x1659E10", VA = "0x18165B210")]
		public void EventOnReceiveAllClick()
		{
		}

		// Token: 0x0601CEBF RID: 118463 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CEBF")]
		[Address(RVA = "0x165B290", Offset = "0x1659E90", VA = "0x18165B290")]
		public void EventOnRemoveAllClick()
		{
		}

		// Token: 0x0601CEC0 RID: 118464 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CEC0")]
		[Address(RVA = "0x165AEF0", Offset = "0x1659AF0", VA = "0x18165AEF0")]
		public void EventOnMailClick(HomeMailIndex index)
		{
		}

		// Token: 0x0601CEC1 RID: 118465 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CEC1")]
		[Address(RVA = "0x165AD30", Offset = "0x1659930", VA = "0x18165AD30")]
		public void EventOnBtnBackClick()
		{
		}

		// Token: 0x0601CEC2 RID: 118466 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CEC2")]
		[Address(RVA = "0x165AC00", Offset = "0x1659800", VA = "0x18165AC00")]
		public void EventOnArchiveClick()
		{
		}

		// Token: 0x0601CEC3 RID: 118467 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CEC3")]
		[Address(RVA = "0x165ADC0", Offset = "0x16599C0", VA = "0x18165ADC0")]
		public void EventOnBtnDebugClick()
		{
		}

		// Token: 0x0601CEC4 RID: 118468 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CEC4")]
		[Address(RVA = "0x165C630", Offset = "0x165B230", VA = "0x18165C630")]
		public void _OnReceiveItemSucceed(ReceiveMailResponse response)
		{
		}

		// Token: 0x0601CEC5 RID: 118469 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CEC5")]
		[Address(RVA = "0x165C010", Offset = "0x165AC10", VA = "0x18165C010")]
		private void _OnReceiveAllItemSucceed(ReceiveAllMailResponse response)
		{
		}

		// Token: 0x0601CEC6 RID: 118470 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CEC6")]
		[Address(RVA = "0x165C1E0", Offset = "0x165ADE0", VA = "0x18165C1E0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601CEC7 RID: 118471 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CEC7")]
		[Address(RVA = "0x165C290", Offset = "0x165AE90", VA = "0x18165C290")]
		private void _LoadData()
		{
		}

		// Token: 0x0601CEC8 RID: 118472 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CEC8")]
		[Address(RVA = "0x165C3B0", Offset = "0x165AFB0", VA = "0x18165C3B0")]
		public void _LoadMetaData(bool isEnter = false)
		{
		}

		// Token: 0x0601CEC9 RID: 118473 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CEC9")]
		[Address(RVA = "0x165C840", Offset = "0x165B440", VA = "0x18165C840")]
		private void _SendListMailBoxService(bool isEnter = false)
		{
		}

		// Token: 0x0601CECA RID: 118474 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CECA")]
		[Address(RVA = "0x165D1A0", Offset = "0x165BDA0", VA = "0x18165D1A0")]
		private void _SendReceiveMailService(MailItemViewModel targetMail)
		{
		}

		// Token: 0x0601CECB RID: 118475 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CECB")]
		[Address(RVA = "0x165CD60", Offset = "0x165B960", VA = "0x18165CD60")]
		private void _SendReceiveAllMailService()
		{
		}

		// Token: 0x0601CECC RID: 118476 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CECC")]
		[Address(RVA = "0x165D390", Offset = "0x165BF90", VA = "0x18165D390")]
		private void _SendRemoveAllReceivedMailService()
		{
		}

		// Token: 0x0601CECD RID: 118477 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601CECD")]
		[Address(RVA = "0x165B9D0", Offset = "0x165A5D0", VA = "0x18165B9D0")]
		public static IEnumerator ReceiveItemsCoroutine(List<MailGet> items)
		{
			return null;
		}

		// Token: 0x0601CECE RID: 118478 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CECE")]
		[Address(RVA = "0x165D860", Offset = "0x165C460", VA = "0x18165D860")]
		public HomeMailState()
		{
		}

		// Token: 0x0601CED3 RID: 118483 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CED3")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0601CED4 RID: 118484 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CED4")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x0601CED5 RID: 118485 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601CED5")]
		[Address(RVA = "0xE63480", Offset = "0xE62080", VA = "0x180E63480")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x0601CED6 RID: 118486 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601CED6")]
		[Address(RVA = "0xE63470", Offset = "0xE62070", VA = "0x180E63470")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterFromDataListener()
		{
			return null;
		}

		// Token: 0x04025F16 RID: 155414
		[Token(Token = "0x4025F16")]
		[FieldOffset(Offset = "0x70")]
		private readonly ListMailBoxResponse EMPTY_RESPONSE;

		// Token: 0x04025F17 RID: 155415
		[Token(Token = "0x4025F17")]
		[NonSerialized]
		public const int MSG_ON_MAIL_NEXT_PAGE = 0;

		// Token: 0x04025F18 RID: 155416
		[Token(Token = "0x4025F18")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Image _imgBlurBkg;

		// Token: 0x04025F19 RID: 155417
		[Token(Token = "0x4025F19")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private HomeMailStateBean _stateBean;

		// Token: 0x04025F1A RID: 155418
		[Token(Token = "0x4025F1A")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		[Tooltip("Click to show inner mail panels to debug")]
		private GameObject _btnDebug;

		// Token: 0x04025F1B RID: 155419
		[Token(Token = "0x4025F1B")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private HomeMailGroupView _groupView;

		// Token: 0x04025F1C RID: 155420
		[Token(Token = "0x4025F1C")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private HomeMailTitleView _titleView;

		// Token: 0x04025F1D RID: 155421
		[Token(Token = "0x4025F1D")]
		[FieldOffset(Offset = "0xA0")]
		private bool m_isInited;

		// Token: 0x04025F1E RID: 155422
		[Token(Token = "0x4025F1E")]
		[FieldOffset(Offset = "0xA8")]
		private HomeMailIndex m_clickedMailIdCache;

		// Token: 0x04025F1F RID: 155423
		[Token(Token = "0x4025F1F")]
		[FieldOffset(Offset = "0xC0")]
		private bool m_sendFlag;

		// Token: 0x04025F20 RID: 155424
		[Token(Token = "0x4025F20")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04025F21 RID: 155425
		[Token(Token = "0x4025F21")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04025F22 RID: 155426
		[Token(Token = "0x4025F22")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x04025F23 RID: 155427
		[Token(Token = "0x4025F23")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x04025F24 RID: 155428
		[Token(Token = "0x4025F24")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_RegisterToDataListener;

		// Token: 0x04025F25 RID: 155429
		[Token(Token = "0x4025F25")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_RegisterFromDataListener;

		// Token: 0x04025F26 RID: 155430
		[Token(Token = "0x4025F26")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnJumpToDetailView;

		// Token: 0x04025F27 RID: 155431
		[Token(Token = "0x4025F27")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnJumpFromDetailView;

		// Token: 0x04025F28 RID: 155432
		[Token(Token = "0x4025F28")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_EventOnDetailClick;

		// Token: 0x04025F29 RID: 155433
		[Token(Token = "0x4025F29")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_EventOnReceiveAllClick;

		// Token: 0x04025F2A RID: 155434
		[Token(Token = "0x4025F2A")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_EventOnRemoveAllClick;

		// Token: 0x04025F2B RID: 155435
		[Token(Token = "0x4025F2B")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_EventOnMailClick;

		// Token: 0x04025F2C RID: 155436
		[Token(Token = "0x4025F2C")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_EventOnBtnBackClick;

		// Token: 0x04025F2D RID: 155437
		[Token(Token = "0x4025F2D")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_EventOnArchiveClick;

		// Token: 0x04025F2E RID: 155438
		[Token(Token = "0x4025F2E")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_EventOnBtnDebugClick;

		// Token: 0x04025F2F RID: 155439
		[Token(Token = "0x4025F2F")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__OnReceiveItemSucceed;

		// Token: 0x04025F30 RID: 155440
		[Token(Token = "0x4025F30")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__OnReceiveAllItemSucceed;

		// Token: 0x04025F31 RID: 155441
		[Token(Token = "0x4025F31")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04025F32 RID: 155442
		[Token(Token = "0x4025F32")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__LoadData;

		// Token: 0x04025F33 RID: 155443
		[Token(Token = "0x4025F33")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__LoadMetaData;

		// Token: 0x04025F34 RID: 155444
		[Token(Token = "0x4025F34")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__SendListMailBoxService;

		// Token: 0x04025F35 RID: 155445
		[Token(Token = "0x4025F35")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__SendReceiveMailService;

		// Token: 0x04025F36 RID: 155446
		[Token(Token = "0x4025F36")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__SendReceiveAllMailService;

		// Token: 0x04025F37 RID: 155447
		[Token(Token = "0x4025F37")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__SendRemoveAllReceivedMailService;

		// Token: 0x04025F38 RID: 155448
		[Token(Token = "0x4025F38")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_ReceiveItemsCoroutine;

		// Token: 0x04025F39 RID: 155449
		[Token(Token = "0x4025F39")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
