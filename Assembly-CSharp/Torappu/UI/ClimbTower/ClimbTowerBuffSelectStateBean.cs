using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005CE5 RID: 23781
	[Token(Token = "0x2005CE5")]
	public class ClimbTowerBuffSelectStateBean : IStateBean, IHotfixable
	{
		// Token: 0x170050F0 RID: 20720
		// (get) Token: 0x060226E4 RID: 141028 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170050F0")]
		public TacticalBuffGroupProp buffGroupProp
		{
			[Token(Token = "0x60226E4")]
			[Address(RVA = "0x1CCDB70", Offset = "0x1CCC770", VA = "0x181CCDB70")]
			get
			{
				return null;
			}
		}

		// Token: 0x170050F1 RID: 20721
		// (get) Token: 0x060226E5 RID: 141029 RVA: 0x000BD630 File Offset: 0x000BB830
		// (set) Token: 0x060226E6 RID: 141030 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170050F1")]
		public bool isPlanFree
		{
			[Token(Token = "0x60226E5")]
			[Address(RVA = "0x1CCDCE0", Offset = "0x1CCC8E0", VA = "0x181CCDCE0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60226E6")]
			[Address(RVA = "0x1CCDDB0", Offset = "0x1CCC9B0", VA = "0x181CCDDB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170050F2 RID: 20722
		// (get) Token: 0x060226E7 RID: 141031 RVA: 0x000BD648 File Offset: 0x000BB848
		// (set) Token: 0x060226E8 RID: 141032 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170050F2")]
		public bool hasTowerPass
		{
			[Token(Token = "0x60226E7")]
			[Address(RVA = "0x1CCDC80", Offset = "0x1CCC880", VA = "0x181CCDC80")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60226E8")]
			[Address(RVA = "0x1CCDD40", Offset = "0x1CCC940", VA = "0x181CCDD40")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170050F3 RID: 20723
		// (get) Token: 0x060226E9 RID: 141033 RVA: 0x000BD660 File Offset: 0x000BB860
		[Token(Token = "0x170050F3")]
		public TowerGameStrategy currentStrategy
		{
			[Token(Token = "0x60226E9")]
			[Address(RVA = "0x1CCDBD0", Offset = "0x1CCC7D0", VA = "0x181CCDBD0")]
			get
			{
				return TowerGameStrategy.NONE;
			}
		}

		// Token: 0x060226EA RID: 141034 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60226EA")]
		[Address(RVA = "0x1CCD980", Offset = "0x1CCC580", VA = "0x181CCD980")]
		public void InitData()
		{
		}

		// Token: 0x060226EB RID: 141035 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60226EB")]
		[Address(RVA = "0x1CCDA80", Offset = "0x1CCC680", VA = "0x181CCDA80")]
		public ClimbTowerBuffSelectStateBean()
		{
		}

		// Token: 0x0402F524 RID: 193828
		[Token(Token = "0x402F524")]
		[FieldOffset(Offset = "0x10")]
		private TacticalBuffGroupProp m_prop;

		// Token: 0x0402F527 RID: 193831
		[Token(Token = "0x402F527")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_buffGroupProp;

		// Token: 0x0402F528 RID: 193832
		[Token(Token = "0x402F528")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_isPlanFree;

		// Token: 0x0402F529 RID: 193833
		[Token(Token = "0x402F529")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_set_isPlanFree;

		// Token: 0x0402F52A RID: 193834
		[Token(Token = "0x402F52A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_hasTowerPass;

		// Token: 0x0402F52B RID: 193835
		[Token(Token = "0x402F52B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_set_hasTowerPass;

		// Token: 0x0402F52C RID: 193836
		[Token(Token = "0x402F52C")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_currentStrategy;

		// Token: 0x0402F52D RID: 193837
		[Token(Token = "0x402F52D")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_InitData;

		// Token: 0x0402F52E RID: 193838
		[Token(Token = "0x402F52E")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
