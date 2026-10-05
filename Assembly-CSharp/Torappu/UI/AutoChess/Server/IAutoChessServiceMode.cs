using System;
using Il2CppDummyDll;
using Torappu.SocketNetwork.ServerBase;

namespace Torappu.UI.AutoChess.Server
{
	// Token: 0x020063D9 RID: 25561
	[Token(Token = "0x20063D9")]
	public interface IAutoChessServiceMode : IHotfixable
	{
		// Token: 0x1700570C RID: 22284
		// (get) Token: 0x06024D99 RID: 150937
		[Token(Token = "0x1700570C")]
		int ping { [Token(Token = "0x6024D99")] get; }

		// Token: 0x1700570D RID: 22285
		// (get) Token: 0x06024D9A RID: 150938
		[Token(Token = "0x1700570D")]
		DateTime currentTime { [Token(Token = "0x6024D9A")] get; }

		// Token: 0x1700570E RID: 22286
		// (get) Token: 0x06024D9B RID: 150939
		[Token(Token = "0x1700570E")]
		AutoChessServiceTeamInfo teamInfo { [Token(Token = "0x6024D9B")] get; }

		// Token: 0x1700570F RID: 22287
		// (get) Token: 0x06024D9C RID: 150940
		[Token(Token = "0x1700570F")]
		AutoChessServiceBattleInfo battleInfo { [Token(Token = "0x6024D9C")] get; }

		// Token: 0x06024D9D RID: 150941
		[Token(Token = "0x6024D9D")]
		void Init(IAutoChessServiceCore host);

		// Token: 0x06024D9E RID: 150942
		[Token(Token = "0x6024D9E")]
		void Dispose();

		// Token: 0x06024D9F RID: 150943
		[Token(Token = "0x6024D9F")]
		void Update();

		// Token: 0x06024DA0 RID: 150944
		[Token(Token = "0x6024DA0")]
		void SendRequest(RequestHandler request);

		// Token: 0x06024DA1 RID: 150945
		[Token(Token = "0x6024DA1")]
		void SendRequest(AutoChessServiceRequest request);

		// Token: 0x06024DA2 RID: 150946
		[Token(Token = "0x6024DA2")]
		TRequest RentRequestForSend<TRequest>() where TRequest : AutoChessServiceRequest, new();
	}
}
