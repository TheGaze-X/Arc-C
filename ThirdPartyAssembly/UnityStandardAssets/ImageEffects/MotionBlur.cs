using System;
using Il2CppDummyDll;
using UnityEngine;

namespace UnityStandardAssets.ImageEffects
{
	// Token: 0x02000057 RID: 87
	[Token(Token = "0x2000057")]
	[RequireComponent(typeof(Camera))]
	[ExecuteInEditMode]
	[AddComponentMenu("Image Effects/Blur/Motion Blur (Color Accumulation)")]
	public class MotionBlur : ImageEffectBase
	{
		// Token: 0x0600021F RID: 543 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600021F")]
		[Address(RVA = "0x51E34F0", Offset = "0x51E20F0", VA = "0x1851E34F0", Slot = "4")]
		protected override void Start()
		{
		}

		// Token: 0x06000220 RID: 544 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000220")]
		[Address(RVA = "0x51E39E0", Offset = "0x51E25E0", VA = "0x1851E39E0", Slot = "5")]
		protected override void OnDisable()
		{
		}

		// Token: 0x06000221 RID: 545 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000221")]
		[Address(RVA = "0x51E3AA0", Offset = "0x51E26A0", VA = "0x1851E3AA0")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		// Token: 0x06000222 RID: 546 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000222")]
		[Address(RVA = "0x51E3EE0", Offset = "0x51E2AE0", VA = "0x1851E3EE0")]
		public MotionBlur()
		{
		}

		// Token: 0x04000241 RID: 577
		[Token(Token = "0x4000241")]
		[FieldOffset(Offset = "0x28")]
		[Range(0f, 0.92f)]
		public float blurAmount;

		// Token: 0x04000242 RID: 578
		[Token(Token = "0x4000242")]
		[FieldOffset(Offset = "0x2C")]
		public bool extraBlur;

		// Token: 0x04000243 RID: 579
		[Token(Token = "0x4000243")]
		[FieldOffset(Offset = "0x30")]
		private RenderTexture accumTexture;
	}
}
