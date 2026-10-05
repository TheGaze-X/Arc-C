using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x020036ED RID: 14061
	[Token(Token = "0x20036ED")]
	[RequireComponent(typeof(RectTransform))]
	public class UITweenSize : BasicTween<RectSize>
	{
		// Token: 0x06016540 RID: 91456 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016540")]
		[Address(RVA = "0xED6280", Offset = "0xED4E80", VA = "0x180ED6280", Slot = "4")]
		protected override void OnInit()
		{
		}

		// Token: 0x06016541 RID: 91457 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6016541")]
		[Address(RVA = "0xED61E0", Offset = "0xED4DE0", VA = "0x180ED61E0", Slot = "5")]
		protected override RectSize GetTweenValue()
		{
			return null;
		}

		// Token: 0x06016542 RID: 91458 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016542")]
		[Address(RVA = "0xED6300", Offset = "0xED4F00", VA = "0x180ED6300", Slot = "6")]
		protected override void SetTweenValue(RectSize val)
		{
		}

		// Token: 0x06016543 RID: 91459 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6016543")]
		[Address(RVA = "0xED6020", Offset = "0xED4C20", VA = "0x180ED6020", Slot = "7")]
		protected override Tweener ConstructTweener(RectSize fromValue, RectSize toValue, float duration)
		{
			return null;
		}

		// Token: 0x06016544 RID: 91460 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016544")]
		[Address(RVA = "0xED63F0", Offset = "0xED4FF0", VA = "0x180ED63F0")]
		private void _OnTweenChanged(float value)
		{
		}

		// Token: 0x06016545 RID: 91461 RVA: 0x00090948 File Offset: 0x0008EB48
		[Token(Token = "0x6016545")]
		[Address(RVA = "0xED6390", Offset = "0xED4F90", VA = "0x180ED6390")]
		private float _GetTweenProcess()
		{
			return 0f;
		}

		// Token: 0x06016546 RID: 91462 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016546")]
		[Address(RVA = "0xED6540", Offset = "0xED5140", VA = "0x180ED6540")]
		public UITweenSize()
		{
		}

		// Token: 0x0401ADB3 RID: 110003
		[Token(Token = "0x401ADB3")]
		[FieldOffset(Offset = "0x58")]
		private RectTransform m_transform;

		// Token: 0x0401ADB4 RID: 110004
		[Token(Token = "0x401ADB4")]
		[FieldOffset(Offset = "0x60")]
		private float m_tweenProcess;

		// Token: 0x0401ADB5 RID: 110005
		[Token(Token = "0x401ADB5")]
		[FieldOffset(Offset = "0x68")]
		private RectSize m_tweenValue;

		// Token: 0x0401ADB6 RID: 110006
		[Token(Token = "0x401ADB6")]
		[FieldOffset(Offset = "0x70")]
		private RectSize m_from;

		// Token: 0x0401ADB7 RID: 110007
		[Token(Token = "0x401ADB7")]
		[FieldOffset(Offset = "0x78")]
		private RectSize m_to;

		// Token: 0x0401ADB8 RID: 110008
		[Token(Token = "0x401ADB8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x0401ADB9 RID: 110009
		[Token(Token = "0x401ADB9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetTweenValue;

		// Token: 0x0401ADBA RID: 110010
		[Token(Token = "0x401ADBA")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SetTweenValue;

		// Token: 0x0401ADBB RID: 110011
		[Token(Token = "0x401ADBB")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_ConstructTweener;

		// Token: 0x0401ADBC RID: 110012
		[Token(Token = "0x401ADBC")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnTweenChanged;

		// Token: 0x0401ADBD RID: 110013
		[Token(Token = "0x401ADBD")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__GetTweenProcess;

		// Token: 0x0401ADBE RID: 110014
		[Token(Token = "0x401ADBE")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
