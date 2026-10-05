using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Colorful
{
	// Token: 0x02007D15 RID: 32021
	[Token(Token = "0x2007D15")]
	[HelpURL("http://www.thomashourdel.com/colorful/doc/camera-effects/wiggle.html")]
	[ExecuteInEditMode]
	[AddComponentMenu("Colorful FX/Camera Effects/Wiggle")]
	public class Wiggle : BaseEffect
	{
		// Token: 0x0602CA73 RID: 182899 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602CA73")]
		[Address(RVA = "0x2883E80", Offset = "0x2882A80", VA = "0x182883E80", Slot = "8")]
		protected virtual void Update()
		{
		}

		// Token: 0x0602CA74 RID: 182900 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602CA74")]
		[Address(RVA = "0x2883D60", Offset = "0x2882960", VA = "0x182883D60", Slot = "6")]
		protected override void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		// Token: 0x0602CA75 RID: 182901 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602CA75")]
		[Address(RVA = "0x2883D30", Offset = "0x2882930", VA = "0x182883D30", Slot = "7")]
		protected override string GetShaderName()
		{
			return null;
		}

		// Token: 0x0602CA76 RID: 182902 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602CA76")]
		[Address(RVA = "0x2883EF0", Offset = "0x2882AF0", VA = "0x182883EF0")]
		public Wiggle()
		{
		}

		// Token: 0x0404058E RID: 263566
		[Token(Token = "0x404058E")]
		[FieldOffset(Offset = "0x28")]
		[Tooltip("Animation type. Complex is slower but looks more natural.")]
		public Wiggle.Algorithm Mode;

		// Token: 0x0404058F RID: 263567
		[Token(Token = "0x404058F")]
		[FieldOffset(Offset = "0x2C")]
		public float Timer;

		// Token: 0x04040590 RID: 263568
		[Token(Token = "0x4040590")]
		[FieldOffset(Offset = "0x30")]
		[Tooltip("Wave animation speed.")]
		public float Speed;

		// Token: 0x04040591 RID: 263569
		[Token(Token = "0x4040591")]
		[FieldOffset(Offset = "0x34")]
		[Tooltip("Wave frequency (higher means more waves).")]
		public float Frequency;

		// Token: 0x04040592 RID: 263570
		[Token(Token = "0x4040592")]
		[FieldOffset(Offset = "0x38")]
		[Tooltip("Wave amplitude (higher means bigger waves).")]
		public float Amplitude;

		// Token: 0x04040593 RID: 263571
		[Token(Token = "0x4040593")]
		[FieldOffset(Offset = "0x3C")]
		[Tooltip("Automatically animate this effect at runtime.")]
		public bool AutomaticTimer;

		// Token: 0x02007D16 RID: 32022
		[Token(Token = "0x2007D16")]
		public enum Algorithm
		{
			// Token: 0x04040595 RID: 263573
			[Token(Token = "0x4040595")]
			Simple,
			// Token: 0x04040596 RID: 263574
			[Token(Token = "0x4040596")]
			Complex
		}
	}
}
