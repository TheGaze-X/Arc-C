using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x020036EC RID: 14060
	[Token(Token = "0x20036EC")]
	[RequireComponent(typeof(RectTransform))]
	public class UITweenPosition : BasicTween<RectPosition>
	{
		// Token: 0x06016539 RID: 91449 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016539")]
		[Address(RVA = "0xED5C30", Offset = "0xED4830", VA = "0x180ED5C30", Slot = "4")]
		protected override void OnInit()
		{
		}

		// Token: 0x0601653A RID: 91450 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601653A")]
		[Address(RVA = "0xED5B90", Offset = "0xED4790", VA = "0x180ED5B90", Slot = "5")]
		protected override RectPosition GetTweenValue()
		{
			return null;
		}

		// Token: 0x0601653B RID: 91451 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601653B")]
		[Address(RVA = "0xED5CB0", Offset = "0xED48B0", VA = "0x180ED5CB0", Slot = "6")]
		protected override void SetTweenValue(RectPosition val)
		{
		}

		// Token: 0x0601653C RID: 91452 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601653C")]
		[Address(RVA = "0xED59D0", Offset = "0xED45D0", VA = "0x180ED59D0", Slot = "7")]
		protected override Tweener ConstructTweener(RectPosition fromValue, RectPosition toValue, float duration)
		{
			return null;
		}

		// Token: 0x0601653D RID: 91453 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601653D")]
		[Address(RVA = "0xED5DA0", Offset = "0xED49A0", VA = "0x180ED5DA0")]
		private void _OnTweenChanged(float value)
		{
		}

		// Token: 0x0601653E RID: 91454 RVA: 0x00090930 File Offset: 0x0008EB30
		[Token(Token = "0x601653E")]
		[Address(RVA = "0xED5D40", Offset = "0xED4940", VA = "0x180ED5D40")]
		private float _GetTweenProcess()
		{
			return 0f;
		}

		// Token: 0x0601653F RID: 91455 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601653F")]
		[Address(RVA = "0xED5EF0", Offset = "0xED4AF0", VA = "0x180ED5EF0")]
		public UITweenPosition()
		{
		}

		// Token: 0x0401ADA7 RID: 109991
		[Token(Token = "0x401ADA7")]
		[FieldOffset(Offset = "0x58")]
		private RectTransform m_transform;

		// Token: 0x0401ADA8 RID: 109992
		[Token(Token = "0x401ADA8")]
		[FieldOffset(Offset = "0x60")]
		private float m_tweenProcess;

		// Token: 0x0401ADA9 RID: 109993
		[Token(Token = "0x401ADA9")]
		[FieldOffset(Offset = "0x68")]
		private RectPosition m_tweenValue;

		// Token: 0x0401ADAA RID: 109994
		[Token(Token = "0x401ADAA")]
		[FieldOffset(Offset = "0x70")]
		private RectPosition m_from;

		// Token: 0x0401ADAB RID: 109995
		[Token(Token = "0x401ADAB")]
		[FieldOffset(Offset = "0x78")]
		private RectPosition m_to;

		// Token: 0x0401ADAC RID: 109996
		[Token(Token = "0x401ADAC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x0401ADAD RID: 109997
		[Token(Token = "0x401ADAD")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetTweenValue;

		// Token: 0x0401ADAE RID: 109998
		[Token(Token = "0x401ADAE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SetTweenValue;

		// Token: 0x0401ADAF RID: 109999
		[Token(Token = "0x401ADAF")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_ConstructTweener;

		// Token: 0x0401ADB0 RID: 110000
		[Token(Token = "0x401ADB0")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnTweenChanged;

		// Token: 0x0401ADB1 RID: 110001
		[Token(Token = "0x401ADB1")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__GetTweenProcess;

		// Token: 0x0401ADB2 RID: 110002
		[Token(Token = "0x401ADB2")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
