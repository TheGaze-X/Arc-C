using System;
using Il2CppDummyDll;
using UnityEngine;

namespace UnityStandardAssets.ImageEffects
{
	// Token: 0x0200003F RID: 63
	[Token(Token = "0x200003F")]
	[AddComponentMenu("Image Effects/Camera/Camera Motion Blur")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	public class CameraMotionBlur : PostEffectsBase
	{
		// Token: 0x060001C2 RID: 450 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001C2")]
		[Address(RVA = "0x51D7A60", Offset = "0x51D6660", VA = "0x1851D7A60")]
		private void CalculateViewProjection()
		{
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001C3")]
		[Address(RVA = "0x51DA2B0", Offset = "0x51D8EB0", VA = "0x1851DA2B0")]
		private new void Start()
		{
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001C4")]
		[Address(RVA = "0x51D8380", Offset = "0x51D6F80", VA = "0x1851D8380")]
		private void OnEnable()
		{
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001C5")]
		[Address(RVA = "0x51D8200", Offset = "0x51D6E00", VA = "0x1851D8200")]
		private void OnDisable()
		{
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x000026D0 File Offset: 0x000008D0
		[Token(Token = "0x60001C6")]
		[Address(RVA = "0x51D7D20", Offset = "0x51D6920", VA = "0x1851D7D20", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001C7")]
		[Address(RVA = "0x51D8450", Offset = "0x51D7050", VA = "0x1851D8450")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		// Token: 0x060001C8 RID: 456 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001C8")]
		[Address(RVA = "0x51DA060", Offset = "0x51D8C60", VA = "0x1851DA060")]
		private void Remember()
		{
		}

		// Token: 0x060001C9 RID: 457 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001C9")]
		[Address(RVA = "0x51D7DC0", Offset = "0x51D69C0", VA = "0x1851D7DC0")]
		private Camera GetTmpCam()
		{
			return null;
		}

		// Token: 0x060001CA RID: 458 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001CA")]
		[Address(RVA = "0x51DA200", Offset = "0x51D8E00", VA = "0x1851DA200")]
		private void StartFrame()
		{
		}

		// Token: 0x060001CB RID: 459 RVA: 0x000026E8 File Offset: 0x000008E8
		[Token(Token = "0x60001CB")]
		[Address(RVA = "0x51DA5C0", Offset = "0x51D91C0", VA = "0x1851DA5C0")]
		private static int divRoundUp(int x, int d)
		{
			return 0;
		}

		// Token: 0x060001CC RID: 460 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001CC")]
		[Address(RVA = "0x51DA450", Offset = "0x51D9050", VA = "0x1851DA450")]
		public CameraMotionBlur()
		{
		}

		// Token: 0x04000162 RID: 354
		[Token(Token = "0x4000162")]
		[FieldOffset(Offset = "0x0")]
		private static float MAX_RADIUS;

		// Token: 0x04000163 RID: 355
		[Token(Token = "0x4000163")]
		[FieldOffset(Offset = "0x28")]
		public CameraMotionBlur.MotionBlurFilter filterType;

		// Token: 0x04000164 RID: 356
		[Token(Token = "0x4000164")]
		[FieldOffset(Offset = "0x2C")]
		public bool preview;

		// Token: 0x04000165 RID: 357
		[Token(Token = "0x4000165")]
		[FieldOffset(Offset = "0x30")]
		public Vector3 previewScale;

		// Token: 0x04000166 RID: 358
		[Token(Token = "0x4000166")]
		[FieldOffset(Offset = "0x3C")]
		public float movementScale;

		// Token: 0x04000167 RID: 359
		[Token(Token = "0x4000167")]
		[FieldOffset(Offset = "0x40")]
		public float rotationScale;

		// Token: 0x04000168 RID: 360
		[Token(Token = "0x4000168")]
		[FieldOffset(Offset = "0x44")]
		public float maxVelocity;

		// Token: 0x04000169 RID: 361
		[Token(Token = "0x4000169")]
		[FieldOffset(Offset = "0x48")]
		public float minVelocity;

		// Token: 0x0400016A RID: 362
		[Token(Token = "0x400016A")]
		[FieldOffset(Offset = "0x4C")]
		public float velocityScale;

		// Token: 0x0400016B RID: 363
		[Token(Token = "0x400016B")]
		[FieldOffset(Offset = "0x50")]
		public float softZDistance;

		// Token: 0x0400016C RID: 364
		[Token(Token = "0x400016C")]
		[FieldOffset(Offset = "0x54")]
		public int velocityDownsample;

		// Token: 0x0400016D RID: 365
		[Token(Token = "0x400016D")]
		[FieldOffset(Offset = "0x58")]
		public LayerMask excludeLayers;

		// Token: 0x0400016E RID: 366
		[Token(Token = "0x400016E")]
		[FieldOffset(Offset = "0x60")]
		private GameObject tmpCam;

		// Token: 0x0400016F RID: 367
		[Token(Token = "0x400016F")]
		[FieldOffset(Offset = "0x68")]
		public Shader shader;

		// Token: 0x04000170 RID: 368
		[Token(Token = "0x4000170")]
		[FieldOffset(Offset = "0x70")]
		public Shader dx11MotionBlurShader;

		// Token: 0x04000171 RID: 369
		[Token(Token = "0x4000171")]
		[FieldOffset(Offset = "0x78")]
		public Shader replacementClear;

		// Token: 0x04000172 RID: 370
		[Token(Token = "0x4000172")]
		[FieldOffset(Offset = "0x80")]
		private Material motionBlurMaterial;

		// Token: 0x04000173 RID: 371
		[Token(Token = "0x4000173")]
		[FieldOffset(Offset = "0x88")]
		private Material dx11MotionBlurMaterial;

		// Token: 0x04000174 RID: 372
		[Token(Token = "0x4000174")]
		[FieldOffset(Offset = "0x90")]
		public Texture2D noiseTexture;

		// Token: 0x04000175 RID: 373
		[Token(Token = "0x4000175")]
		[FieldOffset(Offset = "0x98")]
		public float jitter;

		// Token: 0x04000176 RID: 374
		[Token(Token = "0x4000176")]
		[FieldOffset(Offset = "0x9C")]
		public bool showVelocity;

		// Token: 0x04000177 RID: 375
		[Token(Token = "0x4000177")]
		[FieldOffset(Offset = "0xA0")]
		public float showVelocityScale;

		// Token: 0x04000178 RID: 376
		[Token(Token = "0x4000178")]
		[FieldOffset(Offset = "0xA4")]
		private Matrix4x4 currentViewProjMat;

		// Token: 0x04000179 RID: 377
		[Token(Token = "0x4000179")]
		[FieldOffset(Offset = "0xE8")]
		private Matrix4x4[] currentStereoViewProjMat;

		// Token: 0x0400017A RID: 378
		[Token(Token = "0x400017A")]
		[FieldOffset(Offset = "0xF0")]
		private Matrix4x4 prevViewProjMat;

		// Token: 0x0400017B RID: 379
		[Token(Token = "0x400017B")]
		[FieldOffset(Offset = "0x130")]
		private Matrix4x4[] prevStereoViewProjMat;

		// Token: 0x0400017C RID: 380
		[Token(Token = "0x400017C")]
		[FieldOffset(Offset = "0x138")]
		private int prevFrameCount;

		// Token: 0x0400017D RID: 381
		[Token(Token = "0x400017D")]
		[FieldOffset(Offset = "0x13C")]
		private bool wasActive;

		// Token: 0x0400017E RID: 382
		[Token(Token = "0x400017E")]
		[FieldOffset(Offset = "0x140")]
		private Vector3 prevFrameForward;

		// Token: 0x0400017F RID: 383
		[Token(Token = "0x400017F")]
		[FieldOffset(Offset = "0x14C")]
		private Vector3 prevFrameUp;

		// Token: 0x04000180 RID: 384
		[Token(Token = "0x4000180")]
		[FieldOffset(Offset = "0x158")]
		private Vector3 prevFramePos;

		// Token: 0x04000181 RID: 385
		[Token(Token = "0x4000181")]
		[FieldOffset(Offset = "0x168")]
		private Camera _camera;

		// Token: 0x02000040 RID: 64
		[Token(Token = "0x2000040")]
		public enum MotionBlurFilter
		{
			// Token: 0x04000183 RID: 387
			[Token(Token = "0x4000183")]
			CameraMotion,
			// Token: 0x04000184 RID: 388
			[Token(Token = "0x4000184")]
			LocalBlur,
			// Token: 0x04000185 RID: 389
			[Token(Token = "0x4000185")]
			Reconstruction,
			// Token: 0x04000186 RID: 390
			[Token(Token = "0x4000186")]
			ReconstructionDX11,
			// Token: 0x04000187 RID: 391
			[Token(Token = "0x4000187")]
			ReconstructionDisc
		}
	}
}
