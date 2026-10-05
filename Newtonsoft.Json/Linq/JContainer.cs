using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Linq
{
	// Token: 0x020000CC RID: 204
	[Token(Token = "0x20000CC")]
	[Preserve]
	public abstract class JContainer : JToken, IList<JToken>, ICollection<JToken>, IEnumerable<JToken>, IEnumerable, ITypedList, IBindingList, IList, ICollection
	{
		// Token: 0x14000005 RID: 5
		// (add) Token: 0x0600073F RID: 1855 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06000740 RID: 1856 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000005")]
		public event ListChangedEventHandler ListChanged
		{
			[Token(Token = "0x600073F")]
			[Address(RVA = "0x4DBE970", Offset = "0x4DBD570", VA = "0x184DBE970", Slot = "48")]
			add
			{
			}
			[Token(Token = "0x6000740")]
			[Address(RVA = "0x4DBECE0", Offset = "0x4DBD8E0", VA = "0x184DBECE0", Slot = "49")]
			remove
			{
			}
		}

		// Token: 0x14000006 RID: 6
		// (add) Token: 0x06000741 RID: 1857 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06000742 RID: 1858 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000006")]
		public event System.ComponentModel.AddingNewEventHandler AddingNew
		{
			[Token(Token = "0x6000741")]
			[Address(RVA = "0x4DBE8D0", Offset = "0x4DBD4D0", VA = "0x184DBE8D0")]
			add
			{
			}
			[Token(Token = "0x6000742")]
			[Address(RVA = "0x4DBEC40", Offset = "0x4DBD840", VA = "0x184DBEC40")]
			remove
			{
			}
		}

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x06000743 RID: 1859
		[Token(Token = "0x1700015F")]
		protected abstract IList<JToken> ChildrenTokens { [Token(Token = "0x6000743")] get; }

		// Token: 0x06000744 RID: 1860 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000744")]
		[Address(RVA = "0x4DBE880", Offset = "0x4DBD480", VA = "0x184DBE880")]
		internal JContainer()
		{
		}

		// Token: 0x06000745 RID: 1861 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000745")]
		[Address(RVA = "0x4DBE640", Offset = "0x4DBD240", VA = "0x184DBE640")]
		internal JContainer(JContainer other)
		{
		}

		// Token: 0x06000746 RID: 1862 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000746")]
		[Address(RVA = "0x4DBAA00", Offset = "0x4DB9600", VA = "0x184DBAA00")]
		internal void CheckReentrancy()
		{
		}

		// Token: 0x06000747 RID: 1863 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000747")]
		[Address(RVA = "0x4DBB510", Offset = "0x4DBA110", VA = "0x184DBB510", Slot = "71")]
		internal virtual IList<JToken> CreateChildrenCollection()
		{
			return null;
		}

		// Token: 0x06000748 RID: 1864 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000748")]
		[Address(RVA = "0x45B3E30", Offset = "0x45B2A30", VA = "0x1845B3E30", Slot = "72")]
		protected virtual void OnAddingNew(System.ComponentModel.AddingNewEventArgs e)
		{
		}

		// Token: 0x06000749 RID: 1865 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000749")]
		[Address(RVA = "0x4DBC9D0", Offset = "0x4DBB5D0", VA = "0x184DBC9D0", Slot = "73")]
		protected virtual void OnListChanged(ListChangedEventArgs e)
		{
		}

		// Token: 0x17000160 RID: 352
		// (get) Token: 0x0600074A RID: 1866 RVA: 0x00004C08 File Offset: 0x00002E08
		[Token(Token = "0x17000160")]
		public override bool HasValues
		{
			[Token(Token = "0x600074A")]
			[Address(RVA = "0x4DBEB20", Offset = "0x4DBD720", VA = "0x184DBEB20", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600074B RID: 1867 RVA: 0x00004C20 File Offset: 0x00002E20
		[Token(Token = "0x600074B")]
		[Address(RVA = "0x4DBAE40", Offset = "0x4DB9A40", VA = "0x184DBAE40")]
		internal bool ContentsEqual(JContainer container)
		{
			return default(bool);
		}

		// Token: 0x17000161 RID: 353
		// (get) Token: 0x0600074C RID: 1868 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000161")]
		public override JToken First
		{
			[Token(Token = "0x600074C")]
			[Address(RVA = "0x4DBEA80", Offset = "0x4DBD680", VA = "0x184DBEA80", Slot = "18")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000162 RID: 354
		// (get) Token: 0x0600074D RID: 1869 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000162")]
		public override JToken Last
		{
			[Token(Token = "0x600074D")]
			[Address(RVA = "0x4DBEBA0", Offset = "0x4DBD7A0", VA = "0x184DBEBA0", Slot = "19")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600074E RID: 1870 RVA: 0x00004C38 File Offset: 0x00002E38
		[Token(Token = "0x600074E")]
		[Address(RVA = "0x4DBAAB0", Offset = "0x4DB96B0", VA = "0x184DBAAB0", Slot = "20")]
		public override JEnumerable<JToken> Children()
		{
			return default(JEnumerable<JToken>);
		}

		// Token: 0x0600074F RID: 1871 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600074F")]
		public override IEnumerable<T> Values<T>()
		{
			return null;
		}

		// Token: 0x06000750 RID: 1872 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000750")]
		[Address(RVA = "0x4DBB720", Offset = "0x4DBA320", VA = "0x184DBB720")]
		public IEnumerable<JToken> Descendants()
		{
			return null;
		}

		// Token: 0x06000751 RID: 1873 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000751")]
		[Address(RVA = "0x4DBB710", Offset = "0x4DBA310", VA = "0x184DBB710")]
		public IEnumerable<JToken> DescendantsAndSelf()
		{
			return null;
		}

		// Token: 0x06000752 RID: 1874 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000752")]
		[Address(RVA = "0x4DBB8B0", Offset = "0x4DBA4B0", VA = "0x184DBB8B0")]
		internal IEnumerable<JToken> GetDescendants(bool self)
		{
			return null;
		}

		// Token: 0x06000753 RID: 1875 RVA: 0x00004C50 File Offset: 0x00002E50
		[Token(Token = "0x6000753")]
		[Address(RVA = "0x4DBBCD0", Offset = "0x4DBA8D0", VA = "0x184DBBCD0")]
		internal bool IsMultiContent(object content)
		{
			return default(bool);
		}

		// Token: 0x06000754 RID: 1876 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000754")]
		[Address(RVA = "0x4DBB730", Offset = "0x4DBA330", VA = "0x184DBB730")]
		internal JToken EnsureParentToken(JToken item, bool skipParentCheck)
		{
			return null;
		}

		// Token: 0x06000755 RID: 1877
		[Token(Token = "0x6000755")]
		internal abstract int IndexOfItem(JToken item);

		// Token: 0x06000756 RID: 1878 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000756")]
		[Address(RVA = "0x4DBB9D0", Offset = "0x4DBA5D0", VA = "0x184DBB9D0", Slot = "75")]
		internal virtual void InsertItem(int index, JToken item, bool skipParentCheck)
		{
		}

		// Token: 0x06000757 RID: 1879 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000757")]
		[Address(RVA = "0x4DBD3C0", Offset = "0x4DBBFC0", VA = "0x184DBD3C0", Slot = "76")]
		internal virtual void RemoveItemAt(int index)
		{
		}

		// Token: 0x06000758 RID: 1880 RVA: 0x00004C68 File Offset: 0x00002E68
		[Token(Token = "0x6000758")]
		[Address(RVA = "0x4DBD6F0", Offset = "0x4DBC2F0", VA = "0x184DBD6F0", Slot = "77")]
		internal virtual bool RemoveItem(JToken item)
		{
			return default(bool);
		}

		// Token: 0x06000759 RID: 1881 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000759")]
		[Address(RVA = "0x4DBB950", Offset = "0x4DBA550", VA = "0x184DBB950", Slot = "78")]
		internal virtual JToken GetItem(int index)
		{
			return null;
		}

		// Token: 0x0600075A RID: 1882 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600075A")]
		[Address(RVA = "0x4DBD850", Offset = "0x4DBC450", VA = "0x184DBD850", Slot = "79")]
		internal virtual void SetItem(int index, JToken item)
		{
		}

		// Token: 0x0600075B RID: 1883 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600075B")]
		[Address(RVA = "0x4DBAB30", Offset = "0x4DB9730", VA = "0x184DBAB30", Slot = "80")]
		internal virtual void ClearItems()
		{
		}

		// Token: 0x0600075C RID: 1884 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600075C")]
		[Address(RVA = "0x4DBD7E0", Offset = "0x4DBC3E0", VA = "0x184DBD7E0", Slot = "81")]
		internal virtual void ReplaceItem(JToken existing, JToken replacement)
		{
		}

		// Token: 0x0600075D RID: 1885 RVA: 0x00004C80 File Offset: 0x00002E80
		[Token(Token = "0x600075D")]
		[Address(RVA = "0x4DBADF0", Offset = "0x4DB99F0", VA = "0x184DBADF0", Slot = "82")]
		internal virtual bool ContainsItem(JToken item)
		{
			return default(bool);
		}

		// Token: 0x0600075E RID: 1886 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600075E")]
		[Address(RVA = "0x4DBB210", Offset = "0x4DB9E10", VA = "0x184DBB210", Slot = "83")]
		internal virtual void CopyItemsTo(Array array, int arrayIndex)
		{
		}

		// Token: 0x0600075F RID: 1887 RVA: 0x00004C98 File Offset: 0x00002E98
		[Token(Token = "0x600075F")]
		[Address(RVA = "0x4DBBDD0", Offset = "0x4DBA9D0", VA = "0x184DBBDD0")]
		internal static bool IsTokenUnchanged(JToken currentValue, JToken newValue)
		{
			return default(bool);
		}

		// Token: 0x06000760 RID: 1888 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000760")]
		[Address(RVA = "0x4DBE4F0", Offset = "0x4DBD0F0", VA = "0x184DBE4F0", Slot = "84")]
		internal virtual void ValidateToken(JToken o, JToken existing)
		{
		}

		// Token: 0x06000761 RID: 1889 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000761")]
		[Address(RVA = "0x4DBA960", Offset = "0x4DB9560", VA = "0x184DBA960", Slot = "85")]
		public virtual void Add(object content)
		{
		}

		// Token: 0x06000762 RID: 1890 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000762")]
		[Address(RVA = "0x4DBA5C0", Offset = "0x4DB91C0", VA = "0x184DBA5C0")]
		internal void AddAndSkipParentCheck(JToken token)
		{
		}

		// Token: 0x06000763 RID: 1891 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000763")]
		[Address(RVA = "0x4DBA660", Offset = "0x4DB9260", VA = "0x184DBA660")]
		public void AddFirst(object content)
		{
		}

		// Token: 0x06000764 RID: 1892 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000764")]
		[Address(RVA = "0x4DBA680", Offset = "0x4DB9280", VA = "0x184DBA680")]
		internal void AddInternal(int index, object content, bool skipParentCheck)
		{
		}

		// Token: 0x06000765 RID: 1893 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000765")]
		[Address(RVA = "0x4DBB570", Offset = "0x4DBA170", VA = "0x184DBB570")]
		internal static JToken CreateFromContent(object content)
		{
			return null;
		}

		// Token: 0x06000766 RID: 1894 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000766")]
		[Address(RVA = "0x4DBB640", Offset = "0x4DBA240", VA = "0x184DBB640")]
		public JsonWriter CreateWriter()
		{
			return null;
		}

		// Token: 0x06000767 RID: 1895 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000767")]
		[Address(RVA = "0x4DBD770", Offset = "0x4DBC370", VA = "0x184DBD770")]
		public void ReplaceAll(object content)
		{
		}

		// Token: 0x06000768 RID: 1896 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000768")]
		[Address(RVA = "0x4DB81F0", Offset = "0x4DB6DF0", VA = "0x184DB81F0")]
		public void RemoveAll()
		{
		}

		// Token: 0x06000769 RID: 1897
		[Token(Token = "0x6000769")]
		internal abstract void MergeItem(object content, JsonMergeSettings settings);

		// Token: 0x0600076A RID: 1898 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600076A")]
		[Address(RVA = "0x4DBC940", Offset = "0x4DBB540", VA = "0x184DBC940")]
		public void Merge(object content)
		{
		}

		// Token: 0x0600076B RID: 1899 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600076B")]
		[Address(RVA = "0x4DBC8E0", Offset = "0x4DBB4E0", VA = "0x184DBC8E0")]
		public void Merge(object content, JsonMergeSettings settings)
		{
		}

		// Token: 0x0600076C RID: 1900 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600076C")]
		[Address(RVA = "0x4DBD1D0", Offset = "0x4DBBDD0", VA = "0x184DBD1D0")]
		internal void ReadTokenFrom(JsonReader reader, JsonLoadSettings options)
		{
		}

		// Token: 0x0600076D RID: 1901 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600076D")]
		[Address(RVA = "0x4DBCA40", Offset = "0x4DBB640", VA = "0x184DBCA40")]
		internal void ReadContentFrom(JsonReader r, JsonLoadSettings settings)
		{
		}

		// Token: 0x0600076E RID: 1902 RVA: 0x00004CB0 File Offset: 0x00002EB0
		[Token(Token = "0x600076E")]
		[Address(RVA = "0x4DBAFE0", Offset = "0x4DB9BE0", VA = "0x184DBAFE0")]
		internal int ContentsHashCode()
		{
			return 0;
		}

		// Token: 0x0600076F RID: 1903 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600076F")]
		[Address(RVA = "0x4DBE4B0", Offset = "0x4DBD0B0", VA = "0x184DBE4B0", Slot = "36")]
		private string GetListName(PropertyDescriptor[] listAccessors)
		{
			return null;
		}

		// Token: 0x06000770 RID: 1904 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000770")]
		[Address(RVA = "0x4DBE3A0", Offset = "0x4DBCFA0", VA = "0x184DBE3A0", Slot = "37")]
		private PropertyDescriptorCollection GetItemProperties(PropertyDescriptor[] listAccessors)
		{
			return null;
		}

		// Token: 0x06000771 RID: 1905 RVA: 0x00004CC8 File Offset: 0x00002EC8
		[Token(Token = "0x6000771")]
		[Address(RVA = "0x4DB88A0", Offset = "0x4DB74A0", VA = "0x184DB88A0", Slot = "26")]
		private int IndexOf(JToken item)
		{
			return 0;
		}

		// Token: 0x06000772 RID: 1906 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000772")]
		[Address(RVA = "0x4DB88F0", Offset = "0x4DB74F0", VA = "0x184DB88F0", Slot = "27")]
		private void Insert(int index, JToken item)
		{
		}

		// Token: 0x06000773 RID: 1907 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000773")]
		[Address(RVA = "0x4DB8E70", Offset = "0x4DB7A70", VA = "0x184DB8E70", Slot = "28")]
		private void RemoveAt(int index)
		{
		}

		// Token: 0x17000163 RID: 355
		// (get) Token: 0x06000774 RID: 1908 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000775 RID: 1909 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000163")]
		private JToken Item
		{
			[Token(Token = "0x6000774")]
			[Address(RVA = "0x4DB93E0", Offset = "0x4DB7FE0", VA = "0x184DB93E0", Slot = "24")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000775")]
			[Address(RVA = "0x4DB9430", Offset = "0x4DB8030", VA = "0x184DB9430", Slot = "25")]
			set
			{
			}
		}

		// Token: 0x06000776 RID: 1910 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000776")]
		[Address(RVA = "0x4DB81A0", Offset = "0x4DB6DA0", VA = "0x184DB81A0", Slot = "31")]
		private void Add(JToken item)
		{
		}

		// Token: 0x06000777 RID: 1911 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000777")]
		[Address(RVA = "0x4DB81F0", Offset = "0x4DB6DF0", VA = "0x184DB81F0", Slot = "32")]
		private void Clear()
		{
		}

		// Token: 0x06000778 RID: 1912 RVA: 0x00004CE0 File Offset: 0x00002EE0
		[Token(Token = "0x6000778")]
		[Address(RVA = "0x4DB8300", Offset = "0x4DB6F00", VA = "0x184DB8300", Slot = "33")]
		private bool Contains(JToken item)
		{
			return default(bool);
		}

		// Token: 0x06000779 RID: 1913 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000779")]
		[Address(RVA = "0x4DB8350", Offset = "0x4DB6F50", VA = "0x184DB8350", Slot = "34")]
		private void CopyTo(JToken[] array, int arrayIndex)
		{
		}

		// Token: 0x17000164 RID: 356
		// (get) Token: 0x0600077A RID: 1914 RVA: 0x00004CF8 File Offset: 0x00002EF8
		[Token(Token = "0x17000164")]
		private bool IsReadOnly
		{
			[Token(Token = "0x600077A")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "30")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600077B RID: 1915 RVA: 0x00004D10 File Offset: 0x00002F10
		[Token(Token = "0x600077B")]
		[Address(RVA = "0x4DB8EB0", Offset = "0x4DB7AB0", VA = "0x184DB8EB0", Slot = "35")]
		private bool Remove(JToken item)
		{
			return default(bool);
		}

		// Token: 0x0600077C RID: 1916 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600077C")]
		[Address(RVA = "0x4DBB7D0", Offset = "0x4DBA3D0", VA = "0x184DBB7D0")]
		private JToken EnsureValue(object value)
		{
			return null;
		}

		// Token: 0x0600077D RID: 1917 RVA: 0x00004D28 File Offset: 0x00002F28
		[Token(Token = "0x600077D")]
		[Address(RVA = "0x4DBDD50", Offset = "0x4DBC950", VA = "0x184DBDD50", Slot = "57")]
		private int Add(object value)
		{
			return 0;
		}

		// Token: 0x0600077E RID: 1918 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600077E")]
		[Address(RVA = "0x4DB81F0", Offset = "0x4DB6DF0", VA = "0x184DB81F0", Slot = "59")]
		private void Clear()
		{
		}

		// Token: 0x0600077F RID: 1919 RVA: 0x00004D40 File Offset: 0x00002F40
		[Token(Token = "0x600077F")]
		[Address(RVA = "0x4DBDE00", Offset = "0x4DBCA00", VA = "0x184DBDE00", Slot = "58")]
		private bool Contains(object value)
		{
			return default(bool);
		}

		// Token: 0x06000780 RID: 1920 RVA: 0x00004D58 File Offset: 0x00002F58
		[Token(Token = "0x6000780")]
		[Address(RVA = "0x4DBDE50", Offset = "0x4DBCA50", VA = "0x184DBDE50", Slot = "62")]
		private int IndexOf(object value)
		{
			return 0;
		}

		// Token: 0x06000781 RID: 1921 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000781")]
		[Address(RVA = "0x4DBDEA0", Offset = "0x4DBCAA0", VA = "0x184DBDEA0", Slot = "63")]
		private void Insert(int index, object value)
		{
		}

		// Token: 0x17000165 RID: 357
		// (get) Token: 0x06000782 RID: 1922 RVA: 0x00004D70 File Offset: 0x00002F70
		[Token(Token = "0x17000165")]
		private bool IsFixedSize
		{
			[Token(Token = "0x6000782")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "61")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000166 RID: 358
		// (get) Token: 0x06000783 RID: 1923 RVA: 0x00004D88 File Offset: 0x00002F88
		[Token(Token = "0x17000166")]
		private bool IsReadOnly
		{
			[Token(Token = "0x6000783")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "60")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000784 RID: 1924 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000784")]
		[Address(RVA = "0x4DBDF10", Offset = "0x4DBCB10", VA = "0x184DBDF10", Slot = "64")]
		private void Remove(object value)
		{
		}

		// Token: 0x06000785 RID: 1925 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000785")]
		[Address(RVA = "0x4DB8E70", Offset = "0x4DB7A70", VA = "0x184DB8E70", Slot = "65")]
		private void RemoveAt(int index)
		{
		}

		// Token: 0x17000167 RID: 359
		// (get) Token: 0x06000786 RID: 1926 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000787 RID: 1927 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000167")]
		private object Item
		{
			[Token(Token = "0x6000786")]
			[Address(RVA = "0x4DB93E0", Offset = "0x4DB7FE0", VA = "0x184DB93E0", Slot = "55")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000787")]
			[Address(RVA = "0x4DBDF60", Offset = "0x4DBCB60", VA = "0x184DBDF60", Slot = "56")]
			set
			{
			}
		}

		// Token: 0x06000788 RID: 1928 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000788")]
		[Address(RVA = "0x4DB8350", Offset = "0x4DB6F50", VA = "0x184DB8350", Slot = "66")]
		private void CopyTo(Array array, int index)
		{
		}

		// Token: 0x17000168 RID: 360
		// (get) Token: 0x06000789 RID: 1929 RVA: 0x00004DA0 File Offset: 0x00002FA0
		[Token(Token = "0x17000168")]
		public int Count
		{
			[Token(Token = "0x6000789")]
			[Address(RVA = "0x4DBEA10", Offset = "0x4DBD610", VA = "0x184DBEA10", Slot = "67")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000169 RID: 361
		// (get) Token: 0x0600078A RID: 1930 RVA: 0x00004DB8 File Offset: 0x00002FB8
		[Token(Token = "0x17000169")]
		private bool IsSynchronized
		{
			[Token(Token = "0x600078A")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "69")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700016A RID: 362
		// (get) Token: 0x0600078B RID: 1931 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700016A")]
		private object SyncRoot
		{
			[Token(Token = "0x600078B")]
			[Address(RVA = "0x4DBDCD0", Offset = "0x4DBC8D0", VA = "0x184DBDCD0", Slot = "68")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600078C RID: 1932 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600078C")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "50")]
		private void AddIndex(PropertyDescriptor property)
		{
		}

		// Token: 0x0600078D RID: 1933 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600078D")]
		[Address(RVA = "0x4DBDFC0", Offset = "0x4DBCBC0", VA = "0x184DBDFC0", Slot = "39")]
		private object AddNew()
		{
			return null;
		}

		// Token: 0x1700016B RID: 363
		// (get) Token: 0x0600078E RID: 1934 RVA: 0x00004DD0 File Offset: 0x00002FD0
		[Token(Token = "0x1700016B")]
		private bool AllowEdit
		{
			[Token(Token = "0x600078E")]
			[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "40")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700016C RID: 364
		// (get) Token: 0x0600078F RID: 1935 RVA: 0x00004DE8 File Offset: 0x00002FE8
		[Token(Token = "0x1700016C")]
		private bool AllowNew
		{
			[Token(Token = "0x600078F")]
			[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "38")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700016D RID: 365
		// (get) Token: 0x06000790 RID: 1936 RVA: 0x00004E00 File Offset: 0x00003000
		[Token(Token = "0x1700016D")]
		private bool AllowRemove
		{
			[Token(Token = "0x6000790")]
			[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "41")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000791 RID: 1937 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000791")]
		[Address(RVA = "0x4DBE2B0", Offset = "0x4DBCEB0", VA = "0x184DBE2B0", Slot = "51")]
		private void ApplySort(PropertyDescriptor property, ListSortDirection direction)
		{
		}

		// Token: 0x06000792 RID: 1938 RVA: 0x00004E18 File Offset: 0x00003018
		[Token(Token = "0x6000792")]
		[Address(RVA = "0x4DBE300", Offset = "0x4DBCF00", VA = "0x184DBE300", Slot = "52")]
		private int Find(PropertyDescriptor property, object key)
		{
			return 0;
		}

		// Token: 0x1700016E RID: 366
		// (get) Token: 0x06000793 RID: 1939 RVA: 0x00004E30 File Offset: 0x00003030
		[Token(Token = "0x1700016E")]
		private bool IsSorted
		{
			[Token(Token = "0x6000793")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "45")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000794 RID: 1940 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000794")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "53")]
		private void RemoveIndex(PropertyDescriptor property)
		{
		}

		// Token: 0x06000795 RID: 1941 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000795")]
		[Address(RVA = "0x4DBE350", Offset = "0x4DBCF50", VA = "0x184DBE350", Slot = "54")]
		private void RemoveSort()
		{
		}

		// Token: 0x1700016F RID: 367
		// (get) Token: 0x06000796 RID: 1942 RVA: 0x00004E48 File Offset: 0x00003048
		[Token(Token = "0x1700016F")]
		private ListSortDirection SortDirection
		{
			[Token(Token = "0x6000796")]
			[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "47")]
			get
			{
				return ListSortDirection.Ascending;
			}
		}

		// Token: 0x17000170 RID: 368
		// (get) Token: 0x06000797 RID: 1943 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000170")]
		private PropertyDescriptor SortProperty
		{
			[Token(Token = "0x6000797")]
			[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "46")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000171 RID: 369
		// (get) Token: 0x06000798 RID: 1944 RVA: 0x00004E60 File Offset: 0x00003060
		[Token(Token = "0x17000171")]
		private bool SupportsChangeNotification
		{
			[Token(Token = "0x6000798")]
			[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "42")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000172 RID: 370
		// (get) Token: 0x06000799 RID: 1945 RVA: 0x00004E78 File Offset: 0x00003078
		[Token(Token = "0x17000172")]
		private bool SupportsSearching
		{
			[Token(Token = "0x6000799")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "43")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000173 RID: 371
		// (get) Token: 0x0600079A RID: 1946 RVA: 0x00004E90 File Offset: 0x00003090
		[Token(Token = "0x17000173")]
		private bool SupportsSorting
		{
			[Token(Token = "0x600079A")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "44")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600079B RID: 1947 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600079B")]
		[Address(RVA = "0x4DBBEF0", Offset = "0x4DBAAF0", VA = "0x184DBBEF0")]
		internal static void MergeEnumerableContent(JContainer target, IEnumerable content, JsonMergeSettings settings)
		{
		}

		// Token: 0x0400031B RID: 795
		[Token(Token = "0x400031B")]
		[FieldOffset(Offset = "0x30")]
		internal ListChangedEventHandler _listChanged;

		// Token: 0x0400031C RID: 796
		[Token(Token = "0x400031C")]
		[FieldOffset(Offset = "0x38")]
		internal System.ComponentModel.AddingNewEventHandler _addingNew;

		// Token: 0x0400031D RID: 797
		[Token(Token = "0x400031D")]
		[FieldOffset(Offset = "0x40")]
		private object _syncRoot;

		// Token: 0x0400031E RID: 798
		[Token(Token = "0x400031E")]
		[FieldOffset(Offset = "0x48")]
		private bool _busy;
	}
}
