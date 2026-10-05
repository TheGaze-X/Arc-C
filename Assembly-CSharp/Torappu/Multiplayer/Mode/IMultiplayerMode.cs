using System;
using Il2CppDummyDll;

namespace Torappu.Multiplayer.Mode
{
	// Token: 0x020015C9 RID: 5577
	[Token(Token = "0x20015C9")]
	public interface IMultiplayerMode : IHotfixable
	{
		// Token: 0x06007E68 RID: 32360
		[Token(Token = "0x6007E68")]
		void Init(MultiplayerMgr mgr);

		// Token: 0x06007E69 RID: 32361
		[Token(Token = "0x6007E69")]
		void Dispose();

		// Token: 0x06007E6A RID: 32362
		[Token(Token = "0x6007E6A")]
		void Update();

		// Token: 0x17000EFB RID: 3835
		// (get) Token: 0x06007E6B RID: 32363
		[Token(Token = "0x17000EFB")]
		string playerUID { [Token(Token = "0x6007E6B")] get; }

		// Token: 0x17000EFC RID: 3836
		// (get) Token: 0x06007E6C RID: 32364
		[Token(Token = "0x17000EFC")]
		TeamInfo teamInfo { [Token(Token = "0x6007E6C")] get; }

		// Token: 0x17000EFD RID: 3837
		// (get) Token: 0x06007E6D RID: 32365
		[Token(Token = "0x17000EFD")]
		BattleInfo battleInfo { [Token(Token = "0x6007E6D")] get; }

		// Token: 0x17000EFE RID: 3838
		// (get) Token: 0x06007E6E RID: 32366
		[Token(Token = "0x17000EFE")]
		int ping { [Token(Token = "0x6007E6E")] get; }

		// Token: 0x17000EFF RID: 3839
		// (get) Token: 0x06007E6F RID: 32367
		[Token(Token = "0x17000EFF")]
		DateTime currentTime { [Token(Token = "0x6007E6F")] get; }

		// Token: 0x17000F00 RID: 3840
		// (get) Token: 0x06007E70 RID: 32368
		[Token(Token = "0x17000F00")]
		object cachedUserInfoForBattle { [Token(Token = "0x6007E70")] get; }

		// Token: 0x06007E71 RID: 32369
		[Token(Token = "0x6007E71")]
		bool SendRequest(RequestType request, object param);
	}
}
