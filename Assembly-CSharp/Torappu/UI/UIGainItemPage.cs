using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x0200393C RID: 14652
	[Token(Token = "0x200393C")]
	public class UIGainItemPage : UIPage
	{
		// Token: 0x0601728B RID: 94859 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601728B")]
		[Address(RVA = "0xF93AA0", Offset = "0xF926A0", VA = "0x180F93AA0", Slot = "12")]
		public override IEnumerator ShowCoroutine(bool isFromStack)
		{
			return null;
		}

		// Token: 0x0601728C RID: 94860 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601728C")]
		[Address(RVA = "0xF93860", Offset = "0xF92460", VA = "0x180F93860", Slot = "13")]
		protected override IEnumerator HideCoroutine(bool isIntoStack, bool isRemoveVirtualTop)
		{
			return null;
		}

		// Token: 0x0601728D RID: 94861 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601728D")]
		[Address(RVA = "0xF93940", Offset = "0xF92540", VA = "0x180F93940", Slot = "17")]
		protected override void OnPageRouted()
		{
		}

		// Token: 0x0601728E RID: 94862 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601728E")]
		[Address(RVA = "0xF939B0", Offset = "0xF925B0", VA = "0x180F939B0", Slot = "15")]
		protected override void OnRecycle()
		{
		}

		// Token: 0x17003756 RID: 14166
		// (get) Token: 0x0601728F RID: 94863 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003756")]
		public UIGainItemFloatPanel floatPanel
		{
			[Token(Token = "0x601728F")]
			[Address(RVA = "0xF93CF0", Offset = "0xF928F0", VA = "0x180F93CF0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06017290 RID: 94864 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017290")]
		[Address(RVA = "0xF93B80", Offset = "0xF92780", VA = "0x180F93B80")]
		private void _HideItemFloat()
		{
		}

		// Token: 0x06017291 RID: 94865 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017291")]
		[Address(RVA = "0xF93BE0", Offset = "0xF927E0", VA = "0x180F93BE0")]
		private void _OnExit()
		{
		}

		// Token: 0x06017292 RID: 94866 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017292")]
		[Address(RVA = "0xF93C90", Offset = "0xF92890", VA = "0x180F93C90")]
		public UIGainItemPage()
		{
		}

		// Token: 0x06017293 RID: 94867 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6017293")]
		[Address(RVA = "0xE987B0", Offset = "0xE973B0", VA = "0x180E987B0")]
		private IEnumerator <>xLuaBaseProxy_ShowCoroutine(bool P0)
		{
			return null;
		}

		// Token: 0x06017294 RID: 94868 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6017294")]
		[Address(RVA = "0xE98760", Offset = "0xE97360", VA = "0x180E98760")]
		private IEnumerator <>xLuaBaseProxy_HideCoroutine(bool P0, bool P1)
		{
			return null;
		}

		// Token: 0x06017295 RID: 94869 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017295")]
		[Address(RVA = "0xF93B60", Offset = "0xF92760", VA = "0x180F93B60")]
		private void <>xLuaBaseProxy_OnPageRouted()
		{
		}

		// Token: 0x06017296 RID: 94870 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017296")]
		[Address(RVA = "0xF93B70", Offset = "0xF92770", VA = "0x180F93B70")]
		private void <>xLuaBaseProxy_OnRecycle()
		{
		}

		// Token: 0x0401BF38 RID: 114488
		[Token(Token = "0x401BF38")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private UIGainItemFloatPanel _prefab;

		// Token: 0x0401BF39 RID: 114489
		[Token(Token = "0x401BF39")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private RectTransform _itemContainer;

		// Token: 0x0401BF3A RID: 114490
		[Token(Token = "0x401BF3A")]
		[FieldOffset(Offset = "0xE8")]
		private UIGainItemFloatPanel m_floatPanel;

		// Token: 0x0401BF3B RID: 114491
		[Token(Token = "0x401BF3B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ShowCoroutine;

		// Token: 0x0401BF3C RID: 114492
		[Token(Token = "0x401BF3C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_HideCoroutine;

		// Token: 0x0401BF3D RID: 114493
		[Token(Token = "0x401BF3D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnPageRouted;

		// Token: 0x0401BF3E RID: 114494
		[Token(Token = "0x401BF3E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnRecycle;

		// Token: 0x0401BF3F RID: 114495
		[Token(Token = "0x401BF3F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_floatPanel;

		// Token: 0x0401BF40 RID: 114496
		[Token(Token = "0x401BF40")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__HideItemFloat;

		// Token: 0x0401BF41 RID: 114497
		[Token(Token = "0x401BF41")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__OnExit;

		// Token: 0x0401BF42 RID: 114498
		[Token(Token = "0x401BF42")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200393D RID: 14653
		[Token(Token = "0x200393D")]
		public struct Params
		{
			// Token: 0x0401BF43 RID: 114499
			[Token(Token = "0x401BF43")]
			[FieldOffset(Offset = "0x0")]
			public UIGainItemFloatPanel.Style style;

			// Token: 0x0401BF44 RID: 114500
			[Token(Token = "0x401BF44")]
			[FieldOffset(Offset = "0x8")]
			public List<UIItemViewModel> itemModels;

			// Token: 0x0401BF45 RID: 114501
			[Token(Token = "0x401BF45")]
			[FieldOffset(Offset = "0x10")]
			public Action onConfirm;
		}
	}
}
