using System;
using Il2CppDummyDll;
using Torappu.Battle.EnemyDuel;
using Torappu.DataStream;
using XLua;

namespace Torappu.UI.EnemyDuel.Service
{
	// Token: 0x0200507C RID: 20604
	[Token(Token = "0x200507C")]
	public class EnemyDuelServiceBattleBetRequest : EnemyDuelServiceBattleRequest
	{
		// Token: 0x1700474F RID: 18255
		// (get) Token: 0x0601E870 RID: 125040 RVA: 0x000AEBD0 File Offset: 0x000ACDD0
		[Token(Token = "0x1700474F")]
		public override EnemyDuelServiceRequestID requestID
		{
			[Token(Token = "0x601E870")]
			[Address(RVA = "0x183FDA0", Offset = "0x183E9A0", VA = "0x18183FDA0", Slot = "5")]
			get
			{
				return (EnemyDuelServiceRequestID)0;
			}
		}

		// Token: 0x0601E871 RID: 125041 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E871")]
		[Address(RVA = "0x183FBC0", Offset = "0x183E7C0", VA = "0x18183FBC0", Slot = "7")]
		public override void Write(IStreamWriter to)
		{
		}

		// Token: 0x0601E872 RID: 125042 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E872")]
		[Address(RVA = "0x183FD40", Offset = "0x183E940", VA = "0x18183FD40")]
		public EnemyDuelServiceBattleBetRequest()
		{
		}

		// Token: 0x0601E873 RID: 125043 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E873")]
		[Address(RVA = "0x183FA10", Offset = "0x183E610", VA = "0x18183FA10")]
		private void <>xLuaBaseProxy_Write(IStreamWriter P0)
		{
		}

		// Token: 0x04028E28 RID: 167464
		[Token(Token = "0x4028E28")]
		[FieldOffset(Offset = "0x10")]
		public string id;

		// Token: 0x04028E29 RID: 167465
		[Token(Token = "0x4028E29")]
		[FieldOffset(Offset = "0x18")]
		public EnemyDuelChoiceSide side;

		// Token: 0x04028E2A RID: 167466
		[Token(Token = "0x4028E2A")]
		[FieldOffset(Offset = "0x1C")]
		public bool isPlayer;

		// Token: 0x04028E2B RID: 167467
		[Token(Token = "0x4028E2B")]
		[FieldOffset(Offset = "0x1D")]
		public bool allin;

		// Token: 0x04028E2C RID: 167468
		[Token(Token = "0x4028E2C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_requestID;

		// Token: 0x04028E2D RID: 167469
		[Token(Token = "0x4028E2D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Write;

		// Token: 0x04028E2E RID: 167470
		[Token(Token = "0x4028E2E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
