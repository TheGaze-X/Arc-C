using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200135F RID: 4959
	[Token(Token = "0x200135F")]
	[Serializable]
	public class MapThemeData
	{
		// Token: 0x06007328 RID: 29480 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007328")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public MapThemeData()
		{
		}

		// Token: 0x04006E10 RID: 28176
		[Token(Token = "0x4006E10")]
		[FieldOffset(Offset = "0x10")]
		public string themeId;

		// Token: 0x04006E11 RID: 28177
		[Token(Token = "0x4006E11")]
		[FieldOffset(Offset = "0x18")]
		public string unitColor;

		// Token: 0x04006E12 RID: 28178
		[Token(Token = "0x4006E12")]
		[FieldOffset(Offset = "0x20")]
		public string buildableColor;

		// Token: 0x04006E13 RID: 28179
		[Token(Token = "0x4006E13")]
		[FieldOffset(Offset = "0x28")]
		public string themeType;

		// Token: 0x04006E14 RID: 28180
		[Token(Token = "0x4006E14")]
		[FieldOffset(Offset = "0x30")]
		public string trapTintColor;

		// Token: 0x04006E15 RID: 28181
		[Token(Token = "0x4006E15")]
		[FieldOffset(Offset = "0x38")]
		public string emissionColor;
	}
}
