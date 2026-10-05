using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005CC2 RID: 23746
	[Token(Token = "0x2005CC2")]
	public class ClimbTowerInitGodMenuButton : ClimbTowerMenuButton
	{
		// Token: 0x0602260E RID: 140814 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602260E")]
		[Address(RVA = "0x1CD16F0", Offset = "0x1CD02F0", VA = "0x181CD16F0", Slot = "4")]
		public override void Render(IClimbTowerMenuButtonDataSource dataSource, bool fastMode)
		{
		}

		// Token: 0x0602260F RID: 140815 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602260F")]
		[Address(RVA = "0x1CD1800", Offset = "0x1CD0400", VA = "0x181CD1800")]
		public ClimbTowerInitGodMenuButton()
		{
		}

		// Token: 0x0402F3E5 RID: 193509
		[Token(Token = "0x402F3E5")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _selectPanel;

		// Token: 0x0402F3E6 RID: 193510
		[Token(Token = "0x402F3E6")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _unSelectPanel;

		// Token: 0x0402F3E7 RID: 193511
		[Token(Token = "0x402F3E7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402F3E8 RID: 193512
		[Token(Token = "0x402F3E8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005CC3 RID: 23747
		[Token(Token = "0x2005CC3")]
		public class DataSource : IClimbTowerMenuButtonDataSource, IHotfixable
		{
			// Token: 0x06022610 RID: 140816 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6022610")]
			[Address(RVA = "0x1CDE0A0", Offset = "0x1CDCCA0", VA = "0x181CDE0A0")]
			public DataSource()
			{
			}

			// Token: 0x0402F3E9 RID: 193513
			[Token(Token = "0x402F3E9")]
			[FieldOffset(Offset = "0x10")]
			public bool isSelect;

			// Token: 0x0402F3EA RID: 193514
			[Token(Token = "0x402F3EA")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
