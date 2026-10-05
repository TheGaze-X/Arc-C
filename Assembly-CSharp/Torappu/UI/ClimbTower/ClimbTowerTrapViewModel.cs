using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005CFB RID: 23803
	[Token(Token = "0x2005CFB")]
	public class ClimbTowerTrapViewModel : IHotfixable
	{
		// Token: 0x17005113 RID: 20755
		// (get) Token: 0x0602275D RID: 141149 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005113")]
		public string trapId
		{
			[Token(Token = "0x602275D")]
			[Address(RVA = "0x1D11740", Offset = "0x1D10340", VA = "0x181D11740")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005114 RID: 20756
		// (get) Token: 0x0602275E RID: 141150 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005114")]
		public string trapName
		{
			[Token(Token = "0x602275E")]
			[Address(RVA = "0x1D117A0", Offset = "0x1D103A0", VA = "0x181D117A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005115 RID: 20757
		// (get) Token: 0x0602275F RID: 141151 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005115")]
		public string trapDesc
		{
			[Token(Token = "0x602275F")]
			[Address(RVA = "0x1D116E0", Offset = "0x1D102E0", VA = "0x181D116E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005116 RID: 20758
		// (get) Token: 0x06022760 RID: 141152 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005116")]
		public string iconId
		{
			[Token(Token = "0x6022760")]
			[Address(RVA = "0x1D11680", Offset = "0x1D10280", VA = "0x181D11680")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005117 RID: 20759
		// (get) Token: 0x06022761 RID: 141153 RVA: 0x000BD948 File Offset: 0x000BBB48
		[Token(Token = "0x17005117")]
		public ClimbTowerTrapType trapType
		{
			[Token(Token = "0x6022761")]
			[Address(RVA = "0x1D11800", Offset = "0x1D10400", VA = "0x181D11800")]
			get
			{
				return ClimbTowerTrapType.NONE;
			}
		}

		// Token: 0x06022762 RID: 141154 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022762")]
		[Address(RVA = "0x1D10BB0", Offset = "0x1D0F7B0", VA = "0x181D10BB0")]
		public void InitData(string trapId, ClimbTowerTrapType trapType)
		{
		}

		// Token: 0x06022763 RID: 141155 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022763")]
		[Address(RVA = "0x1D11140", Offset = "0x1D0FD40", VA = "0x181D11140")]
		private void _InitMainCardData(string cardId)
		{
		}

		// Token: 0x06022764 RID: 141156 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022764")]
		[Address(RVA = "0x1D11260", Offset = "0x1D0FE60", VA = "0x181D11260")]
		private void _InitSubCardData(string cardId)
		{
		}

		// Token: 0x06022765 RID: 141157 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022765")]
		[Address(RVA = "0x1D11010", Offset = "0x1D0FC10", VA = "0x181D11010")]
		private void _InitCurseCardData(string cardId)
		{
		}

		// Token: 0x06022766 RID: 141158 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022766")]
		[Address(RVA = "0x1D113C0", Offset = "0x1D0FFC0", VA = "0x181D113C0")]
		private void _InitTrapData(string trapId)
		{
		}

		// Token: 0x06022767 RID: 141159 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022767")]
		[Address(RVA = "0x1D11620", Offset = "0x1D10220", VA = "0x181D11620")]
		public ClimbTowerTrapViewModel()
		{
		}

		// Token: 0x0402F5F7 RID: 194039
		[Token(Token = "0x402F5F7")]
		[FieldOffset(Offset = "0x10")]
		private string m_trapId;

		// Token: 0x0402F5F8 RID: 194040
		[Token(Token = "0x402F5F8")]
		[FieldOffset(Offset = "0x18")]
		private string m_trapName;

		// Token: 0x0402F5F9 RID: 194041
		[Token(Token = "0x402F5F9")]
		[FieldOffset(Offset = "0x20")]
		private string m_trapDesc;

		// Token: 0x0402F5FA RID: 194042
		[Token(Token = "0x402F5FA")]
		[FieldOffset(Offset = "0x28")]
		private string m_iconId;

		// Token: 0x0402F5FB RID: 194043
		[Token(Token = "0x402F5FB")]
		[FieldOffset(Offset = "0x30")]
		private ClimbTowerTrapType m_trapType;

		// Token: 0x0402F5FC RID: 194044
		[Token(Token = "0x402F5FC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_trapId;

		// Token: 0x0402F5FD RID: 194045
		[Token(Token = "0x402F5FD")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_trapName;

		// Token: 0x0402F5FE RID: 194046
		[Token(Token = "0x402F5FE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_trapDesc;

		// Token: 0x0402F5FF RID: 194047
		[Token(Token = "0x402F5FF")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_iconId;

		// Token: 0x0402F600 RID: 194048
		[Token(Token = "0x402F600")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_trapType;

		// Token: 0x0402F601 RID: 194049
		[Token(Token = "0x402F601")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_InitData;

		// Token: 0x0402F602 RID: 194050
		[Token(Token = "0x402F602")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__InitMainCardData;

		// Token: 0x0402F603 RID: 194051
		[Token(Token = "0x402F603")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__InitSubCardData;

		// Token: 0x0402F604 RID: 194052
		[Token(Token = "0x402F604")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__InitCurseCardData;

		// Token: 0x0402F605 RID: 194053
		[Token(Token = "0x402F605")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__InitTrapData;

		// Token: 0x0402F606 RID: 194054
		[Token(Token = "0x402F606")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
