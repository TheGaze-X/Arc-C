using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.BattleFinish
{
	// Token: 0x0200621A RID: 25114
	[Token(Token = "0x200621A")]
	public abstract class BattleFinishDropRewardFrameView : MonoBehaviour, IHotfixable
	{
		// Token: 0x060243C3 RID: 148419
		[Token(Token = "0x60243C3")]
		public abstract void Render(BattleFinishDropRewardFrameHolder holder, DropInfoGroupViewModel dropInfoGroupViewModel);

		// Token: 0x060243C4 RID: 148420
		[Token(Token = "0x60243C4")]
		public abstract void SetLayout(LayoutGroup layoutGroup);

		// Token: 0x060243C5 RID: 148421 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60243C5")]
		[Address(RVA = "0x1F14390", Offset = "0x1F12F90", VA = "0x181F14390")]
		protected BattleFinishDropRewardFrameView()
		{
		}

		// Token: 0x04032628 RID: 206376
		[Token(Token = "0x4032628")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
