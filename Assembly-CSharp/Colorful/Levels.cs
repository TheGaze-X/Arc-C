using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Colorful
{
	// Token: 0x02007CF2 RID: 31986
	[Token(Token = "0x2007CF2")]
	[HelpURL("http://www.thomashourdel.com/colorful/doc/color-correction/levels.html")]
	[ExecuteInEditMode]
	[AddComponentMenu("Colorful FX/Color Correction/Levels")]
	public class Levels : BaseEffect
	{
		// Token: 0x0602CA17 RID: 182807 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602CA17")]
		[Address(RVA = "0x287ED40", Offset = "0x287D940", VA = "0x18287ED40", Slot = "6")]
		protected override void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		// Token: 0x0602CA18 RID: 182808 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602CA18")]
		[Address(RVA = "0x287ED10", Offset = "0x287D910", VA = "0x18287ED10", Slot = "7")]
		protected override string GetShaderName()
		{
			return null;
		}

		// Token: 0x0602CA19 RID: 182809 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602CA19")]
		[Address(RVA = "0x287F120", Offset = "0x287DD20", VA = "0x18287F120")]
		public Levels()
		{
		}

		// Token: 0x040404CC RID: 263372
		[Token(Token = "0x40404CC")]
		[FieldOffset(Offset = "0x28")]
		public Levels.ColorMode Mode;

		// Token: 0x040404CD RID: 263373
		[Token(Token = "0x40404CD")]
		[FieldOffset(Offset = "0x2C")]
		public Vector3 InputL;

		// Token: 0x040404CE RID: 263374
		[Token(Token = "0x40404CE")]
		[FieldOffset(Offset = "0x38")]
		public Vector3 InputR;

		// Token: 0x040404CF RID: 263375
		[Token(Token = "0x40404CF")]
		[FieldOffset(Offset = "0x44")]
		public Vector3 InputG;

		// Token: 0x040404D0 RID: 263376
		[Token(Token = "0x40404D0")]
		[FieldOffset(Offset = "0x50")]
		public Vector3 InputB;

		// Token: 0x040404D1 RID: 263377
		[Token(Token = "0x40404D1")]
		[FieldOffset(Offset = "0x5C")]
		public Vector2 OutputL;

		// Token: 0x040404D2 RID: 263378
		[Token(Token = "0x40404D2")]
		[FieldOffset(Offset = "0x64")]
		public Vector2 OutputR;

		// Token: 0x040404D3 RID: 263379
		[Token(Token = "0x40404D3")]
		[FieldOffset(Offset = "0x6C")]
		public Vector2 OutputG;

		// Token: 0x040404D4 RID: 263380
		[Token(Token = "0x40404D4")]
		[FieldOffset(Offset = "0x74")]
		public Vector2 OutputB;

		// Token: 0x02007CF3 RID: 31987
		[Token(Token = "0x2007CF3")]
		public enum ColorMode
		{
			// Token: 0x040404D6 RID: 263382
			[Token(Token = "0x40404D6")]
			Monochrome,
			// Token: 0x040404D7 RID: 263383
			[Token(Token = "0x40404D7")]
			RGB
		}
	}
}
