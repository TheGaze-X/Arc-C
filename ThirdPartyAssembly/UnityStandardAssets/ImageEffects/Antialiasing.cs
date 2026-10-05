using System;
using Il2CppDummyDll;
using UnityEngine;

namespace UnityStandardAssets.ImageEffects
{
	// Token: 0x0200002D RID: 45
	[Token(Token = "0x200002D")]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Other/Antialiasing")]
	[ExecuteInEditMode]
	public class Antialiasing : PostEffectsBase
	{
		// Token: 0x060001A0 RID: 416 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001A0")]
		[Address(RVA = "0x51B6000", Offset = "0x51B4C00", VA = "0x1851B6000")]
		public Material CurrentAAMaterial()
		{
			return null;
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x00002658 File Offset: 0x00000858
		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x51B5E80", Offset = "0x51B4A80", VA = "0x1851B5E80", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001A2")]
		[Address(RVA = "0x51B6070", Offset = "0x51B4C70", VA = "0x1851B6070")]
		public void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001A3")]
		[Address(RVA = "0x51B6540", Offset = "0x51B5140", VA = "0x1851B6540")]
		public Antialiasing()
		{
		}

		// Token: 0x040000D2 RID: 210
		[Token(Token = "0x40000D2")]
		[FieldOffset(Offset = "0x28")]
		public AAMode mode;

		// Token: 0x040000D3 RID: 211
		[Token(Token = "0x40000D3")]
		[FieldOffset(Offset = "0x2C")]
		public bool showGeneratedNormals;

		// Token: 0x040000D4 RID: 212
		[Token(Token = "0x40000D4")]
		[FieldOffset(Offset = "0x30")]
		public float offsetScale;

		// Token: 0x040000D5 RID: 213
		[Token(Token = "0x40000D5")]
		[FieldOffset(Offset = "0x34")]
		public float blurRadius;

		// Token: 0x040000D6 RID: 214
		[Token(Token = "0x40000D6")]
		[FieldOffset(Offset = "0x38")]
		public float edgeThresholdMin;

		// Token: 0x040000D7 RID: 215
		[Token(Token = "0x40000D7")]
		[FieldOffset(Offset = "0x3C")]
		public float edgeThreshold;

		// Token: 0x040000D8 RID: 216
		[Token(Token = "0x40000D8")]
		[FieldOffset(Offset = "0x40")]
		public float edgeSharpness;

		// Token: 0x040000D9 RID: 217
		[Token(Token = "0x40000D9")]
		[FieldOffset(Offset = "0x44")]
		public bool dlaaSharp;

		// Token: 0x040000DA RID: 218
		[Token(Token = "0x40000DA")]
		[FieldOffset(Offset = "0x48")]
		public Shader ssaaShader;

		// Token: 0x040000DB RID: 219
		[Token(Token = "0x40000DB")]
		[FieldOffset(Offset = "0x50")]
		private Material ssaa;

		// Token: 0x040000DC RID: 220
		[Token(Token = "0x40000DC")]
		[FieldOffset(Offset = "0x58")]
		public Shader dlaaShader;

		// Token: 0x040000DD RID: 221
		[Token(Token = "0x40000DD")]
		[FieldOffset(Offset = "0x60")]
		private Material dlaa;

		// Token: 0x040000DE RID: 222
		[Token(Token = "0x40000DE")]
		[FieldOffset(Offset = "0x68")]
		public Shader nfaaShader;

		// Token: 0x040000DF RID: 223
		[Token(Token = "0x40000DF")]
		[FieldOffset(Offset = "0x70")]
		private Material nfaa;

		// Token: 0x040000E0 RID: 224
		[Token(Token = "0x40000E0")]
		[FieldOffset(Offset = "0x78")]
		public Shader shaderFXAAPreset2;

		// Token: 0x040000E1 RID: 225
		[Token(Token = "0x40000E1")]
		[FieldOffset(Offset = "0x80")]
		private Material materialFXAAPreset2;

		// Token: 0x040000E2 RID: 226
		[Token(Token = "0x40000E2")]
		[FieldOffset(Offset = "0x88")]
		public Shader shaderFXAAPreset3;

		// Token: 0x040000E3 RID: 227
		[Token(Token = "0x40000E3")]
		[FieldOffset(Offset = "0x90")]
		private Material materialFXAAPreset3;

		// Token: 0x040000E4 RID: 228
		[Token(Token = "0x40000E4")]
		[FieldOffset(Offset = "0x98")]
		public Shader shaderFXAAII;

		// Token: 0x040000E5 RID: 229
		[Token(Token = "0x40000E5")]
		[FieldOffset(Offset = "0xA0")]
		private Material materialFXAAII;

		// Token: 0x040000E6 RID: 230
		[Token(Token = "0x40000E6")]
		[FieldOffset(Offset = "0xA8")]
		public Shader shaderFXAAIII;

		// Token: 0x040000E7 RID: 231
		[Token(Token = "0x40000E7")]
		[FieldOffset(Offset = "0xB0")]
		private Material materialFXAAIII;
	}
}
