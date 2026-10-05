using System;
using Il2CppDummyDll;

namespace UnityEngine.Rendering.PostProcessing
{
	// Token: 0x02000007 RID: 7
	[Token(Token = "0x2000007")]
	[AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
	public sealed class MaxAttribute : Attribute
	{
		// Token: 0x06000008 RID: 8 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000008")]
		[Address(RVA = "0x28616F0", Offset = "0x28602F0", VA = "0x1828616F0")]
		public MaxAttribute(float max)
		{
		}

		// Token: 0x0400000E RID: 14
		[Token(Token = "0x400000E")]
		[FieldOffset(Offset = "0x10")]
		public readonly float max;
	}
}
