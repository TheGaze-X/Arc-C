using System;
using Il2CppDummyDll;

namespace Torappu.AVG
{
	// Token: 0x02001E24 RID: 7716
	[Token(Token = "0x2001E24")]
	public interface ICommandPredicator
	{
		// Token: 0x0600BEA3 RID: 48803
		[Token(Token = "0x600BEA3")]
		bool NeedToExecuteCommand(Command command);
	}
}
