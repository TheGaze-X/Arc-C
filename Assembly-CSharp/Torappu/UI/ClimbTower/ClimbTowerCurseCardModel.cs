using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005D3D RID: 23869
	[Token(Token = "0x2005D3D")]
	public class ClimbTowerCurseCardModel : IHotfixable
	{
		// Token: 0x17005155 RID: 20821
		// (get) Token: 0x06022916 RID: 141590 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005155")]
		public string cardName
		{
			[Token(Token = "0x6022916")]
			[Address(RVA = "0x1D173F0", Offset = "0x1D15FF0", VA = "0x181D173F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005156 RID: 20822
		// (get) Token: 0x06022917 RID: 141591 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005156")]
		public string cardDesc
		{
			[Token(Token = "0x6022917")]
			[Address(RVA = "0x1D17360", Offset = "0x1D15F60", VA = "0x181D17360")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005157 RID: 20823
		// (get) Token: 0x06022918 RID: 141592 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005157")]
		public Sprite iconSprite
		{
			[Token(Token = "0x6022918")]
			[Address(RVA = "0x1D17480", Offset = "0x1D16080", VA = "0x181D17480")]
			get
			{
				return null;
			}
		}

		// Token: 0x06022919 RID: 141593 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022919")]
		[Address(RVA = "0x1D171D0", Offset = "0x1D15DD0", VA = "0x181D171D0")]
		public void LoadData(string curseCardId)
		{
		}

		// Token: 0x0602291A RID: 141594 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602291A")]
		[Address(RVA = "0x1D17300", Offset = "0x1D15F00", VA = "0x181D17300")]
		public ClimbTowerCurseCardModel()
		{
		}

		// Token: 0x0402F82F RID: 194607
		[Token(Token = "0x402F82F")]
		[FieldOffset(Offset = "0x10")]
		private ClimbTowerCurseCardData m_curseCardData;

		// Token: 0x0402F830 RID: 194608
		[Token(Token = "0x402F830")]
		[FieldOffset(Offset = "0x18")]
		private Sprite m_iconSprite;

		// Token: 0x0402F831 RID: 194609
		[Token(Token = "0x402F831")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_cardName;

		// Token: 0x0402F832 RID: 194610
		[Token(Token = "0x402F832")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_cardDesc;

		// Token: 0x0402F833 RID: 194611
		[Token(Token = "0x402F833")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_iconSprite;

		// Token: 0x0402F834 RID: 194612
		[Token(Token = "0x402F834")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0402F835 RID: 194613
		[Token(Token = "0x402F835")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
