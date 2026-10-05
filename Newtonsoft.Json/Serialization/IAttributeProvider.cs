using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x0200007A RID: 122
	[Token(Token = "0x200007A")]
	[Preserve]
	public interface IAttributeProvider
	{
		// Token: 0x06000450 RID: 1104
		[Token(Token = "0x6000450")]
		IList<Attribute> GetAttributes(bool inherit);

		// Token: 0x06000451 RID: 1105
		[Token(Token = "0x6000451")]
		IList<Attribute> GetAttributes(Type attributeType, bool inherit);
	}
}
