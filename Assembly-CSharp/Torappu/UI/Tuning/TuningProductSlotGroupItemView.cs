using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Tuning
{
	// Token: 0x02003CE0 RID: 15584
	[Token(Token = "0x2003CE0")]
	public class TuningProductSlotGroupItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x060184BA RID: 99514 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60184BA")]
		[Address(RVA = "0x10CCE20", Offset = "0x10CBA20", VA = "0x1810CCE20")]
		public void Render(bool isShow)
		{
		}

		// Token: 0x060184BB RID: 99515 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60184BB")]
		[Address(RVA = "0x10CCF80", Offset = "0x10CBB80", VA = "0x1810CCF80")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060184BC RID: 99516 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60184BC")]
		[Address(RVA = "0x10CD070", Offset = "0x10CBC70", VA = "0x1810CD070")]
		public TuningProductSlotGroupItemView()
		{
		}

		// Token: 0x0401DAB7 RID: 121527
		[Token(Token = "0x401DAB7")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CanvasGroup _slotGroup;

		// Token: 0x0401DAB8 RID: 121528
		[Token(Token = "0x401DAB8")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _groupTweenDuration;

		// Token: 0x0401DAB9 RID: 121529
		[Token(Token = "0x401DAB9")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private bool _defaultShow;

		// Token: 0x0401DABA RID: 121530
		[Token(Token = "0x401DABA")]
		[FieldOffset(Offset = "0x28")]
		private FadeSwitchTween m_fadeSwitchTween;

		// Token: 0x0401DABB RID: 121531
		[Token(Token = "0x401DABB")]
		[FieldOffset(Offset = "0x30")]
		private bool m_isInited;

		// Token: 0x0401DABC RID: 121532
		[Token(Token = "0x401DABC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401DABD RID: 121533
		[Token(Token = "0x401DABD")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401DABE RID: 121534
		[Token(Token = "0x401DABE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
