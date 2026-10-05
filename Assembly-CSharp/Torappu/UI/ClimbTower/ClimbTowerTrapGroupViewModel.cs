using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005CF8 RID: 23800
	[Token(Token = "0x2005CF8")]
	public class ClimbTowerTrapGroupViewModel : IHotfixable
	{
		// Token: 0x17005111 RID: 20753
		// (get) Token: 0x06022755 RID: 141141 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005111")]
		public List<ClimbTowerTrapViewModel> itemList
		{
			[Token(Token = "0x6022755")]
			[Address(RVA = "0x1D0F420", Offset = "0x1D0E020", VA = "0x181D0F420")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005112 RID: 20754
		// (get) Token: 0x06022756 RID: 141142 RVA: 0x000BD918 File Offset: 0x000BBB18
		[Token(Token = "0x17005112")]
		public ClimbTowerTrapGroupViewModel.TrapGroupType trapGroupType
		{
			[Token(Token = "0x6022756")]
			[Address(RVA = "0x1D0F480", Offset = "0x1D0E080", VA = "0x181D0F480")]
			get
			{
				return ClimbTowerTrapGroupViewModel.TrapGroupType.NONE;
			}
		}

		// Token: 0x06022757 RID: 141143 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022757")]
		[Address(RVA = "0x1D0E910", Offset = "0x1D0D510", VA = "0x181D0E910")]
		public void InitData(ClimbTowerTrapGroupViewModel.TrapGroupType trapGroupType)
		{
		}

		// Token: 0x06022758 RID: 141144 RVA: 0x000BD930 File Offset: 0x000BBB30
		[Token(Token = "0x6022758")]
		[Address(RVA = "0x1D0ECE0", Offset = "0x1D0D8E0", VA = "0x181D0ECE0")]
		public bool IsEmpty()
		{
			return default(bool);
		}

		// Token: 0x06022759 RID: 141145 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022759")]
		[Address(RVA = "0x1D0F030", Offset = "0x1D0DC30", VA = "0x181D0F030")]
		private void _InitGodCardGroupData()
		{
		}

		// Token: 0x0602275A RID: 141146 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602275A")]
		[Address(RVA = "0x1D0EDA0", Offset = "0x1D0D9A0", VA = "0x181D0EDA0")]
		private void _InitCurseCardGroupData()
		{
		}

		// Token: 0x0602275B RID: 141147 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602275B")]
		[Address(RVA = "0x1D0F1C0", Offset = "0x1D0DDC0", VA = "0x181D0F1C0")]
		private void _InitTrapCardGroupData()
		{
		}

		// Token: 0x0602275C RID: 141148 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602275C")]
		[Address(RVA = "0x1D0F370", Offset = "0x1D0DF70", VA = "0x181D0F370")]
		public ClimbTowerTrapGroupViewModel()
		{
		}

		// Token: 0x0402F5E2 RID: 194018
		[Token(Token = "0x402F5E2")]
		[FieldOffset(Offset = "0x10")]
		private List<ClimbTowerTrapViewModel> m_trapList;

		// Token: 0x0402F5E3 RID: 194019
		[Token(Token = "0x402F5E3")]
		[FieldOffset(Offset = "0x18")]
		private ClimbTowerTrapGroupViewModel.TrapGroupType m_trapGroupType;

		// Token: 0x0402F5E4 RID: 194020
		[Token(Token = "0x402F5E4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_itemList;

		// Token: 0x0402F5E5 RID: 194021
		[Token(Token = "0x402F5E5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_trapGroupType;

		// Token: 0x0402F5E6 RID: 194022
		[Token(Token = "0x402F5E6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_InitData;

		// Token: 0x0402F5E7 RID: 194023
		[Token(Token = "0x402F5E7")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_IsEmpty;

		// Token: 0x0402F5E8 RID: 194024
		[Token(Token = "0x402F5E8")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__InitGodCardGroupData;

		// Token: 0x0402F5E9 RID: 194025
		[Token(Token = "0x402F5E9")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__InitCurseCardGroupData;

		// Token: 0x0402F5EA RID: 194026
		[Token(Token = "0x402F5EA")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__InitTrapCardGroupData;

		// Token: 0x0402F5EB RID: 194027
		[Token(Token = "0x402F5EB")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005CF9 RID: 23801
		[Token(Token = "0x2005CF9")]
		public enum TrapGroupType
		{
			// Token: 0x0402F5ED RID: 194029
			[Token(Token = "0x402F5ED")]
			NONE,
			// Token: 0x0402F5EE RID: 194030
			[Token(Token = "0x402F5EE")]
			GOD_CARD,
			// Token: 0x0402F5EF RID: 194031
			[Token(Token = "0x402F5EF")]
			CURSE_CARD,
			// Token: 0x0402F5F0 RID: 194032
			[Token(Token = "0x402F5F0")]
			TRAP_CARD
		}
	}
}
