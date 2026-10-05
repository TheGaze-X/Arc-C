using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Colorful
{
	// Token: 0x02007CC5 RID: 31941
	[Token(Token = "0x2007CC5")]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("")]
	public class BaseEffect : MonoBehaviour
	{
		// Token: 0x17006865 RID: 26725
		// (get) Token: 0x0602C996 RID: 182678 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17006865")]
		public Shader ShaderSafe
		{
			[Token(Token = "0x602C996")]
			[Address(RVA = "0x2878AB0", Offset = "0x28776B0", VA = "0x182878AB0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17006866 RID: 26726
		// (get) Token: 0x0602C997 RID: 182679 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17006866")]
		public Material Material
		{
			[Token(Token = "0x602C997")]
			[Address(RVA = "0x28789D0", Offset = "0x28775D0", VA = "0x1828789D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0602C998 RID: 182680 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C998")]
		[Address(RVA = "0x28788C0", Offset = "0x28774C0", VA = "0x1828788C0", Slot = "4")]
		protected virtual void Start()
		{
		}

		// Token: 0x0602C999 RID: 182681 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C999")]
		[Address(RVA = "0x2878830", Offset = "0x2877430", VA = "0x182878830", Slot = "5")]
		protected virtual void OnDisable()
		{
		}

		// Token: 0x0602C99A RID: 182682 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C99A")]
		[Address(RVA = "0x2878600", Offset = "0x2877200", VA = "0x182878600")]
		public void Apply(Texture source, RenderTexture destination)
		{
		}

		// Token: 0x0602C99B RID: 182683 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C99B")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "6")]
		protected virtual void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		// Token: 0x0602C99C RID: 182684 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C99C")]
		[Address(RVA = "0x2878800", Offset = "0x2877400", VA = "0x182878800", Slot = "7")]
		protected virtual string GetShaderName()
		{
			return null;
		}

		// Token: 0x0602C99D RID: 182685 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C99D")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public BaseEffect()
		{
		}

		// Token: 0x040403E9 RID: 263145
		[Token(Token = "0x40403E9")]
		[FieldOffset(Offset = "0x18")]
		public Shader Shader;

		// Token: 0x040403EA RID: 263146
		[Token(Token = "0x40403EA")]
		[FieldOffset(Offset = "0x20")]
		protected Material m_Material;
	}
}
