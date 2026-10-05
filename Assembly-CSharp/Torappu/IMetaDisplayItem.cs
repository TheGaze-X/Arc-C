using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020010F9 RID: 4345
	[Token(Token = "0x20010F9")]
	public interface IMetaDisplayItem
	{
		// Token: 0x06006EA6 RID: 28326
		[Token(Token = "0x6006EA6")]
		MetaUIDisplayType GetDisplayType();

		// Token: 0x06006EA7 RID: 28327
		[Token(Token = "0x6006EA7")]
		CommonAvailCheck GetAvailCheckNullable();

		// Token: 0x06006EA8 RID: 28328
		[Token(Token = "0x6006EA8")]
		string GetRelatedActId();
	}
}
