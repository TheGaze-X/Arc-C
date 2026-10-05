using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine.Playables;

namespace UnityEngine.Timeline
{
	// Token: 0x0200002E RID: 46
	[Token(Token = "0x200002E")]
	[ExcludeFromPreset]
	[TrackBindingType(typeof(AudioSource))]
	[TrackClipType(typeof(AudioPlayableAsset), false)]
	[Serializable]
	public class AudioTrack : TrackAsset
	{
		// Token: 0x060001D5 RID: 469 RVA: 0x000021E6 File Offset: 0x000003E6
		[Token(Token = "0x60001D5")]
		[Address(RVA = "0x58E3810", Offset = "0x58E2410", VA = "0x1858E3810")]
		public TimelineClip CreateClip(AudioClip clip)
		{
			return null;
		}

		// Token: 0x060001D6 RID: 470 RVA: 0x000030BC File Offset: 0x000012BC
		[Token(Token = "0x60001D6")]
		[Address(RVA = "0x58E2F80", Offset = "0x58E1B80", VA = "0x1858E2F80", Slot = "25")]
		internal override Playable CompileClips(PlayableGraph graph, GameObject go, IList<TimelineClip> timelineClips, IntervalTree<RuntimeElement> tree)
		{
			return default(Playable);
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x060001D7 RID: 471 RVA: 0x000021E6 File Offset: 0x000003E6
		[Token(Token = "0x17000092")]
		public override IEnumerable<PlayableBinding> outputs
		{
			[Token(Token = "0x60001D7")]
			[Address(RVA = "0x58E3AD0", Offset = "0x58E26D0", VA = "0x1858E3AD0", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x060001D8 RID: 472 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60001D8")]
		[Address(RVA = "0x58E3990", Offset = "0x58E2590", VA = "0x1858E3990")]
		private void OnValidate()
		{
		}

		// Token: 0x060001D9 RID: 473 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60001D9")]
		[Address(RVA = "0x58E3A30", Offset = "0x58E2630", VA = "0x1858E3A30")]
		public AudioTrack()
		{
		}

		// Token: 0x040000DB RID: 219
		[Token(Token = "0x40000DB")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private AudioMixerProperties m_TrackProperties;
	}
}
