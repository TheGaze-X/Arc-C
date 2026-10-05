using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x0200434A RID: 17226
	[Token(Token = "0x200434A")]
	public class SandboxV2LogisticsCharViewModel : IHotfixable, IComparable<SandboxV2LogisticsCharViewModel>
	{
		// Token: 0x17003EC6 RID: 16070
		// (get) Token: 0x0601A737 RID: 108343 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003EC6")]
		public string charName
		{
			[Token(Token = "0x601A737")]
			[Address(RVA = "0x1387110", Offset = "0x1385D10", VA = "0x181387110")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003EC7 RID: 16071
		// (get) Token: 0x0601A738 RID: 108344 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003EC7")]
		public string charId
		{
			[Token(Token = "0x601A738")]
			[Address(RVA = "0x13870A0", Offset = "0x1385CA0", VA = "0x1813870A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003EC8 RID: 16072
		// (get) Token: 0x0601A739 RID: 108345 RVA: 0x000A1DA8 File Offset: 0x0009FFA8
		[Token(Token = "0x17003EC8")]
		public int charBeanCount
		{
			[Token(Token = "0x601A739")]
			[Address(RVA = "0x1387040", Offset = "0x1385C40", VA = "0x181387040")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17003EC9 RID: 16073
		// (get) Token: 0x0601A73A RID: 108346 RVA: 0x000A1DC0 File Offset: 0x0009FFC0
		[Token(Token = "0x17003EC9")]
		public ProfessionCategory professionCategory
		{
			[Token(Token = "0x601A73A")]
			[Address(RVA = "0x1387180", Offset = "0x1385D80", VA = "0x181387180")]
			get
			{
				return ProfessionCategory.NONE;
			}
		}

		// Token: 0x17003ECA RID: 16074
		// (get) Token: 0x0601A73B RID: 108347 RVA: 0x000A1DD8 File Offset: 0x0009FFD8
		[Token(Token = "0x17003ECA")]
		public RarityRank rarity
		{
			[Token(Token = "0x601A73B")]
			[Address(RVA = "0x13871F0", Offset = "0x1385DF0", VA = "0x1813871F0")]
			get
			{
				return RarityRank.TIER_1;
			}
		}

		// Token: 0x17003ECB RID: 16075
		// (get) Token: 0x0601A73C RID: 108348 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003ECB")]
		public string skinId
		{
			[Token(Token = "0x601A73C")]
			[Address(RVA = "0x1387260", Offset = "0x1385E60", VA = "0x181387260")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601A73D RID: 108349 RVA: 0x000A1DF0 File Offset: 0x0009FFF0
		[Token(Token = "0x601A73D")]
		[Address(RVA = "0x1386AD0", Offset = "0x13856D0", VA = "0x181386AD0", Slot = "4")]
		public int CompareTo(SandboxV2LogisticsCharViewModel obj)
		{
			return 0;
		}

		// Token: 0x0601A73E RID: 108350 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A73E")]
		[Address(RVA = "0x1386D80", Offset = "0x1385980", VA = "0x181386D80")]
		public SandboxV2LogisticsCharViewModel(SandboxV2Data gameData, int charInstId, CharacterData characterData, PlayerCharacter playerCharacter)
		{
		}

		// Token: 0x04021A20 RID: 137760
		[Token(Token = "0x4021A20")]
		[FieldOffset(Offset = "0x10")]
		public int charInstId;

		// Token: 0x04021A21 RID: 137761
		[Token(Token = "0x4021A21")]
		[FieldOffset(Offset = "0x18")]
		private CharacterData m_charData;

		// Token: 0x04021A22 RID: 137762
		[Token(Token = "0x4021A22")]
		[FieldOffset(Offset = "0x20")]
		private PlayerCharacter m_playerCharacter;

		// Token: 0x04021A23 RID: 137763
		[Token(Token = "0x4021A23")]
		[FieldOffset(Offset = "0x28")]
		private int m_beanCount;

		// Token: 0x04021A24 RID: 137764
		[Token(Token = "0x4021A24")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_charName;

		// Token: 0x04021A25 RID: 137765
		[Token(Token = "0x4021A25")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_charId;

		// Token: 0x04021A26 RID: 137766
		[Token(Token = "0x4021A26")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_charBeanCount;

		// Token: 0x04021A27 RID: 137767
		[Token(Token = "0x4021A27")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_professionCategory;

		// Token: 0x04021A28 RID: 137768
		[Token(Token = "0x4021A28")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_rarity;

		// Token: 0x04021A29 RID: 137769
		[Token(Token = "0x4021A29")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_skinId;

		// Token: 0x04021A2A RID: 137770
		[Token(Token = "0x4021A2A")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_CompareTo;

		// Token: 0x04021A2B RID: 137771
		[Token(Token = "0x4021A2B")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
