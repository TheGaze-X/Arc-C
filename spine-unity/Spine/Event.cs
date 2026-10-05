using System;
using Il2CppDummyDll;

namespace Spine
{
	// Token: 0x02000040 RID: 64
	[Token(Token = "0x2000040")]
	public class Event
	{
		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x06000256 RID: 598 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x170000C8")]
		public EventData Data
		{
			[Token(Token = "0x6000256")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x06000257 RID: 599 RVA: 0x00002FCC File Offset: 0x000011CC
		[Token(Token = "0x170000C9")]
		public float Time
		{
			[Token(Token = "0x6000257")]
			[Address(RVA = "0x5B4650", Offset = "0x5B3250", VA = "0x1805B4650")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x06000258 RID: 600 RVA: 0x00002FE4 File Offset: 0x000011E4
		// (set) Token: 0x06000259 RID: 601 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x170000CA")]
		public int Int
		{
			[Token(Token = "0x6000258")]
			[Address(RVA = "0x4EA880", Offset = "0x4E9480", VA = "0x1804EA880")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000259")]
			[Address(RVA = "0x4EAC10", Offset = "0x4E9810", VA = "0x1804EAC10")]
			set
			{
			}
		}

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x0600025A RID: 602 RVA: 0x00002FFC File Offset: 0x000011FC
		// (set) Token: 0x0600025B RID: 603 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x170000CB")]
		public float Float
		{
			[Token(Token = "0x600025A")]
			[Address(RVA = "0x621E40", Offset = "0x620A40", VA = "0x180621E40")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600025B")]
			[Address(RVA = "0x73B900", Offset = "0x73A500", VA = "0x18073B900")]
			set
			{
			}
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x0600025C RID: 604 RVA: 0x00002096 File Offset: 0x00000296
		// (set) Token: 0x0600025D RID: 605 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x170000CC")]
		public string String
		{
			[Token(Token = "0x600025C")]
			[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070")]
			get
			{
				return null;
			}
			[Token(Token = "0x600025D")]
			[Address(RVA = "0x4E6EB0", Offset = "0x4E5AB0", VA = "0x1804E6EB0")]
			set
			{
			}
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x0600025E RID: 606 RVA: 0x00003014 File Offset: 0x00001214
		// (set) Token: 0x0600025F RID: 607 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x170000CD")]
		public float Volume
		{
			[Token(Token = "0x600025E")]
			[Address(RVA = "0x4F7D70", Offset = "0x4F6970", VA = "0x1804F7D70")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600025F")]
			[Address(RVA = "0x16928D0", Offset = "0x16914D0", VA = "0x1816928D0")]
			set
			{
			}
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x06000260 RID: 608 RVA: 0x0000302C File Offset: 0x0000122C
		// (set) Token: 0x06000261 RID: 609 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x170000CE")]
		public float Balance
		{
			[Token(Token = "0x6000260")]
			[Address(RVA = "0x16923F0", Offset = "0x1690FF0", VA = "0x1816923F0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000261")]
			[Address(RVA = "0x16928C0", Offset = "0x16914C0", VA = "0x1816928C0")]
			set
			{
			}
		}

		// Token: 0x06000262 RID: 610 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000262")]
		[Address(RVA = "0x4E4E090", Offset = "0x4E4CC90", VA = "0x184E4E090")]
		public Event(float time, EventData data)
		{
		}

		// Token: 0x06000263 RID: 611 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000263")]
		[Address(RVA = "0x319C1D0", Offset = "0x319ADD0", VA = "0x18319C1D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x040001A6 RID: 422
		[Token(Token = "0x40001A6")]
		[FieldOffset(Offset = "0x10")]
		internal readonly EventData data;

		// Token: 0x040001A7 RID: 423
		[Token(Token = "0x40001A7")]
		[FieldOffset(Offset = "0x18")]
		internal readonly float time;

		// Token: 0x040001A8 RID: 424
		[Token(Token = "0x40001A8")]
		[FieldOffset(Offset = "0x1C")]
		internal int intValue;

		// Token: 0x040001A9 RID: 425
		[Token(Token = "0x40001A9")]
		[FieldOffset(Offset = "0x20")]
		internal float floatValue;

		// Token: 0x040001AA RID: 426
		[Token(Token = "0x40001AA")]
		[FieldOffset(Offset = "0x28")]
		internal string stringValue;

		// Token: 0x040001AB RID: 427
		[Token(Token = "0x40001AB")]
		[FieldOffset(Offset = "0x30")]
		internal float volume;

		// Token: 0x040001AC RID: 428
		[Token(Token = "0x40001AC")]
		[FieldOffset(Offset = "0x34")]
		internal float balance;
	}
}
