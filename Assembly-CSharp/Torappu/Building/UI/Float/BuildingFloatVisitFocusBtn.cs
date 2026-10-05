using System;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Building.UI.Float
{
	// Token: 0x02001DFD RID: 7677
	[Token(Token = "0x2001DFD")]
	public class BuildingFloatVisitFocusBtn : MonoBehaviour, IHotfixable
	{
		// Token: 0x0600BD92 RID: 48530 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD92")]
		[Address(RVA = "0x33AEDC0", Offset = "0x33AD9C0", VA = "0x1833AEDC0")]
		private void _ApplyAnim()
		{
		}

		// Token: 0x0600BD93 RID: 48531 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD93")]
		[Address(RVA = "0x33AEF50", Offset = "0x33ADB50", VA = "0x1833AEF50")]
		private void _OnFinish()
		{
		}

		// Token: 0x0600BD94 RID: 48532 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD94")]
		[Address(RVA = "0x33AE9D0", Offset = "0x33AD5D0", VA = "0x1833AE9D0")]
		public void OnClick()
		{
		}

		// Token: 0x0600BD95 RID: 48533 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD95")]
		[Address(RVA = "0x33AEFC0", Offset = "0x33ADBC0", VA = "0x1833AEFC0")]
		public BuildingFloatVisitFocusBtn()
		{
		}

		// Token: 0x0400BE1A RID: 48666
		[Token(Token = "0x400BE1A")]
		private const string VISIT_BUTTON_CLICK = "visit_button_active";

		// Token: 0x0400BE1B RID: 48667
		[Token(Token = "0x400BE1B")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private AnimationWrapper _animationWrapper;

		// Token: 0x0400BE1C RID: 48668
		[Token(Token = "0x400BE1C")]
		[FieldOffset(Offset = "0x20")]
		private bool m_isLocked;

		// Token: 0x0400BE1D RID: 48669
		[Token(Token = "0x400BE1D")]
		[FieldOffset(Offset = "0x28")]
		private Tween m_tween;

		// Token: 0x0400BE1E RID: 48670
		[Token(Token = "0x400BE1E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__ApplyAnim;

		// Token: 0x0400BE1F RID: 48671
		[Token(Token = "0x400BE1F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__OnFinish;

		// Token: 0x0400BE20 RID: 48672
		[Token(Token = "0x400BE20")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x0400BE21 RID: 48673
		[Token(Token = "0x400BE21")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
