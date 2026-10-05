using System;
using Il2CppDummyDll;

namespace Torappu.UI.CrisisV2
{
	// Token: 0x0200597F RID: 22911
	[Token(Token = "0x200597F")]
	public interface ICrisisV2RuneSingleItemInfo : IHotfixable
	{
		// Token: 0x0602166E RID: 136814
		[Token(Token = "0x602166E")]
		string GetDesc();

		// Token: 0x0602166F RID: 136815
		[Token(Token = "0x602166F")]
		int GetPoint();

		// Token: 0x06021670 RID: 136816
		[Token(Token = "0x6021670")]
		string GetTutorialHighLightKey();
	}
}
