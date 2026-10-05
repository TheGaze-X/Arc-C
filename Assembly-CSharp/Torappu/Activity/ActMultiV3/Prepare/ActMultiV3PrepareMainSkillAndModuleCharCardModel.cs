using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Activity.ActMultiV3.Prepare
{
	// Token: 0x02007043 RID: 28739
	[Token(Token = "0x2007043")]
	public class ActMultiV3PrepareMainSkillAndModuleCharCardModel : IHotfixable
	{
		// Token: 0x1700606A RID: 24682
		// (get) Token: 0x06028CC2 RID: 167106 RVA: 0x000D3098 File Offset: 0x000D1298
		// (set) Token: 0x06028CC3 RID: 167107 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700606A")]
		public int innerInstId
		{
			[Token(Token = "0x6028CC2")]
			[Address(RVA = "0x243CD40", Offset = "0x243B940", VA = "0x18243CD40")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6028CC3")]
			[Address(RVA = "0x243D090", Offset = "0x243BC90", VA = "0x18243D090")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700606B RID: 24683
		// (get) Token: 0x06028CC4 RID: 167108 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06028CC5 RID: 167109 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700606B")]
		public string selectedSkillId
		{
			[Token(Token = "0x6028CC4")]
			[Address(RVA = "0x243D030", Offset = "0x243BC30", VA = "0x18243D030")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6028CC5")]
			[Address(RVA = "0x243D180", Offset = "0x243BD80", VA = "0x18243D180")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700606C RID: 24684
		// (get) Token: 0x06028CC6 RID: 167110 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06028CC7 RID: 167111 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700606C")]
		public string selectedEquipId
		{
			[Token(Token = "0x6028CC6")]
			[Address(RVA = "0x243CE10", Offset = "0x243BA10", VA = "0x18243CE10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6028CC7")]
			[Address(RVA = "0x243D100", Offset = "0x243BD00", VA = "0x18243D100")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700606D RID: 24685
		// (get) Token: 0x06028CC8 RID: 167112 RVA: 0x000D30B0 File Offset: 0x000D12B0
		[Token(Token = "0x1700606D")]
		public bool isEmpty
		{
			[Token(Token = "0x6028CC8")]
			[Address(RVA = "0x243CDA0", Offset = "0x243B9A0", VA = "0x18243CDA0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700606E RID: 24686
		// (get) Token: 0x06028CC9 RID: 167113 RVA: 0x000D30C8 File Offset: 0x000D12C8
		[Token(Token = "0x1700606E")]
		public int selectedEquipIndex
		{
			[Token(Token = "0x6028CC9")]
			[Address(RVA = "0x243CE70", Offset = "0x243BA70", VA = "0x18243CE70")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06028CCA RID: 167114 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028CCA")]
		[Address(RVA = "0x243BDD0", Offset = "0x243A9D0", VA = "0x18243BDD0")]
		public void LoadData(int instId, ActMultiV3CharViewModel cardViewModel, ActMultiV3IdentityType identityType)
		{
		}

		// Token: 0x06028CCB RID: 167115 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028CCB")]
		[Address(RVA = "0x243C7B0", Offset = "0x243B3B0", VA = "0x18243C7B0")]
		private void _LoadSkill(ICharacterCardViewModel charModel)
		{
		}

		// Token: 0x06028CCC RID: 167116 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6028CCC")]
		[Address(RVA = "0x243C0B0", Offset = "0x243ACB0", VA = "0x18243C0B0")]
		private PlayerCharSkill _GetPlayerSkillData(ListDict<string, PlayerCharSkill> playerSkills, string skillId)
		{
			return null;
		}

		// Token: 0x06028CCD RID: 167117 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028CCD")]
		[Address(RVA = "0x243C310", Offset = "0x243AF10", VA = "0x18243C310")]
		private void _LoadEquip(ICharacterCardViewModel charModel)
		{
		}

		// Token: 0x06028CCE RID: 167118 RVA: 0x000D30E0 File Offset: 0x000D12E0
		[Token(Token = "0x6028CCE")]
		[Address(RVA = "0x243C1A0", Offset = "0x243ADA0", VA = "0x18243C1A0")]
		private int _GetSelectEquipIndex()
		{
			return 0;
		}

		// Token: 0x06028CCF RID: 167119 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028CCF")]
		[Address(RVA = "0x243BFE0", Offset = "0x243ABE0", VA = "0x18243BFE0")]
		public void UpdateSelectSkill(string selectId)
		{
		}

		// Token: 0x06028CD0 RID: 167120 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028CD0")]
		[Address(RVA = "0x243BF10", Offset = "0x243AB10", VA = "0x18243BF10")]
		public void UpdateSelectEquip(string selectId)
		{
		}

		// Token: 0x06028CD1 RID: 167121 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028CD1")]
		[Address(RVA = "0x243CC00", Offset = "0x243B800", VA = "0x18243CC00")]
		public ActMultiV3PrepareMainSkillAndModuleCharCardModel()
		{
		}

		// Token: 0x0403A2DA RID: 238298
		[Token(Token = "0x403A2DA")]
		[FieldOffset(Offset = "0x18")]
		public ActMultiV3CharCardBase.Param baseViewModel;

		// Token: 0x0403A2DB RID: 238299
		[Token(Token = "0x403A2DB")]
		[FieldOffset(Offset = "0x20")]
		public ListDict<string, SkillItemViewModel> skills;

		// Token: 0x0403A2DC RID: 238300
		[Token(Token = "0x403A2DC")]
		[FieldOffset(Offset = "0x28")]
		public ListDict<string, ActMultiV3PrepareMainSkillAndModuleCharCardModel.EquipItemViewModel> equips;

		// Token: 0x0403A2DF RID: 238303
		[Token(Token = "0x403A2DF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_innerInstId;

		// Token: 0x0403A2E0 RID: 238304
		[Token(Token = "0x403A2E0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_innerInstId;

		// Token: 0x0403A2E1 RID: 238305
		[Token(Token = "0x403A2E1")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_selectedSkillId;

		// Token: 0x0403A2E2 RID: 238306
		[Token(Token = "0x403A2E2")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_selectedSkillId;

		// Token: 0x0403A2E3 RID: 238307
		[Token(Token = "0x403A2E3")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_selectedEquipId;

		// Token: 0x0403A2E4 RID: 238308
		[Token(Token = "0x403A2E4")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_selectedEquipId;

		// Token: 0x0403A2E5 RID: 238309
		[Token(Token = "0x403A2E5")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_isEmpty;

		// Token: 0x0403A2E6 RID: 238310
		[Token(Token = "0x403A2E6")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_selectedEquipIndex;

		// Token: 0x0403A2E7 RID: 238311
		[Token(Token = "0x403A2E7")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0403A2E8 RID: 238312
		[Token(Token = "0x403A2E8")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__LoadSkill;

		// Token: 0x0403A2E9 RID: 238313
		[Token(Token = "0x403A2E9")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__GetPlayerSkillData;

		// Token: 0x0403A2EA RID: 238314
		[Token(Token = "0x403A2EA")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__LoadEquip;

		// Token: 0x0403A2EB RID: 238315
		[Token(Token = "0x403A2EB")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__GetSelectEquipIndex;

		// Token: 0x0403A2EC RID: 238316
		[Token(Token = "0x403A2EC")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_UpdateSelectSkill;

		// Token: 0x0403A2ED RID: 238317
		[Token(Token = "0x403A2ED")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_UpdateSelectEquip;

		// Token: 0x0403A2EE RID: 238318
		[Token(Token = "0x403A2EE")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02007044 RID: 28740
		[Token(Token = "0x2007044")]
		public class EquipItemViewModel : IComparable<ActMultiV3PrepareMainSkillAndModuleCharCardModel.EquipItemViewModel>, IHotfixable
		{
			// Token: 0x06028CD2 RID: 167122 RVA: 0x000D30F8 File Offset: 0x000D12F8
			[Token(Token = "0x6028CD2")]
			[Address(RVA = "0x2447AA0", Offset = "0x24466A0", VA = "0x182447AA0", Slot = "4")]
			public int CompareTo(ActMultiV3PrepareMainSkillAndModuleCharCardModel.EquipItemViewModel other)
			{
				return 0;
			}

			// Token: 0x06028CD3 RID: 167123 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6028CD3")]
			[Address(RVA = "0x2447B50", Offset = "0x2446750", VA = "0x182447B50")]
			public EquipItemViewModel()
			{
			}

			// Token: 0x0403A2EF RID: 238319
			[Token(Token = "0x403A2EF")]
			[FieldOffset(Offset = "0x10")]
			public UniEquipData equipData;

			// Token: 0x0403A2F0 RID: 238320
			[Token(Token = "0x403A2F0")]
			[FieldOffset(Offset = "0x18")]
			public int equipLv;

			// Token: 0x0403A2F1 RID: 238321
			[Token(Token = "0x403A2F1")]
			[FieldOffset(Offset = "0x1C")]
			public bool isAvail;

			// Token: 0x0403A2F2 RID: 238322
			[Token(Token = "0x403A2F2")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_CompareTo;

			// Token: 0x0403A2F3 RID: 238323
			[Token(Token = "0x403A2F3")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
