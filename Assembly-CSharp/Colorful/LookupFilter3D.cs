using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Colorful
{
	// Token: 0x02007CF7 RID: 31991
	[Token(Token = "0x2007CF7")]
	[HelpURL("http://www.thomashourdel.com/colorful/doc/color-correction/lookup-filter-3d.html")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Colorful FX/Color Correction/Lookup Filter 3D")]
	public class LookupFilter3D : MonoBehaviour
	{
		// Token: 0x17006868 RID: 26728
		// (get) Token: 0x0602CA21 RID: 182817 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17006868")]
		public Shader Shader2DSafe
		{
			[Token(Token = "0x602CA21")]
			[Address(RVA = "0x2880C30", Offset = "0x287F830", VA = "0x182880C30")]
			get
			{
				return null;
			}
		}

		// Token: 0x17006869 RID: 26729
		// (get) Token: 0x0602CA22 RID: 182818 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17006869")]
		public Shader Shader3DSafe
		{
			[Token(Token = "0x602CA22")]
			[Address(RVA = "0x2880CC0", Offset = "0x287F8C0", VA = "0x182880CC0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700686A RID: 26730
		// (get) Token: 0x0602CA23 RID: 182819 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700686A")]
		public Material Material
		{
			[Token(Token = "0x602CA23")]
			[Address(RVA = "0x2880B10", Offset = "0x287F710", VA = "0x182880B10")]
			get
			{
				return null;
			}
		}

		// Token: 0x0602CA24 RID: 182820 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602CA24")]
		[Address(RVA = "0x2880840", Offset = "0x287F440", VA = "0x182880840", Slot = "4")]
		protected virtual void Start()
		{
		}

		// Token: 0x0602CA25 RID: 182821 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602CA25")]
		[Address(RVA = "0x287FEC0", Offset = "0x287EAC0", VA = "0x18287FEC0", Slot = "5")]
		protected virtual void OnDisable()
		{
		}

		// Token: 0x0602CA26 RID: 182822 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602CA26")]
		[Address(RVA = "0x28805B0", Offset = "0x287F1B0", VA = "0x1828805B0", Slot = "6")]
		protected virtual void Reset()
		{
		}

		// Token: 0x0602CA27 RID: 182823 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602CA27")]
		[Address(RVA = "0x2880600", Offset = "0x287F200", VA = "0x182880600")]
		protected void SetIdentityLut()
		{
		}

		// Token: 0x0602CA28 RID: 182824 RVA: 0x000E1120 File Offset: 0x000DF320
		[Token(Token = "0x602CA28")]
		[Address(RVA = "0x28809D0", Offset = "0x287F5D0", VA = "0x1828809D0")]
		public bool ValidDimensions(Texture2D tex2D)
		{
			return default(bool);
		}

		// Token: 0x0602CA29 RID: 182825 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602CA29")]
		[Address(RVA = "0x287FA70", Offset = "0x287E670", VA = "0x18287FA70")]
		protected void ConvertBaseTexture()
		{
		}

		// Token: 0x0602CA2A RID: 182826 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602CA2A")]
		[Address(RVA = "0x287F870", Offset = "0x287E470", VA = "0x18287F870")]
		public void Apply(Texture source, RenderTexture destination)
		{
		}

		// Token: 0x0602CA2B RID: 182827 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602CA2B")]
		[Address(RVA = "0x2880000", Offset = "0x287EC00", VA = "0x182880000", Slot = "7")]
		protected virtual void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		// Token: 0x0602CA2C RID: 182828 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602CA2C")]
		[Address(RVA = "0x28800F0", Offset = "0x287ECF0", VA = "0x1828800F0", Slot = "8")]
		protected virtual void RenderLut2D(RenderTexture source, RenderTexture destination)
		{
		}

		// Token: 0x0602CA2D RID: 182829 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602CA2D")]
		[Address(RVA = "0x28803A0", Offset = "0x287EFA0", VA = "0x1828803A0", Slot = "9")]
		protected virtual void RenderLut3D(RenderTexture source, RenderTexture destination)
		{
		}

		// Token: 0x0602CA2E RID: 182830 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602CA2E")]
		[Address(RVA = "0x156D000", Offset = "0x156BC00", VA = "0x18156D000")]
		public LookupFilter3D()
		{
		}

		// Token: 0x040404FF RID: 263423
		[Token(Token = "0x40404FF")]
		[FieldOffset(Offset = "0x18")]
		[Tooltip("The lookup texture to apply. Read the documentation to learn how to create one.")]
		public Texture2D LookupTexture;

		// Token: 0x04040500 RID: 263424
		[Token(Token = "0x4040500")]
		[FieldOffset(Offset = "0x20")]
		[Range(0f, 1f)]
		[Tooltip("Blending factor.")]
		public float Amount;

		// Token: 0x04040501 RID: 263425
		[Token(Token = "0x4040501")]
		[FieldOffset(Offset = "0x24")]
		[Tooltip("The effect will automatically detect the correct shader to use for the device but you can force it to only use the compatibility shader.")]
		public bool ForceCompatibility;

		// Token: 0x04040502 RID: 263426
		[Token(Token = "0x4040502")]
		[FieldOffset(Offset = "0x28")]
		protected Texture3D m_Lut3D;

		// Token: 0x04040503 RID: 263427
		[Token(Token = "0x4040503")]
		[FieldOffset(Offset = "0x30")]
		protected string m_BaseTextureName;

		// Token: 0x04040504 RID: 263428
		[Token(Token = "0x4040504")]
		[FieldOffset(Offset = "0x38")]
		protected bool m_Use2DLut;

		// Token: 0x04040505 RID: 263429
		[Token(Token = "0x4040505")]
		[FieldOffset(Offset = "0x40")]
		public Shader Shader2D;

		// Token: 0x04040506 RID: 263430
		[Token(Token = "0x4040506")]
		[FieldOffset(Offset = "0x48")]
		public Shader Shader3D;

		// Token: 0x04040507 RID: 263431
		[Token(Token = "0x4040507")]
		[FieldOffset(Offset = "0x50")]
		protected Material m_Material2D;

		// Token: 0x04040508 RID: 263432
		[Token(Token = "0x4040508")]
		[FieldOffset(Offset = "0x58")]
		protected Material m_Material3D;
	}
}
