using System;
using Il2CppDummyDll;
using Torappu.Multiplayer;

namespace Torappu.Battle.GameMode
{
	// Token: 0x02002802 RID: 10242
	[Token(Token = "0x2002802")]
	public interface IMultiplayerGameMode : IGameMode, IHotfixable
	{
		// Token: 0x0601108E RID: 69774
		[Token(Token = "0x601108E")]
		void SetPrepared();

		// Token: 0x0601108F RID: 69775
		[Token(Token = "0x601108F")]
		void SetReady();

		// Token: 0x06011090 RID: 69776
		[Token(Token = "0x6011090")]
		void SetPlaying();

		// Token: 0x06011091 RID: 69777
		[Token(Token = "0x6011091")]
		void SetUnstable();

		// Token: 0x06011092 RID: 69778
		[Token(Token = "0x6011092")]
		bool NextFrame(bool additional);

		// Token: 0x06011093 RID: 69779
		[Token(Token = "0x6011093")]
		void ApplyOprt(PlayerOprtData oprt);

		// Token: 0x1700258D RID: 9613
		// (get) Token: 0x06011094 RID: 69780
		[Token(Token = "0x1700258D")]
		bool isPrepared { [Token(Token = "0x6011094")] get; }

		// Token: 0x1700258E RID: 9614
		// (get) Token: 0x06011095 RID: 69781
		[Token(Token = "0x1700258E")]
		bool isRunning { [Token(Token = "0x6011095")] get; }
	}
}
