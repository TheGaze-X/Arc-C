using System;
using Il2CppDummyDll;

namespace Torappu.Battle.LevelScript
{
	// Token: 0x02002886 RID: 10374
	[Token(Token = "0x2002886")]
	public interface IParamVariablePool
	{
		// Token: 0x06011486 RID: 70790
		[Token(Token = "0x6011486")]
		ParamVariable AllocateFromMainPool();

		// Token: 0x06011487 RID: 70791
		[Token(Token = "0x6011487")]
		void RecycleFromMainPool(ParamVariable variable);
	}
}
