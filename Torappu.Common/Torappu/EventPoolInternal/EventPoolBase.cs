using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.EventPoolInternal
{
	// Token: 0x02000133 RID: 307
	[Token(Token = "0x2000133")]
	public abstract class EventPoolBase
	{
		// Token: 0x0600074D RID: 1869 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x600074D")]
		[Address(RVA = "0x5516F60", Offset = "0x5515B60", VA = "0x185516F60")]
		public void Remove(EventPool.EventCallbackDelegate cb)
		{
		}

		// Token: 0x0600074E RID: 1870 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x600074E")]
		[Address(RVA = "0x5516BC0", Offset = "0x55157C0", VA = "0x185516BC0")]
		public void Clear()
		{
		}

		// Token: 0x0600074F RID: 1871 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x600074F")]
		[Address(RVA = "0x5517170", Offset = "0x5515D70", VA = "0x185517170")]
		public void Reset()
		{
		}

		// Token: 0x06000750 RID: 1872 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000750")]
		[Address(RVA = "0x5516C20", Offset = "0x5515820", VA = "0x185516C20")]
		protected EventPoolBase.AddOrRemoveSafeCallbackSet EnsureEvents(Dictionary<int, EventPoolBase.AddOrRemoveSafeCallbackSet> events, int ev)
		{
			return null;
		}

		// Token: 0x06000751 RID: 1873 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000751")]
		[Address(RVA = "0x5516E50", Offset = "0x5515A50", VA = "0x185516E50")]
		protected void RecycleEvents(Dictionary<int, EventPoolBase.AddOrRemoveSafeCallbackSet> events, int ev)
		{
		}

		// Token: 0x06000752 RID: 1874 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000752")]
		[Address(RVA = "0x5517510", Offset = "0x5516110", VA = "0x185517510")]
		protected EventPoolBase()
		{
		}

		// Token: 0x04000652 RID: 1618
		[Token(Token = "0x4000652")]
		[FieldOffset(Offset = "0x0")]
		private static List<EventPoolBase.AddOrRemoveSafeCallbackSet> s_unusedSet;

		// Token: 0x04000653 RID: 1619
		[Token(Token = "0x4000653")]
		[FieldOffset(Offset = "0x10")]
		protected Dictionary<int, EventPoolBase.AddOrRemoveSafeCallbackSet> eventsMap;

		// Token: 0x04000654 RID: 1620
		[Token(Token = "0x4000654")]
		[FieldOffset(Offset = "0x18")]
		protected Dictionary<int, EventPoolBase.AddOrRemoveSafeCallbackSet> onceEventsMap;

		// Token: 0x02000134 RID: 308
		[Token(Token = "0x2000134")]
		protected class AddOrRemoveSafeCallbackSet
		{
			// Token: 0x06000754 RID: 1876 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x6000754")]
			[Address(RVA = "0x5512730", Offset = "0x5511330", VA = "0x185512730")]
			public void Add(EventPool.EventCallbackDelegate cb)
			{
			}

			// Token: 0x06000755 RID: 1877 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x6000755")]
			[Address(RVA = "0x5512AD0", Offset = "0x55116D0", VA = "0x185512AD0")]
			public void Remove(EventPool.EventCallbackDelegate cb)
			{
			}

			// Token: 0x06000756 RID: 1878 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x6000756")]
			[Address(RVA = "0x5512870", Offset = "0x5511470", VA = "0x185512870")]
			public void Emit(object arg)
			{
			}

			// Token: 0x06000757 RID: 1879 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x6000757")]
			[Address(RVA = "0x5512C10", Offset = "0x5511810", VA = "0x185512C10")]
			public void Reset()
			{
			}

			// Token: 0x06000758 RID: 1880 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x6000758")]
			[Address(RVA = "0x5512CA0", Offset = "0x55118A0", VA = "0x185512CA0")]
			public AddOrRemoveSafeCallbackSet()
			{
			}

			// Token: 0x04000655 RID: 1621
			[Token(Token = "0x4000655")]
			[FieldOffset(Offset = "0x10")]
			private ushort m_iterCounter;

			// Token: 0x04000656 RID: 1622
			[Token(Token = "0x4000656")]
			[FieldOffset(Offset = "0x18")]
			private HashSet<EventPool.EventCallbackDelegate> m_internalSet;

			// Token: 0x04000657 RID: 1623
			[Token(Token = "0x4000657")]
			[FieldOffset(Offset = "0x20")]
			private List<KeyValuePair<bool, EventPool.EventCallbackDelegate>> m_pendingAddOrRemove;
		}
	}
}
