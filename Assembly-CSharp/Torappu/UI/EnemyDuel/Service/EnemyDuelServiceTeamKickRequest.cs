using System;
using Il2CppDummyDll;
using Torappu.DataStream;
using XLua;

namespace Torappu.UI.EnemyDuel.Service
{
	// Token: 0x02005073 RID: 20595
	[Token(Token = "0x2005073")]
	public class EnemyDuelServiceTeamKickRequest : EnemyDuelServiceTeamRequest
	{
		// Token: 0x17004746 RID: 18246
		// (get) Token: 0x0601E856 RID: 125014 RVA: 0x000AEAF8 File Offset: 0x000ACCF8
		[Token(Token = "0x17004746")]
		public override EnemyDuelServiceRequestID requestID
		{
			[Token(Token = "0x601E856")]
			[Address(RVA = "0x18481E0", Offset = "0x1846DE0", VA = "0x1818481E0", Slot = "5")]
			get
			{
				return (EnemyDuelServiceRequestID)0;
			}
		}

		// Token: 0x0601E857 RID: 125015 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E857")]
		[Address(RVA = "0x18480E0", Offset = "0x1846CE0", VA = "0x1818480E0", Slot = "7")]
		public override void Write(IStreamWriter to)
		{
		}

		// Token: 0x0601E858 RID: 125016 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E858")]
		[Address(RVA = "0x1848180", Offset = "0x1846D80", VA = "0x181848180")]
		public EnemyDuelServiceTeamKickRequest()
		{
		}

		// Token: 0x0601E859 RID: 125017 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E859")]
		[Address(RVA = "0x183FA10", Offset = "0x183E610", VA = "0x18183FA10")]
		private void <>xLuaBaseProxy_Write(IStreamWriter P0)
		{
		}

		// Token: 0x04028E0E RID: 167438
		[Token(Token = "0x4028E0E")]
		[FieldOffset(Offset = "0x10")]
		public string uid;

		// Token: 0x04028E0F RID: 167439
		[Token(Token = "0x4028E0F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_requestID;

		// Token: 0x04028E10 RID: 167440
		[Token(Token = "0x4028E10")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Write;

		// Token: 0x04028E11 RID: 167441
		[Token(Token = "0x4028E11")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
