using System;
using System.Collections;
using Il2CppDummyDll;

namespace System.Configuration
{
	// Token: 0x020003E6 RID: 998
	[Token(Token = "0x20003E6")]
	public class SettingsPropertyCollection : ICollection, IEnumerable, ICloneable
	{
		// Token: 0x06001A96 RID: 6806 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A96")]
		[Address(RVA = "0x50BF660", Offset = "0x50BE260", VA = "0x1850BF660")]
		public SettingsPropertyCollection()
		{
		}

		// Token: 0x170005DA RID: 1498
		// (get) Token: 0x06001A97 RID: 6807 RVA: 0x0000BCD0 File Offset: 0x00009ED0
		[Token(Token = "0x170005DA")]
		public int Count
		{
			[Token(Token = "0x6001A97")]
			[Address(RVA = "0x50BF690", Offset = "0x50BE290", VA = "0x1850BF690", Slot = "5")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170005DB RID: 1499
		// (get) Token: 0x06001A98 RID: 6808 RVA: 0x0000BCE8 File Offset: 0x00009EE8
		[Token(Token = "0x170005DB")]
		public bool IsSynchronized
		{
			[Token(Token = "0x6001A98")]
			[Address(RVA = "0x50BF6C0", Offset = "0x50BE2C0", VA = "0x1850BF6C0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170005DC RID: 1500
		[Token(Token = "0x170005DC")]
		public SettingsProperty this[string name]
		{
			[Token(Token = "0x6001A99")]
			[Address(RVA = "0x50BF6F0", Offset = "0x50BE2F0", VA = "0x1850BF6F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170005DD RID: 1501
		// (get) Token: 0x06001A9A RID: 6810 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005DD")]
		public object SyncRoot
		{
			[Token(Token = "0x6001A9A")]
			[Address(RVA = "0x50BF720", Offset = "0x50BE320", VA = "0x1850BF720", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001A9B RID: 6811 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A9B")]
		[Address(RVA = "0x50BF3F0", Offset = "0x50BDFF0", VA = "0x1850BF3F0")]
		public void Add(SettingsProperty property)
		{
		}

		// Token: 0x06001A9C RID: 6812 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A9C")]
		[Address(RVA = "0x50BF420", Offset = "0x50BE020", VA = "0x1850BF420")]
		public void Clear()
		{
		}

		// Token: 0x06001A9D RID: 6813 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A9D")]
		[Address(RVA = "0x50BF450", Offset = "0x50BE050", VA = "0x1850BF450", Slot = "9")]
		public object Clone()
		{
			return null;
		}

		// Token: 0x06001A9E RID: 6814 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A9E")]
		[Address(RVA = "0x50BF480", Offset = "0x50BE080", VA = "0x1850BF480", Slot = "4")]
		public void CopyTo(Array array, int index)
		{
		}

		// Token: 0x06001A9F RID: 6815 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A9F")]
		[Address(RVA = "0x50BF4B0", Offset = "0x50BE0B0", VA = "0x1850BF4B0", Slot = "8")]
		public IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x06001AA0 RID: 6816 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AA0")]
		[Address(RVA = "0x50BF510", Offset = "0x50BE110", VA = "0x1850BF510", Slot = "10")]
		protected virtual void OnAdd(SettingsProperty property)
		{
		}

		// Token: 0x06001AA1 RID: 6817 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AA1")]
		[Address(RVA = "0x50BF4E0", Offset = "0x50BE0E0", VA = "0x1850BF4E0", Slot = "11")]
		protected virtual void OnAddComplete(SettingsProperty property)
		{
		}

		// Token: 0x06001AA2 RID: 6818 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AA2")]
		[Address(RVA = "0x50BF570", Offset = "0x50BE170", VA = "0x1850BF570", Slot = "12")]
		protected virtual void OnClear()
		{
		}

		// Token: 0x06001AA3 RID: 6819 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AA3")]
		[Address(RVA = "0x50BF540", Offset = "0x50BE140", VA = "0x1850BF540", Slot = "13")]
		protected virtual void OnClearComplete()
		{
		}

		// Token: 0x06001AA4 RID: 6820 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AA4")]
		[Address(RVA = "0x50BF5D0", Offset = "0x50BE1D0", VA = "0x1850BF5D0", Slot = "14")]
		protected virtual void OnRemove(SettingsProperty property)
		{
		}

		// Token: 0x06001AA5 RID: 6821 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AA5")]
		[Address(RVA = "0x50BF5A0", Offset = "0x50BE1A0", VA = "0x1850BF5A0", Slot = "15")]
		protected virtual void OnRemoveComplete(SettingsProperty property)
		{
		}

		// Token: 0x06001AA6 RID: 6822 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AA6")]
		[Address(RVA = "0x50BF600", Offset = "0x50BE200", VA = "0x1850BF600")]
		public void Remove(string name)
		{
		}

		// Token: 0x06001AA7 RID: 6823 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AA7")]
		[Address(RVA = "0x50BF630", Offset = "0x50BE230", VA = "0x1850BF630")]
		public void SetReadOnly()
		{
		}
	}
}
