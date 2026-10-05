using System;
using Il2CppDummyDll;

namespace System.ComponentModel
{
	// Token: 0x02000160 RID: 352
	[Token(Token = "0x2000160")]
	public sealed class EventHandlerList : IDisposable
	{
		// Token: 0x060008FE RID: 2302 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60008FE")]
		[Address(RVA = "0x1CF9670", Offset = "0x1CF8270", VA = "0x181CF9670")]
		internal EventHandlerList(Component parent)
		{
		}

		// Token: 0x060008FF RID: 2303 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60008FF")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public EventHandlerList()
		{
		}

		// Token: 0x170001C1 RID: 449
		[Token(Token = "0x170001C1")]
		public Delegate this[object key]
		{
			[Token(Token = "0x6000900")]
			[Address(RVA = "0x5123740", Offset = "0x5122340", VA = "0x185123740")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000901")]
			[Address(RVA = "0x51237A0", Offset = "0x51223A0", VA = "0x1851237A0")]
			set
			{
			}
		}

		// Token: 0x06000902 RID: 2306 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000902")]
		[Address(RVA = "0x5123470", Offset = "0x5122070", VA = "0x185123470")]
		public void AddHandler(object key, Delegate value)
		{
		}

		// Token: 0x06000903 RID: 2307 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000903")]
		[Address(RVA = "0x5123580", Offset = "0x5122180", VA = "0x185123580")]
		public void AddHandlers(EventHandlerList listToAddFrom)
		{
		}

		// Token: 0x06000904 RID: 2308 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000904")]
		[Address(RVA = "0x1DEED20", Offset = "0x1DED920", VA = "0x181DEED20", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x06000905 RID: 2309 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000905")]
		[Address(RVA = "0x51236C0", Offset = "0x51222C0", VA = "0x1851236C0")]
		private EventHandlerList.ListEntry Find(object key)
		{
			return null;
		}

		// Token: 0x06000906 RID: 2310 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000906")]
		[Address(RVA = "0x51236E0", Offset = "0x51222E0", VA = "0x1851236E0")]
		public void RemoveHandler(object key, Delegate value)
		{
		}

		// Token: 0x04000625 RID: 1573
		[Token(Token = "0x4000625")]
		[FieldOffset(Offset = "0x10")]
		private EventHandlerList.ListEntry _head;

		// Token: 0x04000626 RID: 1574
		[Token(Token = "0x4000626")]
		[FieldOffset(Offset = "0x18")]
		private Component _parent;

		// Token: 0x02000161 RID: 353
		[Token(Token = "0x2000161")]
		private sealed class ListEntry
		{
			// Token: 0x06000907 RID: 2311 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000907")]
			[Address(RVA = "0x5123BF0", Offset = "0x51227F0", VA = "0x185123BF0")]
			public ListEntry(object key, Delegate handler, EventHandlerList.ListEntry next)
			{
			}

			// Token: 0x04000627 RID: 1575
			[Token(Token = "0x4000627")]
			[FieldOffset(Offset = "0x10")]
			internal EventHandlerList.ListEntry _next;

			// Token: 0x04000628 RID: 1576
			[Token(Token = "0x4000628")]
			[FieldOffset(Offset = "0x18")]
			internal object _key;

			// Token: 0x04000629 RID: 1577
			[Token(Token = "0x4000629")]
			[FieldOffset(Offset = "0x20")]
			internal Delegate _handler;
		}
	}
}
