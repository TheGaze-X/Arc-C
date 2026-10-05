using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x02000059 RID: 89
	[Token(Token = "0x2000059")]
	internal class PointerDispatchState
	{
		// Token: 0x06000228 RID: 552 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000228")]
		[Address(RVA = "0x5A3AC10", Offset = "0x5A39810", VA = "0x185A3AC10")]
		public PointerDispatchState()
		{
		}

		// Token: 0x06000229 RID: 553 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000229")]
		[Address(RVA = "0x5A3AAB0", Offset = "0x5A396B0", VA = "0x185A3AAB0")]
		internal void Reset()
		{
		}

		// Token: 0x0600022A RID: 554 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x600022A")]
		[Address(RVA = "0x187C640", Offset = "0x187B240", VA = "0x18187C640")]
		public IEventHandler GetCapturingElement(int pointerId)
		{
			return null;
		}

		// Token: 0x0600022B RID: 555 RVA: 0x00002BC8 File Offset: 0x00000DC8
		[Token(Token = "0x600022B")]
		[Address(RVA = "0x5A3A410", Offset = "0x5A39010", VA = "0x185A3A410")]
		public bool HasPointerCapture(IEventHandler handler, int pointerId)
		{
			return default(bool);
		}

		// Token: 0x0600022C RID: 556 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600022C")]
		[Address(RVA = "0x5A3A2D0", Offset = "0x5A38ED0", VA = "0x185A3A2D0")]
		public void CapturePointer(IEventHandler handler, int pointerId)
		{
		}

		// Token: 0x0600022D RID: 557 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600022D")]
		[Address(RVA = "0x5A3AA20", Offset = "0x5A39620", VA = "0x185A3AA20")]
		public void ReleasePointer(int pointerId)
		{
		}

		// Token: 0x0600022E RID: 558 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600022E")]
		[Address(RVA = "0x5A3AA60", Offset = "0x5A39660", VA = "0x185A3AA60")]
		public void ReleasePointer(IEventHandler handler, int pointerId)
		{
		}

		// Token: 0x0600022F RID: 559 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600022F")]
		[Address(RVA = "0x5A3A470", Offset = "0x5A39070", VA = "0x185A3A470")]
		public void ProcessPointerCapture(int pointerId)
		{
		}

		// Token: 0x06000230 RID: 560 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000230")]
		[Address(RVA = "0x5A3A2A0", Offset = "0x5A38EA0", VA = "0x185A3A2A0")]
		public void ActivateCompatibilityMouseEvents(int pointerId)
		{
		}

		// Token: 0x06000231 RID: 561 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000231")]
		[Address(RVA = "0x5A3A440", Offset = "0x5A39040", VA = "0x185A3A440")]
		public void PreventCompatibilityMouseEvents(int pointerId)
		{
		}

		// Token: 0x06000232 RID: 562 RVA: 0x00002BE0 File Offset: 0x00000DE0
		[Token(Token = "0x6000232")]
		[Address(RVA = "0x5A3AB70", Offset = "0x5A39770", VA = "0x185A3AB70")]
		public bool ShouldSendCompatibilityMouseEvents(IPointerEvent evt)
		{
			return default(bool);
		}

		// Token: 0x0400013B RID: 315
		[Token(Token = "0x400013B")]
		[FieldOffset(Offset = "0x10")]
		private IEventHandler[] m_PendingPointerCapture;

		// Token: 0x0400013C RID: 316
		[Token(Token = "0x400013C")]
		[FieldOffset(Offset = "0x18")]
		private IEventHandler[] m_PointerCapture;

		// Token: 0x0400013D RID: 317
		[Token(Token = "0x400013D")]
		[FieldOffset(Offset = "0x20")]
		private bool[] m_ShouldSendCompatibilityMouseEvents;
	}
}
