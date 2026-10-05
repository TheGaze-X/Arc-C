using System;
using Il2CppDummyDll;

namespace FullInspector
{
	// Token: 0x02007BB5 RID: 31669
	[Token(Token = "0x2007BB5")]
	[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field)]
	public sealed class InspectorShowIfAttribute : Attribute
	{
		// Token: 0x0602C521 RID: 181537 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C521")]
		[Address(RVA = "0x50BD60", Offset = "0x50A960", VA = "0x18050BD60")]
		public InspectorShowIfAttribute(string conditionalMemberName)
		{
		}

		// Token: 0x04040205 RID: 262661
		[Token(Token = "0x4040205")]
		[FieldOffset(Offset = "0x10")]
		public string ConditionalMemberName;
	}
}
