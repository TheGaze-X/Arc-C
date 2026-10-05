using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Spine
{
	// Token: 0x02000020 RID: 32
	[Token(Token = "0x2000020")]
	internal class EventQueue
	{
		// Token: 0x1400000D RID: 13
		// (add) Token: 0x06000129 RID: 297 RVA: 0x0000207E File Offset: 0x0000027E
		// (remove) Token: 0x0600012A RID: 298 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x1400000D")]
		internal event Action AnimationsChanged
		{
			[Token(Token = "0x6000129")]
			[Address(RVA = "0x4E45DC0", Offset = "0x4E449C0", VA = "0x184E45DC0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600012A")]
			[Address(RVA = "0x4E45E60", Offset = "0x4E44A60", VA = "0x184E45E60")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x0600012B RID: 299 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600012B")]
		[Address(RVA = "0x4E45C80", Offset = "0x4E44880", VA = "0x184E45C80")]
		internal EventQueue(AnimationState state, Action HandleAnimationsChanged, Pool<TrackEntry> trackEntryPool)
		{
		}

		// Token: 0x0600012C RID: 300 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600012C")]
		[Address(RVA = "0x4E45B50", Offset = "0x4E44750", VA = "0x184E45B50")]
		internal void Start(TrackEntry entry)
		{
		}

		// Token: 0x0600012D RID: 301 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600012D")]
		[Address(RVA = "0x4E45A40", Offset = "0x4E44640", VA = "0x184E45A40")]
		internal void Interrupt(TrackEntry entry)
		{
		}

		// Token: 0x0600012E RID: 302 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600012E")]
		[Address(RVA = "0x4E457F0", Offset = "0x4E443F0", VA = "0x184E457F0")]
		internal void End(TrackEntry entry)
		{
		}

		// Token: 0x0600012F RID: 303 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600012F")]
		[Address(RVA = "0x4E453B0", Offset = "0x4E43FB0", VA = "0x184E453B0")]
		internal void Dispose(TrackEntry entry)
		{
		}

		// Token: 0x06000130 RID: 304 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000130")]
		[Address(RVA = "0x4E452A0", Offset = "0x4E43EA0", VA = "0x184E452A0")]
		internal void Complete(TrackEntry entry)
		{
		}

		// Token: 0x06000131 RID: 305 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000131")]
		[Address(RVA = "0x4E45920", Offset = "0x4E44520", VA = "0x184E45920")]
		internal void Event(TrackEntry entry, Event e)
		{
		}

		// Token: 0x06000132 RID: 306 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000132")]
		[Address(RVA = "0x4E454C0", Offset = "0x4E440C0", VA = "0x184E454C0")]
		internal void Drain()
		{
		}

		// Token: 0x06000133 RID: 307 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000133")]
		[Address(RVA = "0x4E45240", Offset = "0x4E43E40", VA = "0x184E45240")]
		internal void Clear()
		{
		}

		// Token: 0x040000D5 RID: 213
		[Token(Token = "0x40000D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly List<EventQueue.EventQueueEntry> eventQueueEntries;

		// Token: 0x040000D6 RID: 214
		[Token(Token = "0x40000D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal bool drainDisabled;

		// Token: 0x040000D7 RID: 215
		[Token(Token = "0x40000D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly AnimationState state;

		// Token: 0x040000D8 RID: 216
		[Token(Token = "0x40000D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly Pool<TrackEntry> trackEntryPool;

		// Token: 0x02000021 RID: 33
		[Token(Token = "0x2000021")]
		private struct EventQueueEntry
		{
			// Token: 0x06000134 RID: 308 RVA: 0x0000207E File Offset: 0x0000027E
			[Token(Token = "0x6000134")]
			[Address(RVA = "0x4E45200", Offset = "0x4E43E00", VA = "0x184E45200")]
			public EventQueueEntry(EventQueue.EventType eventType, TrackEntry trackEntry, [Optional] Event e)
			{
			}

			// Token: 0x040000DA RID: 218
			[Token(Token = "0x40000DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public EventQueue.EventType type;

			// Token: 0x040000DB RID: 219
			[Token(Token = "0x40000DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public TrackEntry entry;

			// Token: 0x040000DC RID: 220
			[Token(Token = "0x40000DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Event e;
		}

		// Token: 0x02000022 RID: 34
		[Token(Token = "0x2000022")]
		private enum EventType
		{
			// Token: 0x040000DE RID: 222
			[Token(Token = "0x40000DE")]
			Start,
			// Token: 0x040000DF RID: 223
			[Token(Token = "0x40000DF")]
			Interrupt,
			// Token: 0x040000E0 RID: 224
			[Token(Token = "0x40000E0")]
			End,
			// Token: 0x040000E1 RID: 225
			[Token(Token = "0x40000E1")]
			Dispose,
			// Token: 0x040000E2 RID: 226
			[Token(Token = "0x40000E2")]
			Complete,
			// Token: 0x040000E3 RID: 227
			[Token(Token = "0x40000E3")]
			Event
		}
	}
}
