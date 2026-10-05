using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike.Copper
{
	// Token: 0x0200589C RID: 22684
	[Token(Token = "0x200589C")]
	public class RoguelikeGameCopperItemViewModel : IRoguelikeCopperItemModel, IHotfixable, IComparable
	{
		// Token: 0x17004DB2 RID: 19890
		// (get) Token: 0x060211C5 RID: 135621 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060211C6 RID: 135622 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004DB2")]
		public string topicId
		{
			[Token(Token = "0x60211C5")]
			[Address(RVA = "0x1B7F100", Offset = "0x1B7DD00", VA = "0x181B7F100", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60211C6")]
			[Address(RVA = "0x1B7F610", Offset = "0x1B7E210", VA = "0x181B7F610")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17004DB3 RID: 19891
		// (get) Token: 0x060211C7 RID: 135623 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060211C8 RID: 135624 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004DB3")]
		public string itemId
		{
			[Token(Token = "0x60211C7")]
			[Address(RVA = "0x1B7EEC0", Offset = "0x1B7DAC0", VA = "0x181B7EEC0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60211C8")]
			[Address(RVA = "0x1B7F330", Offset = "0x1B7DF30", VA = "0x181B7F330")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17004DB4 RID: 19892
		// (get) Token: 0x060211C9 RID: 135625 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060211CA RID: 135626 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004DB4")]
		public string gildIconId
		{
			[Token(Token = "0x60211C9")]
			[Address(RVA = "0x1B7EE60", Offset = "0x1B7DA60", VA = "0x181B7EE60", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60211CA")]
			[Address(RVA = "0x1B7F2B0", Offset = "0x1B7DEB0", VA = "0x181B7F2B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17004DB5 RID: 19893
		// (get) Token: 0x060211CB RID: 135627 RVA: 0x000B8938 File Offset: 0x000B6B38
		// (set) Token: 0x060211CC RID: 135628 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004DB5")]
		public RoguelikeCopperLuckyLevel luckyLevel
		{
			[Token(Token = "0x60211CB")]
			[Address(RVA = "0x1B7EF80", Offset = "0x1B7DB80", VA = "0x181B7EF80", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return RoguelikeCopperLuckyLevel.NONE;
			}
			[Token(Token = "0x60211CC")]
			[Address(RVA = "0x1B7F430", Offset = "0x1B7E030", VA = "0x181B7F430")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17004DB6 RID: 19894
		// (get) Token: 0x060211CD RID: 135629 RVA: 0x000B8950 File Offset: 0x000B6B50
		// (set) Token: 0x060211CE RID: 135630 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004DB6")]
		public RoguelikeCopperBuffType buffType
		{
			[Token(Token = "0x60211CD")]
			[Address(RVA = "0x1B7EDA0", Offset = "0x1B7D9A0", VA = "0x181B7EDA0")]
			[CompilerGenerated]
			get
			{
				return RoguelikeCopperBuffType.NONE;
			}
			[Token(Token = "0x60211CE")]
			[Address(RVA = "0x1B7F1C0", Offset = "0x1B7DDC0", VA = "0x181B7F1C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17004DB7 RID: 19895
		// (get) Token: 0x060211CF RID: 135631 RVA: 0x000B8968 File Offset: 0x000B6B68
		// (set) Token: 0x060211D0 RID: 135632 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004DB7")]
		public int sortId
		{
			[Token(Token = "0x60211CF")]
			[Address(RVA = "0x1B7F0A0", Offset = "0x1B7DCA0", VA = "0x181B7F0A0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x60211D0")]
			[Address(RVA = "0x1B7F5A0", Offset = "0x1B7E1A0", VA = "0x181B7F5A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17004DB8 RID: 19896
		// (get) Token: 0x060211D1 RID: 135633 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060211D2 RID: 135634 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004DB8")]
		public string layerCntDesc
		{
			[Token(Token = "0x60211D1")]
			[Address(RVA = "0x1B7EF20", Offset = "0x1B7DB20", VA = "0x181B7EF20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60211D2")]
			[Address(RVA = "0x1B7F3B0", Offset = "0x1B7DFB0", VA = "0x181B7F3B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17004DB9 RID: 19897
		// (get) Token: 0x060211D3 RID: 135635 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060211D4 RID: 135636 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004DB9")]
		public string desc
		{
			[Token(Token = "0x60211D3")]
			[Address(RVA = "0x1B7EE00", Offset = "0x1B7DA00", VA = "0x181B7EE00", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60211D4")]
			[Address(RVA = "0x1B7F230", Offset = "0x1B7DE30", VA = "0x181B7F230")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17004DBA RID: 19898
		// (get) Token: 0x060211D5 RID: 135637 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060211D6 RID: 135638 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004DBA")]
		public string usage
		{
			[Token(Token = "0x60211D5")]
			[Address(RVA = "0x1B7F160", Offset = "0x1B7DD60", VA = "0x181B7F160", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60211D6")]
			[Address(RVA = "0x1B7F690", Offset = "0x1B7E290", VA = "0x181B7F690")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17004DBB RID: 19899
		// (get) Token: 0x060211D7 RID: 135639 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060211D8 RID: 135640 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004DBB")]
		public string name
		{
			[Token(Token = "0x60211D7")]
			[Address(RVA = "0x1B7EFE0", Offset = "0x1B7DBE0", VA = "0x181B7EFE0", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60211D8")]
			[Address(RVA = "0x1B7F4A0", Offset = "0x1B7E0A0", VA = "0x181B7F4A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17004DBC RID: 19900
		// (get) Token: 0x060211D9 RID: 135641 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060211DA RID: 135642 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004DBC")]
		public List<string> poemList
		{
			[Token(Token = "0x60211D9")]
			[Address(RVA = "0x1B7F040", Offset = "0x1B7DC40", VA = "0x181B7F040")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60211DA")]
			[Address(RVA = "0x1B7F520", Offset = "0x1B7E120", VA = "0x181B7F520")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060211DB RID: 135643 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60211DB")]
		[Address(RVA = "0x1B7E700", Offset = "0x1B7D300", VA = "0x181B7E700")]
		public static RoguelikeGameCopperItemViewModel CreateByGameData(string topicId, string itemId)
		{
			return null;
		}

		// Token: 0x060211DC RID: 135644 RVA: 0x000B8980 File Offset: 0x000B6B80
		[Token(Token = "0x60211DC")]
		[Address(RVA = "0x1B7E530", Offset = "0x1B7D130", VA = "0x181B7E530", Slot = "12")]
		public int CompareTo(object obj)
		{
			return 0;
		}

		// Token: 0x060211DD RID: 135645 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60211DD")]
		[Address(RVA = "0x1B7ED40", Offset = "0x1B7D940", VA = "0x181B7ED40")]
		public RoguelikeGameCopperItemViewModel()
		{
		}

		// Token: 0x0402D15A RID: 184666
		[Token(Token = "0x402D15A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_topicId;

		// Token: 0x0402D15B RID: 184667
		[Token(Token = "0x402D15B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_topicId;

		// Token: 0x0402D15C RID: 184668
		[Token(Token = "0x402D15C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_itemId;

		// Token: 0x0402D15D RID: 184669
		[Token(Token = "0x402D15D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_itemId;

		// Token: 0x0402D15E RID: 184670
		[Token(Token = "0x402D15E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_gildIconId;

		// Token: 0x0402D15F RID: 184671
		[Token(Token = "0x402D15F")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_gildIconId;

		// Token: 0x0402D160 RID: 184672
		[Token(Token = "0x402D160")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_luckyLevel;

		// Token: 0x0402D161 RID: 184673
		[Token(Token = "0x402D161")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_set_luckyLevel;

		// Token: 0x0402D162 RID: 184674
		[Token(Token = "0x402D162")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_buffType;

		// Token: 0x0402D163 RID: 184675
		[Token(Token = "0x402D163")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_set_buffType;

		// Token: 0x0402D164 RID: 184676
		[Token(Token = "0x402D164")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_sortId;

		// Token: 0x0402D165 RID: 184677
		[Token(Token = "0x402D165")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_set_sortId;

		// Token: 0x0402D166 RID: 184678
		[Token(Token = "0x402D166")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_get_layerCntDesc;

		// Token: 0x0402D167 RID: 184679
		[Token(Token = "0x402D167")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_set_layerCntDesc;

		// Token: 0x0402D168 RID: 184680
		[Token(Token = "0x402D168")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_get_desc;

		// Token: 0x0402D169 RID: 184681
		[Token(Token = "0x402D169")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_set_desc;

		// Token: 0x0402D16A RID: 184682
		[Token(Token = "0x402D16A")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_get_usage;

		// Token: 0x0402D16B RID: 184683
		[Token(Token = "0x402D16B")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_set_usage;

		// Token: 0x0402D16C RID: 184684
		[Token(Token = "0x402D16C")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_get_name;

		// Token: 0x0402D16D RID: 184685
		[Token(Token = "0x402D16D")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_set_name;

		// Token: 0x0402D16E RID: 184686
		[Token(Token = "0x402D16E")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_get_poemList;

		// Token: 0x0402D16F RID: 184687
		[Token(Token = "0x402D16F")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_set_poemList;

		// Token: 0x0402D170 RID: 184688
		[Token(Token = "0x402D170")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_CreateByGameData;

		// Token: 0x0402D171 RID: 184689
		[Token(Token = "0x402D171")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_CompareTo;

		// Token: 0x0402D172 RID: 184690
		[Token(Token = "0x402D172")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
