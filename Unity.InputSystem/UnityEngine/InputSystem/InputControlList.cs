using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using Unity.Collections;

namespace UnityEngine.InputSystem
{
	// Token: 0x02000077 RID: 119
	[Token(Token = "0x2000077")]
	[DebuggerDisplay("Count = {Count}")]
	public struct InputControlList<TControl> : IList<TControl>, ICollection<TControl>, IEnumerable<TControl>, IEnumerable, IReadOnlyList<TControl>, IReadOnlyCollection<TControl>, IDisposable where TControl : InputControl
	{
		// Token: 0x17000197 RID: 407
		// (get) Token: 0x060005B4 RID: 1460 RVA: 0x00004A28 File Offset: 0x00002C28
		[Token(Token = "0x17000197")]
		public int Count
		{
			[Token(Token = "0x60005B4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000198 RID: 408
		// (get) Token: 0x060005B5 RID: 1461 RVA: 0x00004A40 File Offset: 0x00002C40
		// (set) Token: 0x060005B6 RID: 1462 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000198")]
		public int Capacity
		{
			[Token(Token = "0x60005B5")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60005B6")]
			set
			{
			}
		}

		// Token: 0x17000199 RID: 409
		// (get) Token: 0x060005B7 RID: 1463 RVA: 0x00004A58 File Offset: 0x00002C58
		[Token(Token = "0x17000199")]
		public bool IsReadOnly
		{
			[Token(Token = "0x60005B7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700019A RID: 410
		[Token(Token = "0x1700019A")]
		public TControl this[int index]
		{
			[Token(Token = "0x60005B8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005B9")]
			set
			{
			}
		}

		// Token: 0x060005BA RID: 1466 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005BA")]
		public InputControlList(Allocator allocator, int initialCapacity = 0)
		{
		}

		// Token: 0x060005BB RID: 1467 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005BB")]
		public InputControlList(IEnumerable<TControl> values, Allocator allocator = Allocator.Persistent)
		{
		}

		// Token: 0x060005BC RID: 1468 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005BC")]
		public InputControlList(params TControl[] values)
		{
		}

		// Token: 0x060005BD RID: 1469 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005BD")]
		public void Resize(int size)
		{
		}

		// Token: 0x060005BE RID: 1470 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005BE")]
		public void Add(TControl item)
		{
		}

		// Token: 0x060005BF RID: 1471 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005BF")]
		public void AddSlice<TList>(TList list, int count = -1, int destinationIndex = -1, int sourceIndex = 0) where TList : IReadOnlyList<TControl>
		{
		}

		// Token: 0x060005C0 RID: 1472 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005C0")]
		public void AddRange(IEnumerable<TControl> list, int count = -1, int destinationIndex = -1)
		{
		}

		// Token: 0x060005C1 RID: 1473 RVA: 0x00004A70 File Offset: 0x00002C70
		[Token(Token = "0x60005C1")]
		public bool Remove(TControl item)
		{
			return default(bool);
		}

		// Token: 0x060005C2 RID: 1474 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005C2")]
		public void RemoveAt(int index)
		{
		}

		// Token: 0x060005C3 RID: 1475 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005C3")]
		public void CopyTo(TControl[] array, int arrayIndex)
		{
		}

		// Token: 0x060005C4 RID: 1476 RVA: 0x00004A88 File Offset: 0x00002C88
		[Token(Token = "0x60005C4")]
		public int IndexOf(TControl item)
		{
			return 0;
		}

		// Token: 0x060005C5 RID: 1477 RVA: 0x00004AA0 File Offset: 0x00002CA0
		[Token(Token = "0x60005C5")]
		public int IndexOf(TControl item, int startIndex, int count = -1)
		{
			return 0;
		}

		// Token: 0x060005C6 RID: 1478 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005C6")]
		public void Insert(int index, TControl item)
		{
		}

		// Token: 0x060005C7 RID: 1479 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005C7")]
		public void Clear()
		{
		}

		// Token: 0x060005C8 RID: 1480 RVA: 0x00004AB8 File Offset: 0x00002CB8
		[Token(Token = "0x60005C8")]
		public bool Contains(TControl item)
		{
			return default(bool);
		}

		// Token: 0x060005C9 RID: 1481 RVA: 0x00004AD0 File Offset: 0x00002CD0
		[Token(Token = "0x60005C9")]
		public bool Contains(TControl item, int startIndex, int count = -1)
		{
			return default(bool);
		}

		// Token: 0x060005CA RID: 1482 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005CA")]
		public void SwapElements(int index1, int index2)
		{
		}

		// Token: 0x060005CB RID: 1483 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005CB")]
		public void Sort<TCompare>(int startIndex, int count, TCompare comparer) where TCompare : IComparer<TControl>
		{
		}

		// Token: 0x060005CC RID: 1484 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60005CC")]
		public TControl[] ToArray(bool dispose = false)
		{
			return null;
		}

		// Token: 0x060005CD RID: 1485 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005CD")]
		internal void AppendTo(ref TControl[] array, ref int count)
		{
		}

		// Token: 0x060005CE RID: 1486 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005CE")]
		public void Dispose()
		{
		}

		// Token: 0x060005CF RID: 1487 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60005CF")]
		public IEnumerator<TControl> GetEnumerator()
		{
			return null;
		}

		// Token: 0x060005D0 RID: 1488 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60005D0")]
		private IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x060005D1 RID: 1489 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60005D1")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060005D2 RID: 1490 RVA: 0x00004AE8 File Offset: 0x00002CE8
		[Token(Token = "0x60005D2")]
		private static ulong ToIndex(TControl control)
		{
			return 0UL;
		}

		// Token: 0x060005D3 RID: 1491 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60005D3")]
		private static TControl FromIndex(ulong index)
		{
			return null;
		}

		// Token: 0x040002AD RID: 685
		[Token(Token = "0x40002AD")]
		[FieldOffset(Offset = "0x0")]
		private int m_Count;

		// Token: 0x040002AE RID: 686
		[Token(Token = "0x40002AE")]
		[FieldOffset(Offset = "0x0")]
		private NativeArray<ulong> m_Indices;

		// Token: 0x040002AF RID: 687
		[Token(Token = "0x40002AF")]
		[FieldOffset(Offset = "0x0")]
		private readonly Allocator m_Allocator;

		// Token: 0x040002B0 RID: 688
		[Token(Token = "0x40002B0")]
		private const ulong kInvalidIndex = 18446744073709551615UL;

		// Token: 0x02000078 RID: 120
		[Token(Token = "0x2000078")]
		private struct Enumerator : IEnumerator<TControl>, IEnumerator, IDisposable
		{
			// Token: 0x060005D4 RID: 1492 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60005D4")]
			public Enumerator(InputControlList<TControl> list)
			{
			}

			// Token: 0x060005D5 RID: 1493 RVA: 0x00004B00 File Offset: 0x00002D00
			[Token(Token = "0x60005D5")]
			public bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x060005D6 RID: 1494 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60005D6")]
			public void Reset()
			{
			}

			// Token: 0x1700019B RID: 411
			// (get) Token: 0x060005D7 RID: 1495 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x1700019B")]
			public TControl Current
			{
				[Token(Token = "0x60005D7")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700019C RID: 412
			// (get) Token: 0x060005D8 RID: 1496 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x1700019C")]
			private object Current
			{
				[Token(Token = "0x60005D8")]
				get
				{
					return null;
				}
			}

			// Token: 0x060005D9 RID: 1497 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60005D9")]
			public void Dispose()
			{
			}

			// Token: 0x040002B1 RID: 689
			[Token(Token = "0x40002B1")]
			[FieldOffset(Offset = "0x0")]
			private unsafe readonly ulong* m_Indices;

			// Token: 0x040002B2 RID: 690
			[Token(Token = "0x40002B2")]
			[FieldOffset(Offset = "0x0")]
			private readonly int m_Count;

			// Token: 0x040002B3 RID: 691
			[Token(Token = "0x40002B3")]
			[FieldOffset(Offset = "0x0")]
			private int m_Current;
		}
	}
}
