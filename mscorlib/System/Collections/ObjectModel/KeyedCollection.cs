using System;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;

namespace System.Collections.ObjectModel
{
	// Token: 0x020005F5 RID: 1525
	[Token(Token = "0x20005F5")]
	[System.Diagnostics.DebuggerTypeProxy(typeof(CollectionDebugView<>))]
	[System.Diagnostics.DebuggerDisplay("Count = {Count}")]
	[System.Serializable]
	public abstract class KeyedCollection<TKey, TItem> : Collection<TItem>
	{
		// Token: 0x06002DFC RID: 11772 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DFC")]
		protected KeyedCollection()
		{
		}

		// Token: 0x06002DFD RID: 11773 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DFD")]
		protected KeyedCollection(System.Collections.Generic.IEqualityComparer<TKey> comparer)
		{
		}

		// Token: 0x06002DFE RID: 11774 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DFE")]
		protected KeyedCollection(System.Collections.Generic.IEqualityComparer<TKey> comparer, int dictionaryCreationThreshold)
		{
		}

		// Token: 0x17000769 RID: 1897
		// (get) Token: 0x06002DFF RID: 11775 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000769")]
		private new System.Collections.Generic.List<TItem> Items
		{
			[Token(Token = "0x6002DFF")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700076A RID: 1898
		[Token(Token = "0x1700076A")]
		public TItem this[TKey key]
		{
			[Token(Token = "0x6002E00")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002E01 RID: 11777 RVA: 0x00019050 File Offset: 0x00017250
		[Token(Token = "0x6002E01")]
		public bool Contains(TKey key)
		{
			return default(bool);
		}

		// Token: 0x06002E02 RID: 11778 RVA: 0x00019068 File Offset: 0x00017268
		[Token(Token = "0x6002E02")]
		public bool TryGetValue(TKey key, out TItem item)
		{
			return default(bool);
		}

		// Token: 0x1700076B RID: 1899
		// (get) Token: 0x06002E03 RID: 11779 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x1700076B")]
		protected System.Collections.Generic.IDictionary<TKey, TItem> Dictionary
		{
			[Token(Token = "0x6002E03")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002E04 RID: 11780 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E04")]
		protected override void ClearItems()
		{
		}

		// Token: 0x06002E05 RID: 11781
		[Token(Token = "0x6002E05")]
		protected abstract TKey GetKeyForItem(TItem item);

		// Token: 0x06002E06 RID: 11782 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E06")]
		protected override void InsertItem(int index, TItem item)
		{
		}

		// Token: 0x06002E07 RID: 11783 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E07")]
		protected override void RemoveItem(int index)
		{
		}

		// Token: 0x06002E08 RID: 11784 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E08")]
		protected override void SetItem(int index, TItem item)
		{
		}

		// Token: 0x06002E09 RID: 11785 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E09")]
		private void AddKey(TKey key, TItem item)
		{
		}

		// Token: 0x06002E0A RID: 11786 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E0A")]
		private void CreateDictionary()
		{
		}

		// Token: 0x06002E0B RID: 11787 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E0B")]
		private void RemoveKey(TKey key)
		{
		}

		// Token: 0x04001A1D RID: 6685
		[Token(Token = "0x4001A1D")]
		[FieldOffset(Offset = "0x0")]
		private readonly System.Collections.Generic.IEqualityComparer<TKey> comparer;

		// Token: 0x04001A1E RID: 6686
		[Token(Token = "0x4001A1E")]
		[FieldOffset(Offset = "0x0")]
		private System.Collections.Generic.Dictionary<TKey, TItem> dict;

		// Token: 0x04001A1F RID: 6687
		[Token(Token = "0x4001A1F")]
		[FieldOffset(Offset = "0x0")]
		private int keyCount;

		// Token: 0x04001A20 RID: 6688
		[Token(Token = "0x4001A20")]
		[FieldOffset(Offset = "0x0")]
		private readonly int threshold;
	}
}
