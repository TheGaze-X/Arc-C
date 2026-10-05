using System;
using Il2CppDummyDll;

namespace Torappu.Resource
{
	// Token: 0x020001CC RID: 460
	[Token(Token = "0x20001CC")]
	public interface ILocalResourceEvents
	{
		// Token: 0x06000AC2 RID: 2754
		[Token(Token = "0x6000AC2")]
		void OnLoadAsset(string assetPath, object asset);

		// Token: 0x06000AC3 RID: 2755
		[Token(Token = "0x6000AC3")]
		void OnLoadScene(string scenePath);

		// Token: 0x06000AC4 RID: 2756
		[Token(Token = "0x6000AC4")]
		void OnRawAssetExists(string assetPath);

		// Token: 0x06000AC5 RID: 2757
		[Token(Token = "0x6000AC5")]
		bool ValidateAsset(string assetPath);
	}
}
