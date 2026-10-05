using System;
using Il2CppDummyDll;
using UnityEngine.Scripting;

namespace UnityEngine.Playables
{
	// Token: 0x02000286 RID: 646
	[Token(Token = "0x2000286")]
	public interface IPlayableBehaviour
	{
		// Token: 0x06000E8B RID: 3723
		[Token(Token = "0x6000E8B")]
		[RequiredByNativeCode]
		void OnGraphStart(Playable playable);

		// Token: 0x06000E8C RID: 3724
		[Token(Token = "0x6000E8C")]
		[RequiredByNativeCode]
		void OnGraphStop(Playable playable);

		// Token: 0x06000E8D RID: 3725
		[Token(Token = "0x6000E8D")]
		[RequiredByNativeCode]
		void OnPlayableCreate(Playable playable);

		// Token: 0x06000E8E RID: 3726
		[Token(Token = "0x6000E8E")]
		[RequiredByNativeCode]
		void OnPlayableDestroy(Playable playable);

		// Token: 0x06000E8F RID: 3727
		[Token(Token = "0x6000E8F")]
		[RequiredByNativeCode]
		void OnBehaviourPlay(Playable playable, FrameData info);

		// Token: 0x06000E90 RID: 3728
		[Token(Token = "0x6000E90")]
		[RequiredByNativeCode]
		void OnBehaviourPause(Playable playable, FrameData info);

		// Token: 0x06000E91 RID: 3729
		[Token(Token = "0x6000E91")]
		[RequiredByNativeCode]
		void PrepareFrame(Playable playable, FrameData info);

		// Token: 0x06000E92 RID: 3730
		[Token(Token = "0x6000E92")]
		[RequiredByNativeCode]
		void ProcessFrame(Playable playable, FrameData info, object playerData);
	}
}
