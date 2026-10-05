using System;
using Il2CppDummyDll;

namespace UnityEngine.Rendering.PostProcessing
{
	// Token: 0x02000009 RID: 9
	[Token(Token = "0x2000009")]
	[AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
	public sealed class MinMaxAttribute : Attribute
	{
		// Token: 0x0600000A RID: 10 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600000A")]
		[Address(RVA = "0x4F1E70", Offset = "0x4F0A70", VA = "0x1804F1E70")]
		public MinMaxAttribute(float min, float max)
		{
		}

		// Token: 0x04000010 RID: 16
		[Token(Token = "0x4000010")]
		[FieldOffset(Offset = "0x10")]
		public readonly float min;

		// Token: 0x04000011 RID: 17
		[Token(Token = "0x4000011")]
		[FieldOffset(Offset = "0x14")]
		public readonly float max;
	}
}
