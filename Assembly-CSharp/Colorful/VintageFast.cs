using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Colorful
{
	// Token: 0x02007D11 RID: 32017
	[Token(Token = "0x2007D11")]
	[ExecuteInEditMode]
	[AddComponentMenu("Colorful FX/Color Correction/Vintage")]
	[HelpURL("http://www.thomashourdel.com/colorful/doc/color-correction/vintage-fast.html")]
	public class VintageFast : LookupFilter3D
	{
		// Token: 0x0602CA6A RID: 182890 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602CA6A")]
		[Address(RVA = "0x2883690", Offset = "0x2882290", VA = "0x182883690", Slot = "7")]
		protected override void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		// Token: 0x0602CA6B RID: 182891 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602CA6B")]
		[Address(RVA = "0x156D000", Offset = "0x156BC00", VA = "0x18156D000")]
		public VintageFast()
		{
		}

		// Token: 0x04040583 RID: 263555
		[Token(Token = "0x4040583")]
		[FieldOffset(Offset = "0x60")]
		public Vintage.InstragramFilter Filter;

		// Token: 0x04040584 RID: 263556
		[Token(Token = "0x4040584")]
		[FieldOffset(Offset = "0x64")]
		protected Vintage.InstragramFilter m_CurrentFilter;
	}
}
