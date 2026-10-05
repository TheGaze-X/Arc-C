using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020004FA RID: 1274
	[Token(Token = "0x20004FA")]
	public interface IAddtiveBattleScene : IHotfixable
	{
		// Token: 0x17000238 RID: 568
		// (get) Token: 0x06004EB2 RID: 20146
		[Token(Token = "0x17000238")]
		string sceneAssetPath { [Token(Token = "0x6004EB2")] get; }

		// Token: 0x06004EB3 RID: 20147
		[Token(Token = "0x6004EB3")]
		void OnSceneLoaded();

		// Token: 0x06004EB4 RID: 20148
		[Token(Token = "0x6004EB4")]
		void OnSceneUnloaded(bool bySceneTrans);
	}
}
