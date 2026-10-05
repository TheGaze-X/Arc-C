using System;
using Il2CppDummyDll;

namespace UnityEngine
{
	// Token: 0x020000E2 RID: 226
	[Token(Token = "0x20000E2")]
	[AttributeUsage(AttributeTargets.Field, Inherited = true, AllowMultiple = true)]
	public class HeaderAttribute : PropertyAttribute
	{
		// Token: 0x060008B8 RID: 2232 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008B8")]
		[Address(RVA = "0x50BD60", Offset = "0x50A960", VA = "0x18050BD60")]
		public HeaderAttribute(string header)
		{
		}

		// Token: 0x0400047C RID: 1148
		[Token(Token = "0x400047C")]
		[FieldOffset(Offset = "0x10")]
		public readonly string header;
	}
}
