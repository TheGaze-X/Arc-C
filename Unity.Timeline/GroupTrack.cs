using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine.Playables;

namespace UnityEngine.Timeline
{
	// Token: 0x0200004B RID: 75
	[Token(Token = "0x200004B")]
	[TrackClipType(typeof(TrackAsset))]
	[SupportsChildTracks(null, 2147483647)]
	[ExcludeFromPreset]
	[Serializable]
	public class GroupTrack : TrackAsset
	{
		// Token: 0x060002B4 RID: 692 RVA: 0x00003824 File Offset: 0x00001A24
		[Token(Token = "0x60002B4")]
		[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "33")]
		internal override bool CanCompileClips()
		{
			return default(bool);
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x060002B5 RID: 693 RVA: 0x000021E6 File Offset: 0x000003E6
		[Token(Token = "0x170000C6")]
		public override IEnumerable<PlayableBinding> outputs
		{
			[Token(Token = "0x60002B5")]
			[Address(RVA = "0x58E9980", Offset = "0x58E8580", VA = "0x1858E9980", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x060002B6 RID: 694 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60002B6")]
		[Address(RVA = "0x58E9930", Offset = "0x58E8530", VA = "0x1858E9930")]
		public GroupTrack()
		{
		}
	}
}
