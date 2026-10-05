using System;
using Il2CppDummyDll;
using Torappu.DataStream;
using XLua;

namespace Torappu.UI.EnemyDuel.Service
{
	// Token: 0x0200507F RID: 20607
	[Token(Token = "0x200507F")]
	public class EnemyDuelServiceBattleEmotionRequest : EnemyDuelServiceBattleRequest
	{
		// Token: 0x17004752 RID: 18258
		// (get) Token: 0x0601E87A RID: 125050 RVA: 0x000AEC18 File Offset: 0x000ACE18
		[Token(Token = "0x17004752")]
		public override EnemyDuelServiceRequestID requestID
		{
			[Token(Token = "0x601E87A")]
			[Address(RVA = "0x1840080", Offset = "0x183EC80", VA = "0x181840080", Slot = "5")]
			get
			{
				return (EnemyDuelServiceRequestID)0;
			}
		}

		// Token: 0x0601E87B RID: 125051 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E87B")]
		[Address(RVA = "0x183FF70", Offset = "0x183EB70", VA = "0x18183FF70", Slot = "7")]
		public override void Write(IStreamWriter to)
		{
		}

		// Token: 0x0601E87C RID: 125052 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E87C")]
		[Address(RVA = "0x1840020", Offset = "0x183EC20", VA = "0x181840020")]
		public EnemyDuelServiceBattleEmotionRequest()
		{
		}

		// Token: 0x0601E87D RID: 125053 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E87D")]
		[Address(RVA = "0x183FA10", Offset = "0x183E610", VA = "0x18183FA10")]
		private void <>xLuaBaseProxy_Write(IStreamWriter P0)
		{
		}

		// Token: 0x04028E38 RID: 167480
		[Token(Token = "0x4028E38")]
		[FieldOffset(Offset = "0x10")]
		public string emojiGroup;

		// Token: 0x04028E39 RID: 167481
		[Token(Token = "0x4028E39")]
		[FieldOffset(Offset = "0x18")]
		public string emojiId;

		// Token: 0x04028E3A RID: 167482
		[Token(Token = "0x4028E3A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_requestID;

		// Token: 0x04028E3B RID: 167483
		[Token(Token = "0x4028E3B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Write;

		// Token: 0x04028E3C RID: 167484
		[Token(Token = "0x4028E3C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
