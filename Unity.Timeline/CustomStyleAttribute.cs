using System;
using Il2CppDummyDll;

namespace UnityEngine.Timeline
{
	// Token: 0x02000066 RID: 102
	[Token(Token = "0x2000066")]
	[AttributeUsage(AttributeTargets.Class)]
	public class CustomStyleAttribute : Attribute
	{
		// Token: 0x06000314 RID: 788 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000314")]
		[Address(RVA = "0x50BD60", Offset = "0x50A960", VA = "0x18050BD60")]
		public CustomStyleAttribute(string ussStyle)
		{
		}

		// Token: 0x04000161 RID: 353
		[Token(Token = "0x4000161")]
		[FieldOffset(Offset = "0x10")]
		public readonly string ussStyle;
	}
}
