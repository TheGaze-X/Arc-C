using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.MsgSubscription
{
	// Token: 0x020015E8 RID: 5608
	[Token(Token = "0x20015E8")]
	public abstract class SubscriptionMsgCenter<MsgStruct> : BaseSubscriptionMsgCenter where MsgStruct : class, ISubscriptionMsg, new()
	{
		// Token: 0x17000F1A RID: 3866
		// (get) Token: 0x06007F12 RID: 32530
		[Token(Token = "0x17000F1A")]
		protected abstract string msgType { [Token(Token = "0x6007F12")] get; }

		// Token: 0x06007F13 RID: 32531 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007F13")]
		protected virtual void OnStart()
		{
		}

		// Token: 0x06007F14 RID: 32532 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007F14")]
		protected virtual void OnStop()
		{
		}

		// Token: 0x06007F15 RID: 32533 RVA: 0x00037F68 File Offset: 0x00036168
		[Token(Token = "0x6007F15")]
		protected virtual bool CheckMsgValid(MsgStruct msg)
		{
			return default(bool);
		}

		// Token: 0x06007F16 RID: 32534 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007F16")]
		public void SetListener(SubscriptionMsgCenter<MsgStruct>.Listener listener)
		{
		}

		// Token: 0x06007F17 RID: 32535 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007F17")]
		public sealed override void Start()
		{
		}

		// Token: 0x06007F18 RID: 32536 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007F18")]
		public sealed override void Stop()
		{
		}

		// Token: 0x06007F19 RID: 32537 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007F19")]
		public sealed override string GetMsgType()
		{
			return null;
		}

		// Token: 0x06007F1A RID: 32538 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007F1A")]
		public sealed override void HandleMsg(string msgContent)
		{
		}

		// Token: 0x06007F1B RID: 32539 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007F1B")]
		private void _OnStartPushMsg()
		{
		}

		// Token: 0x06007F1C RID: 32540 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007F1C")]
		private void _OnStopPushMsg()
		{
		}

		// Token: 0x06007F1D RID: 32541 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007F1D")]
		private void _OnStartSDK()
		{
		}

		// Token: 0x06007F1E RID: 32542 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007F1E")]
		private void _OnStopSDK()
		{
		}

		// Token: 0x06007F1F RID: 32543 RVA: 0x00037F80 File Offset: 0x00036180
		[Token(Token = "0x6007F1F")]
		private static bool _UseNativeSDK()
		{
			return default(bool);
		}

		// Token: 0x06007F20 RID: 32544 RVA: 0x00037F98 File Offset: 0x00036198
		[Token(Token = "0x6007F20")]
		private static bool _UsePushMsg()
		{
			return default(bool);
		}

		// Token: 0x06007F21 RID: 32545 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007F21")]
		protected SubscriptionMsgCenter()
		{
		}

		// Token: 0x040080C2 RID: 32962
		[Token(Token = "0x40080C2")]
		[FieldOffset(Offset = "0x0")]
		private SubscriptionMsgCenter<MsgStruct>.Listener m_listener;

		// Token: 0x040080C3 RID: 32963
		[Token(Token = "0x40080C3")]
		[FieldOffset(Offset = "0x0")]
		private static BaseSubscriptionMsgCenter.SDKCore s_sdk;

		// Token: 0x040080C4 RID: 32964
		[Token(Token = "0x40080C4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnStart;

		// Token: 0x040080C5 RID: 32965
		[Token(Token = "0x40080C5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnStop;

		// Token: 0x040080C6 RID: 32966
		[Token(Token = "0x40080C6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CheckMsgValid;

		// Token: 0x040080C7 RID: 32967
		[Token(Token = "0x40080C7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_SetListener;

		// Token: 0x040080C8 RID: 32968
		[Token(Token = "0x40080C8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Start;

		// Token: 0x040080C9 RID: 32969
		[Token(Token = "0x40080C9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Stop;

		// Token: 0x040080CA RID: 32970
		[Token(Token = "0x40080CA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetMsgType;

		// Token: 0x040080CB RID: 32971
		[Token(Token = "0x40080CB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_HandleMsg;

		// Token: 0x040080CC RID: 32972
		[Token(Token = "0x40080CC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__OnStartPushMsg;

		// Token: 0x040080CD RID: 32973
		[Token(Token = "0x40080CD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__OnStopPushMsg;

		// Token: 0x040080CE RID: 32974
		[Token(Token = "0x40080CE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__OnStartSDK;

		// Token: 0x040080CF RID: 32975
		[Token(Token = "0x40080CF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__OnStopSDK;

		// Token: 0x040080D0 RID: 32976
		[Token(Token = "0x40080D0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__UseNativeSDK;

		// Token: 0x040080D1 RID: 32977
		[Token(Token = "0x40080D1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__UsePushMsg;

		// Token: 0x040080D2 RID: 32978
		[Token(Token = "0x40080D2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020015E9 RID: 5609
		// (Invoke) Token: 0x06007F23 RID: 32547
		[Token(Token = "0x20015E9")]
		public delegate void Listener(MsgStruct msg);
	}
}
