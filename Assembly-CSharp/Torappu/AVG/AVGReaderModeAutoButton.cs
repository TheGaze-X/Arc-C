using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.AVG
{
	// Token: 0x02001F61 RID: 8033
	[Token(Token = "0x2001F61")]
	public class AVGReaderModeAutoButton : MonoBehaviour
	{
		// Token: 0x0600C7A9 RID: 51113 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C7A9")]
		[Address(RVA = "0x3473FB0", Offset = "0x3472BB0", VA = "0x183473FB0")]
		public void SetPos(bool hasOtherBtn)
		{
		}

		// Token: 0x0600C7AA RID: 51114 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C7AA")]
		[Address(RVA = "0x348CA60", Offset = "0x348B660", VA = "0x18348CA60")]
		public void SetIsAutoPlaying(AVGReaderModeAutoPlayCache.AutoMode autoMode)
		{
		}

		// Token: 0x0600C7AB RID: 51115 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C7AB")]
		[Address(RVA = "0x34740B0", Offset = "0x3472CB0", VA = "0x1834740B0")]
		private void _StopTween()
		{
		}

		// Token: 0x0600C7AC RID: 51116 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C7AC")]
		[Address(RVA = "0x34740B0", Offset = "0x3472CB0", VA = "0x1834740B0")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600C7AD RID: 51117 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C7AD")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public AVGReaderModeAutoButton()
		{
		}

		// Token: 0x0400CDBD RID: 52669
		[Token(Token = "0x400CDBD")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RectTransform _image;

		// Token: 0x0400CDBE RID: 52670
		[Token(Token = "0x400CDBE")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _text;

		// Token: 0x0400CDBF RID: 52671
		[Token(Token = "0x400CDBF")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _noPlayWidth;

		// Token: 0x0400CDC0 RID: 52672
		[Token(Token = "0x400CDC0")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float _defaultWidth;

		// Token: 0x0400CDC1 RID: 52673
		[Token(Token = "0x400CDC1")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _stepWidth;

		// Token: 0x0400CDC2 RID: 52674
		[Token(Token = "0x400CDC2")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float _stepCount;

		// Token: 0x0400CDC3 RID: 52675
		[Token(Token = "0x400CDC3")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float _stepTime;

		// Token: 0x0400CDC4 RID: 52676
		[Token(Token = "0x400CDC4")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private Vector2 _defaultPos;

		// Token: 0x0400CDC5 RID: 52677
		[Token(Token = "0x400CDC5")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private Vector2 _posWithoutOtherBtn;

		// Token: 0x0400CDC6 RID: 52678
		[Token(Token = "0x400CDC6")]
		[FieldOffset(Offset = "0x50")]
		private Tweener m_tweener;
	}
}
