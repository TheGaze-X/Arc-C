using System;
using Il2CppDummyDll;
using UnityEngine;

namespace UnityStandardAssets.ImageEffects
{
	// Token: 0x02000052 RID: 82
	[Token(Token = "0x2000052")]
	[ExecuteInEditMode]
	[AddComponentMenu("Image Effects/Displacement/Fisheye")]
	[RequireComponent(typeof(Camera))]
	public class Fisheye : PostEffectsBase
	{
		// Token: 0x0600020F RID: 527 RVA: 0x00002820 File Offset: 0x00000A20
		[Token(Token = "0x600020F")]
		[Address(RVA = "0x51E28B0", Offset = "0x51E14B0", VA = "0x1851E28B0", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		// Token: 0x06000210 RID: 528 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000210")]
		[Address(RVA = "0x51E2910", Offset = "0x51E1510", VA = "0x1851E2910")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		// Token: 0x06000211 RID: 529 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000211")]
		[Address(RVA = "0x51E2AD0", Offset = "0x51E16D0", VA = "0x1851E2AD0")]
		public Fisheye()
		{
		}

		// Token: 0x04000230 RID: 560
		[Token(Token = "0x4000230")]
		[FieldOffset(Offset = "0x28")]
		[Range(0f, 1.5f)]
		public float strengthX;

		// Token: 0x04000231 RID: 561
		[Token(Token = "0x4000231")]
		[FieldOffset(Offset = "0x2C")]
		[Range(0f, 1.5f)]
		public float strengthY;

		// Token: 0x04000232 RID: 562
		[Token(Token = "0x4000232")]
		[FieldOffset(Offset = "0x30")]
		public Shader fishEyeShader;

		// Token: 0x04000233 RID: 563
		[Token(Token = "0x4000233")]
		[FieldOffset(Offset = "0x38")]
		private Material fisheyeMaterial;
	}
}
