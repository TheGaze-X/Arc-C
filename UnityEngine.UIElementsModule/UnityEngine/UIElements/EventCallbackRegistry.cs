using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x0200019F RID: 415
	[Token(Token = "0x200019F")]
	internal class EventCallbackRegistry
	{
		// Token: 0x06000B6B RID: 2923 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x6000B6B")]
		[Address(RVA = "0x5ADCCF0", Offset = "0x5ADB8F0", VA = "0x185ADCCF0")]
		private static EventCallbackList GetCallbackList([Optional] EventCallbackList initializer)
		{
			return null;
		}

		// Token: 0x06000B6C RID: 2924 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B6C")]
		[Address(RVA = "0x5ADD110", Offset = "0x5ADBD10", VA = "0x185ADD110")]
		private static void ReleaseCallbackList(EventCallbackList toRelease)
		{
		}

		// Token: 0x06000B6D RID: 2925 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B6D")]
		[Address(RVA = "0x5ADD510", Offset = "0x5ADC110", VA = "0x185ADD510")]
		public EventCallbackRegistry()
		{
		}

		// Token: 0x06000B6E RID: 2926 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x6000B6E")]
		[Address(RVA = "0x5ADCC10", Offset = "0x5ADB810", VA = "0x185ADCC10")]
		private EventCallbackList GetCallbackListForWriting()
		{
			return null;
		}

		// Token: 0x06000B6F RID: 2927 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x6000B6F")]
		[Address(RVA = "0x45CB350", Offset = "0x45C9F50", VA = "0x1845CB350")]
		private EventCallbackList GetCallbackListForReading()
		{
			return null;
		}

		// Token: 0x06000B70 RID: 2928 RVA: 0x000060D8 File Offset: 0x000042D8
		[Token(Token = "0x6000B70")]
		[Address(RVA = "0x5ADD210", Offset = "0x5ADBE10", VA = "0x185ADD210")]
		private bool UnregisterCallback(long eventTypeId, Delegate callback, TrickleDown useTrickleDown)
		{
			return default(bool);
		}

		// Token: 0x06000B71 RID: 2929 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B71")]
		public void RegisterCallback<TEventType>(EventCallback<TEventType> callback, TrickleDown useTrickleDown = TrickleDown.NoTrickleDown, InvokePolicy invokePolicy = InvokePolicy.Default) where TEventType : EventBase<TEventType>, new()
		{
		}

		// Token: 0x06000B72 RID: 2930 RVA: 0x000060F0 File Offset: 0x000042F0
		[Token(Token = "0x6000B72")]
		public bool UnregisterCallback<TEventType>(EventCallback<TEventType> callback, TrickleDown useTrickleDown = TrickleDown.NoTrickleDown) where TEventType : EventBase<TEventType>, new()
		{
			return default(bool);
		}

		// Token: 0x06000B73 RID: 2931 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B73")]
		[Address(RVA = "0x5ADCF30", Offset = "0x5ADBB30", VA = "0x185ADCF30")]
		public void InvokeCallbacks(EventBase evt, PropagationPhase propagationPhase)
		{
		}

		// Token: 0x06000B74 RID: 2932 RVA: 0x00006108 File Offset: 0x00004308
		[Token(Token = "0x6000B74")]
		[Address(RVA = "0x5ADCF10", Offset = "0x5ADBB10", VA = "0x185ADCF10")]
		public bool HasTrickleDownHandlers()
		{
			return default(bool);
		}

		// Token: 0x06000B75 RID: 2933 RVA: 0x00006120 File Offset: 0x00004320
		[Token(Token = "0x6000B75")]
		[Address(RVA = "0x5ADCEF0", Offset = "0x5ADBAF0", VA = "0x185ADCEF0")]
		public bool HasBubbleHandlers()
		{
			return default(bool);
		}

		// Token: 0x04000644 RID: 1604
		[Token(Token = "0x4000644")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly EventCallbackListPool s_ListPool;

		// Token: 0x04000645 RID: 1605
		[Token(Token = "0x4000645")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private EventCallbackList m_Callbacks;

		// Token: 0x04000646 RID: 1606
		[Token(Token = "0x4000646")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private EventCallbackList m_TemporaryCallbacks;

		// Token: 0x04000647 RID: 1607
		[Token(Token = "0x4000647")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private int m_IsInvoking;
	}
}
