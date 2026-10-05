using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x0200005F RID: 95
	[Token(Token = "0x200005F")]
	[Preserve]
	internal class CollectionWrapper<T> : ICollection<T>, IEnumerable<T>, IEnumerable, IWrappedCollection, IList, ICollection
	{
		// Token: 0x0600033B RID: 827 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600033B")]
		public CollectionWrapper(IList list)
		{
		}

		// Token: 0x0600033C RID: 828 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600033C")]
		public CollectionWrapper(ICollection<T> list)
		{
		}

		// Token: 0x0600033D RID: 829 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600033D")]
		public virtual void Add(T item)
		{
		}

		// Token: 0x0600033E RID: 830 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600033E")]
		public virtual void Clear()
		{
		}

		// Token: 0x0600033F RID: 831 RVA: 0x000030D8 File Offset: 0x000012D8
		[Token(Token = "0x600033F")]
		public virtual bool Contains(T item)
		{
			return default(bool);
		}

		// Token: 0x06000340 RID: 832 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000340")]
		public virtual void CopyTo(T[] array, int arrayIndex)
		{
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x06000341 RID: 833 RVA: 0x000030F0 File Offset: 0x000012F0
		[Token(Token = "0x1700009C")]
		public virtual int Count
		{
			[Token(Token = "0x6000341")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x06000342 RID: 834 RVA: 0x00003108 File Offset: 0x00001308
		[Token(Token = "0x1700009D")]
		public virtual bool IsReadOnly
		{
			[Token(Token = "0x6000342")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000343 RID: 835 RVA: 0x00003120 File Offset: 0x00001320
		[Token(Token = "0x6000343")]
		public virtual bool Remove(T item)
		{
			return default(bool);
		}

		// Token: 0x06000344 RID: 836 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000344")]
		public virtual IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		// Token: 0x06000345 RID: 837 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000345")]
		private IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x06000346 RID: 838 RVA: 0x00003138 File Offset: 0x00001338
		[Token(Token = "0x6000346")]
		private int Add(object value)
		{
			return 0;
		}

		// Token: 0x06000347 RID: 839 RVA: 0x00003150 File Offset: 0x00001350
		[Token(Token = "0x6000347")]
		private bool Contains(object value)
		{
			return default(bool);
		}

		// Token: 0x06000348 RID: 840 RVA: 0x00003168 File Offset: 0x00001368
		[Token(Token = "0x6000348")]
		private int IndexOf(object value)
		{
			return 0;
		}

		// Token: 0x06000349 RID: 841 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000349")]
		private void RemoveAt(int index)
		{
		}

		// Token: 0x0600034A RID: 842 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600034A")]
		private void Insert(int index, object value)
		{
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x0600034B RID: 843 RVA: 0x00003180 File Offset: 0x00001380
		[Token(Token = "0x1700009E")]
		private bool IsFixedSize
		{
			[Token(Token = "0x600034B")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600034C RID: 844 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600034C")]
		private void Remove(object value)
		{
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x0600034D RID: 845 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600034E RID: 846 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700009F")]
		private object Item
		{
			[Token(Token = "0x600034D")]
			get
			{
				return null;
			}
			[Token(Token = "0x600034E")]
			set
			{
			}
		}

		// Token: 0x0600034F RID: 847 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600034F")]
		private void CopyTo(Array array, int arrayIndex)
		{
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x06000350 RID: 848 RVA: 0x00003198 File Offset: 0x00001398
		[Token(Token = "0x170000A0")]
		private bool IsSynchronized
		{
			[Token(Token = "0x6000350")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x06000351 RID: 849 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000A1")]
		private object SyncRoot
		{
			[Token(Token = "0x6000351")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000352 RID: 850 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000352")]
		private static void VerifyValueType(object value)
		{
		}

		// Token: 0x06000353 RID: 851 RVA: 0x000031B0 File Offset: 0x000013B0
		[Token(Token = "0x6000353")]
		private static bool IsCompatibleObject(object value)
		{
			return default(bool);
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x06000354 RID: 852 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000A2")]
		public object UnderlyingCollection
		{
			[Token(Token = "0x6000354")]
			get
			{
				return null;
			}
		}

		// Token: 0x040001D8 RID: 472
		[Token(Token = "0x40001D8")]
		[FieldOffset(Offset = "0x0")]
		private readonly IList _list;

		// Token: 0x040001D9 RID: 473
		[Token(Token = "0x40001D9")]
		[FieldOffset(Offset = "0x0")]
		private readonly ICollection<T> _genericCollection;

		// Token: 0x040001DA RID: 474
		[Token(Token = "0x40001DA")]
		[FieldOffset(Offset = "0x0")]
		private object _syncRoot;
	}
}
