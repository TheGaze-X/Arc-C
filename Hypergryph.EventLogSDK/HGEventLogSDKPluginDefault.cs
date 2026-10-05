using System;
using Il2CppDummyDll;

namespace Hypergryph.SDK
{
	// Token: 0x02000007 RID: 7
	[Token(Token = "0x2000007")]
	public class HGEventLogSDKPluginDefault : IEventLogSDK
	{
		// Token: 0x0600004E RID: 78 RVA: 0x0000209A File Offset: 0x0000029A
		[Token(Token = "0x600004E")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public HGEventLogSDKPluginDefault()
		{
		}

		// Token: 0x0600004F RID: 79 RVA: 0x0000221C File Offset: 0x0000041C
		[Token(Token = "0x600004F")]
		[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "4")]
		public bool setEnvironment(string env)
		{
			return default(bool);
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00002234 File Offset: 0x00000434
		[Token(Token = "0x6000050")]
		[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "6")]
		public bool init(string appId, string regionTag)
		{
			return default(bool);
		}

		// Token: 0x06000051 RID: 81 RVA: 0x0000224C File Offset: 0x0000044C
		[Token(Token = "0x6000051")]
		[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "7")]
		public bool setGlobalProperties(string appId, string globalProperties)
		{
			return default(bool);
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00002264 File Offset: 0x00000464
		[Token(Token = "0x6000052")]
		[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "8")]
		public bool unsetGlobalProperties(string appId, string propertyKeys)
		{
			return default(bool);
		}

