using System;
using Il2CppDummyDll;
using UnityEngine.Playables;

namespace UnityEngine.Timeline
{
	// Token: 0x02000004 RID: 4
	[Token(Token = "0x2000004")]
	[ExcludeFromPreset]
	[TrackBindingType(typeof(GameObject))]
	[TrackClipType(typeof(ActivationPlayableAsset))]
	[Serializable]
	public class ActivationTrack : TrackAsset
	{
		// Token: 0x0600000A RID: 10 RVA: 0x000020B0 File Offset: 0x000002B0
		[Token(Token = "0x600000A")]
		[Address(RVA = "0x58DC620", Offset = "0x58DB220", VA = "0x1858DC620", Slot = "33")]
		internal override bool CanCompileClips()
		{
			return default(bool);
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600000B RID: 11 RVA: 0x000020C8 File Offset: 0x000002C8
		// (set) Token: 0x0600000C RID: 12 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x17000003")]
		public ActivationTrack.PostPlaybackState postPlaybackState
		{
			[Token(Token = "0x600000B")]
			[Address(RVA = "0x371A2F0", Offset = "0x3718EF0", VA = "0x18371A2F0")]
			get
			{
				return ActivationTrack.PostPlaybackState.Active;
			}
			[Token(Token = "0x600000C")]
			[Address(RVA = "0x58DC990", Offset = "0x58DB590", VA = "0x1858DC990")]
			set
			{
			}
		}

		// Token: 0x0600000D RID: 13 RVA: 0x000020E0 File Offset: 0x000002E0
		[Token(Token = "0x600000D")]
		[Address(RVA = "0x58DC6A0", Offset = "0x58DB2A0", VA = "0x1858DC6A0", Slot = "24")]
		public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
		{
			return default(Playable);
		}

		// Token: 0x0600000E RID: 14 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600000E")]
		[Address(RVA = "0x58DC910", Offset = "0x58DB510", VA = "0x1858DC910")]
		internal void UpdateTrackMode()
		{
		}

		// Token: 0x0600000F RID: 15 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600000F")]
		[Address(RVA = "0x58DC7F0", Offset = "0x58DB3F0", VA = "0x1858DC7F0", Slot = "29")]
		public override void GatherProperties(PlayableDirector director, IPropertyCollector driver)
		{
		}

		// Token: 0x06000010 RID: 16 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000010")]
		[Address(RVA = "0x58DC8C0", Offset = "0x58DB4C0", VA = "0x1858DC8C0", Slot = "30")]
		protected override void OnCreateClip(TimelineClip clip)
		{
		}

		// Token: 0x06000011 RID: 17 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000011")]
		[Address(RVA = "0x58DC930", Offset = "0x58DB530", VA = "0x1858DC930")]
		public ActivationTrack()
		{
		}

		// Token: 0x04000004 RID: 4
		[Token(Token = "0x4000004")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private ActivationTrack.PostPlaybackState m_PostPlaybackState;

		// Token: 0x04000005 RID: 5
		[Token(Token = "0x4000005")]
		[FieldOffset(Offset = "0xA8")]
		private ActivationMixerPlayable m_ActivationMixer;

		// Token: 0x02000005 RID: 5
		[Token(Token = "0x2000005")]
		public enum PostPlaybackState
		{
			// Token: 0x04000007 RID: 7
			[Token(Token = "0x4000007")]
			Active,
			// Token: 0x04000008 RID: 8
			[Token(Token = "0x4000008")]
			Inactive,
			// Token: 0x04000009 RID: 9
			[Token(Token = "0x4000009")]
			Revert,
			// Token: 0x0400000A RID: 10
			[Token(Token = "0x400000A")]
			LeaveAsIs
		}
	}
}
