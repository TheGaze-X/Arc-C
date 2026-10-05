using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005CF7 RID: 23799
	[Token(Token = "0x2005CF7")]
	public class ClimbTowerTrapStateBean : IStateBean, IHotfixable
	{
		// Token: 0x1700510C RID: 20748
		// (get) Token: 0x0602274E RID: 141134 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700510C")]
		public string seasonId
		{
			[Token(Token = "0x602274E")]
			[Address(RVA = "0x1D10020", Offset = "0x1D0EC20", VA = "0x181D10020")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700510D RID: 20749
		// (get) Token: 0x0602274F RID: 141135 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700510D")]
		public List<ClimbTowerTrapGroupViewModel> groupViewModels
		{
			[Token(Token = "0x602274F")]
			[Address(RVA = "0x1D0FFC0", Offset = "0x1D0EBC0", VA = "0x181D0FFC0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700510E RID: 20750
		// (get) Token: 0x06022750 RID: 141136 RVA: 0x000BD8D0 File Offset: 0x000BBAD0
		[Token(Token = "0x1700510E")]
		public bool showBuffBtn
		{
			[Token(Token = "0x6022750")]
			[Address(RVA = "0x1D10080", Offset = "0x1D0EC80", VA = "0x181D10080")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700510F RID: 20751
		// (get) Token: 0x06022751 RID: 141137 RVA: 0x000BD8E8 File Offset: 0x000BBAE8
		[Token(Token = "0x1700510F")]
		public bool showSquadBtn
		{
			[Token(Token = "0x6022751")]
			[Address(RVA = "0x1D10140", Offset = "0x1D0ED40", VA = "0x181D10140")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17005110 RID: 20752
		// (get) Token: 0x06022752 RID: 141138 RVA: 0x000BD900 File Offset: 0x000BBB00
		[Token(Token = "0x17005110")]
		public bool showProfessionBtns
		{
			[Token(Token = "0x6022752")]
			[Address(RVA = "0x1D100E0", Offset = "0x1D0ECE0", VA = "0x181D100E0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06022753 RID: 141139 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022753")]
		[Address(RVA = "0x1D0FC60", Offset = "0x1D0E860", VA = "0x181D0FC60")]
		public void InitData()
		{
		}

		// Token: 0x06022754 RID: 141140 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022754")]
		[Address(RVA = "0x1D0FF10", Offset = "0x1D0EB10", VA = "0x181D0FF10")]
		public ClimbTowerTrapStateBean()
		{
		}

		// Token: 0x0402F5D6 RID: 194006
		[Token(Token = "0x402F5D6")]
		[FieldOffset(Offset = "0x10")]
		private List<ClimbTowerTrapGroupViewModel> m_groupViewModels;

		// Token: 0x0402F5D7 RID: 194007
		[Token(Token = "0x402F5D7")]
		[FieldOffset(Offset = "0x18")]
		private string m_seaonId;

		// Token: 0x0402F5D8 RID: 194008
		[Token(Token = "0x402F5D8")]
		[FieldOffset(Offset = "0x20")]
		private bool m_showBuffBtn;

		// Token: 0x0402F5D9 RID: 194009
		[Token(Token = "0x402F5D9")]
		[FieldOffset(Offset = "0x21")]
		private bool m_showSquadBtn;

		// Token: 0x0402F5DA RID: 194010
		[Token(Token = "0x402F5DA")]
		[FieldOffset(Offset = "0x22")]
		private bool m_showProfessionBtns;

		// Token: 0x0402F5DB RID: 194011
		[Token(Token = "0x402F5DB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_seasonId;

		// Token: 0x0402F5DC RID: 194012
		[Token(Token = "0x402F5DC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_groupViewModels;

		// Token: 0x0402F5DD RID: 194013
		[Token(Token = "0x402F5DD")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_showBuffBtn;

		// Token: 0x0402F5DE RID: 194014
		[Token(Token = "0x402F5DE")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_showSquadBtn;

		// Token: 0x0402F5DF RID: 194015
		[Token(Token = "0x402F5DF")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_showProfessionBtns;

		// Token: 0x0402F5E0 RID: 194016
		[Token(Token = "0x402F5E0")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_InitData;

		// Token: 0x0402F5E1 RID: 194017
		[Token(Token = "0x402F5E1")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