		// Token: 0x06000053 RID: 83 RVA: 0x0000209A File Offset: 0x0000029A
		[Token(Token = "0x6000053")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "9")]
		public void clearGlobalProperties(string appId)
		{
		}

		// Token: 0x06000054 RID: 84 RVA: 0x0000227C File Offset: 0x0000047C
		[Token(Token = "0x6000054")]
		[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "10")]
		public bool eventTrack(string appId, string name, string properties)
		{
			return default(bool);
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00002294 File Offset: 0x00000494
		[Token(Token = "0x6000055")]
		[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "11")]
		public bool appStartEvent(string appId, string channel1, string channel2, bool beat, string properties)
		{
			return default(bool);
		}

		// Token: 0x06000056 RID: 86 RVA: 0x0000209A File Offset: 0x0000029A
		[Token(Token = "0x6000056")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "12")]
		public void pauseBeat(string appId)
		{
		}

		// Token: 0x06000057 RID: 87 RVA: 0x0000209A File Offset: 0x0000029A
		[Token(Token = "0x6000057")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "13")]
		public void resumeBeat(string appId)
		{
		}

		// Token: 0x06000058 RID: 88 RVA: 0x000022AC File Offset: 0x000004AC
		[Token(Token = "0x6000058")]
		[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "14")]
		public bool userLoginEvent(string appId, string userId, string properties)
		{
			return default(bool);
		}

		// Token: 0x06000059 RID: 89 RVA: 0x0000209A File Offset: 0x0000029A
		[Token(Token = "0x6000059")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "15")]
		public void unsetUser(string appId)
		{
		}

		// Token: 0x0600005A RID: 90 RVA: 0x000022C4 File Offset: 0x000004C4
		[Token(Token = "0x600005A")]
		[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "16")]
		public bool characterLoginEvent(string appId, string characterId, string serverId, string properties)
		{
			return default(bool);
		}

		// Token: 0x0600005B RID: 91 RVA: 0x0000209A File Offset: 0x0000029A
		[Token(Token = "0x600005B")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "17")]
		public void unsetCharacter(string appId)
		{
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600005C")]
		[Address(RVA = "0x4A04080", Offset = "0x4A02C80", VA = "0x184A04080", Slot = "18")]
		public string getPresetProperties(string appId)
		{
			return null;
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600005D")]
		[Address(RVA = "0x4A040E0", Offset = "0x4A02CE0", VA = "0x184A040E0", Slot = "20")]
		public string getStaticPresetProperties(string appId)
		{
			return null;
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600005E")]
		[Address(RVA = "0x4A04020", Offset = "0x4A02C20", VA = "0x184A04020", Slot = "21")]
		public string getDeviceIdProperties(string appId)
		{
			return null;
		}

		// Token: 0x0600005F RID: 95 RVA: 0x0000209A File Offset: 0x0000029A
		[Token(Token = "0x600005F")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "19")]
		public void flush(string appId)
		{
		}

		// Token: 0x06000060 RID: 96 RVA: 0x000022DC File Offset: 0x000004DC
		[Token(Token = "0x6000060")]
		[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "5")]
		public bool enableRealTimeSend(bool enable)
		{
			return default(bool);
		}

		// Token: 0x06000061 RID: 97 RVA: 0x000022F4 File Offset: 0x000004F4
		[Token(Token = "0x6000061")]
		[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "22")]
		public bool setGlobalPropertiesV2(string globalProperties)
		{
			return default(bool);
		}

		// Token: 0x06000062 RID: 98 RVA: 0x0000230C File Offset: 0x0000050C
		[Token(Token = "0x6000062")]
		[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "23")]
		public bool unsetGlobalPropertiesV2(string propertyKeys)
		{
			return default(bool);
		}

		// Token: 0x06000063 RID: 99 RVA: 0x0000209A File Offset: 0x0000029A
		[Token(Token = "0x6000063")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "24")]
		public void clearGlobalPropertiesV2()
		{
		}

		// Token: 0x06000064 RID: 100 RVA: 0x00002324 File Offset: 0x00000524
		[Token(Token = "0x6000064")]
		[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "25")]
		public bool eventTrackV2(string name, string properties)
		{
			return default(bool);
		}

		// Token: 0x06000065 RID: 101 RVA: 0x0000233C File Offset: 0x0000053C
		[Token(Token = "0x6000065")]
		[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "26")]
		public bool appStartEventV2(string channel1, string channel2, bool beat, string properties)
		{
			return default(bool);
		}

		// Token: 0x06000066 RID: 102 RVA: 0x0000209A File Offset: 0x0000029A
		[Token(Token = "0x6000066")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "27")]
		public void pauseBeatV2()
		{
		}

		// Token: 0x06000067 RID: 103 RVA: 0x0000209A File Offset: 0x0000029A
		[Token(Token = "0x6000067")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "28")]
		public void resumeBeatV2()
		{
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00002354 File Offset: 0x00000554
		[Token(Token = "0x6000068")]
		[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "29")]
		public bool userLoginEventV2(string userId, string properties)
		{
			return default(bool);
		}

		// Token: 0x06000069 RID: 105 RVA: 0x0000209A File Offset: 0x0000029A
		[Token(Token = "0x6000069")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "30")]
		public void unsetUserV2()
		{
		}

		// Token: 0x0600006A RID: 106 RVA: 0x0000236C File Offset: 0x0000056C
		[Token(Token = "0x600006A")]
		[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "31")]
		public bool characterLoginEventV2(string characterId, string serverId, string properties)
		{
			return default(bool);
		}

		// Token: 0x0600006B RID: 107 RVA: 0x0000209A File Offset: 0x0000029A
		[Token(Token = "0x600006B")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "32")]
		public void unsetCharacterV2()
		{
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600006C")]
		[Address(RVA = "0x4A04050", Offset = "0x4A02C50", VA = "0x184A04050", Slot = "33")]
		public string getPresetPropertiesV2()
		{
			return null;
		}

		// Token: 0x0600006D RID: 109 RVA: 0x0000209A File Offset: 0x0000029A
		[Token(Token = "0x600006D")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "34")]
		public void flushV2()
		{
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600006E")]
		[Address(RVA = "0x4A040B0", Offset = "0x4A02CB0", VA = "0x184A040B0", Slot = "35")]
		public string getStaticPresetPropertiesV2()
		{
			return null;
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600006F")]
		[Address(RVA = "0x4A03FF0", Offset = "0x4A02BF0", VA = "0x184A03FF0", Slot = "36")]
		public string getDeviceIdPropertiesV2()
		{
			return null;
		}

		// Token: 0x06000070 RID: 112 RVA: 0x00002384 File Offset: 0x00000584
		[Token(Token = "0x6000070")]
		[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "37")]
		public bool eventTrackV3(string appId, string name, string properties)
		{
			return default(bool);
		}
	}
}
