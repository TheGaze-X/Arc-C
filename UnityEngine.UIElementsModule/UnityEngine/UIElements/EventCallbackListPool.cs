using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x0200019D RID: 413
	[Token(Token = "0x200019D")]
	internal class EventCallbackListPool
	{
		// Token: 0x06000B5A RID: 2906 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x6000B5A")]
		[Address(RVA = "0x5ADC160", Offset = "0x5ADAD60", VA = "0x185ADC160")]
		public EventCallbackList Get(EventCallbackList initializer)
		{
			return null;
		}

		// Token: 0x06000B5B RID: 2907 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B5B")]
		[Address(RVA = "0x5ADC310", Offset = "0x5ADAF10", VA = "0x185ADC310")]
		public void Release(EventCallbackList element)
		{
		}

		// Token: 0x06000B5C RID: 2908 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B5C")]
		[Address(RVA = "0x5ADC3C0", Offset = "0x5ADAFC0", VA = "0x185ADC3C0")]
		public EventCallbackListPool()
		{
		}

		// Token: 0x04000640 RID: 1600
		[Token(Token = "0x4000640")]
		[FieldOffset(Offset = "0x10")]
		private readonly Stack<EventCallbackList> m_Stack;
	}
}
