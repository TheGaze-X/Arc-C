using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x02000199 RID: 409
	[Token(Token = "0x2000199")]
	internal class EventCallbackFunctor<TEventType> : EventCallbackFunctorBase where TEventType : EventBase<TEventType>, new()
	{
		// Token: 0x06000B57 RID: 2903 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B57")]
		public EventCallbackFunctor(EventCallback<TEventType> callback, CallbackPhase phase, InvokePolicy invokePolicy = InvokePolicy.Default)
		{
		}

		// Token: 0x06000B58 RID: 2904 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B58")]
		public override void Invoke(EventBase evt, PropagationPhase propagationPhase)
		{
		}

		// Token: 0x06000B59 RID: 2905 RVA: 0x00006048 File Offset: 0x00004248
		[Token(Token = "0x6000B59")]
		public override bool IsEquivalentTo(long eventTypeId, Delegate callback, CallbackPhase phase)
		{
			return default(bool);
		}

		// Token: 0x04000635 RID: 1589
		[Token(Token = "0x4000635")]
		[FieldOffset(Offset = "0x0")]
		private readonly EventCallback<TEventType> m_Callback;

		// Token: 0x04000636 RID: 1590
		[Token(Token = "0x4000636")]
		[FieldOffset(Offset = "0x0")]
		private readonly long m_EventTypeId;
	}
}
