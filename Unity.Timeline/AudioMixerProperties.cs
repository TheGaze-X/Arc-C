using System;
using Il2CppDummyDll;
using UnityEngine.Playables;

namespace UnityEngine.Timeline
{
	// Token: 0x0200002B RID: 43
	[Token(Token = "0x200002B")]
	[Serializable]
	internal class AudioMixerProperties : PlayableBehaviour
	{
		// Token: 0x060001C0 RID: 448 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60001C0")]
		[Address(RVA = "0x58E28F0", Offset = "0x58E14F0", VA = "0x1858E28F0", Slot = "19")]
		public override void PrepareFrame(Playable playable, FrameData info)
		{
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60001C1")]
		[Address(RVA = "0x3709AE0", Offset = "0x37086E0", VA = "0x183709AE0")]
		public AudioMixerProperties()
		{
		}

		// Token: 0x040000D0 RID: 208
		[Token(Token = "0x40000D0")]
		[FieldOffset(Offset = "0x10")]
		[Range(0f, 1f)]
		public float volume;

		// Token: 0x040000D1 RID: 209
		[Token(Token = "0x40000D1")]
		[FieldOffset(Offset = "0x14")]
		[Range(-1f, 1f)]
		public float stereoPan;

		// Token: 0x040000D2 RID: 210
		[Token(Token = "0x40000D2")]
		[FieldOffset(Offset = "0x18")]
		[Range(0f, 1f)]
		public float spatialBlend;
	}
}
