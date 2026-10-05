using System;
using System.ComponentModel;
using Il2CppDummyDll;
using UnityEngine.InputSystem.Layouts;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.Composites
{
	// Token: 0x0200026B RID: 619
	[Token(Token = "0x200026B")]
	[DisplayName("Up/Down/Left/Right Composite")]
	[DisplayStringFormat("{up}/{left}/{down}/{right}")]
	public class Vector2Composite : InputBindingComposite<Vector2>
	{
		// Token: 0x06001643 RID: 5699 RVA: 0x0000C078 File Offset: 0x0000A278
		[Token(Token = "0x6001643")]
		[Address(RVA = "0x56193B0", Offset = "0x5617FB0", VA = "0x1856193B0", Slot = "10")]
		public override Vector2 ReadValue(ref InputBindingCompositeContext context)
		{
			return default(Vector2);
		}

		// Token: 0x06001644 RID: 5700 RVA: 0x0000C090 File Offset: 0x0000A290
		[Token(Token = "0x6001644")]
		[Address(RVA = "0x56192F0", Offset = "0x5617EF0", VA = "0x1856192F0", Slot = "8")]
		public override float EvaluateMagnitude(ref InputBindingCompositeContext context)
		{
			return 0f;
		}

		// Token: 0x06001645 RID: 5701 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001645")]
		[Address(RVA = "0x5619530", Offset = "0x5618130", VA = "0x185619530")]
		public Vector2Composite()
		{
		}

		// Token: 0x04000C9D RID: 3229
		[Token(Token = "0x4000C9D")]
		[FieldOffset(Offset = "0x10")]
		[InputControl(layout = "Axis")]
		public int up;

		// Token: 0x04000C9E RID: 3230
		[Token(Token = "0x4000C9E")]
		[FieldOffset(Offset = "0x14")]
		[InputControl(layout = "Axis")]
		public int down;

		// Token: 0x04000C9F RID: 3231
		[Token(Token = "0x4000C9F")]
		[FieldOffset(Offset = "0x18")]
		[InputControl(layout = "Axis")]
		public int left;

		// Token: 0x04000CA0 RID: 3232
		[Token(Token = "0x4000CA0")]
		[FieldOffset(Offset = "0x1C")]
		[InputControl(layout = "Axis")]
		public int right;

		// Token: 0x04000CA1 RID: 3233
		[Token(Token = "0x4000CA1")]
		[FieldOffset(Offset = "0x20")]
		[Obsolete("Use Mode.DigitalNormalized with 'mode' instead")]
		public bool normalize;

		// Token: 0x04000CA2 RID: 3234
		[Token(Token = "0x4000CA2")]
		[FieldOffset(Offset = "0x24")]
		public Vector2Composite.Mode mode;

		// Token: 0x0200026C RID: 620
		[Token(Token = "0x200026C")]
		public enum Mode
		{
			// Token: 0x04000CA4 RID: 3236
			[Token(Token = "0x4000CA4")]
			Analog = 2,
			// Token: 0x04000CA5 RID: 3237
			[Token(Token = "0x4000CA5")]
			DigitalNormalized = 0,
			// Token: 0x04000CA6 RID: 3238
			[Token(Token = "0x4000CA6")]
			Digital
		}
	}
}
