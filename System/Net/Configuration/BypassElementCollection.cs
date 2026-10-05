using System;
using System.Configuration;
using Il2CppDummyDll;

namespace System.Net.Configuration
{
	// Token: 0x020003F3 RID: 1011
	[Token(Token = "0x20003F3")]
	[ConfigurationCollection(typeof(BypassElement))]
	public sealed class BypassElementCollection : ConfigurationElementCollection
	{
		// Token: 0x06001AFD RID: 6909 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AFD")]
		[Address(RVA = "0x50BB190", Offset = "0x50B9D90", VA = "0x1850BB190")]
		public BypassElementCollection()
		{
		}

		// Token: 0x06001AFE RID: 6910 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AFE")]
		[Address(RVA = "0x50BB1C0", Offset = "0x50B9DC0", VA = "0x1850BB1C0")]
		public BypassElement get_Item(int index)
		{
			return null;
		}

		// Token: 0x06001AFF RID: 6911 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AFF")]
		[Address(RVA = "0x50BB280", Offset = "0x50B9E80", VA = "0x1850BB280")]
		public void set_Item(int index, BypassElement value)
		{
		}

		// Token: 0x170005FB RID: 1531
		[Token(Token = "0x170005FB")]
		public BypassElement this[string name]
		{
			[Token(Token = "0x6001B00")]
			[Address(RVA = "0x50BB1F0", Offset = "0x50B9DF0", VA = "0x1850BB1F0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001B01")]
			[Address(RVA = "0x50BB250", Offset = "0x50B9E50", VA = "0x1850BB250")]
			set
			{
			}
		}

		// Token: 0x170005FC RID: 1532
		// (get) Token: 0x06001B02 RID: 6914 RVA: 0x0000BDF0 File Offset: 0x00009FF0
		[Token(Token = "0x170005FC")]
		protected override bool ThrowOnDuplicate
		{
			[Token(Token = "0x6001B02")]
			[Address(RVA = "0x50BB220", Offset = "0x50B9E20", VA = "0x1850BB220", Slot = "15")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06001B03 RID: 6915 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B03")]
		[Address(RVA = "0x50BB010", Offset = "0x50B9C10", VA = "0x1850BB010")]
		public void Add(BypassElement element)
		{
		}

		// Token: 0x06001B04 RID: 6916 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B04")]
		[Address(RVA = "0x50BB040", Offset = "0x50B9C40", VA = "0x1850BB040")]
		public void Clear()
		{
		}

		// Token: 0x06001B05 RID: 6917 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B05")]
		[Address(RVA = "0x50BB070", Offset = "0x50B9C70", VA = "0x1850BB070", Slot = "16")]
		protected override ConfigurationElement CreateNewElement()
		{
			return null;
		}

		// Token: 0x06001B06 RID: 6918 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B06")]
		[Address(RVA = "0x50BB0A0", Offset = "0x50B9CA0", VA = "0x1850BB0A0", Slot = "17")]
		protected override object GetElementKey(ConfigurationElement element)
		{
			return null;
		}

		// Token: 0x06001B07 RID: 6919 RVA: 0x0000BE08 File Offset: 0x0000A008
		[Token(Token = "0x6001B07")]
		[Address(RVA = "0x50BB0D0", Offset = "0x50B9CD0", VA = "0x1850BB0D0")]
		public int IndexOf(BypassElement element)
		{
			return 0;
		}

		// Token: 0x06001B08 RID: 6920 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B08")]
		[Address(RVA = "0x50BB130", Offset = "0x50B9D30", VA = "0x1850BB130")]
		public void Remove(BypassElement element)
		{
		}

		// Token: 0x06001B09 RID: 6921 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B09")]
		[Address(RVA = "0x50BB160", Offset = "0x50B9D60", VA = "0x1850BB160")]
		public void Remove(string name)
		{
		}

		// Token: 0x06001B0A RID: 6922 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B0A")]
		[Address(RVA = "0x50BB100", Offset = "0x50B9D00", VA = "0x1850BB100")]
		public void RemoveAt(int index)
		{
		}
	}
}
