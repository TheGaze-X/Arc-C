using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

namespace Torappu.Grading
{
	// Token: 0x02001643 RID: 5699
	[Token(Token = "0x2001643")]
	[CreateAssetMenu(menuName = "HG/AntialiasingProfile")]
	public class AntialiasingProfile : ScriptableObject
	{
		// Token: 0x06008150 RID: 33104 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008150")]
		[Address(RVA = "0x2AF7F80", Offset = "0x2AF6B80", VA = "0x182AF7F80")]
		public AntialiasingProfile()
		{
		}

		// Token: 0x04008315 RID: 33557
		[Token(Token = "0x4008315")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		public bool enabled;

		// Token: 0x04008316 RID: 33558
		[Token(Token = "0x4008316")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		public SubpixelMorphologicalAntialiasing.Quality quality;
	}
}
