using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike.RL03
{
	// Token: 0x02005822 RID: 22562
	[Token(Token = "0x2005822")]
	public class RL03TotemViewModel : IHotfixable, IRoguelikeSacrifice
	{
		// Token: 0x17004D5F RID: 19807
		// (get) Token: 0x06020F7C RID: 135036 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06020F7D RID: 135037 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004D5F")]
		public string instId
		{
			[Token(Token = "0x6020F7C")]
			[Address(RVA = "0x1B57BD0", Offset = "0x1B567D0", VA = "0x181B57BD0", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6020F7D")]
			[Address(RVA = "0x1B57FF0", Offset = "0x1B56BF0", VA = "0x181B57FF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17004D60 RID: 19808
		// (get) Token: 0x06020F7E RID: 135038 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06020F7F RID: 135039 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004D60")]
		public string itemId
		{
			[Token(Token = "0x6020F7E")]
			[Address(RVA = "0x1B57C30", Offset = "0x1B56830", VA = "0x181B57C30", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6020F7F")]
			[Address(RVA = "0x1B58070", Offset = "0x1B56C70", VA = "0x181B58070")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17004D61 RID: 19809
		// (get) Token: 0x06020F80 RID: 135040 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06020F81 RID: 135041 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004D61")]
		public string name
		{
			[Token(Token = "0x6020F80")]
			[Address(RVA = "0x1B57CF0", Offset = "0x1B568F0", VA = "0x181B57CF0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6020F81")]
			[Address(RVA = "0x1B580F0", Offset = "0x1B56CF0", VA = "0x181B580F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17004D62 RID: 19810
		// (get) Token: 0x06020F82 RID: 135042 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004D62")]
		public string usage
		{
			[Token(Token = "0x6020F82")]
			[Address(RVA = "0x1B57E10", Offset = "0x1B56A10", VA = "0x181B57E10", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004D63 RID: 19811
		// (get) Token: 0x06020F83 RID: 135043 RVA: 0x000B8050 File Offset: 0x000B6250
		// (set) Token: 0x06020F84 RID: 135044 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004D63")]
		public long ts
		{
			[Token(Token = "0x6020F83")]
			[Address(RVA = "0x1B57DB0", Offset = "0x1B569B0", VA = "0x181B57DB0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return 0L;
			}
			[Token(Token = "0x6020F84")]
			[Address(RVA = "0x1B581F0", Offset = "0x1B56DF0", VA = "0x181B581F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17004D64 RID: 19812
		// (get) Token: 0x06020F85 RID: 135045 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06020F86 RID: 135046 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004D64")]
		public string topicId
		{
			[Token(Token = "0x6020F85")]
			[Address(RVA = "0x1B57D50", Offset = "0x1B56950", VA = "0x181B57D50", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6020F86")]
			[Address(RVA = "0x1B58170", Offset = "0x1B56D70", VA = "0x181B58170")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17004D65 RID: 19813
		// (get) Token: 0x06020F87 RID: 135047 RVA: 0x000B8068 File Offset: 0x000B6268
		[Token(Token = "0x17004D65")]
		public RoguelikeGameItemType itemType
		{
			[Token(Token = "0x6020F87")]
			[Address(RVA = "0x1B57C90", Offset = "0x1B56890", VA = "0x181B57C90", Slot = "5")]
			get
			{
				return RoguelikeGameItemType.NONE;
			}
		}

		// Token: 0x06020F88 RID: 135048 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020F88")]
		[Address(RVA = "0x1B57100", Offset = "0x1B55D00", VA = "0x181B57100")]
		public static RL03TotemViewModel Create(string topicId, PlayerRoguelikeV2.CurrentData.Module.InventoryTotem totem, RoguelikeGameItemType itemType)
		{
			return null;
		}

		// Token: 0x06020F89 RID: 135049 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020F89")]
		[Address(RVA = "0x1B57490", Offset = "0x1B56090", VA = "0x181B57490")]
		public void LoadData(string topicId, PlayerRoguelikeV2.CurrentData.Module.InventoryTotem totem, RoguelikeGameItemType itemType)
		{
		}

		// Token: 0x06020F8A RID: 135050 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020F8A")]
		[Address(RVA = "0x1B57220", Offset = "0x1B55E20", VA = "0x181B57220")]
		public static RL03TotemViewModel Create(string topicId, string id, RoguelikeGameItemType itemType)
		{
			return null;
		}

		// Token: 0x06020F8B RID: 135051 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020F8B")]
		[Address(RVA = "0x1B57730", Offset = "0x1B56330", VA = "0x181B57730")]
		public void LoadData(string topicId, string id, RoguelikeGameItemType itemType)
		{
		}

		// Token: 0x06020F8C RID: 135052 RVA: 0x000B8080 File Offset: 0x000B6280
		[Token(Token = "0x6020F8C")]
		[Address(RVA = "0x1B56F80", Offset = "0x1B55B80", VA = "0x181B56F80")]
		public bool CanCombine(RL03TotemViewModel totemViewModel)
		{
			return default(bool);
		}

		// Token: 0x06020F8D RID: 135053 RVA: 0x000B8098 File Offset: 0x000B6298
		[Token(Token = "0x6020F8D")]
		[Address(RVA = "0x1B57020", Offset = "0x1B55C20", VA = "0x181B57020")]
		public bool CanResonance(RL03TotemViewModel totemViewModel)
		{
			return default(bool);
		}

		// Token: 0x06020F8E RID: 135054 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020F8E")]
		[Address(RVA = "0x1B57B70", Offset = "0x1B56770", VA = "0x181B57B70")]
		public RL03TotemViewModel()
		{
		}

		// Token: 0x0402CD47 RID: 183623
		[Token(Token = "0x402CD47")]
		[FieldOffset(Offset = "0x10")]
		public string iconId;

		// Token: 0x0402CD48 RID: 183624
		[Token(Token = "0x402CD48")]
		[FieldOffset(Offset = "0x18")]
		public bool isUsed;

		// Token: 0x0402CD49 RID: 183625
		[Token(Token = "0x402CD49")]
		[FieldOffset(Offset = "0x19")]
		public bool canSacrifice;

		// Token: 0x0402CD4A RID: 183626
		[Token(Token = "0x402CD4A")]
		[FieldOffset(Offset = "0x20")]
		public RL03TotemAffixBuffViewModel affixBuff;

		// Token: 0x0402CD4B RID: 183627
		[Token(Token = "0x402CD4B")]
		[FieldOffset(Offset = "0x28")]
		public RoguelikeTotemPosType posType;

		// Token: 0x0402CD4C RID: 183628
		[Token(Token = "0x402CD4C")]
		[FieldOffset(Offset = "0x2C")]
		public RoguelikeTotemColorType colorType;

		// Token: 0x0402CD4D RID: 183629
		[Token(Token = "0x402CD4D")]
		[FieldOffset(Offset = "0x30")]
		public string normalDesc;

		// Token: 0x0402CD4E RID: 183630
		[Token(Token = "0x402CD4E")]
		[FieldOffset(Offset = "0x38")]
		public string synergyDesc;

		// Token: 0x0402CD4F RID: 183631
		[Token(Token = "0x402CD4F")]
		[FieldOffset(Offset = "0x40")]
		public string combineGroupName;

		// Token: 0x0402CD50 RID: 183632
		[Token(Token = "0x402CD50")]
		[FieldOffset(Offset = "0x48")]
		public string bgIconId;

		// Token: 0x0402CD51 RID: 183633
		[Token(Token = "0x402CD51")]
		[FieldOffset(Offset = "0x50")]
		public string rhythm;

		// Token: 0x0402CD52 RID: 183634
		[Token(Token = "0x402CD52")]
		[FieldOffset(Offset = "0x58")]
		public bool isManual;

		// Token: 0x0402CD53 RID: 183635
		[Token(Token = "0x402CD53")]
		[FieldOffset(Offset = "0x60")]
		public RoguelikeTotemLinkedNodeTypeData linkedNodeTypeData;

		// Token: 0x0402CD54 RID: 183636
		[Token(Token = "0x402CD54")]
		[FieldOffset(Offset = "0x68")]
		public int distanceMin;

		// Token: 0x0402CD55 RID: 183637
		[Token(Token = "0x402CD55")]
		[FieldOffset(Offset = "0x6C")]
		public int distanceMax;

		// Token: 0x0402CD56 RID: 183638
		[Token(Token = "0x402CD56")]
		[FieldOffset(Offset = "0x70")]
		public bool vertPassable;

		// Token: 0x0402CD57 RID: 183639
		[Token(Token = "0x402CD57")]
		[FieldOffset(Offset = "0x74")]
		public int expandLength;

		// Token: 0x0402CD58 RID: 183640
		[Token(Token = "0x402CD58")]
		[FieldOffset(Offset = "0x78")]
		public bool onlyForVert;

		// Token: 0x0402CD59 RID: 183641
		[Token(Token = "0x402CD59")]
		[FieldOffset(Offset = "0x80")]
		public RoguelikeTotemLinkedNodeTypeData portalLinkedNodeTypeData;

		// Token: 0x0402CD5F RID: 183647
		[Token(Token = "0x402CD5F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_instId;

		// Token: 0x0402CD60 RID: 183648
		[Token(Token = "0x402CD60")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_instId;

		// Token: 0x0402CD61 RID: 183649
		[Token(Token = "0x402CD61")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_itemId;

		// Token: 0x0402CD62 RID: 183650
		[Token(Token = "0x402CD62")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_itemId;

		// Token: 0x0402CD63 RID: 183651
		[Token(Token = "0x402CD63")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_name;

		// Token: 0x0402CD64 RID: 183652
		[Token(Token = "0x402CD64")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_name;

		// Token: 0x0402CD65 RID: 183653
		[Token(Token = "0x402CD65")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_usage;

		// Token: 0x0402CD66 RID: 183654
		[Token(Token = "0x402CD66")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_ts;

		// Token: 0x0402CD67 RID: 183655
		[Token(Token = "0x402CD67")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_set_ts;

		// Token: 0x0402CD68 RID: 183656
		[Token(Token = "0x402CD68")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_topicId;

		// Token: 0x0402CD69 RID: 183657
		[Token(Token = "0x402CD69")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_set_topicId;

		// Token: 0x0402CD6A RID: 183658
		[Token(Token = "0x402CD6A")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_get_itemType;

		// Token: 0x0402CD6B RID: 183659
		[Token(Token = "0x402CD6B")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_Create;

		// Token: 0x0402CD6C RID: 183660
		[Token(Token = "0x402CD6C")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0402CD6D RID: 183661
		[Token(Token = "0x402CD6D")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix1_Create;

		// Token: 0x0402CD6E RID: 183662
		[Token(Token = "0x402CD6E")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix1_LoadData;

		// Token: 0x0402CD6F RID: 183663
		[Token(Token = "0x402CD6F")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_CanCombine;

		// Token: 0x0402CD70 RID: 183664
		[Token(Token = "0x402CD70")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_CanResonance;

		// Token: 0x0402CD71 RID: 183665
		[Token(Token = "0x402CD71")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
