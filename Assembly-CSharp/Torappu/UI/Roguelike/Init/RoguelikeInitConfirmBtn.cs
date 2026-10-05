using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike.Init
{
	// Token: 0x020057DD RID: 22493
	[Token(Token = "0x20057DD")]
	public class RoguelikeInitConfirmBtn : MonoBehaviour, IHotfixable
	{
		// Token: 0x06020E5B RID: 134747 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020E5B")]
		[Address(RVA = "0x1B38F50", Offset = "0x1B37B50", VA = "0x181B38F50")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06020E5C RID: 134748 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020E5C")]
		[Address(RVA = "0x1B38E50", Offset = "0x1B37A50", VA = "0x181B38E50")]
		public void InjectBtnEvents(Action onClick)
		{
		}

		// Token: 0x06020E5D RID: 134749 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020E5D")]
		[Address(RVA = "0x1B38DE0", Offset = "0x1B379E0", VA = "0x181B38DE0")]
		public void EventOnConfirm()
		{
		}

		// Token: 0x06020E5E RID: 134750 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020E5E")]
		[Address(RVA = "0x1B38FE0", Offset = "0x1B37BE0", VA = "0x181B38FE0")]
		public RoguelikeInitConfirmBtn()
		{
		}

		// Token: 0x0402CB40 RID: 183104
		[Token(Token = "0x402CB40")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private AnimationWrapper _anim;

		// Token: 0x0402CB41 RID: 183105
		[Token(Token = "0x402CB41")]
		private const string ARROW_ANIM = "init_enter_arrow";

		// Token: 0x0402CB42 RID: 183106
		[Token(Token = "0x402CB42")]
		[FieldOffset(Offset = "0x20")]
		private Action m_onClicked;

		// Token: 0x0402CB43 RID: 183107
		[Token(Token = "0x402CB43")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402CB44 RID: 183108
		[Token(Token = "0x402CB44")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_InjectBtnEvents;

		// Token: 0x0402CB45 RID: 183109
		[Token(Token = "0x402CB45")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_EventOnConfirm;

		// Token: 0x0402CB46 RID: 183110
		[Token(Token = "0x402CB46")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
