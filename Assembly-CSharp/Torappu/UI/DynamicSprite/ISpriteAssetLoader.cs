using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.UI.DynamicSprite
{
	// Token: 0x02005A59 RID: 23129
	[Token(Token = "0x2005A59")]
	public interface ISpriteAssetLoader
	{
		// Token: 0x06021A95 RID: 137877
		[Token(Token = "0x6021A95")]
		void LoadAsync(DynamicSpriteLoader.BakeInfo bakeInfo, Action<Sprite> callback);
	}
}
