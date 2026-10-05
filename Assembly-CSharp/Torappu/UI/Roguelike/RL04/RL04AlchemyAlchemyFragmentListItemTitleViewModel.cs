using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike.RL04
{
	// Token: 0x0200565F RID: 22111
	[Token(Token = "0x200565F")]
	public class RL04AlchemyAlchemyFragmentListItemTitleViewModel : IRL04AlchemyFragmentListItemViewModel, IHotfixable
	{
		// Token: 0x17004BEF RID: 19439
		// (get) Token: 0x060206E7 RID: 132839 RVA: 0x000B5DD0 File Offset: 0x000B3FD0
		// (set) Token: 0x060206E8 RID: 132840 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004BEF")]
		public RoguelikeFragmentType type
		{
			[Token(Token = "0x60206E7")]
			[Address(RVA = "0x1A8C0C0", Offset = "0x1A8ACC0", VA = "0x181A8C0C0")]
			[CompilerGenerated]
			get
			{
				return RoguelikeFragmentType.NONE;
			}
			[Token(Token = "0x60206E8")]
			[Address(RVA = "0x1A8C320", Offset = "0x1A8AF20", VA = "0x181A8C320")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17004BF0 RID: 19440
		// (get) Token: 0x060206E9 RID: 132841 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060206EA RID: 132842 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004BF0")]
		public string topicId
		{
			[Token(Token = "0x60206E9")]
			[Address(RVA = "0x1A8BF40", Offset = "0x1A8AB40", VA = "0x181A8BF40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60206EA")]
			[Address(RVA = "0x1A8C120", Offset = "0x1A8AD20", VA = "0x181A8C120")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17004BF1 RID: 19441
		// (get) Token: 0x060206EB RID: 132843 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060206EC RID: 132844 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004BF1")]
		public string typeName
		{
			[Token(Token = "0x60206EB")]
			[Address(RVA = "0x1A8C060", Offset = "0x1A8AC60", VA = "0x181A8C060")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60206EC")]
			[Address(RVA = "0x1A8C2A0", Offset = "0x1A8AEA0", VA = "0x181A8C2A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17004BF2 RID: 19442
		// (get) Token: 0x060206ED RID: 132845 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060206EE RID: 132846 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004BF2")]
		public string typeDesc
		{
			[Token(Token = "0x60206ED")]
			[Address(RVA = "0x1A8BFA0", Offset = "0x1A8ABA0", VA = "0x181A8BFA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60206EE")]
			[Address(RVA = "0x1A8C1A0", Offset = "0x1A8ADA0", VA = "0x181A8C1A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17004BF3 RID: 19443
		// (get) Token: 0x060206EF RID: 132847 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060206F0 RID: 132848 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004BF3")]
		public string typeIconId
		{
			[Token(Token = "0x60206EF")]
			[Address(RVA = "0x1A8C000", Offset = "0x1A8AC00", VA = "0x181A8C000")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60206F0")]
			[Address(RVA = "0x1A8C220", Offset = "0x1A8AE20", VA = "0x181A8C220")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060206F1 RID: 132849 RVA: 0x000B5DE8 File Offset: 0x000B3FE8
		[Token(Token = "0x60206F1")]
		[Address(RVA = "0x1A8BE80", Offset = "0x1A8AA80", VA = "0x181A8BE80", Slot = "4")]
		public RL04AlchemyFragmentListItemViewType GetViewType()
		{
			return RL04AlchemyFragmentListItemViewType.ROW_ITEM;
		}

		// Token: 0x060206F2 RID: 132850 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60206F2")]
		[Address(RVA = "0x1A8BEE0", Offset = "0x1A8AAE0", VA = "0x181A8BEE0")]
		public RL04AlchemyAlchemyFragmentListItemTitleViewModel()
		{
		}

		// Token: 0x0402BEB7 RID: 179895
		[Token(Token = "0x402BEB7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_type;

		// Token: 0x0402BEB8 RID: 179896
		[Token(Token = "0x402BEB8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_type;

		// Token: 0x0402BEB9 RID: 179897
		[Token(Token = "0x402BEB9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_topicId;

		// Token: 0x0402BEBA RID: 179898
		[Token(Token = "0x402BEBA")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_topicId;

		// Token: 0x0402BEBB RID: 179899
		[Token(Token = "0x402BEBB")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_typeName;

		// Token: 0x0402BEBC RID: 179900
		[Token(Token = "0x402BEBC")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_typeName;

		// Token: 0x0402BEBD RID: 179901
		[Token(Token = "0x402BEBD")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_typeDesc;

		// Token: 0x0402BEBE RID: 179902
		[Token(Token = "0x402BEBE")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_set_typeDesc;

		// Token: 0x0402BEBF RID: 179903
		[Token(Token = "0x402BEBF")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_typeIconId;

		// Token: 0x0402BEC0 RID: 179904
		[Token(Token = "0x402BEC0")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_set_typeIconId;

		// Token: 0x0402BEC1 RID: 179905
		[Token(Token = "0x402BEC1")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_GetViewType;

		// Token: 0x0402BEC2 RID: 179906
		[Token(Token = "0x402BEC2")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
