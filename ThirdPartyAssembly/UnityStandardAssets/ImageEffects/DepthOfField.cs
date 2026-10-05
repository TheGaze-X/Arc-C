using System;
using Il2CppDummyDll;
using UnityEngine;

namespace UnityStandardAssets.ImageEffects
{
	// Token: 0x02000048 RID: 72
	[Token(Token = "0x2000048")]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Camera/Depth of Field (Lens Blur, Scatter, DX11)")]
	[ExecuteInEditMode]
	public class DepthOfField : PostEffectsBase
	{
		// Token: 0x060001EF RID: 495 RVA: 0x00002778 File Offset: 0x00000978
		[Token(Token = "0x60001EF")]
		[Address(RVA = "0x51E02A0", Offset = "0x51DEEA0", VA = "0x1851E02A0", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		// Token: 0x060001F0 RID: 496 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001F0")]
		[Address(RVA = "0x51E08F0", Offset = "0x51DF4F0", VA = "0x1851E08F0")]
		private void OnEnable()
		{
		}

		// Token: 0x060001F1 RID: 497 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001F1")]
		[Address(RVA = "0x51E07A0", Offset = "0x51DF3A0", VA = "0x1851E07A0")]
		private void OnDisable()
		{
		}

		// Token: 0x060001F2 RID: 498 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001F2")]
		[Address(RVA = "0x51E20C0", Offset = "0x51E0CC0", VA = "0x1851E20C0")]
		private void ReleaseComputeResources()
		{
		}

		// Token: 0x060001F3 RID: 499 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001F3")]
		[Address(RVA = "0x51E0490", Offset = "0x51DF090", VA = "0x1851E0490")]
		private void CreateComputeResources()
		{
		}

		// Token: 0x060001F4 RID: 500 RVA: 0x00002790 File Offset: 0x00000990
		[Token(Token = "0x60001F4")]
		[Address(RVA = "0x51E0600", Offset = "0x51DF200", VA = "0x1851E0600")]
		private float FocalDistance01(float worldDist)
		{
			return 0f;
		}

		// Token: 0x060001F5 RID: 501 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001F5")]
		[Address(RVA = "0x51E2130", Offset = "0x51E0D30", VA = "0x1851E2130")]
		private void WriteCoc(RenderTexture fromTo, bool fgDilate)
		{
		}

		// Token: 0x060001F6 RID: 502 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001F6")]
		[Address(RVA = "0x51E0970", Offset = "0x51DF570", VA = "0x1851E0970")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		// Token: 0x060001F7 RID: 503 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001F7")]
		[Address(RVA = "0x51E2440", Offset = "0x51E1040", VA = "0x1851E2440")]
		public DepthOfField()
		{
		}

		// Token: 0x040001C5 RID: 453
		[Token(Token = "0x40001C5")]
		[FieldOffset(Offset = "0x28")]
		public bool visualizeFocus;

		// Token: 0x040001C6 RID: 454
		[Token(Token = "0x40001C6")]
		[FieldOffset(Offset = "0x2C")]
		public float focalLength;

		// Token: 0x040001C7 RID: 455
		[Token(Token = "0x40001C7")]
		[FieldOffset(Offset = "0x30")]
		public float focalSize;

		// Token: 0x040001C8 RID: 456
		[Token(Token = "0x40001C8")]
		[FieldOffset(Offset = "0x34")]
		public float aperture;

		// Token: 0x040001C9 RID: 457
		[Token(Token = "0x40001C9")]
		[FieldOffset(Offset = "0x38")]
		public Transform focalTransform;

		// Token: 0x040001CA RID: 458
		[Token(Token = "0x40001CA")]
		[FieldOffset(Offset = "0x40")]
		public float maxBlurSize;

		// Token: 0x040001CB RID: 459
		[Token(Token = "0x40001CB")]
		[FieldOffset(Offset = "0x44")]
		public bool highResolution;

		// Token: 0x040001CC RID: 460
		[Token(Token = "0x40001CC")]
		[FieldOffset(Offset = "0x48")]
		public DepthOfField.BlurType blurType;

		// Token: 0x040001CD RID: 461
		[Token(Token = "0x40001CD")]
		[FieldOffset(Offset = "0x4C")]
		public DepthOfField.BlurSampleCount blurSampleCount;

		// Token: 0x040001CE RID: 462
		[Token(Token = "0x40001CE")]
		[FieldOffset(Offset = "0x50")]
		public bool nearBlur;

		// Token: 0x040001CF RID: 463
		[Token(Token = "0x40001CF")]
		[FieldOffset(Offset = "0x54")]
		public float foregroundOverlap;

		// Token: 0x040001D0 RID: 464
		[Token(Token = "0x40001D0")]
		[FieldOffset(Offset = "0x58")]
		public Shader dofHdrShader;

		// Token: 0x040001D1 RID: 465
		[Token(Token = "0x40001D1")]
		[FieldOffset(Offset = "0x60")]
		private Material dofHdrMaterial;

		// Token: 0x040001D2 RID: 466
		[Token(Token = "0x40001D2")]
		[FieldOffset(Offset = "0x68")]
		public Shader dx11BokehShader;

		// Token: 0x040001D3 RID: 467
		[Token(Token = "0x40001D3")]
		[FieldOffset(Offset = "0x70")]
		private Material dx11bokehMaterial;

		// Token: 0x040001D4 RID: 468
		[Token(Token = "0x40001D4")]
		[FieldOffset(Offset = "0x78")]
		public float dx11BokehThreshold;

		// Token: 0x040001D5 RID: 469
		[Token(Token = "0x40001D5")]
		[FieldOffset(Offset = "0x7C")]
		public float dx11SpawnHeuristic;

		// Token: 0x040001D6 RID: 470
		[Token(Token = "0x40001D6")]
		[FieldOffset(Offset = "0x80")]
		public Texture2D dx11BokehTexture;

		// Token: 0x040001D7 RID: 471
		[Token(Token = "0x40001D7")]
		[FieldOffset(Offset = "0x88")]
		public float dx11BokehScale;

		// Token: 0x040001D8 RID: 472
		[Token(Token = "0x40001D8")]
		[FieldOffset(Offset = "0x8C")]
		public float dx11BokehIntensity;

		// Token: 0x040001D9 RID: 473
		[Token(Token = "0x40001D9")]
		[FieldOffset(Offset = "0x90")]
		private float focalDistance01;

		// Token: 0x040001DA RID: 474
		[Token(Token = "0x40001DA")]
		[FieldOffset(Offset = "0x98")]
		private ComputeBuffer cbDrawArgs;

		// Token: 0x040001DB RID: 475
		[Token(Token = "0x40001DB")]
		[FieldOffset(Offset = "0xA0")]
		private ComputeBuffer cbPoints;

		// Token: 0x040001DC RID: 476
		[Token(Token = "0x40001DC")]
		[FieldOffset(Offset = "0xA8")]
		private float internalBlurWidth;

		// Token: 0x040001DD RID: 477
		[Token(Token = "0x40001DD")]
		[FieldOffset(Offset = "0xB0")]
		private Camera cachedCamera;

		// Token: 0x02000049 RID: 73
		[Token(Token = "0x2000049")]
		public enum BlurType
		{
			// Token: 0x040001DF RID: 479
			[Token(Token = "0x40001DF")]
			DiscBlur,
			// Token: 0x040001E0 RID: 480
			[Token(Token = "0x40001E0")]
			DX11
		}

		// Token: 0x0200004A RID: 74
		[Token(Token = "0x200004A")]
		public enum BlurSampleCount
		{
			// Token: 0x040001E2 RID: 482
			[Token(Token = "0x40001E2")]
			Low,
			// Token: 0x040001E3 RID: 483
			[Token(Token = "0x40001E3")]
			Medium,
			// Token: 0x040001E4 RID: 484
			[Token(Token = "0x40001E4")]
			High
		}
	}
}
