using System;
using Il2CppDummyDll;
using UnityEngine;

namespace UnityStandardAssets.ImageEffects
{
	// Token: 0x02000053 RID: 83
	[Token(Token = "0x2000053")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Rendering/Global Fog")]
	internal class GlobalFog : PostEffectsBase
	{
		// Token: 0x06000212 RID: 530 RVA: 0x00002838 File Offset: 0x00000A38
		[Token(Token = "0x6000212")]
		[Address(RVA = "0x51E2AF0", Offset = "0x51E16F0", VA = "0x1851E2AF0", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		// Token: 0x06000213 RID: 531 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000213")]
		[Address(RVA = "0x51E2B50", Offset = "0x51E1750", VA = "0x1851E2B50")]
		[ImageEffectOpaque]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		// Token: 0x06000214 RID: 532 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000214")]
		[Address(RVA = "0x51E3370", Offset = "0x51E1F70", VA = "0x1851E3370")]
		public GlobalFog()
		{
		}

		// Token: 0x04000234 RID: 564
		[Token(Token = "0x4000234")]
		[FieldOffset(Offset = "0x28")]
		[Tooltip("Apply distance-based fog?")]
		public bool distanceFog;

		// Token: 0x04000235 RID: 565
		[Token(Token = "0x4000235")]
		[FieldOffset(Offset = "0x29")]
		[Tooltip("Exclude far plane pixels from distance-based fog? (Skybox or clear color)")]
		public bool excludeFarPixels;

		// Token: 0x04000236 RID: 566
		[Token(Token = "0x4000236")]
		[FieldOffset(Offset = "0x2A")]
		[Tooltip("Distance fog is based on radial distance from camera when checked")]
		public bool useRadialDistance;

		// Token: 0x04000237 RID: 567
		[Token(Token = "0x4000237")]
		[FieldOffset(Offset = "0x2B")]
		[Tooltip("Apply height-based fog?")]
		public bool heightFog;

		// Token: 0x04000238 RID: 568
		[Token(Token = "0x4000238")]
		[FieldOffset(Offset = "0x2C")]
		[Tooltip("Fog top Y coordinate")]
		public float height;

		// Token: 0x04000239 RID: 569
		[Token(Token = "0x4000239")]
		[FieldOffset(Offset = "0x30")]
		[Range(0.001f, 10f)]
		public float heightDensity;

		// Token: 0x0400023A RID: 570
		[Token(Token = "0x400023A")]
		[FieldOffset(Offset = "0x34")]
		[Tooltip("Push fog away from the camera by this amount")]
		public float startDistance;

		// Token: 0x0400023B RID: 571
		[Token(Token = "0x400023B")]
		[FieldOffset(Offset = "0x38")]
		public Shader fogShader;

		// Token: 0x0400023C RID: 572
		[Token(Token = "0x400023C")]
		[FieldOffset(Offset = "0x40")]
		private Material fogMaterial;
	}
}
