using System;
using System.Collections;
using Il2CppDummyDll;

namespace System.ComponentModel.Design
{
	// Token: 0x02000239 RID: 569
	[Token(Token = "0x2000239")]
	public interface ITypeDescriptorFilterService
	{
		// Token: 0x06000F84 RID: 3972
		[Token(Token = "0x6000F84")]
		bool FilterAttributes(IComponent component, IDictionary attributes);

		// Token: 0x06000F85 RID: 3973
		[Token(Token = "0x6000F85")]
		bool FilterEvents(IComponent component, IDictionary events);

		// Token: 0x06000F86 RID: 3974
		[Token(Token = "0x6000F86")]
		bool FilterProperties(IComponent component, IDictionary properties);
	}
}
