using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.EnemyDuel.Service.Mode
{
	// Token: 0x0200509E RID: 20638
	[Token(Token = "0x200509E")]
	public class EnemyDuelServiceSingleMode : IEnemyDuelServiceMode, IHotfixable
	{
		// Token: 0x1700475E RID: 18270
		// (get) Token: 0x0601E8E0 RID: 125152 RVA: 0x000AED68 File Offset: 0x000ACF68
		[Token(Token = "0x1700475E")]
		public int ping
		{
			[Token(Token = "0x601E8E0")]
			[Address(RVA = "0x18477B0", Offset = "0x18463B0", VA = "0x1818477B0", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700475F RID: 18271
		// (get) Token: 0x0601E8E1 RID: 125153 RVA: 0x000AED80 File Offset: 0x000ACF80
		[Token(Token = "0x1700475F")]
		public DateTime currentTime
		{
			[Token(Token = "0x601E8E1")]
			[Address(RVA = "0x1847730", Offset = "0x1846330", VA = "0x181847730", Slot = "5")]
			get
			{
				return default(DateTime);
			}
		}

		// Token: 0x17004760 RID: 18272
		// (get) Token: 0x0601E8E2 RID: 125154 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601E8E3 RID: 125155 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004760")]
		public EnemyDuelServiceTeamInfo teamInfo
		{
			[Token(Token = "0x601E8E2")]
			[Address(RVA = "0x1847810", Offset = "0x1846410", VA = "0x181847810", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601E8E3")]
			[Address(RVA = "0x18478F0", Offset = "0x18464F0", VA = "0x1818478F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17004761 RID: 18273
		// (get) Token: 0x0601E8E4 RID: 125156 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601E8E5 RID: 125157 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004761")]
		public EnemyDuelServiceBattleInfo battleInfo
		{
			[Token(Token = "0x601E8E4")]
			[Address(RVA = "0x18476D0", Offset = "0x18462D0", VA = "0x1818476D0", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601E8E5")]
			[Address(RVA = "0x1847870", Offset = "0x1846470", VA = "0x181847870")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0601E8E6 RID: 125158 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E8E6")]
		[Address(RVA = "0x1845430", Offset = "0x1844030", VA = "0x181845430", Slot = "8")]
		public void Init(IEnemyDuelServiceCore host)
		{
		}

		// Token: 0x0601E8E7 RID: 125159 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E8E7")]
		[Address(RVA = "0x18453D0", Offset = "0x1843FD0", VA = "0x1818453D0", Slot = "9")]
		public void Dispose()
		{
		}

		// Token: 0x0601E8E8 RID: 125160 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E8E8")]
		[Address(RVA = "0x18459F0", Offset = "0x18445F0", VA = "0x1818459F0")]
		public void Start(SingleBattleEntry entry)
		{
		}

		// Token: 0x0601E8E9 RID: 125161 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E8E9")]
		[Address(RVA = "0x1846090", Offset = "0x1844C90", VA = "0x181846090", Slot = "10")]
		public void Update()
		{
		}

		// Token: 0x0601E8EA RID: 125162 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E8EA")]
		[Address(RVA = "0x1845930", Offset = "0x1844530", VA = "0x181845930", Slot = "11")]
		public void SendRequest(EnemyDuelServiceRequest request)
		{
		}

		// Token: 0x0601E8EB RID: 125163 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E8EB")]
		[Address(RVA = "0x1846510", Offset = "0x1845110", VA = "0x181846510")]
		private void _ChangeToEntry()
		{
		}

		// Token: 0x0601E8EC RID: 125164 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E8EC")]
		[Address(RVA = "0x18463C0", Offset = "0x1844FC0", VA = "0x1818463C0")]
		private void _ChangeToBet()
		{
		}

		// Token: 0x0601E8ED RID: 125165 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E8ED")]
		[Address(RVA = "0x1846320", Offset = "0x1844F20", VA = "0x181846320")]
		private void _ChangeToBattle()
		{
		}

		// Token: 0x0601E8EE RID: 125166 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E8EE")]
		[Address(RVA = "0x18468B0", Offset = "0x18454B0", VA = "0x1818468B0")]
		private void _ChangeToRoundSettle(bool auto)
		{
		}

		// Token: 0x0601E8EF RID: 125167 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E8EF")]
		[Address(RVA = "0x1846830", Offset = "0x1845430", VA = "0x181846830")]
		private void _ChangeToFinish()
		{
		}

		// Token: 0x0601E8F0 RID: 125168 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E8F0")]
		[Address(RVA = "0x18473A0", Offset = "0x1845FA0", VA = "0x1818473A0")]
		private void _UpdateBattleStatus()
		{
		}

		// Token: 0x0601E8F1 RID: 125169 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E8F1")]
		[Address(RVA = "0x18475C0", Offset = "0x18461C0", VA = "0x1818475C0")]
		private void _UpdateEndTs(float hours, float minutes, float second)
		{
		}

		// Token: 0x0601E8F2 RID: 125170 RVA: 0x000AED98 File Offset: 0x000ACF98
		[Token(Token = "0x601E8F2")]
		[Address(RVA = "0x1846CC0", Offset = "0x18458C0", VA = "0x181846CC0")]
		private int _GenRandSeed()
		{
			return 0;
		}

		// Token: 0x0601E8F3 RID: 125171 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E8F3")]
		[Address(RVA = "0x1846A00", Offset = "0x1845600", VA = "0x181846A00")]
		private void _CloseService()
		{
		}

		// Token: 0x0601E8F4 RID: 125172 RVA: 0x000AEDB0 File Offset: 0x000ACFB0
		[Token(Token = "0x601E8F4")]
		[Address(RVA = "0x1846B80", Offset = "0x1845780", VA = "0x181846B80")]
		private long _GenFutureTs(float hours, float minutes, float second)
		{
			return 0L;
		}

		// Token: 0x0601E8F5 RID: 125173 RVA: 0x000AEDC8 File Offset: 0x000ACFC8
		[Token(Token = "0x601E8F5")]
		[Address(RVA = "0x1847290", Offset = "0x1845E90", VA = "0x181847290")]
		private bool _HandleGameReady(EnemyDuelServiceBattleReadyRequest request)
		{
			return default(bool);
		}

		// Token: 0x0601E8F6 RID: 125174 RVA: 0x000AEDE0 File Offset: 0x000ACFE0
		[Token(Token = "0x601E8F6")]
		[Address(RVA = "0x1846D30", Offset = "0x1845930", VA = "0x181846D30")]
		private bool _HandleBet(EnemyDuelServiceBattleBetRequest request)
		{
			return default(bool);
		}

		// Token: 0x0601E8F7 RID: 125175 RVA: 0x000AEDF8 File Offset: 0x000ACFF8
		[Token(Token = "0x601E8F7")]
		[Address(RVA = "0x1847310", Offset = "0x1845F10", VA = "0x181847310")]
		private bool _HandleRoundSettle(EnemyDuelServiceBattleRoundSettleRequest request)
		{
			return default(bool);
		}

		// Token: 0x0601E8F8 RID: 125176 RVA: 0x000AEE10 File Offset: 0x000AD010
		[Token(Token = "0x601E8F8")]
		[Address(RVA = "0x1847110", Offset = "0x1845D10", VA = "0x181847110")]
		private bool _HandleFinalSettle(EnemyDuelServiceBattleFinalSettleRequest request)
		{
			return default(bool);
		}

		// Token: 0x0601E8F9 RID: 125177 RVA: 0x000AEE28 File Offset: 0x000AD028
		[Token(Token = "0x601E8F9")]
		[Address(RVA = "0x1846F80", Offset = "0x1845B80", VA = "0x181846F80")]
		private bool _HandleEmotion(EnemyDuelServiceBattleEmotionRequest request)
		{
			return default(bool);
		}

		// Token: 0x0601E8FA RID: 125178 RVA: 0x000AEE40 File Offset: 0x000AD040
		[Token(Token = "0x601E8FA")]
		[Address(RVA = "0x18471E0", Offset = "0x1845DE0", VA = "0x1818471E0")]
		private bool _HandleGameQuit(EnemyDuelServiceBattleQuitRequest request)
		{
			return default(bool);
		}

		// Token: 0x0601E8FB RID: 125179 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E8FB")]
		[Address(RVA = "0x1847670", Offset = "0x1846270", VA = "0x181847670")]
		public EnemyDuelServiceSingleMode()
		{
		}

		// Token: 0x04028F07 RID: 167687
		[Token(Token = "0x4028F07")]
		[FieldOffset(Offset = "0x10")]
		private IEnemyDuelServiceCore m_serviceCore;

		// Token: 0x04028F0A RID: 167690
		[Token(Token = "0x4028F0A")]
		[FieldOffset(Offset = "0x28")]
		private ActivityEnemyDuelData m_actData;

		// Token: 0x04028F0B RID: 167691
		[Token(Token = "0x4028F0B")]
		[FieldOffset(Offset = "0x30")]
		private EnemyDuelBattleStatus m_battleStatus;

		// Token: 0x04028F0C RID: 167692
		[Token(Token = "0x4028F0C")]
		[FieldOffset(Offset = "0x58")]
		private EnemyDuelServiceRequestHandler m_handlers;

		// Token: 0x04028F0D RID: 167693
		[Token(Token = "0x4028F0D")]
		[FieldOffset(Offset = "0x60")]
		private long m_forEndTime;

		// Token: 0x04028F0E RID: 167694
		[Token(Token = "0x4028F0E")]
		[FieldOffset(Offset = "0x68")]
		private string playerId;

		// Token: 0x04028F0F RID: 167695
		[Token(Token = "0x4028F0F")]
		[FieldOffset(Offset = "0x70")]
		private int m_remainRoundCnt;

		// Token: 0x04028F10 RID: 167696
		[Token(Token = "0x4028F10")]
		[FieldOffset(Offset = "0x74")]
		private bool m_isFinalSettle;

		// Token: 0x04028F11 RID: 167697
		[Token(Token = "0x4028F11")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_ping;

		// Token: 0x04028F12 RID: 167698
		[Token(Token = "0x4028F12")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_currentTime;

		// Token: 0x04028F13 RID: 167699
		[Token(Token = "0x4028F13")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_teamInfo;

		// Token: 0x04028F14 RID: 167700
		[Token(Token = "0x4028F14")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_teamInfo;

		// Token: 0x04028F15 RID: 167701
		[Token(Token = "0x4028F15")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_battleInfo;

		// Token: 0x04028F16 RID: 167702
		[Token(Token = "0x4028F16")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_battleInfo;

		// Token: 0x04028F17 RID: 167703
		[Token(Token = "0x4028F17")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04028F18 RID: 167704
		[Token(Token = "0x4028F18")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_Dispose;

		// Token: 0x04028F19 RID: 167705
		[Token(Token = "0x4028F19")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_Start;

		// Token: 0x04028F1A RID: 167706
		[Token(Token = "0x4028F1A")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x04028F1B RID: 167707
		[Token(Token = "0x4028F1B")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_SendRequest;

		// Token: 0x04028F1C RID: 167708
		[Token(Token = "0x4028F1C")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__ChangeToEntry;

		// Token: 0x04028F1D RID: 167709
		[Token(Token = "0x4028F1D")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__ChangeToBet;

		// Token: 0x04028F1E RID: 167710
		[Token(Token = "0x4028F1E")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__ChangeToBattle;

		// Token: 0x04028F1F RID: 167711
		[Token(Token = "0x4028F1F")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__ChangeToRoundSettle;

		// Token: 0x04028F20 RID: 167712
		[Token(Token = "0x4028F20")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__ChangeToFinish;

		// Token: 0x04028F21 RID: 167713
		[Token(Token = "0x4028F21")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__UpdateBattleStatus;

		// Token: 0x04028F22 RID: 167714
		[Token(Token = "0x4028F22")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__UpdateEndTs;

		// Token: 0x04028F23 RID: 167715
		[Token(Token = "0x4028F23")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__GenRandSeed;

		// Token: 0x04028F24 RID: 167716
		[Token(Token = "0x4028F24")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__CloseService;

		// Token: 0x04028F25 RID: 167717
		[Token(Token = "0x4028F25")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__GenFutureTs;

		// Token: 0x04028F26 RID: 167718
		[Token(Token = "0x4028F26")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__HandleGameReady;

		// Token: 0x04028F27 RID: 167719
		[Token(Token = "0x4028F27")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__HandleBet;

		// Token: 0x04028F28 RID: 167720
		[Token(Token = "0x4028F28")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__HandleRoundSettle;

		// Token: 0x04028F29 RID: 167721
		[Token(Token = "0x4028F29")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0__HandleFinalSettle;

		// Token: 0x04028F2A RID: 167722
		[Token(Token = "0x4028F2A")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0__HandleEmotion;

		// Token: 0x04028F2B RID: 167723
		[Token(Token = "0x4028F2B")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0__HandleGameQuit;

		// Token: 0x04028F2C RID: 167724
		[Token(Token = "0x4028F2C")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
