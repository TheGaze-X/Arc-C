using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Setting
{
	// Token: 0x02001E0C RID: 7692
	[Token(Token = "0x2001E0C")]
	public class ProxyPowerSavingManager : Singleton<ProxyPowerSavingManager>
	{
		// Token: 0x0600BDD9 RID: 48601 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BDD9")]
		[Address(RVA = "0x33C8DE0", Offset = "0x33C79E0", VA = "0x1833C8DE0")]
		private ProxyPowerSavingManager()
		{
		}

		// Token: 0x0600BDDA RID: 48602 RVA: 0x00046548 File Offset: 0x00044748
		[Token(Token = "0x600BDDA")]
		[Address(RVA = "0x33C8800", Offset = "0x33C7400", VA = "0x1833C8800")]
		public bool GetPowerSavingStatus()
		{
			return default(bool);
		}

		// Token: 0x0600BDDB RID: 48603 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BDDB")]
		[Address(RVA = "0x33C8A70", Offset = "0x33C7670", VA = "0x1833C8A70")]
		public void SetPowerSavingStatus(bool value)
		{
		}

		// Token: 0x0600BDDC RID: 48604 RVA: 0x00046560 File Offset: 0x00044760
		[Token(Token = "0x600BDDC")]
		[Address(RVA = "0x33C88F0", Offset = "0x33C74F0", VA = "0x1833C88F0")]
		public bool GetProxyBattleStatus()
		{
			return default(bool);
		}

		// Token: 0x0600BDDD RID: 48605 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BDDD")]
		[Address(RVA = "0x33C8B00", Offset = "0x33C7700", VA = "0x1833C8B00")]
		private void _SendSetLowPowerRequest(bool isLowPower)
		{
		}

		// Token: 0x0600BDDE RID: 48606 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BDDE")]
		[Address(RVA = "0x33C8D30", Offset = "0x33C7930", VA = "0x1833C8D30")]
		private void _SyncFromPlayerData()
		{
		}

		// Token: 0x0400BE97 RID: 48791
		[Token(Token = "0x400BE97")]
		[FieldOffset(Offset = "0x10")]
		private bool m_openPowerSavingMode;

		// Token: 0x0400BE98 RID: 48792
		[Token(Token = "0x400BE98")]
		[FieldOffset(Offset = "0x18")]
		private long m_loginToken;

		// Token: 0x0400BE99 RID: 48793
		[Token(Token = "0x400BE99")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0400BE9A RID: 48794
		[Token(Token = "0x400BE9A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetPowerSavingStatus;

		// Token: 0x0400BE9B RID: 48795
		[Token(Token = "0x400BE9B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SetPowerSavingStatus;

		// Token: 0x0400BE9C RID: 48796
		[Token(Token = "0x400BE9C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetProxyBattleStatus;

		// Token: 0x0400BE9D RID: 48797
		[Token(Token = "0x400BE9D")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__SendSetLowPowerRequest;

		// Token: 0x0400BE9E RID: 48798
		[Token(Token = "0x400BE9E")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__SyncFromPlayerData;
	}
}
