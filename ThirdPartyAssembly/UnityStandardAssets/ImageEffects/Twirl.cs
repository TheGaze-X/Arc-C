using System;
using Il2CppDummyDll;
using UnityEngine;

namespace UnityStandardAssets.ImageEffects
{
	// Token: 0x0200006D RID: 109
	[Token(Token = "0x200006D")]
	[ExecuteInEditMode]
	[AddComponentMenu("Image Effects/Displacement/Twirl")]
	public class Twirl : ImageEffectBase
	{
		// Token: 0x0600026A RID: 618 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600026A")]
		[Address(RVA = "0x5301860", Offset = "0x5300460", VA = "0x185301860")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		// Token: 0x0600026B RID: 619 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600026B")]
		[Address(RVA = "0x53018E0", Offset = "0x53004E0", VA = "0x1853018E0")]
		public Twirl()
		{
		}

		// Token: 0x040002D3 RID: 723
		[Token(Token = "0x40002D3")]
		[FieldOffset(Offset = "0x28")]
		public Vector2 radius;

		// Token: 0x040002D4 RID: 724
		[Token(Token = "0x40002D4")]
		[FieldOffset(Offset = "0x30")]
		[Range(0f, 360f)]
		public float angle;

		// Token: 0x040002D5 RID: 725
		[Token(Token = "0x40002D5")]
		[FieldOffset(Offset = "0x34")]
		public Vector2 center;
	}
}
