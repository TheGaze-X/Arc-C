using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Colorful
{
	// Token: 0x02007CEB RID: 31979
	[Token(Token = "0x2007CEB")]
	[ExecuteInEditMode]
	[AddComponentMenu("Colorful FX/Color Correction/Hue, Saturation, Value")]
	[HelpURL("http://www.thomashourdel.com/colorful/doc/color-correction/hue-saturation-value.html")]
	public class HueSaturationValue : BaseEffect
	{
		// Token: 0x0602CA08 RID: 182792 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602CA08")]
		[Address(RVA = "0x287E070", Offset = "0x287CC70", VA = "0x18287E070", Slot = "6")]
		protected override void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		// Token: 0x0602CA09 RID: 182793 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602CA09")]
		[Address(RVA = "0x287E040", Offset = "0x287CC40", VA = "0x18287E040", Slot = "7")]
		protected override string GetShaderName()
		{
			return null;
		}

		// Token: 0x0602CA0A RID: 182794 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602CA0A")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public HueSaturationValue()
		{
		}

		// Token: 0x040404A0 RID: 263328
		[Token(Token = "0x40404A0")]
		[FieldOffset(Offset = "0x28")]
		[Range(-180f, 180f)]
		public float MasterHue;

		// Token: 0x040404A1 RID: 263329
		[Token(Token = "0x40404A1")]
		[FieldOffset(Offset = "0x2C")]
		[Range(-100f, 100f)]
		public float MasterSaturation;

		// Token: 0x040404A2 RID: 263330
		[Token(Token = "0x40404A2")]
		[FieldOffset(Offset = "0x30")]
		[Range(-100f, 100f)]
		public float MasterValue;

		// Token: 0x040404A3 RID: 263331
		[Token(Token = "0x40404A3")]
		[FieldOffset(Offset = "0x34")]
		[Range(-180f, 180f)]
		public float RedsHue;

		// Token: 0x040404A4 RID: 263332
		[Token(Token = "0x40404A4")]
		[FieldOffset(Offset = "0x38")]
		[Range(-100f, 100f)]
		public float RedsSaturation;

		// Token: 0x040404A5 RID: 263333
		[Token(Token = "0x40404A5")]
		[FieldOffset(Offset = "0x3C")]
		[Range(-100f, 100f)]
		public float RedsValue;

		// Token: 0x040404A6 RID: 263334
		[Token(Token = "0x40404A6")]
		[FieldOffset(Offset = "0x40")]
		[Range(-180f, 180f)]
		public float YellowsHue;

		// Token: 0x040404A7 RID: 263335
		[Token(Token = "0x40404A7")]
		[FieldOffset(Offset = "0x44")]
		[Range(-100f, 100f)]
		public float YellowsSaturation;

		// Token: 0x040404A8 RID: 263336
		[Token(Token = "0x40404A8")]
		[FieldOffset(Offset = "0x48")]
		[Range(-100f, 100f)]
		public float YellowsValue;

		// Token: 0x040404A9 RID: 263337
		[Token(Token = "0x40404A9")]
		[FieldOffset(Offset = "0x4C")]
		[Range(-180f, 180f)]
		public float GreensHue;

		// Token: 0x040404AA RID: 263338
		[Token(Token = "0x40404AA")]
		[FieldOffset(Offset = "0x50")]
		[Range(-100f, 100f)]
		public float GreensSaturation;

		// Token: 0x040404AB RID: 263339
		[Token(Token = "0x40404AB")]
		[FieldOffset(Offset = "0x54")]
		[Range(-100f, 100f)]
		public float GreensValue;

		// Token: 0x040404AC RID: 263340
		[Token(Token = "0x40404AC")]
		[FieldOffset(Offset = "0x58")]
		[Range(-180f, 180f)]
		public float CyansHue;

		// Token: 0x040404AD RID: 263341
		[Token(Token = "0x40404AD")]
		[FieldOffset(Offset = "0x5C")]
		[Range(-100f, 100f)]
		public float CyansSaturation;

		// Token: 0x040404AE RID: 263342
		[Token(Token = "0x40404AE")]
		[FieldOffset(Offset = "0x60")]
		[Range(-100f, 100f)]
		public float CyansValue;

		// Token: 0x040404AF RID: 263343
		[Token(Token = "0x40404AF")]
		[FieldOffset(Offset = "0x64")]
		[Range(-180f, 180f)]
		public float BluesHue;

		// Token: 0x040404B0 RID: 263344
		[Token(Token = "0x40404B0")]
		[FieldOffset(Offset = "0x68")]
		[Range(-100f, 100f)]
		public float BluesSaturation;

		// Token: 0x040404B1 RID: 263345
		[Token(Token = "0x40404B1")]
		[FieldOffset(Offset = "0x6C")]
		[Range(-100f, 100f)]
		public float BluesValue;

		// Token: 0x040404B2 RID: 263346
		[Token(Token = "0x40404B2")]
		[FieldOffset(Offset = "0x70")]
		[Range(-180f, 180f)]
		public float MagentasHue;

		// Token: 0x040404B3 RID: 263347
		[Token(Token = "0x40404B3")]
		[FieldOffset(Offset = "0x74")]
		[Range(-100f, 100f)]
		public float MagentasSaturation;

		// Token: 0x040404B4 RID: 263348
		[Token(Token = "0x40404B4")]
		[FieldOffset(Offset = "0x78")]
		[Range(-100f, 100f)]
		public float MagentasValue;

		// Token: 0x040404B5 RID: 263349
		[Token(Token = "0x40404B5")]
		[FieldOffset(Offset = "0x7C")]
		public bool AdvancedMode;
	}
}
