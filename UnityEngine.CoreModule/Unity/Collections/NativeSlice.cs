using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine.Internal;

namespace Unity.Collections
{
	// Token: 0x02000029 RID: 41
	[Token(Token = "0x2000029")]
	[DebuggerDisplay("Length = {Length}")]
	[DebuggerTypeProxy(typeof(NativeSliceDebugView<>))]
	[NativeContainer]
	[NativeContainerSupportsMinMaxWriteRestriction]
	public struct NativeSlice<T> : IEnumerable<T>, IEnumerable, IEquatable<NativeSlice<T>> where T : struct
	{
		// Token: 0x06000040 RID: 64 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000040")]
		public NativeSlice(NativeSlice<T> slice, int start, int length)
		{
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000041")]
		public NativeSlice(NativeArray<T> array)
		{
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00002190 File Offset: 0x00000390
		[Token(Token = "0x6000042")]
		public static implicit operator NativeSlice<T>(NativeArray<T> array)
		{
			return default(NativeSlice<T>);
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000043")]
		public NativeSlice(NativeArray<T> array, int start, int length)
		{
		}

		// Token: 0x17000008 RID: 8
		[Token(Token = "0x17000008")]
		public T this[int index]
		{
			[Token(Token = "0x6000044")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000045")]
			[WriteAccessRequired]
			set
			{
			}
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000046")]
		[WriteAccessRequired]
		public void CopyFrom(NativeSlice<T> slice)
		{
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000047")]
		[WriteAccessRequired]
		public void CopyFrom(T[] array)
		{
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000048 RID: 72 RVA: 0x000021A8 File Offset: 0x000003A8
		[Token(Token = "0x17000009")]
		public int Stride
		{
			[Token(Token = "0x6000048")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000049 RID: 73 RVA: 0x000021C0 File Offset: 0x000003C0
		[Token(Token = "0x1700000A")]
		public int Length
		{
			[Token(Token = "0x6000049")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600004A RID: 74 RVA: 0x000021D8 File Offset: 0x000003D8
		[Token(Token = "0x600004A")]
		public NativeSlice<T>.Enumerator GetEnumerator()
		{
			return default(NativeSlice<T>.Enumerator);
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600004B")]
		private IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600004C")]
		private IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x0600004D RID: 77 RVA: 0x000021F0 File Offset: 0x000003F0
		[Token(Token = "0x600004D")]
		public bool Equals(NativeSlice<T> other)
		{
			return default(bool);
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00002208 File Offset: 0x00000408
		[Token(Token = "0x600004E")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00002220 File Offset: 0x00000420
		[Token(Token = "0x600004F")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00002238 File Offset: 0x00000438
		[Token(Token = "0x6000050")]
		public static bool operator !=(NativeSlice<T> left, NativeSlice<T> right)
		{
			return default(bool);
		}

		// Token: 0x04000067 RID: 103
		[Token(Token = "0x4000067")]
		[FieldOffset(Offset = "0x0")]
		[NativeDisableUnsafePtrRestriction]
		internal unsafe byte* m_Buffer;

		// Token: 0x04000068 RID: 104
		[Token(Token = "0x4000068")]
		[FieldOffset(Offset = "0x0")]
		internal int m_Stride;

		// Token: 0x04000069 RID: 105
		[Token(Token = "0x4000069")]
		[FieldOffset(Offset = "0x0")]
		internal int m_Length;

		// Token: 0x0200002A RID: 42
		[Token(Token = "0x200002A")]
		[ExcludeFromDocs]
		public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
		{
			// Token: 0x06000051 RID: 81 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000051")]
			public Enumerator(ref NativeSlice<T> array)
			{
			}

			// Token: 0x06000052 RID: 82 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000052")]
			public void Dispose()
			{
			}

			// Token: 0x06000053 RID: 83 RVA: 0x00002250 File Offset: 0x00000450
			[Token(Token = "0x6000053")]
			public bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x06000054 RID: 84 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000054")]
			public void Reset()
			{
			}

			// Token: 0x1700000B RID: 11
			// (get) Token: 0x06000055 RID: 85 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x1700000B")]
			public T Current
			{
				[Token(Token = "0x6000055")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700000C RID: 12
			// (get) Token: 0x06000056 RID: 86 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x1700000C")]
			private object Current
			{
				[Token(Token = "0x6000056")]
				get
				{
					return null;
				}
			}

			// Token: 0x0400006A RID: 106
			[Token(Token = "0x400006A")]
			[FieldOffset(Offset = "0x0")]
			private NativeSlice<T> m_Array;

			// Token: 0x0400006B RID: 107
			[Token(Token = "0x400006B")]
			[FieldOffset(Offset = "0x0")]
			private int m_Index;
		}
	}
}
