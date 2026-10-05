using System;
using Il2CppDummyDll;
using UnityEngine;

namespace UnityStandardAssets.ImageEffects
{
	// Token: 0x02000050 RID: 80
	[Token(Token = "0x2000050")]
	[RequireComponent(typeof(Camera))]
	[ExecuteInEditMode]
	[AddComponentMenu("Image Effects/Edge Detection/Edge Detection")]
	public class EdgeDetection : PostEffectsBase
	{
		// Token: 0x06000209 RID: 521 RVA: 0x00002808 File Offset: 0x00000A08
		[Token(Token = "0x6000209")]
		[Address(RVA = "0x51E24B0", Offset = "0x51E10B0", VA = "0x1851E24B0", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		// Token: 0x0600020A RID: 522 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600020A")]
		[Address(RVA = "0x51E2850", Offset = "0x51E1450", VA = "0x1851E2850")]
		private new void Start()
		{
		}

		// Token: 0x0600020B RID: 523 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600020B")]
		[Address(RVA = "0x51E27A0", Offset = "0x51E13A0", VA = "0x1851E27A0")]
		private void SetCameraFlag()
		{
		}

		// Token: 0x0600020C RID: 524 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600020C")]
		[Address(RVA = "0x51E2530", Offset = "0x51E1130", VA = "0x1851E2530")]
		private void OnEnable()
		{
		}

		// Token: 0x0600020D RID: 525 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600020D")]
		[Address(RVA = "0x51E2540", Offset = "0x51E1140", VA = "0x1851E2540")]
		[ImageEffectOpaque]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		// Token: 0x0600020E RID: 526 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600020E")]
		[Address(RVA = "0x51E2860", Offset = "0x51E1460", VA = "0x1851E2860")]
		public EdgeDetection()
		{
		}

		// Token: 0x0400021F RID: 543
		[Token(Token = "0x400021F")]
		[FieldOffset(Offset = "0x28")]
		public EdgeDetection.EdgeDetectMode mode;

		// Token: 0x04000220 RID: 544
		[Token(Token = "0x4000220")]
		[FieldOffset(Offset = "0x2C")]
		public float sensitivityDepth;

		// Token: 0x04000221 RID: 545
		[Token(Token = "0x4000221")]
		[FieldOffset(Offset = "0x30")]
		public float sensitivityNormals;

		// Token: 0x04000222 RID: 546
		[Token(Token = "0x4000222")]
		[FieldOffset(Offset = "0x34")]
		public float lumThreshold;

		// Token: 0x04000223 RID: 547
		[Token(Token = "0x4000223")]
		[FieldOffset(Offset = "0x38")]
		public float edgeExp;

		// Token: 0x04000224 RID: 548
		[Token(Token = "0x4000224")]
		[FieldOffset(Offset = "0x3C")]
		public float sampleDist;

		// Token: 0x04000225 RID: 549
		[Token(Token = "0x4000225")]
		[FieldOffset(Offset = "0x40")]
		public float edgesOnly;

		// Token: 0x04000226 RID: 550
		[Token(Token = "0x4000226")]
		[FieldOffset(Offset = "0x44")]
		public Color edgesOnlyBgColor;

		// Token: 0x04000227 RID: 551
		[Token(Token = "0x4000227")]
		[FieldOffset(Offset = "0x58")]
		public Shader edgeDetectShader;

		// Token: 0x04000228 RID: 552
		[Token(Token = "0x4000228")]
		[FieldOffset(Offset = "0x60")]
		private Material edgeDetectMaterial;

		// Token: 0x04000229 RID: 553
		[Token(Token = "0x4000229")]
		[FieldOffset(Offset = "0x68")]
		private EdgeDetection.EdgeDetectMode oldMode;

		// Token: 0x02000051 RID: 81
		[Token(Token = "0x2000051")]
		public enum EdgeDetectMode
		{
			// Token: 0x0400022B RID: 555
			[Token(Token = "0x400022B")]
			TriangleDepthNormals,
			// Token: 0x0400022C RID: 556
			[Token(Token = "0x400022C")]
			RobertsCrossDepthNormals,
			// Token: 0x0400022D RID: 557
			[Token(Token = "0x400022D")]
			SobelDepth,
			// Token: 0x0400022E RID: 558
			[Token(Token = "0x400022E")]
			SobelDepthThin,
			// Token: 0x0400022F RID: 559
			[Token(Token = "0x400022F")]
			TriangleLuminance
		}
	}
}
