using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

namespace CriWare.CriTimeline.Mana
{
	// Token: 0x02000122 RID: 290
	[Token(Token = "0x2000122")]
	[TrackColor(0.15f, 0.5f, 1f)]
	[TrackBindingType(typeof(CriManaMovieMaterialBase))]
	[TrackClipType(typeof(CriManaClipBase))]
	public class CriManaTrack : TrackAsset
	{
		// Token: 0x0600085D RID: 2141 RVA: 0x00004574 File Offset: 0x00002774
		[Token(Token = "0x600085D")]
		[Address(RVA = "0x370FD30", Offset = "0x370E930", VA = "0x18370FD30", Slot = "24")]
		public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
		{
			return default(Playable);
		}

		// Token: 0x0600085E RID: 2142 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600085E")]
		[Address(RVA = "0x3710480", Offset = "0x370F080", VA = "0x183710480")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600085F RID: 2143 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600085F")]
		[Address(RVA = "0x37104D0", Offset = "0x370F0D0", VA = "0x1837104D0")]
		private static void RemoveTrackFromBindDict(CriManaTrack trackAsset)
		{
		}

		// Token: 0x06000860 RID: 2144 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000860")]
		[Address(RVA = "0x3710920", Offset = "0x370F520", VA = "0x183710920")]
		public CriManaTrack()
		{
		}

		// Token: 0x04000543 RID: 1347
		[Token(Token = "0x4000543")]
		[FieldOffset(Offset = "0xA0")]
		public bool frameSync;

		// Token: 0x04000544 RID: 1348
		[Token(Token = "0x4000544")]
		[FieldOffset(Offset = "0xA1")]
		public bool checkPosWithinClip;

		// Token: 0x04000545 RID: 1349
		[Token(Token = "0x4000545")]
		[FieldOffset(Offset = "0xA4")]
		public readonly Guid guid;

		// Token: 0x04000546 RID: 1350
		[Token(Token = "0x4000546")]
		[FieldOffset(Offset = "0x0")]
		private static Dictionary<int, Guid> bindDict;
	}
}
