using System;
using Il2CppDummyDll;
using UnityEngine;

namespace YoStar.SDK.View.Dates
{
	// Token: 0x0200011B RID: 283
	[Token(Token = "0x200011B")]
	[Serializable]
	public struct DatePickerConfig
	{
		// Token: 0x04000433 RID: 1075
		[Token(Token = "0x4000433")]
		[FieldOffset(Offset = "0x0")]
		[Space]
		public DatePickerBorderConfig Border;

		// Token: 0x04000434 RID: 1076
		[Token(Token = "0x4000434")]
		[FieldOffset(Offset = "0x8")]
		[Space]
		public DatePickerAnimationConfig Animation;

		// Token: 0x04000435 RID: 1077
		[Token(Token = "0x4000435")]
		[FieldOffset(Offset = "0x10")]
		[Space]
		public DatePickerEventConfig Events;
	}
}
