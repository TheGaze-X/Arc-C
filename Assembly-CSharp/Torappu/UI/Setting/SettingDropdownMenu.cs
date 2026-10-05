using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Setting;
using UnityEngine;
using XLua;

namespace Torappu.UI.Setting
{
	// Token: 0x02003FEE RID: 16366
	[Token(Token = "0x2003FEE")]
	public abstract class SettingDropdownMenu : SettingCommonObject, ICompDialogCallBack, IHotfixable
	{
		// Token: 0x060195A2 RID: 103842 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60195A2")]
		[Address(RVA = "0x1224B60", Offset = "0x1223760", VA = "0x181224B60", Slot = "4")]
		protected override void RefreshState()
		{
		}

		// Token: 0x060195A3 RID: 103843 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60195A3")]
		[Address(RVA = "0x1224C40", Offset = "0x1223840", VA = "0x181224C40", Slot = "5")]
		protected override void SetData(SettingConstVars.SettingType type = SettingConstVars.SettingType.ALL)
		{
		}

		// Token: 0x060195A4 RID: 103844 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60195A4")]
		[Address(RVA = "0x1224BD0", Offset = "0x12237D0", VA = "0x181224BD0", Slot = "6")]
		protected override void SetCommonObjectEnabled(bool enabled)
		{
		}

		// Token: 0x060195A5 RID: 103845
		[Token(Token = "0x60195A5")]
		protected abstract void InitOptions(List<ICommonDropdownModel> optionList);

		// Token: 0x060195A6 RID: 103846
		[Token(Token = "0x60195A6")]
		protected abstract int GetSelectedOptionIndex();

		// Token: 0x060195A7 RID: 103847
		[Token(Token = "0x60195A7")]
		protected abstract void OnValueChanged(int selectedIdx);

		// Token: 0x060195A8 RID: 103848 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60195A8")]
		[Address(RVA = "0x1224A70", Offset = "0x1223670", VA = "0x181224A70", Slot = "7")]
		public void HandleCallBack(int instId, ValueBundle output)
		{
		}

		// Token: 0x060195A9 RID: 103849 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60195A9")]
		[Address(RVA = "0x1224F10", Offset = "0x1223B10", VA = "0x181224F10")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060195AA RID: 103850 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60195AA")]
		[Address(RVA = "0x1224D00", Offset = "0x1223900", VA = "0x181224D00")]
		private void _EventOnDropdownBtnClicked()
		{
		}

		// Token: 0x060195AB RID: 103851 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60195AB")]
		[Address(RVA = "0x12251F0", Offset = "0x1223DF0", VA = "0x1812251F0")]
		private void _RenderDropdownBtn(int index, bool isSelected)
		{
		}

		// Token: 0x060195AC RID: 103852 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60195AC")]
		[Address(RVA = "0x1225350", Offset = "0x1223F50", VA = "0x181225350")]
		protected SettingDropdownMenu()
		{
		}

		// Token: 0x060195AD RID: 103853 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60195AD")]
		[Address(RVA = "0x1223A20", Offset = "0x1222620", VA = "0x181223A20")]
		private void <>xLuaBaseProxy_RefreshState()
		{
		}

		// Token: 0x060195AE RID: 103854 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60195AE")]
		[Address(RVA = "0x1223A30", Offset = "0x1222630", VA = "0x181223A30")]
		private void <>xLuaBaseProxy_SetData(SettingConstVars.SettingType P0)
		{
		}

		// Token: 0x0401F893 RID: 129171
		[Token(Token = "0x401F893")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private RectTransform _dropdownContainer;

		// Token: 0x0401F894 RID: 129172
		[Token(Token = "0x401F894")]
		[FieldOffset(Offset = "0x48")]
		private List<ICommonDropdownModel> m_optionList;

		// Token: 0x0401F895 RID: 129173
		[Token(Token = "0x401F895")]
		[FieldOffset(Offset = "0x50")]
		private bool m_hasInited;

		// Token: 0x0401F896 RID: 129174
		[Token(Token = "0x401F896")]
		[FieldOffset(Offset = "0x51")]
		private bool m_isEnabled;

		// Token: 0x0401F897 RID: 129175
		[Token(Token = "0x401F897")]
		[FieldOffset(Offset = "0x58")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0401F898 RID: 129176
		[Token(Token = "0x401F898")]
		[FieldOffset(Offset = "0x68")]
		private UISimpleDropdownEntryView m_entryView;

		// Token: 0x0401F899 RID: 129177
		[Token(Token = "0x401F899")]
		[FieldOffset(Offset = "0x70")]
		private int m_dialogInst;

		// Token: 0x0401F89A RID: 129178
		[Token(Token = "0x401F89A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_RefreshState;

		// Token: 0x0401F89B RID: 129179
		[Token(Token = "0x401F89B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SetData;

		// Token: 0x0401F89C RID: 129180
		[Token(Token = "0x401F89C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SetCommonObjectEnabled;

		// Token: 0x0401F89D RID: 129181
		[Token(Token = "0x401F89D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_HandleCallBack;

		// Token: 0x0401F89E RID: 129182
		[Token(Token = "0x401F89E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401F89F RID: 129183
		[Token(Token = "0x401F89F")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__EventOnDropdownBtnClicked;

		// Token: 0x0401F8A0 RID: 129184
		[Token(Token = "0x401F8A0")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__RenderDropdownBtn;

		// Token: 0x0401F8A1 RID: 129185
		[Token(Token = "0x401F8A1")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
