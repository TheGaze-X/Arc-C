using System;
using Il2CppDummyDll;
using UnityEngine;

namespace UnityStandardAssets.ImageEffects
{
	// Token: 0x02000047 RID: 71
	[Token(Token = "0x2000047")]
	[ExecuteInEditMode]
	[AddComponentMenu("Image Effects/Edge Detection/Crease Shading")]
	[RequireComponent(typeof(Camera))]
	public class CreaseShading : PostEffectsBase
	{
		// Token: 0x060001EC RID: 492 RVA: 0x00002760 File Offset: 0x00000960
		[Token(Token = "0x60001EC")]
		[Address(RVA = "0x51DD6F0", Offset = "0x51DC2F0", VA = "0x1851DD6F0", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		// Token: 0x060001ED RID: 493 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001ED")]
		[Address(RVA = "0x51DD790", Offset = "0x51DC390", VA = "0x1851DD790")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		// Token: 0x060001EE RID: 494 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001EE")]
		[Address(RVA = "0x51DDB70", Offset = "0x51DC770", VA = "0x1851DDB70")]
		public CreaseShading()
		{
		}

		// Token: 0x040001BC RID: 444
		[Token(Token = "0x40001BC")]
		[FieldOffset(Offset = "0x28")]
		public float intensity;

		// Token: 0x040001BD RID: 445
		[Token(Token = "0x40001BD")]
		[FieldOffset(Offset = "0x2C")]
		public int softness;

		// Token: 0x040001BE RID: 446
		[Token(Token = "0x40001BE")]
		[FieldOffset(Offset = "0x30")]
		public float spread;

		// Token: 0x040001BF RID: 447
		[Token(Token = "0x40001BF")]
		[FieldOffset(Offset = "0x38")]
		public Shader blurShader;

		// Token: 0x040001C0 RID: 448
		[Token(Token = "0x40001C0")]
		[FieldOffset(Offset = "0x40")]
		private Material blurMaterial;

		// Token: 0x040001C1 RID: 449
		[Token(Token = "0x40001C1")]
		[FieldOffset(Offset = "0x48")]
		public Shader depthFetchShader;

		// Token: 0x040001C2 RID: 450
		[Token(Token = "0x40001C2")]
		[FieldOffset(Offset = "0x50")]
		private Material depthFetchMaterial;

		// Token: 0x040001C3 RID: 451
		[Token(Token = "0x40001C3")]
		[FieldOffset(Offset = "0x58")]
		public Shader creaseApplyShader;

		// Token: 0x040001C4 RID: 452
		[Token(Token = "0x40001C4")]
		[FieldOffset(Offset = "0x60")]
		private Material creaseApplyMaterial;
	}
}
