using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x020038BE RID: 14526
	[Token(Token = "0x20038BE")]
	public class AdvancedAutoHideComponent : MonoBehaviour, IHotfixable
	{
		// Token: 0x06016FA7 RID: 94119 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016FA7")]
		[Address(RVA = "0xF6C8B0", Offset = "0xF6B4B0", VA = "0x180F6C8B0")]
		private void OnDestroy()
		{
		}

		// Token: 0x06016FA8 RID: 94120 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016FA8")]
		[Address(RVA = "0xF6C790", Offset = "0xF6B390", VA = "0x180F6C790")]
		public void NotifyInteract()
		{
		}

		// Token: 0x06016FA9 RID: 94121 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016FA9")]
		[Address(RVA = "0xF6CA60", Offset = "0xF6B660", VA = "0x180F6CA60")]
		public void ResetState(bool isShow)
		{
		}

		// Token: 0x06016FAA RID: 94122 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016FAA")]
		[Address(RVA = "0xF6CBF0", Offset = "0xF6B7F0", VA = "0x180F6CBF0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06016FAB RID: 94123 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016FAB")]
		[Address(RVA = "0xF6D210", Offset = "0xF6BE10", VA = "0x180F6D210")]
		private void _StartToHide()
		{
		}

		// Token: 0x06016FAC RID: 94124 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016FAC")]
		[Address(RVA = "0xF6D2C0", Offset = "0xF6BEC0", VA = "0x180F6D2C0")]
		private void _StartToShow()
		{
		}

		// Token: 0x06016FAD RID: 94125 RVA: 0x000942D8 File Offset: 0x000924D8
		[Token(Token = "0x6016FAD")]
		[Address(RVA = "0xF6CB80", Offset = "0xF6B780", VA = "0x180F6CB80")]
		private float _GetTargetAlpha()
		{
			return 0f;
		}

		// Token: 0x06016FAE RID: 94126 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016FAE")]
		[Address(RVA = "0xF6D190", Offset = "0xF6BD90", VA = "0x180F6D190")]
		private void _SetTargetAlpha(float alpha)
		{
		}

		// Token: 0x06016FAF RID: 94127 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016FAF")]
		[Address(RVA = "0xF6D380", Offset = "0xF6BF80", VA = "0x180F6D380")]
		public AdvancedAutoHideComponent()
		{
		}

		// Token: 0x0401BBCE RID: 113614
		[Token(Token = "0x401BBCE")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float _tweenDuration;

		// Token: 0x0401BBCF RID: 113615
		[Token(Token = "0x401BBCF")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float _waitDuration;

		// Token: 0x0401BBD0 RID: 113616
		[Token(Token = "0x401BBD0")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CanvasGroup _target;

		// Token: 0x0401BBD1 RID: 113617
		[Token(Token = "0x401BBD1")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool _controlRaycast;

		// Token: 0x0401BBD2 RID: 113618
		[Token(Token = "0x401BBD2")]
		[FieldOffset(Offset = "0x30")]
		private Tweener m_showTweener;

		// Token: 0x0401BBD3 RID: 113619
		[Token(Token = "0x401BBD3")]
		[FieldOffset(Offset = "0x38")]
		private Tweener m_hideTweener;

		// Token: 0x0401BBD4 RID: 113620
		[Token(Token = "0x401BBD4")]
		[FieldOffset(Offset = "0x40")]
		private Tweener m_waitTweener;

		// Token: 0x0401BBD5 RID: 113621
		[Token(Token = "0x401BBD5")]
		[FieldOffset(Offset = "0x48")]
		private bool m_isShow;

		// Token: 0x0401BBD6 RID: 113622
		[Token(Token = "0x401BBD6")]
		[FieldOffset(Offset = "0x49")]
		private bool m_hasInited;

		// Token: 0x0401BBD7 RID: 113623
		[Token(Token = "0x401BBD7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0401BBD8 RID: 113624
		[Token(Token = "0x401BBD8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_NotifyInteract;

		// Token: 0x0401BBD9 RID: 113625
		[Token(Token = "0x401BBD9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ResetState;

		// Token: 0x0401BBDA RID: 113626
		[Token(Token = "0x401BBDA")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401BBDB RID: 113627
		[Token(Token = "0x401BBDB")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__StartToHide;

		// Token: 0x0401BBDC RID: 113628
		[Token(Token = "0x401BBDC")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__StartToShow;

		// Token: 0x0401BBDD RID: 113629
		[Token(Token = "0x401BBDD")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__GetTargetAlpha;

		// Token: 0x0401BBDE RID: 113630
		[Token(Token = "0x401BBDE")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__SetTargetAlpha;

		// Token: 0x0401BBDF RID: 113631
		[Token(Token = "0x401BBDF")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
