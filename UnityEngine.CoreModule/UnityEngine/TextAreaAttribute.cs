using System;
using Il2CppDummyDll;

namespace UnityEngine
{
	// Token: 0x020000E6 RID: 230
	[Token(Token = "0x20000E6")]
	[AttributeUsage(AttributeTargets.Field, Inherited = true, AllowMultiple = false)]
	public sealed class TextAreaAttribute : PropertyAttribute
	{
		// Token: 0x060008BC RID: 2236 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008BC")]
		[Address(RVA = "0x4BDC4D0", Offset = "0x4BDB0D0", VA = "0x184BDC4D0")]
		public TextAreaAttribute(int minLines, int maxLines)
		{
		}

		// Token: 0x04000481 RID: 1153
		[Token(Token = "0x4000481")]
		[FieldOffset(Offset = "0x10")]
		public readonly int minLines;

		// Token: 0x04000482 RID: 1154
		[Token(Token = "0x4000482")]
		[FieldOffset(Offset = "0x14")]
		public readonly int maxLines;
	}
}
