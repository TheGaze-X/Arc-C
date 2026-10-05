using System;
using Il2CppDummyDll;

namespace System.Configuration
{
	// Token: 0x020003E7 RID: 999
	[Token(Token = "0x20003E7")]
	public class SettingsProperty
	{
		// Token: 0x06001AA8 RID: 6824 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AA8")]
		[Address(RVA = "0x50BFE40", Offset = "0x50BEA40", VA = "0x1850BFE40")]
		public SettingsProperty(SettingsProperty propertyToCopy)
		{
		}

		// Token: 0x06001AA9 RID: 6825 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AA9")]
		[Address(RVA = "0x50BFE10", Offset = "0x50BEA10", VA = "0x1850BFE10")]
		public SettingsProperty(string name)
		{
		}

		// Token: 0x06001AAA RID: 6826 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AAA")]
		[Address(RVA = "0x50BFE70", Offset = "0x50BEA70", VA = "0x1850BFE70")]
		public SettingsProperty(string name, Type propertyType, SettingsProvider provider, bool isReadOnly, object defaultValue, SettingsSerializeAs serializeAs, SettingsAttributeDictionary attributes, bool throwOnErrorDeserializing, bool throwOnErrorSerializing)
		{
		}

		// Token: 0x170005DE RID: 1502
		// (get) Token: 0x06001AAB RID: 6827 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005DE")]
		public virtual SettingsAttributeDictionary Attributes
		{
			[Token(Token = "0x6001AAB")]
			[Address(RVA = "0x50BFEA0", Offset = "0x50BEAA0", VA = "0x1850BFEA0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x170005DF RID: 1503
		// (get) Token: 0x06001AAC RID: 6828 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001AAD RID: 6829 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005DF")]
		public virtual object DefaultValue
		{
			[Token(Token = "0x6001AAC")]
			[Address(RVA = "0x50BFED0", Offset = "0x50BEAD0", VA = "0x1850BFED0", Slot = "5")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001AAD")]
			[Address(RVA = "0x50C0050", Offset = "0x50BEC50", VA = "0x1850C0050", Slot = "6")]
			set
			{
			}
		}

		// Token: 0x170005E0 RID: 1504
		// (get) Token: 0x06001AAE RID: 6830 RVA: 0x0000BD00 File Offset: 0x00009F00
		// (set) Token: 0x06001AAF RID: 6831 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005E0")]
		public virtual bool IsReadOnly
		{
			[Token(Token = "0x6001AAE")]
			[Address(RVA = "0x50BFF00", Offset = "0x50BEB00", VA = "0x1850BFF00", Slot = "7")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001AAF")]
			[Address(RVA = "0x50C0080", Offset = "0x50BEC80", VA = "0x1850C0080", Slot = "8")]
			set
			{
			}
		}

		// Token: 0x170005E1 RID: 1505
		// (get) Token: 0x06001AB0 RID: 6832 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001AB1 RID: 6833 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005E1")]
		public virtual string Name
		{
			[Token(Token = "0x6001AB0")]
			[Address(RVA = "0x50BFF30", Offset = "0x50BEB30", VA = "0x1850BFF30", Slot = "9")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001AB1")]
			[Address(RVA = "0x50C00B0", Offset = "0x50BECB0", VA = "0x1850C00B0", Slot = "10")]
			set
			{
			}
		}

		// Token: 0x170005E2 RID: 1506
		// (get) Token: 0x06001AB2 RID: 6834 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001AB3 RID: 6835 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005E2")]
		public virtual Type PropertyType
		{
			[Token(Token = "0x6001AB2")]
			[Address(RVA = "0x50BFF60", Offset = "0x50BEB60", VA = "0x1850BFF60", Slot = "11")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001AB3")]
			[Address(RVA = "0x50C00E0", Offset = "0x50BECE0", VA = "0x1850C00E0", Slot = "12")]
			set
			{
			}
		}

		// Token: 0x170005E3 RID: 1507
		// (get) Token: 0x06001AB4 RID: 6836 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001AB5 RID: 6837 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005E3")]
		public virtual SettingsProvider Provider
		{
			[Token(Token = "0x6001AB4")]
			[Address(RVA = "0x50BFF90", Offset = "0x50BEB90", VA = "0x1850BFF90", Slot = "13")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001AB5")]
			[Address(RVA = "0x50C0110", Offset = "0x50BED10", VA = "0x1850C0110", Slot = "14")]
			set
			{
			}
		}

		// Token: 0x170005E4 RID: 1508
		// (get) Token: 0x06001AB6 RID: 6838 RVA: 0x0000BD18 File Offset: 0x00009F18
		// (set) Token: 0x06001AB7 RID: 6839 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005E4")]
		public virtual SettingsSerializeAs SerializeAs
		{
			[Token(Token = "0x6001AB6")]
			[Address(RVA = "0x50BFFC0", Offset = "0x50BEBC0", VA = "0x1850BFFC0", Slot = "15")]
			get
			{
				return SettingsSerializeAs.String;
			}
			[Token(Token = "0x6001AB7")]
			[Address(RVA = "0x50C0140", Offset = "0x50BED40", VA = "0x1850C0140", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x170005E5 RID: 1509
		// (get) Token: 0x06001AB8 RID: 6840 RVA: 0x0000BD30 File Offset: 0x00009F30
		// (set) Token: 0x06001AB9 RID: 6841 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005E5")]
		public bool ThrowOnErrorDeserializing
		{
			[Token(Token = "0x6001AB8")]
			[Address(RVA = "0x50BFFF0", Offset = "0x50BEBF0", VA = "0x1850BFFF0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001AB9")]
			[Address(RVA = "0x50C0170", Offset = "0x50BED70", VA = "0x1850C0170")]
			set
			{
			}
		}

		// Token: 0x170005E6 RID: 1510
		// (get) Token: 0x06001ABA RID: 6842 RVA: 0x0000BD48 File Offset: 0x00009F48
		// (set) Token: 0x06001ABB RID: 6843 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005E6")]
		public bool ThrowOnErrorSerializing
		{
			[Token(Token = "0x6001ABA")]
			[Address(RVA = "0x50C0020", Offset = "0x50BEC20", VA = "0x1850C0020")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001ABB")]
			[Address(RVA = "0x50C01A0", Offset = "0x50BEDA0", VA = "0x1850C01A0")]
			set
			{
			}
		}
	}
}
