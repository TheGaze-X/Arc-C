using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Colorful
{
	// Token: 0x02007CED RID: 31981
	[Token(Token = "0x2007CED")]
	[AddComponentMenu("Colorful FX/Other Effects/LED")]
	[HelpURL("http://www.thomashourdel.com/colorful/doc/other-effects/led.html")]
	[ExecuteInEditMode]
	public class Led : BaseEffect
	{
		// Token: 0x0602CA0E RID: 182798 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602CA0E")]
		[Address(RVA = "0x287E720", Offset = "0x287D320", VA = "0x18287E720", Slot = "6")]
		protected override void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		// Token: 0x0602CA0F RID: 182799 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602CA0F")]
		[Address(RVA = "0x287E6F0", Offset = "0x287D2F0", VA = "0x18287E6F0", Slot = "7")]
		protected override string GetShaderName()
		{
			return null;
		}

		// Token: 0x0602CA10 RID: 182800 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602CA10")]
		[Address(RVA = "0x287E8F0", Offset = "0x287D4F0", VA = "0x18287E8F0")]
		public Led()
		{
		}

		// Token: 0x040404B7 RID: 263351
		[Token(Token = "0x40404B7")]
		[FieldOffset(Offset = "0x28")]
		[Range(1f, 255f)]
		[Tooltip("Scale of an individual LED. Depends on the Mode used.")]
		public float Scale;

		// Token: 0x040404B8 RID: 263352
		[Token(Token = "0x40404B8")]
		[FieldOffset(Offset = "0x2C")]
		[Range(0f, 10f)]
		[Tooltip("LED brightness booster.")]
		public float Brightness;

		// Token: 0x040404B9 RID: 263353
		[Token(Token = "0x40404B9")]
		[FieldOffset(Offset = "0x30")]
		[Range(1f, 3f)]
		[Tooltip("LED shape, from softer to harsher.")]
		public float Shape;

		// Token: 0x040404BA RID: 263354
		[Token(Token = "0x40404BA")]
		[FieldOffset(Offset = "0x34")]
		[Tooltip("Turn this on to automatically compute the aspect ratio needed for squared LED.")]
		public bool AutomaticRatio;

		// Token: 0x040404BB RID: 263355
		[Token(Token = "0x40404BB")]
		[FieldOffset(Offset = "0x38")]
		[Tooltip("Custom aspect ratio.")]
		public float Ratio;

		// Token: 0x040404BC RID: 263356
		[Token(Token = "0x40404BC")]
		[FieldOffset(Offset = "0x3C")]
		[Tooltip("Used for the Scale field.")]
		public Led.SizeMode Mode;

		// Token: 0x02007CEE RID: 31982
		[Token(Token = "0x2007CEE")]
		public enum SizeMode
		{
			// Token: 0x040404BE RID: 263358
			[Token(Token = "0x40404BE")]
			ResolutionIndependent,
			// Token: 0x040404BF RID: 263359
			[Token(Token = "0x40404BF")]
			PixelPerfect
		}
	}
}
