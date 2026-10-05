using System;
using Il2CppDummyDll;

namespace FullInspector
{
	// Token: 0x02007BAE RID: 31662
	[Token(Token = "0x2007BAE")]
	[Obsolete("Please use InspectorShowIfAttribute instead")]
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
	public sealed class InspectorDisplayIfAttribute : Attribute
	{
		// Token: 0x0602C518 RID: 181528 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C518")]
		[Address(RVA = "0x50BD60", Offset = "0x50A960", VA = "0x18050BD60")]
		public InspectorDisplayIfAttribute(string conditionalMemberName)
		{
		}

		// Token: 0x04040200 RID: 262656
		[Token(Token = "0x4040200")]
		[FieldOffset(Offset = "0x10")]
		public string ConditionalMemberName;
	}
}
