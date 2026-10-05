using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike.RL04
{
	// Token: 0x02005657 RID: 22103
	[Token(Token = "0x2005657")]
	public class RL04AlchemyForecastRandomViewModel : IHotfixable
	{
		// Token: 0x17004BDD RID: 19421
		// (get) Token: 0x060206BE RID: 132798 RVA: 0x000B5CC8 File Offset: 0x000B3EC8
		// (set) Token: 0x060206BF RID: 132799 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004BDD")]
		public bool isInfoValid
		{
			[Token(Token = "0x60206BE")]
			[Address(RVA = "0x1A8FDA0", Offset = "0x1A8E9A0", VA = "0x181A8FDA0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60206BF")]
			[Address(RVA = "0x1A90040", Offset = "0x1A8EC40", VA = "0x181A90040")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17004BDE RID: 19422
		// (get) Token: 0x060206C0 RID: 132800 RVA: 0x000B5CE0 File Offset: 0x000B3EE0
		// (set) Token: 0x060206C1 RID: 132801 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004BDE")]
		public float relicProp
		{
			[Token(Token = "0x60206C0")]
			[Address(RVA = "0x1A8FEC0", Offset = "0x1A8EAC0", VA = "0x181A8FEC0")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60206C1")]
			[Address(RVA = "0x1A90190", Offset = "0x1A8ED90", VA = "0x181A90190")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17004BDF RID: 19423
		// (get) Token: 0x060206C2 RID: 132802 RVA: 0x000B5CF8 File Offset: 0x000B3EF8
		// (set) Token: 0x060206C3 RID: 132803 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004BDF")]
		public float shieldProp
		{
			[Token(Token = "0x60206C2")]
			[Address(RVA = "0x1A8FFE0", Offset = "0x1A8EBE0", VA = "0x181A8FFE0")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60206C3")]
			[Address(RVA = "0x1A90270", Offset = "0x1A8EE70", VA = "0x181A90270")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17004BE0 RID: 19424
		// (get) Token: 0x060206C4 RID: 132804 RVA: 0x000B5D10 File Offset: 0x000B3F10
		// (set) Token: 0x060206C5 RID: 132805 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004BE0")]
		public float populationProp
		{
			[Token(Token = "0x60206C4")]
			[Address(RVA = "0x1A8FE60", Offset = "0x1A8EA60", VA = "0x181A8FE60")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60206C5")]
			[Address(RVA = "0x1A90120", Offset = "0x1A8ED20", VA = "0x181A90120")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17004BE1 RID: 19425
		// (get) Token: 0x060206C6 RID: 132806 RVA: 0x000B5D28 File Offset: 0x000B3F28
		// (set) Token: 0x060206C7 RID: 132807 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004BE1")]
		public AlchemyPoolRarityType poolRarity
		{
			[Token(Token = "0x60206C6")]
			[Address(RVA = "0x1A8FE00", Offset = "0x1A8EA00", VA = "0x181A8FE00")]
			[CompilerGenerated]
			get
			{
				return AlchemyPoolRarityType.NORMAL;
			}
			[Token(Token = "0x60206C7")]
			[Address(RVA = "0x1A900B0", Offset = "0x1A8ECB0", VA = "0x181A900B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17004BE2 RID: 19426
		// (get) Token: 0x060206C8 RID: 132808 RVA: 0x000B5D40 File Offset: 0x000B3F40
		// (set) Token: 0x060206C9 RID: 132809 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004BE2")]
		public int rewardRarityMaxCount
		{
			[Token(Token = "0x60206C8")]
			[Address(RVA = "0x1A8FF80", Offset = "0x1A8EB80", VA = "0x181A8FF80")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x60206C9")]
			[Address(RVA = "0x1A90200", Offset = "0x1A8EE00", VA = "0x181A90200")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17004BE3 RID: 19427
		// (get) Token: 0x060206CA RID: 132810 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004BE3")]
		public List<RL04AlchemyForecastRandomViewModel.RandomRewardRarityItemStatus> rewardRarityItemViewModels
		{
			[Token(Token = "0x60206CA")]
			[Address(RVA = "0x1A8FF20", Offset = "0x1A8EB20", VA = "0x181A8FF20")]
			get
			{
				return null;
			}
		}

		// Token: 0x060206CB RID: 132811 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60206CB")]
		[Address(RVA = "0x1A8FCF0", Offset = "0x1A8E8F0", VA = "0x181A8FCF0")]
		private RL04AlchemyForecastRandomViewModel()
		{
		}

		// Token: 0x060206CC RID: 132812 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60206CC")]
		[Address(RVA = "0x1A8F860", Offset = "0x1A8E460", VA = "0x181A8F860")]
		public RL04AlchemyForecastRandomViewModel(int maxAlchemyPoolRarity, RoguelikeAlchemyData alchemyData)
		{
		}

		// Token: 0x060206CD RID: 132813 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60206CD")]
		[Address(RVA = "0x1A8F510", Offset = "0x1A8E110", VA = "0x181A8F510")]
		public static RL04AlchemyForecastRandomViewModel EMPTY(int maxAlchemyPoolRarity)
		{
			return null;
		}

		// Token: 0x0402BE71 RID: 179825
		[Token(Token = "0x402BE71")]
		[FieldOffset(Offset = "0x28")]
		private List<RL04AlchemyForecastRandomViewModel.RandomRewardRarityItemStatus> m_rewardRarityItemViewModels;

		// Token: 0x0402BE72 RID: 179826
		[Token(Token = "0x402BE72")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isInfoValid;

		// Token: 0x0402BE73 RID: 179827
		[Token(Token = "0x402BE73")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_isInfoValid;

		// Token: 0x0402BE74 RID: 179828
		[Token(Token = "0x402BE74")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_relicProp;

		// Token: 0x0402BE75 RID: 179829
		[Token(Token = "0x402BE75")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_relicProp;

		// Token: 0x0402BE76 RID: 179830
		[Token(Token = "0x402BE76")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_shieldProp;

		// Token: 0x0402BE77 RID: 179831
		[Token(Token = "0x402BE77")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_shieldProp;

		// Token: 0x0402BE78 RID: 179832
		[Token(Token = "0x402BE78")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_populationProp;

		// Token: 0x0402BE79 RID: 179833
		[Token(Token = "0x402BE79")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_set_populationProp;

		// Token: 0x0402BE7A RID: 179834
		[Token(Token = "0x402BE7A")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_poolRarity;

		// Token: 0x0402BE7B RID: 179835
		[Token(Token = "0x402BE7B")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_set_poolRarity;

		// Token: 0x0402BE7C RID: 179836
		[Token(Token = "0x402BE7C")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_rewardRarityMaxCount;

		// Token: 0x0402BE7D RID: 179837
		[Token(Token = "0x402BE7D")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_set_rewardRarityMaxCount;

		// Token: 0x0402BE7E RID: 179838
		[Token(Token = "0x402BE7E")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_get_rewardRarityItemViewModels;

		// Token: 0x0402BE7F RID: 179839
		[Token(Token = "0x402BE7F")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0402BE80 RID: 179840
		[Token(Token = "0x402BE80")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge _c__Hotfix1_ctor;

		// Token: 0x0402BE81 RID: 179841
		[Token(Token = "0x402BE81")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_EMPTY;

		// Token: 0x02005658 RID: 22104
		[Token(Token = "0x2005658")]
		public enum RandomRewardRarityItemStatus
		{
			// Token: 0x0402BE83 RID: 179843
			[Token(Token = "0x402BE83")]
			GRAY,
			// Token: 0x0402BE84 RID: 179844
			[Token(Token = "0x402BE84")]
			BRIGHT
		}
	}
}
