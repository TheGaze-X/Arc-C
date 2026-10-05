using System;
using Il2CppDummyDll;
using Torappu.DataStream;
using XLua;

namespace Torappu.UI.EnemyDuel.Service
{
	// Token: 0x0200507D RID: 20605
	[Token(Token = "0x200507D")]
	public class EnemyDuelServiceBattleRoundSettleRequest : EnemyDuelServiceBattleRequest
	{
		// Token: 0x17004750 RID: 18256
		// (get) Token: 0x0601E874 RID: 125044 RVA: 0x000AEBE8 File Offset: 0x000ACDE8
		[Token(Token = "0x17004750")]
		public override EnemyDuelServiceRequestID requestID
		{
			[Token(Token = "0x601E874")]
			[Address(RVA = "0x1843390", Offset = "0x1841F90", VA = "0x181843390", Slot = "5")]
			get
			{
				return (EnemyDuelServiceRequestID)0;
			}
		}

		// Token: 0x0601E875 RID: 125045 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E875")]
		[Address(RVA = "0x1843260", Offset = "0x1841E60", VA = "0x181843260", Slot = "7")]
		public override void Write(IStreamWriter to)
		{
		}

		// Token: 0x0601E876 RID: 125046 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E876")]
		[Address(RVA = "0x1843330", Offset = "0x1841F30", VA = "0x181843330")]
		public EnemyDuelServiceBattleRoundSettleRequest()
		{
		}

		// Token: 0x0601E877 RID: 125047 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E877")]
		[Address(RVA = "0x183FA10", Offset = "0x183E610", VA = "0x18183FA10")]
		private void <>xLuaBaseProxy_Write(IStreamWriter P0)
		{
		}

		// Token: 0x04028E2F RID: 167471
		[Token(Token = "0x4028E2F")]
		[FieldOffset(Offset = "0x10")]
		public int side;

		// Token: 0x04028E30 RID: 167472
		[Token(Token = "0x4028E30")]
		[FieldOffset(Offset = "0x14")]
		public bool finalSettle;

		// Token: 0x04028E31 RID: 167473
		[Token(Token = "0x4028E31")]
		[FieldOffset(Offset = "0x18")]
		public string info;

		// Token: 0x04028E32 RID: 167474
		[Token(Token = "0x4028E32")]
		[FieldOffset(Offset = "0x20")]
		public string infoHash;

		// Token: 0x04028E33 RID: 167475
		[Token(Token = "0x4028E33")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_requestID;

		// Token: 0x04028E34 RID: 167476
		[Token(Token = "0x4028E34")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Write;

		// Token: 0x04028E35 RID: 167477
		[Token(Token = "0x4028E35")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
