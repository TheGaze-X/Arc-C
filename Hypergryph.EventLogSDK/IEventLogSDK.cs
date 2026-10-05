using System;
using Il2CppDummyDll;

namespace Hypergryph.SDK
{
	// Token: 0x02000002 RID: 2
	[Token(Token = "0x2000002")]
	public interface IEventLogSDK
	{
		// Token: 0x06000001 RID: 1
		[Token(Token = "0x6000001")]
		bool setEnvironment(string env);

		// Token: 0x06000002 RID: 2
		[Token(Token = "0x6000002")]
		bool enableRealTimeSend(bool enable);

		// Token: 0x06000003 RID: 3
		[Token(Token = "0x6000003")]
		bool init(string appId, string regionTag);

		// Token: 0x06000004 RID: 4
		[Token(Token = "0x6000004")]
		bool setGlobalProperties(string appId, string globalProperties);

		// Token: 0x06000005 RID: 5
		[Token(Token = "0x6000005")]
		bool unsetGlobalProperties(string appId, string propertyKeys);

		// Token: 0x06000006 RID: 6
		[Token(Token = "0x6000006")]
		void clearGlobalProperties(string appId);

		// Token: 0x06000007 RID: 7
		[Token(Token = "0x6000007")]
		bool eventTrack(string appId, string name, string properties);

		// Token: 0x06000008 RID: 8
		[Token(Token = "0x6000008")]
		bool appStartEvent(string appId, string channel1, string channel2, bool beat, string properties);

		// Token: 0x06000009 RID: 9
		[Token(Token = "0x6000009")]
		void pauseBeat(string appId);

		// Token: 0x0600000A RID: 10
		[Token(Token = "0x600000A")]
		void resumeBeat(string appId);

		// Token: 0x0600000B RID: 11
		[Token(Token = "0x600000B")]
		bool userLoginEvent(string appId, string userId, string properties);

		// Token: 0x0600000C RID: 12
		[Token(Token = "0x600000C")]
		void unsetUser(string appId);

		// Token: 0x0600000D RID: 13
		[Token(Token = "0x600000D")]
		bool characterLoginEvent(string appId, string characterId, string serverId, string properties);

		// Token: 0x0600000E RID: 14
		[Token(Token = "0x600000E")]
		void unsetCharacter(string appId);

		// Token: 0x0600000F RID: 15
		[Token(Token = "0x600000F")]
		string getPresetProperties(string appId);

		// Token: 0x06000010 RID: 16
		[Token(Token = "0x6000010")]
		void flush(string appId);

		// Token: 0x06000011 RID: 17
		[Token(Token = "0x6000011")]
		string getStaticPresetProperties(string appId);

		// Token: 0x06000012 RID: 18
		[Token(Token = "0x6000012")]
		string getDeviceIdProperties(string appId);

		// Token: 0x06000013 RID: 19
		[Token(Token = "0x6000013")]
		bool setGlobalPropertiesV2(string globalProperties);

		// Token: 0x06000014 RID: 20
		[Token(Token = "0x6000014")]
		bool unsetGlobalPropertiesV2(string propertyKeys);

		// Token: 0x06000015 RID: 21
		[Token(Token = "0x6000015")]
		void clearGlobalPropertiesV2();

		// Token: 0x06000016 RID: 22
		[Token(Token = "0x6000016")]
		bool eventTrackV2(string name, string properties);

		// Token: 0x06000017 RID: 23
		[Token(Token = "0x6000017")]
		bool appStartEventV2(string channel1, string channel2, bool beat, string properties);

		// Token: 0x06000018 RID: 24
		[Token(Token = "0x6000018")]
		void pauseBeatV2();

		// Token: 0x06000019 RID: 25
		[Token(Token = "0x6000019")]
		void resumeBeatV2();

		// Token: 0x0600001A RID: 26
		[Token(Token = "0x600001A")]
		bool userLoginEventV2(string userId, string properties);

		// Token: 0x0600001B RID: 27
		[Token(Token = "0x600001B")]
		void unsetUserV2();

		// Token: 0x0600001C RID: 28
		[Token(Token = "0x600001C")]
		bool characterLoginEventV2(string characterId, string serverId, string properties);

		// Token: 0x0600001D RID: 29
		[Token(Token = "0x600001D")]
		void unsetCharacterV2();

		// Token: 0x0600001E RID: 30
		[Token(Token = "0x600001E")]
		string getPresetPropertiesV2();

		// Token: 0x0600001F RID: 31
		[Token(Token = "0x600001F")]
		void flushV2();

		// Token: 0x06000020 RID: 32
		[Token(Token = "0x6000020")]
		string getStaticPresetPropertiesV2();

		// Token: 0x06000021 RID: 33
		[Token(Token = "0x6000021")]
		string getDeviceIdPropertiesV2();

		// Token: 0x06000022 RID: 34
		[Token(Token = "0x6000022")]
		bool eventTrackV3(string appId, string name, string properties);
	}
}
