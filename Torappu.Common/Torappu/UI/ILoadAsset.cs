using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.UI
{
	// Token: 0x02000152 RID: 338
	[Token(Token = "0x2000152")]
	public interface ILoadAsset
	{
		// Token: 0x060007F7 RID: 2039
		[Token(Token = "0x60007F7")]
		T LoadAsset<T>(string path) where T : UnityEngine.Object;

		// Token: 0x060007F8 RID: 2040
		[Token(Token = "0x60007F8")]
		UnityEngine.Object LoadAsset(string path);

		// Token: 0x060007F9 RID: 2041
		[Token(Token = "0x60007F9")]
		void UnloadAsset(UnityEngine.Object asset);
	}
}
