using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.UI
{
	// Token: 0x020038C1 RID: 14529
	[Token(Token = "0x20038C1")]
	public class AutoHideComponent : MonoBehaviour
	{
		// Token: 0x06016FB7 RID: 94135 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016FB7")]
		[Address(RVA = "0xF6D630", Offset = "0xF6C230", VA = "0x180F6D630")]
		private void Start()
		{
		}

		// Token: 0x06016FB8 RID: 94136 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016FB8")]
		[Address(RVA = "0xF6D590", Offset = "0xF6C190", VA = "0x180F6D590")]
		private void OnDestroy()
		{
		}

		// Token: 0x06016FB9 RID: 94137 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016FB9")]
		[Address(RVA = "0xF6D510", Offset = "0xF6C110", VA = "0x180F6D510")]
		public void NotifyInteract()
		{
		}

		// Token: 0x06016FBA RID: 94138 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016FBA")]
		[Address(RVA = "0xF6DBE0", Offset = "0xF6C7E0", VA = "0x180F6DBE0")]
		private void _StartToHide()
		{
		}

		// Token: 0x06016FBB RID: 94139 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016FBB")]
		[Address(RVA = "0xF6DC40", Offset = "0xF6C840", VA = "0x180F6DC40")]
		private void _StartToShow()
		{
		}

		// Token: 0x06016FBC RID: 94140 RVA: 0x00094308 File Offset: 0x00092508
		[Token(Token = "0x6016FBC")]
		[Address(RVA = "0xF6DBC0", Offset = "0xF6C7C0", VA = "0x180F6DBC0")]
		private float _GetTargetAlpha()
		{
			return 0f;
		}

		// Token: 0x06016FBD RID: 94141 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016FBD")]
		[Address(RVA = "0xD1B7B0", Offset = "0xD1A3B0", VA = "0x180D1B7B0")]
		private void _SetTargetAlpha(float alpha)
		{
		}

		// Token: 0x06016FBE RID: 94142 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016FBE")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public AutoHideComponent()
		{
		}

		// Token: 0x0401BBE4 RID: 113636
		[Token(Token = "0x401BBE4")]
		private const float WAIT_DURATION = 0.6f;

		// Token: 0x0401BBE5 RID: 113637
		[Token(Token = "0x401BBE5")]
		private const float TWEEN_DURATION = 0.4f;

		// Token: 0x0401BBE6 RID: 113638
		[Token(Token = "0x401BBE6")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CanvasGroup _target;

		// Token: 0x0401BBE7 RID: 113639
		[Token(Token = "0x401BBE7")]
		[FieldOffset(Offset = "0x20")]
		private Tweener m_showTweener;

		// Token: 0x0401BBE8 RID: 113640
		[Token(Token = "0x401BBE8")]
		[FieldOffset(Offset = "0x28")]
		private Tweener m_hideTweener;

		// Token: 0x0401BBE9 RID: 113641
		[Token(Token = "0x401BBE9")]
		[FieldOffset(Offset = "0x30")]
		private Tweener m_waitTweener;

		// Token: 0x0401BBEA RID: 113642
		[Token(Token = "0x401BBEA")]
		[FieldOffset(Offset = "0x38")]
		private bool m_isHide;

		// Token: 0x0401BBEB RID: 113643
		[Token(Token = "0x401BBEB")]
		[FieldOffset(Offset = "0x40")]
		private Tweener[] m_activeTweens;
	}
}
