using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.TemplateMission
{
	// Token: 0x02003D99 RID: 15769
	[Token(Token = "0x2003D99")]
	public class TemplateMissionCommonEntryFadeTween : MonoBehaviour, ITemplateMissionEntryTween, IHotfixable
	{
		// Token: 0x17003A7D RID: 14973
		// (get) Token: 0x0601886C RID: 100460 RVA: 0x0009AA58 File Offset: 0x00098C58
		[Token(Token = "0x17003A7D")]
		public float entryDelay
		{
			[Token(Token = "0x601886C")]
			[Address(RVA = "0x110C750", Offset = "0x110B350", VA = "0x18110C750", Slot = "4")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17003A7E RID: 14974
		// (get) Token: 0x0601886D RID: 100461 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003A7E")]
		public Tween entryTween
		{
			[Token(Token = "0x601886D")]
			[Address(RVA = "0x110C7B0", Offset = "0x110B3B0", VA = "0x18110C7B0", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601886E RID: 100462 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601886E")]
		[Address(RVA = "0x110C670", Offset = "0x110B270", VA = "0x18110C670", Slot = "6")]
		public void ResetTween()
		{
		}

		// Token: 0x0601886F RID: 100463 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601886F")]
		[Address(RVA = "0x110C6E0", Offset = "0x110B2E0", VA = "0x18110C6E0")]
		public TemplateMissionCommonEntryFadeTween()
		{
		}

		// Token: 0x0401E121 RID: 123169
		[Token(Token = "0x401E121")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float _fadeInDur;

		// Token: 0x0401E122 RID: 123170
		[Token(Token = "0x401E122")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private Ease _easeType;

		// Token: 0x0401E123 RID: 123171
		[Token(Token = "0x401E123")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _delay;

		// Token: 0x0401E124 RID: 123172
		[Token(Token = "0x401E124")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		// Token: 0x0401E125 RID: 123173
		[Token(Token = "0x401E125")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_entryDelay;

		// Token: 0x0401E126 RID: 123174
		[Token(Token = "0x401E126")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_entryTween;

		// Token: 0x0401E127 RID: 123175
		[Token(Token = "0x401E127")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ResetTween;

		// Token: 0x0401E128 RID: 123176
		[Token(Token = "0x401E128")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
