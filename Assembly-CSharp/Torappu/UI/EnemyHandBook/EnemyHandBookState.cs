using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.EnemyHandBook
{
	// Token: 0x02004F48 RID: 20296
	[Token(Token = "0x2004F48")]
	public class EnemyHandBookState : PopupFloatState
	{
		// Token: 0x0601E383 RID: 123779 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601E383")]
		[Address(RVA = "0x17ED8C0", Offset = "0x17EC4C0", VA = "0x1817ED8C0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0601E384 RID: 123780 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E384")]
		[Address(RVA = "0x17ED920", Offset = "0x17EC520", VA = "0x1817ED920", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0601E385 RID: 123781 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E385")]
		[Address(RVA = "0x17ED750", Offset = "0x17EC350", VA = "0x1817ED750")]
		public void DismissWrapped()
		{
		}

		// Token: 0x0601E386 RID: 123782 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E386")]
		[Address(RVA = "0x17EDE40", Offset = "0x17ECA40", VA = "0x1817EDE40")]
		private void _InitView()
		{
		}

		// Token: 0x0601E387 RID: 123783 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E387")]
		[Address(RVA = "0x17EE0C0", Offset = "0x17ECCC0", VA = "0x1817EE0C0")]
		private void _OnSelectedChanged(string enemyId, bool needScrollFlag)
		{
		}

		// Token: 0x0601E388 RID: 123784 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E388")]
		[Address(RVA = "0x17EDDC0", Offset = "0x17EC9C0", VA = "0x1817EDDC0")]
		public void OnSelectedChanged(string enemyId)
		{
		}

		// Token: 0x0601E389 RID: 123785 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E389")]
		[Address(RVA = "0x17EDD40", Offset = "0x17EC940", VA = "0x1817EDD40")]
		public void OnSelectedChangedByClick(string enemyId)
		{
		}

		// Token: 0x0601E38A RID: 123786 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E38A")]
		[Address(RVA = "0x17EE290", Offset = "0x17ECE90", VA = "0x1817EE290")]
		public EnemyHandBookState()
		{
		}

		// Token: 0x0601E38B RID: 123787 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E38B")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x04028493 RID: 165011
		[Token(Token = "0x4028493")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private EnemyHandBookStateBean _stateBean;

		// Token: 0x04028494 RID: 165012
		[Token(Token = "0x4028494")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private EnemyHandBookScrollView _enemyScrollView;

		// Token: 0x04028495 RID: 165013
		[Token(Token = "0x4028495")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private EnemyHandBookShufflePanel _shufflePanel;

		// Token: 0x04028496 RID: 165014
		[Token(Token = "0x4028496")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private GameObject _pageBack;

		// Token: 0x04028497 RID: 165015
		[Token(Token = "0x4028497")]
		[FieldOffset(Offset = "0x90")]
		private bool m_hasInited;

		// Token: 0x04028498 RID: 165016
		[Token(Token = "0x4028498")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04028499 RID: 165017
		[Token(Token = "0x4028499")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0402849A RID: 165018
		[Token(Token = "0x402849A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_DismissWrapped;

		// Token: 0x0402849B RID: 165019
		[Token(Token = "0x402849B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitView;

		// Token: 0x0402849C RID: 165020
		[Token(Token = "0x402849C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnSelectedChanged;

		// Token: 0x0402849D RID: 165021
		[Token(Token = "0x402849D")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnSelectedChanged;

		// Token: 0x0402849E RID: 165022
		[Token(Token = "0x402849E")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnSelectedChangedByClick;

		// Token: 0x0402849F RID: 165023
		[Token(Token = "0x402849F")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
