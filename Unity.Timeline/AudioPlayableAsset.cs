using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine.Playables;

namespace UnityEngine.Timeline
{
	// Token: 0x0200002C RID: 44
	[Token(Token = "0x200002C")]
	[Serializable]
	public class AudioPlayableAsset : PlayableAsset, ITimelineClipAsset
	{
		// Token: 0x1700008A RID: 138
		// (get) Token: 0x060001C2 RID: 450 RVA: 0x00003014 File Offset: 0x00001214
		// (set) Token: 0x060001C3 RID: 451 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x1700008A")]
		internal float bufferingTime
		{
			[Token(Token = "0x60001C2")]
			[Address(RVA = "0x73B8E0", Offset = "0x73A4E0", VA = "0x18073B8E0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60001C3")]
			[Address(RVA = "0x73B910", Offset = "0x73A510", VA = "0x18073B910")]
			set
			{
			}
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x060001C4 RID: 452 RVA: 0x000021E6 File Offset: 0x000003E6
		// (set) Token: 0x060001C5 RID: 453 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x1700008B")]
		public AudioClip clip
		{
			[Token(Token = "0x60001C4")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001C5")]
			[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670")]
			set
			{
			}
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x060001C6 RID: 454 RVA: 0x0000302C File Offset: 0x0000122C
		// (set) Token: 0x060001C7 RID: 455 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x1700008C")]
		public bool loop
		{
			[Token(Token = "0x60001C6")]
			[Address(RVA = "0x4F1E20", Offset = "0x4F0A20", VA = "0x1804F1E20")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001C7")]
			[Address(RVA = "0x4F1E30", Offset = "0x4F0A30", VA = "0x1804F1E30")]
			set
			{
			}
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x060001C8 RID: 456 RVA: 0x00003044 File Offset: 0x00001244
		[Token(Token = "0x1700008D")]
		public override double duration
		{
			[Token(Token = "0x60001C8")]
			[Address(RVA = "0x58E2E40", Offset = "0x58E1A40", VA = "0x1858E2E40", Slot = "7")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x060001C9 RID: 457 RVA: 0x000021E6 File Offset: 0x000003E6
		[Token(Token = "0x1700008E")]
		public override IEnumerable<PlayableBinding> outputs
		{
			[Token(Token = "0x60001C9")]
			[Address(RVA = "0x58E2F00", Offset = "0x58E1B00", VA = "0x1858E2F00", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x060001CA RID: 458 RVA: 0x0000305C File Offset: 0x0000125C
		[Token(Token = "0x60001CA")]
		[Address(RVA = "0x58E2C20", Offset = "0x58E1820", VA = "0x1858E2C20", Slot = "6")]
		public override Playable CreatePlayable(PlayableGraph graph, GameObject go)
		{
			return default(Playable);
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x060001CB RID: 459 RVA: 0x00003074 File Offset: 0x00001274
		[Token(Token = "0x1700008F")]
		public ClipCaps clipCaps
		{
			[Token(Token = "0x60001CB")]
			[Address(RVA = "0x58E2E30", Offset = "0x58E1A30", VA = "0x1858E2E30", Slot = "9")]
			get
			{
				return ClipCaps.None;
			}
		}

		// Token: 0x060001CC RID: 460 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60001CC")]
		[Address(RVA = "0x58E2DB0", Offset = "0x58E19B0", VA = "0x1858E2DB0")]
		public AudioPlayableAsset()
		{
		}

		// Token: 0x040000D3 RID: 211
		[Token(Token = "0x40000D3")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private AudioClip m_Clip;

		// Token: 0x040000D4 RID: 212
		[Token(Token = "0x40000D4")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool m_Loop;

		// Token: 0x040000D5 RID: 213
		[Token(Token = "0x40000D5")]
		[FieldOffset(Offset = "0x24")]
		[HideInInspector]
		[SerializeField]
		private float m_bufferingTime;

		// Token: 0x040000D6 RID: 214
		[Token(Token = "0x40000D6")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private AudioClipProperties m_ClipProperties;
	}
}
