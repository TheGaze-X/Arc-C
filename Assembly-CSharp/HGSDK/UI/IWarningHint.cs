using System;
using Il2CppDummyDll;

namespace HGSDK.UI
{
	// Token: 0x0200017E RID: 382
	[Token(Token = "0x200017E")]
	public interface IWarningHint
	{
		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x060005FD RID: 1533
		[Token(Token = "0x170000D1")]
		bool isValidatedOK { [Token(Token = "0x60005FD")] get; }

		// Token: 0x060005FE RID: 1534
		[Token(Token = "0x60005FE")]
		bool Validate(bool forceShowIfNotPass);
	}
}
