using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005CD5 RID: 23765
	[Token(Token = "0x2005CD5")]
	public class ClimbTowerSquadEditMenuButton : ClimbTowerMenuButton
	{
		// Token: 0x06022675 RID: 140917 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022675")]
		[Address(RVA = "0x1CD66F0", Offset = "0x1CD52F0", VA = "0x181CD66F0", Slot = "4")]
		public override void Render(IClimbTowerMenuButtonDataSource dataSource, bool fastMode)
		{
		}

		// Token: 0x06022676 RID: 140918 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022676")]
		[Address(RVA = "0x1CD6840", Offset = "0x1CD5440", VA = "0x181CD6840")]
		public ClimbTowerSquadEditMenuButton()
		{
		}

		// Token: 0x0402F47D RID: 193661
		[Token(Token = "0x402F47D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIAtlasImage _imgBtnBkg;

		// Token: 0x0402F47E RID: 193662
		[Token(Token = "0x402F47E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIAtlasObject _atlasObject;

		// Token: 0x0402F47F RID: 193663
		[Token(Token = "0x402F47F")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private string _normalBkgId;

		// Token: 0x0402F480 RID: 193664
		[Token(Token = "0x402F480")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private string _hardBkgId;

		// Token: 0x0402F481 RID: 193665
		[Token(Token = "0x402F481")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402F482 RID: 193666
		[Token(Token = "0x402F482")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005CD6 RID: 23766
		[Token(Token = "0x2005CD6")]
		public class DataSource : IClimbTowerMenuButtonDataSource, IHotfixable
		{
			// Token: 0x06022677 RID: 140919 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6022677")]
			[Address(RVA = "0x1CDE160", Offset = "0x1CDCD60", VA = "0x181CDE160")]
			public DataSource()
			{
			}

			// Token: 0x0402F483 RID: 193667
			[Token(Token = "0x402F483")]
			[FieldOffset(Offset = "0x10")]
			public bool isHard;

			// Token: 0x0402F484 RID: 193668
			[Token(Token = "0x402F484")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
