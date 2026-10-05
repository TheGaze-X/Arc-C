using System;
using Il2CppDummyDll;

namespace UnityEngine
{
	// Token: 0x020000E0 RID: 224
	[Token(Token = "0x20000E0")]
	[AttributeUsage(AttributeTargets.All, Inherited = true, AllowMultiple = false)]
	public class TooltipAttribute : PropertyAttribute
	{
		// Token: 0x060008B5 RID: 2229 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008B5")]
		[Address(RVA = "0x50BD60", Offset = "0x50A960", VA = "0x18050BD60")]
		public TooltipAttribute(string tooltip)
		{
		}

		// Token: 0x0400047A RID: 1146
		[Token(Token = "0x400047A")]
		[FieldOffset(Offset = "0x10")]
		public readonly string tooltip;
	}
}
