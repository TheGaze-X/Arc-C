using System;
using System.ComponentModel;
using Il2CppDummyDll;

namespace System.Configuration
{
	// Token: 0x02000416 RID: 1046
	[Token(Token = "0x2000416")]
	public abstract class ApplicationSettingsBase : SettingsBase, INotifyPropertyChanged
	{
		// Token: 0x06001BFC RID: 7164 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BFC")]
		[Address(RVA = "0x50BA560", Offset = "0x50B9160", VA = "0x1850BA560")]
		protected ApplicationSettingsBase()
		{
		}

		// Token: 0x06001BFD RID: 7165 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BFD")]
		[Address(RVA = "0x50BA500", Offset = "0x50B9100", VA = "0x1850BA500")]
		protected ApplicationSettingsBase(IComponent owner)
		{
		}

		// Token: 0x06001BFE RID: 7166 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BFE")]
		[Address(RVA = "0x50BA590", Offset = "0x50B9190", VA = "0x1850BA590")]
		protected ApplicationSettingsBase(IComponent owner, string settingsKey)
		{
		}

		// Token: 0x06001BFF RID: 7167 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BFF")]
		[Address(RVA = "0x50BA530", Offset = "0x50B9130", VA = "0x1850BA530")]
		protected ApplicationSettingsBase(string settingsKey)
		{
		}

