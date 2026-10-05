using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

namespace CriWare.CriTimeline.Atom
{
	// Token: 0x0200012B RID: 299
	[Token(Token = "0x200012B")]
	[TrackClipType(typeof(CriAtomClipBase))]
	[TrackBindingType(typeof(CriAtomSourceBase))]
	[TrackColor(0.3317462f, 0.6611561f, 0.990566f)]
	public class CriAtomTrack : TrackAsset
	{
		// Token: 0x060008AF RID: 2223 RVA: 0x00004694 File Offset: 0x00002894
		[Token(Token = "0x60008AF")]
		[Address(RVA = "0x370CCB0", Offset = "0x370B8B0", VA = "0x18370CCB0", Slot = "24")]
		public override Playable CreateTrackMixer(PlayableGraph graph, GameObject owner, int inputCount)
		{
			return default(Playable);
		}

		// Token: 0x060008B0 RID: 2224 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008B0")]
		[Address(RVA = "0x370D140", Offset = "0x370BD40", VA = "0x18370D140")]
		public CriAtomTrack()
		{
		}

		// Token: 0x0400057B RID: 1403
		[Token(Token = "0x400057B")]
		[FieldOffset(Offset = "0xA0")]
		public string m_AisacControls;

		// Token: 0x0400057C RID: 1404
		[Token(Token = "0x400057C")]
		[FieldOffset(Offset = "0xA8")]
		public bool m_StopOnWrapping;

		// Token: 0x0400057D RID: 1405
		[Token(Token = "0x400057D")]
		[FieldOffset(Offset = "0xA9")]
		public bool m_StopAtGraphEnd;

		// Token: 0x0400057E RID: 1406
		[Token(Token = "0x400057E")]
		[FieldOffset(Offset = "0xAA")]
		public bool m_ApplyPlayableSpeed;

		// Token: 0x0400057F RID: 1407
		[Token(Token = "0x400057F")]
		[FieldOffset(Offset = "0xAB")]
		public bool m_CheckPosWithinClip;
	}
}
