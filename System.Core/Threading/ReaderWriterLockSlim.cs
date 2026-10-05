using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace System.Threading
{
	// Token: 0x0200007F RID: 127
	[Token(Token = "0x200007F")]
	public class ReaderWriterLockSlim : IDisposable
	{
		// Token: 0x06000415 RID: 1045 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000415")]
		[Address(RVA = "0x4F43D20", Offset = "0x4F42920", VA = "0x184F43D20")]
		private void InitializeThreadCounts()
		{
		}

		// Token: 0x06000416 RID: 1046 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000416")]
		[Address(RVA = "0x4F44FD0", Offset = "0x4F43BD0", VA = "0x184F44FD0")]
		public ReaderWriterLockSlim(LockRecursionPolicy recursionPolicy)
		{
		}

		// Token: 0x06000417 RID: 1047 RVA: 0x00003180 File Offset: 0x00001380
		[Token(Token = "0x6000417")]
		[Address(RVA = "0x4F43D30", Offset = "0x4F42930", VA = "0x184F43D30")]
		[MethodImpl(256)]
		private static bool IsRWEntryEmpty(ReaderWriterCount rwc)
		{
			return default(bool);
		}

		// Token: 0x06000418 RID: 1048 RVA: 0x00003198 File Offset: 0x00001398
		[Token(Token = "0x6000418")]
		[Address(RVA = "0x4F43D70", Offset = "0x4F42970", VA = "0x184F43D70")]
		private bool IsRwHashEntryChanged(ReaderWriterCount lrwc)
		{
			return default(bool);
		}

		// Token: 0x06000419 RID: 1049 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000419")]
		[Address(RVA = "0x4F43BE0", Offset = "0x4F427E0", VA = "0x184F43BE0")]
		[MethodImpl(256)]
		private ReaderWriterCount GetThreadRWCount(bool dontAllocate)
		{
			return null;
		}

		// Token: 0x0600041A RID: 1050 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600041A")]
		[Address(RVA = "0x4F43250", Offset = "0x4F41E50", VA = "0x184F43250")]
		public void EnterReadLock()
		{
		}

		// Token: 0x0600041B RID: 1051 RVA: 0x000031B0 File Offset: 0x000013B0
		[Token(Token = "0x600041B")]
		[Address(RVA = "0x4F44320", Offset = "0x4F42F20", VA = "0x184F44320")]
		public bool TryEnterReadLock(int millisecondsTimeout)
		{
			return default(bool);
		}

		// Token: 0x0600041C RID: 1052 RVA: 0x000031C8 File Offset: 0x000013C8
		[Token(Token = "0x600041C")]
		[Address(RVA = "0x4F443C0", Offset = "0x4F42FC0", VA = "0x184F443C0")]
		private bool TryEnterReadLock(ReaderWriterLockSlim.TimeoutTracker timeout)
		{
			return default(bool);
		}

		// Token: 0x0600041D RID: 1053 RVA: 0x000031E0 File Offset: 0x000013E0
		[Token(Token = "0x600041D")]
		[Address(RVA = "0x4F43F70", Offset = "0x4F42B70", VA = "0x184F43F70")]
		private bool TryEnterReadLockCore(ReaderWriterLockSlim.TimeoutTracker timeout)
		{
			return default(bool);
		}

		// Token: 0x0600041E RID: 1054 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600041E")]
		[Address(RVA = "0x4F43290", Offset = "0x4F41E90", VA = "0x184F43290")]
		public void EnterWriteLock()
		{
		}

		// Token: 0x0600041F RID: 1055 RVA: 0x000031F8 File Offset: 0x000013F8
		[Token(Token = "0x600041F")]
		[Address(RVA = "0x4F44DC0", Offset = "0x4F439C0", VA = "0x184F44DC0")]
		public bool TryEnterWriteLock(int millisecondsTimeout)
		{
			return default(bool);
		}

		// Token: 0x06000420 RID: 1056 RVA: 0x00003210 File Offset: 0x00001410
		[Token(Token = "0x6000420")]
		[Address(RVA = "0x4F44DB0", Offset = "0x4F439B0", VA = "0x184F44DB0")]
		private bool TryEnterWriteLock(ReaderWriterLockSlim.TimeoutTracker timeout)
		{
			return default(bool);
		}

		// Token: 0x06000421 RID: 1057 RVA: 0x00003228 File Offset: 0x00001428
		[Token(Token = "0x6000421")]
		[Address(RVA = "0x4F44910", Offset = "0x4F43510", VA = "0x184F44910")]
		private bool TryEnterWriteLockCore(ReaderWriterLockSlim.TimeoutTracker timeout)
		{
			return default(bool);
		}

		// Token: 0x06000422 RID: 1058 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000422")]
		[Address(RVA = "0x4F43270", Offset = "0x4F41E70", VA = "0x184F43270")]
		public void EnterUpgradeableReadLock()
		{
		}

		// Token: 0x06000423 RID: 1059 RVA: 0x00003240 File Offset: 0x00001440
		[Token(Token = "0x6000423")]
		[Address(RVA = "0x4F44870", Offset = "0x4F43470", VA = "0x184F44870")]
		public bool TryEnterUpgradeableReadLock(int millisecondsTimeout)
		{
			return default(bool);
		}

		// Token: 0x06000424 RID: 1060 RVA: 0x00003258 File Offset: 0x00001458
		[Token(Token = "0x6000424")]
		[Address(RVA = "0x4F44860", Offset = "0x4F43460", VA = "0x184F44860")]
		private bool TryEnterUpgradeableReadLock(ReaderWriterLockSlim.TimeoutTracker timeout)
		{
			return default(bool);
		}

		// Token: 0x06000425 RID: 1061 RVA: 0x00003270 File Offset: 0x00001470
		[Token(Token = "0x6000425")]
		[Address(RVA = "0x4F443D0", Offset = "0x4F42FD0", VA = "0x184F443D0")]
		private bool TryEnterUpgradeableReadLockCore(ReaderWriterLockSlim.TimeoutTracker timeout)
		{
			return default(bool);
		}

		// Token: 0x06000426 RID: 1062 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000426")]
		[Address(RVA = "0x4F434A0", Offset = "0x4F420A0", VA = "0x184F434A0")]
		public void ExitReadLock()
		{
		}

		// Token: 0x06000427 RID: 1063 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000427")]
		[Address(RVA = "0x4F439C0", Offset = "0x4F425C0", VA = "0x184F439C0")]
		public void ExitWriteLock()
		{
		}

		// Token: 0x06000428 RID: 1064 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000428")]
		[Address(RVA = "0x4F436A0", Offset = "0x4F422A0", VA = "0x184F436A0")]
		public void ExitUpgradeableReadLock()
		{
		}

		// Token: 0x06000429 RID: 1065 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000429")]
		[Address(RVA = "0x4F43DA0", Offset = "0x4F429A0", VA = "0x184F43DA0")]
		private void LazyCreateEvent(ref EventWaitHandle waitEvent, bool makeAutoResetEvent)
		{
		}

		// Token: 0x0600042A RID: 1066 RVA: 0x00003288 File Offset: 0x00001488
		[Token(Token = "0x600042A")]
		[Address(RVA = "0x4F44E60", Offset = "0x4F43A60", VA = "0x184F44E60")]
		private bool WaitOnEvent(EventWaitHandle waitEvent, ref uint numWaiters, ReaderWriterLockSlim.TimeoutTracker timeout, bool isWriteWaiter)
		{
			return default(bool);
		}

		// Token: 0x0600042B RID: 1067 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600042B")]
		[Address(RVA = "0x4F433E0", Offset = "0x4F41FE0", VA = "0x184F433E0")]
		private void ExitAndWakeUpAppropriateWaiters()
		{
		}

		// Token: 0x0600042C RID: 1068 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600042C")]
		[Address(RVA = "0x4F43350", Offset = "0x4F41F50", VA = "0x184F43350")]
		private void ExitAndWakeUpAppropriateWaitersPreferringWriters()
		{
		}

		// Token: 0x0600042D RID: 1069 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600042D")]
		[Address(RVA = "0x4F432B0", Offset = "0x4F41EB0", VA = "0x184F432B0")]
		private void ExitAndWakeUpAppropriateReadWaiters()
		{
		}

		// Token: 0x0600042E RID: 1070 RVA: 0x000032A0 File Offset: 0x000014A0
		[Token(Token = "0x600042E")]
		[Address(RVA = "0x4F43D90", Offset = "0x4F42990", VA = "0x184F43D90")]
		private bool IsWriterAcquired()
		{
			return default(bool);
		}

		// Token: 0x0600042F RID: 1071 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600042F")]
		[Address(RVA = "0x4F43ED0", Offset = "0x4F42AD0", VA = "0x184F43ED0")]
		private void SetWriterAcquired()
		{
		}

		// Token: 0x06000430 RID: 1072 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000430")]
		[Address(RVA = "0x4F42E00", Offset = "0x4F41A00", VA = "0x184F42E00")]
		private void ClearWriterAcquired()
		{
		}

		// Token: 0x06000431 RID: 1073 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000431")]
		[Address(RVA = "0x4F43EE0", Offset = "0x4F42AE0", VA = "0x184F43EE0")]
		private void SetWritersWaiting()
		{
		}

		// Token: 0x06000432 RID: 1074 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000432")]
		[Address(RVA = "0x4F42E10", Offset = "0x4F41A10", VA = "0x184F42E10")]
		private void ClearWritersWaiting()
		{
		}

		// Token: 0x06000433 RID: 1075 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000433")]
		[Address(RVA = "0x4F43EC0", Offset = "0x4F42AC0", VA = "0x184F43EC0")]
		private void SetUpgraderWaiting()
		{
		}

		// Token: 0x06000434 RID: 1076 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000434")]
		[Address(RVA = "0x4F42DF0", Offset = "0x4F419F0", VA = "0x184F42DF0")]
		private void ClearUpgraderWaiting()
		{
		}

		// Token: 0x06000435 RID: 1077 RVA: 0x000032B8 File Offset: 0x000014B8
		[Token(Token = "0x6000435")]
		[Address(RVA = "0x4F43BD0", Offset = "0x4F427D0", VA = "0x184F43BD0")]
		private uint GetNumReaders()
		{
			return 0U;
		}

		// Token: 0x06000436 RID: 1078 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000436")]
		[Address(RVA = "0x4F43210", Offset = "0x4F41E10", VA = "0x184F43210")]
		[MethodImpl(256)]
		private void EnterMyLock()
		{
		}

		// Token: 0x06000437 RID: 1079 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000437")]
		[Address(RVA = "0x4F43150", Offset = "0x4F41D50", VA = "0x184F43150")]
		private void EnterMyLockSpin()
		{
		}

		// Token: 0x06000438 RID: 1080 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000438")]
		[Address(RVA = "0x4F43480", Offset = "0x4F42080", VA = "0x184F43480")]
		private void ExitMyLock()
		{
		}

		// Token: 0x06000439 RID: 1081 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000439")]
		[Address(RVA = "0x4F43EF0", Offset = "0x4F42AF0", VA = "0x184F43EF0")]
		private static void SpinWait(int SpinCount)
		{
		}

		// Token: 0x0600043A RID: 1082 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600043A")]
		[Address(RVA = "0x4F43140", Offset = "0x4F41D40", VA = "0x184F43140", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x0600043B RID: 1083 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600043B")]
		[Address(RVA = "0x4F42E20", Offset = "0x4F41A20", VA = "0x184F42E20")]
		private void Dispose(bool disposing)
		{
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x0600043C RID: 1084 RVA: 0x000032D0 File Offset: 0x000014D0
		[Token(Token = "0x170000BC")]
		public bool IsReadLockHeld
		{
			[Token(Token = "0x600043C")]
			[Address(RVA = "0x4F45040", Offset = "0x4F43C40", VA = "0x184F45040")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x0600043D RID: 1085 RVA: 0x000032E8 File Offset: 0x000014E8
		[Token(Token = "0x170000BD")]
		public bool IsUpgradeableReadLockHeld
		{
			[Token(Token = "0x600043D")]
			[Address(RVA = "0x4F450B0", Offset = "0x4F43CB0", VA = "0x184F450B0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x0600043E RID: 1086 RVA: 0x00003300 File Offset: 0x00001500
		[Token(Token = "0x170000BE")]
		public bool IsWriteLockHeld
		{
			[Token(Token = "0x600043E")]
			[Address(RVA = "0x4F45150", Offset = "0x4F43D50", VA = "0x184F45150")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x0600043F RID: 1087 RVA: 0x00003318 File Offset: 0x00001518
		[Token(Token = "0x170000BF")]
		public int RecursiveReadCount
		{
			[Token(Token = "0x600043F")]
			[Address(RVA = "0x4F451F0", Offset = "0x4F43DF0", VA = "0x184F451F0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x06000440 RID: 1088 RVA: 0x00003330 File Offset: 0x00001530
		[Token(Token = "0x170000C0")]
		public int RecursiveUpgradeCount
		{
			[Token(Token = "0x6000440")]
			[Address(RVA = "0x4F45260", Offset = "0x4F43E60", VA = "0x184F45260")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x06000441 RID: 1089 RVA: 0x00003348 File Offset: 0x00001548
		[Token(Token = "0x170000C1")]
		public int RecursiveWriteCount
		{
			[Token(Token = "0x6000441")]
			[Address(RVA = "0x4F45320", Offset = "0x4F43F20", VA = "0x184F45320")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x06000442 RID: 1090 RVA: 0x00003360 File Offset: 0x00001560
		[Token(Token = "0x170000C2")]
		public int WaitingReadCount
		{
			[Token(Token = "0x6000442")]
			[Address(RVA = "0x4EA880", Offset = "0x4E9480", VA = "0x1804EA880")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x06000443 RID: 1091 RVA: 0x00003378 File Offset: 0x00001578
		[Token(Token = "0x170000C3")]
		public int WaitingUpgradeCount
		{
			[Token(Token = "0x6000443")]
			[Address(RVA = "0x4F6200", Offset = "0x4F4E00", VA = "0x1804F6200")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x06000444 RID: 1092 RVA: 0x00003390 File Offset: 0x00001590
		[Token(Token = "0x170000C4")]
		public int WaitingWriteCount
		{
			[Token(Token = "0x6000444")]
			[Address(RVA = "0x4EA860", Offset = "0x4E9460", VA = "0x1804EA860")]
			get
			{
				return 0;
			}
		}

		// Token: 0x04000191 RID: 401
		[Token(Token = "0x4000191")]
		[FieldOffset(Offset = "0x10")]
		private bool fIsReentrant;

		// Token: 0x04000192 RID: 402
		[Token(Token = "0x4000192")]
		[FieldOffset(Offset = "0x14")]
		private int myLock;

		// Token: 0x04000193 RID: 403
		[Token(Token = "0x4000193")]
		[FieldOffset(Offset = "0x18")]
		private uint numWriteWaiters;

		// Token: 0x04000194 RID: 404
		[Token(Token = "0x4000194")]
		[FieldOffset(Offset = "0x1C")]
		private uint numReadWaiters;

		// Token: 0x04000195 RID: 405
		[Token(Token = "0x4000195")]
		[FieldOffset(Offset = "0x20")]
		private uint numWriteUpgradeWaiters;

		// Token: 0x04000196 RID: 406
		[Token(Token = "0x4000196")]
		[FieldOffset(Offset = "0x24")]
		private uint numUpgradeWaiters;

		// Token: 0x04000197 RID: 407
		[Token(Token = "0x4000197")]
		[FieldOffset(Offset = "0x28")]
		private bool fNoWaiters;

		// Token: 0x04000198 RID: 408
		[Token(Token = "0x4000198")]
		[FieldOffset(Offset = "0x2C")]
		private int upgradeLockOwnerId;

		// Token: 0x04000199 RID: 409
		[Token(Token = "0x4000199")]
		[FieldOffset(Offset = "0x30")]
		private int writeLockOwnerId;

		// Token: 0x0400019A RID: 410
		[Token(Token = "0x400019A")]
		[FieldOffset(Offset = "0x38")]
		private EventWaitHandle writeEvent;

		// Token: 0x0400019B RID: 411
		[Token(Token = "0x400019B")]
		[FieldOffset(Offset = "0x40")]
		private EventWaitHandle readEvent;

		// Token: 0x0400019C RID: 412
		[Token(Token = "0x400019C")]
		[FieldOffset(Offset = "0x48")]
		private EventWaitHandle upgradeEvent;

		// Token: 0x0400019D RID: 413
		[Token(Token = "0x400019D")]
		[FieldOffset(Offset = "0x50")]
		private EventWaitHandle waitUpgradeEvent;

		// Token: 0x0400019E RID: 414
		[Token(Token = "0x400019E")]
		[FieldOffset(Offset = "0x0")]
		private static long s_nextLockID;

		// Token: 0x0400019F RID: 415
		[Token(Token = "0x400019F")]
		[FieldOffset(Offset = "0x58")]
		private long lockID;

		// Token: 0x040001A0 RID: 416
		[Token(Token = "0x40001A0")]
		[ThreadStatic]
		private static ReaderWriterCount t_rwc;

		// Token: 0x040001A1 RID: 417
		[Token(Token = "0x40001A1")]
		[FieldOffset(Offset = "0x60")]
		private bool fUpgradeThreadHoldingRead;

		// Token: 0x040001A2 RID: 418
		[Token(Token = "0x40001A2")]
		[FieldOffset(Offset = "0x64")]
		private uint owners;

		// Token: 0x040001A3 RID: 419
		[Token(Token = "0x40001A3")]
		[FieldOffset(Offset = "0x68")]
		private bool fDisposed;

		// Token: 0x02000080 RID: 128
		[Token(Token = "0x2000080")]
		private struct TimeoutTracker
		{
			// Token: 0x06000445 RID: 1093 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000445")]
			[Address(RVA = "0x4F466C0", Offset = "0x4F452C0", VA = "0x184F466C0")]
			public TimeoutTracker(int millisecondsTimeout)
			{
			}

			// Token: 0x170000C5 RID: 197
			// (get) Token: 0x06000446 RID: 1094 RVA: 0x000033A8 File Offset: 0x000015A8
			[Token(Token = "0x170000C5")]
			public int RemainingMilliseconds
			{
				[Token(Token = "0x6000446")]
				[Address(RVA = "0x4F46790", Offset = "0x4F45390", VA = "0x184F46790")]
				get
				{
					return 0;
				}
			}

			// Token: 0x170000C6 RID: 198
			// (get) Token: 0x06000447 RID: 1095 RVA: 0x000033C0 File Offset: 0x000015C0
			[Token(Token = "0x170000C6")]
			public bool IsExpired
			{
				[Token(Token = "0x6000447")]
				[Address(RVA = "0x4F46750", Offset = "0x4F45350", VA = "0x184F46750")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x040001A4 RID: 420
			[Token(Token = "0x40001A4")]
			[FieldOffset(Offset = "0x0")]
			private int m_total;

			// Token: 0x040001A5 RID: 421
			[Token(Token = "0x40001A5")]
			[FieldOffset(Offset = "0x4")]
			private int m_start;
		}
	}
}
