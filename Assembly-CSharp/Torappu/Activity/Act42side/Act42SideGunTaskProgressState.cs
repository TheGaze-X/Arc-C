using System;
using System.Collections;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act42side
{
	// Token: 0x02007322 RID: 29474
	[Token(Token = "0x2007322")]
	public class Act42SideGunTaskProgressState : PopupFadeState, IValueMsgReceiver
	{
		// Token: 0x06029ADB RID: 170715 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029ADB")]
		[Address(RVA = "0x250F760", Offset = "0x250E360", VA = "0x18250F760", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06029ADC RID: 170716 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029ADC")]
		[Address(RVA = "0x250FA20", Offset = "0x250E620", VA = "0x18250FA20", Slot = "31")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x06029ADD RID: 170717 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029ADD")]
		[Address(RVA = "0x250F7C0", Offset = "0x250E3C0", VA = "0x18250F7C0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x06029ADE RID: 170718 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029ADE")]
		[Address(RVA = "0x25103C0", Offset = "0x250EFC0", VA = "0x1825103C0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06029ADF RID: 170719 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029ADF")]
		[Address(RVA = "0x2510690", Offset = "0x250F290", VA = "0x182510690")]
		private IEnumerator _PlayEntryAnim()
		{
			return null;
		}

		// Token: 0x06029AE0 RID: 170720 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029AE0")]
		[Address(RVA = "0x2510500", Offset = "0x250F100", VA = "0x182510500")]
		private void _OnItemSelected(string id)
		{
		}

		// Token: 0x06029AE1 RID: 170721 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029AE1")]
		[Address(RVA = "0x250FFD0", Offset = "0x250EBD0", VA = "0x18250FFD0")]
		private void _AcceptTask(string acceptTaskId)
		{
		}

		// Token: 0x06029AE2 RID: 170722 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029AE2")]
		[Address(RVA = "0x2510740", Offset = "0x250F340", VA = "0x182510740")]
		private void _SubmitTask(string submitTaskId)
		{
		}

		// Token: 0x06029AE3 RID: 170723 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029AE3")]
		[Address(RVA = "0x25102A0", Offset = "0x250EEA0", VA = "0x1825102A0")]
		private void _GoToStage(string stageId)
		{
		}

		// Token: 0x06029AE4 RID: 170724 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029AE4")]
		[Address(RVA = "0x25109A0", Offset = "0x250F5A0", VA = "0x1825109A0")]
		public Act42SideGunTaskProgressState()
		{
		}

		// Token: 0x06029AE9 RID: 170729 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029AE9")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0403BA21 RID: 244257
		[Token(Token = "0x403BA21")]
		[NonSerialized]
		public const int MSG_TAB_CLICK = 0;

		// Token: 0x0403BA22 RID: 244258
		[Token(Token = "0x403BA22")]
		[NonSerialized]
		public const int MSG_ITEM_SELECTED = 1;

		// Token: 0x0403BA23 RID: 244259
		[Token(Token = "0x403BA23")]
		[NonSerialized]
		public const int MSG_TASK_LOCKED_TOAST = 2;

		// Token: 0x0403BA24 RID: 244260
		[Token(Token = "0x403BA24")]
		[NonSerialized]
		public const int MSG_GUN_LOCKED_TOAST = 3;

		// Token: 0x0403BA25 RID: 244261
		[Token(Token = "0x403BA25")]
		[NonSerialized]
		public const int MSG_ACCEPT_TASK = 4;

		// Token: 0x0403BA26 RID: 244262
		[Token(Token = "0x403BA26")]
		[NonSerialized]
		public const int MSG_SUBMIT_TASK = 5;

		// Token: 0x0403BA27 RID: 244263
		[Token(Token = "0x403BA27")]
		[NonSerialized]
		public const int MSG_GO_TO_STAGE = 6;

		// Token: 0x0403BA28 RID: 244264
		[Token(Token = "0x403BA28")]
		[NonSerialized]
		public const int MSG_TOKEN_DETAIL_CLICK = 7;

		// Token: 0x0403BA29 RID: 244265
		[Token(Token = "0x403BA29")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Act42SideGunTaskProgressView _view;

		// Token: 0x0403BA2A RID: 244266
		[Token(Token = "0x403BA2A")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private UIAnimationLocation _animEntry;

		// Token: 0x0403BA2B RID: 244267
		[Token(Token = "0x403BA2B")]
		[FieldOffset(Offset = "0x88")]
		private Act42SideGunTaskProgressStateBean m_stateBean;

		// Token: 0x0403BA2C RID: 244268
		[Token(Token = "0x403BA2C")]
		[FieldOffset(Offset = "0x90")]
		private Tween m_entryTween;

		// Token: 0x0403BA2D RID: 244269
		[Token(Token = "0x403BA2D")]
		[FieldOffset(Offset = "0x98")]
		private Act42sideGunTaskPage m_page;

		// Token: 0x0403BA2E RID: 244270
		[Token(Token = "0x403BA2E")]
		[FieldOffset(Offset = "0xA0")]
		private bool m_isInited;

		// Token: 0x0403BA2F RID: 244271
		[Token(Token = "0x403BA2F")]
		[FieldOffset(Offset = "0xA8")]
		private string m_cachedActId;

		// Token: 0x0403BA30 RID: 244272
		[Token(Token = "0x403BA30")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0403BA31 RID: 244273
		[Token(Token = "0x403BA31")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x0403BA32 RID: 244274
		[Token(Token = "0x403BA32")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0403BA33 RID: 244275
		[Token(Token = "0x403BA33")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403BA34 RID: 244276
		[Token(Token = "0x403BA34")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__PlayEntryAnim;

		// Token: 0x0403BA35 RID: 244277
		[Token(Token = "0x403BA35")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnItemSelected;

		// Token: 0x0403BA36 RID: 244278
		[Token(Token = "0x403BA36")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__AcceptTask;

		// Token: 0x0403BA37 RID: 244279
		[Token(Token = "0x403BA37")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__SubmitTask;

		// Token: 0x0403BA38 RID: 244280
		[Token(Token = "0x403BA38")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__GoToStage;

		// Token: 0x0403BA39 RID: 244281
		[Token(Token = "0x403BA39")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
