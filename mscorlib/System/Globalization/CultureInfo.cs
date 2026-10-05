using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Mono.Interop;

namespace System.Globalization
{
	// Token: 0x02000596 RID: 1430
	[Token(Token = "0x2000596")]
	[System.Runtime.InteropServices.ComVisible(true)]
	[System.Serializable]
	[StructLayout(0)]
	public class CultureInfo : System.ICloneable, System.IFormatProvider
	{
		// Token: 0x17000680 RID: 1664
		// (get) Token: 0x06002AC8 RID: 10952 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000680")]
		internal CultureData _cultureData
		{
			[Token(Token = "0x6002AC8")]
			[Address(RVA = "0x20BBCF0", Offset = "0x20BA8F0", VA = "0x1820BBCF0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000681 RID: 1665
		// (get) Token: 0x06002AC9 RID: 10953 RVA: 0x00017D60 File Offset: 0x00015F60
		[Token(Token = "0x17000681")]
		internal bool _isInherited
		{
			[Token(Token = "0x6002AC9")]
			[Address(RVA = "0x371A210", Offset = "0x3718E10", VA = "0x18371A210")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000682 RID: 1666
		// (get) Token: 0x06002ACA RID: 10954 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000682")]
		public static CultureInfo InvariantCulture
		{
			[Token(Token = "0x6002ACA")]
			[Address(RVA = "0x4C4B350", Offset = "0x4C49F50", VA = "0x184C4B350")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000683 RID: 1667
		// (get) Token: 0x06002ACB RID: 10955 RVA: 0x000020CA File Offset: 0x000002CA
		// (set) Token: 0x06002ACC RID: 10956 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000683")]
		public static CultureInfo CurrentCulture
		{
			[Token(Token = "0x6002ACB")]
			[Address(RVA = "0x4C4AF30", Offset = "0x4C49B30", VA = "0x184C4AF30")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002ACC")]
			[Address(RVA = "0x4C4BB40", Offset = "0x4C4A740", VA = "0x184C4BB40")]
			set
			{
			}
		}

		// Token: 0x17000684 RID: 1668
		// (get) Token: 0x06002ACD RID: 10957 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000684")]
		public static CultureInfo CurrentUICulture
		{
			[Token(Token = "0x6002ACD")]
			[Address(RVA = "0x4C4AF60", Offset = "0x4C49B60", VA = "0x184C4AF60")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002ACE RID: 10958 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002ACE")]
		[Address(RVA = "0x4C46200", Offset = "0x4C44E00", VA = "0x184C46200")]
		internal static CultureInfo ConstructCurrentCulture()
		{
			return null;
		}

		// Token: 0x06002ACF RID: 10959 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002ACF")]
		[Address(RVA = "0x4C463F0", Offset = "0x4C44FF0", VA = "0x184C463F0")]
		internal static CultureInfo ConstructCurrentUICulture()
		{
			return null;
		}

		// Token: 0x17000685 RID: 1669
		// (get) Token: 0x06002AD0 RID: 10960 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000685")]
		internal string Territory
		{
			[Token(Token = "0x6002AD0")]
			[Address(RVA = "0xEB4B80", Offset = "0xEB3780", VA = "0x180EB4B80")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000686 RID: 1670
		// (get) Token: 0x06002AD1 RID: 10961 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000686")]
		internal string _name
		{
			[Token(Token = "0x6002AD1")]
			[Address(RVA = "0x4EE940", Offset = "0x4ED540", VA = "0x1804EE940")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000687 RID: 1671
		// (get) Token: 0x06002AD2 RID: 10962 RVA: 0x00017D78 File Offset: 0x00015F78
		[Token(Token = "0x17000687")]
		public virtual int LCID
		{
			[Token(Token = "0x6002AD2")]
			[Address(RVA = "0x4EEB30", Offset = "0x4ED730", VA = "0x1804EEB30", Slot = "6")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000688 RID: 1672
		// (get) Token: 0x06002AD3 RID: 10963 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000688")]
		public virtual string Name
		{
			[Token(Token = "0x6002AD3")]
			[Address(RVA = "0x4EE940", Offset = "0x4ED540", VA = "0x1804EE940", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000689 RID: 1673
		// (get) Token: 0x06002AD4 RID: 10964 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000689")]
		public virtual Calendar Calendar
		{
			[Token(Token = "0x6002AD4")]
			[Address(RVA = "0x4C4AD50", Offset = "0x4C49950", VA = "0x184C4AD50", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700068A RID: 1674
		// (get) Token: 0x06002AD5 RID: 10965 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x1700068A")]
		public virtual CultureInfo Parent
		{
			[Token(Token = "0x6002AD5")]
			[Address(RVA = "0x4C4B4A0", Offset = "0x4C4A0A0", VA = "0x184C4B4A0", Slot = "9")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700068B RID: 1675
		// (get) Token: 0x06002AD6 RID: 10966 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x1700068B")]
		public virtual TextInfo TextInfo
		{
			[Token(Token = "0x6002AD6")]
			[Address(RVA = "0x4C4B710", Offset = "0x4C4A310", VA = "0x184C4B710", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002AD7 RID: 10967 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002AD7")]
		[Address(RVA = "0x4C45FA0", Offset = "0x4C44BA0", VA = "0x184C45FA0", Slot = "11")]
		public virtual object Clone()
		{
			return null;
		}

		// Token: 0x06002AD8 RID: 10968 RVA: 0x00017D90 File Offset: 0x00015F90
		[Token(Token = "0x6002AD8")]
		[Address(RVA = "0x4C49010", Offset = "0x4C47C10", VA = "0x184C49010", Slot = "0")]
		public override bool Equals(object value)
		{
			return default(bool);
		}

		// Token: 0x06002AD9 RID: 10969 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002AD9")]
		[Address(RVA = "0x4C496A0", Offset = "0x4C482A0", VA = "0x184C496A0")]
		public static CultureInfo[] GetCultures(CultureTypes types)
		{
			return null;
		}

		// Token: 0x06002ADA RID: 10970 RVA: 0x00017DA8 File Offset: 0x00015FA8
		[Token(Token = "0x6002ADA")]
		[Address(RVA = "0x4C49B40", Offset = "0x4C48740", VA = "0x184C49B40")]
		private CultureInfo.Data GetTextInfoData()
		{
			return default(CultureInfo.Data);
		}

		// Token: 0x06002ADB RID: 10971 RVA: 0x00017DC0 File Offset: 0x00015FC0
		[Token(Token = "0x6002ADB")]
		[Address(RVA = "0x4C49B30", Offset = "0x4C48730", VA = "0x184C49B30", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06002ADC RID: 10972 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002ADC")]
		[Address(RVA = "0x4C49C80", Offset = "0x4C48880", VA = "0x184C49C80")]
		public static CultureInfo ReadOnly(CultureInfo ci)
		{
			return null;
		}

		// Token: 0x06002ADD RID: 10973 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002ADD")]
		[Address(RVA = "0x4EE940", Offset = "0x4ED540", VA = "0x1804EE940", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x1700068C RID: 1676
		// (get) Token: 0x06002ADE RID: 10974 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x1700068C")]
		public virtual CompareInfo CompareInfo
		{
			[Token(Token = "0x6002ADE")]
			[Address(RVA = "0x4C4ADE0", Offset = "0x4C499E0", VA = "0x184C4ADE0", Slot = "12")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700068D RID: 1677
		// (get) Token: 0x06002ADF RID: 10975 RVA: 0x00017DD8 File Offset: 0x00015FD8
		[Token(Token = "0x1700068D")]
		public virtual bool IsNeutralCulture
		{
			[Token(Token = "0x6002ADF")]
			[Address(RVA = "0x4C4B3B0", Offset = "0x4C49FB0", VA = "0x184C4B3B0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06002AE0 RID: 10976 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002AE0")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		private void CheckNeutral()
		{
		}

		// Token: 0x1700068E RID: 1678
		// (get) Token: 0x06002AE1 RID: 10977 RVA: 0x000020CA File Offset: 0x000002CA
		// (set) Token: 0x06002AE2 RID: 10978 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700068E")]
		public virtual NumberFormatInfo NumberFormat
		{
			[Token(Token = "0x6002AE1")]
			[Address(RVA = "0x4C4B3F0", Offset = "0x4C49FF0", VA = "0x184C4B3F0", Slot = "14")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002AE2")]
			[Address(RVA = "0x4C4BCE0", Offset = "0x4C4A8E0", VA = "0x184C4BCE0", Slot = "15")]
			set
			{
			}
		}

		// Token: 0x1700068F RID: 1679
		// (get) Token: 0x06002AE3 RID: 10979 RVA: 0x000020CA File Offset: 0x000002CA
		// (set) Token: 0x06002AE4 RID: 10980 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700068F")]
		public virtual DateTimeFormatInfo DateTimeFormat
		{
			[Token(Token = "0x6002AE3")]
			[Address(RVA = "0x4C4AF90", Offset = "0x4C49B90", VA = "0x184C4AF90", Slot = "16")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002AE4")]
			[Address(RVA = "0x4C4BB70", Offset = "0x4C4A770", VA = "0x184C4BB70", Slot = "17")]
			set
			{
			}
		}

		// Token: 0x17000690 RID: 1680
		// (get) Token: 0x06002AE5 RID: 10981 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000690")]
		public virtual string EnglishName
		{
			[Token(Token = "0x6002AE5")]
			[Address(RVA = "0x4C4B210", Offset = "0x4C49E10", VA = "0x184C4B210", Slot = "18")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000691 RID: 1681
		// (get) Token: 0x06002AE6 RID: 10982 RVA: 0x00017DF0 File Offset: 0x00015FF0
		[Token(Token = "0x17000691")]
		public bool IsReadOnly
		{
			[Token(Token = "0x6002AE6")]
			[Address(RVA = "0x4E6300", Offset = "0x4E4F00", VA = "0x1804E6300")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06002AE7 RID: 10983 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002AE7")]
		[Address(RVA = "0x4C49A00", Offset = "0x4C48600", VA = "0x184C49A00", Slot = "19")]
		public virtual object GetFormat(System.Type formatType)
		{
			return null;
		}

		// Token: 0x06002AE8 RID: 10984 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002AE8")]
		[Address(RVA = "0x4C466C0", Offset = "0x4C452C0", VA = "0x184C466C0")]
		private void Construct()
		{
		}

		// Token: 0x06002AE9 RID: 10985
		[Token(Token = "0x6002AE9")]
		[Address(RVA = "0x4C4AC90", Offset = "0x4C49890", VA = "0x184C4AC90")]
		[MethodImpl(4096)]
		private extern bool construct_internal_locale_from_lcid(int lcid);

		// Token: 0x06002AEA RID: 10986
		[Token(Token = "0x6002AEA")]
		[Address(RVA = "0x4C4ACA0", Offset = "0x4C498A0", VA = "0x184C4ACA0")]
		[MethodImpl(4096)]
		private extern bool construct_internal_locale_from_name(string name);

		// Token: 0x06002AEB RID: 10987
		[Token(Token = "0x6002AEB")]
		[Address(RVA = "0x4C4B940", Offset = "0x4C4A540", VA = "0x184C4B940")]
		[MethodImpl(4096)]
		private static extern string get_current_locale_name();

		// Token: 0x06002AEC RID: 10988
		[Token(Token = "0x6002AEC")]
		[Address(RVA = "0x4C4BB30", Offset = "0x4C4A730", VA = "0x184C4BB30")]
		[MethodImpl(4096)]
		private static extern CultureInfo[] internal_get_cultures(bool neutral, bool specific, bool installed);

		// Token: 0x06002AED RID: 10989 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002AED")]
		[Address(RVA = "0x4C46430", Offset = "0x4C45030", VA = "0x184C46430")]
		private void ConstructInvariant(bool read_only)
		{
		}

		// Token: 0x06002AEE RID: 10990 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002AEE")]
		[Address(RVA = "0x4C48F90", Offset = "0x4C47B90", VA = "0x184C48F90")]
		private TextInfo CreateTextInfo(bool readOnly)
		{
			return null;
		}

		// Token: 0x06002AEF RID: 10991 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002AEF")]
		[Address(RVA = "0x4C4AC70", Offset = "0x4C49870", VA = "0x184C4AC70")]
		public CultureInfo(int culture)
		{
		}

		// Token: 0x06002AF0 RID: 10992 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002AF0")]
		[Address(RVA = "0x4C4A8D0", Offset = "0x4C494D0", VA = "0x184C4A8D0")]
		public CultureInfo(int culture, bool useUserOverride)
		{
		}

		// Token: 0x06002AF1 RID: 10993 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002AF1")]
		[Address(RVA = "0x4C4A8F0", Offset = "0x4C494F0", VA = "0x184C4A8F0")]
		private CultureInfo(int culture, bool useUserOverride, bool read_only)
		{
		}

		// Token: 0x06002AF2 RID: 10994 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002AF2")]
		[Address(RVA = "0x4C4A890", Offset = "0x4C49490", VA = "0x184C4A890")]
		public CultureInfo(string name)
		{
		}

		// Token: 0x06002AF3 RID: 10995 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002AF3")]
		[Address(RVA = "0x4C4AC50", Offset = "0x4C49850", VA = "0x184C4AC50")]
		public CultureInfo(string name, bool useUserOverride)
		{
		}

		// Token: 0x06002AF4 RID: 10996 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002AF4")]
		[Address(RVA = "0x4C4A5A0", Offset = "0x4C491A0", VA = "0x184C4A5A0")]
		private CultureInfo(string name, bool useUserOverride, bool read_only)
		{
		}

		// Token: 0x06002AF5 RID: 10997 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002AF5")]
		[Address(RVA = "0x4C4A8B0", Offset = "0x4C494B0", VA = "0x184C4A8B0")]
		private CultureInfo()
		{
		}

		// Token: 0x06002AF6 RID: 10998 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002AF6")]
		[Address(RVA = "0x4C4B950", Offset = "0x4C4A550", VA = "0x184C4B950")]
		private static void insert_into_shared_tables(CultureInfo c)
		{
		}

		// Token: 0x06002AF7 RID: 10999 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002AF7")]
		[Address(RVA = "0x4C491B0", Offset = "0x4C47DB0", VA = "0x184C491B0")]
		public static CultureInfo GetCultureInfo(int culture)
		{
			return null;
		}

		// Token: 0x06002AF8 RID: 11000 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002AF8")]
		[Address(RVA = "0x4C49430", Offset = "0x4C48030", VA = "0x184C49430")]
		public static CultureInfo GetCultureInfo(string name)
		{
			return null;
		}

		// Token: 0x06002AF9 RID: 11001 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002AF9")]
		[Address(RVA = "0x4C46950", Offset = "0x4C45550", VA = "0x184C46950")]
		internal static CultureInfo CreateCulture(string name, bool reference)
		{
			return null;
		}

		// Token: 0x06002AFA RID: 11002 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002AFA")]
		[Address(RVA = "0x4C48C70", Offset = "0x4C47870", VA = "0x184C48C70")]
		public static CultureInfo CreateSpecificCulture(string name)
		{
			return null;
		}

		// Token: 0x06002AFB RID: 11003 RVA: 0x00017E08 File Offset: 0x00016008
		[Token(Token = "0x6002AFB")]
		[Address(RVA = "0x4C46620", Offset = "0x4C45220", VA = "0x184C46620")]
		private bool ConstructLocaleFromName(string name)
		{
			return default(bool);
		}

		// Token: 0x06002AFC RID: 11004 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002AFC")]
		[Address(RVA = "0x4C46A90", Offset = "0x4C45690", VA = "0x184C46A90")]
		private static CultureInfo CreateSpecificCultureFromNeutral(string name)
		{
			return null;
		}

		// Token: 0x17000692 RID: 1682
		// (get) Token: 0x06002AFD RID: 11005 RVA: 0x00017E20 File Offset: 0x00016020
		[Token(Token = "0x17000692")]
		internal int CalendarType
		{
			[Token(Token = "0x6002AFD")]
			[Address(RVA = "0x4C4ACB0", Offset = "0x4C498B0", VA = "0x184C4ACB0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06002AFE RID: 11006 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002AFE")]
		[Address(RVA = "0x4C466E0", Offset = "0x4C452E0", VA = "0x184C466E0")]
		private static Calendar CreateCalendar(int calendarType)
		{
			return null;
		}

		// Token: 0x06002AFF RID: 11007 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002AFF")]
		[Address(RVA = "0x4C469E0", Offset = "0x4C455E0", VA = "0x184C469E0")]
		private static System.Exception CreateNotFoundException(string name)
		{
			return null;
		}

		// Token: 0x17000693 RID: 1683
		// (get) Token: 0x06002B00 RID: 11008 RVA: 0x000020CA File Offset: 0x000002CA
		// (set) Token: 0x06002B01 RID: 11009 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000693")]
		public static CultureInfo DefaultThreadCurrentCulture
		{
			[Token(Token = "0x6002B00")]
			[Address(RVA = "0x4C4B150", Offset = "0x4C49D50", VA = "0x184C4B150")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002B01")]
			[Address(RVA = "0x4C4BC70", Offset = "0x4C4A870", VA = "0x184C4BC70")]
			set
			{
			}
		}

		// Token: 0x17000694 RID: 1684
		// (get) Token: 0x06002B02 RID: 11010 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000694")]
		public static CultureInfo DefaultThreadCurrentUICulture
		{
			[Token(Token = "0x6002B02")]
			[Address(RVA = "0x4C4B1B0", Offset = "0x4C49DB0", VA = "0x184C4B1B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000695 RID: 1685
		// (get) Token: 0x06002B03 RID: 11011 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000695")]
		internal string SortName
		{
			[Token(Token = "0x6002B03")]
			[Address(RVA = "0x4EE940", Offset = "0x4ED540", VA = "0x1804EE940")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000696 RID: 1686
		// (get) Token: 0x06002B04 RID: 11012 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000696")]
		internal static CultureInfo UserDefaultUICulture
		{
			[Token(Token = "0x6002B04")]
			[Address(RVA = "0x4C4B8C0", Offset = "0x4C4A4C0", VA = "0x184C4B8C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000697 RID: 1687
		// (get) Token: 0x06002B05 RID: 11013 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000697")]
		internal static CultureInfo UserDefaultCulture
		{
			[Token(Token = "0x6002B05")]
			[Address(RVA = "0x4C4B880", Offset = "0x4C4A480", VA = "0x184C4B880")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002B06 RID: 11014
		[Token(Token = "0x6002B06")]
		[Address(RVA = "0x4C49B60", Offset = "0x4C48760", VA = "0x184C49B60")]
		[System.Runtime.InteropServices.PreserveSig]
		private static extern void InitializeUserPreferredCultureInfoInAppX(CultureInfo.OnCultureInfoChangedDelegate onCultureInfoChangedInAppX);

		// Token: 0x06002B07 RID: 11015
		[Token(Token = "0x6002B07")]
		[Address(RVA = "0x4C4A000", Offset = "0x4C48C00", VA = "0x184C4A000")]
		[System.Runtime.InteropServices.PreserveSig]
		private static extern void SetUserPreferredCultureInfoInAppX(string name);

		// Token: 0x06002B08 RID: 11016 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B08")]
		[Address(RVA = "0x4C49B80", Offset = "0x4C48780", VA = "0x184C49B80")]
		[MonoPInvokeCallback(typeof(CultureInfo.OnCultureInfoChangedDelegate))]
		private static void OnCultureInfoChangedInAppX(string language)
		{
		}

		// Token: 0x06002B09 RID: 11017 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002B09")]
		[Address(RVA = "0x4C490C0", Offset = "0x4C47CC0", VA = "0x184C490C0")]
		internal static CultureInfo GetCultureInfoForUserPreferredLanguageInAppX()
		{
			return null;
		}

		// Token: 0x06002B0A RID: 11018 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B0A")]
		[Address(RVA = "0x4C49EA0", Offset = "0x4C48AA0", VA = "0x184C49EA0")]
		internal static void SetCultureInfoForUserPreferredLanguageInAppX(CultureInfo cultureInfo)
		{
		}

		// Token: 0x17000698 RID: 1688
		// (get) Token: 0x06002B0B RID: 11019 RVA: 0x00017E38 File Offset: 0x00016038
		[Token(Token = "0x17000698")]
		internal bool HasInvariantCultureName
		{
			[Token(Token = "0x6002B0B")]
			[Address(RVA = "0x4C4B250", Offset = "0x4C49E50", VA = "0x184C4B250")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06002B0C RID: 11020 RVA: 0x00017E50 File Offset: 0x00016050
		[Token(Token = "0x6002B0C")]
		[Address(RVA = "0x4C4A020", Offset = "0x4C48C20", VA = "0x184C4A020")]
		internal static bool VerifyCultureName(string cultureName, bool throwException)
		{
			return default(bool);
		}

		// Token: 0x040018E0 RID: 6368
		[Token(Token = "0x40018E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static CultureInfo invariant_culture_info;

		// Token: 0x040018E1 RID: 6369
		[Token(Token = "0x40018E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static object shared_table_lock;

		// Token: 0x040018E2 RID: 6370
		[Token(Token = "0x40018E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static CultureInfo default_current_culture;

		// Token: 0x040018E3 RID: 6371
		[Token(Token = "0x40018E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private bool m_isReadOnly;

		// Token: 0x040018E4 RID: 6372
		[Token(Token = "0x40018E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private int cultureID;

		// Token: 0x040018E5 RID: 6373
		[Token(Token = "0x40018E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[System.NonSerialized]
		private int parent_lcid;

		// Token: 0x040018E6 RID: 6374
		[Token(Token = "0x40018E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[System.NonSerialized]
		private int datetime_index;

		// Token: 0x040018E7 RID: 6375
		[Token(Token = "0x40018E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[System.NonSerialized]
		private int number_index;

		// Token: 0x040018E8 RID: 6376
		[Token(Token = "0x40018E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[System.NonSerialized]
		private int default_calendar_type;

		// Token: 0x040018E9 RID: 6377
		[Token(Token = "0x40018E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool m_useUserOverride;

		// Token: 0x040018EA RID: 6378
		[Token(Token = "0x40018EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		internal NumberFormatInfo numInfo;

		// Token: 0x040018EB RID: 6379
		[Token(Token = "0x40018EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		internal DateTimeFormatInfo dateTimeInfo;

		// Token: 0x040018EC RID: 6380
		[Token(Token = "0x40018EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private TextInfo textInfo;

		// Token: 0x040018ED RID: 6381
		[Token(Token = "0x40018ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		internal string m_name;

		// Token: 0x040018EE RID: 6382
		[Token(Token = "0x40018EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[System.NonSerialized]
		private string englishname;

		// Token: 0x040018EF RID: 6383
		[Token(Token = "0x40018EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[System.NonSerialized]
		private string nativename;

		// Token: 0x040018F0 RID: 6384
		[Token(Token = "0x40018F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[System.NonSerialized]
		private string iso3lang;

		// Token: 0x040018F1 RID: 6385
		[Token(Token = "0x40018F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[System.NonSerialized]
		private string iso2lang;

		// Token: 0x040018F2 RID: 6386
		[Token(Token = "0x40018F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[System.NonSerialized]
		private string win3lang;

		// Token: 0x040018F3 RID: 6387
		[Token(Token = "0x40018F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[System.NonSerialized]
		private string territory;

		// Token: 0x040018F4 RID: 6388
		[Token(Token = "0x40018F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[System.NonSerialized]
		private string[] native_calendar_names;

		// Token: 0x040018F5 RID: 6389
		[Token(Token = "0x40018F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private CompareInfo compareInfo;

		// Token: 0x040018F6 RID: 6390
		[Token(Token = "0x40018F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[System.NonSerialized]
		private unsafe readonly void* textinfo_data;

		// Token: 0x040018F7 RID: 6391
		[Token(Token = "0x40018F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private int m_dataItem;

		// Token: 0x040018F8 RID: 6392
		[Token(Token = "0x40018F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Calendar calendar;

		// Token: 0x040018F9 RID: 6393
		[Token(Token = "0x40018F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[System.NonSerialized]
		private CultureInfo parent_culture;

		// Token: 0x040018FA RID: 6394
		[Token(Token = "0x40018FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[System.NonSerialized]
		private bool constructed;

		// Token: 0x040018FB RID: 6395
		[Token(Token = "0x40018FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[System.NonSerialized]
		internal byte[] cached_serialized_form;

		// Token: 0x040018FC RID: 6396
		[Token(Token = "0x40018FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[System.NonSerialized]
		internal CultureData m_cultureData;

		// Token: 0x040018FD RID: 6397
		[Token(Token = "0x40018FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[System.NonSerialized]
		internal bool m_isInherited;

		// Token: 0x040018FE RID: 6398
		[Token(Token = "0x40018FE")]
		internal const int InvariantCultureId = 127;

		// Token: 0x040018FF RID: 6399
		[Token(Token = "0x40018FF")]
		private const int CalendarTypeBits = 8;

		// Token: 0x04001900 RID: 6400
		[Token(Token = "0x4001900")]
		internal const int LOCALE_INVARIANT = 127;

		// Token: 0x04001901 RID: 6401
		[Token(Token = "0x4001901")]
		private const string MSG_READONLY = "This instance is read only";

		// Token: 0x04001902 RID: 6402
		[Token(Token = "0x4001902")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static CultureInfo s_DefaultThreadCurrentUICulture;

		// Token: 0x04001903 RID: 6403
		[Token(Token = "0x4001903")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static CultureInfo s_DefaultThreadCurrentCulture;

		// Token: 0x04001904 RID: 6404
		[Token(Token = "0x4001904")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static System.Collections.Generic.Dictionary<int, CultureInfo> shared_by_number;

		// Token: 0x04001905 RID: 6405
		[Token(Token = "0x4001905")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static System.Collections.Generic.Dictionary<string, CultureInfo> shared_by_name;

		// Token: 0x04001906 RID: 6406
		[Token(Token = "0x4001906")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static CultureInfo s_UserPreferredCultureInfoInAppX;

		// Token: 0x04001907 RID: 6407
		[Token(Token = "0x4001907")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		internal static readonly bool IsTaiwanSku;

		// Token: 0x02000597 RID: 1431
		[Token(Token = "0x2000597")]
		private struct Data
		{
			// Token: 0x04001908 RID: 6408
			[Token(Token = "0x4001908")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int ansi;

			// Token: 0x04001909 RID: 6409
			[Token(Token = "0x4001909")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public int ebcdic;

			// Token: 0x0400190A RID: 6410
			[Token(Token = "0x400190A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public int mac;

			// Token: 0x0400190B RID: 6411
			[Token(Token = "0x400190B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public int oem;

			// Token: 0x0400190C RID: 6412
			[Token(Token = "0x400190C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool right_to_left;

			// Token: 0x0400190D RID: 6413
			[Token(Token = "0x400190D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
			public byte list_sep;
		}

		// Token: 0x02000598 RID: 1432
		// (Invoke) Token: 0x06002B0F RID: 11023
		[Token(Token = "0x2000598")]
		private delegate void OnCultureInfoChangedDelegate(string language);
	}
}
