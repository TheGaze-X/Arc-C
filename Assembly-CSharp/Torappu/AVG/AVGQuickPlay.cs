using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.AVG
{
	// Token: 0x02001EA6 RID: 7846
	[Token(Token = "0x2001EA6")]
	public class AVGQuickPlay : MonoBehaviour
	{
		// Token: 0x1700173F RID: 5951
		// (get) Token: 0x0600C25A RID: 49754 RVA: 0x00047568 File Offset: 0x00045768
		[Token(Token = "0x1700173F")]
		public AVGQuickPlay.State state
		{
			[Token(Token = "0x600C25A")]
			[Address(RVA = "0x32FB1A0", Offset = "0x32F9DA0", VA = "0x1832FB1A0")]
			get
			{
				return AVGQuickPlay.State.NONE;
			}
		}

		// Token: 0x0600C25B RID: 49755 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C25B")]
		[Address(RVA = "0x33F92A0", Offset = "0x33F7EA0", VA = "0x1833F92A0")]
		public void OnDragAction(Vector2 pos)
		{
		}

		// Token: 0x0600C25C RID: 49756 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C25C")]
		[Address(RVA = "0x33F9340", Offset = "0x33F7F40", VA = "0x1833F9340")]
		public void SetSpeedBtn(string name)
		{
		}

		// Token: 0x0600C25D RID: 49757 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C25D")]
		[Address(RVA = "0x33F98D0", Offset = "0x33F84D0", VA = "0x1833F98D0")]
		private void _SetSpeedBtn()
		{
		}

		// Token: 0x0600C25E RID: 49758 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C25E")]
		[Address(RVA = "0x33F93C0", Offset = "0x33F7FC0", VA = "0x1833F93C0")]
		public void SetStatus(bool flag, int pos = 0)
		{
		}

		// Token: 0x0600C25F RID: 49759 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C25F")]
		[Address(RVA = "0x33F9520", Offset = "0x33F8120", VA = "0x1833F9520")]
		private void Update()
		{
		}

		// Token: 0x0600C260 RID: 49760 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C260")]
		[Address(RVA = "0x33F99F0", Offset = "0x33F85F0", VA = "0x1833F99F0")]
		public AVGQuickPlay()
		{
		}

		// Token: 0x0400C41E RID: 50206
		[Token(Token = "0x400C41E")]
		private const float X_POS = 550f;

		// Token: 0x0400C41F RID: 50207
		[Token(Token = "0x400C41F")]
		private const float DEFAULT_HEIGHT = 326f;

		// Token: 0x0400C420 RID: 50208
		[Token(Token = "0x400C420")]
		private const float SMALL_HEIGHT = 118f;

		// Token: 0x0400C421 RID: 50209
		[Token(Token = "0x400C421")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _slider;

		// Token: 0x0400C422 RID: 50210
		[Token(Token = "0x400C422")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _speedBtn;

		// Token: 0x0400C423 RID: 50211
		[Token(Token = "0x400C423")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _sliderFill;

		// Token: 0x0400C424 RID: 50212
		[Token(Token = "0x400C424")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Tooltip("Millsecs")]
		private int _holdTime;

		// Token: 0x0400C425 RID: 50213
		[Token(Token = "0x400C425")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private AVGQuickPlayBtn[] _speedBtns;

		// Token: 0x0400C426 RID: 50214
		[Token(Token = "0x400C426")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private RectTransform _speedBtnBG;

		// Token: 0x0400C427 RID: 50215
		[Token(Token = "0x400C427")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private CanvasGroup _btnsCanvasGroup;

		// Token: 0x0400C428 RID: 50216
		[Token(Token = "0x400C428")]
		[FieldOffset(Offset = "0x50")]
		private DateTime m_startTime;

		// Token: 0x0400C429 RID: 50217
		[Token(Token = "0x400C429")]
		[FieldOffset(Offset = "0x58")]
		private AVGQuickPlay.State m_state;

		// Token: 0x0400C42A RID: 50218
		[Token(Token = "0x400C42A")]
		[FieldOffset(Offset = "0x5C")]
		private int m_speed;

		// Token: 0x02001EA7 RID: 7847
		[Token(Token = "0x2001EA7")]
		public enum State
		{
			// Token: 0x0400C42C RID: 50220
			[Token(Token = "0x400C42C")]
			NONE,
			// Token: 0x0400C42D RID: 50221
			[Token(Token = "0x400C42D")]
			COUNT,
			// Token: 0x0400C42E RID: 50222
			[Token(Token = "0x400C42E")]
			QUICK_PLAY
		}
	}
}
