using System;
using Il2CppDummyDll;

namespace Torappu.UI.Home.Activity
{
	// Token: 0x02004C94 RID: 19604
	[Token(Token = "0x2004C94")]
	public interface ICheckinItemData
	{
		// Token: 0x0601D61B RID: 120347
		[Token(Token = "0x601D61B")]
		bool IsEmpty();

		// Token: 0x0601D61C RID: 120348
		[Token(Token = "0x601D61C")]
		int GetColorId();

		// Token: 0x0601D61D RID: 120349
		[Token(Token = "0x601D61D")]
		OpenServerItemData GetOpenServerItemData();

		// Token: 0x0601D61E RID: 120350
		[Token(Token = "0x601D61E")]
		OpenServerCheckinItemState GetCheckinState();
	}
}
