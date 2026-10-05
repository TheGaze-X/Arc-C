using System;
using Il2CppDummyDll;

namespace FullInspector
{
	// Token: 0x02007BFE RID: 31742
	[Token(Token = "0x2007BFE")]
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
	public sealed class InspectorRangeAttribute : Attribute
	{
		// Token: 0x0602C695 RID: 181909 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C695")]
		[Address(RVA = "0x2861690", Offset = "0x2860290", VA = "0x182861690")]
		public InspectorRangeAttribute(float min, float max)
		{
		}

		// Token: 0x040402A1 RID: 262817
		[Token(Token = "0x40402A1")]
		[FieldOffset(Offset = "0x10")]
		public float Min;

		// Token: 0x040402A2 RID: 262818
		[Token(Token = "0x40402A2")]
		[FieldOffset(Offset = "0x14")]
		public float Max;

		// Token: 0x040402A3 RID: 262819
		[Token(Token = "0x40402A3")]
		[FieldOffset(Offset = "0x18")]
		public float Step;
	}
}
