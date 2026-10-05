using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Hypergryph.SDK
{
	// Token: 0x02000008 RID: 8
	[Token(Token = "0x2000008")]
	public class HGEventLogSDKPluginWindows : IEventLogSDK
	{
		// Token: 0x06000071 RID: 113
		[Token(Token = "0x6000071")]
		[Address(RVA = "0x4A04FC0", Offset = "0x4A03BC0", VA = "0x184A04FC0")]
		[PreserveSig]
		private static extern bool EventLogSetEnvironment(string env);

		// Token: 0x06000072 RID: 114
		[Token(Token = "0x6000072")]
		[Address(RVA = "0x4A04F00", Offset = "0x4A03B00", VA = "0x184A04F00")]
		[PreserveSig]
		private static extern bool EventLogInitInstance(string appId, string regionTag);

		// Token: 0x06000073 RID: 115
		[Token(Token = "0x6000073")]
		[Address(RVA = "0x4A05100", Offset = "0x4A03D00", VA = "0x184A05100")]
		[PreserveSig]
		private static extern bool EventLogSetGlobalProperties(string appId, string globalProperties);

		// Token: 0x06000074 RID: 116
		[Token(Token = "0x6000074")]
		[Address(RVA = "0x4A05370", Offset = "0x4A03F70", VA = "0x184A05370")]
		[PreserveSig]
		private static extern bool EventLogUnsetGlobalProperties(string appId, string propertyKeys);

		// Token: 0x06000075 RID: 117
		[Token(Token = "0x6000075")]
		[Address(RVA = "0x4A04790", Offset = "0x4A03390", VA = "0x184A04790")]
		[PreserveSig]
		private static extern bool EventLogClearGlobalProperties(string appId);

		// Token: 0x06000076 RID: 118
		[Token(Token = "0x6000076")]
		[Address(RVA = "0x4A04970", Offset = "0x4A03570", VA = "0x184A04970")]
		[PreserveSig]
		private static extern bool EventLogEvent(string appId, string name, string properties);

		// Token: 0x06000077 RID: 119
		[Token(Token = "0x6000077")]
		[Address(RVA = "0x4A04200", Offset = "0x4A02E00", VA = "0x184A04200")]
		[PreserveSig]
		private static extern bool EventLogAppStartEvent(string appId, string channel1, string channel2, bool beat, string properties);

		// Token: 0x06000078 RID: 120
		[Token(Token = "0x6000078")]
		[Address(RVA = "0x4A04380", Offset = "0x4A02F80", VA = "0x184A04380")]
		[PreserveSig]
		private static extern bool EventLogBeatPause(string appId);

		// Token: 0x06000079 RID: 121
		[Token(Token = "0x6000079")]
		[Address(RVA = "0x4A04490", Offset = "0x4A03090", VA = "0x184A04490")]
		[PreserveSig]
		private static extern bool EventLogBeatResume(string appId);

		// Token: 0x0600007A RID: 122
		[Token(Token = "0x600007A")]
		[Address(RVA = "0x4A05600", Offset = "0x4A04200", VA = "0x184A05600")]
		[PreserveSig]
		private static extern bool EventLogUserLoginEvent(string appId, string userId, string properties);

		// Token: 0x0600007B RID: 123
		[Token(Token = "0x600007B")]
		[Address(RVA = "0x4A054A0", Offset = "0x4A040A0", VA = "0x184A054A0")]
		[PreserveSig]
		private static extern bool EventLogUnsetUser(string appId);

		// Token: 0x0600007C RID: 124
		[Token(Token = "0x600007C")]
		[Address(RVA = "0x4A04610", Offset = "0x4A03210", VA = "0x184A04610")]
		[PreserveSig]
		private static extern bool EventLogCharacterLoginEvent(string appId, string characterId, string serverId, string properties);

		// Token: 0x0600007D RID: 125
		[Token(Token = "0x600007D")]
		[Address(RVA = "0x4A05230", Offset = "0x4A03E30", VA = "0x184A05230")]
		[PreserveSig]
		private static extern bool EventLogUnsetCharacter(string appId);

		// Token: 0x0600007E RID: 126
		[Token(Token = "0x600007E")]
		[Address(RVA = "0x4A04D50", Offset = "0x4A03950", VA = "0x184A04D50")]
		[PreserveSig]
		private static extern IntPtr EventLogGetPresetProperties(string appId);

		// Token: 0x0600007F RID: 127
		[Token(Token = "0x600007F")]
		[Address(RVA = "0x4A04E60", Offset = "0x4A03A60", VA = "0x184A04E60")]
		[PreserveSig]
		private static extern IntPtr EventLogGetStaticPresetProperties(string appId);

		// Token: 0x06000080 RID: 128
		[Token(Token = "0x6000080")]
		[Address(RVA = "0x4A04C40", Offset = "0x4A03840", VA = "0x184A04C40")]
		[PreserveSig]
		private static extern IntPtr EventLogGetDeviceIdProperties(string appId);

		// Token: 0x06000081 RID: 129
		[Token(Token = "0x6000081")]
		[Address(RVA = "0x4A04830", Offset = "0x4A03430", VA = "0x184A04830")]
		[PreserveSig]
		private static extern bool EventLogEnableRealTimeSend(bool enable);

		// Token: 0x06000082 RID: 130
		[Token(Token = "0x6000082")]
		[Address(RVA = "0x4A04AC0", Offset = "0x4A036C0", VA = "0x184A04AC0")]
		[PreserveSig]
		private static extern void EventLogFlush(string appId);

		// Token: 0x06000083 RID: 131
		[Token(Token = "0x6000083")]
		[Address(RVA = "0x4A04B50", Offset = "0x4A03750", VA = "0x184A04B50")]
		[PreserveSig]
		private static extern bool EventLogFree(IntPtr buf);

		// Token: 0x06000084 RID: 132
		[Token(Token = "0x6000084")]
		[Address(RVA = "0x4A052D0", Offset = "0x4A03ED0", VA = "0x184A052D0")]
		[PreserveSig]
		private static extern bool EventLogUnsetGlobalPropertiesV2(string property_keys);

		// Token: 0x06000085 RID: 133
		[Token(Token = "0x6000085")]
		[Address(RVA = "0x4A05060", Offset = "0x4A03C60", VA = "0x184A05060")]
		[PreserveSig]
		private static extern bool EventLogSetGlobalPropertiesV2(string global_properties);

		// Token: 0x06000086 RID: 134
		[Token(Token = "0x6000086")]
		[Address(RVA = "0x4A04720", Offset = "0x4A03320", VA = "0x184A04720")]
		[PreserveSig]
		private static extern void EventLogClearGlobalPropertiesV2();

		// Token: 0x06000087 RID: 135
		[Token(Token = "0x6000087")]
		[Address(RVA = "0x4A048B0", Offset = "0x4A034B0", VA = "0x184A048B0")]
		[PreserveSig]
		private static extern bool EventLogEventV2(string name, string json_str);

		// Token: 0x06000088 RID: 136
		[Token(Token = "0x6000088")]
		[Address(RVA = "0x4A04110", Offset = "0x4A02D10", VA = "0x184A04110")]
		[PreserveSig]
		private static extern bool EventLogAppStartEventV2(string channel1, string channel2, bool beat, string json_str);

		// Token: 0x06000089 RID: 137
		[Token(Token = "0x6000089")]
		[Address(RVA = "0x4A04310", Offset = "0x4A02F10", VA = "0x184A04310")]
		[PreserveSig]
		private static extern void EventLogBeatPauseV2();

		// Token: 0x0600008A RID: 138
		[Token(Token = "0x600008A")]
		[Address(RVA = "0x4A04420", Offset = "0x4A03020", VA = "0x184A04420")]
		[PreserveSig]
		private static extern void EventLogBeatResumeV2();

		// Token: 0x0600008B RID: 139
		[Token(Token = "0x600008B")]
		[Address(RVA = "0x4A05540", Offset = "0x4A04140", VA = "0x184A05540")]
		[PreserveSig]
		private static extern bool EventLogUserLoginEventV2(string user_id, string json_str);

		// Token: 0x0600008C RID: 140
		[Token(Token = "0x600008C")]
		[Address(RVA = "0x4A05430", Offset = "0x4A04030", VA = "0x184A05430")]
		[PreserveSig]
		private static extern void EventLogUnsetUserV2();

		// Token: 0x0600008D RID: 141
		[Token(Token = "0x600008D")]
		[Address(RVA = "0x4A04530", Offset = "0x4A03130", VA = "0x184A04530")]
		[PreserveSig]
		private static extern bool EventLogCharacterLoginEventV2(string character_id, string server_id, string json_str);

		// Token: 0x0600008E RID: 142
		[Token(Token = "0x600008E")]
		[Address(RVA = "0x4A051C0", Offset = "0x4A03DC0", VA = "0x184A051C0")]
		[PreserveSig]
		private static extern void EventLogUnsetCharacterV2();

		// Token: 0x0600008F RID: 143
		[Token(Token = "0x600008F")]
		[Address(RVA = "0x4A04CE0", Offset = "0x4A038E0", VA = "0x184A04CE0")]
		[PreserveSig]
		private static extern IntPtr EventLogGetPresetPropertiesV2();

		// Token: 0x06000090 RID: 144
		[Token(Token = "0x6000090")]
		[Address(RVA = "0x4A04DF0", Offset = "0x4A039F0", VA = "0x184A04DF0")]
		[PreserveSig]
		private static extern IntPtr EventLogGetStaticPresetPropertiesV2();

		// Token: 0x06000091 RID: 145
		[Token(Token = "0x6000091")]
		[Address(RVA = "0x4A04BD0", Offset = "0x4A037D0", VA = "0x184A04BD0")]
		[PreserveSig]
		private static extern IntPtr EventLogGetDeviceIdPropertiesV2();

		// Token: 0x06000092 RID: 146
		[Token(Token = "0x6000092")]
		[Address(RVA = "0x4A04A50", Offset = "0x4A03650", VA = "0x184A04A50")]
		[PreserveSig]
		private static extern void EventLogFlushV2();

		// Token: 0x06000093 RID: 147 RVA: 0x0000209A File Offset: 0x0000029A
		[Token(Token = "0x6000093")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public HGEventLogSDKPluginWindows()
		{
		}

		// Token: 0x06000094 RID: 148 RVA: 0x0000239C File Offset: 0x0000059C
		[Token(Token = "0x6000094")]
		[Address(RVA = "0x4A06930", Offset = "0x4A05530", VA = "0x184A06930", Slot = "4")]
		public bool setEnvironment(string env)
		{
			return default(bool);
		}

		// Token: 0x06000095 RID: 149 RVA: 0x000023B4 File Offset: 0x000005B4
		[Token(Token = "0x6000095")]
		[Address(RVA = "0x4A06670", Offset = "0x4A05270", VA = "0x184A06670", Slot = "6")]
		public bool init(string appId, string regionTag)
		{
			return default(bool);
		}

		// Token: 0x06000096 RID: 150 RVA: 0x000023CC File Offset: 0x000005CC
		[Token(Token = "0x6000096")]
		[Address(RVA = "0x4A06A90", Offset = "0x4A05690", VA = "0x184A06A90", Slot = "7")]
		public bool setGlobalProperties(string appId, string globalProperties)
		{
			return default(bool);
		}

		// Token: 0x06000097 RID: 151 RVA: 0x000023E4 File Offset: 0x000005E4
		[Token(Token = "0x6000097")]
		[Address(RVA = "0x4A06D00", Offset = "0x4A05900", VA = "0x184A06D00", Slot = "8")]
		public bool unsetGlobalProperties(string appId, string propertyKeys)
		{
			return default(bool);
		}

		// Token: 0x06000098 RID: 152 RVA: 0x0000209A File Offset: 0x0000029A
		[Token(Token = "0x6000098")]
		[Address(RVA = "0x4A05B70", Offset = "0x4A04770", VA = "0x184A05B70", Slot = "9")]
		public void clearGlobalProperties(string appId)
		{
		}

		// Token: 0x06000099 RID: 153 RVA: 0x000023FC File Offset: 0x000005FC
		[Token(Token = "0x6000099")]
		[Address(RVA = "0x4A05D60", Offset = "0x4A04960", VA = "0x184A05D60", Slot = "10")]
		public bool eventTrack(string appId, string name, string properties)
		{
			return default(bool);
		}

		// Token: 0x0600009A RID: 154 RVA: 0x00002414 File Offset: 0x00000614
		[Token(Token = "0x600009A")]
		[Address(RVA = "0x4A057E0", Offset = "0x4A043E0", VA = "0x184A057E0", Slot = "11")]
		public bool appStartEvent(string appId, string channel1, string channel2, bool beat, string properties)
		{
			return default(bool);
		}

		// Token: 0x0600009B RID: 155 RVA: 0x0000209A File Offset: 0x0000029A
		[Token(Token = "0x600009B")]
		[Address(RVA = "0x4A067A0", Offset = "0x4A053A0", VA = "0x184A067A0", Slot = "12")]
		public void pauseBeat(string appId)
		{
		}

		// Token: 0x0600009C RID: 156 RVA: 0x0000209A File Offset: 0x0000029A
		[Token(Token = "0x600009C")]
		[Address(RVA = "0x4A068A0", Offset = "0x4A054A0", VA = "0x184A068A0", Slot = "13")]
		public void resumeBeat(string appId)
		{
		}

		// Token: 0x0600009D RID: 157 RVA: 0x0000242C File Offset: 0x0000062C
		[Token(Token = "0x600009D")]
		[Address(RVA = "0x4A06F80", Offset = "0x4A05B80", VA = "0x184A06F80", Slot = "14")]
		public bool userLoginEvent(string appId, string userId, string properties)
		{
			return default(bool);
		}

		// Token: 0x0600009E RID: 158 RVA: 0x0000209A File Offset: 0x0000029A
		[Token(Token = "0x600009E")]
		[Address(RVA = "0x4A06E30", Offset = "0x4A05A30", VA = "0x184A06E30", Slot = "15")]
		public void unsetUser(string appId)
		{
		}

		// Token: 0x0600009F RID: 159 RVA: 0x00002444 File Offset: 0x00000644
		[Token(Token = "0x600009F")]
		[Address(RVA = "0x4A059F0", Offset = "0x4A045F0", VA = "0x184A059F0", Slot = "16")]
		public bool characterLoginEvent(string appId, string characterId, string serverId, string properties)
		{
			return default(bool);
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x0000209A File Offset: 0x0000029A
		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x4A06BC0", Offset = "0x4A057C0", VA = "0x184A06BC0", Slot = "17")]
		public void unsetCharacter(string appId)
		{
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x4A062D0", Offset = "0x4A04ED0", VA = "0x184A062D0", Slot = "18")]
		public string getPresetProperties(string appId)
		{
			return null;
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x4A06530", Offset = "0x4A05130", VA = "0x184A06530", Slot = "20")]
		public string getStaticPresetProperties(string appId)
		{
			return null;
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x4A06070", Offset = "0x4A04C70", VA = "0x184A06070", Slot = "21")]
		public string getDeviceIdProperties(string appId)
		{
			return null;
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x0000209A File Offset: 0x0000029A
		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x4A05EC0", Offset = "0x4A04AC0", VA = "0x184A05EC0", Slot = "19")]
		public void flush(string appId)
		{
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x0000245C File Offset: 0x0000065C
		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x4A05C00", Offset = "0x4A04800", VA = "0x184A05C00", Slot = "5")]
		public bool enableRealTimeSend(bool enable)
		{
			return default(bool);
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x00002474 File Offset: 0x00000674
		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x4A069E0", Offset = "0x4A055E0", VA = "0x184A069E0", Slot = "22")]
		public bool setGlobalPropertiesV2(string globalProperties)
		{
			return default(bool);
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x0000248C File Offset: 0x0000068C
		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x4A06C50", Offset = "0x4A05850", VA = "0x184A06C50", Slot = "23")]
		public bool unsetGlobalPropertiesV2(string propertyKeys)
		{
			return default(bool);
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x0000209A File Offset: 0x0000029A
		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x4A05B00", Offset = "0x4A04700", VA = "0x184A05B00", Slot = "24")]
		public void clearGlobalPropertiesV2()
		{
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x000024A4 File Offset: 0x000006A4
		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x4A05C80", Offset = "0x4A04880", VA = "0x184A05C80", Slot = "25")]
		public bool eventTrackV2(string name, string properties)
		{
			return default(bool);
		}

		// Token: 0x060000AA RID: 170 RVA: 0x000024BC File Offset: 0x000006BC
		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x4A056E0", Offset = "0x4A042E0", VA = "0x184A056E0", Slot = "26")]
		public bool appStartEventV2(string channel1, string channel2, bool beat, string properties)
		{
			return default(bool);
		}

		// Token: 0x060000AB RID: 171 RVA: 0x0000209A File Offset: 0x0000029A
		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x4A06730", Offset = "0x4A05330", VA = "0x184A06730", Slot = "27")]
		public void pauseBeatV2()
		{
		}

		// Token: 0x060000AC RID: 172 RVA: 0x0000209A File Offset: 0x0000029A
		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x4A06830", Offset = "0x4A05430", VA = "0x184A06830", Slot = "28")]
		public void resumeBeatV2()
		{
		}

		// Token: 0x060000AD RID: 173 RVA: 0x000024D4 File Offset: 0x000006D4
		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x4A06EC0", Offset = "0x4A05AC0", VA = "0x184A06EC0", Slot = "29")]
		public bool userLoginEventV2(string userId, string properties)
		{
			return default(bool);
		}

		// Token: 0x060000AE RID: 174 RVA: 0x0000209A File Offset: 0x0000029A
		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x4A06DC0", Offset = "0x4A059C0", VA = "0x184A06DC0", Slot = "30")]
		public void unsetUserV2()
		{
		}

		// Token: 0x060000AF RID: 175 RVA: 0x000024EC File Offset: 0x000006EC
		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x4A05900", Offset = "0x4A04500", VA = "0x184A05900", Slot = "31")]
		public bool characterLoginEventV2(string characterId, string serverId, string properties)
		{
			return default(bool);
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x0000209A File Offset: 0x0000029A
		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x4A06B50", Offset = "0x4A05750", VA = "0x184A06B50", Slot = "32")]
		public void unsetCharacterV2()
		{
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x4A061B0", Offset = "0x4A04DB0", VA = "0x184A061B0", Slot = "33")]
		public string getPresetPropertiesV2()
		{
			return null;
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x0000209A File Offset: 0x0000029A
		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x4A05E50", Offset = "0x4A04A50", VA = "0x184A05E50", Slot = "34")]
		public void flushV2()
		{
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x4A06410", Offset = "0x4A05010", VA = "0x184A06410", Slot = "35")]
		public string getStaticPresetPropertiesV2()
		{
			return null;
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x4A05F50", Offset = "0x4A04B50", VA = "0x184A05F50", Slot = "36")]
		public string getDeviceIdPropertiesV2()
		{
			return null;
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x00002504 File Offset: 0x00000704
		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x4A05D40", Offset = "0x4A04940", VA = "0x184A05D40", Slot = "37")]
		public bool eventTrackV3(string appId, string name, string properties)
		{
			return default(bool);
		}
	}
}
