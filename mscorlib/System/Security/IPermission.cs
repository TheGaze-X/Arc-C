using System;
using Il2CppDummyDll;

namespace System.Security
{
	// Token: 0x020002B9 RID: 697
	[Token(Token = "0x20002B9")]
	public interface IPermission : ISecurityEncodable
	{
		// Token: 0x06001778 RID: 6008
		[Token(Token = "0x6001778")]
		void Demand();

		// Token: 0x06001779 RID: 6009
		[Token(Token = "0x6001779")]
		bool IsSubsetOf(IPermission target);
	}
}
