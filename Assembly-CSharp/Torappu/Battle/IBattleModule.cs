using System;
using Il2CppDummyDll;

namespace Torappu.Battle
{
	// Token: 0x0200221C RID: 8732
	[Token(Token = "0x200221C")]
	public interface IBattleModule
	{
		// Token: 0x0600DBE7 RID: 56295
		[Token(Token = "0x600DBE7")]
		void OnGameReset(BattleController controller);

		// Token: 0x0600DBE8 RID: 56296
		[Token(Token = "0x600DBE8")]
		void OnGameInit(LevelData.Options levelOptions);

		// Token: 0x0600DBE9 RID: 56297
		[Token(Token = "0x600DBE9")]
		void OnGameReady();

		// Token: 0x0600DBEA RID: 56298
		[Token(Token = "0x600DBEA")]
		void OnGameStart();

		// Token: 0x0600DBEB RID: 56299
		[Token(Token = "0x600DBEB")]
		void OnGameOver(BattleController.GameResult result);
	}
}
