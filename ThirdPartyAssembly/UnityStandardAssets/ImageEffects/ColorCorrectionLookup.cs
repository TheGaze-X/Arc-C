using System;
using Il2CppDummyDll;
using UnityEngine;

namespace UnityStandardAssets.ImageEffects
{
	// Token: 0x02000043 RID: 67
	[Token(Token = "0x2000043")]
	[ExecuteInEditMode]
	[AddComponentMenu("Image Effects/Color Adjustments/Color Correction (3D Lookup Texture)")]
	public class ColorCorrectionLookup : PostEffectsBase
	{
		// Token: 0x060001D5 RID: 469 RVA: 0x00002718 File Offset: 0x00000918
		[Token(Token = "0x60001D5")]
		[Address(RVA = "0x51DB8B0", Offset = "0x51DA4B0", VA = "0x1851DB8B0", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		// Token: 0x060001D6 RID: 470 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001D6")]
		[Address(RVA = "0x51DBE70", Offset = "0x51DAA70", VA = "0x1851DBE70")]
		private void OnDisable()
		{
		}

		// Token: 0x060001D7 RID: 471 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001D7")]
		[Address(RVA = "0x51DBDE0", Offset = "0x51DA9E0", VA = "0x1851DBDE0")]
		private void OnDestroy()
		{
		}

		// Token: 0x060001D8 RID: 472 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001D8")]
		[Address(RVA = "0x51DC150", Offset = "0x51DAD50", VA = "0x1851DC150")]
		public void SetIdentityLut()
		{
		}

		// Token: 0x060001D9 RID: 473 RVA: 0x00002730 File Offset: 0x00000930
		[Token(Token = "0x60001D9")]
		[Address(RVA = "0x51DC370", Offset = "0x51DAF70", VA = "0x1851DC370")]
		public bool ValidDimensions(Texture2D tex2d)
		{
			return default(bool);
		}

		// Token: 0x060001DA RID: 474 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001DA")]
		[Address(RVA = "0x51DB920", Offset = "0x51DA520", VA = "0x1851DB920")]
		public void Convert(Texture2D temp2DTex, string path)
		{
		}

		// Token: 0x060001DB RID: 475 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001DB")]
		[Address(RVA = "0x51DBF10", Offset = "0x51DAB10", VA = "0x1851DBF10")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		// Token: 0x060001DC RID: 476 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001DC")]
		[Address(RVA = "0x51DC4B0", Offset = "0x51DB0B0", VA = "0x1851DC4B0")]
		public ColorCorrectionLookup()
		{
		}

		// Token: 0x040001A3 RID: 419
		[Token(Token = "0x40001A3")]
		[FieldOffset(Offset = "0x28")]
		public Shader shader;

		// Token: 0x040001A4 RID: 420
		[Token(Token = "0x40001A4")]
		[FieldOffset(Offset = "0x30")]
		private Material material;

		// Token: 0x040001A5 RID: 421
		[Token(Token = "0x40001A5")]
		[FieldOffset(Offset = "0x38")]
		public Texture3D converted3DLut;

		// Token: 0x040001A6 RID: 422
		[Token(Token = "0x40001A6")]
		[FieldOffset(Offset = "0x40")]
		public string basedOnTempTex;
	}
}
