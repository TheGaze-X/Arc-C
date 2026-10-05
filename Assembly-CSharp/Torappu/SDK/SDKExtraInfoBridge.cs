using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.SDK
{
	// Token: 0x020014DA RID: 5338
	[Token(Token = "0x20014DA")]
	public class SDKExtraInfoBridge : Singleton<SDKExtraInfoBridge>, IDisposable
	{
		// Token: 0x06007B1F RID: 31519 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B1F")]
		[Address(RVA = "0x273FD70", Offset = "0x273E970", VA = "0x18273FD70")]
		private SDKExtraInfoBridge()
		{
		}

		// Token: 0x06007B20 RID: 31520 RVA: 0x00036F90 File Offset: 0x00035190
		[Token(Token = "0x6007B20")]
		[Address(RVA = "0x273F7E0", Offset = "0x273E3E0", VA = "0x18273F7E0")]
		private bool _InitIfNot()
		{
			return default(bool);
		}

		// Token: 0x06007B21 RID: 31521 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B21")]
		[Address(RVA = "0x273F4C0", Offset = "0x273E0C0", VA = "0x18273F4C0", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x06007B22 RID: 31522 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B22")]
		[Address(RVA = "0x273F740", Offset = "0x273E340", VA = "0x18273F740")]
		private void _GT3MessageEvent(SDKExtraInfoHandler.GT3Message msg)
		{
		}

		// Token: 0x06007B23 RID: 31523 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B23")]
		[Address(RVA = "0x273F6A0", Offset = "0x273E2A0", VA = "0x18273F6A0")]
		private void _CloudAuthMessageEvent(SDKExtraInfoHandler.CloudAuthMessage msg)
		{
		}

		// Token: 0x06007B24 RID: 31524 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B24")]
		[Address(RVA = "0x273FCD0", Offset = "0x273E8D0", VA = "0x18273FCD0")]
		private void _UnbindGrantMsgEvent(SDKExtraInfoHandler.UnbindGrantMessage msg)
		{
		}

		// Token: 0x06007B25 RID: 31525 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B25")]
		[Address(RVA = "0x273F380", Offset = "0x273DF80", VA = "0x18273F380")]
		public void CallGT3Message(string captchaData, Action<SDKExtraInfoHandler.GT3Message> callback)
		{
		}

		// Token: 0x06007B26 RID: 31526 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B26")]
		[Address(RVA = "0x273F1E0", Offset = "0x273DDE0", VA = "0x18273F1E0")]
		public void CallCloudAuthMessage(string token, Action<SDKExtraInfoHandler.CloudAuthMessage> callback)
		{
		}

		// Token: 0x06007B27 RID: 31527 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B27")]
		public void BindMsgObserver<InfoType>(UnityEngine.Object binder, Action<InfoType> callback)
		{
		}

		// Token: 0x06007B28 RID: 31528 RVA: 0x00036FA8 File Offset: 0x000351A8
		[Token(Token = "0x6007B28")]
		public bool UnbindMsgObserver<InfoType>(UnityEngine.Object binder)
		{
			return default(bool);
		}

		// Token: 0x06007B29 RID: 31529 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B29")]
		private void _TriggerMsgEvents<InfoType>(InfoType result)
		{
		}

		// Token: 0x06007B2A RID: 31530 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B2A")]
		private void _DoActionWithCallback<InfoType>(Action invoke, Action<InfoType> callback, bool useBlocker = false)
		{
		}

		// Token: 0x06007B2B RID: 31531 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007B2B")]
		private void _BindCallback<InfoType>(Action<InfoType> callback)
		{
		}

		// Token: 0x06007B2C RID: 31532 RVA: 0x00036FC0 File Offset: 0x000351C0
		[Token(Token = "0x6007B2C")]
		private bool _CheckIfInvoking<InfoType>()
		{
			return default(bool);
		}

		// Token: 0x04007955 RID: 31061
		[Token(Token = "0x4007955")]
		[FieldOffset(Offset = "0x10")]
		private Dictionary<Type, object> m_callbackMap;

		// Token: 0x04007956 RID: 31062
		[Token(Token = "0x4007956")]
		[FieldOffset(Offset = "0x18")]
		private Dictionary<Type, List<SDKExtraInfoBridge.Observer>> m_observerMap;

		// Token: 0x04007957 RID: 31063
		[Token(Token = "0x4007957")]
		[FieldOffset(Offset = "0x20")]
		private bool m_isInited;

		// Token: 0x04007958 RID: 31064
		[Token(Token = "0x4007958")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x04007959 RID: 31065
		[Token(Token = "0x4007959")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0400795A RID: 31066
		[Token(Token = "0x400795A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Dispose;

		// Token: 0x0400795B RID: 31067
		[Token(Token = "0x400795B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__GT3MessageEvent;

		// Token: 0x0400795C RID: 31068
		[Token(Token = "0x400795C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__CloudAuthMessageEvent;

		// Token: 0x0400795D RID: 31069
		[Token(Token = "0x400795D")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__UnbindGrantMsgEvent;

		// Token: 0x0400795E RID: 31070
		[Token(Token = "0x400795E")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_CallGT3Message;

		// Token: 0x0400795F RID: 31071
		[Token(Token = "0x400795F")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_CallCloudAuthMessage;

		// Token: 0x04007960 RID: 31072
		[Token(Token = "0x4007960")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_BindMsgObserver;

		// Token: 0x04007961 RID: 31073
		[Token(Token = "0x4007961")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_UnbindMsgObserver;

		// Token: 0x04007962 RID: 31074
		[Token(Token = "0x4007962")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__TriggerMsgEvents;

		// Token: 0x04007963 RID: 31075
		[Token(Token = "0x4007963")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__DoActionWithCallback;

		// Token: 0x04007964 RID: 31076
		[Token(Token = "0x4007964")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__BindCallback;

		// Token: 0x04007965 RID: 31077
		[Token(Token = "0x4007965")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__CheckIfInvoking;

		// Token: 0x020014DB RID: 5339
		[Token(Token = "0x20014DB")]
		private struct Observer
		{
			// Token: 0x04007966 RID: 31078
			[Token(Token = "0x4007966")]
			[FieldOffset(Offset = "0x0")]
			public UnityEngine.Object binder;

			// Token: 0x04007967 RID: 31079
			[Token(Token = "0x4007967")]
			[FieldOffset(Offset = "0x8")]
			public object callback;
		}
	}
}
