using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200056A RID: 1386
	[Token(Token = "0x200056A")]
	public interface IPlayerDataListener : IHotfixable
	{
		// Token: 0x06005B6D RID: 23405
		[Token(Token = "0x6005B6D")]
		bool CheckIfDataChanged(PlayerDataModel prevData, PlayerDataModel curData, PlayerDataDelta delta);

		// Token: 0x06005B6E RID: 23406
		[Token(Token = "0x6005B6E")]
		void OnPlayerDataChanged();
	}
}
