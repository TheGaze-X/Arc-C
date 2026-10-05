using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.ActMultiV3
{
	// Token: 0x02006FA6 RID: 28582
	[Token(Token = "0x2006FA6")]
	public class ActMultiV3MatchModeGroupModel : IHotfixable
	{
		// Token: 0x17005FC3 RID: 24515
		// (get) Token: 0x06028968 RID: 166248 RVA: 0x000D23D8 File Offset: 0x000D05D8
		// (set) Token: 0x06028969 RID: 166249 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005FC3")]
		public ActMultiV3MapModeType modeType
		{
			[Token(Token = "0x6028968")]
			[Address(RVA = "0x23D85C0", Offset = "0x23D71C0", VA = "0x1823D85C0")]
			[CompilerGenerated]
			get
			{
				return ActMultiV3MapModeType.NONE;
			}
			[Token(Token = "0x6028969")]
			[Address(RVA = "0x23D8760", Offset = "0x23D7360", VA = "0x1823D8760")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005FC4 RID: 24516
		// (get) Token: 0x0602896A RID: 166250 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602896B RID: 166251 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005FC4")]
		public string color
		{
			[Token(Token = "0x602896A")]
			[Address(RVA = "0x23D8560", Offset = "0x23D7160", VA = "0x1823D8560")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x602896B")]
			[Address(RVA = "0x23D86E0", Offset = "0x23D72E0", VA = "0x1823D86E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005FC5 RID: 24517
		// (get) Token: 0x0602896C RID: 166252 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602896D RID: 166253 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005FC5")]
		public string name
		{
			[Token(Token = "0x602896C")]
			[Address(RVA = "0x23D8620", Offset = "0x23D7220", VA = "0x1823D8620")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x602896D")]
			[Address(RVA = "0x23D87D0", Offset = "0x23D73D0", VA = "0x1823D87D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005FC6 RID: 24518
		// (get) Token: 0x0602896E RID: 166254 RVA: 0x000D23F0 File Offset: 0x000D05F0
		// (set) Token: 0x0602896F RID: 166255 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005FC6")]
		public int sortId
		{
			[Token(Token = "0x602896E")]
			[Address(RVA = "0x23D8680", Offset = "0x23D7280", VA = "0x1823D8680")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x602896F")]
			[Address(RVA = "0x23D8850", Offset = "0x23D7450", VA = "0x1823D8850")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06028970 RID: 166256 RVA: 0x000D2408 File Offset: 0x000D0608
		[Token(Token = "0x6028970")]
		[Address(RVA = "0x23D7F10", Offset = "0x23D6B10", VA = "0x1823D7F10")]
		public bool TryGetDiffModel(string modeId, out ActMultiV3MatchModeDiffModel diffModel)
		{
			return default(bool);
		}

		// Token: 0x06028971 RID: 166257 RVA: 0x000D2420 File Offset: 0x000D0620
		[Token(Token = "0x6028971")]
		[Address(RVA = "0x23D77F0", Offset = "0x23D63F0", VA = "0x1823D77F0")]
		public bool FindNearestLockStage(long currTs, out string unlockTimeStr)
		{
			return default(bool);
		}

		// Token: 0x06028972 RID: 166258 RVA: 0x000D2438 File Offset: 0x000D0638
		[Token(Token = "0x6028972")]
		[Address(RVA = "0x23D76D0", Offset = "0x23D62D0", VA = "0x1823D76D0")]
		public bool CheckModeGroupUnlock(long currTs, out string unlockHint)
		{
			return default(bool);
		}

		// Token: 0x06028973 RID: 166259 RVA: 0x000D2450 File Offset: 0x000D0650
		[Token(Token = "0x6028973")]
		[Address(RVA = "0x23D7FC0", Offset = "0x23D6BC0", VA = "0x1823D7FC0")]
		public bool TryGetDiffModel(ActMultiV3MapDiffType diffType, out ActMultiV3MatchModeDiffModel targetModel)
		{
			return default(bool);
		}

		// Token: 0x06028974 RID: 166260 RVA: 0x000D2468 File Offset: 0x000D0668
		[Token(Token = "0x6028974")]
		[Address(RVA = "0x23D7540", Offset = "0x23D6140", VA = "0x1823D7540")]
		public bool CheckDiffSelect(List<string> selectList)
		{
			return default(bool);
		}

		// Token: 0x06028975 RID: 166261 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028975")]
		[Address(RVA = "0x23D7370", Offset = "0x23D5F70", VA = "0x1823D7370")]
		public void AddDefaultSelectToList(long currTs, List<string> selectList)
		{
		}

		// Token: 0x06028976 RID: 166262 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028976")]
		[Address(RVA = "0x23D7B70", Offset = "0x23D6770", VA = "0x1823D7B70")]
		public void LoadData(string actId, ActMultiV3Data actData, ActMultiV3MapModeData mapModeData)
		{
		}

		// Token: 0x06028977 RID: 166263 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028977")]
		[Address(RVA = "0x23D8150", Offset = "0x23D6D50", VA = "0x1823D8150")]
		public void UpdatePlayerData()
		{
		}

		// Token: 0x06028978 RID: 166264 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028978")]
		[Address(RVA = "0x23D8260", Offset = "0x23D6E60", VA = "0x1823D8260")]
		public void UpdateUnlockStatus(ActMultiV3QuickMatchModel matchModel)
		{
		}

		// Token: 0x06028979 RID: 166265 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028979")]
		[Address(RVA = "0x23D84A0", Offset = "0x23D70A0", VA = "0x1823D84A0")]
		public ActMultiV3MatchModeGroupModel()
		{
		}

		// Token: 0x04039CE5 RID: 236773
		[Token(Token = "0x4039CE5")]
		[FieldOffset(Offset = "0x10")]
		private Dictionary<string, ActMultiV3MatchModeDiffModel> m_diffDict;

		// Token: 0x04039CE6 RID: 236774
		[Token(Token = "0x4039CE6")]
		[FieldOffset(Offset = "0x18")]
		private long m_unlockTs;

		// Token: 0x04039CEB RID: 236779
		[Token(Token = "0x4039CEB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_modeType;

		// Token: 0x04039CEC RID: 236780
		[Token(Token = "0x4039CEC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_modeType;

		// Token: 0x04039CED RID: 236781
		[Token(Token = "0x4039CED")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_color;

		// Token: 0x04039CEE RID: 236782
		[Token(Token = "0x4039CEE")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_color;

		// Token: 0x04039CEF RID: 236783
		[Token(Token = "0x4039CEF")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_name;

		// Token: 0x04039CF0 RID: 236784
		[Token(Token = "0x4039CF0")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_name;

		// Token: 0x04039CF1 RID: 236785
		[Token(Token = "0x4039CF1")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_sortId;

		// Token: 0x04039CF2 RID: 236786
		[Token(Token = "0x4039CF2")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_set_sortId;

		// Token: 0x04039CF3 RID: 236787
		[Token(Token = "0x4039CF3")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_TryGetDiffModel;

		// Token: 0x04039CF4 RID: 236788
		[Token(Token = "0x4039CF4")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_FindNearestLockStage;

		// Token: 0x04039CF5 RID: 236789
		[Token(Token = "0x4039CF5")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_CheckModeGroupUnlock;

		// Token: 0x04039CF6 RID: 236790
		[Token(Token = "0x4039CF6")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix1_TryGetDiffModel;

		// Token: 0x04039CF7 RID: 236791
		[Token(Token = "0x4039CF7")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_CheckDiffSelect;

		// Token: 0x04039CF8 RID: 236792
		[Token(Token = "0x4039CF8")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_AddDefaultSelectToList;

		// Token: 0x04039CF9 RID: 236793
		[Token(Token = "0x4039CF9")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04039CFA RID: 236794
		[Token(Token = "0x4039CFA")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_UpdatePlayerData;

		// Token: 0x04039CFB RID: 236795
		[Token(Token = "0x4039CFB")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_UpdateUnlockStatus;

		// Token: 0x04039CFC RID: 236796
		[Token(Token = "0x4039CFC")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
