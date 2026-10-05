using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x02005510 RID: 21776
	[Token(Token = "0x2005510")]
	public class RoguelikeShopNpcView : MonoBehaviour, IHotfixable
	{
		// Token: 0x17004B1E RID: 19230
		// (get) Token: 0x0602006A RID: 131178 RVA: 0x000B44C8 File Offset: 0x000B26C8
		[Token(Token = "0x17004B1E")]
		public bool isTweening
		{
			[Token(Token = "0x602006A")]
			[Address(RVA = "0x1A25BF0", Offset = "0x1A247F0", VA = "0x181A25BF0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0602006B RID: 131179 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602006B")]
		[Address(RVA = "0x1A257E0", Offset = "0x1A243E0", VA = "0x181A257E0")]
		public void Render(string dialog, bool tweenAlpha)
		{
		}

		// Token: 0x0602006C RID: 131180 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602006C")]
		[Address(RVA = "0x1A25A10", Offset = "0x1A24610", VA = "0x181A25A10")]
		private void _PlayTextTween(string dialog)
		{
		}

		// Token: 0x0602006D RID: 131181 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602006D")]
		[Address(RVA = "0x1A25B90", Offset = "0x1A24790", VA = "0x181A25B90")]
		public RoguelikeShopNpcView()
		{
		}

		// Token: 0x0402B3E5 RID: 177125
		[Token(Token = "0x402B3E5")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		// Token: 0x0402B3E6 RID: 177126
		[Token(Token = "0x402B3E6")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textDialog;

		// Token: 0x0402B3E7 RID: 177127
		[Token(Token = "0x402B3E7")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _alphaTweenDelay;

		// Token: 0x0402B3E8 RID: 177128
		[Token(Token = "0x402B3E8")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float _alphaTweenDuration;

		// Token: 0x0402B3E9 RID: 177129
		[Token(Token = "0x402B3E9")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _textTweenDuration;

		// Token: 0x0402B3EA RID: 177130
		[Token(Token = "0x402B3EA")]
		[FieldOffset(Offset = "0x38")]
		private Tween m_alphaTweener;

		// Token: 0x0402B3EB RID: 177131
		[Token(Token = "0x402B3EB")]
		[FieldOffset(Offset = "0x40")]
		private Tween m_textTweener;

		// Token: 0x0402B3EC RID: 177132
		[Token(Token = "0x402B3EC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isTweening;

		// Token: 0x0402B3ED RID: 177133
		[Token(Token = "0x402B3ED")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402B3EE RID: 177134
		[Token(Token = "0x402B3EE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__PlayTextTween;

		// Token: 0x0402B3EF RID: 177135
		[Token(Token = "0x402B3EF")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
