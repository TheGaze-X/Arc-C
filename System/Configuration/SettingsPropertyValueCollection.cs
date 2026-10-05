using System;
using System.Collections;
using Il2CppDummyDll;

namespace System.Configuration
{
	// Token: 0x020003E9 RID: 1001
	[Token(Token = "0x20003E9")]
	public class SettingsPropertyValueCollection : ICollection, IEnumerable, ICloneable
	{
		// Token: 0x06001AC1 RID: 6849 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AC1")]
		[Address(RVA = "0x50BFA20", Offset = "0x50BE620", VA = "0x1850BFA20")]
		public SettingsPropertyValueCollection()
		{
		}

		// Token: 0x170005E8 RID: 1512
		// (get) Token: 0x06001AC2 RID: 6850 RVA: 0x0000BD60 File Offset: 0x00009F60
		[Token(Token = "0x170005E8")]
		public int Count
		{
			[Token(Token = "0x6001AC2")]
			[Address(RVA = "0x50BFA50", Offset = "0x50BE650", VA = "0x1850BFA50", Slot = "5")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170005E9 RID: 1513
		// (get) Token: 0x06001AC3 RID: 6851 RVA: 0x0000BD78 File Offset: 0x00009F78
		[Token(Token = "0x170005E9")]
		public bool IsSynchronized
		{
			[Token(Token = "0x6001AC3")]
			[Address(RVA = "0x50BFA80", Offset = "0x50BE680", VA = "0x1850BFA80", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170005EA RID: 1514
		[Token(Token = "0x170005EA")]
		public SettingsPropertyValue this[string name]
		{
			[Token(Token = "0x6001AC4")]
			[Address(RVA = "0x50BFAB0", Offset = "0x50BE6B0", VA = "0x1850BFAB0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170005EB RID: 1515
		// (get) Token: 0x06001AC5 RID: 6853 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005EB")]
		public object SyncRoot
		{
			[Token(Token = "0x6001AC5")]
			[Address(RVA = "0x50BFAE0", Offset = "0x50BE6E0", VA = "0x1850BFAE0", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001AC6 RID: 6854 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AC6")]
		[Address(RVA = "0x50BF8D0", Offset = "0x50BE4D0", VA = "0x1850BF8D0")]
		public void Add(SettingsPropertyValue property)
		{
		}

		// Token: 0x06001AC7 RID: 6855 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AC7")]
		[Address(RVA = "0x50BF900", Offset = "0x50BE500", VA = "0x1850BF900")]
		public void Clear()
		{
		}

		// Token: 0x06001AC8 RID: 6856 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AC8")]
		[Address(RVA = "0x50BF930", Offset = "0x50BE530", VA = "0x1850BF930", Slot = "9")]
		public object Clone()
		{
			return null;
		}

		// Token: 0x06001AC9 RID: 6857 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AC9")]
		[Address(RVA = "0x50BF960", Offset = "0x50BE560", VA = "0x1850BF960", Slot = "4")]
		public void CopyTo(Array array, int index)
		{
		}

		// Token: 0x06001ACA RID: 6858 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001ACA")]
		[Address(RVA = "0x50BF990", Offset = "0x50BE590", VA = "0x1850BF990", Slot = "8")]
		public IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x06001ACB RID: 6859 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001ACB")]
		[Address(RVA = "0x50BF9C0", Offset = "0x50BE5C0", VA = "0x1850BF9C0")]
		public void Remove(string name)
		{
		}

		// Token: 0x06001ACC RID: 6860 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001ACC")]
		[Address(RVA = "0x50BF9F0", Offset = "0x50BE5F0", VA = "0x1850BF9F0")]
		public void SetReadOnly()
		{
		}
	}
}
