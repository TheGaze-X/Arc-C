using System;
using Il2CppDummyDll;
using Torappu.DataStream;
using XLua;

namespace Torappu.UI.EnemyDuel.Service
{
	// Token: 0x02005077 RID: 20599
	[Token(Token = "0x2005077")]
	public class EnemyDuelServiceTeamChangeAllowNpcRequest : EnemyDuelServiceTeamRequest
	{
		// Token: 0x1700474A RID: 18250
		// (get) Token: 0x0601E862 RID: 125026 RVA: 0x000AEB58 File Offset: 0x000ACD58
		[Token(Token = "0x1700474A")]
		public override EnemyDuelServiceRequestID requestID
		{
			[Token(Token = "0x601E862")]
			[Address(RVA = "0x1847D30", Offset = "0x1846930", VA = "0x181847D30", Slot = "5")]
			get
			{
				return (EnemyDuelServiceRequestID)0;
			}
		}

		// Token: 0x0601E863 RID: 125027 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E863")]
		[Address(RVA = "0x1847C40", Offset = "0x1846840", VA = "0x181847C40", Slot = "7")]
		public override void Write(IStreamWriter to)
		{
		}

		// Token: 0x0601E864 RID: 125028 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E864")]
		[Address(RVA = "0x1847CD0", Offset = "0x18468D0", VA = "0x181847CD0")]
		public EnemyDuelServiceTeamChangeAllowNpcRequest()
		{
		}

		// Token: 0x0601E865 RID: 125029 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E865")]
		[Address(RVA = "0x183FA10", Offset = "0x183E610", VA = "0x18183FA10")]
		private void <>xLuaBaseProxy_Write(IStreamWriter P0)
		{
		}

		// Token: 0x04028E1A RID: 167450
		[Token(Token = "0x4028E1A")]
		[FieldOffset(Offset = "0x10")]
		public bool allowNpc;

		// Token: 0x04028E1B RID: 167451
		[Token(Token = "0x4028E1B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_requestID;

		// Token: 0x04028E1C RID: 167452
		[Token(Token = "0x4028E1C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Write;

		// Token: 0x04028E1D RID: 167453
		[Token(Token = "0x4028E1D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
