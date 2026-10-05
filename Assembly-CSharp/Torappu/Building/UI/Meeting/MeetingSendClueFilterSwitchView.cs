using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Building.UI.Meeting
{
	// Token: 0x02001D7A RID: 7546
	[Token(Token = "0x2001D7A")]
	public class MeetingSendClueFilterSwitchView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0600BA5C RID: 47708 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA5C")]
		[Address(RVA = "0x3380C90", Offset = "0x337F890", VA = "0x183380C90")]
		public void UpdateSwitch(bool isActive)
		{
		}

		// Token: 0x0600BA5D RID: 47709 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA5D")]
		[Address(RVA = "0x3380D40", Offset = "0x337F940", VA = "0x183380D40")]
		public MeetingSendClueFilterSwitchView()
		{
		}

		// Token: 0x0400B97A RID: 47482
		[Token(Token = "0x400B97A")]
		private const string BUTTON_SWITCH_ON = "filterIsOn";

		// Token: 0x0400B97B RID: 47483
		[Token(Token = "0x400B97B")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Animator _switchAnimator;

		// Token: 0x0400B97C RID: 47484
		[Token(Token = "0x400B97C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_UpdateSwitch;

		// Token: 0x0400B97D RID: 47485
		[Token(Token = "0x400B97D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
