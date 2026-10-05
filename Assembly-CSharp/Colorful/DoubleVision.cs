using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Colorful
{
	// Token: 0x02007CDA RID: 31962
	[Token(Token = "0x2007CDA")]
	[HelpURL("http://www.thomashourdel.com/colorful/doc/camera-effects/double-vision.html")]
	[ExecuteInEditMode]
	[AddComponentMenu("Colorful FX/Camera Effects/Double Vision")]
	public class DoubleVision : BaseEffect
	{
		// Token: 0x0602C9D6 RID: 182742 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C9D6")]
		[Address(RVA = "0x287B6A0", Offset = "0x287A2A0", VA = "0x18287B6A0", Slot = "6")]
		protected override void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		// Token: 0x0602C9D7 RID: 182743 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C9D7")]
		[Address(RVA = "0x287B670", Offset = "0x287A270", VA = "0x18287B670", Slot = "7")]
		protected override string GetShaderName()
		{
			return null;
		}

		// Token: 0x0602C9D8 RID: 182744 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C9D8")]
		[Address(RVA = "0x287B8E0", Offset = "0x287A4E0", VA = "0x18287B8E0")]
		public DoubleVision()
		{
		}

		// Token: 0x04040458 RID: 263256
		[Token(Token = "0x4040458")]
		[FieldOffset(Offset = "0x28")]
		[Tooltip("Diploplia strength.")]
		public Vector2 Displace;

		// Token: 0x04040459 RID: 263257
		[Token(Token = "0x4040459")]
		[FieldOffset(Offset = "0x30")]
		[Range(0f, 1f)]
		[Tooltip("Blending factor.")]
		public float Amount;
	}
}
