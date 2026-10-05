using System;
using Il2CppDummyDll;

namespace System.Text.RegularExpressions
{
	// Token: 0x020000FA RID: 250
	[Token(Token = "0x20000FA")]
	public abstract class RegexRunner
	{
		// Token: 0x0600062D RID: 1581 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600062D")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected internal RegexRunner()
		{
		}

		// Token: 0x0600062E RID: 1582 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600062E")]
		[Address(RVA = "0x5116700", Offset = "0x5115300", VA = "0x185116700")]
		protected internal Match Scan(Regex regex, string text, int textbeg, int textend, int textstart, int prevlen, bool quick, TimeSpan timeout)
		{
			return null;
		}

		// Token: 0x0600062F RID: 1583 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600062F")]
		[Address(RVA = "0x5116B60", Offset = "0x5115760", VA = "0x185116B60")]
		private void StartTimeoutWatch()
		{
		}

		// Token: 0x06000630 RID: 1584 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000630")]
		[Address(RVA = "0x5115B20", Offset = "0x5114720", VA = "0x185115B20")]
		protected void CheckTimeout()
		{
		}

		// Token: 0x06000631 RID: 1585 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000631")]
		[Address(RVA = "0x5115D20", Offset = "0x5114920", VA = "0x185115D20")]
		private void DoCheckTimeout()
		{
		}

		// Token: 0x06000632 RID: 1586
		[Token(Token = "0x6000632")]
		protected abstract void Go();

		// Token: 0x06000633 RID: 1587
		[Token(Token = "0x6000633")]
		protected abstract bool FindFirstChar();

		// Token: 0x06000634 RID: 1588
		[Token(Token = "0x6000634")]
		protected abstract void InitTrackCount();

		// Token: 0x06000635 RID: 1589 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000635")]
		[Address(RVA = "0x5116160", Offset = "0x5114D60", VA = "0x185116160")]
		private void InitMatch()
		{
		}

		// Token: 0x06000636 RID: 1590 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000636")]
		[Address(RVA = "0x5116B90", Offset = "0x5115790", VA = "0x185116B90")]
		private Match TidyMatch(bool quick)
		{
			return null;
		}

		// Token: 0x06000637 RID: 1591 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000637")]
		[Address(RVA = "0x5116010", Offset = "0x5114C10", VA = "0x185116010")]
		protected void EnsureStorage()
		{
		}

		// Token: 0x06000638 RID: 1592 RVA: 0x000047A0 File Offset: 0x000029A0
		[Token(Token = "0x6000638")]
		[Address(RVA = "0x5116410", Offset = "0x5115010", VA = "0x185116410")]
		protected bool IsBoundary(int index, int startpos, int endpos)
		{
			return default(bool);
		}

		// Token: 0x06000639 RID: 1593 RVA: 0x000047B8 File Offset: 0x000029B8
		[Token(Token = "0x6000639")]
		[Address(RVA = "0x51164F0", Offset = "0x51150F0", VA = "0x1851164F0")]
		protected bool IsECMABoundary(int index, int startpos, int endpos)
		{
			return default(bool);
		}

		// Token: 0x0600063A RID: 1594 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600063A")]
		[Address(RVA = "0x5115F60", Offset = "0x5114B60", VA = "0x185115F60")]
		protected void DoubleTrack()
		{
		}

		// Token: 0x0600063B RID: 1595 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600063B")]
		[Address(RVA = "0x5115EB0", Offset = "0x5114AB0", VA = "0x185115EB0")]
		protected void DoubleStack()
		{
		}

		// Token: 0x0600063C RID: 1596 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600063C")]
		[Address(RVA = "0x5115E00", Offset = "0x5114A00", VA = "0x185115E00")]
		protected void DoubleCrawl()
		{
		}

		// Token: 0x0600063D RID: 1597 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600063D")]
		[Address(RVA = "0x5115C10", Offset = "0x5114810", VA = "0x185115C10")]
		protected void Crawl(int i)
		{
		}

		// Token: 0x0600063E RID: 1598 RVA: 0x000047D0 File Offset: 0x000029D0
		[Token(Token = "0x600063E")]
		[Address(RVA = "0x51166C0", Offset = "0x51152C0", VA = "0x1851166C0")]
		protected int Popcrawl()
		{
			return 0;
		}

		// Token: 0x0600063F RID: 1599 RVA: 0x000047E8 File Offset: 0x000029E8
		[Token(Token = "0x600063F")]
		[Address(RVA = "0x5115D00", Offset = "0x5114900", VA = "0x185115D00")]
		protected int Crawlpos()
		{
			return 0;
		}

		// Token: 0x06000640 RID: 1600 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000640")]
		[Address(RVA = "0x5115A80", Offset = "0x5114680", VA = "0x185115A80")]
		protected void Capture(int capnum, int start, int end)
		{
		}

