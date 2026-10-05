using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using Il2CppDummyDll;
using Microsoft.Win32;

namespace System
{
	// Token: 0x02000096 RID: 150
	[Token(Token = "0x2000096")]
	[System.Runtime.CompilerServices.TypeForwardedFrom("System.Core, Version=2.0.5.0, Culture=Neutral, PublicKeyToken=7cec85d7bea7798e")]
	[System.Serializable]
	public sealed class TimeZoneInfo : System.IEquatable<System.TimeZoneInfo>, System.Runtime.Serialization.ISerializable, System.Runtime.Serialization.IDeserializationCallback
	{
		// Token: 0x0600036F RID: 879 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600036F")]
		[Address(RVA = "0x4BFD800", Offset = "0x4BFC400", VA = "0x184BFD800")]
		public System.TimeZoneInfo.AdjustmentRule[] GetAdjustmentRules()
		{
			return null;
		}

		// Token: 0x06000370 RID: 880 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000370")]
		[Address(RVA = "0x4C02320", Offset = "0x4C00F20", VA = "0x184C02320")]
		private static void PopulateAllSystemTimeZones(System.TimeZoneInfo.CachedData cachedData)
		{
		}

		// Token: 0x06000371 RID: 881 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000371")]
		[Address(RVA = "0x4C02170", Offset = "0x4C00D70", VA = "0x184C02170")]
		private static void PopulateAllSystemTimeZonesFromRegistry(System.TimeZoneInfo.CachedData cachedData)
		{
		}

		// Token: 0x06000372 RID: 882 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000372")]
		[Address(RVA = "0x4C07200", Offset = "0x4C05E00", VA = "0x184C07200")]
		private TimeZoneInfo(in Interop.Kernel32.TIME_ZONE_INFORMATION zone, bool dstDisabled)
		{
		}

		// Token: 0x06000373 RID: 883 RVA: 0x00003B28 File Offset: 0x00001D28
		[Token(Token = "0x6000373")]
		[Address(RVA = "0x4BFB430", Offset = "0x4BFA030", VA = "0x184BFB430")]
		private static bool CheckDaylightSavingTimeNotSupported(in Interop.Kernel32.TIME_ZONE_INFORMATION timeZone)
		{
			return default(bool);
		}

		// Token: 0x06000374 RID: 884 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000374")]
		[Address(RVA = "0x4BFCA20", Offset = "0x4BFB620", VA = "0x184BFCA20")]
		private static System.TimeZoneInfo.AdjustmentRule CreateAdjustmentRuleFromTimeZoneInformation(in Interop.Kernel32.REG_TZI_FORMAT timeZoneInformation, System.DateTime startDate, System.DateTime endDate, int defaultBaseUtcOffset)
		{
			return null;
		}

		// Token: 0x06000375 RID: 885 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000375")]
		[Address(RVA = "0x4BFD1A0", Offset = "0x4BFBDA0", VA = "0x184BFD1A0")]
		private static string FindIdFromTimeZoneInformation(in Interop.Kernel32.TIME_ZONE_INFORMATION timeZone, out bool dstDisabled)
		{
			return null;
		}

		// Token: 0x06000376 RID: 886 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000376")]
		[Address(RVA = "0x4BFFC60", Offset = "0x4BFE860", VA = "0x184BFFC60")]
		private static System.TimeZoneInfo GetLocalTimeZone(System.TimeZoneInfo.CachedData cachedData)
		{
			return null;
		}

		// Token: 0x06000377 RID: 887 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000377")]
		[Address(RVA = "0x4BFF770", Offset = "0x4BFE370", VA = "0x184BFF770")]
		private static System.TimeZoneInfo GetLocalTimeZoneFromWin32Data(in Interop.Kernel32.TIME_ZONE_INFORMATION timeZoneInformation, bool dstDisabled)
		{
			return null;
		}

		// Token: 0x06000378 RID: 888 RVA: 0x00003B40 File Offset: 0x00001D40
		[Token(Token = "0x6000378")]
		[Address(RVA = "0x4BFD890", Offset = "0x4BFC490", VA = "0x184BFD890")]
		internal static System.TimeSpan GetDateTimeNowUtcOffsetFromUtc(System.DateTime time, out bool isAmbiguousLocalDst)
		{
			return default(System.TimeSpan);
		}

		// Token: 0x06000379 RID: 889 RVA: 0x00003B58 File Offset: 0x00001D58
		[Token(Token = "0x6000379")]
		[Address(RVA = "0x4C03620", Offset = "0x4C02220", VA = "0x184C03620")]
		private static bool TransitionTimeFromTimeZoneInformation(in Interop.Kernel32.REG_TZI_FORMAT timeZoneInformation, out System.TimeZoneInfo.TransitionTime transitionTime, bool readStartDate)
		{
			return default(bool);
		}

		// Token: 0x0600037A RID: 890 RVA: 0x00003B70 File Offset: 0x00001D70
		[Token(Token = "0x600037A")]
		[Address(RVA = "0x4C04000", Offset = "0x4C02C00", VA = "0x184C04000")]
		private static bool TryCreateAdjustmentRules(string id, in Interop.Kernel32.REG_TZI_FORMAT defaultTimeZoneInformation, out System.TimeZoneInfo.AdjustmentRule[] rules, out System.Exception e, int defaultBaseUtcOffset)
		{
			return default(bool);
		}

		// Token: 0x0600037B RID: 891 RVA: 0x00003B88 File Offset: 0x00001D88
		[Token(Token = "0x600037B")]
		[Address(RVA = "0x4C05800", Offset = "0x4C04400", VA = "0x184C05800")]
		private static bool TryGetTimeZoneEntryFromRegistry(Microsoft.Win32.RegistryKey key, string name, out Interop.Kernel32.REG_TZI_FORMAT dtzi)
		{
			return default(bool);
		}

		// Token: 0x0600037C RID: 892 RVA: 0x00003BA0 File Offset: 0x00001DA0
		[Token(Token = "0x600037C")]
		[Address(RVA = "0x4C03AE0", Offset = "0x4C026E0", VA = "0x184C03AE0")]
		private static bool TryCompareStandardDate(in Interop.Kernel32.TIME_ZONE_INFORMATION timeZone, in Interop.Kernel32.REG_TZI_FORMAT registryTimeZoneInfo)
		{
			return default(bool);
		}

		// Token: 0x0600037D RID: 893 RVA: 0x00003BB8 File Offset: 0x00001DB8
		[Token(Token = "0x600037D")]
		[Address(RVA = "0x4C03B20", Offset = "0x4C02720", VA = "0x184C03B20")]
		private static bool TryCompareTimeZoneInformationToRegistry(in Interop.Kernel32.TIME_ZONE_INFORMATION timeZone, string id, out bool dstDisabled)
		{
			return default(bool);
		}

		// Token: 0x0600037E RID: 894 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600037E")]
		[Address(RVA = "0x4C053B0", Offset = "0x4C03FB0", VA = "0x184C053B0")]
		private static string TryGetLocalizedNameByMuiNativeResource(string resource)
		{
			return null;
		}

		// Token: 0x0600037F RID: 895 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600037F")]
		[Address(RVA = "0x4C05680", Offset = "0x4C04280", VA = "0x184C05680")]
		private static string TryGetLocalizedNameByNativeResource(string filePath, int resource)
		{
			return null;
		}

