using System;
using Il2CppDummyDll;

namespace UnityEngine.Rendering.PostProcessing
{
	// Token: 0x02000008 RID: 8
	[Token(Token = "0x2000008")]
	[AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
	public sealed class PPMinAttribute : Attribute
	{
		// Token: 0x06000009 RID: 9 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000009")]
		[Address(RVA = "0x28616F0", Offset = "0x28602F0", VA = "0x1828616F0")]
		public PPMinAttribute(float min)
		{
		}

		// Token: 0x0400000F RID: 15
		[Token(Token = "0x400000F")]
		[FieldOffset(Offset = "0x10")]
		public readonly float min;
	}
}
