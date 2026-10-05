using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.AVG
{
	// Token: 0x02001F46 RID: 8006
	[Token(Token = "0x2001F46")]
	public class AVGAutoButton : MonoBehaviour
	{
		// Token: 0x0600C709 RID: 50953 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C709")]
		[Address(RVA = "0x3473FB0", Offset = "0x3472BB0", VA = "0x183473FB0")]
		public void SetPos(bool hasSkipBtn)
		{
		}

		// Token: 0x0600C70A RID: 50954 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C70A")]
		[Address(RVA = "0x3473CB0", Offset = "0x34728B0", VA = "0x183473CB0")]
		public void SetIsAutoPlaying(AVGStoryCache.AVGAutoMode autoMode)
		{
		}

		// Token: 0x0600C70B RID: 50955 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C70B")]
		[Address(RVA = "0x34740B0", Offset = "0x3472CB0", VA = "0x1834740B0")]
		private void _StopTween()
		{
		}

		// Token: 0x0600C70C RID: 50956 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C70C")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public AVGAutoButton()
		{
		}

		// Token: 0x0400CCAF RID: 52399
		[Token(Token = "0x400CCAF")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RectTransform _image;

		// Token: 0x0400CCB0 RID: 52400
		[Token(Token = "0x400CCB0")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _text;

		// Token: 0x0400CCB1 RID: 52401
		[Token(Token = "0x400CCB1")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _noPlayWidth;

		// Token: 0x0400CCB2 RID: 52402
		[Token(Token = "0x400CCB2")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float _defaultWidth;

		// Token: 0x0400CCB3 RID: 52403
		[Token(Token = "0x400CCB3")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _stepWidth;

		// Token: 0x0400CCB4 RID: 52404
		[Token(Token = "0x400CCB4")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float _stepCount;

		// Token: 0x0400CCB5 RID: 52405
		[Token(Token = "0x400CCB5")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float _stepTime;

		// Token: 0x0400CCB6 RID: 52406
		[Token(Token = "0x400CCB6")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private Vector2 _defaultPos;

		// Token: 0x0400CCB7 RID: 52407
		[Token(Token = "0x400CCB7")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private Vector2 _posWithoutSkipBtn;

		// Token: 0x0400CCB8 RID: 52408
		[Token(Token = "0x400CCB8")]
		[FieldOffset(Offset = "0x50")]
		private Tweener m_tweener;
	}
}
