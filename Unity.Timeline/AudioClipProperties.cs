using System;
using Il2CppDummyDll;
using UnityEngine.Playables;

namespace UnityEngine.Timeline
{
	// Token: 0x0200002A RID: 42
	[Token(Token = "0x200002A")]
	[NotKeyable]
	[Serializable]
	internal class AudioClipProperties : PlayableBehaviour
	{
		// Token: 0x060001BF RID: 447 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60001BF")]
		[Address(RVA = "0x3709AE0", Offset = "0x37086E0", VA = "0x183709AE0")]
		public AudioClipProperties()
		{
		}

		// Token: 0x040000CF RID: 207
		[Token(Token = "0x40000CF")]
		[FieldOffset(Offset = "0x10")]
		[Range(0f, 1f)]
		public float volume;
	}
}
