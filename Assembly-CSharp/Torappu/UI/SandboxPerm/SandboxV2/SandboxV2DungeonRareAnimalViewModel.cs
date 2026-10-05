using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x020042E6 RID: 17126
	[Token(Token = "0x20042E6")]
	public class SandboxV2DungeonRareAnimalViewModel : SandboxV2DungeonFloatViewModel
	{
		// Token: 0x0601A555 RID: 107861 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A555")]
		[Address(RVA = "0x133B0F0", Offset = "0x1339CF0", VA = "0x18133B0F0")]
		public void UpdateData(SandboxV2DungeonRareAnimalViewModel.UpdateParam updateParam)
		{
		}

		// Token: 0x0601A556 RID: 107862 RVA: 0x000A1538 File Offset: 0x0009F738
		[Token(Token = "0x601A556")]
		[Address(RVA = "0x133AFA0", Offset = "0x1339BA0", VA = "0x18133AFA0", Slot = "4")]
		public override int CompareDungeonFloat(SandboxV2DungeonFloatViewModel other)
		{
			return 0;
		}

		// Token: 0x0601A557 RID: 107863 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A557")]
		[Address(RVA = "0x133B460", Offset = "0x133A060", VA = "0x18133B460")]
		public SandboxV2DungeonRareAnimalViewModel()
		{
		}

		// Token: 0x0601A558 RID: 107864 RVA: 0x000A1550 File Offset: 0x0009F750
		[Token(Token = "0x601A558")]
		[Address(RVA = "0x132BFB0", Offset = "0x132ABB0", VA = "0x18132BFB0")]
		private int <>xLuaBaseProxy_CompareDungeonFloat(SandboxV2DungeonFloatViewModel P0)
		{
			return 0;
		}

		// Token: 0x0402164D RID: 136781
		[Token(Token = "0x402164D")]
		private const int DEFAULT_HP_RATIO = 10000;

		// Token: 0x0402164E RID: 136782
		[Token(Token = "0x402164E")]
		[FieldOffset(Offset = "0x60")]
		public string enemyId;

		// Token: 0x0402164F RID: 136783
		[Token(Token = "0x402164F")]
		[FieldOffset(Offset = "0x68")]
		public string enemyGroupKey;

		// Token: 0x04021650 RID: 136784
		[Token(Token = "0x4021650")]
		[FieldOffset(Offset = "0x70")]
		public SandboxV2DropDetail rareAnimalDrop;

		// Token: 0x04021651 RID: 136785
		[Token(Token = "0x4021651")]
		[FieldOffset(Offset = "0x90")]
		public int remainDays;

		// Token: 0x04021652 RID: 136786
		[Token(Token = "0x4021652")]
		[FieldOffset(Offset = "0x94")]
		public bool hpRatioValid;

		// Token: 0x04021653 RID: 136787
		[Token(Token = "0x4021653")]
		[FieldOffset(Offset = "0x98")]
		public int hpRatio;

		// Token: 0x04021654 RID: 136788
		[Token(Token = "0x4021654")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_UpdateData;

		// Token: 0x04021655 RID: 136789
		[Token(Token = "0x4021655")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_CompareDungeonFloat;

		// Token: 0x04021656 RID: 136790
		[Token(Token = "0x4021656")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020042E7 RID: 17127
		[Token(Token = "0x20042E7")]
		public struct UpdateParam
		{
			// Token: 0x04021657 RID: 136791
			[Token(Token = "0x4021657")]
			[FieldOffset(Offset = "0x0")]
			public string rareAnimalId;

			// Token: 0x04021658 RID: 136792
			[Token(Token = "0x4021658")]
			[FieldOffset(Offset = "0x8")]
			public SandboxV2Data topicDetailData;

			// Token: 0x04021659 RID: 136793
			[Token(Token = "0x4021659")]
			[FieldOffset(Offset = "0x10")]
			public PlayerSandboxV2.Dungeon.RareAnimal playerRareAnimalData;
		}
	}
}
