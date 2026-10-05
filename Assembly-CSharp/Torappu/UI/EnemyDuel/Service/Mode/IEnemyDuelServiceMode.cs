using System;
using Il2CppDummyDll;

namespace Torappu.UI.EnemyDuel.Service.Mode
{
	// Token: 0x020050A0 RID: 20640
	[Token(Token = "0x20050A0")]
	public interface IEnemyDuelServiceMode : IHotfixable
	{
		// Token: 0x17004762 RID: 18274
		// (get) Token: 0x0601E8FE RID: 125182
		[Token(Token = "0x17004762")]
		int ping { [Token(Token = "0x601E8FE")] get; }

		// Token: 0x17004763 RID: 18275
		// (get) Token: 0x0601E8FF RID: 125183
		[Token(Token = "0x17004763")]
		DateTime currentTime { [Token(Token = "0x601E8FF")] get; }

		// Token: 0x17004764 RID: 18276
		// (get) Token: 0x0601E900 RID: 125184
		[Token(Token = "0x17004764")]
		EnemyDuelServiceTeamInfo teamInfo { [Token(Token = "0x601E900")] get; }

		// Token: 0x17004765 RID: 18277
		// (get) Token: 0x0601E901 RID: 125185
		[Token(Token = "0x17004765")]
		EnemyDuelServiceBattleInfo battleInfo { [Token(Token = "0x601E901")] get; }

		// Token: 0x0601E902 RID: 125186
		[Token(Token = "0x601E902")]
		void Init(IEnemyDuelServiceCore host);

		// Token: 0x0601E903 RID: 125187
		[Token(Token = "0x601E903")]
		void Dispose();

		// Token: 0x0601E904 RID: 125188
		[Token(Token = "0x601E904")]
		void Update();

		// Token: 0x0601E905 RID: 125189
		[Token(Token = "0x601E905")]
		void SendRequest(EnemyDuelServiceRequest request);
	}
}
