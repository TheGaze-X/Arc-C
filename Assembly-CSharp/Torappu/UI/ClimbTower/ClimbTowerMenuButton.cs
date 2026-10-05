using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using XLua;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005CCE RID: 23758
	[Token(Token = "0x2005CCE")]
	public abstract class ClimbTowerMenuButton : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602265A RID: 140890
		[Token(Token = "0x602265A")]
		public abstract void Render(IClimbTowerMenuButtonDataSource dataSource, bool fastMode);

		// Token: 0x0602265B RID: 140891 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602265B")]
		[Address(RVA = "0x1CD2330", Offset = "0x1CD0F30", VA = "0x181CD2330")]
		public void OnButtonClicked()
		{
		}

		// Token: 0x0602265C RID: 140892 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602265C")]
		[Address(RVA = "0x1CD23A0", Offset = "0x1CD0FA0", VA = "0x181CD23A0")]
		protected ClimbTowerMenuButton()
		{
		}

		// Token: 0x0402F456 RID: 193622
		[Token(Token = "0x402F456")]
		[FieldOffset(Offset = "0x18")]
		[NonSerialized]
		public UnityEvent onClicked;

		// Token: 0x0402F457 RID: 193623
		[Token(Token = "0x402F457")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnButtonClicked;

		// Token: 0x0402F458 RID: 193624
		[Token(Token = "0x402F458")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
