using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace CriWare
{
	// Token: 0x02000101 RID: 257
	[Token(Token = "0x2000101")]
	public static class CriAtomExAcfDebug
	{
		// Token: 0x060007E1 RID: 2017 RVA: 0x0000413C File Offset: 0x0000233C
		[Token(Token = "0x60007E1")]
		[Address(RVA = "0x36DFFD0", Offset = "0x36DEBD0", VA = "0x1836DFFD0")]
		public static int GetNumCategories()
		{
			return 0;
		}

		// Token: 0x060007E2 RID: 2018 RVA: 0x00004154 File Offset: 0x00002354
		[Token(Token = "0x60007E2")]
		[Address(RVA = "0x36DF980", Offset = "0x36DE580", VA = "0x1836DF980")]
		public static bool GetCategoryInfoByIndex(ushort index, out CriAtomExAcfDebug.CategoryInfo categoryInfo)
		{
			return default(bool);
		}

		// Token: 0x060007E3 RID: 2019 RVA: 0x0000416C File Offset: 0x0000236C
		[Token(Token = "0x60007E3")]
		[Address(RVA = "0x36DFA60", Offset = "0x36DE660", VA = "0x1836DFA60")]
		public static bool GetCategoryInfoByName(string name, out CriAtomExAcfDebug.CategoryInfo categoryInfo)
		{
			return default(bool);
		}

		// Token: 0x060007E4 RID: 2020 RVA: 0x00004184 File Offset: 0x00002384
		[Token(Token = "0x60007E4")]
		[Address(RVA = "0x36DF8A0", Offset = "0x36DE4A0", VA = "0x1836DF8A0")]
		public static bool GetCategoryInfoById(uint id, out CriAtomExAcfDebug.CategoryInfo categoryInfo)
		{
			return default(bool);
		}

		// Token: 0x060007E5 RID: 2021 RVA: 0x0000419C File Offset: 0x0000239C
		[Token(Token = "0x60007E5")]
		[Address(RVA = "0x36DFF60", Offset = "0x36DEB60", VA = "0x1836DFF60")]
		public static int GetNumBuses()
		{
			return 0;
		}

		// Token: 0x060007E6 RID: 2022 RVA: 0x000041B4 File Offset: 0x000023B4
		[Token(Token = "0x60007E6")]
		[Address(RVA = "0x36DFB60", Offset = "0x36DE760", VA = "0x1836DFB60")]
		public static bool GetDspBusInformation(ushort index, out CriAtomExAcfDebug.DspBusInfo dspBusInfo)
		{
			return default(bool);
		}

		// Token: 0x060007E7 RID: 2023 RVA: 0x000041CC File Offset: 0x000023CC
		[Token(Token = "0x60007E7")]
		[Address(RVA = "0x36DFEF0", Offset = "0x36DEAF0", VA = "0x1836DFEF0")]
		public static int GetNumAisacControls()
		{
			return 0;
		}

		// Token: 0x060007E8 RID: 2024 RVA: 0x000041E4 File Offset: 0x000023E4
		[Token(Token = "0x60007E8")]
		[Address(RVA = "0x36DF760", Offset = "0x36DE360", VA = "0x1836DF760")]
		public static bool GetAisacControlInfo(ushort index, out CriAtomExAcfDebug.AisacControlInfo info)
		{
			return default(bool);
		}

		// Token: 0x060007E9 RID: 2025 RVA: 0x000041FC File Offset: 0x000023FC
		[Token(Token = "0x60007E9")]
		[Address(RVA = "0x36DF6C0", Offset = "0x36DE2C0", VA = "0x1836DF6C0")]
		public static uint GetAisacControlIdByName(string name)
		{
			return 0U;
		}

		// Token: 0x060007EA RID: 2026 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x60007EA")]
		[Address(RVA = "0x36DF820", Offset = "0x36DE420", VA = "0x1836DF820")]
		public static string GetAisacControlNameById(uint id)
		{
			return null;
		}

		// Token: 0x060007EB RID: 2027 RVA: 0x00004214 File Offset: 0x00002414
		[Token(Token = "0x60007EB")]
		[Address(RVA = "0x36E0040", Offset = "0x36DEC40", VA = "0x1836E0040")]
		public static int GetNumGlobalAisacs()
		{
			return 0;
		}

		// Token: 0x060007EC RID: 2028 RVA: 0x0000422C File Offset: 0x0000242C
		[Token(Token = "0x60007EC")]
		[Address(RVA = "0x36DFE00", Offset = "0x36DEA00", VA = "0x1836DFE00")]
		public static bool GetGlobalAisacInfo(ushort index, out CriAtomExAcfDebug.GlobalAisacInfo info)
		{
			return default(bool);
		}

		// Token: 0x060007ED RID: 2029 RVA: 0x00004244 File Offset: 0x00002444
		[Token(Token = "0x60007ED")]
		[Address(RVA = "0x36DFCF0", Offset = "0x36DE8F0", VA = "0x1836DFCF0")]
		public static bool GetGlobalAisacInfoByName(string name, out CriAtomExAcfDebug.GlobalAisacInfo info)
		{
			return default(bool);
		}

		// Token: 0x060007EE RID: 2030 RVA: 0x0000425C File Offset: 0x0000245C
		[Token(Token = "0x60007EE")]
		[Address(RVA = "0x36E00B0", Offset = "0x36DECB0", VA = "0x1836E00B0")]
		public static int GetNumSelectors()
		{
			return 0;
		}

		// Token: 0x060007EF RID: 2031 RVA: 0x00004274 File Offset: 0x00002474
		[Token(Token = "0x60007EF")]
		[Address(RVA = "0x36E0120", Offset = "0x36DED20", VA = "0x1836E0120")]
		public static bool GetSelectorInfoByIndex(ushort index, out CriAtomExAcfDebug.SelectorInfo info)
		{
			return default(bool);
		}

		// Token: 0x060007F0 RID: 2032 RVA: 0x0000428C File Offset: 0x0000248C
		[Token(Token = "0x60007F0")]
		[Address(RVA = "0x36E01F0", Offset = "0x36DEDF0", VA = "0x1836E01F0")]
		public static bool GetSelectorInfoByName(string name, out CriAtomExAcfDebug.SelectorInfo info)
		{
			return default(bool);
		}

		// Token: 0x060007F1 RID: 2033 RVA: 0x000042A4 File Offset: 0x000024A4
		[Token(Token = "0x60007F1")]
		[Address(RVA = "0x36E02E0", Offset = "0x36DEEE0", VA = "0x1836E02E0")]
		public static bool GetSelectorLabelInfo(ref CriAtomExAcfDebug.SelectorInfo selectorInfo, ushort index, out CriAtomExAcfDebug.SelectorLabelInfo labelInfo)
		{
			return default(bool);
		}

		// Token: 0x060007F2 RID: 2034
		[Token(Token = "0x60007F2")]
		[Address(RVA = "0x36DFFD0", Offset = "0x36DEBD0", VA = "0x1836DFFD0")]
		[PreserveSig]
		private static extern int criAtomExAcf_GetNumCategories();

		// Token: 0x060007F3 RID: 2035
		[Token(Token = "0x60007F3")]
		[Address(RVA = "0x36E0610", Offset = "0x36DF210", VA = "0x1836E0610")]
		[PreserveSig]
		private static extern int criAtomExAcf_GetCategoryInfo(ushort index, out CriAtomExAcfDebug.CategoryInfoForMarshaling categoryInfo);

		// Token: 0x060007F4 RID: 2036
		[Token(Token = "0x60007F4")]
		[Address(RVA = "0x36E0570", Offset = "0x36DF170", VA = "0x1836E0570")]
		[PreserveSig]
		private static extern int criAtomExAcf_GetCategoryInfoByName(string name, out CriAtomExAcfDebug.CategoryInfoForMarshaling categoryInfo);

		// Token: 0x060007F5 RID: 2037
		[Token(Token = "0x60007F5")]
		[Address(RVA = "0x36E04E0", Offset = "0x36DF0E0", VA = "0x1836E04E0")]
		[PreserveSig]
		private static extern int criAtomExAcf_GetCategoryInfoById(uint id, out CriAtomExAcfDebug.CategoryInfoForMarshaling categoryInfo);

		// Token: 0x060007F6 RID: 2038
		[Token(Token = "0x60007F6")]
		[Address(RVA = "0x36DFF60", Offset = "0x36DEB60", VA = "0x1836DFF60")]
		[PreserveSig]
		private static extern int criAtomExAcf_GetNumBuses();

		// Token: 0x060007F7 RID: 2039
		[Token(Token = "0x60007F7")]
		[Address(RVA = "0x36E06A0", Offset = "0x36DF2A0", VA = "0x1836E06A0")]
		[PreserveSig]
		private static extern int criAtomExAcf_GetDspBusInformation(ushort index, out CriAtomExAcfDebug.DspBusInfoForMarshaling dspBusInfo);

		// Token: 0x060007F8 RID: 2040
		[Token(Token = "0x60007F8")]
		[Address(RVA = "0x36DFEF0", Offset = "0x36DEAF0", VA = "0x1836DFEF0")]
		[PreserveSig]
		private static extern int criAtomExAcf_GetNumAisacControls();

		// Token: 0x060007F9 RID: 2041
		[Token(Token = "0x60007F9")]
		[Address(RVA = "0x36E03D0", Offset = "0x36DEFD0", VA = "0x1836E03D0")]
		[PreserveSig]
		private static extern int criAtomExAcf_GetAisacControlInfo(ushort index, out CriAtomExAcfDebug.AisacControlInfoForMarshaling info);

		// Token: 0x060007FA RID: 2042
		[Token(Token = "0x60007FA")]
		[Address(RVA = "0x36DF6C0", Offset = "0x36DE2C0", VA = "0x1836DF6C0")]
		[PreserveSig]
		private static extern uint criAtomExAcf_GetAisacControlIdByName(string name);

		// Token: 0x060007FB RID: 2043
		[Token(Token = "0x60007FB")]
		[Address(RVA = "0x36E0460", Offset = "0x36DF060", VA = "0x1836E0460")]
		[PreserveSig]
		private static extern IntPtr criAtomExAcf_GetAisacControlNameById(uint id);

		// Token: 0x060007FC RID: 2044
		[Token(Token = "0x60007FC")]
		[Address(RVA = "0x36E0040", Offset = "0x36DEC40", VA = "0x1836E0040")]
		[PreserveSig]
		private static extern int criAtomExAcf_GetNumGlobalAisacs();

		// Token: 0x060007FD RID: 2045
		[Token(Token = "0x60007FD")]
		[Address(RVA = "0x36E0860", Offset = "0x36DF460", VA = "0x1836E0860")]
		[PreserveSig]
		private static extern int criAtomExAcf_GetGlobalAisacInfo(ushort index, out CriAtomExAcfDebug.GlobalAisacInfoForMarshaling info);

		// Token: 0x060007FE RID: 2046
		[Token(Token = "0x60007FE")]
		[Address(RVA = "0x36E07C0", Offset = "0x36DF3C0", VA = "0x1836E07C0")]
		[PreserveSig]
		private static extern int criAtomExAcf_GetGlobalAisacInfoByName(string name, out CriAtomExAcfDebug.GlobalAisacInfoForMarshaling info);

		// Token: 0x060007FF RID: 2047
		[Token(Token = "0x60007FF")]
		[Address(RVA = "0x36E00B0", Offset = "0x36DECB0", VA = "0x1836E00B0")]
		[PreserveSig]
		private static extern int criAtomExAcf_GetNumSelectors();

		// Token: 0x06000800 RID: 2048
		[Token(Token = "0x6000800")]
		[Address(RVA = "0x36E08F0", Offset = "0x36DF4F0", VA = "0x1836E08F0")]
		[PreserveSig]
		private static extern int criAtomExAcf_GetSelectorInfoByIndex(ushort index, out CriAtomExAcfDebug.SelectorInfoForMarshaling info);

		// Token: 0x06000801 RID: 2049
		[Token(Token = "0x6000801")]
		[Address(RVA = "0x36E0980", Offset = "0x36DF580", VA = "0x1836E0980")]
		[PreserveSig]
		private static extern int criAtomExAcf_GetSelectorInfoByName(string name, out CriAtomExAcfDebug.SelectorInfoForMarshaling info);

		// Token: 0x06000802 RID: 2050
		[Token(Token = "0x6000802")]
		[Address(RVA = "0x36E0A20", Offset = "0x36DF620", VA = "0x1836E0A20")]
		[PreserveSig]
		private static extern int criAtomExAcf_GetSelectorLabelInfo(ref CriAtomExAcfDebug.SelectorInfoForMarshaling info, ushort labelIndex, out CriAtomExAcfDebug.SelectorLabelInfoForMarshaling label_info);

		// Token: 0x02000102 RID: 258
		[Token(Token = "0x2000102")]
		public struct CategoryInfo
		{
			// Token: 0x040004A3 RID: 1187
			[Token(Token = "0x40004A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public uint groupNo;

			// Token: 0x040004A4 RID: 1188
			[Token(Token = "0x40004A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public uint id;

			// Token: 0x040004A5 RID: 1189
			[Token(Token = "0x40004A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public string name;

			// Token: 0x040004A6 RID: 1190
			[Token(Token = "0x40004A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public uint numCueLimits;

			// Token: 0x040004A7 RID: 1191
			[Token(Token = "0x40004A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float volume;
		}

		// Token: 0x02000103 RID: 259
		[Token(Token = "0x2000103")]
		public struct DspBusInfo
		{
			// Token: 0x040004A8 RID: 1192
			[Token(Token = "0x40004A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public string name;

			// Token: 0x040004A9 RID: 1193
			[Token(Token = "0x40004A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public float volume;

			// Token: 0x040004AA RID: 1194
			[Token(Token = "0x40004AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public float pan3dVolume;

			// Token: 0x040004AB RID: 1195
			[Token(Token = "0x40004AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float pan3dAngle;

			// Token: 0x040004AC RID: 1196
			[Token(Token = "0x40004AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float pan3dDistance;

			// Token: 0x040004AD RID: 1197
			[Token(Token = "0x40004AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float pan3dSpread;

			// Token: 0x040004AE RID: 1198
			[Token(Token = "0x40004AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float pan3dWideness;

			// Token: 0x040004AF RID: 1199
			[Token(Token = "0x40004AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ushort[] fxIndexes;

			// Token: 0x040004B0 RID: 1200
			[Token(Token = "0x40004B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public ushort[] busLinkIndexes;

			// Token: 0x040004B1 RID: 1201
			[Token(Token = "0x40004B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public ushort busNo;

			// Token: 0x040004B2 RID: 1202
			[Token(Token = "0x40004B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
			public byte numFxes;

			// Token: 0x040004B3 RID: 1203
			[Token(Token = "0x40004B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x33")]
			public byte numBusLinks;
		}

		// Token: 0x02000104 RID: 260
		[Token(Token = "0x2000104")]
		public struct AisacControlInfo
		{
			// Token: 0x040004B4 RID: 1204
			[Token(Token = "0x40004B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public string name;

			// Token: 0x040004B5 RID: 1205
			[Token(Token = "0x40004B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public uint id;
		}

		// Token: 0x02000105 RID: 261
		[Token(Token = "0x2000105")]
		public enum AisacType
		{
			// Token: 0x040004B7 RID: 1207
			[Token(Token = "0x40004B7")]
			Normal,
			// Token: 0x040004B8 RID: 1208
			[Token(Token = "0x40004B8")]
			AutoModulation
		}

		// Token: 0x02000106 RID: 262
		[Token(Token = "0x2000106")]
		public struct GlobalAisacInfo
		{
			// Token: 0x040004B9 RID: 1209
			[Token(Token = "0x40004B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public string name;

			// Token: 0x040004BA RID: 1210
			[Token(Token = "0x40004BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public ushort index;

			// Token: 0x040004BB RID: 1211
			[Token(Token = "0x40004BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA")]
			public ushort numGraphs;

			// Token: 0x040004BC RID: 1212
			[Token(Token = "0x40004BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public CriAtomExAcfDebug.AisacType type;

			// Token: 0x040004BD RID: 1213
			[Token(Token = "0x40004BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float randomRange;

			// Token: 0x040004BE RID: 1214
			[Token(Token = "0x40004BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public ushort controlId;
		}

		// Token: 0x02000107 RID: 263
		[Token(Token = "0x2000107")]
		public struct SelectorInfo
		{
			// Token: 0x040004BF RID: 1215
			[Token(Token = "0x40004BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public string name;

			// Token: 0x040004C0 RID: 1216
			[Token(Token = "0x40004C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public ushort index;

			// Token: 0x040004C1 RID: 1217
			[Token(Token = "0x40004C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA")]
			public ushort numLabels;

			// Token: 0x040004C2 RID: 1218
			[Token(Token = "0x40004C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public ushort globalLabelIndex;
		}

		// Token: 0x02000108 RID: 264
		[Token(Token = "0x2000108")]
		public struct SelectorLabelInfo
		{
			// Token: 0x040004C3 RID: 1219
			[Token(Token = "0x40004C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public string selectorName;

			// Token: 0x040004C4 RID: 1220
			[Token(Token = "0x40004C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public string labelName;
		}

		// Token: 0x02000109 RID: 265
		[Token(Token = "0x2000109")]
		private struct CategoryInfoForMarshaling
		{
			// Token: 0x06000803 RID: 2051 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000803")]
			[Address(RVA = "0x36DE370", Offset = "0x36DCF70", VA = "0x1836DE370")]
			public void Convert(out CriAtomExAcfDebug.CategoryInfo x)
			{
			}

			// Token: 0x040004C5 RID: 1221
			[Token(Token = "0x40004C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public uint groupNo;

			// Token: 0x040004C6 RID: 1222
			[Token(Token = "0x40004C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public uint id;

			// Token: 0x040004C7 RID: 1223
			[Token(Token = "0x40004C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public IntPtr namePtr;

			// Token: 0x040004C8 RID: 1224
			[Token(Token = "0x40004C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public uint numCueLimits;

			// Token: 0x040004C9 RID: 1225
			[Token(Token = "0x40004C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float volume;
		}

		// Token: 0x0200010A RID: 266
		[Token(Token = "0x200010A")]
		private struct DspBusInfoForMarshaling
		{
			// Token: 0x06000804 RID: 2052 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000804")]
			[Address(RVA = "0x37073A0", Offset = "0x3705FA0", VA = "0x1837073A0")]
			public void Convert(out CriAtomExAcfDebug.DspBusInfo x)
			{
			}

			// Token: 0x040004CA RID: 1226
			[Token(Token = "0x40004CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public IntPtr namePtr;

			// Token: 0x040004CB RID: 1227
			[Token(Token = "0x40004CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public float volume;

			// Token: 0x040004CC RID: 1228
			[Token(Token = "0x40004CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public float pan3dVolume;

			// Token: 0x040004CD RID: 1229
			[Token(Token = "0x40004CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float pan3dAngle;

			// Token: 0x040004CE RID: 1230
			[Token(Token = "0x40004CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float pan3dDistance;

			// Token: 0x040004CF RID: 1231
			[Token(Token = "0x40004CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float pan3dSpread;

			// Token: 0x040004D0 RID: 1232
			[Token(Token = "0x40004D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float pan3dWideness;

			// Token: 0x040004D1 RID: 1233
			[Token(Token = "0x40004D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ushort[] fxIndexes;

			// Token: 0x040004D2 RID: 1234
			[Token(Token = "0x40004D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public ushort[] busLinkIndexes;

			// Token: 0x040004D3 RID: 1235
			[Token(Token = "0x40004D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public ushort busNo;

			// Token: 0x040004D4 RID: 1236
			[Token(Token = "0x40004D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
			public byte numFxes;

			// Token: 0x040004D5 RID: 1237
			[Token(Token = "0x40004D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x33")]
			public byte numBusLinks;

			// Token: 0x040004D6 RID: 1238
			[Token(Token = "0x40004D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public CriAtom.SpeakerMapping speakerMapping;

			// Token: 0x040004D7 RID: 1239
			[Token(Token = "0x40004D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public CriAtomExAcf.DspBusOutputType outputType;

			// Token: 0x040004D8 RID: 1240
			[Token(Token = "0x40004D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public byte outputOptions;
		}

		// Token: 0x0200010B RID: 267
		[Token(Token = "0x200010B")]
		private struct AisacControlInfoForMarshaling
		{
			// Token: 0x06000805 RID: 2053 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000805")]
			[Address(RVA = "0x36DE2B0", Offset = "0x36DCEB0", VA = "0x1836DE2B0")]
			public void Convert(out CriAtomExAcfDebug.AisacControlInfo x)
			{
			}

			// Token: 0x040004D9 RID: 1241
			[Token(Token = "0x40004D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public IntPtr namePtr;

			// Token: 0x040004DA RID: 1242
			[Token(Token = "0x40004DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public uint id;
		}

		// Token: 0x0200010C RID: 268
		[Token(Token = "0x200010C")]
		private struct GlobalAisacInfoForMarshaling
		{
			// Token: 0x06000806 RID: 2054 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000806")]
			[Address(RVA = "0x3707650", Offset = "0x3706250", VA = "0x183707650")]
			public void Convert(out CriAtomExAcfDebug.GlobalAisacInfo x)
			{
			}

			// Token: 0x040004DB RID: 1243
			[Token(Token = "0x40004DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public IntPtr namePtr;

			// Token: 0x040004DC RID: 1244
			[Token(Token = "0x40004DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public ushort index;

			// Token: 0x040004DD RID: 1245
			[Token(Token = "0x40004DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA")]
			public ushort numGraphs;

			// Token: 0x040004DE RID: 1246
			[Token(Token = "0x40004DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public uint type;

			// Token: 0x040004DF RID: 1247
			[Token(Token = "0x40004DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float randomRange;

			// Token: 0x040004E0 RID: 1248
			[Token(Token = "0x40004E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public ushort controlId;

			// Token: 0x040004E1 RID: 1249
			[Token(Token = "0x40004E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x16")]
			public ushort dummy;
		}

		// Token: 0x0200010D RID: 269
		[Token(Token = "0x200010D")]
		private struct SelectorInfoForMarshaling
		{
			// Token: 0x06000807 RID: 2055 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000807")]
			[Address(RVA = "0x3708880", Offset = "0x3707480", VA = "0x183708880")]
			public void Convert(out CriAtomExAcfDebug.SelectorInfo x)
			{
			}

			// Token: 0x040004E2 RID: 1250
			[Token(Token = "0x40004E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public IntPtr namePtr;

			// Token: 0x040004E3 RID: 1251
			[Token(Token = "0x40004E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public ushort index;

			// Token: 0x040004E4 RID: 1252
			[Token(Token = "0x40004E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA")]
			public ushort numLabels;

			// Token: 0x040004E5 RID: 1253
			[Token(Token = "0x40004E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public ushort globalLabelIndex;
		}

		// Token: 0x0200010E RID: 270
		[Token(Token = "0x200010E")]
		private struct SelectorLabelInfoForMarshaling
		{
			// Token: 0x06000808 RID: 2056 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000808")]
			[Address(RVA = "0x37088D0", Offset = "0x37074D0", VA = "0x1837088D0")]
			public void Convert(out CriAtomExAcfDebug.SelectorLabelInfo x)
			{
			}

			// Token: 0x040004E6 RID: 1254
			[Token(Token = "0x40004E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public IntPtr selectorNamePtr;

			// Token: 0x040004E7 RID: 1255
			[Token(Token = "0x40004E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public IntPtr labelNamePtr;
		}
	}
}
