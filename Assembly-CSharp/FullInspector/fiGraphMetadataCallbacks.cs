using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace FullInspector
{
	// Token: 0x02007BC5 RID: 31685
	[Token(Token = "0x2007BC5")]
	public static class fiGraphMetadataCallbacks
	{
		// Token: 0x0602C58F RID: 181647 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C58F")]
		public static IList Cast<T>(IList<T> list)
		{
			return null;
		}

		// Token: 0x04040225 RID: 262693
		[Token(Token = "0x4040225")]
		[FieldOffset(Offset = "0x0")]
		public static Action<fiGraphMetadata, IList, int> ListMetadataCallback;

		// Token: 0x04040226 RID: 262694
		[Token(Token = "0x4040226")]
		[FieldOffset(Offset = "0x8")]
		public static Action<fiGraphMetadata, InspectedProperty> PropertyMetadataCallback;

		// Token: 0x02007BC6 RID: 31686
		[Token(Token = "0x2007BC6")]
		private sealed class ListWrapper<T> : IList, ICollection, IEnumerable
		{
			// Token: 0x0602C591 RID: 181649 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602C591")]
			public ListWrapper(IList<T> list)
			{
			}

			// Token: 0x0602C592 RID: 181650 RVA: 0x000DFAB8 File Offset: 0x000DDCB8
			[Token(Token = "0x602C592")]
			public int Add(object value)
			{
				return 0;
			}

			// Token: 0x0602C593 RID: 181651 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602C593")]
			public void Clear()
			{
			}

			// Token: 0x0602C594 RID: 181652 RVA: 0x000DFAD0 File Offset: 0x000DDCD0
			[Token(Token = "0x602C594")]
			public bool Contains(object value)
			{
				return default(bool);
			}

			// Token: 0x0602C595 RID: 181653 RVA: 0x000DFAE8 File Offset: 0x000DDCE8
			[Token(Token = "0x602C595")]
			public int IndexOf(object value)
			{
				return 0;
			}

			// Token: 0x0602C596 RID: 181654 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602C596")]
			public void Insert(int index, object value)
			{
			}

			// Token: 0x170067D0 RID: 26576
			// (get) Token: 0x0602C597 RID: 181655 RVA: 0x000DFB00 File Offset: 0x000DDD00
			[Token(Token = "0x170067D0")]
			public bool IsFixedSize
			{
				[Token(Token = "0x602C597")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x170067D1 RID: 26577
			// (get) Token: 0x0602C598 RID: 181656 RVA: 0x000DFB18 File Offset: 0x000DDD18
			[Token(Token = "0x170067D1")]
			public bool IsReadOnly
			{
				[Token(Token = "0x602C598")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x0602C599 RID: 181657 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602C599")]
			public void Remove(object value)
			{
			}

			// Token: 0x0602C59A RID: 181658 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602C59A")]
			public void RemoveAt(int index)
			{
			}

			// Token: 0x170067D2 RID: 26578
			[Token(Token = "0x170067D2")]
			public object this[int index]
			{
				[Token(Token = "0x602C59B")]
				get
				{
					return null;
				}
				[Token(Token = "0x602C59C")]
				set
				{
				}
			}

			// Token: 0x0602C59D RID: 181661 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602C59D")]
			public void CopyTo(Array array, int index)
			{
			}

			// Token: 0x170067D3 RID: 26579
			// (get) Token: 0x0602C59E RID: 181662 RVA: 0x000DFB30 File Offset: 0x000DDD30
			[Token(Token = "0x170067D3")]
			public int Count
			{
				[Token(Token = "0x602C59E")]
				get
				{
					return 0;
				}
			}

			// Token: 0x170067D4 RID: 26580
			// (get) Token: 0x0602C59F RID: 181663 RVA: 0x000DFB48 File Offset: 0x000DDD48
			[Token(Token = "0x170067D4")]
			public bool IsSynchronized
			{
				[Token(Token = "0x602C59F")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x170067D5 RID: 26581
			// (get) Token: 0x0602C5A0 RID: 181664 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170067D5")]
			public object SyncRoot
			{
				[Token(Token = "0x602C5A0")]
				get
				{
					return null;
				}
			}

			// Token: 0x0602C5A1 RID: 181665 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602C5A1")]
			public IEnumerator GetEnumerator()
			{
				return null;
			}

			// Token: 0x04040227 RID: 262695
			[Token(Token = "0x4040227")]
			[FieldOffset(Offset = "0x0")]
			private readonly IList<T> _list;
		}
	}
}
