using System;
using Il2CppDummyDll;

namespace UnityEngine
{
	// Token: 0x020000E7 RID: 231
	[Token(Token = "0x20000E7")]
	[AttributeUsage(AttributeTargets.Field, Inherited = true, AllowMultiple = false)]
	public sealed class ColorUsageAttribute : PropertyAttribute
	{
		// Token: 0x060008BD RID: 2237 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008BD")]
		[Address(RVA = "0x5948400", Offset = "0x5947000", VA = "0x185948400")]
		public ColorUsageAttribute(bool showAlpha)
		{
		}

		// Token: 0x060008BE RID: 2238 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008BE")]
		[Address(RVA = "0x59483A0", Offset = "0x5946FA0", VA = "0x1859483A0")]
		public ColorUsageAttribute(bool showAlpha, bool hdr)
		{
		}

		// Token: 0x04000483 RID: 1155
		[Token(Token = "0x4000483")]
		[FieldOffset(Offset = "0x10")]
		public readonly bool showAlpha;

		// Token: 0x04000484 RID: 1156
		[Token(Token = "0x4000484")]
		[FieldOffset(Offset = "0x11")]
		public readonly bool hdr;

		// Token: 0x04000485 RID: 1157
		[Token(Token = "0x4000485")]
		[FieldOffset(Offset = "0x14")]
		[Obsolete("This field is no longer used for anything.")]
		public readonly float minBrightness;

		// Token: 0x04000486 RID: 1158
		[Token(Token = "0x4000486")]
		[FieldOffset(Offset = "0x18")]
		[Obsolete("This field is no longer used for anything.")]
		public readonly float maxBrightness;

		// Token: 0x04000487 RID: 1159
		[Token(Token = "0x4000487")]
		[FieldOffset(Offset = "0x1C")]
		[Obsolete("This field is no longer used for anything.")]
		public readonly float minExposureValue;

		// Token: 0x04000488 RID: 1160
		[Token(Token = "0x4000488")]
		[FieldOffset(Offset = "0x20")]
		[Obsolete("This field is no longer used for anything.")]
		public readonly float maxExposureValue;
	}
}
