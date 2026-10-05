using System;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;

namespace Torappu.Battle.Sandbox
{
	// Token: 0x02002A4E RID: 10830
	[Token(Token = "0x2002A4E")]
	public interface IConstructOp
	{
		// Token: 0x06011F9F RID: 73631
		[Token(Token = "0x6011F9F")]
		void Execute();

		// Token: 0x06011FA0 RID: 73632
		[Token(Token = "0x6011FA0")]
		void Revert();

		// Token: 0x06011FA1 RID: 73633
		[Token(Token = "0x6011FA1")]
		JObject GetDataNullable();
	}
}
