using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Colorful
{
	// Token: 0x02007CF6 RID: 31990
	[Token(Token = "0x2007CF6")]
	[ExecuteInEditMode]
	[AddComponentMenu("Colorful FX/Color Correction/Lookup Filter (Deprecated)")]
	[HelpURL("http://www.thomashourdel.com/colorful/doc/color-correction/lookup-filter.html")]
	public class LookupFilter : BaseEffect
	{
		// Token: 0x0602CA1E RID: 182814 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602CA1E")]
		[Address(RVA = "0x2880D80", Offset = "0x287F980", VA = "0x182880D80", Slot = "6")]
		protected override void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		// Token: 0x0602CA1F RID: 182815 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602CA1F")]
		[Address(RVA = "0x2880D50", Offset = "0x287F950", VA = "0x182880D50", Slot = "7")]
		protected override string GetShaderName()
		{
			return null;
		}

		// Token: 0x0602CA20 RID: 182816 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602CA20")]
		[Address(RVA = "0xFD3E40", Offset = "0xFD2A40", VA = "0x180FD3E40")]
		public LookupFilter()
		{
		}

		// Token: 0x040404FD RID: 263421
		[Token(Token = "0x40404FD")]
		[FieldOffset(Offset = "0x28")]
		[Tooltip("The lookup texture to apply. Read the documentation to learn how to create one.")]
		public Texture LookupTexture;

		// Token: 0x040404FE RID: 263422
		[Token(Token = "0x40404FE")]
		[FieldOffset(Offset = "0x30")]
		[Range(0f, 1f)]
		[Tooltip("Blending factor.")]
		public float Amount;
	}
}
