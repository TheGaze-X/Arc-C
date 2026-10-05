using System;
using System.Runtime.InteropServices;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.UI
{
	// Token: 0x02003A30 RID: 14896
	[Token(Token = "0x2003A30")]
	public class UISingleValueChangeBar : MonoBehaviour
	{
		// Token: 0x06017832 RID: 96306 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017832")]
		[Address(RVA = "0xFD3930", Offset = "0xFD2530", VA = "0x180FD3930")]
		public void SetData(UISingleValueChangeBar.Options options)
		{
		}

		// Token: 0x06017833 RID: 96307 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017833")]
		[Address(RVA = "0xFD3AA0", Offset = "0xFD26A0", VA = "0x180FD3AA0")]
		public void StartTween([Optional] TweenCallback onComplete)
		{
		}

		// Token: 0x06017834 RID: 96308 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017834")]
		[Address(RVA = "0xFD3D20", Offset = "0xFD2920", VA = "0x180FD3D20")]
		private void _Render(float progress)
		{
		}

		// Token: 0x06017835 RID: 96309 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017835")]
		[Address(RVA = "0xFD3CE0", Offset = "0xFD28E0", VA = "0x180FD3CE0")]
		private void _ClearTween()
		{
		}

		// Token: 0x06017836 RID: 96310 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017836")]
		[Address(RVA = "0xFD3E40", Offset = "0xFD2A40", VA = "0x180FD3E40")]
		public UISingleValueChangeBar()
		{
		}

		// Token: 0x0401C64B RID: 116299
		[Token(Token = "0x401C64B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private StretchProgressBar _progressBar;

		// Token: 0x0401C64C RID: 116300
		[Token(Token = "0x401C64C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _currentValue;

		// Token: 0x0401C64D RID: 116301
		[Token(Token = "0x401C64D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _maxValue;

		// Token: 0x0401C64E RID: 116302
		[Token(Token = "0x401C64E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _tweenTime;

		// Token: 0x0401C64F RID: 116303
		[Token(Token = "0x401C64F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private UISingleValueChangeBar.Options m_options;

		// Token: 0x0401C650 RID: 116304
		[Token(Token = "0x401C650")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Tween m_tween;

		// Token: 0x0401C651 RID: 116305
		[Token(Token = "0x401C651")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float m_startProgress;

		// Token: 0x0401C652 RID: 116306
		[Token(Token = "0x401C652")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private float m_endProgress;

		// Token: 0x02003A31 RID: 14897
		[Token(Token = "0x2003A31")]
		public struct Options
		{
			// Token: 0x0401C653 RID: 116307
			[Token(Token = "0x401C653")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int startValue;

			// Token: 0x0401C654 RID: 116308
			[Token(Token = "0x401C654")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public int endValue;

			// Token: 0x0401C655 RID: 116309
			[Token(Token = "0x401C655")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public int maxValue;
		}
	}
}
