using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.Battle
{
	// Token: 0x0200265F RID: 9823
	[Token(Token = "0x200265F")]
	public class FixedEventHandler<T> where T : class, IPtrObject
	{
		// Token: 0x06010102 RID: 65794 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010102")]
		public void Clear()
		{
		}

		// Token: 0x06010103 RID: 65795 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010103")]
		public void QueueEvent(T target, uint secondaryCompareUid, uint thirdCompareWeight, Action<T> callback)
		{
		}

		// Token: 0x06010104 RID: 65796 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010104")]
		private void _DealPendingActions()
		{
		}

		// Token: 0x06010105 RID: 65797 RVA: 0x000621C0 File Offset: 0x000603C0
		[Token(Token = "0x6010105")]
		private int _CompareEvent(FixedEventHandler<T>.PendingEvent lhs, FixedEventHandler<T>.PendingEvent rhs)
		{
			return 0;
		}

		// Token: 0x06010106 RID: 65798 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010106")]
		public FixedEventHandler()
		{
		}

		// Token: 0x04011DCF RID: 73167
		[Token(Token = "0x4011DCF")]
		[FieldOffset(Offset = "0x0")]
		private List<FixedEventHandler<T>.PendingEvent> m_pendingActions;

		// Token: 0x04011DD0 RID: 73168
		[Token(Token = "0x4011DD0")]
		[FieldOffset(Offset = "0x0")]
		private CoroutineId m_coroutine;

		// Token: 0x02002660 RID: 9824
		[Token(Token = "0x2002660")]
		private struct PendingEvent
		{
			// Token: 0x04011DD1 RID: 73169
			[Token(Token = "0x4011DD1")]
			[FieldOffset(Offset = "0x0")]
			public Action<T> callback;

			// Token: 0x04011DD2 RID: 73170
			[Token(Token = "0x4011DD2")]
			[FieldOffset(Offset = "0x0")]
			public ObjectPtr<T> target;

			// Token: 0x04011DD3 RID: 73171
			[Token(Token = "0x4011DD3")]
			[FieldOffset(Offset = "0x0")]
			public uint secondaryCompUid;

			// Token: 0x04011DD4 RID: 73172
			[Token(Token = "0x4011DD4")]
			[FieldOffset(Offset = "0x0")]
			public uint thirdCompareWeight;

			// Token: 0x04011DD5 RID: 73173
			[Token(Token = "0x4011DD5")]
			[FieldOffset(Offset = "0x0")]
			public int seqNum;
		}
	}
}
