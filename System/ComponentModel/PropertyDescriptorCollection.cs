using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace System.ComponentModel
{
	// Token: 0x020001D4 RID: 468
	[Token(Token = "0x20001D4")]
	public class PropertyDescriptorCollection : ICollection, IEnumerable, IList, IDictionary
	{
		// Token: 0x06000C61 RID: 3169 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000C61")]
		[Address(RVA = "0x5162010", Offset = "0x5160C10", VA = "0x185162010")]
		public PropertyDescriptorCollection(PropertyDescriptor[] properties)
		{
		}

		// Token: 0x06000C62 RID: 3170 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000C62")]
		[Address(RVA = "0x51620E0", Offset = "0x5160CE0", VA = "0x1851620E0")]
		public PropertyDescriptorCollection(PropertyDescriptor[] properties, bool readOnly)
		{
		}

		// Token: 0x06000C63 RID: 3171 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000C63")]
		[Address(RVA = "0x5161EC0", Offset = "0x5160AC0", VA = "0x185161EC0")]
		private PropertyDescriptorCollection(PropertyDescriptor[] properties, int propCount, string[] namedSort, IComparer comparer)
		{
		}

		// Token: 0x1700028A RID: 650
		// (get) Token: 0x06000C64 RID: 3172 RVA: 0x00006EB8 File Offset: 0x000050B8
		// (set) Token: 0x06000C65 RID: 3173 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700028A")]
		public int Count
		{
			[Token(Token = "0x6000C64")]
			[Address(RVA = "0x14DAA90", Offset = "0x14D9690", VA = "0x1814DAA90")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000C65")]
			[Address(RVA = "0x14DAB10", Offset = "0x14D9710", VA = "0x1814DAB10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700028B RID: 651
		[Token(Token = "0x1700028B")]
		public virtual PropertyDescriptor this[int index]
		{
			[Token(Token = "0x6000C66")]
			[Address(RVA = "0x51621C0", Offset = "0x5160DC0", VA = "0x1851621C0", Slot = "31")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700028C RID: 652
		[Token(Token = "0x1700028C")]
		public virtual PropertyDescriptor this[string name]
		{
			[Token(Token = "0x6000C67")]
			[Address(RVA = "0x5162250", Offset = "0x5160E50", VA = "0x185162250", Slot = "32")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000C68 RID: 3176 RVA: 0x00006ED0 File Offset: 0x000050D0
		[Token(Token = "0x6000C68")]
		[Address(RVA = "0x515FA50", Offset = "0x515E650", VA = "0x18515FA50")]
		public int Add(PropertyDescriptor value)
		{
			return 0;
		}

		// Token: 0x06000C69 RID: 3177 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000C69")]
		[Address(RVA = "0x515FB40", Offset = "0x515E740", VA = "0x18515FB40")]
		public void Clear()
		{
		}

		// Token: 0x06000C6A RID: 3178 RVA: 0x00006EE8 File Offset: 0x000050E8
		[Token(Token = "0x6000C6A")]
		[Address(RVA = "0x515FBB0", Offset = "0x515E7B0", VA = "0x18515FBB0")]
		public bool Contains(PropertyDescriptor value)
		{
			return default(bool);
		}

		// Token: 0x06000C6B RID: 3179 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000C6B")]
		[Address(RVA = "0x515FC10", Offset = "0x515E810", VA = "0x18515FC10", Slot = "4")]
		public void CopyTo(Array array, int index)
		{
		}

		// Token: 0x06000C6C RID: 3180 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000C6C")]
		[Address(RVA = "0x515FC60", Offset = "0x515E860", VA = "0x18515FC60")]
		private void EnsurePropsOwned()
		{
		}

		// Token: 0x06000C6D RID: 3181 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000C6D")]
		[Address(RVA = "0x515FD20", Offset = "0x515E920", VA = "0x18515FD20")]
		private void EnsureSize(int sizeNeeded)
		{
		}

		// Token: 0x06000C6E RID: 3182 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C6E")]
		[Address(RVA = "0x515FE40", Offset = "0x515EA40", VA = "0x18515FE40", Slot = "33")]
		public virtual PropertyDescriptor Find(string name, bool ignoreCase)
		{
			return null;
		}

		// Token: 0x06000C6F RID: 3183 RVA: 0x00006F00 File Offset: 0x00005100
		[Token(Token = "0x6000C6F")]
		[Address(RVA = "0x5160370", Offset = "0x515EF70", VA = "0x185160370")]
		public int IndexOf(PropertyDescriptor value)
		{
			return 0;
		}

		// Token: 0x06000C70 RID: 3184 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000C70")]
		[Address(RVA = "0x51603D0", Offset = "0x515EFD0", VA = "0x1851603D0")]
		public void Insert(int index, PropertyDescriptor value)
		{
		}

		// Token: 0x06000C71 RID: 3185 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000C71")]
		[Address(RVA = "0x5160970", Offset = "0x515F570", VA = "0x185160970")]
		public void Remove(PropertyDescriptor value)
		{
		}

		// Token: 0x06000C72 RID: 3186 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000C72")]
		[Address(RVA = "0x51608A0", Offset = "0x515F4A0", VA = "0x1851608A0")]
		public void RemoveAt(int index)
		{
		}

		// Token: 0x06000C73 RID: 3187 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C73")]
		[Address(RVA = "0x5160B60", Offset = "0x515F760", VA = "0x185160B60", Slot = "34")]
		public virtual PropertyDescriptorCollection Sort()
		{
			return null;
		}

		// Token: 0x06000C74 RID: 3188 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C74")]
		[Address(RVA = "0x5160AC0", Offset = "0x515F6C0", VA = "0x185160AC0", Slot = "35")]
		public virtual PropertyDescriptorCollection Sort(string[] names)
		{
			return null;
		}

		// Token: 0x06000C75 RID: 3189 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C75")]
		[Address(RVA = "0x5160A20", Offset = "0x515F620", VA = "0x185160A20", Slot = "36")]
		public virtual PropertyDescriptorCollection Sort(string[] names, IComparer comparer)
		{
			return null;
		}

		// Token: 0x06000C76 RID: 3190 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C76")]
		[Address(RVA = "0x5160C00", Offset = "0x515F800", VA = "0x185160C00", Slot = "37")]
		public virtual PropertyDescriptorCollection Sort(IComparer comparer)
		{
			return null;
		}

		// Token: 0x06000C77 RID: 3191 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000C77")]
		[Address(RVA = "0x5160570", Offset = "0x515F170", VA = "0x185160570")]
		protected void InternalSort(string[] names)
		{
		}

		// Token: 0x06000C78 RID: 3192 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000C78")]
		[Address(RVA = "0x51604F0", Offset = "0x515F0F0", VA = "0x1851604F0")]
		protected void InternalSort(IComparer sorter)
		{
		}

		// Token: 0x06000C79 RID: 3193 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C79")]
		[Address(RVA = "0x51602C0", Offset = "0x515EEC0", VA = "0x1851602C0", Slot = "38")]
		public virtual IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x1700028D RID: 653
		// (get) Token: 0x06000C7A RID: 3194 RVA: 0x00006F18 File Offset: 0x00005118
		[Token(Token = "0x1700028D")]
		private bool IsSynchronized
		{
			[Token(Token = "0x6000C7A")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700028E RID: 654
		// (get) Token: 0x06000C7B RID: 3195 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700028E")]
		private object SyncRoot
		{
			[Token(Token = "0x6000C7B")]
			[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700028F RID: 655
		// (get) Token: 0x06000C7C RID: 3196 RVA: 0x00006F30 File Offset: 0x00005130
		[Token(Token = "0x1700028F")]
		private int Count
		{
			[Token(Token = "0x6000C7C")]
			[Address(RVA = "0x14DAA90", Offset = "0x14D9690", VA = "0x1814DAA90", Slot = "5")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000C7D RID: 3197 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000C7D")]
		[Address(RVA = "0x515FB40", Offset = "0x515E740", VA = "0x18515FB40", Slot = "13")]
		private void Clear()
		{
		}

		// Token: 0x06000C7E RID: 3198 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000C7E")]
		[Address(RVA = "0x515FB40", Offset = "0x515E740", VA = "0x18515FB40", Slot = "26")]
		private void Clear()
		{
		}

		// Token: 0x06000C7F RID: 3199 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C7F")]
		[Address(RVA = "0x4C6D600", Offset = "0x4C6C200", VA = "0x184C6D600", Slot = "8")]
		private IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x06000C80 RID: 3200 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000C80")]
		[Address(RVA = "0x5161AB0", Offset = "0x51606B0", VA = "0x185161AB0", Slot = "19")]
		private void RemoveAt(int index)
		{
		}

		// Token: 0x06000C81 RID: 3201 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000C81")]
		[Address(RVA = "0x5160CA0", Offset = "0x515F8A0", VA = "0x185160CA0", Slot = "25")]
		private void Add(object key, object value)
		{
		}

		// Token: 0x06000C82 RID: 3202 RVA: 0x00006F48 File Offset: 0x00005148
		[Token(Token = "0x6000C82")]
		[Address(RVA = "0x5160D90", Offset = "0x515F990", VA = "0x185160D90", Slot = "24")]
		private bool Contains(object key)
		{
			return default(bool);
		}

		// Token: 0x06000C83 RID: 3203 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C83")]
		[Address(RVA = "0x5160E50", Offset = "0x515FA50", VA = "0x185160E50", Slot = "29")]
		private IDictionaryEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x17000290 RID: 656
		// (get) Token: 0x06000C84 RID: 3204 RVA: 0x00006F60 File Offset: 0x00005160
		[Token(Token = "0x17000290")]
		private bool IsFixedSize
		{
			[Token(Token = "0x6000C84")]
			[Address(RVA = "0x1694D40", Offset = "0x1693940", VA = "0x181694D40", Slot = "28")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000291 RID: 657
		// (get) Token: 0x06000C85 RID: 3205 RVA: 0x00006F78 File Offset: 0x00005178
		[Token(Token = "0x17000291")]
		private bool IsReadOnly
		{
			[Token(Token = "0x6000C85")]
			[Address(RVA = "0x1694D40", Offset = "0x1693940", VA = "0x181694D40", Slot = "27")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000292 RID: 658
		// (get) Token: 0x06000C86 RID: 3206 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000C87 RID: 3207 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000292")]
		private object Item
		{
			[Token(Token = "0x6000C86")]
			[Address(RVA = "0x5160FA0", Offset = "0x515FBA0", VA = "0x185160FA0", Slot = "20")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000C87")]
			[Address(RVA = "0x5161260", Offset = "0x515FE60", VA = "0x185161260", Slot = "21")]
			set
			{
			}
		}

		// Token: 0x17000293 RID: 659
		// (get) Token: 0x06000C88 RID: 3208 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000293")]
		private ICollection Keys
		{
			[Token(Token = "0x6000C88")]
			[Address(RVA = "0x5161060", Offset = "0x515FC60", VA = "0x185161060", Slot = "22")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000294 RID: 660
		// (get) Token: 0x06000C89 RID: 3209 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000294")]
		private ICollection Values
		{
			[Token(Token = "0x6000C89")]
			[Address(RVA = "0x5161190", Offset = "0x515FD90", VA = "0x185161190", Slot = "23")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000C8A RID: 3210 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000C8A")]
		[Address(RVA = "0x5160ED0", Offset = "0x515FAD0", VA = "0x185160ED0", Slot = "30")]
		private void Remove(object key)
		{
		}

		// Token: 0x06000C8B RID: 3211 RVA: 0x00006F90 File Offset: 0x00005190
		[Token(Token = "0x6000C8B")]
		[Address(RVA = "0x5161670", Offset = "0x5160270", VA = "0x185161670", Slot = "11")]
		private int Add(object value)
		{
			return 0;
		}

		// Token: 0x06000C8C RID: 3212 RVA: 0x00006FA8 File Offset: 0x000051A8
		[Token(Token = "0x6000C8C")]
		[Address(RVA = "0x5161720", Offset = "0x5160320", VA = "0x185161720", Slot = "12")]
		private bool Contains(object value)
		{
			return default(bool);
		}

		// Token: 0x06000C8D RID: 3213 RVA: 0x00006FC0 File Offset: 0x000051C0
		[Token(Token = "0x6000C8D")]
		[Address(RVA = "0x5161810", Offset = "0x5160410", VA = "0x185161810", Slot = "16")]
		private int IndexOf(object value)
		{
			return 0;
		}

		// Token: 0x06000C8E RID: 3214 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000C8E")]
		[Address(RVA = "0x5161900", Offset = "0x5160500", VA = "0x185161900", Slot = "17")]
		private void Insert(int index, object value)
		{
		}

		// Token: 0x17000295 RID: 661
		// (get) Token: 0x06000C8F RID: 3215 RVA: 0x00006FD8 File Offset: 0x000051D8
		[Token(Token = "0x17000295")]
		private bool IsReadOnly
		{
			[Token(Token = "0x6000C8F")]
			[Address(RVA = "0x1694D40", Offset = "0x1693940", VA = "0x181694D40", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000296 RID: 662
		// (get) Token: 0x06000C90 RID: 3216 RVA: 0x00006FF0 File Offset: 0x000051F0
		[Token(Token = "0x17000296")]
		private bool IsFixedSize
		{
			[Token(Token = "0x6000C90")]
			[Address(RVA = "0x1694D40", Offset = "0x1693940", VA = "0x181694D40", Slot = "15")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000C91 RID: 3217 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000C91")]
		[Address(RVA = "0x5161AC0", Offset = "0x51606C0", VA = "0x185161AC0", Slot = "18")]
		private void Remove(object value)
		{
		}

		// Token: 0x17000297 RID: 663
		// (get) Token: 0x06000C92 RID: 3218 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000C93 RID: 3219 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000297")]
		private object Item
		{
			[Token(Token = "0x6000C92")]
			[Address(RVA = "0x5161C10", Offset = "0x5160810", VA = "0x185161C10", Slot = "9")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000C93")]
			[Address(RVA = "0x5161C60", Offset = "0x5160860", VA = "0x185161C60", Slot = "10")]
			set
			{
			}
		}

		// Token: 0x04000731 RID: 1841
		[Token(Token = "0x4000731")]
		[FieldOffset(Offset = "0x0")]
		public static readonly PropertyDescriptorCollection Empty;

		// Token: 0x04000732 RID: 1842
		[Token(Token = "0x4000732")]
		[FieldOffset(Offset = "0x10")]
		private IDictionary _cachedFoundProperties;

		// Token: 0x04000733 RID: 1843
		[Token(Token = "0x4000733")]
		[FieldOffset(Offset = "0x18")]
		private bool _cachedIgnoreCase;

		// Token: 0x04000734 RID: 1844
		[Token(Token = "0x4000734")]
		[FieldOffset(Offset = "0x20")]
		private PropertyDescriptor[] _properties;

		// Token: 0x04000735 RID: 1845
		[Token(Token = "0x4000735")]
		[FieldOffset(Offset = "0x28")]
		private readonly string[] _namedSort;

		// Token: 0x04000736 RID: 1846
		[Token(Token = "0x4000736")]
		[FieldOffset(Offset = "0x30")]
		private readonly IComparer _comparer;

		// Token: 0x04000737 RID: 1847
		[Token(Token = "0x4000737")]
		[FieldOffset(Offset = "0x38")]
		private bool _propsOwned;

		// Token: 0x04000738 RID: 1848
		[Token(Token = "0x4000738")]
		[FieldOffset(Offset = "0x39")]
		private bool _needSort;

		// Token: 0x04000739 RID: 1849
		[Token(Token = "0x4000739")]
		[FieldOffset(Offset = "0x3A")]
		private bool _readOnly;

		// Token: 0x0400073A RID: 1850
		[Token(Token = "0x400073A")]
		[FieldOffset(Offset = "0x40")]
		private readonly object _internalSyncObject;

		// Token: 0x020001D5 RID: 469
		[Token(Token = "0x20001D5")]
		private class PropertyDescriptorEnumerator : IDictionaryEnumerator, IEnumerator
		{
			// Token: 0x06000C95 RID: 3221 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000C95")]
			[Address(RVA = "0x4A5F040", Offset = "0x4A5DC40", VA = "0x184A5F040")]
			public PropertyDescriptorEnumerator(PropertyDescriptorCollection owner)
			{
			}

			// Token: 0x17000298 RID: 664
			// (get) Token: 0x06000C96 RID: 3222 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000298")]
			public object Current
			{
				[Token(Token = "0x6000C96")]
				[Address(RVA = "0x51622E0", Offset = "0x5160EE0", VA = "0x1851622E0", Slot = "8")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000299 RID: 665
			// (get) Token: 0x06000C97 RID: 3223 RVA: 0x00007008 File Offset: 0x00005208
			[Token(Token = "0x17000299")]
			public DictionaryEntry Entry
			{
				[Token(Token = "0x6000C97")]
				[Address(RVA = "0x51623C0", Offset = "0x5160FC0", VA = "0x1851623C0", Slot = "6")]
				get
				{
					return default(DictionaryEntry);
				}
			}

			// Token: 0x1700029A RID: 666
			// (get) Token: 0x06000C98 RID: 3224 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700029A")]
			public object Key
			{
				[Token(Token = "0x6000C98")]
				[Address(RVA = "0x5162470", Offset = "0x5161070", VA = "0x185162470", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700029B RID: 667
			// (get) Token: 0x06000C99 RID: 3225 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700029B")]
			public object Value
			{
				[Token(Token = "0x6000C99")]
				[Address(RVA = "0x5162470", Offset = "0x5161070", VA = "0x185162470", Slot = "5")]
				get
				{
					return null;
				}
			}

			// Token: 0x06000C9A RID: 3226 RVA: 0x00007020 File Offset: 0x00005220
			[Token(Token = "0x6000C9A")]
			[Address(RVA = "0x51622A0", Offset = "0x5160EA0", VA = "0x1851622A0", Slot = "7")]
			public bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x06000C9B RID: 3227 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000C9B")]
			[Address(RVA = "0x487E640", Offset = "0x487D240", VA = "0x18487E640", Slot = "9")]
			public void Reset()
			{
			}

			// Token: 0x0400073C RID: 1852
			[Token(Token = "0x400073C")]
			[FieldOffset(Offset = "0x10")]
			private PropertyDescriptorCollection _owner;

			// Token: 0x0400073D RID: 1853
			[Token(Token = "0x400073D")]
			[FieldOffset(Offset = "0x18")]
			private int _index;
		}
	}
}
