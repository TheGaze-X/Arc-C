using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Colorful
{
	// Token: 0x02007D08 RID: 32008
	[Token(Token = "0x2007D08")]
	[HelpURL("http://www.thomashourdel.com/colorful/doc/color-correction/smart-saturation.html")]
	[ExecuteInEditMode]
	[AddComponentMenu("Colorful FX/Color Correction/Smart Saturation")]
	public class SmartSaturation : BaseEffect
	{
		// Token: 0x1700686B RID: 26731
		// (get) Token: 0x0602CA51 RID: 182865 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700686B")]
		protected Texture2D m_CurveTexture
		{
			[Token(Token = "0x602CA51")]
			[Address(RVA = "0x2882B90", Offset = "0x2881790", VA = "0x182882B90")]
			get
			{
				return null;
			}
		}

		// Token: 0x0602CA52 RID: 182866 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602CA52")]
		[Address(RVA = "0x28827D0", Offset = "0x28813D0", VA = "0x1828827D0", Slot = "8")]
		protected virtual void Reset()
		{
		}

		// Token: 0x0602CA53 RID: 182867 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602CA53")]
		[Address(RVA = "0x2882620", Offset = "0x2881220", VA = "0x182882620", Slot = "9")]
		protected virtual void OnEnable()
		{
		}

		// Token: 0x0602CA54 RID: 182868 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602CA54")]
		[Address(RVA = "0x2882510", Offset = "0x2881110", VA = "0x182882510", Slot = "5")]
		protected override void OnDisable()
		{
		}

		// Token: 0x0602CA55 RID: 182869 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602CA55")]
		[Address(RVA = "0x2882950", Offset = "0x2881550", VA = "0x182882950", Slot = "10")]
		public virtual void UpdateCurve()
		{
		}

		// Token: 0x0602CA56 RID: 182870 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602CA56")]
		[Address(RVA = "0x2882660", Offset = "0x2881260", VA = "0x182882660", Slot = "6")]
		protected override void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		// Token: 0x0602CA57 RID: 182871 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602CA57")]
		[Address(RVA = "0x28824E0", Offset = "0x28810E0", VA = "0x1828824E0", Slot = "7")]
		protected override string GetShaderName()
		{
			return null;
		}

		// Token: 0x0602CA58 RID: 182872 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602CA58")]
		[Address(RVA = "0x2879610", Offset = "0x2878210", VA = "0x182879610")]
		public SmartSaturation()
		{
		}

		// Token: 0x04040543 RID: 263491
		[Token(Token = "0x4040543")]
		[FieldOffset(Offset = "0x28")]
		[Range(0f, 2f)]
		[Tooltip("Saturation boost. Default: 1 (no boost).")]
		public float Boost;

		// Token: 0x04040544 RID: 263492
		[Token(Token = "0x4040544")]
		[FieldOffset(Offset = "0x30")]
		public AnimationCurve Curve;

		// Token: 0x04040545 RID: 263493
		[Token(Token = "0x4040545")]
		[FieldOffset(Offset = "0x38")]
		private Texture2D _CurveTexture;
	}
}
