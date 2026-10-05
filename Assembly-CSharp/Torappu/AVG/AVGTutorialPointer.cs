using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.AVG
{
	// Token: 0x02001F75 RID: 8053
	[Token(Token = "0x2001F75")]
	public class AVGTutorialPointer : MonoBehaviour
	{
		// Token: 0x0600C81C RID: 51228 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C81C")]
		[Address(RVA = "0x3494480", Offset = "0x3493080", VA = "0x183494480")]
		public void OnReset()
		{
		}

		// Token: 0x0600C81D RID: 51229 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C81D")]
		[Address(RVA = "0x3494550", Offset = "0x3493150", VA = "0x183494550")]
		public void SetClick(Vector2 position, Vector2 size)
		{
		}

		// Token: 0x0600C81E RID: 51230 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C81E")]
		[Address(RVA = "0x3494650", Offset = "0x3493250", VA = "0x183494650")]
		public void SetDrag(Vector2 startPos, AVGTutorialPanel.AnchorType startAnchor, Vector2 endPos, AVGTutorialPanel.AnchorType endAnchor)
		{
		}

		// Token: 0x0600C81F RID: 51231 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C81F")]
		[Address(RVA = "0x3494470", Offset = "0x3493070", VA = "0x183494470")]
		public void Hide()
		{
		}

		// Token: 0x0600C820 RID: 51232 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C820")]
		[Address(RVA = "0x3494A60", Offset = "0x3493660", VA = "0x183494A60")]
		public AVGTutorialPointer()
		{
		}

		// Token: 0x0400CE8B RID: 52875
		[Token(Token = "0x400CE8B")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _pointer;

		// Token: 0x0400CE8C RID: 52876
		[Token(Token = "0x400CE8C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _dragAnimTime;

		// Token: 0x0400CE8D RID: 52877
		[Token(Token = "0x400CE8D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Animator _pointerAnimator;

		// Token: 0x0400CE8E RID: 52878
		[Token(Token = "0x400CE8E")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private AnimationCurve _dragMoveCurve;

		// Token: 0x0400CE8F RID: 52879
		[Token(Token = "0x400CE8F")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private TrailRenderer _dragTrail;

		// Token: 0x0400CE90 RID: 52880
		[Token(Token = "0x400CE90")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Image _dragStartIcon;

		// Token: 0x0400CE91 RID: 52881
		[Token(Token = "0x400CE91")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Image _dragEndIcon;
	}
}
