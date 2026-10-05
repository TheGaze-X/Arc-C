using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020005FD RID: 1533
	[Token(Token = "0x20005FD")]
	public interface ISharedItemModel
	{
		// Token: 0x06006207 RID: 25095
		[Token(Token = "0x6006207")]
		ItemType GetItemType();

		// Token: 0x06006208 RID: 25096
		[Token(Token = "0x6006208")]
		string GetItemId();

		// Token: 0x06006209 RID: 25097
		[Token(Token = "0x6006209")]
		int GetItemCount();

		// Token: 0x0600620A RID: 25098
		[Token(Token = "0x600620A")]
		void SetItemCount(int count);
	}
}
