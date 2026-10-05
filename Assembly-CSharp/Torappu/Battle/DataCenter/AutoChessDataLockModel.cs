using System;
using Il2CppDummyDll;
using Torappu.Battle.AutoChess;
using XLua;

namespace Torappu.Battle.DataCenter
{
	// Token: 0x020026F7 RID: 9975
	[Token(Token = "0x20026F7")]
	public class AutoChessDataLockModel : AutoChessDataCenter.AutoChessDataModelBase, AutoChessDataCenter.AutoChessDataModelIgnoreLock
	{
		// Token: 0x1700237F RID: 9087
		// (get) Token: 0x06010392 RID: 66450 RVA: 0x00062F28 File Offset: 0x00061128
		[Token(Token = "0x1700237F")]
		public bool locked
		{
			[Token(Token = "0x6010392")]
			[Address(RVA = "0x7E1B60", Offset = "0x7E0760", VA = "0x1807E1B60")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06010393 RID: 66451 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010393")]
		[Address(RVA = "0x7E1570", Offset = "0x7E0170", VA = "0x1807E1570")]
		public void UpdateData(SettleData settleData)
		{
		}

		// Token: 0x06010394 RID: 66452 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010394")]
		[Address(RVA = "0x7E15F0", Offset = "0x7E01F0", VA = "0x1807E15F0")]
		public void UpdateState()
		{
		}

		// Token: 0x06010395 RID: 66453 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010395")]
		[Address(RVA = "0x7E1860", Offset = "0x7E0460", VA = "0x1807E1860")]
		private void _RefreshSelfPlayerState(AutoChessPlayerDataModel playerDataModel)
		{
		}

		// Token: 0x06010396 RID: 66454 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010396")]
		[Address(RVA = "0x7E19C0", Offset = "0x7E05C0", VA = "0x1807E19C0")]
		private void _SetAutoChessDataLock(string key, bool isEnable)
		{
		}

		// Token: 0x06010397 RID: 66455 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010397")]
		[Address(RVA = "0x7E1A70", Offset = "0x7E0670", VA = "0x1807E1A70")]
		public AutoChessDataLockModel()
		{
		}

		// Token: 0x0401225E RID: 74334
		[Token(Token = "0x401225E")]
		private const string PLAYER_DEAD_STATE_LOCK_KEY = "player_dead_no_ob";

		// Token: 0x0401225F RID: 74335
		[Token(Token = "0x401225F")]
		[FieldOffset(Offset = "0x18")]
		private bool m_enable;

		// Token: 0x04012260 RID: 74336
		[Token(Token = "0x4012260")]
		[FieldOffset(Offset = "0x20")]
		private EnableStateWithKey m_dataLocker;

		// Token: 0x04012261 RID: 74337
		[Token(Token = "0x4012261")]
		[FieldOffset(Offset = "0x28")]
		public bool lockedOnPlayerDead;

		// Token: 0x04012262 RID: 74338
		[Token(Token = "0x4012262")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_locked;

		// Token: 0x04012263 RID: 74339
		[Token(Token = "0x4012263")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateData;

		// Token: 0x04012264 RID: 74340
		[Token(Token = "0x4012264")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_UpdateState;

		// Token: 0x04012265 RID: 74341
		[Token(Token = "0x4012265")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__RefreshSelfPlayerState;

		// Token: 0x04012266 RID: 74342
		[Token(Token = "0x4012266")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__SetAutoChessDataLock;

		// Token: 0x04012267 RID: 74343
		[Token(Token = "0x4012267")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
