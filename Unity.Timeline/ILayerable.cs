using System;
using Il2CppDummyDll;
using UnityEngine.Playables;

namespace UnityEngine.Timeline
{
	// Token: 0x0200004C RID: 76
	[Token(Token = "0x200004C")]
	public interface ILayerable
	{
		// Token: 0x060002B7 RID: 695
		[Token(Token = "0x60002B7")]
		Playable CreateLayerMixer(PlayableGraph graph, GameObject go, int inputCount);
	}
}
