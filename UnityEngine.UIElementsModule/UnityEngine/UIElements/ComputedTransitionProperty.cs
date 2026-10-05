using System;
using Il2CppDummyDll;
using UnityEngine.UIElements.StyleSheets;

namespace UnityEngine.UIElements
{
	// Token: 0x0200021B RID: 539
	[Token(Token = "0x200021B")]
	internal struct ComputedTransitionProperty
	{
		// Token: 0x040007B0 RID: 1968
		[Token(Token = "0x40007B0")]
		[FieldOffset(Offset = "0x0")]
		public StylePropertyId id;

		// Token: 0x040007B1 RID: 1969
		[Token(Token = "0x40007B1")]
		[FieldOffset(Offset = "0x4")]
		public int durationMs;

		// Token: 0x040007B2 RID: 1970
		[Token(Token = "0x40007B2")]
		[FieldOffset(Offset = "0x8")]
		public int delayMs;

		// Token: 0x040007B3 RID: 1971
		[Token(Token = "0x40007B3")]
		[FieldOffset(Offset = "0x10")]
		public Func<float, float> easingCurve;
	}
}
