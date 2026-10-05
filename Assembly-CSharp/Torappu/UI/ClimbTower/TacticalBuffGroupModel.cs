using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005CE6 RID: 23782
	[Token(Token = "0x2005CE6")]
	public class TacticalBuffGroupModel : IHotfixable
	{
		// Token: 0x170050F4 RID: 20724
		// (get) Token: 0x060226EC RID: 141036 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170050F4")]
		public List<TacticalBuffModel> tacticalGroupList
		{
			[Token(Token = "0x60226EC")]
			[Address(RVA = "0x1CE16D0", Offset = "0x1CE02D0", VA = "0x181CE16D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170050F5 RID: 20725
		// (get) Token: 0x060226ED RID: 141037 RVA: 0x000BD678 File Offset: 0x000BB878
		[Token(Token = "0x170050F5")]
		public int totalStepCount
		{
			[Token(Token = "0x60226ED")]
			[Address(RVA = "0x1CE1730", Offset = "0x1CE0330", VA = "0x181CE1730")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170050F6 RID: 20726
		// (get) Token: 0x060226EE RID: 141038 RVA: 0x000BD690 File Offset: 0x000BB890
		[Token(Token = "0x170050F6")]
		public int currentStep
		{
			[Token(Token = "0x60226EE")]
			[Address(RVA = "0x1CE1670", Offset = "0x1CE0270", VA = "0x181CE1670")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060226EF RID: 141039 RVA: 0x000BD6A8 File Offset: 0x000BB8A8
		[Token(Token = "0x60226EF")]
		[Address(RVA = "0x1CE0F60", Offset = "0x1CDFB60", VA = "0x181CE0F60")]
		public bool CanToggleBuff()
		{
			return default(bool);
		}

		// Token: 0x060226F0 RID: 141040 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60226F0")]
		[Address(RVA = "0x1CE0FC0", Offset = "0x1CDFBC0", VA = "0x181CE0FC0")]
		public void InitData(PlayerTower towerPlayerData)
		{
		}

		// Token: 0x060226F1 RID: 141041 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60226F1")]
		[Address(RVA = "0x1CE1490", Offset = "0x1CE0090", VA = "0x181CE1490")]
		private string _GetSavedBuffIdByProfession(TowerTactical savedTactical, ProfessionCategory profession)
		{
			return null;
		}

		// Token: 0x060226F2 RID: 141042 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60226F2")]
		[Address(RVA = "0x1CE1340", Offset = "0x1CDFF40", VA = "0x181CE1340")]
		public void SelectBuff(ProfessionCategory profession)
		{
		}

		// Token: 0x060226F3 RID: 141043 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60226F3")]
		[Address(RVA = "0x1CE1610", Offset = "0x1CE0210", VA = "0x181CE1610")]
		public TacticalBuffGroupModel()
		{
		}

		// Token: 0x0402F52F RID: 193839
		[Token(Token = "0x402F52F")]
		[FieldOffset(Offset = "0x10")]
		private bool m_hasTowerPass;

		// Token: 0x0402F530 RID: 193840
		[Token(Token = "0x402F530")]
		[FieldOffset(Offset = "0x18")]
		private List<TacticalBuffModel> m_tacticalGroupList;

		// Token: 0x0402F531 RID: 193841
		[Token(Token = "0x402F531")]
		[FieldOffset(Offset = "0x20")]
		private int m_currentStep;

		// Token: 0x0402F532 RID: 193842
		[Token(Token = "0x402F532")]
		[FieldOffset(Offset = "0x24")]
		private int m_totalStepCount;

		// Token: 0x0402F533 RID: 193843
		[Token(Token = "0x402F533")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_tacticalGroupList;

		// Token: 0x0402F534 RID: 193844
		[Token(Token = "0x402F534")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_totalStepCount;

		// Token: 0x0402F535 RID: 193845
		[Token(Token = "0x402F535")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_currentStep;

		// Token: 0x0402F536 RID: 193846
		[Token(Token = "0x402F536")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_CanToggleBuff;

		// Token: 0x0402F537 RID: 193847
		[Token(Token = "0x402F537")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_InitData;

		// Token: 0x0402F538 RID: 193848
		[Token(Token = "0x402F538")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__GetSavedBuffIdByProfession;

		// Token: 0x0402F539 RID: 193849
		[Token(Token = "0x402F539")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_SelectBuff;

		// Token: 0x0402F53A RID: 193850
		[Token(Token = "0x402F53A")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
