using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine.Playables;

namespace UnityEngine.Timeline
{
	// Token: 0x02000050 RID: 80
	[Token(Token = "0x2000050")]
	[Obsolete("For best performance use PlayableAsset and PlayableBehaviour.")]
	[Serializable]
	public class BasicPlayableBehaviour : ScriptableObject, IPlayableAsset, IPlayableBehaviour
	{
		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x060002BF RID: 703 RVA: 0x00003854 File Offset: 0x00001A54
		[Token(Token = "0x170000C7")]
		public virtual double duration
		{
			[Token(Token = "0x60002BF")]
			[Address(RVA = "0x58E3C20", Offset = "0x58E2820", VA = "0x1858E3C20", Slot = "14")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x060002C0 RID: 704 RVA: 0x000021E6 File Offset: 0x000003E6
		[Token(Token = "0x170000C8")]
		public virtual IEnumerable<PlayableBinding> outputs
		{
			[Token(Token = "0x60002C0")]
			[Address(RVA = "0x58E3C70", Offset = "0x58E2870", VA = "0x1858E3C70", Slot = "15")]
			get
			{
				return null;
			}
		}

		// Token: 0x060002C1 RID: 705 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60002C1")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "16")]
		public virtual void OnGraphStart(Playable playable)
		{
		}

		// Token: 0x060002C2 RID: 706 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60002C2")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "17")]
		public virtual void OnGraphStop(Playable playable)
		{
		}

		// Token: 0x060002C3 RID: 707 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60002C3")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "18")]
		public virtual void OnPlayableCreate(Playable playable)
		{
		}

		// Token: 0x060002C4 RID: 708 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60002C4")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "19")]
		public virtual void OnPlayableDestroy(Playable playable)
		{
		}

		// Token: 0x060002C5 RID: 709 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60002C5")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "20")]
		public virtual void OnBehaviourPlay(Playable playable, FrameData info)
		{
		}

		// Token: 0x060002C6 RID: 710 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60002C6")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "21")]
		public virtual void OnBehaviourPause(Playable playable, FrameData info)
		{
		}

		// Token: 0x060002C7 RID: 711 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60002C7")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "22")]
		public virtual void PrepareFrame(Playable playable, FrameData info)
		{
		}

		// Token: 0x060002C8 RID: 712 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60002C8")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "23")]
		public virtual void ProcessFrame(Playable playable, FrameData info, object playerData)
		{
		}

		// Token: 0x060002C9 RID: 713 RVA: 0x0000386C File Offset: 0x00001A6C
		[Token(Token = "0x60002C9")]
		[Address(RVA = "0x58E3B50", Offset = "0x58E2750", VA = "0x1858E3B50", Slot = "24")]
		public virtual Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			return default(Playable);
		}

		// Token: 0x060002CA RID: 714 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60002CA")]
		[Address(RVA = "0x4F4B00", Offset = "0x4F3700", VA = "0x1804F4B00")]
		public BasicPlayableBehaviour()
		{
		}
	}
}
