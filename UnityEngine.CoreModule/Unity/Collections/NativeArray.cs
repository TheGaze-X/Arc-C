using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine.Internal;

namespace Unity.Collections
{
	// Token: 0x02000025 RID: 37
	[Token(Token = "0x2000025")]
	[NativeContainerSupportsDeferredConvertListToArray]
	[NativeContainerSupportsDeallocateOnJobCompletion]
	[NativeContainerSupportsMinMaxWriteRestriction]
	[DebuggerDisplay("Length = {Length}")]
	[NativeContainer]
	[DebuggerTypeProxy(typeof(NativeArrayDebugView<>))]
	public struct NativeArray<T> : IDisposable, IEnumerable<T>, IEnumerable, IEquatable<NativeArray<T>> where T : struct
	{
		// Token: 0x06000021 RID: 33 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000021")]
		public NativeArray(int length, Allocator allocator, NativeArrayOptions options = NativeArrayOptions.ClearMemory)
		{
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000022")]
		public NativeArray(T[] array, Allocator allocator)
		{
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000023")]
		private static void Allocate(int length, Allocator allocator, out NativeArray<T> array)
		{
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000024 RID: 36 RVA: 0x000020B8 File Offset: 0x000002B8
		[Token(Token = "0x17000003")]
		public int Length
		{
			[Token(Token = "0x6000024")]
			[MethodImpl(256)]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000004 RID: 4
		[Token(Token = "0x17000004")]
		public T this[int index]
		{
			[Token(Token = "0x6000025")]
			[MethodImpl(256)]
			get
			{
				return null;
			}
			[Token(Token = "0x6000026")]
			[WriteAccessRequired]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000027 RID: 39 RVA: 0x000020D0 File Offset: 0x000002D0
		[Token(Token = "0x17000005")]
		public bool IsCreated
		{
			[Token(Token = "0x6000027")]
			[MethodImpl(256)]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000028")]
		[WriteAccessRequired]
		public void Dispose()
		{
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000029")]
		[WriteAccessRequired]
		public void CopyFrom(NativeArray<T> array)
		{
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600002A")]
		public T[] ToArray()
		{
			return null;
		}

		// Token: 0x0600002B RID: 43 RVA: 0x000020E8 File Offset: 0x000002E8
		[Token(Token = "0x600002B")]
		public NativeArray<T>.Enumerator GetEnumerator()
		{
			return default(NativeArray<T>.Enumerator);
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600002C")]
		private IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600002D")]
		private IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00002100 File Offset: 0x00000300
		[Token(Token = "0x600002E")]
		public bool Equals(NativeArray<T> other)
		{
			return default(bool);
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00002118 File Offset: 0x00000318
		[Token(Token = "0x600002F")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00002130 File Offset: 0x00000330
		[Token(Token = "0x6000030")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000031")]
		public static void Copy(NativeArray<T> src, NativeArray<T> dst)
		{
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000032")]
		public static void Copy(T[] src, NativeArray<T> dst)
		{
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000033")]
		public static void Copy(NativeArray<T> src, NativeArray<T> dst, int length)
		{
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000034")]
		public static void Copy(NativeArray<T> src, T[] dst, int length)
		{
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000035")]
		public static void Copy(NativeArray<T> src, int srcIndex, NativeArray<T> dst, int dstIndex, int length)
		{
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000036")]
		public static void Copy(T[] src, int srcIndex, NativeArray<T> dst, int dstIndex, int length)
		{
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000037")]
		public static void Copy(NativeArray<T> src, int srcIndex, T[] dst, int dstIndex, int length)
		{
		}

		// Token: 0x04000061 RID: 97
		[Token(Token = "0x4000061")]
		[FieldOffset(Offset = "0x0")]
		[NativeDisableUnsafePtrRestriction]
		internal unsafe void* m_Buffer;

		// Token: 0x04000062 RID: 98
		[Token(Token = "0x4000062")]
		[FieldOffset(Offset = "0x0")]
		internal int m_Length;

		// Token: 0x04000063 RID: 99
		[Token(Token = "0x4000063")]
		[FieldOffset(Offset = "0x0")]
		internal Allocator m_AllocatorLabel;

		// Token: 0x02000026 RID: 38
		[Token(Token = "0x2000026")]
		[ExcludeFromDocs]
		public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
		{
			// Token: 0x06000038 RID: 56 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000038")]
			public Enumerator(ref NativeArray<T> array)
			{
			}

			// Token: 0x06000039 RID: 57 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000039")]
			public void Dispose()
			{
			}

			// Token: 0x0600003A RID: 58 RVA: 0x00002148 File Offset: 0x00000348
			[Token(Token = "0x600003A")]
			[MethodImpl(256)]
			public bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x0600003B RID: 59 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600003B")]
			public void Reset()
			{
			}

			// Token: 0x17000006 RID: 6
			// (get) Token: 0x0600003C RID: 60 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17000006")]
			public T Current
			{
				[Token(Token = "0x600003C")]
				[MethodImpl(256)]
				get
				{
					return null;
				}
			}

			// Token: 0x17000007 RID: 7
			// (get) Token: 0x0600003D RID: 61 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17000007")]
			private object Current
			{
				[Token(Token = "0x600003D")]
				[MethodImpl(256)]
				get
				{
					return null;
				}
			}

			// Token: 0x04000064 RID: 100
			[Token(Token = "0x4000064")]
			[FieldOffset(Offset = "0x0")]
			private NativeArray<T> m_Array;

			// Token: 0x04000065 RID: 101
			[Token(Token = "0x4000065")]
			[FieldOffset(Offset = "0x0")]
			private int m_Index;

			// Token: 0x04000066 RID: 102
			[Token(Token = "0x4000066")]
			[FieldOffset(Offset = "0x0")]
			private T value;
		}
	}
}
