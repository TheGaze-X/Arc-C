using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x020001A1 RID: 417
	[Token(Token = "0x20001A1")]
	public abstract class CallbackEventHandler : IEventHandler
	{
		// Token: 0x06000B79 RID: 2937 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B79")]
		public void RegisterCallback<TEventType>(EventCallback<TEventType> callback, TrickleDown useTrickleDown = TrickleDown.NoTrickleDown) where TEventType : EventBase<TEventType>, new()
		{
		}

		// Token: 0x06000B7A RID: 2938 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B7A")]
		internal void RegisterCallback<TEventType>(EventCallback<TEventType> callback, InvokePolicy invokePolicy, TrickleDown useTrickleDown = TrickleDown.NoTrickleDown) where TEventType : EventBase<TEventType>, new()
		{
		}

		// Token: 0x06000B7B RID: 2939 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B7B")]
		public void UnregisterCallback<TEventType>(EventCallback<TEventType> callback, TrickleDown useTrickleDown = TrickleDown.NoTrickleDown) where TEventType : EventBase<TEventType>, new()
		{
		}

		// Token: 0x06000B7C RID: 2940
		[Token(Token = "0x6000B7C")]
		public abstract void SendEvent(EventBase e);

		// Token: 0x06000B7D RID: 2941
		[Token(Token = "0x6000B7D")]
		internal abstract void SendEvent(EventBase e, DispatchMode dispatchMode);

		// Token: 0x06000B7E RID: 2942 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B7E")]
		[Address(RVA = "0x5AD77C0", Offset = "0x5AD63C0", VA = "0x185AD77C0")]
		internal void HandleEventAtTargetPhase(EventBase evt)
		{
		}

		// Token: 0x06000B7F RID: 2943 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B7F")]
		[Address(RVA = "0x5AD7880", Offset = "0x5AD6480", VA = "0x185AD7880", Slot = "8")]
		public virtual void HandleEvent(EventBase evt)
		{
		}

		// Token: 0x06000B80 RID: 2944 RVA: 0x00006138 File Offset: 0x00004338
		[Token(Token = "0x6000B80")]
		[Address(RVA = "0x5AD7AD0", Offset = "0x5AD66D0", VA = "0x185AD7AD0", Slot = "9")]
		public bool HasTrickleDownHandlers()
		{
			return default(bool);
		}

		// Token: 0x06000B81 RID: 2945 RVA: 0x00006150 File Offset: 0x00004350
		[Token(Token = "0x6000B81")]
		[Address(RVA = "0x5AD7AB0", Offset = "0x5AD66B0", VA = "0x185AD7AB0", Slot = "10")]
		public bool HasBubbleUpHandlers()
		{
			return default(bool);
		}

		// Token: 0x06000B82 RID: 2946 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B82")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "11")]
		protected virtual void ExecuteDefaultActionAtTarget(EventBase evt)
		{
		}

		// Token: 0x06000B83 RID: 2947 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B83")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "12")]
		protected virtual void ExecuteDefaultAction(EventBase evt)
		{
		}

		// Token: 0x06000B84 RID: 2948 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B84")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "13")]
		internal virtual void ExecuteDefaultActionDisabledAtTarget(EventBase evt)
		{
		}

		// Token: 0x06000B85 RID: 2949 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B85")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "14")]
		internal virtual void ExecuteDefaultActionDisabled(EventBase evt)
		{
		}

		// Token: 0x06000B86 RID: 2950 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B86")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected CallbackEventHandler()
		{
		}

		// Token: 0x04000648 RID: 1608
		[Token(Token = "0x4000648")]
		[FieldOffset(Offset = "0x10")]
		private EventCallbackRegistry m_CallbackRegistry;
	}
}
