using System;
using Il2CppDummyDll;

namespace Torappu.UI.ChooseChar
{
	// Token: 0x02005A1A RID: 23066
	[Token(Token = "0x2005A1A")]
	public interface ICommonChooseCharCardViewModel
	{
		// Token: 0x0602199B RID: 137627
		[Token(Token = "0x602199B")]
		string GetCharId();

		// Token: 0x0602199C RID: 137628
		[Token(Token = "0x602199C")]
		bool IsOwned();

		// Token: 0x0602199D RID: 137629
		[Token(Token = "0x602199D")]
		CharacterData GetCharData();

		// Token: 0x0602199E RID: 137630
		[Token(Token = "0x602199E")]
		PlayerCharacter GetPlayerCharacter();

		// Token: 0x0602199F RID: 137631
		[Token(Token = "0x602199F")]
		bool IsClickable();
	}
}
