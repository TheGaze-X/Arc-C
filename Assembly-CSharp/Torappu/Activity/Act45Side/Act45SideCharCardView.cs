using System;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act45Side
{
	// Token: 0x020072D2 RID: 29394
	[Token(Token = "0x20072D2")]
	public class Act45SideCharCardView : MonoBehaviour, IHotfixable
	{
		// Token: 0x060299A6 RID: 170406 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60299A6")]
		[Address(RVA = "0x24F1820", Offset = "0x24F0420", VA = "0x1824F1820")]
		public void Render(Act45SideCharUnlockViewModel.CharInfo charInfo, ILoadAsset assetLoader, float animDelay)
		{
		}

		// Token: 0x060299A7 RID: 170407 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60299A7")]
		[Address(RVA = "0x24F1A40", Offset = "0x24F0640", VA = "0x1824F1A40")]
		public Act45SideCharCardView()
		{
		}

		// Token: 0x0403B802 RID: 243714
		[Token(Token = "0x403B802")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _frontImg;

		// Token: 0x0403B803 RID: 243715
		[Token(Token = "0x403B803")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _backImg;

		// Token: 0x0403B804 RID: 243716
		[Token(Token = "0x403B804")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIAnimationLocation _anim;

		// Token: 0x0403B805 RID: 243717
		[Token(Token = "0x403B805")]
		[FieldOffset(Offset = "0x38")]
		private Tween m_tween;

		// Token: 0x0403B806 RID: 243718
		[Token(Token = "0x403B806")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403B807 RID: 243719
		[Token(Token = "0x403B807")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
