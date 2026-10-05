using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace System.Buffers
{
	// Token: 0x0200063B RID: 1595
	[Token(Token = "0x200063B")]
	internal sealed class TlsOverPerCoreLockedStacksArrayPool<T> : ArrayPool<T>
	{
		// Token: 0x06002FE3 RID: 12259 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FE3")]
		public TlsOverPerCoreLockedStacksArrayPool()
		{
		}

		// Token: 0x06002FE4 RID: 12260 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002FE4")]
		private TlsOverPerCoreLockedStacksArrayPool<T>.PerCoreLockedStacks CreatePerCoreLockedStacks(int bucketIndex)
		{
			return null;
		}

		// Token: 0x170007BD RID: 1981
		// (get) Token: 0x06002FE5 RID: 12261 RVA: 0x00019F20 File Offset: 0x00018120
		[Token(Token = "0x170007BD")]
		private int Id
		{
			[Token(Token = "0x6002FE5")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06002FE6 RID: 12262 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002FE6")]
		public override T[] Rent(int minimumLength)
		{
			return null;
		}

		// Token: 0x06002FE7 RID: 12263 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FE7")]
		public override void Return(T[] array, bool clearArray = false)
		{
		}

		// Token: 0x06002FE8 RID: 12264 RVA: 0x00019F38 File Offset: 0x00018138
		[Token(Token = "0x6002FE8")]
		public bool Trim()
		{
			return default(bool);
		}

		// Token: 0x06002FE9 RID: 12265 RVA: 0x00019F50 File Offset: 0x00018150
		[Token(Token = "0x6002FE9")]
		private static bool Gen2GcCallbackFunc(object target)
		{
			return default(bool);
		}

		// Token: 0x06002FEA RID: 12266 RVA: 0x00019F68 File Offset: 0x00018168
		[Token(Token = "0x6002FEA")]
		private static TlsOverPerCoreLockedStacksArrayPool<T>.MemoryPressure GetMemoryPressure()
		{
			return TlsOverPerCoreLockedStacksArrayPool.MemoryPressure.Low;
		}

		// Token: 0x06002FEB RID: 12267 RVA: 0x00019F80 File Offset: 0x00018180
		[Token(Token = "0x6002FEB")]
		private static bool GetTrimBuffers()
		{
			return default(bool);
		}

		// Token: 0x04001A8F RID: 6799
		[Token(Token = "0x4001A8F")]
		[FieldOffset(Offset = "0x0")]
		private readonly int[] _bucketArraySizes;

		// Token: 0x04001A90 RID: 6800
		[Token(Token = "0x4001A90")]
		[FieldOffset(Offset = "0x0")]
		private readonly TlsOverPerCoreLockedStacksArrayPool<T>.PerCoreLockedStacks[] _buckets;

		// Token: 0x04001A91 RID: 6801
		[Token(Token = "0x4001A91")]
		[System.ThreadStatic]
		private static T[][] t_tlsBuckets;

		// Token: 0x04001A92 RID: 6802
		[Token(Token = "0x4001A92")]
		[FieldOffset(Offset = "0x0")]
		private int _callbackCreated;

		// Token: 0x04001A93 RID: 6803
		[Token(Token = "0x4001A93")]
		[FieldOffset(Offset = "0x0")]
		private static readonly bool s_trimBuffers;

		// Token: 0x04001A94 RID: 6804
		[Token(Token = "0x4001A94")]
		[FieldOffset(Offset = "0x0")]
		private static readonly System.Runtime.CompilerServices.ConditionalWeakTable<T[][], object> s_allTlsBuckets;

		// Token: 0x0200063C RID: 1596
		[Token(Token = "0x200063C")]
		private enum MemoryPressure
		{
			// Token: 0x04001A96 RID: 6806
			[Token(Token = "0x4001A96")]
			Low,
			// Token: 0x04001A97 RID: 6807
			[Token(Token = "0x4001A97")]
			Medium,
			// Token: 0x04001A98 RID: 6808
			[Token(Token = "0x4001A98")]
			High
		}

		// Token: 0x0200063D RID: 1597
		[Token(Token = "0x200063D")]
		private sealed class PerCoreLockedStacks
		{
			// Token: 0x06002FED RID: 12269 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002FED")]
			public PerCoreLockedStacks()
			{
			}

			// Token: 0x06002FEE RID: 12270 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002FEE")]
			[MethodImpl(256)]
			public void TryPush(T[] array)
			{
			}

			// Token: 0x06002FEF RID: 12271 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x6002FEF")]
			[MethodImpl(256)]
			public T[] TryPop()
			{
				return null;
			}

			// Token: 0x06002FF0 RID: 12272 RVA: 0x00019F98 File Offset: 0x00018198
			[Token(Token = "0x6002FF0")]
			public bool Trim(uint tickCount, int id, TlsOverPerCoreLockedStacksArrayPool<T>.MemoryPressure pressure, int[] bucketSizes)
			{
				return default(bool);
			}

			// Token: 0x04001A99 RID: 6809
			[Token(Token = "0x4001A99")]
			[FieldOffset(Offset = "0x0")]
			private readonly TlsOverPerCoreLockedStacksArrayPool<T>.LockedStack[] _perCoreStacks;
		}

		// Token: 0x0200063E RID: 1598
		[Token(Token = "0x200063E")]
		private sealed class LockedStack
		{
			// Token: 0x06002FF1 RID: 12273 RVA: 0x00019FB0 File Offset: 0x000181B0
			[Token(Token = "0x6002FF1")]
			[MethodImpl(256)]
			public bool TryPush(T[] array)
			{
				return default(bool);
			}

			// Token: 0x06002FF2 RID: 12274 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x6002FF2")]
			[MethodImpl(256)]
			public T[] TryPop()
			{
				return null;
			}

			// Token: 0x06002FF3 RID: 12275 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002FF3")]
			public void Trim(uint tickCount, int id, TlsOverPerCoreLockedStacksArrayPool<T>.MemoryPressure pressure, int bucketSize)
			{
			}

			// Token: 0x06002FF4 RID: 12276 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002FF4")]
			public LockedStack()
			{
			}

			// Token: 0x04001A9A RID: 6810
			[Token(Token = "0x4001A9A")]
			[FieldOffset(Offset = "0x0")]
			private readonly T[][] _arrays;

			// Token: 0x04001A9B RID: 6811
			[Token(Token = "0x4001A9B")]
			[FieldOffset(Offset = "0x0")]
			private int _count;

			// Token: 0x04001A9C RID: 6812
			[Token(Token = "0x4001A9C")]
			[FieldOffset(Offset = "0x0")]
			private uint _firstStackItemMS;
		}
	}
}
