using System;
using Il2CppDummyDll;
using Torappu.DataStream;
using XLua;

namespace Torappu.UI.EnemyDuel.Service
{
	// Token: 0x02005074 RID: 20596
	[Token(Token = "0x2005074")]
	public class EnemyDuelServiceTeamGetNameCardRequest : EnemyDuelServiceTeamRequest
	{
		// Token: 0x17004747 RID: 18247
		// (get) Token: 0x0601E85A RID: 125018 RVA: 0x000AEB10 File Offset: 0x000ACD10
		[Token(Token = "0x17004747")]
		public override EnemyDuelServiceRequestID requestID
		{
			[Token(Token = "0x601E85A")]
			[Address(RVA = "0x1847F50", Offset = "0x1846B50", VA = "0x181847F50", Slot = "5")]
			get
			{
				return (EnemyDuelServiceRequestID)0;
			}
		}

		// Token: 0x0601E85B RID: 125019 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E85B")]
		[Address(RVA = "0x1847E50", Offset = "0x1846A50", VA = "0x181847E50", Slot = "7")]
		public override void Write(IStreamWriter to)
		{
		}

		// Token: 0x0601E85C RID: 125020 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E85C")]
		[Address(RVA = "0x1847EF0", Offset = "0x1846AF0", VA = "0x181847EF0")]
		public EnemyDuelServiceTeamGetNameCardRequest()
		{
		}

		// Token: 0x0601E85D RID: 125021 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E85D")]
		[Address(RVA = "0x183FA10", Offset = "0x183E610", VA = "0x18183FA10")]
		private void <>xLuaBaseProxy_Write(IStreamWriter P0)
		{
		}

		// Token: 0x04028E12 RID: 167442
		[Token(Token = "0x4028E12")]
		[FieldOffset(Offset = "0x10")]
		public string uid;

		// Token: 0x04028E13 RID: 167443
		[Token(Token = "0x4028E13")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_requestID;

		// Token: 0x04028E14 RID: 167444
		[Token(Token = "0x4028E14")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Write;

		// Token: 0x04028E15 RID: 167445
		[Token(Token = "0x4028E15")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
