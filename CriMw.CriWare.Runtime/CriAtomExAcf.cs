using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace CriWare
{
	// Token: 0x0200006B RID: 107
	[Token(Token = "0x200006B")]
	public class CriAtomExAcf
	{
		// Token: 0x06000378 RID: 888 RVA: 0x00002E94 File Offset: 0x00001094
		[Token(Token = "0x6000378")]
		[Address(RVA = "0x36BF120", Offset = "0x36BDD20", VA = "0x1836BF120")]
		public static int GetNumAisacControls()
		{
			return 0;
		}

		// Token: 0x06000379 RID: 889 RVA: 0x00002EAC File Offset: 0x000010AC
		[Token(Token = "0x6000379")]
		[Address(RVA = "0x36BD640", Offset = "0x36BC240", VA = "0x1836BD640")]
		public static bool GetAisacControlInfo(ushort index, out CriAtomEx.AisacControlInfo info)
		{
			return default(bool);
		}

		// Token: 0x0600037A RID: 890 RVA: 0x00002EC4 File Offset: 0x000010C4
		[Token(Token = "0x600037A")]
		[Address(RVA = "0x36BF370", Offset = "0x36BDF70", VA = "0x1836BF370")]
		public static int GetNumDspSettings()
		{
			return 0;
		}

		// Token: 0x0600037B RID: 891 RVA: 0x00002EDC File Offset: 0x000010DC
		[Token(Token = "0x600037B")]
		[Address(RVA = "0x36BF2E0", Offset = "0x36BDEE0", VA = "0x1836BF2E0")]
		public static int GetNumDspSettings(IntPtr acfData, int size)
		{
			return 0;
		}

		// Token: 0x0600037C RID: 892 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x600037C")]
		[Address(RVA = "0x36BE3E0", Offset = "0x36BCFE0", VA = "0x1836BE3E0")]
		public static string GetDspSettingNameByIndex(ushort index)
		{
			return null;
		}

		// Token: 0x0600037D RID: 893 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x600037D")]
		[Address(RVA = "0x36BE4D0", Offset = "0x36BD0D0", VA = "0x1836BE4D0")]
		public static string GetDspSettingNameByIndex(IntPtr acfData, int size, ushort index)
		{
			return null;
		}

		// Token: 0x0600037E RID: 894 RVA: 0x00002EF4 File Offset: 0x000010F4
		[Token(Token = "0x600037E")]
		[Address(RVA = "0x36BE1A0", Offset = "0x36BCDA0", VA = "0x1836BE1A0")]
		public static bool GetDspSettingInformation(string name, out CriAtomExAcf.AcfDspSettingInfo info)
		{
			return default(bool);
		}

		// Token: 0x0600037F RID: 895 RVA: 0x00002F0C File Offset: 0x0000110C
		[Token(Token = "0x600037F")]
		[Address(RVA = "0x36BE5F0", Offset = "0x36BD1F0", VA = "0x1836BE5F0")]
		public static bool GetDspSettingSnapshotInformation(ushort index, out CriAtomExAcf.AcfDspSettingSnapshotInfo info)
		{
			return default(bool);
		}

		// Token: 0x06000380 RID: 896 RVA: 0x00002F24 File Offset: 0x00001124
		[Token(Token = "0x6000380")]
		[Address(RVA = "0x36BDE80", Offset = "0x36BCA80", VA = "0x1836BDE80")]
		public static bool GetDspBusInformation(ushort index, out CriAtomExAcf.AcfDspBusInfo info)
		{
			return default(bool);
		}

		// Token: 0x06000381 RID: 897 RVA: 0x00002F3C File Offset: 0x0000113C
		[Token(Token = "0x6000381")]
		[Address(RVA = "0x36BDFA0", Offset = "0x36BCBA0", VA = "0x1836BDFA0")]
		public static bool GetDspBusLinkInformation(ushort index, out CriAtomExAcf.AcfDspBusLinkInfo info)
		{
			return default(bool);
		}

		// Token: 0x06000382 RID: 898 RVA: 0x00002F54 File Offset: 0x00001154
		[Token(Token = "0x6000382")]
		[Address(RVA = "0x36BF270", Offset = "0x36BDE70", VA = "0x1836BF270")]
		public static int GetNumCategories()
		{
			return 0;
		}

		// Token: 0x06000383 RID: 899 RVA: 0x00002F6C File Offset: 0x0000116C
		[Token(Token = "0x6000383")]
		[Address(RVA = "0x36BF200", Offset = "0x36BDE00", VA = "0x1836BF200")]
		public static int GetNumCategoriesPerPlayback()
		{
			return 0;
		}

		// Token: 0x06000384 RID: 900 RVA: 0x00002F84 File Offset: 0x00001184
		[Token(Token = "0x6000384")]
		[Address(RVA = "0x36BDA40", Offset = "0x36BC640", VA = "0x1836BDA40")]
		public static bool GetCategoryInfoByIndex(ushort index, out CriAtomExAcf.CategoryInfo info)
		{
			return default(bool);
		}

		// Token: 0x06000385 RID: 901 RVA: 0x00002F9C File Offset: 0x0000119C
		[Token(Token = "0x6000385")]
		[Address(RVA = "0x36BDC50", Offset = "0x36BC850", VA = "0x1836BDC50")]
		public static bool GetCategoryInfoByName(string name, out CriAtomExAcf.CategoryInfo info)
		{
			return default(bool);
		}

		// Token: 0x06000386 RID: 902 RVA: 0x00002FB4 File Offset: 0x000011B4
		[Token(Token = "0x6000386")]
		[Address(RVA = "0x36BD830", Offset = "0x36BC430", VA = "0x1836BD830")]
		public static bool GetCategoryInfoById(uint id, out CriAtomExAcf.CategoryInfo info)
		{
			return default(bool);
		}

		// Token: 0x06000387 RID: 903 RVA: 0x00002FCC File Offset: 0x000011CC
		[Token(Token = "0x6000387")]
		[Address(RVA = "0x36BF3E0", Offset = "0x36BDFE0", VA = "0x1836BF3E0")]
		public static int GetNumGlobalAisacs()
		{
			return 0;
		}

		// Token: 0x06000388 RID: 904 RVA: 0x00002FE4 File Offset: 0x000011E4
		[Token(Token = "0x6000388")]
		[Address(RVA = "0x36BEAE0", Offset = "0x36BD6E0", VA = "0x1836BEAE0")]
		public static bool GetGlobalAisacInfoByIndex(ushort index, out CriAtomExAcf.GlobalAisacInfo info)
		{
			return default(bool);
		}

		// Token: 0x06000389 RID: 905 RVA: 0x00002FFC File Offset: 0x000011FC
		[Token(Token = "0x6000389")]
		[Address(RVA = "0x36BECF0", Offset = "0x36BD8F0", VA = "0x1836BECF0")]
		public static bool GetGlobalAisacInfoByName(string name, out CriAtomExAcf.GlobalAisacInfo info)
		{
			return default(bool);
		}

		// Token: 0x0600038A RID: 906 RVA: 0x00003014 File Offset: 0x00001214
		[Token(Token = "0x600038A")]
		[Address(RVA = "0x36BE810", Offset = "0x36BD410", VA = "0x1836BE810")]
		public static bool GetGlobalAisacGraphInfo(CriAtomExAcf.GlobalAisacInfo aisacInfo, ushort graphIndex, out CriAtomExAcf.AisacGraphInfo graphInfo)
		{
			return default(bool);
		}

		// Token: 0x0600038B RID: 907 RVA: 0x0000302C File Offset: 0x0000122C
		[Token(Token = "0x600038B")]
		[Address(RVA = "0x36BEF20", Offset = "0x36BDB20", VA = "0x1836BEF20")]
		public static bool GetGlobalAisacValue(CriAtomExAcf.GlobalAisacInfo aisacInfo, float control, CriAtomExAcf.AisacGraphType type, out float value)
		{
			return default(bool);
		}

		// Token: 0x0600038C RID: 908 RVA: 0x00003044 File Offset: 0x00001244
		[Token(Token = "0x600038C")]
		[Address(RVA = "0x36BD410", Offset = "0x36BC010", VA = "0x1836BD410")]
		public static bool GetAcfInfo(out CriAtomExAcf.AcfInfo acfInfo)
		{
			return default(bool);
		}

		// Token: 0x0600038D RID: 909 RVA: 0x0000305C File Offset: 0x0000125C
		[Token(Token = "0x600038D")]
		[Address(RVA = "0x36BF450", Offset = "0x36BE050", VA = "0x1836BF450")]
		public static int GetNumSelectors()
		{
			return 0;
		}

		// Token: 0x0600038E RID: 910 RVA: 0x00003074 File Offset: 0x00001274
		[Token(Token = "0x600038E")]
		[Address(RVA = "0x36BF5A0", Offset = "0x36BE1A0", VA = "0x1836BF5A0")]
		public static bool GetSelectorInfoByIndex(ushort index, out CriAtomExAcf.SelectorInfo info)
		{
			return default(bool);
		}

		// Token: 0x0600038F RID: 911 RVA: 0x0000308C File Offset: 0x0000128C
		[Token(Token = "0x600038F")]
		[Address(RVA = "0x36BF790", Offset = "0x36BE390", VA = "0x1836BF790")]
		public static bool GetSelectorInfoByName(string name, out CriAtomExAcf.SelectorInfo info)
		{
			return default(bool);
		}

		// Token: 0x06000390 RID: 912 RVA: 0x000030A4 File Offset: 0x000012A4
		[Token(Token = "0x6000390")]
		[Address(RVA = "0x36BF9B0", Offset = "0x36BE5B0", VA = "0x1836BF9B0")]
		public static bool GetSelectorLabelInfo(CriAtomExAcf.SelectorInfo selectorInfo, ushort labelIndex, out CriAtomExAcf.SelectorLabelInfo info)
		{
			return default(bool);
		}

		// Token: 0x06000391 RID: 913 RVA: 0x000030BC File Offset: 0x000012BC
		[Token(Token = "0x6000391")]
		[Address(RVA = "0x36BF190", Offset = "0x36BDD90", VA = "0x1836BF190")]
		public static int GetNumBuses()
		{
			return 0;
		}

		// Token: 0x06000392 RID: 914 RVA: 0x000030D4 File Offset: 0x000012D4
		[Token(Token = "0x6000392")]
		[Address(RVA = "0x36BF0B0", Offset = "0x36BDCB0", VA = "0x1836BF0B0")]
		public static int GetMaxBusesOfDspBusSettings()
		{
			return 0;
		}

		// Token: 0x06000393 RID: 915 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x6000393")]
		[Address(RVA = "0x36BD350", Offset = "0x36BBF50", VA = "0x1836BD350")]
		public static string FindBusName(string busName)
		{
			return null;
		}

		// Token: 0x06000394 RID: 916 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x6000394")]
		[Address(RVA = "0x36BF4C0", Offset = "0x36BE0C0", VA = "0x1836BF4C0")]
		public static CriAtomExOutputPort GetOutputPort(string name)
		{
			return null;
		}

		// Token: 0x06000395 RID: 917
		[Token(Token = "0x6000395")]
		[Address(RVA = "0x36BF120", Offset = "0x36BDD20", VA = "0x1836BF120")]
		[PreserveSig]
		private static extern int criAtomExAcf_GetNumAisacControls();

		// Token: 0x06000396 RID: 918
		[Token(Token = "0x6000396")]
		[Address(RVA = "0x36BFE50", Offset = "0x36BEA50", VA = "0x1836BFE50")]
		[PreserveSig]
		private static extern bool criAtomExAcf_GetAisacControlInfo(ushort index, IntPtr info);

		// Token: 0x06000397 RID: 919
		[Token(Token = "0x6000397")]
		[Address(RVA = "0x36BFDB0", Offset = "0x36BE9B0", VA = "0x1836BFDB0")]
		[PreserveSig]
		private static extern uint criAtomExAcf_GetAisacControlIdByName(string name);

		// Token: 0x06000398 RID: 920
		[Token(Token = "0x6000398")]
		[Address(RVA = "0x36BFEE0", Offset = "0x36BEAE0", VA = "0x1836BFEE0")]
		[PreserveSig]
		private static extern string criAtomExAcf_GetAisacControlNameById(uint id);

		// Token: 0x06000399 RID: 921
		[Token(Token = "0x6000399")]
		[Address(RVA = "0x36BF370", Offset = "0x36BDF70", VA = "0x1836BF370")]
		[PreserveSig]
		private static extern int criAtomExAcf_GetNumDspSettings();

		// Token: 0x0600039A RID: 922
		[Token(Token = "0x600039A")]
		[Address(RVA = "0x36BF2E0", Offset = "0x36BDEE0", VA = "0x1836BF2E0")]
		[PreserveSig]
		private static extern int criAtomExAcf_GetNumDspSettingsFromAcfData(IntPtr acf_data, int acf_data_size);

		// Token: 0x0600039B RID: 923
		[Token(Token = "0x600039B")]
		[Address(RVA = "0x36C04F0", Offset = "0x36BF0F0", VA = "0x1836C04F0")]
		[PreserveSig]
		private static extern IntPtr criAtomExAcf_GetDspSettingNameByIndex(ushort index);

		// Token: 0x0600039C RID: 924
		[Token(Token = "0x600039C")]
		[Address(RVA = "0x36C0450", Offset = "0x36BF050", VA = "0x1836C0450")]
		[PreserveSig]
		private static extern IntPtr criAtomExAcf_GetDspSettingNameByIndexFromAcfData(IntPtr acf_data, int acf_data_size, ushort index);

		// Token: 0x0600039D RID: 925
		[Token(Token = "0x600039D")]
		[Address(RVA = "0x36C03A0", Offset = "0x36BEFA0", VA = "0x1836C03A0")]
		[PreserveSig]
		private static extern bool criAtomExAcf_GetDspSettingInformation(string name, IntPtr info);

		// Token: 0x0600039E RID: 926
		[Token(Token = "0x600039E")]
		[Address(RVA = "0x36C0570", Offset = "0x36BF170", VA = "0x1836C0570")]
		[PreserveSig]
		private static extern bool criAtomExAcf_GetDspSettingSnapshotInformation(ushort index, IntPtr info);

		// Token: 0x0600039F RID: 927
		[Token(Token = "0x600039F")]
		[Address(RVA = "0x36BDE80", Offset = "0x36BCA80", VA = "0x1836BDE80")]
		[PreserveSig]
		private static extern bool criAtomExAcf_GetDspBusInformation(ushort index, out CriAtomExAcf.AcfDspBusInfo info);

		// Token: 0x060003A0 RID: 928
		[Token(Token = "0x60003A0")]
		[Address(RVA = "0x36C0320", Offset = "0x36BEF20", VA = "0x1836C0320")]
		[PreserveSig]
		private static extern int criAtomExAcf_GetDspFxType(ushort index);

		// Token: 0x060003A1 RID: 929
		[Token(Token = "0x60003A1")]
		[Address(RVA = "0x36C01E0", Offset = "0x36BEDE0", VA = "0x1836C01E0")]
		[PreserveSig]
		private static extern string criAtomExAcf_GetDspFxName(ushort index);

		// Token: 0x060003A2 RID: 930
		[Token(Token = "0x60003A2")]
		[Address(RVA = "0x36C0280", Offset = "0x36BEE80", VA = "0x1836C0280")]
		[PreserveSig]
		private static extern bool criAtomExAcf_GetDspFxParameters(ushort index, IntPtr parameters, int size);

		// Token: 0x060003A3 RID: 931
		[Token(Token = "0x60003A3")]
		[Address(RVA = "0x36C0150", Offset = "0x36BED50", VA = "0x1836C0150")]
		[PreserveSig]
		private static extern bool criAtomExAcf_GetDspBusLinkInformation(ushort index, IntPtr info);

		// Token: 0x060003A4 RID: 932
		[Token(Token = "0x60003A4")]
		[Address(RVA = "0x36C09B0", Offset = "0x36BF5B0", VA = "0x1836C09B0")]
		[PreserveSig]
		private static extern int criAtomExAcf_GetNumCategoriesFromAcfData(IntPtr acf_data, int acf_data_size);

		// Token: 0x060003A5 RID: 933
		[Token(Token = "0x60003A5")]
		[Address(RVA = "0x36BF270", Offset = "0x36BDE70", VA = "0x1836BF270")]
		[PreserveSig]
		private static extern int criAtomExAcf_GetNumCategories();

		// Token: 0x060003A6 RID: 934
		[Token(Token = "0x60003A6")]
		[Address(RVA = "0x36C0A40", Offset = "0x36BF640", VA = "0x1836C0A40")]
		[PreserveSig]
		private static extern int criAtomExAcf_GetNumCategoriesPerPlaybackFromAcfData(IntPtr acf_data, int acf_data_size);

		// Token: 0x060003A7 RID: 935
		[Token(Token = "0x60003A7")]
		[Address(RVA = "0x36BF200", Offset = "0x36BDE00", VA = "0x1836BF200")]
		[PreserveSig]
		private static extern int criAtomExAcf_GetNumCategoriesPerPlayback();

		// Token: 0x060003A8 RID: 936
		[Token(Token = "0x60003A8")]
		[Address(RVA = "0x36C00C0", Offset = "0x36BECC0", VA = "0x1836C00C0")]
		[PreserveSig]
		private static extern bool criAtomExAcf_GetCategoryInfo(ushort index, IntPtr info);

		// Token: 0x060003A9 RID: 937
		[Token(Token = "0x60003A9")]
		[Address(RVA = "0x36C0010", Offset = "0x36BEC10", VA = "0x1836C0010")]
		[PreserveSig]
		private static extern bool criAtomExAcf_GetCategoryInfoByName(string name, IntPtr info);

		// Token: 0x060003AA RID: 938
		[Token(Token = "0x60003AA")]
		[Address(RVA = "0x36BFF80", Offset = "0x36BEB80", VA = "0x1836BFF80")]
		[PreserveSig]
		private static extern bool criAtomExAcf_GetCategoryInfoById(uint id, IntPtr info);

		// Token: 0x060003AB RID: 939
		[Token(Token = "0x60003AB")]
		[Address(RVA = "0x36BF3E0", Offset = "0x36BDFE0", VA = "0x1836BF3E0")]
		[PreserveSig]
		private static extern int criAtomExAcf_GetNumGlobalAisacs();

		// Token: 0x060003AC RID: 940
		[Token(Token = "0x60003AC")]
		[Address(RVA = "0x36C0750", Offset = "0x36BF350", VA = "0x1836C0750")]
		[PreserveSig]
		private static extern bool criAtomExAcf_GetGlobalAisacInfo(ushort index, IntPtr info);

		// Token: 0x060003AD RID: 941
		[Token(Token = "0x60003AD")]
		[Address(RVA = "0x36C06A0", Offset = "0x36BF2A0", VA = "0x1836C06A0")]
		[PreserveSig]
		private static extern bool criAtomExAcf_GetGlobalAisacInfoByName(string name, IntPtr info);

		// Token: 0x060003AE RID: 942
		[Token(Token = "0x60003AE")]
		[Address(RVA = "0x36C0600", Offset = "0x36BF200", VA = "0x1836C0600")]
		[PreserveSig]
		private static extern bool criAtomExAcf_GetGlobalAisacGraphInfo(IntPtr aisac_info, ushort graph_index, IntPtr graph_info);

		// Token: 0x060003AF RID: 943
		[Token(Token = "0x60003AF")]
		[Address(RVA = "0x36C07E0", Offset = "0x36BF3E0", VA = "0x1836C07E0")]
		[PreserveSig]
		private static extern bool criAtomExAcf_GetGlobalAisacValue(IntPtr aisac_info, float control, CriAtomExAcf.AisacGraphType type, out float value);

		// Token: 0x060003B0 RID: 944
		[Token(Token = "0x60003B0")]
		[Address(RVA = "0x36BFD30", Offset = "0x36BE930", VA = "0x1836BFD30")]
		[PreserveSig]
		private static extern bool criAtomExAcf_GetAcfInfo(IntPtr acf_info);

		// Token: 0x060003B1 RID: 945
		[Token(Token = "0x60003B1")]
		[Address(RVA = "0x36BFC90", Offset = "0x36BE890", VA = "0x1836BFC90")]
		[PreserveSig]
		private static extern bool criAtomExAcf_GetAcfInfoFromAcfData(IntPtr acf_data, int acf_data_size, IntPtr acf_info);

		// Token: 0x060003B2 RID: 946
		[Token(Token = "0x60003B2")]
		[Address(RVA = "0x36BF450", Offset = "0x36BE050", VA = "0x1836BF450")]
		[PreserveSig]
		private static extern int criAtomExAcf_GetNumSelectors();

		// Token: 0x060003B3 RID: 947
		[Token(Token = "0x60003B3")]
		[Address(RVA = "0x36C0B70", Offset = "0x36BF770", VA = "0x1836C0B70")]
		[PreserveSig]
		private static extern bool criAtomExAcf_GetSelectorInfoByIndex(ushort index, IntPtr info);

		// Token: 0x060003B4 RID: 948
		[Token(Token = "0x60003B4")]
		[Address(RVA = "0x36C0C00", Offset = "0x36BF800", VA = "0x1836C0C00")]
		[PreserveSig]
		private static extern bool criAtomExAcf_GetSelectorInfoByName(string name, IntPtr info);

		// Token: 0x060003B5 RID: 949
		[Token(Token = "0x60003B5")]
		[Address(RVA = "0x36C0CB0", Offset = "0x36BF8B0", VA = "0x1836C0CB0")]
		[PreserveSig]
		private static extern bool criAtomExAcf_GetSelectorLabelInfo(IntPtr selector_info, ushort label_index, IntPtr info);

		// Token: 0x060003B6 RID: 950
		[Token(Token = "0x60003B6")]
		[Address(RVA = "0x36C0920", Offset = "0x36BF520", VA = "0x1836C0920")]
		[PreserveSig]
		private static extern int criAtomExAcf_GetNumBusesFromAcfData(IntPtr acf_data, int acf_data_size);

		// Token: 0x060003B7 RID: 951
		[Token(Token = "0x60003B7")]
		[Address(RVA = "0x36BF190", Offset = "0x36BDD90", VA = "0x1836BF190")]
		[PreserveSig]
		private static extern int criAtomExAcf_GetNumBuses();

		// Token: 0x060003B8 RID: 952
		[Token(Token = "0x60003B8")]
		[Address(RVA = "0x36C0890", Offset = "0x36BF490", VA = "0x1836C0890")]
		[PreserveSig]
		private static extern int criAtomExAcf_GetMaxBusesOfDspBusSettingsFromAcfData(IntPtr acf_data, int acf_data_size);

		// Token: 0x060003B9 RID: 953
		[Token(Token = "0x60003B9")]
		[Address(RVA = "0x36BF0B0", Offset = "0x36BDCB0", VA = "0x1836BF0B0")]
		[PreserveSig]
		private static extern int criAtomExAcf_GetMaxBusesOfDspBusSettings();

		// Token: 0x060003BA RID: 954
		[Token(Token = "0x60003BA")]
		[Address(RVA = "0x36BD350", Offset = "0x36BBF50", VA = "0x1836BD350")]
		[PreserveSig]
		private static extern string criAtomExAcf_FindBusName(string bus_name);

		// Token: 0x060003BB RID: 955
		[Token(Token = "0x60003BB")]
		[Address(RVA = "0x36C0AD0", Offset = "0x36BF6D0", VA = "0x1836C0AD0")]
		[PreserveSig]
		private static extern IntPtr criAtomExAcf_GetOutputPortHnByName(string name);

		// Token: 0x060003BC RID: 956 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003BC")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public CriAtomExAcf()
		{
		}

		// Token: 0x0200006C RID: 108
		[Token(Token = "0x200006C")]
		public struct AcfDspSettingInfo
		{
			// Token: 0x060003BD RID: 957 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60003BD")]
			[Address(RVA = "0x36B2400", Offset = "0x36B1000", VA = "0x1836B2400")]
			public AcfDspSettingInfo(byte[] data, int startIndex)
			{
			}

			// Token: 0x040001FF RID: 511
			[Token(Token = "0x40001FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public string name;

			// Token: 0x04000200 RID: 512
			[Token(Token = "0x4000200")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public ushort[] busIndexes;

			// Token: 0x04000201 RID: 513
			[Token(Token = "0x4000201")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ushort[] extendBusIndexes;

			// Token: 0x04000202 RID: 514
			[Token(Token = "0x4000202")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public ushort snapshotStartIndex;

			// Token: 0x04000203 RID: 515
			[Token(Token = "0x4000203")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
			public byte numBuses;

			// Token: 0x04000204 RID: 516
			[Token(Token = "0x4000204")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1B")]
			public byte numExtendBuses;

			// Token: 0x04000205 RID: 517
			[Token(Token = "0x4000205")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public ushort numSnapshots;

			// Token: 0x04000206 RID: 518
			[Token(Token = "0x4000206")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1E")]
			public ushort snapshotWorkSize;

			// Token: 0x04000207 RID: 519
			[Token(Token = "0x4000207")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ushort numMixerAisacs;

			// Token: 0x04000208 RID: 520
			[Token(Token = "0x4000208")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x22")]
			public ushort mixerAisacStartIndex;
		}

		// Token: 0x0200006D RID: 109
		[Token(Token = "0x200006D")]
		public struct AcfDspSettingSnapshotInfo
		{
			// Token: 0x060003BE RID: 958 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60003BE")]
			[Address(RVA = "0x36B28C0", Offset = "0x36B14C0", VA = "0x1836B28C0")]
			public AcfDspSettingSnapshotInfo(byte[] data, int startIndex)
			{
			}

			// Token: 0x04000209 RID: 521
			[Token(Token = "0x4000209")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public string name;

			// Token: 0x0400020A RID: 522
			[Token(Token = "0x400020A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public byte numBuses;

			// Token: 0x0400020B RID: 523
			[Token(Token = "0x400020B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9")]
			public byte numExtendBuses;

			// Token: 0x0400020C RID: 524
			[Token(Token = "0x400020C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public byte[] reserved;

			// Token: 0x0400020D RID: 525
			[Token(Token = "0x400020D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public ushort[] busIndexes;

			// Token: 0x0400020E RID: 526
			[Token(Token = "0x400020E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ushort[] extendBusIndexes;
		}

		// Token: 0x0200006E RID: 110
		[Token(Token = "0x200006E")]
		public struct AcfDspBusInfo
		{
			// Token: 0x1700004A RID: 74
			// (get) Token: 0x060003BF RID: 959 RVA: 0x000020AE File Offset: 0x000002AE
			[Token(Token = "0x1700004A")]
			public string name
			{
				[Token(Token = "0x60003BF")]
				[Address(RVA = "0x36B2240", Offset = "0x36B0E40", VA = "0x1836B2240")]
				get
				{
					return null;
				}
			}

			// Token: 0x0400020F RID: 527
			[Token(Token = "0x400020F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public IntPtr namePointer;

			// Token: 0x04000210 RID: 528
			[Token(Token = "0x4000210")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public float volume;

			// Token: 0x04000211 RID: 529
			[Token(Token = "0x4000211")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public float pan3dVolume;

			// Token: 0x04000212 RID: 530
			[Token(Token = "0x4000212")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float pan3dAngle;

			// Token: 0x04000213 RID: 531
			[Token(Token = "0x4000213")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float pan3dDistance;

			// Token: 0x04000214 RID: 532
			[Token(Token = "0x4000214")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float pan3dSpread;

			// Token: 0x04000215 RID: 533
			[Token(Token = "0x4000215")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float pan3dWideness;

			// Token: 0x04000216 RID: 534
			[Token(Token = "0x4000216")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ushort[] fxIndexes;

			// Token: 0x04000217 RID: 535
			[Token(Token = "0x4000217")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public ushort[] busLinkIndexes;

			// Token: 0x04000218 RID: 536
			[Token(Token = "0x4000218")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public ushort busNo;

			// Token: 0x04000219 RID: 537
			[Token(Token = "0x4000219")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
			public byte numFxes;

			// Token: 0x0400021A RID: 538
			[Token(Token = "0x400021A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x33")]
			public byte numBusLinks;

			// Token: 0x0400021B RID: 539
			[Token(Token = "0x400021B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public CriAtom.SpeakerMapping speakerMapping;

			// Token: 0x0400021C RID: 540
			[Token(Token = "0x400021C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public CriAtomExAcf.DspBusOutputType outputType;

			// Token: 0x0400021D RID: 541
			[Token(Token = "0x400021D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public byte outputOptions;
		}

		// Token: 0x0200006F RID: 111
		[Token(Token = "0x200006F")]
		public enum DspBusOutputType
		{
			// Token: 0x0400021F RID: 543
			[Token(Token = "0x400021F")]
			None,
			// Token: 0x04000220 RID: 544
			[Token(Token = "0x4000220")]
			Main,
			// Token: 0x04000221 RID: 545
			[Token(Token = "0x4000221")]
			MainPassthrough,
			// Token: 0x04000222 RID: 546
			[Token(Token = "0x4000222")]
			PadHaptic,
			// Token: 0x04000223 RID: 547
			[Token(Token = "0x4000223")]
			PadSpeaker,
			// Token: 0x04000224 RID: 548
			[Token(Token = "0x4000224")]
			Personal,
			// Token: 0x04000225 RID: 549
			[Token(Token = "0x4000225")]
			PersonalPassthrough
		}

		// Token: 0x02000070 RID: 112
		[Token(Token = "0x2000070")]
		public enum AcfDspBusLinkType : uint
		{
			// Token: 0x04000227 RID: 551
			[Token(Token = "0x4000227")]
			preVolume,
			// Token: 0x04000228 RID: 552
			[Token(Token = "0x4000228")]
			postVolume,
			// Token: 0x04000229 RID: 553
			[Token(Token = "0x4000229")]
			postPan
		}

		// Token: 0x02000071 RID: 113
		[Token(Token = "0x2000071")]
		public struct AcfDspBusLinkInfo
		{
			// Token: 0x060003C0 RID: 960 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60003C0")]
			[Address(RVA = "0x36B2290", Offset = "0x36B0E90", VA = "0x1836B2290")]
			public AcfDspBusLinkInfo(byte[] data, int startIndex)
			{
			}

			// Token: 0x0400022A RID: 554
			[Token(Token = "0x400022A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public CriAtomExAcf.AcfDspBusLinkType type;

			// Token: 0x0400022B RID: 555
			[Token(Token = "0x400022B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public float sendLevel;

			// Token: 0x0400022C RID: 556
			[Token(Token = "0x400022C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public ushort busNo;

			// Token: 0x0400022D RID: 557
			[Token(Token = "0x400022D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA")]
			public ushort busId;
		}

		// Token: 0x02000072 RID: 114
		[Token(Token = "0x2000072")]
		public struct CategoryInfo
		{
			// Token: 0x060003C1 RID: 961 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60003C1")]
			[Address(RVA = "0x36B3A90", Offset = "0x36B2690", VA = "0x1836B3A90")]
			public CategoryInfo(byte[] data, int startIndex)
			{
			}

			// Token: 0x0400022E RID: 558
			[Token(Token = "0x400022E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public uint groupNo;

			// Token: 0x0400022F RID: 559
			[Token(Token = "0x400022F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public uint id;

			// Token: 0x04000230 RID: 560
			[Token(Token = "0x4000230")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public string name;

			// Token: 0x04000231 RID: 561
			[Token(Token = "0x4000231")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public uint numCueLimits;

			// Token: 0x04000232 RID: 562
			[Token(Token = "0x4000232")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float volume;
		}

		// Token: 0x02000073 RID: 115
		[Token(Token = "0x2000073")]
		public enum AcfAisacType : uint
		{
			// Token: 0x04000234 RID: 564
			[Token(Token = "0x4000234")]
			normal,
			// Token: 0x04000235 RID: 565
			[Token(Token = "0x4000235")]
			autoModulation
		}

		// Token: 0x02000074 RID: 116
		[Token(Token = "0x2000074")]
		public struct GlobalAisacInfo
		{
			// Token: 0x060003C2 RID: 962 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60003C2")]
			[Address(RVA = "0x36DB470", Offset = "0x36DA070", VA = "0x1836DB470")]
			public GlobalAisacInfo(byte[] data, int startIndex)
			{
			}

			// Token: 0x04000236 RID: 566
			[Token(Token = "0x4000236")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public string name;

			// Token: 0x04000237 RID: 567
			[Token(Token = "0x4000237")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public ushort index;

			// Token: 0x04000238 RID: 568
			[Token(Token = "0x4000238")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA")]
			public ushort numGraphs;

			// Token: 0x04000239 RID: 569
			[Token(Token = "0x4000239")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public CriAtomExAcf.AcfAisacType type;

			// Token: 0x0400023A RID: 570
			[Token(Token = "0x400023A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float randomRange;

			// Token: 0x0400023B RID: 571
			[Token(Token = "0x400023B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public ushort controlId;

			// Token: 0x0400023C RID: 572
			[Token(Token = "0x400023C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x16")]
			public ushort dummy;
		}

		// Token: 0x02000075 RID: 117
		[Token(Token = "0x2000075")]
		public enum AisacGraphType
		{
			// Token: 0x0400023E RID: 574
			[Token(Token = "0x400023E")]
			none,
			// Token: 0x0400023F RID: 575
			[Token(Token = "0x400023F")]
			volume,
			// Token: 0x04000240 RID: 576
			[Token(Token = "0x4000240")]
			pitch,
			// Token: 0x04000241 RID: 577
			[Token(Token = "0x4000241")]
			bandpassHigh,
			// Token: 0x04000242 RID: 578
			[Token(Token = "0x4000242")]
			bandpassLow,
			// Token: 0x04000243 RID: 579
			[Token(Token = "0x4000243")]
			biquadFreq,
			// Token: 0x04000244 RID: 580
			[Token(Token = "0x4000244")]
			biquadQ,
			// Token: 0x04000245 RID: 581
			[Token(Token = "0x4000245")]
			busSend0,
			// Token: 0x04000246 RID: 582
			[Token(Token = "0x4000246")]
			busSend1,
			// Token: 0x04000247 RID: 583
			[Token(Token = "0x4000247")]
			busSend2,
			// Token: 0x04000248 RID: 584
			[Token(Token = "0x4000248")]
			busSend3,
			// Token: 0x04000249 RID: 585
			[Token(Token = "0x4000249")]
			busSend4,
			// Token: 0x0400024A RID: 586
			[Token(Token = "0x400024A")]
			busSend5,
			// Token: 0x0400024B RID: 587
			[Token(Token = "0x400024B")]
			busSend6,
			// Token: 0x0400024C RID: 588
			[Token(Token = "0x400024C")]
			busSend7,
			// Token: 0x0400024D RID: 589
			[Token(Token = "0x400024D")]
			pan3dAngel,
			// Token: 0x0400024E RID: 590
			[Token(Token = "0x400024E")]
			pan3dVolume,
			// Token: 0x0400024F RID: 591
			[Token(Token = "0x400024F")]
			pan3dInteriorDistance,
			// Token: 0x04000250 RID: 592
			[Token(Token = "0x4000250")]
			pan3dCenter,
			// Token: 0x04000251 RID: 593
			[Token(Token = "0x4000251")]
			pan3dLfe,
			// Token: 0x04000252 RID: 594
			[Token(Token = "0x4000252")]
			aisac0,
			// Token: 0x04000253 RID: 595
			[Token(Token = "0x4000253")]
			aisac1,
			// Token: 0x04000254 RID: 596
			[Token(Token = "0x4000254")]
			aisac2,
			// Token: 0x04000255 RID: 597
			[Token(Token = "0x4000255")]
			aisac3,
			// Token: 0x04000256 RID: 598
			[Token(Token = "0x4000256")]
			aisac4,
			// Token: 0x04000257 RID: 599
			[Token(Token = "0x4000257")]
			aisac5,
			// Token: 0x04000258 RID: 600
			[Token(Token = "0x4000258")]
			aisac6,
			// Token: 0x04000259 RID: 601
			[Token(Token = "0x4000259")]
			aisac7,
			// Token: 0x0400025A RID: 602
			[Token(Token = "0x400025A")]
			aisac8,
			// Token: 0x0400025B RID: 603
			[Token(Token = "0x400025B")]
			aisac9,
			// Token: 0x0400025C RID: 604
			[Token(Token = "0x400025C")]
			aisac10,
			// Token: 0x0400025D RID: 605
			[Token(Token = "0x400025D")]
			aisac11,
			// Token: 0x0400025E RID: 606
			[Token(Token = "0x400025E")]
			aisac12,
			// Token: 0x0400025F RID: 607
			[Token(Token = "0x400025F")]
			aisac13,
			// Token: 0x04000260 RID: 608
			[Token(Token = "0x4000260")]
			aisac14,
			// Token: 0x04000261 RID: 609
			[Token(Token = "0x4000261")]
			aisac15,
			// Token: 0x04000262 RID: 610
			[Token(Token = "0x4000262")]
			priority,
			// Token: 0x04000263 RID: 611
			[Token(Token = "0x4000263")]
			preDelayTime,
			// Token: 0x04000264 RID: 612
			[Token(Token = "0x4000264")]
			biquadGain,
			// Token: 0x04000265 RID: 613
			[Token(Token = "0x4000265")]
			pan3dMixdownCenter,
			// Token: 0x04000266 RID: 614
			[Token(Token = "0x4000266")]
			pan3dMixdownLfe,
			// Token: 0x04000267 RID: 615
			[Token(Token = "0x4000267")]
			egAttack,
			// Token: 0x04000268 RID: 616
			[Token(Token = "0x4000268")]
			egRelease,
			// Token: 0x04000269 RID: 617
			[Token(Token = "0x4000269")]
			playbackRatio,
			// Token: 0x0400026A RID: 618
			[Token(Token = "0x400026A")]
			drySendL,
			// Token: 0x0400026B RID: 619
			[Token(Token = "0x400026B")]
			drySendR,
			// Token: 0x0400026C RID: 620
			[Token(Token = "0x400026C")]
			drySendCenter,
			// Token: 0x0400026D RID: 621
			[Token(Token = "0x400026D")]
			drySendLfe,
			// Token: 0x0400026E RID: 622
			[Token(Token = "0x400026E")]
			drySendSl,
			// Token: 0x0400026F RID: 623
			[Token(Token = "0x400026F")]
			drySendSr,
			// Token: 0x04000270 RID: 624
			[Token(Token = "0x4000270")]
			drySendEx1,
			// Token: 0x04000271 RID: 625
			[Token(Token = "0x4000271")]
			drySendEx2,
			// Token: 0x04000272 RID: 626
			[Token(Token = "0x4000272")]
			panSpread
		}

		// Token: 0x02000076 RID: 118
		[Token(Token = "0x2000076")]
		public struct AisacGraphInfo
		{
			// Token: 0x060003C3 RID: 963 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60003C3")]
			[Address(RVA = "0x36B3310", Offset = "0x36B1F10", VA = "0x1836B3310")]
			public AisacGraphInfo(byte[] data, int startIndex)
			{
			}

			// Token: 0x04000273 RID: 627
			[Token(Token = "0x4000273")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public CriAtomExAcf.AisacGraphType type;
		}

		// Token: 0x02000077 RID: 119
		[Token(Token = "0x2000077")]
		public enum CharacterEncoding : uint
		{
			// Token: 0x04000275 RID: 629
			[Token(Token = "0x4000275")]
			utf8,
			// Token: 0x04000276 RID: 630
			[Token(Token = "0x4000276")]
			sjis
		}

		// Token: 0x02000078 RID: 120
		[Token(Token = "0x2000078")]
		public struct AcfInfo
		{
			// Token: 0x060003C4 RID: 964 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60003C4")]
			[Address(RVA = "0x36B2D60", Offset = "0x36B1960", VA = "0x1836B2D60")]
			public AcfInfo(byte[] data, int startIndex)
			{
			}

			// Token: 0x04000277 RID: 631
			[Token(Token = "0x4000277")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public string name;

			// Token: 0x04000278 RID: 632
			[Token(Token = "0x4000278")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public uint size;

			// Token: 0x04000279 RID: 633
			[Token(Token = "0x4000279")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public uint version;

			// Token: 0x0400027A RID: 634
			[Token(Token = "0x400027A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public CriAtomExAcf.CharacterEncoding characterEncoding;

			// Token: 0x0400027B RID: 635
			[Token(Token = "0x400027B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public int numDspSettings;

			// Token: 0x0400027C RID: 636
			[Token(Token = "0x400027C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int numCategories;

			// Token: 0x0400027D RID: 637
			[Token(Token = "0x400027D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public int numCategoriesPerPlayback;

			// Token: 0x0400027E RID: 638
			[Token(Token = "0x400027E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public int numReacts;

			// Token: 0x0400027F RID: 639
			[Token(Token = "0x400027F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public int numAisacControls;

			// Token: 0x04000280 RID: 640
			[Token(Token = "0x4000280")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public int numGlobalAisacs;

			// Token: 0x04000281 RID: 641
			[Token(Token = "0x4000281")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public int numGameVariables;

			// Token: 0x04000282 RID: 642
			[Token(Token = "0x4000282")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public int maxBusesOfDspBusSettings;

			// Token: 0x04000283 RID: 643
			[Token(Token = "0x4000283")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public int numBuses;

			// Token: 0x04000284 RID: 644
			[Token(Token = "0x4000284")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public int numVoiceLimitGroups;

			// Token: 0x04000285 RID: 645
			[Token(Token = "0x4000285")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public int numOutputPorts;
		}

		// Token: 0x02000079 RID: 121
		[Token(Token = "0x2000079")]
		public struct SelectorInfo
		{
			// Token: 0x060003C5 RID: 965 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60003C5")]
			[Address(RVA = "0x36DC0E0", Offset = "0x36DACE0", VA = "0x1836DC0E0")]
			public SelectorInfo(byte[] data, int startIndex)
			{
			}

			// Token: 0x04000286 RID: 646
			[Token(Token = "0x4000286")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public string name;

			// Token: 0x04000287 RID: 647
			[Token(Token = "0x4000287")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public ushort index;

			// Token: 0x04000288 RID: 648
			[Token(Token = "0x4000288")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA")]
			public ushort numLabels;

			// Token: 0x04000289 RID: 649
			[Token(Token = "0x4000289")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public ushort globalLabelIndex;
		}

		// Token: 0x0200007A RID: 122
		[Token(Token = "0x200007A")]
		public struct SelectorLabelInfo
		{
			// Token: 0x060003C6 RID: 966 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60003C6")]
			[Address(RVA = "0x36DC270", Offset = "0x36DAE70", VA = "0x1836DC270")]
			public SelectorLabelInfo(byte[] data, int startIndex)
			{
			}

			// Token: 0x0400028A RID: 650
			[Token(Token = "0x400028A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public string selectorName;

			// Token: 0x0400028B RID: 651
			[Token(Token = "0x400028B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public string labelName;
		}
	}
}
