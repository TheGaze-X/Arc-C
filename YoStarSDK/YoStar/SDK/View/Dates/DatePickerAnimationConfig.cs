using System;
using Il2CppDummyDll;

namespace YoStar.SDK.View.Dates
{
	// Token: 0x0200011E RID: 286
	[Token(Token = "0x200011E")]
	[Serializable]
	public class DatePickerAnimationConfig
	{
		// Token: 0x0600077B RID: 1915 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600077B")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public DatePickerAnimationConfig()
		{
		}

		// Token: 0x04000439 RID: 1081
		[Token(Token = "0x4000439")]
		[FieldOffset(Offset = "0x10")]
		public Animation ShowAnimation;

		// Token: 0x0400043A RID: 1082
		[Token(Token = "0x400043A")]
		[FieldOffset(Offset = "0x14")]
		public Animation HideAnimation;

		// Token: 0x0400043B RID: 1083
		[Token(Token = "0x400043B")]
		[FieldOffset(Offset = "0x18")]
		public Animation MonthChangedAnimation;
	}
}
