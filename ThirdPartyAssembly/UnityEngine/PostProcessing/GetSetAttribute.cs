using System;
using Il2CppDummyDll;

namespace UnityEngine.PostProcessing
{
	// Token: 0x0200007D RID: 125
	[Token(Token = "0x200007D")]
	public sealed class GetSetAttribute : PropertyAttribute
	{
		// Token: 0x060002AF RID: 687 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002AF")]
		[Address(RVA = "0x4E9E770", Offset = "0x4E9D370", VA = "0x184E9E770")]
		public GetSetAttribute(string name)
		{
		}

		// Token: 0x0400034A RID: 842
		[Token(Token = "0x400034A")]
		[FieldOffset(Offset = "0x10")]
		public readonly string name;

		// Token: 0x0400034B RID: 843
		[Token(Token = "0x400034B")]
		[FieldOffset(Offset = "0x18")]
		public bool dirty;
	}
}
