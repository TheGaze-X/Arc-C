using System;
using Il2CppDummyDll;

namespace FullInspector
{
	// Token: 0x02007BAF RID: 31663
	[Token(Token = "0x2007BAF")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Interface)]
	public sealed class InspectorDropdownNameAttribute : Attribute
	{
		// Token: 0x0602C519 RID: 181529 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C519")]
		[Address(RVA = "0x50BD60", Offset = "0x50A960", VA = "0x18050BD60")]
		public InspectorDropdownNameAttribute(string displayName)
		{
		}

		// Token: 0x04040201 RID: 262657
		[Token(Token = "0x4040201")]
		[FieldOffset(Offset = "0x10")]
		public string DisplayName;
	}
}
