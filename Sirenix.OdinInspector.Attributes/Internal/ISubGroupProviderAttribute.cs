using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Sirenix.OdinInspector.Internal
{
	// Token: 0x0200009F RID: 159
	[Token(Token = "0x200009F")]
	public interface ISubGroupProviderAttribute
	{
		// Token: 0x060001CD RID: 461
		[Token(Token = "0x60001CD")]
		IList<PropertyGroupAttribute> GetSubGroupAttributes();

		// Token: 0x060001CE RID: 462
		[Token(Token = "0x60001CE")]
		string RepathMemberAttribute(PropertyGroupAttribute attr);
	}
}
