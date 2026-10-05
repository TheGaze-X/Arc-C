using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI.Roguelike.Fragment;
using XLua;

namespace Torappu.UI.Roguelike.RL04
{
	// Token: 0x02005662 RID: 22114
	[Token(Token = "0x2005662")]
	public class RL04AlchemyFragmentItemViewModel : IRoguelikeFragmentItemModel, IHotfixable, IComparable
	{
		// Token: 0x17004BF8 RID: 19448
		// (get) Token: 0x060206FD RID: 132861 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060206FE RID: 132862 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004BF8")]
		public string instId
		{
			[Token(Token = "0x60206FD")]
			[Address(RVA = "0x1A91D80", Offset = "0x1A90980", VA = "0x181A91D80", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60206FE")]
			[Address(RVA = "0x1A921A0", Offset = "0x1A90DA0", VA = "0x181A921A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17004BF9 RID: 19449
		// (get) Token: 0x060206FF RID: 132863 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06020700 RID: 132864 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004BF9")]
		public string fragmentId
		{
			[Token(Token = "0x60206FF")]
			[Address(RVA = "0x1A91CC0", Offset = "0x1A908C0", VA = "0x181A91CC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6020700")]
			[Address(RVA = "0x1A920A0", Offset = "0x1A90CA0", VA = "0x181A920A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17004BFA RID: 19450
		// (get) Token: 0x06020701 RID: 132865 RVA: 0x000B5E78 File Offset: 0x000B4078
		// (set) Token: 0x06020702 RID: 132866 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004BFA")]
		public RoguelikeFragmentType type
		{
			[Token(Token = "0x6020701")]
			[Address(RVA = "0x1A91EA0", Offset = "0x1A90AA0", VA = "0x181A91EA0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return RoguelikeFragmentType.NONE;
			}
			[Token(Token = "0x6020702")]
			[Address(RVA = "0x1A92310", Offset = "0x1A90F10", VA = "0x181A92310")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17004BFB RID: 19451
		// (get) Token: 0x06020703 RID: 132867 RVA: 0x000B5E90 File Offset: 0x000B4090
		// (set) Token: 0x06020704 RID: 132868 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004BFB")]
		public int weight
		{
			[Token(Token = "0x6020703")]
			[Address(RVA = "0x1A91FC0", Offset = "0x1A90BC0", VA = "0x181A91FC0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6020704")]
			[Address(RVA = "0x1A92470", Offset = "0x1A91070", VA = "0x181A92470")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17004BFC RID: 19452
		// (get) Token: 0x06020705 RID: 132869 RVA: 0x000B5EA8 File Offset: 0x000B40A8
		// (set) Token: 0x06020706 RID: 132870 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004BFC")]
		public int value
		{
			[Token(Token = "0x6020705")]
			[Address(RVA = "0x1A91F60", Offset = "0x1A90B60", VA = "0x181A91F60", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6020706")]
			[Address(RVA = "0x1A92400", Offset = "0x1A91000", VA = "0x181A92400")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17004BFD RID: 19453
		// (get) Token: 0x06020707 RID: 132871 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06020708 RID: 132872 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004BFD")]
		public string name
		{
			[Token(Token = "0x6020707")]
			[Address(RVA = "0x1A91E40", Offset = "0x1A90A40", VA = "0x181A91E40", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6020708")]
			[Address(RVA = "0x1A92290", Offset = "0x1A90E90", VA = "0x181A92290")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17004BFE RID: 19454
		// (get) Token: 0x06020709 RID: 132873 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602070A RID: 132874 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004BFE")]
		public string iconId
		{
			[Token(Token = "0x6020709")]
			[Address(RVA = "0x1A91D20", Offset = "0x1A90920", VA = "0x181A91D20", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x602070A")]
			[Address(RVA = "0x1A92120", Offset = "0x1A90D20", VA = "0x181A92120")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17004BFF RID: 19455
		// (get) Token: 0x0602070B RID: 132875 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602070C RID: 132876 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004BFF")]
		public string desc
		{
			[Token(Token = "0x602070B")]
			[Address(RVA = "0x1A91C60", Offset = "0x1A90860", VA = "0x181A91C60", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x602070C")]
			[Address(RVA = "0x1A92020", Offset = "0x1A90C20", VA = "0x181A92020")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17004C00 RID: 19456
		// (get) Token: 0x0602070D RID: 132877 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602070E RID: 132878 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004C00")]
		public string usage
		{
			[Token(Token = "0x602070D")]
			[Address(RVA = "0x1A91F00", Offset = "0x1A90B00", VA = "0x181A91F00", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x602070E")]
			[Address(RVA = "0x1A92380", Offset = "0x1A90F80", VA = "0x181A92380")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17004C01 RID: 19457
		// (get) Token: 0x0602070F RID: 132879 RVA: 0x000B5EC0 File Offset: 0x000B40C0
		// (set) Token: 0x06020710 RID: 132880 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004C01")]
		public bool isSelected
		{
			[Token(Token = "0x602070F")]
			[Address(RVA = "0x1A91DE0", Offset = "0x1A909E0", VA = "0x181A91DE0", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6020710")]
			[Address(RVA = "0x1A92220", Offset = "0x1A90E20", VA = "0x181A92220")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06020711 RID: 132881 RVA: 0x000B5ED8 File Offset: 0x000B40D8
		[Token(Token = "0x6020711")]
		[Address(RVA = "0x1A91940", Offset = "0x1A90540", VA = "0x181A91940", Slot = "13")]
		public int CompareTo(object obj)
		{
			return 0;
		}

		// Token: 0x06020712 RID: 132882 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020712")]
		[Address(RVA = "0x1A91C00", Offset = "0x1A90800", VA = "0x181A91C00")]
		public RL04AlchemyFragmentItemViewModel()
		{
		}

		// Token: 0x0402BED9 RID: 179929
		[Token(Token = "0x402BED9")]
		[FieldOffset(Offset = "0x54")]
		public int sortId;

		// Token: 0x0402BEDA RID: 179930
		[Token(Token = "0x402BEDA")]
		[FieldOffset(Offset = "0x58")]
		public long ts;

		// Token: 0x0402BEDB RID: 179931
		[Token(Token = "0x402BEDB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_instId;

		// Token: 0x0402BEDC RID: 179932
		[Token(Token = "0x402BEDC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_instId;

		// Token: 0x0402BEDD RID: 179933
		[Token(Token = "0x402BEDD")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_fragmentId;

		// Token: 0x0402BEDE RID: 179934
		[Token(Token = "0x402BEDE")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_fragmentId;

		// Token: 0x0402BEDF RID: 179935
		[Token(Token = "0x402BEDF")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_type;

		// Token: 0x0402BEE0 RID: 179936
		[Token(Token = "0x402BEE0")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_type;

		// Token: 0x0402BEE1 RID: 179937
		[Token(Token = "0x402BEE1")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_weight;

		// Token: 0x0402BEE2 RID: 179938
		[Token(Token = "0x402BEE2")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_set_weight;

		// Token: 0x0402BEE3 RID: 179939
		[Token(Token = "0x402BEE3")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_value;

		// Token: 0x0402BEE4 RID: 179940
		[Token(Token = "0x402BEE4")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_set_value;

		// Token: 0x0402BEE5 RID: 179941
		[Token(Token = "0x402BEE5")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_name;

		// Token: 0x0402BEE6 RID: 179942
		[Token(Token = "0x402BEE6")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_set_name;

		// Token: 0x0402BEE7 RID: 179943
		[Token(Token = "0x402BEE7")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_get_iconId;

		// Token: 0x0402BEE8 RID: 179944
		[Token(Token = "0x402BEE8")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_set_iconId;

		// Token: 0x0402BEE9 RID: 179945
		[Token(Token = "0x402BEE9")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_get_desc;

		// Token: 0x0402BEEA RID: 179946
		[Token(Token = "0x402BEEA")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_set_desc;

		// Token: 0x0402BEEB RID: 179947
		[Token(Token = "0x402BEEB")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_get_usage;

		// Token: 0x0402BEEC RID: 179948
		[Token(Token = "0x402BEEC")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_set_usage;

		// Token: 0x0402BEED RID: 179949
		[Token(Token = "0x402BEED")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_get_isSelected;

		// Token: 0x0402BEEE RID: 179950
		[Token(Token = "0x402BEEE")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_set_isSelected;

		// Token: 0x0402BEEF RID: 179951
		[Token(Token = "0x402BEEF")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_CompareTo;

		// Token: 0x0402BEF0 RID: 179952
		[Token(Token = "0x402BEF0")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
