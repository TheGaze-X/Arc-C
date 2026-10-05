using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace UnityEngine.InputSystem.HID
{
	// Token: 0x0200013F RID: 319
	[Token(Token = "0x200013F")]
	internal static class HIDParser
	{
		// Token: 0x06000E34 RID: 3636 RVA: 0x00006FF0 File Offset: 0x000051F0
		[Token(Token = "0x6000E34")]
		[Address(RVA = "0x56D8030", Offset = "0x56D6C30", VA = "0x1856D8030")]
		public static bool ParseReportDescriptor(byte[] buffer, ref HID.HIDDeviceDescriptor deviceDescriptor)
		{
			return default(bool);
		}

		// Token: 0x06000E35 RID: 3637 RVA: 0x00007008 File Offset: 0x00005208
		[Token(Token = "0x6000E35")]
		[Address(RVA = "0x56D80C0", Offset = "0x56D6CC0", VA = "0x1856D80C0")]
		public unsafe static bool ParseReportDescriptor(byte* bufferPtr, int bufferLength, ref HID.HIDDeviceDescriptor deviceDescriptor)
		{
			return default(bool);
		}

		// Token: 0x06000E36 RID: 3638 RVA: 0x00007020 File Offset: 0x00005220
		[Token(Token = "0x6000E36")]
		[Address(RVA = "0x56D8ED0", Offset = "0x56D7AD0", VA = "0x1856D8ED0")]
		private unsafe static int ReadData(int itemSize, byte* currentPtr, byte* endPtr)
		{
			return 0;
		}

		// Token: 0x02000140 RID: 320
		[Token(Token = "0x2000140")]
		private struct HIDReportData
		{
			// Token: 0x06000E37 RID: 3639 RVA: 0x00007038 File Offset: 0x00005238
			[Token(Token = "0x6000E37")]
			[Address(RVA = "0x56D8F30", Offset = "0x56D7B30", VA = "0x1856D8F30")]
			public static int FindOrAddReport(int? reportId, HID.HIDReportType reportType, List<HIDParser.HIDReportData> reports)
			{
				return 0;
			}

			// Token: 0x040007E3 RID: 2019
			[Token(Token = "0x40007E3")]
			[FieldOffset(Offset = "0x0")]
			public int reportId;

			// Token: 0x040007E4 RID: 2020
			[Token(Token = "0x40007E4")]
			[FieldOffset(Offset = "0x4")]
			public HID.HIDReportType reportType;

			// Token: 0x040007E5 RID: 2021
			[Token(Token = "0x40007E5")]
			[FieldOffset(Offset = "0x8")]
			public int currentBitOffset;
		}

		// Token: 0x02000141 RID: 321
		[Token(Token = "0x2000141")]
		private enum HIDItemTypeAndTag
		{
			// Token: 0x040007E7 RID: 2023
			[Token(Token = "0x40007E7")]
			Input = 128,
			// Token: 0x040007E8 RID: 2024
			[Token(Token = "0x40007E8")]
			Output = 144,
			// Token: 0x040007E9 RID: 2025
			[Token(Token = "0x40007E9")]
			Feature = 176,
			// Token: 0x040007EA RID: 2026
			[Token(Token = "0x40007EA")]
			Collection = 160,
			// Token: 0x040007EB RID: 2027
			[Token(Token = "0x40007EB")]
			EndCollection = 192,
			// Token: 0x040007EC RID: 2028
			[Token(Token = "0x40007EC")]
			UsagePage = 4,
			// Token: 0x040007ED RID: 2029
			[Token(Token = "0x40007ED")]
			LogicalMinimum = 20,
			// Token: 0x040007EE RID: 2030
			[Token(Token = "0x40007EE")]
			LogicalMaximum = 36,
			// Token: 0x040007EF RID: 2031
			[Token(Token = "0x40007EF")]
			PhysicalMinimum = 52,
			// Token: 0x040007F0 RID: 2032
			[Token(Token = "0x40007F0")]
			PhysicalMaximum = 68,
			// Token: 0x040007F1 RID: 2033
			[Token(Token = "0x40007F1")]
			UnitExponent = 84,
			// Token: 0x040007F2 RID: 2034
			[Token(Token = "0x40007F2")]
			Unit = 100,
			// Token: 0x040007F3 RID: 2035
			[Token(Token = "0x40007F3")]
			ReportSize = 116,
			// Token: 0x040007F4 RID: 2036
			[Token(Token = "0x40007F4")]
			ReportID = 132,
			// Token: 0x040007F5 RID: 2037
			[Token(Token = "0x40007F5")]
			ReportCount = 148,
			// Token: 0x040007F6 RID: 2038
			[Token(Token = "0x40007F6")]
			Push = 164,
			// Token: 0x040007F7 RID: 2039
			[Token(Token = "0x40007F7")]
			Pop = 180,
			// Token: 0x040007F8 RID: 2040
			[Token(Token = "0x40007F8")]
			Usage = 8,
			// Token: 0x040007F9 RID: 2041
			[Token(Token = "0x40007F9")]
			UsageMinimum = 24,
			// Token: 0x040007FA RID: 2042
			[Token(Token = "0x40007FA")]
			UsageMaximum = 40,
			// Token: 0x040007FB RID: 2043
			[Token(Token = "0x40007FB")]
			DesignatorIndex = 56,
			// Token: 0x040007FC RID: 2044
			[Token(Token = "0x40007FC")]
			DesignatorMinimum = 72,
			// Token: 0x040007FD RID: 2045
			[Token(Token = "0x40007FD")]
			DesignatorMaximum = 88,
			// Token: 0x040007FE RID: 2046
			[Token(Token = "0x40007FE")]
			StringIndex = 120,
			// Token: 0x040007FF RID: 2047
			[Token(Token = "0x40007FF")]
			StringMinimum = 136,
			// Token: 0x04000800 RID: 2048
			[Token(Token = "0x4000800")]
			StringMaximum = 152,
			// Token: 0x04000801 RID: 2049
			[Token(Token = "0x4000801")]
			Delimiter = 168
		}

		// Token: 0x02000142 RID: 322
		[Token(Token = "0x2000142")]
		private struct HIDItemStateLocal
		{
			// Token: 0x06000E38 RID: 3640 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000E38")]
			[Address(RVA = "0x56D7E40", Offset = "0x56D6A40", VA = "0x1856D7E40")]
			public static void Reset(ref HIDParser.HIDItemStateLocal state)
			{
			}

			// Token: 0x06000E39 RID: 3641 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000E39")]
			[Address(RVA = "0x56D7EB0", Offset = "0x56D6AB0", VA = "0x1856D7EB0")]
			public void SetUsage(int value)
			{
			}

			// Token: 0x06000E3A RID: 3642 RVA: 0x00007050 File Offset: 0x00005250
			[Token(Token = "0x6000E3A")]
			[Address(RVA = "0x56D7D30", Offset = "0x56D6930", VA = "0x1856D7D30")]
			public int GetUsage(int index)
			{
				return 0;
			}

			// Token: 0x04000802 RID: 2050
			[Token(Token = "0x4000802")]
			[FieldOffset(Offset = "0x0")]
			public int? usage;

			// Token: 0x04000803 RID: 2051
			[Token(Token = "0x4000803")]
			[FieldOffset(Offset = "0x8")]
			public int? usageMinimum;

			// Token: 0x04000804 RID: 2052
			[Token(Token = "0x4000804")]
			[FieldOffset(Offset = "0x10")]
			public int? usageMaximum;

			// Token: 0x04000805 RID: 2053
			[Token(Token = "0x4000805")]
			[FieldOffset(Offset = "0x18")]
			public int? designatorIndex;

			// Token: 0x04000806 RID: 2054
			[Token(Token = "0x4000806")]
			[FieldOffset(Offset = "0x20")]
			public int? designatorMinimum;

			// Token: 0x04000807 RID: 2055
			[Token(Token = "0x4000807")]
			[FieldOffset(Offset = "0x28")]
			public int? designatorMaximum;

			// Token: 0x04000808 RID: 2056
			[Token(Token = "0x4000808")]
			[FieldOffset(Offset = "0x30")]
			public int? stringIndex;

			// Token: 0x04000809 RID: 2057
			[Token(Token = "0x4000809")]
			[FieldOffset(Offset = "0x38")]
			public int? stringMinimum;

			// Token: 0x0400080A RID: 2058
			[Token(Token = "0x400080A")]
			[FieldOffset(Offset = "0x40")]
			public int? stringMaximum;

			// Token: 0x0400080B RID: 2059
			[Token(Token = "0x400080B")]
			[FieldOffset(Offset = "0x48")]
			public List<int> usageList;
		}

		// Token: 0x02000143 RID: 323
		[Token(Token = "0x2000143")]
		private struct HIDItemStateGlobal
		{
			// Token: 0x06000E3B RID: 3643 RVA: 0x00007068 File Offset: 0x00005268
			[Token(Token = "0x6000E3B")]
			[Address(RVA = "0x56D7CA0", Offset = "0x56D68A0", VA = "0x1856D7CA0")]
			public HID.UsagePage GetUsagePage(int index, ref HIDParser.HIDItemStateLocal localItemState)
			{
				return HID.UsagePage.Undefined;
			}

			// Token: 0x06000E3C RID: 3644 RVA: 0x00007080 File Offset: 0x00005280
			[Token(Token = "0x6000E3C")]
			[Address(RVA = "0x56D7BE0", Offset = "0x56D67E0", VA = "0x1856D7BE0")]
			public int GetPhysicalMin()
			{
				return 0;
			}

			// Token: 0x06000E3D RID: 3645 RVA: 0x00007098 File Offset: 0x00005298
			[Token(Token = "0x6000E3D")]
			[Address(RVA = "0x56D7B30", Offset = "0x56D6730", VA = "0x1856D7B30")]
			public int GetPhysicalMax()
			{
				return 0;
			}

			// Token: 0x0400080C RID: 2060
			[Token(Token = "0x400080C")]
			[FieldOffset(Offset = "0x0")]
			public int? usagePage;

			// Token: 0x0400080D RID: 2061
			[Token(Token = "0x400080D")]
			[FieldOffset(Offset = "0x8")]
			public int? logicalMinimum;

			// Token: 0x0400080E RID: 2062
			[Token(Token = "0x400080E")]
			[FieldOffset(Offset = "0x10")]
			public int? logicalMaximum;

			// Token: 0x0400080F RID: 2063
			[Token(Token = "0x400080F")]
			[FieldOffset(Offset = "0x18")]
			public int? physicalMinimum;

			// Token: 0x04000810 RID: 2064
			[Token(Token = "0x4000810")]
			[FieldOffset(Offset = "0x20")]
			public int? physicalMaximum;

			// Token: 0x04000811 RID: 2065
			[Token(Token = "0x4000811")]
			[FieldOffset(Offset = "0x28")]
			public int? unitExponent;

			// Token: 0x04000812 RID: 2066
			[Token(Token = "0x4000812")]
			[FieldOffset(Offset = "0x30")]
			public int? unit;

			// Token: 0x04000813 RID: 2067
			[Token(Token = "0x4000813")]
			[FieldOffset(Offset = "0x38")]
			public int? reportSize;

			// Token: 0x04000814 RID: 2068
			[Token(Token = "0x4000814")]
			[FieldOffset(Offset = "0x40")]
			public int? reportCount;

			// Token: 0x04000815 RID: 2069
			[Token(Token = "0x4000815")]
			[FieldOffset(Offset = "0x48")]
			public int? reportId;
		}
	}
}
