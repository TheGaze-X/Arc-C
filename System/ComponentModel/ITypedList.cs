using System;
using Il2CppDummyDll;

namespace System.ComponentModel
{
	// Token: 0x020001B1 RID: 433
	[Token(Token = "0x20001B1")]
	public interface ITypedList
	{
		// Token: 0x06000B19 RID: 2841
		[Token(Token = "0x6000B19")]
		string GetListName(PropertyDescriptor[] listAccessors);

		// Token: 0x06000B1A RID: 2842
		[Token(Token = "0x6000B1A")]
		PropertyDescriptorCollection GetItemProperties(PropertyDescriptor[] listAccessors);
	}
}
