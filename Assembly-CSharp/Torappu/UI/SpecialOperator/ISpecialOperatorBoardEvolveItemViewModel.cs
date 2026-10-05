using System;
using Il2CppDummyDll;

namespace Torappu.UI.SpecialOperator
{
	// Token: 0x02003E90 RID: 16016
	[Token(Token = "0x2003E90")]
	public interface ISpecialOperatorBoardEvolveItemViewModel
	{
		// Token: 0x06018E03 RID: 101891
		[Token(Token = "0x6018E03")]
		SpecialOperatorBoardEvolveItemType GetItemType();

		// Token: 0x06018E04 RID: 101892
		[Token(Token = "0x6018E04")]
		void RefreshData(PlayerCharacter playerChar);
	}
}
