using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.AVG
{
	// Token: 0x02001E3A RID: 7738
	[Token(Token = "0x2001E3A")]
	public class AVGDataDriver<T> : IHotfixable
	{
		// Token: 0x0600BFA1 RID: 49057 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BFA1")]
		private void _CompactNullSubscribers()
		{
		}

		// Token: 0x0600BFA2 RID: 49058 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BFA2")]
		public void Subscribe(IAVGDataSubscriber<T> subscriber, T current, bool pushNow = true)
		{
		}

		// Token: 0x0600BFA3 RID: 49059 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BFA3")]
		public void Unsubscribe(IAVGDataSubscriber<T> subscriber)
		{
		}

		// Token: 0x0600BFA4 RID: 49060 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BFA4")]
		public void UnsubscribeAll()
		{
		}

		// Token: 0x0600BFA5 RID: 49061 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BFA5")]
		public void Broadcast(T data)
		{
		}

		// Token: 0x0600BFA6 RID: 49062 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BFA6")]
		private void _FlushPendingOperations()
		{
		}

		// Token: 0x0600BFA7 RID: 49063 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BFA7")]
		private static void _SafeNotify(IAVGDataSubscriber<T> subscriber, T data)
		{
		}

		// Token: 0x0600BFA8 RID: 49064 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BFA8")]
		public AVGDataDriver()
		{
		}

		// Token: 0x0400C0CC RID: 49356
		[Token(Token = "0x400C0CC")]
		[FieldOffset(Offset = "0x0")]
		private readonly List<IAVGDataSubscriber<T>> m_subscribers;

		// Token: 0x0400C0CD RID: 49357
		[Token(Token = "0x400C0CD")]
		[FieldOffset(Offset = "0x0")]
		private readonly List<IAVGDataSubscriber<T>> m_pendingAdd;

		// Token: 0x0400C0CE RID: 49358
		[Token(Token = "0x400C0CE")]
		[FieldOffset(Offset = "0x0")]
		private readonly List<IAVGDataSubscriber<T>> m_pendingRemove;

		// Token: 0x0400C0CF RID: 49359
		[Token(Token = "0x400C0CF")]
		[FieldOffset(Offset = "0x0")]
		private bool m_isDispatching;

		// Token: 0x0400C0D0 RID: 49360
		[Token(Token = "0x400C0D0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__CompactNullSubscribers;

		// Token: 0x0400C0D1 RID: 49361
		[Token(Token = "0x400C0D1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Subscribe;

		// Token: 0x0400C0D2 RID: 49362
		[Token(Token = "0x400C0D2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Unsubscribe;

		// Token: 0x0400C0D3 RID: 49363
		[Token(Token = "0x400C0D3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_UnsubscribeAll;

		// Token: 0x0400C0D4 RID: 49364
		[Token(Token = "0x400C0D4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Broadcast;

		// Token: 0x0400C0D5 RID: 49365
		[Token(Token = "0x400C0D5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__FlushPendingOperations;

		// Token: 0x0400C0D6 RID: 49366
		[Token(Token = "0x400C0D6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__SafeNotify;

		// Token: 0x0400C0D7 RID: 49367
		[Token(Token = "0x400C0D7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
