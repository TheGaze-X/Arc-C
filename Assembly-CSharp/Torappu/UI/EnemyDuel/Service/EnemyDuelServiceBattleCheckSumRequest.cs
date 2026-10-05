using System;
using Il2CppDummyDll;
using Torappu.DataStream;
using XLua;

namespace Torappu.UI.EnemyDuel.Service
{
	// Token: 0x02005080 RID: 20608
	[Token(Token = "0x2005080")]
	public class EnemyDuelServiceBattleCheckSumRequest : EnemyDuelServiceBattleRequest
	{
		// Token: 0x17004753 RID: 18259
		// (get) Token: 0x0601E87E RID: 125054 RVA: 0x000AEC30 File Offset: 0x000ACE30
		[Token(Token = "0x17004753")]
		public override EnemyDuelServiceRequestID requestID
		{
			[Token(Token = "0x601E87E")]
			[Address(RVA = "0x183FF10", Offset = "0x183EB10", VA = "0x18183FF10", Slot = "5")]
			get
			{
				return (EnemyDuelServiceRequestID)0;
			}
		}

		// Token: 0x0601E87F RID: 125055 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E87F")]
		[Address(RVA = "0x183FE00", Offset = "0x183EA00", VA = "0x18183FE00", Slot = "7")]
		public override void Write(IStreamWriter to)
		{
		}

		// Token: 0x0601E880 RID: 125056 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E880")]
		[Address(RVA = "0x183FEB0", Offset = "0x183EAB0", VA = "0x18183FEB0")]
		public EnemyDuelServiceBattleCheckSumRequest()
		{
		}

		// Token: 0x0601E881 RID: 125057 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E881")]
		[Address(RVA = "0x183FA10", Offset = "0x183E610", VA = "0x18183FA10")]
		private void <>xLuaBaseProxy_Write(IStreamWriter P0)
		{
		}

		// Token: 0x04028E3D RID: 167485
		[Token(Token = "0x4028E3D")]
		[FieldOffset(Offset = "0x10")]
		public int seq;

		// Token: 0x04028E3E RID: 167486
		[Token(Token = "0x4028E3E")]
		[FieldOffset(Offset = "0x14")]
		public uint checkSum;

		// Token: 0x04028E3F RID: 167487
		[Token(Token = "0x4028E3F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_requestID;

		// Token: 0x04028E40 RID: 167488
		[Token(Token = "0x4028E40")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Write;

		// Token: 0x04028E41 RID: 167489
		[Token(Token = "0x4028E41")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
