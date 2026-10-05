using System;
using Il2CppDummyDll;

namespace System.Reflection
{
	// Token: 0x020004FE RID: 1278
	[Token(Token = "0x20004FE")]
	public interface ICustomAttributeProvider
	{
		// Token: 0x06002470 RID: 9328
		[Token(Token = "0x6002470")]
		object[] GetCustomAttributes(bool inherit);

		// Token: 0x06002471 RID: 9329
		[Token(Token = "0x6002471")]
		object[] GetCustomAttributes(System.Type attributeType, bool inherit);

		// Token: 0x06002472 RID: 9330
		[Token(Token = "0x6002472")]
		bool IsDefined(System.Type attributeType, bool inherit);
	}
}