		// Token: 0x06000641 RID: 1601 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000641")]
		[Address(RVA = "0x5116C10", Offset = "0x5115810", VA = "0x185116C10")]
		protected void TransferCapture(int capnum, int uncapnum, int start, int end)
		{
		}

		// Token: 0x06000642 RID: 1602 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000642")]
		[Address(RVA = "0x5116DA0", Offset = "0x51159A0", VA = "0x185116DA0")]
		protected void Uncapture()
		{
		}

		// Token: 0x06000643 RID: 1603 RVA: 0x00004800 File Offset: 0x00002A00
		[Token(Token = "0x6000643")]
		[Address(RVA = "0x51165D0", Offset = "0x51151D0", VA = "0x1851165D0")]
		protected bool IsMatched(int cap)
		{
			return default(bool);
		}

		// Token: 0x06000644 RID: 1604 RVA: 0x00004818 File Offset: 0x00002A18
		[Token(Token = "0x6000644")]
		[Address(RVA = "0x5116620", Offset = "0x5115220", VA = "0x185116620")]
		protected int MatchIndex(int cap)
		{
			return 0;
		}

		// Token: 0x06000645 RID: 1605 RVA: 0x00004830 File Offset: 0x00002A30
		[Token(Token = "0x6000645")]
		[Address(RVA = "0x5116670", Offset = "0x5115270", VA = "0x185116670")]
		protected int MatchLength(int cap)
		{
			return 0;
		}

		// Token: 0x04000432 RID: 1074
		[Token(Token = "0x4000432")]
		[FieldOffset(Offset = "0x10")]
		protected internal int runtextbeg;

		// Token: 0x04000433 RID: 1075
		[Token(Token = "0x4000433")]
		[FieldOffset(Offset = "0x14")]
		protected internal int runtextend;

		// Token: 0x04000434 RID: 1076
		[Token(Token = "0x4000434")]
		[FieldOffset(Offset = "0x18")]
		protected internal int runtextstart;

		// Token: 0x04000435 RID: 1077
		[Token(Token = "0x4000435")]
		[FieldOffset(Offset = "0x20")]
		protected internal string runtext;

		// Token: 0x04000436 RID: 1078
		[Token(Token = "0x4000436")]
		[FieldOffset(Offset = "0x28")]
		protected internal int runtextpos;

		// Token: 0x04000437 RID: 1079
		[Token(Token = "0x4000437")]
		[FieldOffset(Offset = "0x30")]
		protected internal int[] runtrack;

		// Token: 0x04000438 RID: 1080
		[Token(Token = "0x4000438")]
		[FieldOffset(Offset = "0x38")]
		protected internal int runtrackpos;

		// Token: 0x04000439 RID: 1081
		[Token(Token = "0x4000439")]
		[FieldOffset(Offset = "0x40")]
		protected internal int[] runstack;

		// Token: 0x0400043A RID: 1082
		[Token(Token = "0x400043A")]
		[FieldOffset(Offset = "0x48")]
		protected internal int runstackpos;

		// Token: 0x0400043B RID: 1083
		[Token(Token = "0x400043B")]
		[FieldOffset(Offset = "0x50")]
		protected internal int[] runcrawl;

		// Token: 0x0400043C RID: 1084
		[Token(Token = "0x400043C")]
		[FieldOffset(Offset = "0x58")]
		protected internal int runcrawlpos;

		// Token: 0x0400043D RID: 1085
		[Token(Token = "0x400043D")]
		[FieldOffset(Offset = "0x5C")]
		protected internal int runtrackcount;

		// Token: 0x0400043E RID: 1086
		[Token(Token = "0x400043E")]
		[FieldOffset(Offset = "0x60")]
		protected internal Match runmatch;

		// Token: 0x0400043F RID: 1087
		[Token(Token = "0x400043F")]
		[FieldOffset(Offset = "0x68")]
		protected internal Regex runregex;

		// Token: 0x04000440 RID: 1088
		[Token(Token = "0x4000440")]
		[FieldOffset(Offset = "0x70")]
		private int _timeout;

		// Token: 0x04000441 RID: 1089
		[Token(Token = "0x4000441")]
		[FieldOffset(Offset = "0x74")]
		private bool _ignoreTimeout;

		// Token: 0x04000442 RID: 1090
		[Token(Token = "0x4000442")]
		[FieldOffset(Offset = "0x78")]
		private int _timeoutOccursAt;

		// Token: 0x04000443 RID: 1091
		[Token(Token = "0x4000443")]
		private const int TimeoutCheckFrequency = 1000;

		// Token: 0x04000444 RID: 1092
		[Token(Token = "0x4000444")]
		[FieldOffset(Offset = "0x7C")]
		private int _timeoutChecksToSkip;
	}
}
