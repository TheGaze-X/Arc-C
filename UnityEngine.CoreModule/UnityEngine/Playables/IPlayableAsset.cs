using System;
using Il2CppDummyDll;

namespace UnityEngine.Playables
{
	// Token: 0x0200028A RID: 650
	[Token(Token = "0x200028A")]
	public interface IPlayableAsset
	{
		// Token: 0x06000E9C RID: 3740
		[Token(Token = "0x6000E9C")]
		Playable CreatePlayable(PlayableGraph graph, GameObject owner);

		// Token: 0x170002F5 RID: 757
		// (get) Token: 0x06000E9D RID: 3741
		[Token(Token = "0x170002F5")]
		double duration { [Token(Token = "0x6000E9D")] get; }
	}
}
