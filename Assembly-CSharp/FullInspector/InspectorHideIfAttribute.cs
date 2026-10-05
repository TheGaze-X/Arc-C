using System;
using Il2CppDummyDll;

namespace FullInspector
{
	// Token: 0x02007BB6 RID: 31670
	[Token(Token = "0x2007BB6")]
	[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field)]
	public sealed class InspectorHideIfAttribute : Attribute
	{
		// Token: 0x0602C522 RID: 181538 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C522")]
		[Address(RVA = "0x50BD60", Offset = "0x50A960", VA = "0x18050BD60")]
		public InspectorHideIfAttribute(string conditionalMemberName)
		{
		}

		// Token: 0x04040206 RID: 262662
		[Token(Token = "0x4040206")]
		[FieldOffset(Offset = "0x10")]
		public string ConditionalMemberName;
	}
}
