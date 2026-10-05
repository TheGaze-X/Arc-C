using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine.Playables;

namespace UnityEngine.Timeline
{
	// Token: 0x02000043 RID: 67
	[Token(Token = "0x2000043")]
	[HideInMenu]
	[TrackBindingType(typeof(GameObject))]
	[ExcludeFromPreset]
	[Serializable]
	public class MarkerTrack : TrackAsset
	{
		// Token: 0x170000BE RID: 190
		// (get) Token: 0x0600028C RID: 652 RVA: 0x000021E6 File Offset: 0x000003E6
		[Token(Token = "0x170000BE")]
		public override IEnumerable<PlayableBinding> outputs
		{
			[Token(Token = "0x600028C")]
			[Address(RVA = "0x58EA830", Offset = "0x58E9430", VA = "0x1858EA830", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600028D RID: 653 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600028D")]
		[Address(RVA = "0x58EA7E0", Offset = "0x58E93E0", VA = "0x1858EA7E0")]
		public MarkerTrack()
		{
		}
	}
}
