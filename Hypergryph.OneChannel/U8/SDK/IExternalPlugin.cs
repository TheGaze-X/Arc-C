using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace U8.SDK
{
	// Token: 0x02000005 RID: 5
	[Token(Token = "0x2000005")]
	public interface IExternalPlugin
	{
		// Token: 0x06000001 RID: 1
		[Token(Token = "0x6000001")]
		void Init();

		// Token: 0x06000002 RID: 2
		[Token(Token = "0x6000002")]
		void Login(ExternalPluginLoginParams args);

		// Token: 0x06000003 RID: 3
		[Token(Token = "0x6000003")]
		void Pay(ExternalPluginPayParams args);

		// Token: 0x06000004 RID: 4
		[Token(Token = "0x6000004")]
		void Logout(ExternalPluginLogoutParams args);

		// Token: 0x06000005 RID: 5
		[Token(Token = "0x6000005")]
		string GetSDKToken();

		// Token: 0x06000006 RID: 6
		[Token(Token = "0x6000006")]
		string GetSDKUid();

		// Token: 0x06000007 RID: 7
		[Token(Token = "0x6000007")]
		bool TryLoadSDKMeta(Func<SDKMeta> loadMetaNative, out SDKMeta meta);

		// Token: 0x06000008 RID: 8
		[Token(Token = "0x6000008")]
		void OnProductListChanged(List<U8ProductInfo> productList);

		// Token: 0x06000009 RID: 9
		[Token(Token = "0x6000009")]
		string GetPayAddition();

		// Token: 0x0600000A RID: 10 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600000A")]
		[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "9")]
		bool TrySetData(int type, string paramJson)
		{
			return default(bool);
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x600000B")]
		[Address(RVA = "0x4A0B6E0", Offset = "0x4A0A2E0", VA = "0x184A0B6E0", Slot = "10")]
		bool TryGetData(int type, string paramJson, out string data)
		{
			return default(bool);
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002080 File Offset: 0x00000280
		[Token(Token = "0x600000C")]
		[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "11")]
		bool TrySubmitGameData(U8ExtraGameData data)
		{
			return default(bool);
		}
	}
}
