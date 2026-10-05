using System;
using Il2CppDummyDll;
using Torappu.UI.EnemyDuel.Service;

namespace Torappu.Battle.GameMode
{
	// Token: 0x020027FF RID: 10239
	[Token(Token = "0x20027FF")]
	public interface IEnemyDuelGameMode : IGameMode, IHotfixable
	{
		// Token: 0x0601100E RID: 69646
		[Token(Token = "0x601100E")]
		void SetPaused(bool isPaused);

		// Token: 0x0601100F RID: 69647
		[Token(Token = "0x601100F")]
		void SetPrepared();

		// Token: 0x06011010 RID: 69648
		[Token(Token = "0x6011010")]
		void SetReady();

		// Token: 0x06011011 RID: 69649
		[Token(Token = "0x6011011")]
		void SetPlaying();

		// Token: 0x06011012 RID: 69650
		[Token(Token = "0x6011012")]
		void SetUnstable();

		// Token: 0x06011013 RID: 69651
		[Token(Token = "0x6011013")]
		bool NextFrame(bool additional);

		// Token: 0x06011014 RID: 69652
		[Token(Token = "0x6011014")]
		void ApplyAction(EnemyDuelServiceAction action);

		// Token: 0x06011015 RID: 69653
		[Token(Token = "0x6011015")]
		void OnStateChanged(EnemyDuelBattleStatus status);

		// Token: 0x17002579 RID: 9593
		// (get) Token: 0x06011016 RID: 69654
		[Token(Token = "0x17002579")]
		bool isPrepared { [Token(Token = "0x6011016")] get; }

		// Token: 0x1700257A RID: 9594
		// (get) Token: 0x06011017 RID: 69655
		[Token(Token = "0x1700257A")]
		bool isRunning { [Token(Token = "0x6011017")] get; }
	}
}
