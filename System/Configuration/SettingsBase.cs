using System;
using Il2CppDummyDll;

namespace System.Configuration
{
	// Token: 0x020003E4 RID: 996
	[Token(Token = "0x20003E4")]
	public abstract class SettingsBase
	{
		// Token: 0x06001A8A RID: 6794 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A8A")]
		[Address(RVA = "0x50BF060", Offset = "0x50BDC60", VA = "0x1850BF060")]
		protected SettingsBase()
		{
		}

		// Token: 0x170005D4 RID: 1492
		// (get) Token: 0x06001A8B RID: 6795 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005D4")]
		public virtual SettingsContext Context
		{
			[Token(Token = "0x6001A8B")]
			[Address(RVA = "0x50BF090", Offset = "0x50BDC90", VA = "0x1850BF090", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x170005D5 RID: 1493
		// (get) Token: 0x06001A8C RID: 6796 RVA: 0x0000BCB8 File Offset: 0x00009EB8
		[Token(Token = "0x170005D5")]
		public bool IsSynchronized
		{
			[Token(Token = "0x6001A8C")]
			[Address(RVA = "0x50BF0C0", Offset = "0x50BDCC0", VA = "0x1850BF0C0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170005D6 RID: 1494
		[Token(Token = "0x170005D6")]
		public virtual object this[string propertyName]
		{
			[Token(Token = "0x6001A8D")]
			[Address(RVA = "0x50BF0F0", Offset = "0x50BDCF0", VA = "0x1850BF0F0", Slot = "5")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001A8E")]
			[Address(RVA = "0x50BF1B0", Offset = "0x50BDDB0", VA = "0x1850BF1B0", Slot = "6")]
			set
			{
			}
		}

		// Token: 0x170005D7 RID: 1495
		// (get) Token: 0x06001A8F RID: 6799 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005D7")]
		public virtual SettingsPropertyCollection Properties
		{
			[Token(Token = "0x6001A8F")]
			[Address(RVA = "0x50BF120", Offset = "0x50BDD20", VA = "0x1850BF120", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x170005D8 RID: 1496
		// (get) Token: 0x06001A90 RID: 6800 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005D8")]
		public virtual SettingsPropertyValueCollection PropertyValues
		{
			[Token(Token = "0x6001A90")]
			[Address(RVA = "0x50BF150", Offset = "0x50BDD50", VA = "0x1850BF150", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x170005D9 RID: 1497
		// (get) Token: 0x06001A91 RID: 6801 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005D9")]
		public virtual SettingsProviderCollection Providers
		{
			[Token(Token = "0x6001A91")]
			[Address(RVA = "0x50BF180", Offset = "0x50BDD80", VA = "0x1850BF180", Slot = "9")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001A92 RID: 6802 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A92")]
		[Address(RVA = "0x50BEFD0", Offset = "0x50BDBD0", VA = "0x1850BEFD0")]
		public void Initialize(SettingsContext context, SettingsPropertyCollection properties, SettingsProviderCollection providers)
		{
		}

		// Token: 0x06001A93 RID: 6803 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A93")]
		[Address(RVA = "0x50BF000", Offset = "0x50BDC00", VA = "0x1850BF000", Slot = "10")]
		public virtual void Save()
		{
		}

		// Token: 0x06001A94 RID: 6804 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A94")]
		[Address(RVA = "0x50BF030", Offset = "0x50BDC30", VA = "0x1850BF030")]
		public static SettingsBase Synchronized(SettingsBase settingsBase)
		{
			return null;
		}
	}
}
