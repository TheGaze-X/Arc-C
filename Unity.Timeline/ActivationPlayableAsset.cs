using System;
using Il2CppDummyDll;
using UnityEngine.Playables;

namespace UnityEngine.Timeline
{
	// Token: 0x02000003 RID: 3
	[Token(Token = "0x2000003")]
	internal class ActivationPlayableAsset : PlayableAsset, ITimelineClipAsset
	{
		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000007 RID: 7 RVA: 0x00002080 File Offset: 0x00000280
		[Token(Token = "0x17000002")]
		public ClipCaps clipCaps
		{
			[Token(Token = "0x6000007")]
			[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "9")]
			get
			{
				return ClipCaps.None;
			}
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002098 File Offset: 0x00000298
		[Token(Token = "0x6000008")]
		[Address(RVA = "0x58DC5A0", Offset = "0x58DB1A0", VA = "0x1858DC5A0", Slot = "6")]
		public override Playable CreatePlayable(PlayableGraph graph, GameObject go)
		{
			return default(Playable);
		}

		// Token: 0x06000009 RID: 9 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000009")]
		[Address(RVA = "0x4E4190", Offset = "0x4E2D90", VA = "0x1804E4190")]
		public ActivationPlayableAsset()
		{
		}
	}
}
