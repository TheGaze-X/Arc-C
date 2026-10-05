using System;
using Il2CppDummyDll;
using UnityEngine;

namespace UnityStandardAssets.ImageEffects
{
	// Token: 0x02000046 RID: 70
	[Token(Token = "0x2000046")]
	[ExecuteInEditMode]
	[AddComponentMenu("Image Effects/Color Adjustments/Contrast Stretch")]
	public class ContrastStretch : MonoBehaviour
	{
		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060001E2 RID: 482 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700002B")]
		protected Material materialLum
		{
			[Token(Token = "0x60001E2")]
			[Address(RVA = "0x51DD550", Offset = "0x51DC150", VA = "0x1851DD550")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060001E3 RID: 483 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700002C")]
		protected Material materialReduce
		{
			[Token(Token = "0x60001E3")]
			[Address(RVA = "0x51DD620", Offset = "0x51DC220", VA = "0x1851DD620")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060001E4 RID: 484 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700002D")]
		protected Material materialAdapt
		{
			[Token(Token = "0x60001E4")]
			[Address(RVA = "0x51DD3B0", Offset = "0x51DBFB0", VA = "0x1851DD3B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060001E5 RID: 485 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700002E")]
		protected Material materialApply
		{
			[Token(Token = "0x60001E5")]
			[Address(RVA = "0x51DD480", Offset = "0x51DC080", VA = "0x1851DD480")]
			get
			{
				return null;
			}
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001E6")]
		[Address(RVA = "0x51DD2B0", Offset = "0x51DBEB0", VA = "0x1851DD2B0")]
		private void Start()
		{
		}

		// Token: 0x060001E7 RID: 487 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001E7")]
		[Address(RVA = "0x51DCE00", Offset = "0x51DBA00", VA = "0x1851DCE00")]
		private void OnEnable()
		{
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001E8")]
		[Address(RVA = "0x51DCC00", Offset = "0x51DB800", VA = "0x1851DCC00")]
		private void OnDisable()
		{
		}

		// Token: 0x060001E9 RID: 489 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001E9")]
		[Address(RVA = "0x51DCF60", Offset = "0x51DBB60", VA = "0x1851DCF60")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		// Token: 0x060001EA RID: 490 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001EA")]
		[Address(RVA = "0x51DCA10", Offset = "0x51DB610", VA = "0x1851DCA10")]
		private void CalculateAdaptation(Texture curTexture)
		{
		}

		// Token: 0x060001EB RID: 491 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001EB")]
		[Address(RVA = "0x51DD340", Offset = "0x51DBF40", VA = "0x1851DD340")]
		public ContrastStretch()
		{
		}

		// Token: 0x040001AF RID: 431
		[Token(Token = "0x40001AF")]
		[FieldOffset(Offset = "0x18")]
		[Range(0.0001f, 1f)]
		public float adaptationSpeed;

		// Token: 0x040001B0 RID: 432
		[Token(Token = "0x40001B0")]
		[FieldOffset(Offset = "0x1C")]
		[Range(0f, 1f)]
		public float limitMinimum;

		// Token: 0x040001B1 RID: 433
		[Token(Token = "0x40001B1")]
		[FieldOffset(Offset = "0x20")]
		[Range(0f, 1f)]
		public float limitMaximum;

		// Token: 0x040001B2 RID: 434
		[Token(Token = "0x40001B2")]
		[FieldOffset(Offset = "0x28")]
		private RenderTexture[] adaptRenderTex;

		// Token: 0x040001B3 RID: 435
		[Token(Token = "0x40001B3")]
		[FieldOffset(Offset = "0x30")]
		private int curAdaptIndex;

		// Token: 0x040001B4 RID: 436
		[Token(Token = "0x40001B4")]
		[FieldOffset(Offset = "0x38")]
		public Shader shaderLum;

		// Token: 0x040001B5 RID: 437
		[Token(Token = "0x40001B5")]
		[FieldOffset(Offset = "0x40")]
		private Material m_materialLum;

		// Token: 0x040001B6 RID: 438
		[Token(Token = "0x40001B6")]
		[FieldOffset(Offset = "0x48")]
		public Shader shaderReduce;

		// Token: 0x040001B7 RID: 439
		[Token(Token = "0x40001B7")]
		[FieldOffset(Offset = "0x50")]
		private Material m_materialReduce;

		// Token: 0x040001B8 RID: 440
		[Token(Token = "0x40001B8")]
		[FieldOffset(Offset = "0x58")]
		public Shader shaderAdapt;

		// Token: 0x040001B9 RID: 441
		[Token(Token = "0x40001B9")]
		[FieldOffset(Offset = "0x60")]
		private Material m_materialAdapt;

		// Token: 0x040001BA RID: 442
		[Token(Token = "0x40001BA")]
		[FieldOffset(Offset = "0x68")]
		public Shader shaderApply;

		// Token: 0x040001BB RID: 443
		[Token(Token = "0x40001BB")]
		[FieldOffset(Offset = "0x70")]
		private Material m_materialApply;
	}
}
