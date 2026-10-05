using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements.UIR
{
	// Token: 0x020002B4 RID: 692
	[Token(Token = "0x20002B4")]
	internal struct TextCoreSettings : IEquatable<TextCoreSettings>
	{
		// Token: 0x060012E9 RID: 4841 RVA: 0x00009F00 File Offset: 0x00008100
		[Token(Token = "0x60012E9")]
		[Address(RVA = "0x5A5A400", Offset = "0x5A59000", VA = "0x185A5A400", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x060012EA RID: 4842 RVA: 0x00009F18 File Offset: 0x00008118
		[Token(Token = "0x60012EA")]
		[Address(RVA = "0x5A5A4B0", Offset = "0x5A590B0", VA = "0x185A5A4B0", Slot = "4")]
		public bool Equals(TextCoreSettings other)
		{
			return default(bool);
		}

		// Token: 0x060012EB RID: 4843 RVA: 0x00009F30 File Offset: 0x00008130
		[Token(Token = "0x60012EB")]
		[Address(RVA = "0x5A5A650", Offset = "0x5A59250", VA = "0x185A5A650", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x04000A6F RID: 2671
		[Token(Token = "0x4000A6F")]
		[FieldOffset(Offset = "0x0")]
		public Color faceColor;

		// Token: 0x04000A70 RID: 2672
		[Token(Token = "0x4000A70")]
		[FieldOffset(Offset = "0x10")]
		public Color outlineColor;

		// Token: 0x04000A71 RID: 2673
		[Token(Token = "0x4000A71")]
		[FieldOffset(Offset = "0x20")]
		public float outlineWidth;

		// Token: 0x04000A72 RID: 2674
		[Token(Token = "0x4000A72")]
		[FieldOffset(Offset = "0x24")]
		public Color underlayColor;

		// Token: 0x04000A73 RID: 2675
		[Token(Token = "0x4000A73")]
		[FieldOffset(Offset = "0x34")]
		public Vector2 underlayOffset;

		// Token: 0x04000A74 RID: 2676
		[Token(Token = "0x4000A74")]
		[FieldOffset(Offset = "0x3C")]
		public float underlaySoftness;
	}
}
