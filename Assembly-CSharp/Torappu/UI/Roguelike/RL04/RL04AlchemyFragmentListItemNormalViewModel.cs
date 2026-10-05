using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike.RL04
{
	// Token: 0x02005661 RID: 22113
	[Token(Token = "0x2005661")]
	public class RL04AlchemyFragmentListItemNormalViewModel : IComparable<RL04AlchemyFragmentListItemNormalViewModel>, IHotfixable
	{
		// Token: 0x17004BF4 RID: 19444
		// (get) Token: 0x060206F5 RID: 132853 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004BF4")]
		public RL04AlchemyFragmentItemViewModel fragmentItemViewModel
		{
			[Token(Token = "0x60206F5")]
			[Address(RVA = "0x1A931F0", Offset = "0x1A91DF0", VA = "0x181A931F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004BF5 RID: 19445
		// (get) Token: 0x060206F6 RID: 132854 RVA: 0x000B5E18 File Offset: 0x000B4018
		[Token(Token = "0x17004BF5")]
		public bool isSelected
		{
			[Token(Token = "0x60206F6")]
			[Address(RVA = "0x1A93480", Offset = "0x1A92080", VA = "0x181A93480")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17004BF6 RID: 19446
		// (get) Token: 0x060206F7 RID: 132855 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004BF6")]
		public string instId
		{
			[Token(Token = "0x60206F7")]
			[Address(RVA = "0x1A93250", Offset = "0x1A91E50", VA = "0x181A93250")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004BF7 RID: 19447
		// (get) Token: 0x060206F8 RID: 132856 RVA: 0x000B5E30 File Offset: 0x000B4030
		[Token(Token = "0x17004BF7")]
		public bool isEmpty
		{
			[Token(Token = "0x60206F8")]
			[Address(RVA = "0x1A933B0", Offset = "0x1A91FB0", VA = "0x181A933B0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060206F9 RID: 132857 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60206F9")]
		[Address(RVA = "0x1A93060", Offset = "0x1A91C60", VA = "0x181A93060")]
		public void LoadData(RL04AlchemyFragmentItemViewModel itemViewModel)
		{
		}

		// Token: 0x060206FA RID: 132858 RVA: 0x000B5E48 File Offset: 0x000B4048
		[Token(Token = "0x60206FA")]
		[Address(RVA = "0x1A92EB0", Offset = "0x1A91AB0", VA = "0x181A92EB0", Slot = "4")]
		public int CompareTo(RL04AlchemyFragmentListItemNormalViewModel other)
		{
			return 0;
		}

		// Token: 0x060206FB RID: 132859 RVA: 0x000B5E60 File Offset: 0x000B4060
		[Token(Token = "0x60206FB")]
		[Address(RVA = "0x1A930E0", Offset = "0x1A91CE0", VA = "0x181A930E0")]
		private static int _TypeComparison(RoguelikeFragmentType x, RoguelikeFragmentType y)
		{
			return 0;
		}

		// Token: 0x060206FC RID: 132860 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60206FC")]
		[Address(RVA = "0x1A93190", Offset = "0x1A91D90", VA = "0x181A93190")]
		public RL04AlchemyFragmentListItemNormalViewModel()
		{
		}

		// Token: 0x0402BEC6 RID: 179910
		[Token(Token = "0x402BEC6")]
		[FieldOffset(Offset = "0x10")]
		private RL04AlchemyFragmentItemViewModel m_fragmentItemViewModel;

		// Token: 0x0402BEC7 RID: 179911
		[Token(Token = "0x402BEC7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_fragmentItemViewModel;

		// Token: 0x0402BEC8 RID: 179912
		[Token(Token = "0x402BEC8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_isSelected;

		// Token: 0x0402BEC9 RID: 179913
		[Token(Token = "0x402BEC9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_instId;

		// Token: 0x0402BECA RID: 179914
		[Token(Token = "0x402BECA")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_isEmpty;

		// Token: 0x0402BECB RID: 179915
		[Token(Token = "0x402BECB")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0402BECC RID: 179916
		[Token(Token = "0x402BECC")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_CompareTo;

		// Token: 0x0402BECD RID: 179917
		[Token(Token = "0x402BECD")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__TypeComparison;

		// Token: 0x0402BECE RID: 179918
		[Token(Token = "0x402BECE")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
