using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike.Copper
{
	// Token: 0x0200589D RID: 22685
	[Token(Token = "0x200589D")]
	public class RoguelikePlayerCopperItemViewModel : IRoguelikeCopperItemModel, IHotfixable, IComparable, IRoguelikeSacrifice
	{
		// Token: 0x17004DBD RID: 19901
		// (get) Token: 0x060211DE RID: 135646 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060211DF RID: 135647 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004DBD")]
		public string topicId
		{
			[Token(Token = "0x60211DE")]
			[Address(RVA = "0x1B80B00", Offset = "0x1B7F700", VA = "0x181B80B00", Slot = "13")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60211DF")]
			[Address(RVA = "0x1B812B0", Offset = "0x1B7FEB0", VA = "0x181B812B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17004DBE RID: 19902
		// (get) Token: 0x060211E0 RID: 135648 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060211E1 RID: 135649 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004DBE")]
		public string itemId
		{
			[Token(Token = "0x60211E0")]
			[Address(RVA = "0x1B80860", Offset = "0x1B7F460", VA = "0x181B80860", Slot = "15")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60211E1")]
			[Address(RVA = "0x1B80FD0", Offset = "0x1B7FBD0", VA = "0x181B80FD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17004DBF RID: 19903
		// (get) Token: 0x060211E2 RID: 135650 RVA: 0x000B8998 File Offset: 0x000B6B98
		[Token(Token = "0x17004DBF")]
		public RoguelikeGameItemType itemType
		{
			[Token(Token = "0x60211E2")]
			[Address(RVA = "0x1B808C0", Offset = "0x1B7F4C0", VA = "0x181B808C0", Slot = "14")]
			get
			{
				return RoguelikeGameItemType.NONE;
			}
		}

		// Token: 0x17004DC0 RID: 19904
		// (get) Token: 0x060211E3 RID: 135651 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060211E4 RID: 135652 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004DC0")]
		public string gildIconId
		{
			[Token(Token = "0x60211E3")]
			[Address(RVA = "0x1B80740", Offset = "0x1B7F340", VA = "0x181B80740", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60211E4")]
			[Address(RVA = "0x1B80E60", Offset = "0x1B7FA60", VA = "0x181B80E60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17004DC1 RID: 19905
		// (get) Token: 0x060211E5 RID: 135653 RVA: 0x000B89B0 File Offset: 0x000B6BB0
		// (set) Token: 0x060211E6 RID: 135654 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004DC1")]
		public RoguelikeCopperLuckyLevel luckyLevel
		{
			[Token(Token = "0x60211E5")]
			[Address(RVA = "0x1B80980", Offset = "0x1B7F580", VA = "0x181B80980", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return RoguelikeCopperLuckyLevel.NONE;
			}
			[Token(Token = "0x60211E6")]
			[Address(RVA = "0x1B810D0", Offset = "0x1B7FCD0", VA = "0x181B810D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17004DC2 RID: 19906
		// (get) Token: 0x060211E7 RID: 135655 RVA: 0x000B89C8 File Offset: 0x000B6BC8
		// (set) Token: 0x060211E8 RID: 135656 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004DC2")]
		public RoguelikeCopperBuffType buffType
		{
			[Token(Token = "0x60211E7")]
			[Address(RVA = "0x1B805C0", Offset = "0x1B7F1C0", VA = "0x181B805C0")]
			[CompilerGenerated]
			get
			{
				return RoguelikeCopperBuffType.NONE;
			}
			[Token(Token = "0x60211E8")]
			[Address(RVA = "0x1B80C90", Offset = "0x1B7F890", VA = "0x181B80C90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17004DC3 RID: 19907
		// (get) Token: 0x060211E9 RID: 135657 RVA: 0x000B89E0 File Offset: 0x000B6BE0
		// (set) Token: 0x060211EA RID: 135658 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004DC3")]
		public int sortId
		{
			[Token(Token = "0x60211E9")]
			[Address(RVA = "0x1B80AA0", Offset = "0x1B7F6A0", VA = "0x181B80AA0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x60211EA")]
			[Address(RVA = "0x1B81240", Offset = "0x1B7FE40", VA = "0x181B81240")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17004DC4 RID: 19908
		// (get) Token: 0x060211EB RID: 135659 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060211EC RID: 135660 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004DC4")]
		public string desc
		{
			[Token(Token = "0x60211EB")]
			[Address(RVA = "0x1B806E0", Offset = "0x1B7F2E0", VA = "0x181B806E0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60211EC")]
			[Address(RVA = "0x1B80DE0", Offset = "0x1B7F9E0", VA = "0x181B80DE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17004DC5 RID: 19909
		// (get) Token: 0x060211ED RID: 135661 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060211EE RID: 135662 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004DC5")]
		public string usage
		{
			[Token(Token = "0x60211ED")]
			[Address(RVA = "0x1B80BC0", Offset = "0x1B7F7C0", VA = "0x181B80BC0", Slot = "19")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60211EE")]
			[Address(RVA = "0x1B813A0", Offset = "0x1B7FFA0", VA = "0x181B813A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17004DC6 RID: 19910
		// (get) Token: 0x060211EF RID: 135663 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060211F0 RID: 135664 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004DC6")]
		public string name
		{
			[Token(Token = "0x60211EF")]
			[Address(RVA = "0x1B809E0", Offset = "0x1B7F5E0", VA = "0x181B809E0", Slot = "18")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60211F0")]
			[Address(RVA = "0x1B81140", Offset = "0x1B7FD40", VA = "0x181B81140")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17004DC7 RID: 19911
		// (get) Token: 0x060211F1 RID: 135665 RVA: 0x000B89F8 File Offset: 0x000B6BF8
		// (set) Token: 0x060211F2 RID: 135666 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004DC7")]
		public bool canSacrifice
		{
			[Token(Token = "0x60211F1")]
			[Address(RVA = "0x1B80620", Offset = "0x1B7F220", VA = "0x181B80620")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60211F2")]
			[Address(RVA = "0x1B80D00", Offset = "0x1B7F900", VA = "0x181B80D00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17004DC8 RID: 19912
		// (get) Token: 0x060211F3 RID: 135667 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060211F4 RID: 135668 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004DC8")]
		public List<string> poemList
		{
			[Token(Token = "0x60211F3")]
			[Address(RVA = "0x1B80A40", Offset = "0x1B7F640", VA = "0x181B80A40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60211F4")]
			[Address(RVA = "0x1B811C0", Offset = "0x1B7FDC0", VA = "0x181B811C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17004DC9 RID: 19913
		// (get) Token: 0x060211F5 RID: 135669 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060211F6 RID: 135670 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004DC9")]
		public string instId
		{
			[Token(Token = "0x60211F5")]
			[Address(RVA = "0x1B807A0", Offset = "0x1B7F3A0", VA = "0x181B807A0", Slot = "16")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60211F6")]
			[Address(RVA = "0x1B80EE0", Offset = "0x1B7FAE0", VA = "0x181B80EE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17004DCA RID: 19914
		// (get) Token: 0x060211F7 RID: 135671 RVA: 0x000B8A10 File Offset: 0x000B6C10
		// (set) Token: 0x060211F8 RID: 135672 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004DCA")]
		public bool isDrawn
		{
			[Token(Token = "0x60211F7")]
			[Address(RVA = "0x1B80800", Offset = "0x1B7F400", VA = "0x181B80800")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60211F8")]
			[Address(RVA = "0x1B80F60", Offset = "0x1B7FB60", VA = "0x181B80F60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17004DCB RID: 19915
		// (get) Token: 0x060211F9 RID: 135673 RVA: 0x000B8A28 File Offset: 0x000B6C28
		// (set) Token: 0x060211FA RID: 135674 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004DCB")]
		public int countDown
		{
			[Token(Token = "0x60211F9")]
			[Address(RVA = "0x1B80680", Offset = "0x1B7F280", VA = "0x181B80680")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x60211FA")]
			[Address(RVA = "0x1B80D70", Offset = "0x1B7F970", VA = "0x181B80D70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17004DCC RID: 19916
		// (get) Token: 0x060211FB RID: 135675 RVA: 0x000B8A40 File Offset: 0x000B6C40
		// (set) Token: 0x060211FC RID: 135676 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004DCC")]
		public bool alwaysShowCountDown
		{
			[Token(Token = "0x60211FB")]
			[Address(RVA = "0x1B80560", Offset = "0x1B7F160", VA = "0x181B80560")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60211FC")]
			[Address(RVA = "0x1B80C20", Offset = "0x1B7F820", VA = "0x181B80C20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17004DCD RID: 19917
		// (get) Token: 0x060211FD RID: 135677 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060211FE RID: 135678 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004DCD")]
		public string layerDesc
		{
			[Token(Token = "0x60211FD")]
			[Address(RVA = "0x1B80920", Offset = "0x1B7F520", VA = "0x181B80920")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60211FE")]
			[Address(RVA = "0x1B81050", Offset = "0x1B7FC50", VA = "0x181B81050")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17004DCE RID: 19918
		// (get) Token: 0x060211FF RID: 135679 RVA: 0x000B8A58 File Offset: 0x000B6C58
		// (set) Token: 0x06021200 RID: 135680 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004DCE")]
		public long ts
		{
			[Token(Token = "0x60211FF")]
			[Address(RVA = "0x1B80B60", Offset = "0x1B7F760", VA = "0x181B80B60", Slot = "17")]
			[CompilerGenerated]
			get
			{
				return 0L;
			}
			[Token(Token = "0x6021200")]
			[Address(RVA = "0x1B81330", Offset = "0x1B7FF30", VA = "0x181B81330")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06021201 RID: 135681 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021201")]
		[Address(RVA = "0x1B7FC80", Offset = "0x1B7E880", VA = "0x181B7FC80")]
		public void LoadData(string topicId, string index, PlayerRoguelikeV2.CurrentData.Module.InventoryCopper playerCopper, RoguelikeCopperData gameCopper)
		{
		}

		// Token: 0x06021202 RID: 135682 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6021202")]
		[Address(RVA = "0x1B7FB00", Offset = "0x1B7E700", VA = "0x181B7FB00")]
		public static RoguelikePlayerCopperItemViewModel CreateByPlayerData(string topicId, string instId, PlayerRoguelikeV2.CurrentData.Module.InventoryCopper playerCopper)
		{
			return null;
		}

		// Token: 0x06021203 RID: 135683 RVA: 0x000B8A70 File Offset: 0x000B6C70
		[Token(Token = "0x6021203")]
		[Address(RVA = "0x1B7F8E0", Offset = "0x1B7E4E0", VA = "0x181B7F8E0", Slot = "12")]
		public int CompareTo(object obj)
		{
			return 0;
		}

		// Token: 0x06021204 RID: 135684 RVA: 0x000B8A88 File Offset: 0x000B6C88
		[Token(Token = "0x6021204")]
		[Address(RVA = "0x1B7F710", Offset = "0x1B7E310", VA = "0x181B7F710")]
		public int CompareForActiveCopper(object obj)
		{
			return 0;
		}

		// Token: 0x06021205 RID: 135685 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021205")]
		[Address(RVA = "0x1B80500", Offset = "0x1B7F100", VA = "0x181B80500")]
		public RoguelikePlayerCopperItemViewModel()
		{
		}

		// Token: 0x0402D184 RID: 184708
		[Token(Token = "0x402D184")]
		[FieldOffset(Offset = "0x88")]
		public PlayerRoguelikePendingEvent.DrawCopperHitReason hitReason;

		// Token: 0x0402D185 RID: 184709
		[Token(Token = "0x402D185")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_topicId;

		// Token: 0x0402D186 RID: 184710
		[Token(Token = "0x402D186")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_topicId;

		// Token: 0x0402D187 RID: 184711
		[Token(Token = "0x402D187")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_itemId;

		// Token: 0x0402D188 RID: 184712
		[Token(Token = "0x402D188")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_itemId;

		// Token: 0x0402D189 RID: 184713
		[Token(Token = "0x402D189")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_itemType;

		// Token: 0x0402D18A RID: 184714
		[Token(Token = "0x402D18A")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_gildIconId;

		// Token: 0x0402D18B RID: 184715
		[Token(Token = "0x402D18B")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_set_gildIconId;

		// Token: 0x0402D18C RID: 184716
		[Token(Token = "0x402D18C")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_luckyLevel;

		// Token: 0x0402D18D RID: 184717
		[Token(Token = "0x402D18D")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_set_luckyLevel;

		// Token: 0x0402D18E RID: 184718
		[Token(Token = "0x402D18E")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_buffType;

		// Token: 0x0402D18F RID: 184719
		[Token(Token = "0x402D18F")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_set_buffType;

		// Token: 0x0402D190 RID: 184720
		[Token(Token = "0x402D190")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_get_sortId;

		// Token: 0x0402D191 RID: 184721
		[Token(Token = "0x402D191")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_set_sortId;

		// Token: 0x0402D192 RID: 184722
		[Token(Token = "0x402D192")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_get_desc;

		// Token: 0x0402D193 RID: 184723
		[Token(Token = "0x402D193")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_set_desc;

		// Token: 0x0402D194 RID: 184724
		[Token(Token = "0x402D194")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_get_usage;

		// Token: 0x0402D195 RID: 184725
		[Token(Token = "0x402D195")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_set_usage;

		// Token: 0x0402D196 RID: 184726
		[Token(Token = "0x402D196")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_get_name;

		// Token: 0x0402D197 RID: 184727
		[Token(Token = "0x402D197")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_set_name;

		// Token: 0x0402D198 RID: 184728
		[Token(Token = "0x402D198")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_get_canSacrifice;

		// Token: 0x0402D199 RID: 184729
		[Token(Token = "0x402D199")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_set_canSacrifice;

		// Token: 0x0402D19A RID: 184730
		[Token(Token = "0x402D19A")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_get_poemList;

		// Token: 0x0402D19B RID: 184731
		[Token(Token = "0x402D19B")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_set_poemList;

		// Token: 0x0402D19C RID: 184732
		[Token(Token = "0x402D19C")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_get_instId;

		// Token: 0x0402D19D RID: 184733
		[Token(Token = "0x402D19D")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_set_instId;

		// Token: 0x0402D19E RID: 184734
		[Token(Token = "0x402D19E")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_get_isDrawn;

		// Token: 0x0402D19F RID: 184735
		[Token(Token = "0x402D19F")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_set_isDrawn;

		// Token: 0x0402D1A0 RID: 184736
		[Token(Token = "0x402D1A0")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_get_countDown;

		// Token: 0x0402D1A1 RID: 184737
		[Token(Token = "0x402D1A1")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_set_countDown;

		// Token: 0x0402D1A2 RID: 184738
		[Token(Token = "0x402D1A2")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0_get_alwaysShowCountDown;

		// Token: 0x0402D1A3 RID: 184739
		[Token(Token = "0x402D1A3")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0_set_alwaysShowCountDown;

		// Token: 0x0402D1A4 RID: 184740
		[Token(Token = "0x402D1A4")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0_get_layerDesc;

		// Token: 0x0402D1A5 RID: 184741
		[Token(Token = "0x402D1A5")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0_set_layerDesc;

		// Token: 0x0402D1A6 RID: 184742
		[Token(Token = "0x402D1A6")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0_get_ts;

		// Token: 0x0402D1A7 RID: 184743
		[Token(Token = "0x402D1A7")]
		[FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0_set_ts;

		// Token: 0x0402D1A8 RID: 184744
		[Token(Token = "0x402D1A8")]
		[FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0402D1A9 RID: 184745
		[Token(Token = "0x402D1A9")]
		[FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0_CreateByPlayerData;

		// Token: 0x0402D1AA RID: 184746
		[Token(Token = "0x402D1AA")]
		[FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix0_CompareTo;

		// Token: 0x0402D1AB RID: 184747
		[Token(Token = "0x402D1AB")]
		[FieldOffset(Offset = "0x130")]
		private static DelegateBridge __Hotfix0_CompareForActiveCopper;

		// Token: 0x0402D1AC RID: 184748
		[Token(Token = "0x402D1AC")]
		[FieldOffset(Offset = "0x138")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
