using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace System.Globalization
{
	// Token: 0x0200059C RID: 1436
	[Token(Token = "0x200059C")]
	[System.Runtime.InteropServices.ComVisible(true)]
	[System.Serializable]
	[StructLayout(0)]
	public class RegionInfo
	{
		// Token: 0x17000699 RID: 1689
		// (get) Token: 0x06002B25 RID: 11045 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000699")]
		public static RegionInfo CurrentRegion
		{
			[Token(Token = "0x6002B25")]
			[Address(RVA = "0x4C6B8F0", Offset = "0x4C6A4F0", VA = "0x184C6B8F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002B26 RID: 11046 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B26")]
		[Address(RVA = "0x4C6B740", Offset = "0x4C6A340", VA = "0x184C6B740")]
		public RegionInfo(int culture)
		{
		}

		// Token: 0x06002B27 RID: 11047 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B27")]
		[Address(RVA = "0x4C6B340", Offset = "0x4C69F40", VA = "0x184C6B340")]
		public RegionInfo(string name)
		{
		}

		// Token: 0x06002B28 RID: 11048 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B28")]
		[Address(RVA = "0x4C6B530", Offset = "0x4C6A130", VA = "0x184C6B530")]
		private RegionInfo(CultureInfo ci)
		{
		}

		// Token: 0x06002B29 RID: 11049 RVA: 0x00017EE0 File Offset: 0x000160E0
		[Token(Token = "0x6002B29")]
		[Address(RVA = "0x4C6B200", Offset = "0x4C69E00", VA = "0x184C6B200")]
		private bool GetByTerritory(CultureInfo ci)
		{
			return default(bool);
		}

		// Token: 0x06002B2A RID: 11050
		[Token(Token = "0x6002B2A")]
		[Address(RVA = "0x4C6B8E0", Offset = "0x4C6A4E0", VA = "0x184C6B8E0")]
		[MethodImpl(4096)]
		private extern bool construct_internal_region_from_name(string name);

		// Token: 0x1700069A RID: 1690
		// (get) Token: 0x06002B2B RID: 11051 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x1700069A")]
		[System.Runtime.InteropServices.ComVisible(false)]
		public virtual string CurrencyEnglishName
		{
			[Token(Token = "0x6002B2B")]
			[Address(RVA = "0x5EC460", Offset = "0x5EB060", VA = "0x1805EC460", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700069B RID: 1691
		// (get) Token: 0x06002B2C RID: 11052 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x1700069B")]
		public virtual string CurrencySymbol
		{
			[Token(Token = "0x6002B2C")]
			[Address(RVA = "0x4EE950", Offset = "0x4ED550", VA = "0x1804EE950", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700069C RID: 1692
		// (get) Token: 0x06002B2D RID: 11053 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x1700069C")]
		[MonoTODO("DisplayName currently only returns the EnglishName")]
		public virtual string DisplayName
		{
			[Token(Token = "0x6002B2D")]
			[Address(RVA = "0x4EA8A0", Offset = "0x4E94A0", VA = "0x1804EA8A0", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700069D RID: 1693
		// (get) Token: 0x06002B2E RID: 11054 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x1700069D")]
		public virtual string EnglishName
		{
			[Token(Token = "0x6002B2E")]
			[Address(RVA = "0x4EA8A0", Offset = "0x4E94A0", VA = "0x1804EA8A0", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700069E RID: 1694
		// (get) Token: 0x06002B2F RID: 11055 RVA: 0x00017EF8 File Offset: 0x000160F8
		[Token(Token = "0x1700069E")]
		[System.Runtime.InteropServices.ComVisible(false)]
		public virtual int GeoId
		{
			[Token(Token = "0x6002B2F")]
			[Address(RVA = "0x4EA8B0", Offset = "0x4E94B0", VA = "0x1804EA8B0", Slot = "8")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700069F RID: 1695
		// (get) Token: 0x06002B30 RID: 11056 RVA: 0x00017F10 File Offset: 0x00016110
		[Token(Token = "0x1700069F")]
		public virtual bool IsMetric
		{
			[Token(Token = "0x6002B30")]
			[Address(RVA = "0x4C6B9D0", Offset = "0x4C6A5D0", VA = "0x184C6B9D0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170006A0 RID: 1696
		// (get) Token: 0x06002B31 RID: 11057 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170006A0")]
		public virtual string ISOCurrencySymbol
		{
			[Token(Token = "0x6002B31")]
			[Address(RVA = "0x4EE940", Offset = "0x4ED540", VA = "0x1804EE940", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x170006A1 RID: 1697
		// (get) Token: 0x06002B32 RID: 11058 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170006A1")]
		[System.Runtime.InteropServices.ComVisible(false)]
		public virtual string NativeName
		{
			[Token(Token = "0x6002B32")]
			[Address(RVA = "0x4EA850", Offset = "0x4E9450", VA = "0x1804EA850", Slot = "11")]
			get
			{
				return null;
			}
		}

		// Token: 0x170006A2 RID: 1698
		// (get) Token: 0x06002B33 RID: 11059 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170006A2")]
		[System.Runtime.InteropServices.ComVisible(false)]
		public virtual string CurrencyNativeName
		{
			[Token(Token = "0x6002B33")]
			[Address(RVA = "0x5EC4B0", Offset = "0x5EB0B0", VA = "0x1805EC4B0", Slot = "12")]
			get
			{
				return null;
			}
		}

		// Token: 0x170006A3 RID: 1699
		// (get) Token: 0x06002B34 RID: 11060 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170006A3")]
		public virtual string Name
		{
			[Token(Token = "0x6002B34")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80", Slot = "13")]
			get
			{
				return null;
			}
		}

		// Token: 0x170006A4 RID: 1700
		// (get) Token: 0x06002B35 RID: 11061 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170006A4")]
		public virtual string ThreeLetterISORegionName
		{
			[Token(Token = "0x6002B35")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x170006A5 RID: 1701
		// (get) Token: 0x06002B36 RID: 11062 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170006A5")]
		public virtual string ThreeLetterWindowsRegionName
		{
			[Token(Token = "0x6002B36")]
			[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070", Slot = "15")]
			get
			{
				return null;
			}
		}

		// Token: 0x170006A6 RID: 1702
		// (get) Token: 0x06002B37 RID: 11063 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170006A6")]
		public virtual string TwoLetterISORegionName
		{
			[Token(Token = "0x6002B37")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80", Slot = "16")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002B38 RID: 11064 RVA: 0x00017F28 File Offset: 0x00016128
		[Token(Token = "0x6002B38")]
		[Address(RVA = "0x4C6B0F0", Offset = "0x4C69CF0", VA = "0x184C6B0F0", Slot = "0")]
		public override bool Equals(object value)
		{
			return default(bool);
		}

		// Token: 0x06002B39 RID: 11065 RVA: 0x00017F40 File Offset: 0x00016140
		[Token(Token = "0x6002B39")]
		[Address(RVA = "0x4C6B2D0", Offset = "0x4C69ED0", VA = "0x184C6B2D0", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06002B3A RID: 11066 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002B3A")]
		[Address(RVA = "0xFACF90", Offset = "0xFABB90", VA = "0x180FACF90", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06002B3B RID: 11067 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B3B")]
		[Address(RVA = "0x4C6B0A0", Offset = "0x4C69CA0", VA = "0x184C6B0A0")]
		internal static void ClearCachedData()
		{
		}

		// Token: 0x04001919 RID: 6425
		[Token(Token = "0x4001919")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static RegionInfo currentRegion;

		// Token: 0x0400191A RID: 6426
		[Token(Token = "0x400191A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int regionId;

		// Token: 0x0400191B RID: 6427
		[Token(Token = "0x400191B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private string iso2Name;

		// Token: 0x0400191C RID: 6428
		[Token(Token = "0x400191C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private string iso3Name;

		// Token: 0x0400191D RID: 6429
		[Token(Token = "0x400191D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string win3Name;

		// Token: 0x0400191E RID: 6430
		[Token(Token = "0x400191E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private string englishName;

		// Token: 0x0400191F RID: 6431
		[Token(Token = "0x400191F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private string nativeName;

		// Token: 0x04001920 RID: 6432
		[Token(Token = "0x4001920")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private string currencySymbol;

		// Token: 0x04001921 RID: 6433
		[Token(Token = "0x4001921")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private string isoCurrencySymbol;

		// Token: 0x04001922 RID: 6434
		[Token(Token = "0x4001922")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private string currencyEnglishName;

		// Token: 0x04001923 RID: 6435
		[Token(Token = "0x4001923")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private string currencyNativeName;
	}
}
