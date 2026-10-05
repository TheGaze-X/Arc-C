using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.Building.UI.Meeting
{
	// Token: 0x02001D6C RID: 7532
	[Token(Token = "0x2001D6C")]
	public class MeetingClueRemoveHintView : MonoBehaviour
	{
		// Token: 0x0600BA12 RID: 47634 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA12")]
		[Address(RVA = "0x337B6A0", Offset = "0x337A2A0", VA = "0x18337B6A0")]
		public void Show(int amount, Action okCallback)
		{
		}

		// Token: 0x0600BA13 RID: 47635 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA13")]
		[Address(RVA = "0x337B940", Offset = "0x337A540", VA = "0x18337B940")]
		private void _Hide()
		{
		}

		// Token: 0x0600BA14 RID: 47636 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA14")]
		[Address(RVA = "0x337B5B0", Offset = "0x337A1B0", VA = "0x18337B5B0")]
		public void OkButtonPressed()
		{
		}

		// Token: 0x0600BA15 RID: 47637 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA15")]
		[Address(RVA = "0x337B5A0", Offset = "0x337A1A0", VA = "0x18337B5A0")]
		public void CancelButtonPressed()
		{
		}

		// Token: 0x0600BA16 RID: 47638 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA16")]
		[Address(RVA = "0x337B5E0", Offset = "0x337A1E0", VA = "0x18337B5E0")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600BA17 RID: 47639 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA17")]
		[Address(RVA = "0x337BB70", Offset = "0x337A770", VA = "0x18337BB70")]
		public MeetingClueRemoveHintView()
		{
		}

		// Token: 0x0400B8F5 RID: 47349
		[Token(Token = "0x400B8F5")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _background;

		// Token: 0x0400B8F6 RID: 47350
		[Token(Token = "0x400B8F6")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _amount;

		// Token: 0x0400B8F7 RID: 47351
		[Token(Token = "0x400B8F7")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		// Token: 0x0400B8F8 RID: 47352
		[Token(Token = "0x400B8F8")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _fadeDuration;

		// Token: 0x0400B8F9 RID: 47353
		[Token(Token = "0x400B8F9")]
		[FieldOffset(Offset = "0x38")]
		private Action m_okCallback;

		// Token: 0x0400B8FA RID: 47354
		[Token(Token = "0x400B8FA")]
		[FieldOffset(Offset = "0x40")]
		private bool m_shown;
	}
}