		// Token: 0x1700066F RID: 1647
		// (get) Token: 0x06001C00 RID: 7168 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700066F")]
		public override SettingsContext Context
		{
			[Token(Token = "0x6001C00")]
			[Address(RVA = "0x50BA680", Offset = "0x50B9280", VA = "0x1850BA680", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000670 RID: 1648
		[Token(Token = "0x17000670")]
		public override object this[string propertyName]
		{
			[Token(Token = "0x6001C01")]
			[Address(RVA = "0x50BA6B0", Offset = "0x50B92B0", VA = "0x1850BA6B0", Slot = "5")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001C02")]
			[Address(RVA = "0x50BA860", Offset = "0x50B9460", VA = "0x1850BA860", Slot = "6")]
			set
			{
			}
		}

		// Token: 0x17000671 RID: 1649
		// (get) Token: 0x06001C03 RID: 7171 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000671")]
		public override SettingsPropertyCollection Properties
		{
			[Token(Token = "0x6001C03")]
			[Address(RVA = "0x50BA6E0", Offset = "0x50B92E0", VA = "0x1850BA6E0", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000672 RID: 1650
		// (get) Token: 0x06001C04 RID: 7172 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000672")]
		public override SettingsPropertyValueCollection PropertyValues
		{
			[Token(Token = "0x6001C04")]
			[Address(RVA = "0x50BA710", Offset = "0x50B9310", VA = "0x1850BA710", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000673 RID: 1651
		// (get) Token: 0x06001C05 RID: 7173 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000673")]
		public override SettingsProviderCollection Providers
		{
			[Token(Token = "0x6001C05")]
			[Address(RVA = "0x50BA740", Offset = "0x50B9340", VA = "0x1850BA740", Slot = "9")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000674 RID: 1652
		// (get) Token: 0x06001C06 RID: 7174 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001C07 RID: 7175 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000674")]
		public string SettingsKey
		{
			[Token(Token = "0x6001C06")]
			[Address(RVA = "0x50BA770", Offset = "0x50B9370", VA = "0x1850BA770")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001C07")]
			[Address(RVA = "0x50BA890", Offset = "0x50B9490", VA = "0x1850BA890")]
			set
			{
			}
		}

		// Token: 0x14000011 RID: 17
		// (add) Token: 0x06001C08 RID: 7176 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06001C09 RID: 7177 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000011")]
		public event PropertyChangedEventHandler PropertyChanged
		{
			[Token(Token = "0x6001C08")]
			[Address(RVA = "0x50BA5C0", Offset = "0x50B91C0", VA = "0x1850BA5C0", Slot = "11")]
			add
			{
			}
			[Token(Token = "0x6001C09")]
			[Address(RVA = "0x50BA7A0", Offset = "0x50B93A0", VA = "0x1850BA7A0", Slot = "12")]
			remove
			{
			}
		}

		// Token: 0x14000012 RID: 18
		// (add) Token: 0x06001C0A RID: 7178 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06001C0B RID: 7179 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000012")]
		public event SettingChangingEventHandler SettingChanging
		{
			[Token(Token = "0x6001C0A")]
			[Address(RVA = "0x50BA5F0", Offset = "0x50B91F0", VA = "0x1850BA5F0")]
			add
			{
			}
			[Token(Token = "0x6001C0B")]
			[Address(RVA = "0x50BA7D0", Offset = "0x50B93D0", VA = "0x1850BA7D0")]
			remove
			{
			}
		}

		// Token: 0x14000013 RID: 19
		// (add) Token: 0x06001C0C RID: 7180 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06001C0D RID: 7181 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000013")]
		public event SettingsLoadedEventHandler SettingsLoaded
		{
			[Token(Token = "0x6001C0C")]
			[Address(RVA = "0x50BA620", Offset = "0x50B9220", VA = "0x1850BA620")]
			add
			{
			}
			[Token(Token = "0x6001C0D")]
			[Address(RVA = "0x50BA800", Offset = "0x50B9400", VA = "0x1850BA800")]
			remove
			{
			}
		}

		// Token: 0x14000014 RID: 20
		// (add) Token: 0x06001C0E RID: 7182 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06001C0F RID: 7183 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000014")]
		public event SettingsSavingEventHandler SettingsSaving
		{
			[Token(Token = "0x6001C0E")]
			[Address(RVA = "0x50BA650", Offset = "0x50B9250", VA = "0x1850BA650")]
			add
			{
			}
			[Token(Token = "0x6001C0F")]
			[Address(RVA = "0x50BA830", Offset = "0x50B9430", VA = "0x1850BA830")]
			remove
			{
			}
		}

		// Token: 0x06001C10 RID: 7184 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C10")]
		[Address(RVA = "0x50BA350", Offset = "0x50B8F50", VA = "0x1850BA350")]
		public object GetPreviousVersion(string propertyName)
		{
			return null;
		}

		// Token: 0x06001C11 RID: 7185 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C11")]
		[Address(RVA = "0x50BA380", Offset = "0x50B8F80", VA = "0x1850BA380", Slot = "13")]
		protected virtual void OnPropertyChanged(object sender, PropertyChangedEventArgs e)
		{
		}

		// Token: 0x06001C12 RID: 7186 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C12")]
		[Address(RVA = "0x50BA3B0", Offset = "0x50B8FB0", VA = "0x1850BA3B0", Slot = "14")]
		protected virtual void OnSettingChanging(object sender, SettingChangingEventArgs e)
		{
		}

		// Token: 0x06001C13 RID: 7187 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C13")]
		[Address(RVA = "0x50BA3E0", Offset = "0x50B8FE0", VA = "0x1850BA3E0", Slot = "15")]
		protected virtual void OnSettingsLoaded(object sender, SettingsLoadedEventArgs e)
		{
		}

		// Token: 0x06001C14 RID: 7188 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C14")]
		[Address(RVA = "0x50BA410", Offset = "0x50B9010", VA = "0x1850BA410", Slot = "16")]
		protected virtual void OnSettingsSaving(object sender, CancelEventArgs e)
		{
		}

		// Token: 0x06001C15 RID: 7189 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C15")]
		[Address(RVA = "0x50BA440", Offset = "0x50B9040", VA = "0x1850BA440")]
		public void Reload()
		{
		}

		// Token: 0x06001C16 RID: 7190 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C16")]
		[Address(RVA = "0x50BA470", Offset = "0x50B9070", VA = "0x1850BA470")]
		public void Reset()
		{
		}

		// Token: 0x06001C17 RID: 7191 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C17")]
		[Address(RVA = "0x50BA4A0", Offset = "0x50B90A0", VA = "0x1850BA4A0", Slot = "10")]
		public override void Save()
		{
		}

		// Token: 0x06001C18 RID: 7192 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C18")]
		[Address(RVA = "0x50BA4D0", Offset = "0x50B90D0", VA = "0x1850BA4D0", Slot = "17")]
		public virtual void Upgrade()
		{
		}
	}
}