		// Token: 0x06000380 RID: 896 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000380")]
		[Address(RVA = "0x4C00050", Offset = "0x4BFEC50", VA = "0x184C00050")]
		private static void GetLocalizedNamesByRegistryKey(Microsoft.Win32.RegistryKey key, out string displayName, out string standardName, out string daylightName)
		{
		}

		// Token: 0x06000381 RID: 897 RVA: 0x00003BD0 File Offset: 0x00001DD0
		[Token(Token = "0x6000381")]
		[Address(RVA = "0x4C05C50", Offset = "0x4C04850", VA = "0x184C05C50")]
		private static System.TimeZoneInfo.TimeZoneInfoResult TryGetTimeZoneFromLocalMachine(string id, out System.TimeZoneInfo value, out System.Exception e)
		{
			return System.TimeZoneInfo.TimeZoneInfoResult.Success;
		}

		// Token: 0x06000382 RID: 898 RVA: 0x00003BE8 File Offset: 0x00001DE8
		[Token(Token = "0x6000382")]
		[Address(RVA = "0x4C05D30", Offset = "0x4C04930", VA = "0x184C05D30")]
		private static System.TimeZoneInfo.TimeZoneInfoResult TryGetTimeZoneFromLocalRegistry(string id, out System.TimeZoneInfo value, out System.Exception e)
		{
			return System.TimeZoneInfo.TimeZoneInfoResult.Success;
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x06000383 RID: 899 RVA: 0x00003C00 File Offset: 0x00001E00
		[Token(Token = "0x17000043")]
		private static bool HaveRegistry
		{
			[Token(Token = "0x6000383")]
			[Address(RVA = "0x4C07660", Offset = "0x4C06260", VA = "0x184C07660")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000384 RID: 900
		[Token(Token = "0x6000384")]
		[Address(RVA = "0x4BFCE40", Offset = "0x4BFBA40", VA = "0x184BFCE40")]
		[System.Runtime.InteropServices.PreserveSig]
		internal static extern uint EnumDynamicTimeZoneInformation(uint dwIndex, out System.TimeZoneInfo.DYNAMIC_TIME_ZONE_INFORMATION lpTimeZoneInformation);

		// Token: 0x06000385 RID: 901
		[Token(Token = "0x6000385")]
		[Address(RVA = "0x4BFE0A0", Offset = "0x4BFCCA0", VA = "0x184BFE0A0")]
		[System.Runtime.InteropServices.PreserveSig]
		internal static extern uint GetDynamicTimeZoneInformation(out System.TimeZoneInfo.DYNAMIC_TIME_ZONE_INFORMATION pTimeZoneInformation);

		// Token: 0x06000386 RID: 902
		[Token(Token = "0x6000386")]
		[Address(RVA = "0x4BFDF20", Offset = "0x4BFCB20", VA = "0x184BFDF20")]
		[System.Runtime.InteropServices.PreserveSig]
		internal static extern uint GetDynamicTimeZoneInformationEffectiveYears(ref System.TimeZoneInfo.DYNAMIC_TIME_ZONE_INFORMATION lpTimeZoneInformation, out uint FirstYear, out uint LastYear);

		// Token: 0x06000387 RID: 903
		[Token(Token = "0x6000387")]
		[Address(RVA = "0x4C00FB0", Offset = "0x4BFFBB0", VA = "0x184C00FB0")]
		[System.Runtime.InteropServices.PreserveSig]
		internal static extern bool GetTimeZoneInformationForYear(ushort wYear, ref System.TimeZoneInfo.DYNAMIC_TIME_ZONE_INFORMATION pdtzi, out Interop.Kernel32.TIME_ZONE_INFORMATION ptzi);

		// Token: 0x06000388 RID: 904 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000388")]
		[Address(RVA = "0x4BFC470", Offset = "0x4BFB070", VA = "0x184BFC470")]
		internal static System.TimeZoneInfo.AdjustmentRule CreateAdjustmentRuleFromTimeZoneInformation(ref System.TimeZoneInfo.DYNAMIC_TIME_ZONE_INFORMATION timeZoneInformation, System.DateTime startDate, System.DateTime endDate, int defaultBaseUtcOffset)
		{
			return null;
		}

		// Token: 0x06000389 RID: 905 RVA: 0x00003C18 File Offset: 0x00001E18
		[Token(Token = "0x6000389")]
		[Address(RVA = "0x4C02780", Offset = "0x4C01380", VA = "0x184C02780")]
		private static bool TransitionTimeFromTimeZoneInformation(System.TimeZoneInfo.DYNAMIC_TIME_ZONE_INFORMATION timeZoneInformation, out System.TimeZoneInfo.TransitionTime transitionTime, bool readStartDate)
		{
			return default(bool);
		}

		// Token: 0x0600038A RID: 906 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600038A")]
		[Address(RVA = "0x4C04A40", Offset = "0x4C03640", VA = "0x184C04A40")]
		internal static System.TimeZoneInfo TryCreateTimeZone(System.TimeZoneInfo.DYNAMIC_TIME_ZONE_INFORMATION timeZoneInformation)
		{
			return null;
		}

		// Token: 0x0600038B RID: 907 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600038B")]
		[Address(RVA = "0x4BFF8B0", Offset = "0x4BFE4B0", VA = "0x184BFF8B0")]
		internal static System.TimeZoneInfo GetLocalTimeZoneInfoWinRTFallback()
		{
			return null;
		}

		// Token: 0x0600038C RID: 908 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600038C")]
		[Address(RVA = "0x4BFD360", Offset = "0x4BFBF60", VA = "0x184BFD360")]
		internal static System.TimeZoneInfo FindSystemTimeZoneByIdWinRTFallback(string id)
		{
			return null;
		}

		// Token: 0x0600038D RID: 909 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600038D")]
		[Address(RVA = "0x4C00530", Offset = "0x4BFF130", VA = "0x184C00530")]
		private static void GetSystemTimeZonesWinRTFallback(System.TimeZoneInfo.CachedData cachedData)
		{
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x0600038E RID: 910 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000044")]
		public string Id
		{
			[Token(Token = "0x600038E")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x0600038F RID: 911 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000045")]
		public string DisplayName
		{
			[Token(Token = "0x600038F")]
			[Address(RVA = "0x4C02730", Offset = "0x4C01330", VA = "0x184C02730")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x06000390 RID: 912 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000046")]
		public string StandardName
		{
			[Token(Token = "0x6000390")]
			[Address(RVA = "0x4C07760", Offset = "0x4C06360", VA = "0x184C07760")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x06000391 RID: 913 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000047")]
		public string DaylightName
		{
			[Token(Token = "0x6000391")]
			[Address(RVA = "0x4C07610", Offset = "0x4C06210", VA = "0x184C07610")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x06000392 RID: 914 RVA: 0x00003C30 File Offset: 0x00001E30
		[Token(Token = "0x17000048")]
		public System.TimeSpan BaseUtcOffset
		{
			[Token(Token = "0x6000392")]
			[Address(RVA = "0x4EA8A0", Offset = "0x4E94A0", VA = "0x1804EA8A0")]
			get
			{
				return default(System.TimeSpan);
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x06000393 RID: 915 RVA: 0x00003C48 File Offset: 0x00001E48
		[Token(Token = "0x17000049")]
		public bool SupportsDaylightSavingTime
		{
			[Token(Token = "0x6000393")]
			[Address(RVA = "0x4FD4C0", Offset = "0x4FC0C0", VA = "0x1804FD4C0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000394 RID: 916 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000394")]
		[Address(RVA = "0x4C00420", Offset = "0x4BFF020", VA = "0x184C00420")]
		private System.TimeZoneInfo.AdjustmentRule GetPreviousAdjustmentRule(System.TimeZoneInfo.AdjustmentRule rule, int? ruleIndex)
		{
			return null;
		}

		// Token: 0x06000395 RID: 917 RVA: 0x00003C60 File Offset: 0x00001E60
		[Token(Token = "0x6000395")]
		[Address(RVA = "0x4C01CE0", Offset = "0x4C008E0", VA = "0x184C01CE0")]
		public System.TimeSpan GetUtcOffset(System.DateTime dateTime)
		{
			return default(System.TimeSpan);
		}

		// Token: 0x06000396 RID: 918 RVA: 0x00003C78 File Offset: 0x00001E78
		[Token(Token = "0x6000396")]
		[Address(RVA = "0x4BFFF90", Offset = "0x4BFEB90", VA = "0x184BFFF90")]
		internal static System.TimeSpan GetLocalUtcOffset(System.DateTime dateTime, TimeZoneInfoOptions flags)
		{
			return default(System.TimeSpan);
		}

		// Token: 0x06000397 RID: 919 RVA: 0x00003C90 File Offset: 0x00001E90
		[Token(Token = "0x6000397")]
		[Address(RVA = "0x4C01590", Offset = "0x4C00190", VA = "0x184C01590")]
		internal System.TimeSpan GetUtcOffset(System.DateTime dateTime, TimeZoneInfoOptions flags)
		{
			return default(System.TimeSpan);
		}

		// Token: 0x06000398 RID: 920 RVA: 0x00003CA8 File Offset: 0x00001EA8
		[Token(Token = "0x6000398")]
		[Address(RVA = "0x4C016F0", Offset = "0x4C002F0", VA = "0x184C016F0")]
		private System.TimeSpan GetUtcOffset(System.DateTime dateTime, TimeZoneInfoOptions flags, System.TimeZoneInfo.CachedData cachedData)
		{
			return default(System.TimeSpan);
		}

		// Token: 0x06000399 RID: 921 RVA: 0x00003CC0 File Offset: 0x00001EC0
		[Token(Token = "0x6000399")]
		[Address(RVA = "0x4BFBA10", Offset = "0x4BFA610", VA = "0x184BFBA10")]
		internal static System.DateTime ConvertTime(System.DateTime dateTime, System.TimeZoneInfo sourceTimeZone, System.TimeZoneInfo destinationTimeZone, TimeZoneInfoOptions flags)
		{
			return default(System.DateTime);
		}

		// Token: 0x0600039A RID: 922 RVA: 0x00003CD8 File Offset: 0x00001ED8
		[Token(Token = "0x600039A")]
		[Address(RVA = "0x4BFBAB0", Offset = "0x4BFA6B0", VA = "0x184BFBAB0")]
		private static System.DateTime ConvertTime(System.DateTime dateTime, System.TimeZoneInfo sourceTimeZone, System.TimeZoneInfo destinationTimeZone, TimeZoneInfoOptions flags, System.TimeZoneInfo.CachedData cachedData)
		{
			return default(System.DateTime);
		}

		// Token: 0x0600039B RID: 923 RVA: 0x00003CF0 File Offset: 0x00001EF0
		[Token(Token = "0x600039B")]
		[Address(RVA = "0x4BFB900", Offset = "0x4BFA500", VA = "0x184BFB900")]
		internal static System.DateTime ConvertTimeToUtc(System.DateTime dateTime, TimeZoneInfoOptions flags)
		{
			return default(System.DateTime);
		}

		// Token: 0x0600039C RID: 924 RVA: 0x00003D08 File Offset: 0x00001F08
		[Token(Token = "0x600039C")]
		[Address(RVA = "0x4BFCFA0", Offset = "0x4BFBBA0", VA = "0x184BFCFA0", Slot = "4")]
		public bool Equals(System.TimeZoneInfo other)
		{
			return default(bool);
		}

		// Token: 0x0600039D RID: 925 RVA: 0x00003D20 File Offset: 0x00001F20
		[Token(Token = "0x600039D")]
		[Address(RVA = "0x4BFD080", Offset = "0x4BFBC80", VA = "0x184BFD080", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x0600039E RID: 926 RVA: 0x00003D38 File Offset: 0x00001F38
		[Token(Token = "0x600039E")]
		[Address(RVA = "0x4BFE200", Offset = "0x4BFCE00", VA = "0x184BFE200", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600039F RID: 927 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600039F")]
		[Address(RVA = "0x4C00C10", Offset = "0x4BFF810", VA = "0x184C00C10")]
		public static System.Collections.ObjectModel.ReadOnlyCollection<System.TimeZoneInfo> GetSystemTimeZones()
		{
			return null;
		}

		// Token: 0x060003A0 RID: 928 RVA: 0x00003D50 File Offset: 0x00001F50
		[Token(Token = "0x60003A0")]
		[Address(RVA = "0x4C01D60", Offset = "0x4C00960", VA = "0x184C01D60")]
		public bool HasSameRules(System.TimeZoneInfo other)
		{
			return default(bool);
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x060003A1 RID: 929 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x1700004A")]
		public static System.TimeZoneInfo Local
		{
			[Token(Token = "0x60003A1")]
			[Address(RVA = "0x4C076D0", Offset = "0x4C062D0", VA = "0x184C076D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x060003A2 RID: 930 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60003A2")]
		[Address(RVA = "0x4C02730", Offset = "0x4C01330", VA = "0x184C02730", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x060003A3 RID: 931 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x1700004B")]
		public static System.TimeZoneInfo Utc
		{
			[Token(Token = "0x60003A3")]
			[Address(RVA = "0x4C077B0", Offset = "0x4C063B0", VA = "0x184C077B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x060003A4 RID: 932 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003A4")]
		[Address(RVA = "0x4C070F0", Offset = "0x4C05CF0", VA = "0x184C070F0")]
		private TimeZoneInfo(string id, System.TimeSpan baseUtcOffset, string displayName, string standardDisplayName, string daylightDisplayName, System.TimeZoneInfo.AdjustmentRule[] adjustmentRules, bool disableDaylightSavingTime)
		{
		}

		// Token: 0x060003A5 RID: 933 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60003A5")]
		[Address(RVA = "0x4BFCD90", Offset = "0x4BFB990", VA = "0x184BFCD90")]
		public static System.TimeZoneInfo CreateCustomTimeZone(string id, System.TimeSpan baseUtcOffset, string displayName, string standardDisplayName)
		{
			return null;
		}

		// Token: 0x060003A6 RID: 934 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003A6")]
		[Address(RVA = "0x4C023B0", Offset = "0x4C00FB0", VA = "0x184C023B0", Slot = "6")]
		private void OnDeserialization(object sender)
		{
		}

		// Token: 0x060003A7 RID: 935 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003A7")]
		[Address(RVA = "0x4C02590", Offset = "0x4C01190", VA = "0x184C02590", Slot = "5")]
		private void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
		{
		}

		// Token: 0x060003A8 RID: 936 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003A8")]
		[Address(RVA = "0x4C06BB0", Offset = "0x4C057B0", VA = "0x184C06BB0")]
		private TimeZoneInfo(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
		{
		}

		// Token: 0x060003A9 RID: 937 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60003A9")]
		[Address(RVA = "0x4BFD7E0", Offset = "0x4BFC3E0", VA = "0x184BFD7E0")]
		private System.TimeZoneInfo.AdjustmentRule GetAdjustmentRuleForTime(System.DateTime dateTime, out int? ruleIndex)
		{
			return null;
		}

		// Token: 0x060003AA RID: 938 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60003AA")]
		[Address(RVA = "0x4BFD600", Offset = "0x4BFC200", VA = "0x184BFD600")]
		private System.TimeZoneInfo.AdjustmentRule GetAdjustmentRuleForTime(System.DateTime dateTime, bool dateTimeisUtc, out int? ruleIndex)
		{
			return null;
		}

		// Token: 0x060003AB RID: 939 RVA: 0x00003D68 File Offset: 0x00001F68
		[Token(Token = "0x60003AB")]
		[Address(RVA = "0x4BFB700", Offset = "0x4BFA300", VA = "0x184BFB700")]
		private int CompareAdjustmentRuleToDateTime(System.TimeZoneInfo.AdjustmentRule rule, System.TimeZoneInfo.AdjustmentRule previousRule, System.DateTime dateTime, System.DateTime dateOnly, bool dateTimeisUtc)
		{
			return 0;
		}

		// Token: 0x060003AC RID: 940 RVA: 0x00003D80 File Offset: 0x00001F80
		[Token(Token = "0x60003AC")]
		[Address(RVA = "0x4BFC1F0", Offset = "0x4BFADF0", VA = "0x184BFC1F0")]
		private System.DateTime ConvertToUtc(System.DateTime dateTime, System.TimeSpan daylightDelta, System.TimeSpan baseUtcOffsetDelta)
		{
			return default(System.DateTime);
		}

		// Token: 0x060003AD RID: 941 RVA: 0x00003D98 File Offset: 0x00001F98
		[Token(Token = "0x60003AD")]
		[Address(RVA = "0x4BFB8E0", Offset = "0x4BFA4E0", VA = "0x184BFB8E0")]
		private System.DateTime ConvertFromUtc(System.DateTime dateTime, System.TimeSpan daylightDelta, System.TimeSpan baseUtcOffsetDelta)
		{
			return default(System.DateTime);
		}

		// Token: 0x060003AE RID: 942 RVA: 0x00003DB0 File Offset: 0x00001FB0
		[Token(Token = "0x60003AE")]
		[Address(RVA = "0x4BFC030", Offset = "0x4BFAC30", VA = "0x184BFC030")]
		private System.DateTime ConvertToFromUtc(System.DateTime dateTime, System.TimeSpan daylightDelta, System.TimeSpan baseUtcOffsetDelta, bool convertToUtc)
		{
			return default(System.DateTime);
		}

		// Token: 0x060003AF RID: 943 RVA: 0x00003DC8 File Offset: 0x00001FC8
		[Token(Token = "0x60003AF")]
		[Address(RVA = "0x4BFC210", Offset = "0x4BFAE10", VA = "0x184BFC210")]
		private static System.DateTime ConvertUtcToTimeZone(long ticks, System.TimeZoneInfo destinationTimeZone, out bool isAmbiguousLocalDst)
		{
			return default(System.DateTime);
		}

		// Token: 0x060003B0 RID: 944 RVA: 0x00003DE0 File Offset: 0x00001FE0
		[Token(Token = "0x60003B0")]
		[Address(RVA = "0x4BFDDA0", Offset = "0x4BFC9A0", VA = "0x184BFDDA0")]
		private DaylightTimeStruct GetDaylightTime(int year, System.TimeZoneInfo.AdjustmentRule rule, int? ruleIndex)
		{
			return default(DaylightTimeStruct);
		}

		// Token: 0x060003B1 RID: 945 RVA: 0x00003DF8 File Offset: 0x00001FF8
		[Token(Token = "0x60003B1")]
		[Address(RVA = "0x4BFEEF0", Offset = "0x4BFDAF0", VA = "0x184BFEEF0")]
		private static bool GetIsDaylightSavings(System.DateTime time, System.TimeZoneInfo.AdjustmentRule rule, DaylightTimeStruct daylightTime, TimeZoneInfoOptions flags)
		{
			return default(bool);
		}

		// Token: 0x060003B2 RID: 946 RVA: 0x00003E10 File Offset: 0x00002010
		[Token(Token = "0x60003B2")]
		[Address(RVA = "0x4BFDCC0", Offset = "0x4BFC8C0", VA = "0x184BFDCC0")]
		private System.TimeSpan GetDaylightSavingsStartOffsetFromUtc(System.TimeSpan baseUtcOffset, System.TimeZoneInfo.AdjustmentRule rule, int? ruleIndex)
		{
			return default(System.TimeSpan);
		}

		// Token: 0x060003B3 RID: 947 RVA: 0x00003E28 File Offset: 0x00002028
		[Token(Token = "0x60003B3")]
		[Address(RVA = "0x4BFDC30", Offset = "0x4BFC830", VA = "0x184BFDC30")]
		private System.TimeSpan GetDaylightSavingsEndOffsetFromUtc(System.TimeSpan baseUtcOffset, System.TimeZoneInfo.AdjustmentRule rule)
		{
			return default(System.TimeSpan);
		}

		// Token: 0x060003B4 RID: 948 RVA: 0x00003E40 File Offset: 0x00002040
		[Token(Token = "0x60003B4")]
		[Address(RVA = "0x4BFE640", Offset = "0x4BFD240", VA = "0x184BFE640")]
		private static bool GetIsDaylightSavingsFromUtc(System.DateTime time, int year, System.TimeSpan utc, System.TimeZoneInfo.AdjustmentRule rule, int? ruleIndex, out bool isAmbiguousLocalDst, System.TimeZoneInfo zone)
		{
			return default(bool);
		}

		// Token: 0x060003B5 RID: 949 RVA: 0x00003E58 File Offset: 0x00002058
		[Token(Token = "0x60003B5")]
		[Address(RVA = "0x4BFB460", Offset = "0x4BFA060", VA = "0x184BFB460")]
		private static bool CheckIsDst(System.DateTime startTime, System.DateTime time, System.DateTime endTime, bool ignoreYearAdjustment, System.TimeZoneInfo.AdjustmentRule rule)
		{
			return default(bool);
		}

		// Token: 0x060003B6 RID: 950 RVA: 0x00003E70 File Offset: 0x00002070
		[Token(Token = "0x60003B6")]
		[Address(RVA = "0x4BFE2D0", Offset = "0x4BFCED0", VA = "0x184BFE2D0")]
		private static bool GetIsAmbiguousTime(System.DateTime time, System.TimeZoneInfo.AdjustmentRule rule, DaylightTimeStruct daylightTime)
		{
			return default(bool);
		}

		// Token: 0x060003B7 RID: 951 RVA: 0x00003E88 File Offset: 0x00002088
		[Token(Token = "0x60003B7")]
		[Address(RVA = "0x4BFF400", Offset = "0x4BFE000", VA = "0x184BFF400")]
		private static bool GetIsInvalidTime(System.DateTime time, System.TimeZoneInfo.AdjustmentRule rule, DaylightTimeStruct daylightTime)
		{
			return default(bool);
		}

		// Token: 0x060003B8 RID: 952 RVA: 0x00003EA0 File Offset: 0x000020A0
		[Token(Token = "0x60003B8")]
		[Address(RVA = "0x4C01AD0", Offset = "0x4C006D0", VA = "0x184C01AD0")]
		private static System.TimeSpan GetUtcOffset(System.DateTime time, System.TimeZoneInfo zone, TimeZoneInfoOptions flags)
		{
			return default(System.TimeSpan);
		}

		// Token: 0x060003B9 RID: 953 RVA: 0x00003EB8 File Offset: 0x000020B8
		[Token(Token = "0x60003B9")]
		[Address(RVA = "0x4C011B0", Offset = "0x4BFFDB0", VA = "0x184C011B0")]
		private static System.TimeSpan GetUtcOffsetFromUtc(System.DateTime time, System.TimeZoneInfo zone)
		{
			return default(System.TimeSpan);
		}

		// Token: 0x060003BA RID: 954 RVA: 0x00003ED0 File Offset: 0x000020D0
		[Token(Token = "0x60003BA")]
		[Address(RVA = "0x4C01130", Offset = "0x4BFFD30", VA = "0x184C01130")]
		private static System.TimeSpan GetUtcOffsetFromUtc(System.DateTime time, System.TimeZoneInfo zone, out bool isDaylightSavings)
		{
			return default(System.TimeSpan);
		}

		// Token: 0x060003BB RID: 955 RVA: 0x00003EE8 File Offset: 0x000020E8
		[Token(Token = "0x60003BB")]
		[Address(RVA = "0x4C01260", Offset = "0x4BFFE60", VA = "0x184C01260")]
		internal static System.TimeSpan GetUtcOffsetFromUtc(System.DateTime time, System.TimeZoneInfo zone, out bool isDaylightSavings, out bool isAmbiguousLocalDst)
		{
			return default(System.TimeSpan);
		}

		// Token: 0x060003BC RID: 956 RVA: 0x00003F00 File Offset: 0x00002100
		[Token(Token = "0x60003BC")]
		[Address(RVA = "0x4C03800", Offset = "0x4C02400", VA = "0x184C03800")]
		internal static System.DateTime TransitionTimeToDateTime(int year, System.TimeZoneInfo.TransitionTime transitionTime)
		{
			return default(System.DateTime);
		}

		// Token: 0x060003BD RID: 957 RVA: 0x00003F18 File Offset: 0x00002118
		[Token(Token = "0x60003BD")]
		[Address(RVA = "0x4C061D0", Offset = "0x4C04DD0", VA = "0x184C061D0")]
		private static System.TimeZoneInfo.TimeZoneInfoResult TryGetTimeZone(string id, bool dstDisabled, out System.TimeZoneInfo value, out System.Exception e, System.TimeZoneInfo.CachedData cachedData, bool alwaysFallbackToLocalMachine = false)
		{
			return System.TimeZoneInfo.TimeZoneInfoResult.Success;
		}

		// Token: 0x060003BE RID: 958 RVA: 0x00003F30 File Offset: 0x00002130
		[Token(Token = "0x60003BE")]
		[Address(RVA = "0x4C058D0", Offset = "0x4C044D0", VA = "0x184C058D0")]
		private static System.TimeZoneInfo.TimeZoneInfoResult TryGetTimeZoneFromLocalMachine(string id, bool dstDisabled, out System.TimeZoneInfo value, out System.Exception e, System.TimeZoneInfo.CachedData cachedData)
		{
			return System.TimeZoneInfo.TimeZoneInfoResult.Success;
		}

		// Token: 0x060003BF RID: 959 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003BF")]
		[Address(RVA = "0x4C064D0", Offset = "0x4C050D0", VA = "0x184C064D0")]
		private static void ValidateTimeZoneInfo(string id, System.TimeSpan baseUtcOffset, System.TimeZoneInfo.AdjustmentRule[] adjustmentRules, out bool adjustmentRulesSupportDst)
		{
		}

		// Token: 0x060003C0 RID: 960 RVA: 0x00003F48 File Offset: 0x00002148
		[Token(Token = "0x60003C0")]
		[Address(RVA = "0x4C063E0", Offset = "0x4C04FE0", VA = "0x184C063E0")]
		internal static bool UtcOffsetOutOfRange(System.TimeSpan offset)
		{
			return default(bool);
		}

		// Token: 0x060003C1 RID: 961 RVA: 0x00003F60 File Offset: 0x00002160
		[Token(Token = "0x60003C1")]
		[Address(RVA = "0x4C01620", Offset = "0x4C00220", VA = "0x184C01620")]
		private static System.TimeSpan GetUtcOffset(System.TimeSpan baseUtcOffset, System.TimeZoneInfo.AdjustmentRule adjustmentRule)
		{
			return default(System.TimeSpan);
		}

		// Token: 0x060003C2 RID: 962 RVA: 0x00003F78 File Offset: 0x00002178
		[Token(Token = "0x60003C2")]
		[Address(RVA = "0x4C02060", Offset = "0x4C00C60", VA = "0x184C02060")]
		private static bool IsValidAdjustmentRuleOffest(System.TimeSpan baseUtcOffset, System.TimeZoneInfo.AdjustmentRule adjustmentRule)
		{
			return default(bool);
		}

		// Token: 0x060003C4 RID: 964 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003C4")]
		[Address(RVA = "0x4C070C0", Offset = "0x4C05CC0", VA = "0x184C070C0")]
		internal TimeZoneInfo()
		{
		}

		// Token: 0x04000279 RID: 633
		[Token(Token = "0x4000279")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static System.Lazy<bool> lazyHaveRegistry;

		// Token: 0x0400027A RID: 634
		[Token(Token = "0x400027A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly string _id;

		// Token: 0x0400027B RID: 635
		[Token(Token = "0x400027B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly string _displayName;

		// Token: 0x0400027C RID: 636
		[Token(Token = "0x400027C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly string _standardDisplayName;

		// Token: 0x0400027D RID: 637
		[Token(Token = "0x400027D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly string _daylightDisplayName;

		// Token: 0x0400027E RID: 638
		[Token(Token = "0x400027E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private readonly System.TimeSpan _baseUtcOffset;

		// Token: 0x0400027F RID: 639
		[Token(Token = "0x400027F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private readonly bool _supportsDaylightSavingTime;

		// Token: 0x04000280 RID: 640
		[Token(Token = "0x4000280")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private readonly System.TimeZoneInfo.AdjustmentRule[] _adjustmentRules;

		// Token: 0x04000281 RID: 641
		[Token(Token = "0x4000281")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly System.TimeZoneInfo s_utcTimeZone;

		// Token: 0x04000282 RID: 642
		[Token(Token = "0x4000282")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static System.TimeZoneInfo.CachedData s_cachedData;

		// Token: 0x04000283 RID: 643
		[Token(Token = "0x4000283")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static readonly System.DateTime s_maxDateOnly;

		// Token: 0x04000284 RID: 644
		[Token(Token = "0x4000284")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static readonly System.DateTime s_minDateOnly;

		// Token: 0x04000285 RID: 645
		[Token(Token = "0x4000285")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static readonly System.TimeSpan MaxOffset;

		// Token: 0x04000286 RID: 646
		[Token(Token = "0x4000286")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static readonly System.TimeSpan MinOffset;

		// Token: 0x02000097 RID: 151
		[Token(Token = "0x2000097")]
		private sealed class CachedData
		{
			// Token: 0x060003C5 RID: 965 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x60003C5")]
			[Address(RVA = "0x4BED890", Offset = "0x4BEC490", VA = "0x184BED890")]
			private static System.TimeZoneInfo GetCurrentOneYearLocal()
			{
				return null;
			}

			// Token: 0x060003C6 RID: 966 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x60003C6")]
			[Address(RVA = "0x4BED990", Offset = "0x4BEC590", VA = "0x184BED990")]
			public System.TimeZoneInfo.OffsetAndRule GetOneYearLocalFromUtc(int year)
			{
				return null;
			}

			// Token: 0x060003C7 RID: 967 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x60003C7")]
			[Address(RVA = "0x4BED650", Offset = "0x4BEC250", VA = "0x184BED650")]
			private System.TimeZoneInfo CreateLocal()
			{
				return null;
			}

			// Token: 0x1700004C RID: 76
			// (get) Token: 0x060003C8 RID: 968 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x1700004C")]
			public System.TimeZoneInfo Local
			{
				[Token(Token = "0x60003C8")]
				[Address(RVA = "0x4BEDB60", Offset = "0x4BEC760", VA = "0x184BEDB60")]
				get
				{
					return null;
				}
			}

			// Token: 0x060003C9 RID: 969 RVA: 0x00003F90 File Offset: 0x00002190
			[Token(Token = "0x60003C9")]
			[Address(RVA = "0x4BED800", Offset = "0x4BEC400", VA = "0x184BED800")]
			public System.DateTimeKind GetCorrespondingKind(System.TimeZoneInfo timeZone)
			{
				return System.DateTimeKind.Unspecified;
			}

			// Token: 0x060003CA RID: 970 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60003CA")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public CachedData()
			{
			}

			// Token: 0x04000287 RID: 647
			[Token(Token = "0x4000287")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private System.TimeZoneInfo.OffsetAndRule _oneYearLocalFromUtc;

			// Token: 0x04000288 RID: 648
			[Token(Token = "0x4000288")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private System.TimeZoneInfo _localTimeZone;

			// Token: 0x04000289 RID: 649
			[Token(Token = "0x4000289")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public System.Collections.Generic.Dictionary<string, System.TimeZoneInfo> _systemTimeZones;

			// Token: 0x0400028A RID: 650
			[Token(Token = "0x400028A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public System.Collections.ObjectModel.ReadOnlyCollection<System.TimeZoneInfo> _readOnlySystemTimeZones;

			// Token: 0x0400028B RID: 651
			[Token(Token = "0x400028B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public bool _allSystemTimeZonesRead;
		}

		// Token: 0x02000098 RID: 152
		[Token(Token = "0x2000098")]
		private sealed class OffsetAndRule
		{
			// Token: 0x060003CB RID: 971 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60003CB")]
			[Address(RVA = "0x4BEE060", Offset = "0x4BECC60", VA = "0x184BEE060")]
			public OffsetAndRule(int year, System.TimeSpan offset, System.TimeZoneInfo.AdjustmentRule rule)
			{
			}

			// Token: 0x0400028C RID: 652
			[Token(Token = "0x400028C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public readonly int Year;

			// Token: 0x0400028D RID: 653
			[Token(Token = "0x400028D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public readonly System.TimeSpan Offset;

			// Token: 0x0400028E RID: 654
			[Token(Token = "0x400028E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public readonly System.TimeZoneInfo.AdjustmentRule Rule;
		}

		// Token: 0x02000099 RID: 153
		[Token(Token = "0x2000099")]
		[StructLayout(0, CharSet = System.Runtime.InteropServices.CharSet.Unicode)]
		internal struct DYNAMIC_TIME_ZONE_INFORMATION
		{
			// Token: 0x0400028F RID: 655
			[Token(Token = "0x400028F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal Interop.Kernel32.TIME_ZONE_INFORMATION TZI;

			// Token: 0x04000290 RID: 656
			[Token(Token = "0x4000290")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			internal string TimeZoneKeyName;

			// Token: 0x04000291 RID: 657
			[Token(Token = "0x4000291")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			internal byte DynamicDaylightTimeDisabled;
		}

		// Token: 0x0200009A RID: 154
		[Token(Token = "0x200009A")]
		private enum TimeZoneInfoResult
		{
			// Token: 0x04000293 RID: 659
			[Token(Token = "0x4000293")]
			Success,
			// Token: 0x04000294 RID: 660
			[Token(Token = "0x4000294")]
			TimeZoneNotFoundException,
			// Token: 0x04000295 RID: 661
			[Token(Token = "0x4000295")]
			InvalidTimeZoneException,
			// Token: 0x04000296 RID: 662
			[Token(Token = "0x4000296")]
			SecurityException
		}

		// Token: 0x0200009B RID: 155
		[Token(Token = "0x200009B")]
		[System.Serializable]
		public sealed class AdjustmentRule : System.IEquatable<System.TimeZoneInfo.AdjustmentRule>, System.Runtime.Serialization.ISerializable, System.Runtime.Serialization.IDeserializationCallback
		{
			// Token: 0x1700004D RID: 77
			// (get) Token: 0x060003CC RID: 972 RVA: 0x00003FA8 File Offset: 0x000021A8
			[Token(Token = "0x1700004D")]
			public System.DateTime DateStart
			{
				[Token(Token = "0x60003CC")]
				[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
				get
				{
					return default(System.DateTime);
				}
			}

			// Token: 0x1700004E RID: 78
			// (get) Token: 0x060003CD RID: 973 RVA: 0x00003FC0 File Offset: 0x000021C0
			[Token(Token = "0x1700004E")]
			public System.DateTime DateEnd
			{
				[Token(Token = "0x60003CD")]
				[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
				get
				{
					return default(System.DateTime);
				}
			}

			// Token: 0x1700004F RID: 79
			// (get) Token: 0x060003CE RID: 974 RVA: 0x00003FD8 File Offset: 0x000021D8
			[Token(Token = "0x1700004F")]
			public System.TimeSpan DaylightDelta
			{
				[Token(Token = "0x60003CE")]
				[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
				get
				{
					return default(System.TimeSpan);
				}
			}

			// Token: 0x17000050 RID: 80
			// (get) Token: 0x060003CF RID: 975 RVA: 0x00003FF0 File Offset: 0x000021F0
			[Token(Token = "0x17000050")]
			public System.TimeZoneInfo.TransitionTime DaylightTransitionStart
			{
				[Token(Token = "0x60003CF")]
				[Address(RVA = "0x4013E30", Offset = "0x4012A30", VA = "0x184013E30")]
				get
				{
					return default(System.TimeZoneInfo.TransitionTime);
				}
			}

			// Token: 0x17000051 RID: 81
			// (get) Token: 0x060003D0 RID: 976 RVA: 0x00004008 File Offset: 0x00002208
			[Token(Token = "0x17000051")]
			public System.TimeZoneInfo.TransitionTime DaylightTransitionEnd
			{
				[Token(Token = "0x60003D0")]
				[Address(RVA = "0x4BED450", Offset = "0x4BEC050", VA = "0x184BED450")]
				get
				{
					return default(System.TimeZoneInfo.TransitionTime);
				}
			}

			// Token: 0x17000052 RID: 82
			// (get) Token: 0x060003D1 RID: 977 RVA: 0x00004020 File Offset: 0x00002220
			[Token(Token = "0x17000052")]
			internal System.TimeSpan BaseUtcOffsetDelta
			{
				[Token(Token = "0x60003D1")]
				[Address(RVA = "0x5EC4B0", Offset = "0x5EB0B0", VA = "0x1805EC4B0")]
				get
				{
					return default(System.TimeSpan);
				}
			}

			// Token: 0x17000053 RID: 83
			// (get) Token: 0x060003D2 RID: 978 RVA: 0x00004038 File Offset: 0x00002238
			[Token(Token = "0x17000053")]
			internal bool NoDaylightTransitions
			{
				[Token(Token = "0x60003D2")]
				[Address(RVA = "0x1A88D30", Offset = "0x1A87930", VA = "0x181A88D30")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17000054 RID: 84
			// (get) Token: 0x060003D3 RID: 979 RVA: 0x00004050 File Offset: 0x00002250
			[Token(Token = "0x17000054")]
			internal bool HasDaylightSaving
			{
				[Token(Token = "0x60003D3")]
				[Address(RVA = "0x4BED470", Offset = "0x4BEC070", VA = "0x184BED470")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x060003D4 RID: 980 RVA: 0x00004068 File Offset: 0x00002268
			[Token(Token = "0x60003D4")]
			[Address(RVA = "0x4BEC0A0", Offset = "0x4BEACA0", VA = "0x184BEC0A0", Slot = "4")]
			public bool Equals(System.TimeZoneInfo.AdjustmentRule other)
			{
				return default(bool);
			}

			// Token: 0x060003D5 RID: 981 RVA: 0x00004080 File Offset: 0x00002280
			[Token(Token = "0x60003D5")]
			[Address(RVA = "0x4BEC220", Offset = "0x4BEAE20", VA = "0x184BEC220", Slot = "2")]
			public override int GetHashCode()
			{
				return 0;
			}

			// Token: 0x060003D6 RID: 982 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60003D6")]
			[Address(RVA = "0x4BED310", Offset = "0x4BEBF10", VA = "0x184BED310")]
			private AdjustmentRule(System.DateTime dateStart, System.DateTime dateEnd, System.TimeSpan daylightDelta, System.TimeZoneInfo.TransitionTime daylightTransitionStart, System.TimeZoneInfo.TransitionTime daylightTransitionEnd, System.TimeSpan baseUtcOffsetDelta, bool noDaylightTransitions)
			{
			}

			// Token: 0x060003D7 RID: 983 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x60003D7")]
			[Address(RVA = "0x4BEBF40", Offset = "0x4BEAB40", VA = "0x184BEBF40")]
			internal static System.TimeZoneInfo.AdjustmentRule CreateAdjustmentRule(System.DateTime dateStart, System.DateTime dateEnd, System.TimeSpan daylightDelta, System.TimeZoneInfo.TransitionTime daylightTransitionStart, System.TimeZoneInfo.TransitionTime daylightTransitionEnd, System.TimeSpan baseUtcOffsetDelta, bool noDaylightTransitions)
			{
				return null;
			}

			// Token: 0x060003D8 RID: 984 RVA: 0x00004098 File Offset: 0x00002298
			[Token(Token = "0x60003D8")]
			[Address(RVA = "0x4BEC3D0", Offset = "0x4BEAFD0", VA = "0x184BEC3D0")]
			internal bool IsStartDateMarkerForBeginningOfYear()
			{
				return default(bool);
			}

			// Token: 0x060003D9 RID: 985 RVA: 0x000040B0 File Offset: 0x000022B0
			[Token(Token = "0x60003D9")]
			[Address(RVA = "0x4BEC270", Offset = "0x4BEAE70", VA = "0x184BEC270")]
			internal bool IsEndDateMarkerForEndOfYear()
			{
				return default(bool);
			}

			// Token: 0x060003DA RID: 986 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60003DA")]
			[Address(RVA = "0x4BEC820", Offset = "0x4BEB420", VA = "0x184BEC820")]
			private static void ValidateAdjustmentRule(System.DateTime dateStart, System.DateTime dateEnd, System.TimeSpan daylightDelta, System.TimeZoneInfo.TransitionTime daylightTransitionStart, System.TimeZoneInfo.TransitionTime daylightTransitionEnd, bool noDaylightTransitions)
			{
			}

			// Token: 0x060003DB RID: 987 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60003DB")]
			[Address(RVA = "0x4BEC530", Offset = "0x4BEB130", VA = "0x184BEC530", Slot = "6")]
			private void OnDeserialization(object sender)
			{
			}

			// Token: 0x060003DC RID: 988 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60003DC")]
			[Address(RVA = "0x4BEC610", Offset = "0x4BEB210", VA = "0x184BEC610", Slot = "5")]
			private void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
			{
			}

			// Token: 0x060003DD RID: 989 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60003DD")]
			[Address(RVA = "0x4BECEF0", Offset = "0x4BEBAF0", VA = "0x184BECEF0")]
			private AdjustmentRule(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
			{
			}

			// Token: 0x060003DE RID: 990 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60003DE")]
			[Address(RVA = "0x4BED420", Offset = "0x4BEC020", VA = "0x184BED420")]
			internal AdjustmentRule()
			{
			}

			// Token: 0x04000297 RID: 663
			[Token(Token = "0x4000297")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly System.DateTime _dateStart;

			// Token: 0x04000298 RID: 664
			[Token(Token = "0x4000298")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private readonly System.DateTime _dateEnd;

			// Token: 0x04000299 RID: 665
			[Token(Token = "0x4000299")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private readonly System.TimeSpan _daylightDelta;

			// Token: 0x0400029A RID: 666
			[Token(Token = "0x400029A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private readonly System.TimeZoneInfo.TransitionTime _daylightTransitionStart;

			// Token: 0x0400029B RID: 667
			[Token(Token = "0x400029B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private readonly System.TimeZoneInfo.TransitionTime _daylightTransitionEnd;

			// Token: 0x0400029C RID: 668
			[Token(Token = "0x400029C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private readonly System.TimeSpan _baseUtcOffsetDelta;

			// Token: 0x0400029D RID: 669
			[Token(Token = "0x400029D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private readonly bool _noDaylightTransitions;
		}

		// Token: 0x0200009C RID: 156
		[Token(Token = "0x200009C")]
		[System.Serializable]
		public readonly struct TransitionTime : System.IEquatable<System.TimeZoneInfo.TransitionTime>, System.Runtime.Serialization.ISerializable, System.Runtime.Serialization.IDeserializationCallback
		{
			// Token: 0x17000055 RID: 85
			// (get) Token: 0x060003DF RID: 991 RVA: 0x000040C8 File Offset: 0x000022C8
			[Token(Token = "0x17000055")]
			public System.DateTime TimeOfDay
			{
				[Token(Token = "0x60003DF")]
				[Address(RVA = "0x925550", Offset = "0x924150", VA = "0x180925550")]
				get
				{
					return default(System.DateTime);
				}
			}

			// Token: 0x17000056 RID: 86
			// (get) Token: 0x060003E0 RID: 992 RVA: 0x000040E0 File Offset: 0x000022E0
			[Token(Token = "0x17000056")]
			public int Month
			{
				[Token(Token = "0x60003E0")]
				[Address(RVA = "0xFEDEC0", Offset = "0xFECAC0", VA = "0x180FEDEC0")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17000057 RID: 87
			// (get) Token: 0x060003E1 RID: 993 RVA: 0x000040F8 File Offset: 0x000022F8
			[Token(Token = "0x17000057")]
			public int Week
			{
				[Token(Token = "0x60003E1")]
				[Address(RVA = "0x4C084E0", Offset = "0x4C070E0", VA = "0x184C084E0")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17000058 RID: 88
			// (get) Token: 0x060003E2 RID: 994 RVA: 0x00004110 File Offset: 0x00002310
			[Token(Token = "0x17000058")]
			public int Day
			{
				[Token(Token = "0x60003E2")]
				[Address(RVA = "0x4C084D0", Offset = "0x4C070D0", VA = "0x184C084D0")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17000059 RID: 89
			// (get) Token: 0x060003E3 RID: 995 RVA: 0x00004128 File Offset: 0x00002328
			[Token(Token = "0x17000059")]
			public System.DayOfWeek DayOfWeek
			{
				[Token(Token = "0x60003E3")]
				[Address(RVA = "0x319ED80", Offset = "0x319D980", VA = "0x18319ED80")]
				get
				{
					return System.DayOfWeek.Sunday;
				}
			}

			// Token: 0x1700005A RID: 90
			// (get) Token: 0x060003E4 RID: 996 RVA: 0x00004140 File Offset: 0x00002340
			[Token(Token = "0x1700005A")]
			public bool IsFixedDateRule
			{
				[Token(Token = "0x60003E4")]
				[Address(RVA = "0x4E6300", Offset = "0x4E4F00", VA = "0x1804E6300")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x060003E5 RID: 997 RVA: 0x00004158 File Offset: 0x00002358
			[Token(Token = "0x60003E5")]
			[Address(RVA = "0x4C07910", Offset = "0x4C06510", VA = "0x184C07910", Slot = "0")]
			public override bool Equals(object obj)
			{
				return default(bool);
			}

			// Token: 0x060003E6 RID: 998 RVA: 0x00004170 File Offset: 0x00002370
			[Token(Token = "0x60003E6")]
			[Address(RVA = "0x4C084F0", Offset = "0x4C070F0", VA = "0x184C084F0")]
			public static bool operator !=(System.TimeZoneInfo.TransitionTime t1, System.TimeZoneInfo.TransitionTime t2)
			{
				return default(bool);
			}

			// Token: 0x060003E7 RID: 999 RVA: 0x00004188 File Offset: 0x00002388
			[Token(Token = "0x60003E7")]
			[Address(RVA = "0x4C079B0", Offset = "0x4C065B0", VA = "0x184C079B0", Slot = "4")]
			public bool Equals(System.TimeZoneInfo.TransitionTime other)
			{
				return default(bool);
			}

			// Token: 0x060003E8 RID: 1000 RVA: 0x000041A0 File Offset: 0x000023A0
			[Token(Token = "0x60003E8")]
			[Address(RVA = "0x4C07AD0", Offset = "0x4C066D0", VA = "0x184C07AD0", Slot = "2")]
			public override int GetHashCode()
			{
				return 0;
			}

			// Token: 0x060003E9 RID: 1001 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60003E9")]
			[Address(RVA = "0x4C080B0", Offset = "0x4C06CB0", VA = "0x184C080B0")]
			private TransitionTime(System.DateTime timeOfDay, int month, int week, int day, System.DayOfWeek dayOfWeek, bool isFixedDateRule)
			{
			}

			// Token: 0x060003EA RID: 1002 RVA: 0x000041B8 File Offset: 0x000023B8
			[Token(Token = "0x60003EA")]
			[Address(RVA = "0x4C07800", Offset = "0x4C06400", VA = "0x184C07800")]
			public static System.TimeZoneInfo.TransitionTime CreateFixedDateRule(System.DateTime timeOfDay, int month, int day)
			{
				return default(System.TimeZoneInfo.TransitionTime);
			}

			// Token: 0x060003EB RID: 1003 RVA: 0x000041D0 File Offset: 0x000023D0
			[Token(Token = "0x60003EB")]
			[Address(RVA = "0x4C07880", Offset = "0x4C06480", VA = "0x184C07880")]
			public static System.TimeZoneInfo.TransitionTime CreateFloatingDateRule(System.DateTime timeOfDay, int month, int week, System.DayOfWeek dayOfWeek)
			{
				return default(System.TimeZoneInfo.TransitionTime);
			}

			// Token: 0x060003EC RID: 1004 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60003EC")]
			[Address(RVA = "0x4C07D10", Offset = "0x4C06910", VA = "0x184C07D10")]
			private static void ValidateTransitionTime(System.DateTime timeOfDay, int month, int week, int day, System.DayOfWeek dayOfWeek)
			{
			}

			// Token: 0x060003ED RID: 1005 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60003ED")]
			[Address(RVA = "0x4C07AE0", Offset = "0x4C066E0", VA = "0x184C07AE0", Slot = "6")]
			private void OnDeserialization(object sender)
			{
			}

			// Token: 0x060003EE RID: 1006 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60003EE")]
			[Address(RVA = "0x4C07B90", Offset = "0x4C06790", VA = "0x184C07B90", Slot = "5")]
			private void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
			{
			}

			// Token: 0x060003EF RID: 1007 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60003EF")]
			[Address(RVA = "0x4C08140", Offset = "0x4C06D40", VA = "0x184C08140")]
			private TransitionTime(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
			{
			}

			// Token: 0x0400029E RID: 670
			[Token(Token = "0x400029E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private readonly System.DateTime _timeOfDay;

			// Token: 0x0400029F RID: 671
			[Token(Token = "0x400029F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private readonly byte _month;

			// Token: 0x040002A0 RID: 672
			[Token(Token = "0x40002A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9")]
			private readonly byte _week;

			// Token: 0x040002A1 RID: 673
			[Token(Token = "0x40002A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA")]
			private readonly byte _day;

			// Token: 0x040002A2 RID: 674
			[Token(Token = "0x40002A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			private readonly System.DayOfWeek _dayOfWeek;

			// Token: 0x040002A3 RID: 675
			[Token(Token = "0x40002A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly bool _isFixedDateRule;
		}
	}
}
