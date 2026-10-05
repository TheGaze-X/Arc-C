using System;
using Il2CppDummyDll;

namespace Torappu.UI
{
	// Token: 0x02003591 RID: 13713
	[Token(Token = "0x2003591")]
	public interface ICharAttrInfo : ICharacterInfo, IHotfixable
	{
		// Token: 0x17003405 RID: 13317
		// (get) Token: 0x06015CFD RID: 89341
		[Token(Token = "0x17003405")]
		AttributesData attrData { [Token(Token = "0x6015CFD")] get; }

		// Token: 0x06015CFE RID: 89342
		[Token(Token = "0x6015CFE")]
		void SetAttrData(AttributesData newAttrData);
	}
}
