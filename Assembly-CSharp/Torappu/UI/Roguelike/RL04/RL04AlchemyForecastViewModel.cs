using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike.RL04
{
	// Token: 0x0200565A RID: 22106
	[Token(Token = "0x200565A")]
	public class RL04AlchemyForecastViewModel : IHotfixable
	{
		// Token: 0x17004BEB RID: 19435
		// (get) Token: 0x060206DD RID: 132829 RVA: 0x000B5DA0 File Offset: 0x000B3FA0
		// (set) Token: 0x060206DE RID: 132830 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004BEB")]
		public RL04AlchemyForecastViewModel.ForecastStatus status
		{
			[Token(Token = "0x60206DD")]
			[Address(RVA = "0x1A90400", Offset = "0x1A8F000", VA = "0x181A90400")]
			[CompilerGenerated]
			get
			{
				return RL04AlchemyForecastViewModel.ForecastStatus.NOT_READY;
			}
			[Token(Token = "0x60206DE")]
			[Address(RVA = "0x1A905C0", Offset = "0x1A8F1C0", VA = "0x181A905C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17004BEC RID: 19436
		// (get) Token: 0x060206DF RID: 132831 RVA: 0x000B5DB8 File Offset: 0x000B3FB8
		// (set) Token: 0x060206E0 RID: 132832 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004BEC")]
		public RL04AlchemyForecastViewModel.ForecastType type
		{
			[Token(Token = "0x60206DF")]
			[Address(RVA = "0x1A90460", Offset = "0x1A8F060", VA = "0x181A90460")]
			[CompilerGenerated]
			get
			{
				return RL04AlchemyForecastViewModel.ForecastType.NONE;
			}
			[Token(Token = "0x60206E0")]
			[Address(RVA = "0x1A90630", Offset = "0x1A8F230", VA = "0x181A90630")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17004BED RID: 19437
		// (get) Token: 0x060206E1 RID: 132833 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060206E2 RID: 132834 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004BED")]
		public RL04AlchemyForecastDefinitenessItemViewModel definitenessItemViewModel
		{
			[Token(Token = "0x60206E1")]
			[Address(RVA = "0x1A90340", Offset = "0x1A8EF40", VA = "0x181A90340")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60206E2")]
			[Address(RVA = "0x1A904C0", Offset = "0x1A8F0C0", VA = "0x181A904C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17004BEE RID: 19438
		// (get) Token: 0x060206E3 RID: 132835 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060206E4 RID: 132836 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004BEE")]
		public RL04AlchemyForecastRandomViewModel randomViewModel
		{
			[Token(Token = "0x60206E3")]
			[Address(RVA = "0x1A903A0", Offset = "0x1A8EFA0", VA = "0x181A903A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60206E4")]
			[Address(RVA = "0x1A90540", Offset = "0x1A8F140", VA = "0x181A90540")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060206E5 RID: 132837 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60206E5")]
		[Address(RVA = "0x1A902E0", Offset = "0x1A8EEE0", VA = "0x181A902E0")]
		public RL04AlchemyForecastViewModel()
		{
		}

		// Token: 0x0402BE9F RID: 179871
		[Token(Token = "0x402BE9F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_status;

		// Token: 0x0402BEA0 RID: 179872
		[Token(Token = "0x402BEA0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_status;

		// Token: 0x0402BEA1 RID: 179873
		[Token(Token = "0x402BEA1")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_type;

		// Token: 0x0402BEA2 RID: 179874
		[Token(Token = "0x402BEA2")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_type;

		// Token: 0x0402BEA3 RID: 179875
		[Token(Token = "0x402BEA3")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_definitenessItemViewModel;

		// Token: 0x0402BEA4 RID: 179876
		[Token(Token = "0x402BEA4")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_definitenessItemViewModel;

		// Token: 0x0402BEA5 RID: 179877
		[Token(Token = "0x402BEA5")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_randomViewModel;

		// Token: 0x0402BEA6 RID: 179878
		[Token(Token = "0x402BEA6")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_set_randomViewModel;

		// Token: 0x0402BEA7 RID: 179879
		[Token(Token = "0x402BEA7")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200565B RID: 22107
		[Token(Token = "0x200565B")]
		public enum ForecastStatus
		{
			// Token: 0x0402BEA9 RID: 179881
			[Token(Token = "0x402BEA9")]
			NOT_READY,
			// Token: 0x0402BEAA RID: 179882
			[Token(Token = "0x402BEAA")]
			READY
		}

		// Token: 0x0200565C RID: 22108
		[Token(Token = "0x200565C")]
		public enum ForecastType
		{
			// Token: 0x0402BEAC RID: 179884
			[Token(Token = "0x402BEAC")]
			NONE,
			// Token: 0x0402BEAD RID: 179885
			[Token(Token = "0x402BEAD")]
			RANDOM,
			// Token: 0x0402BEAE RID: 179886
			[Token(Token = "0x402BEAE")]
			DEFINITENESS
		}
	}
}
