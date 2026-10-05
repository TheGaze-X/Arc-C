using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.DataStream;
using XLua;

namespace Torappu.UI.EnemyDuel.Service
{
	// Token: 0x0200507B RID: 20603
	[Token(Token = "0x200507B")]
	public class EnemyDuelServiceBattleActionRequest : EnemyDuelServiceBattleRequest
	{
		// Token: 0x1700474E RID: 18254
		// (get) Token: 0x0601E86C RID: 125036 RVA: 0x000AEBB8 File Offset: 0x000ACDB8
		[Token(Token = "0x1700474E")]
		public override EnemyDuelServiceRequestID requestID
		{
			[Token(Token = "0x601E86C")]
			[Address(RVA = "0x183FB60", Offset = "0x183E760", VA = "0x18183FB60", Slot = "5")]
			get
			{
				return (EnemyDuelServiceRequestID)0;
			}
		}

		// Token: 0x0601E86D RID: 125037 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E86D")]
		[Address(RVA = "0x183FA70", Offset = "0x183E670", VA = "0x18183FA70", Slot = "7")]
		public override void Write(IStreamWriter to)
		{
		}

		// Token: 0x0601E86E RID: 125038 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E86E")]
		[Address(RVA = "0x183FB00", Offset = "0x183E700", VA = "0x18183FB00")]
		public EnemyDuelServiceBattleActionRequest()
		{
		}

		// Token: 0x0601E86F RID: 125039 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E86F")]
		[Address(RVA = "0x183FA10", Offset = "0x183E610", VA = "0x18183FA10")]
		private void <>xLuaBaseProxy_Write(IStreamWriter P0)
		{
		}

		// Token: 0x04028E24 RID: 167460
		[Token(Token = "0x4028E24")]
		[FieldOffset(Offset = "0x10")]
		public List<EnemyDuelServiceAction> actions;

		// Token: 0x04028E25 RID: 167461
		[Token(Token = "0x4028E25")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_requestID;

		// Token: 0x04028E26 RID: 167462
		[Token(Token = "0x4028E26")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Write;

		// Token: 0x04028E27 RID: 167463
		[Token(Token = "0x4028E27")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
