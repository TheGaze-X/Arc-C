using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace System.Diagnostics
{
	// Token: 0x02000119 RID: 281
	[Token(Token = "0x2000119")]
	public class Stopwatch
	{
		// Token: 0x060006EE RID: 1774
		[Token(Token = "0x60006EE")]
		[Address(RVA = "0x4AF15F0", Offset = "0x4AF01F0", VA = "0x184AF15F0")]
		[MethodImpl(4096)]
		public static extern long GetTimestamp();

		// Token: 0x060006EF RID: 1775 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006EF")]
		[Address(RVA = "0x51186E0", Offset = "0x51172E0", VA = "0x1851186E0")]
		public static Stopwatch StartNew()
		{
			return null;
		}

		// Token: 0x060006F0 RID: 1776 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006F0")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public Stopwatch()
		{
		}

		// Token: 0x17000137 RID: 311
		// (get) Token: 0x060006F1 RID: 1777 RVA: 0x00004C08 File Offset: 0x00002E08
		[Token(Token = "0x17000137")]
		public TimeSpan Elapsed
		{
			[Token(Token = "0x60006F1")]
			[Address(RVA = "0x5118C10", Offset = "0x5117810", VA = "0x185118C10")]
			get
			{
				return default(TimeSpan);
			}
		}

		// Token: 0x17000138 RID: 312
		// (get) Token: 0x060006F2 RID: 1778 RVA: 0x00004C20 File Offset: 0x00002E20
		[Token(Token = "0x17000138")]
		public long ElapsedMilliseconds
		{
			[Token(Token = "0x60006F2")]
			[Address(RVA = "0x51188B0", Offset = "0x51174B0", VA = "0x1851188B0")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x17000139 RID: 313
		// (get) Token: 0x060006F3 RID: 1779 RVA: 0x00004C38 File Offset: 0x00002E38
		[Token(Token = "0x17000139")]
		public long ElapsedTicks
		{
			[Token(Token = "0x60006F3")]
			[Address(RVA = "0x5118BA0", Offset = "0x51177A0", VA = "0x185118BA0")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x1700013A RID: 314
		// (get) Token: 0x060006F4 RID: 1780 RVA: 0x00004C50 File Offset: 0x00002E50
		[Token(Token = "0x1700013A")]
		public bool IsRunning
		{
			[Token(Token = "0x60006F4")]
			[Address(RVA = "0x4F1E20", Offset = "0x4F0A20", VA = "0x1804F1E20")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060006F5 RID: 1781 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006F5")]
		[Address(RVA = "0x51186D0", Offset = "0x51172D0", VA = "0x1851186D0")]
		public void Reset()
		{
		}

		// Token: 0x060006F6 RID: 1782 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006F6")]
		[Address(RVA = "0x5118780", Offset = "0x5117380", VA = "0x185118780")]
		public void Start()
		{
		}

		// Token: 0x060006F7 RID: 1783 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006F7")]
		[Address(RVA = "0x51187E0", Offset = "0x51173E0", VA = "0x1851187E0")]
		public void Stop()
		{
		}

		// Token: 0x040004E5 RID: 1253
		[Token(Token = "0x40004E5")]
		[FieldOffset(Offset = "0x0")]
		public static readonly long Frequency;

		// Token: 0x040004E6 RID: 1254
		[Token(Token = "0x40004E6")]
		[FieldOffset(Offset = "0x8")]
		public static readonly bool IsHighResolution;

		// Token: 0x040004E7 RID: 1255
		[Token(Token = "0x40004E7")]
		[FieldOffset(Offset = "0x10")]
		private long elapsed;

		// Token: 0x040004E8 RID: 1256
		[Token(Token = "0x40004E8")]
		[FieldOffset(Offset = "0x18")]
		private long started;

		// Token: 0x040004E9 RID: 1257
		[Token(Token = "0x40004E9")]
		[FieldOffset(Offset = "0x20")]
		private bool is_running;
	}
}
