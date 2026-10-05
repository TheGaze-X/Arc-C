using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act1VHalfIdle
{
	// Token: 0x0200770A RID: 30474
	[Token(Token = "0x200770A")]
	public class Act1VHalfIdleCharLevelUpgradeEliteView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602ACFC RID: 175356 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602ACFC")]
		[Address(RVA = "0x2696020", Offset = "0x2694C20", VA = "0x182696020")]
		public void Render(Act1VHalfIdleCharUpgradeViewModel viewModel, Act1VHalfIdleCharLevelUpgradeNotFullView.ShowStatus showStatus, bool isInit)
		{
		}

		// Token: 0x0602ACFD RID: 175357 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602ACFD")]
		[Address(RVA = "0x2696110", Offset = "0x2694D10", VA = "0x182696110")]
		public Act1VHalfIdleCharLevelUpgradeEliteView()
		{
		}

		// Token: 0x0403DB1B RID: 252699
		[Token(Token = "0x403DB1B")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _imgEvolveBefore;

		// Token: 0x0403DB1C RID: 252700
		[Token(Token = "0x403DB1C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _imgEvolveAfter;

		// Token: 0x0403DB1D RID: 252701
		[Token(Token = "0x403DB1D")]
		[FieldOffset(Offset = "0x28")]
		private int m_cachedEliteId;

		// Token: 0x0403DB1E RID: 252702
		[Token(Token = "0x403DB1E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403DB1F RID: 252703
		[Token(Token = "0x403DB1F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
