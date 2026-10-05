using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act1VHalfIdle
{
	// Token: 0x0200777B RID: 30587
	[Token(Token = "0x200777B")]
	public class Act1VHalfIdleStuffDepotItemDetailDialog : UICompDialog<Act1VHalfIdleStuffDepotItemDetailDialog.Option>
	{
		// Token: 0x0602AF5F RID: 175967 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AF5F")]
		[Address(RVA = "0x26D4460", Offset = "0x26D3060", VA = "0x1826D4460", Slot = "9")]
		protected override void OnInit()
		{
		}

		// Token: 0x0602AF60 RID: 175968 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AF60")]
		[Address(RVA = "0x26D4560", Offset = "0x26D3160", VA = "0x1826D4560", Slot = "18")]
		protected override void OnRender(Act1VHalfIdleStuffDepotItemDetailDialog.Option input)
		{
		}

		// Token: 0x0602AF61 RID: 175969 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AF61")]
		[Address(RVA = "0x26D4700", Offset = "0x26D3300", VA = "0x1826D4700")]
		private void _Render(Act1VHalfIdleStuffDepotItemViewModel itemViewModel)
		{
		}

		// Token: 0x0602AF62 RID: 175970 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602AF62")]
		[Address(RVA = "0x26D4200", Offset = "0x26D2E00", VA = "0x1826D4200", Slot = "15")]
		protected override UIRenderTextureImage GetBlurTarget()
		{
			return null;
		}

		// Token: 0x0602AF63 RID: 175971 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AF63")]
		[Address(RVA = "0x26D3F50", Offset = "0x26D2B50", VA = "0x1826D3F50")]
		public void EventOnClose()
		{
		}

		// Token: 0x0602AF64 RID: 175972 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AF64")]
		[Address(RVA = "0x26D4020", Offset = "0x26D2C20", VA = "0x1826D4020")]
		public void EventOnToUse()
		{
		}

		// Token: 0x0602AF65 RID: 175973 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AF65")]
		[Address(RVA = "0x26D4260", Offset = "0x26D2E60", VA = "0x1826D4260")]
		public void OnBtnSwitchItemLeftClicked()
		{
		}

		// Token: 0x0602AF66 RID: 175974 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AF66")]
		[Address(RVA = "0x26D4340", Offset = "0x26D2F40", VA = "0x1826D4340")]
		public void OnBtnSwitchItemRightClicked()
		{
		}

		// Token: 0x0602AF67 RID: 175975 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AF67")]
		[Address(RVA = "0x26D49B0", Offset = "0x26D35B0", VA = "0x1826D49B0")]
		public Act1VHalfIdleStuffDepotItemDetailDialog()
		{
		}

		// Token: 0x0602AF68 RID: 175976 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AF68")]
		[Address(RVA = "0xE613C0", Offset = "0xE5FFC0", VA = "0x180E613C0")]
		private void <>xLuaBaseProxy_OnInit()
		{
		}

		// Token: 0x0602AF69 RID: 175977 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602AF69")]
		[Address(RVA = "0xE613B0", Offset = "0xE5FFB0", VA = "0x180E613B0")]
		private UIRenderTextureImage <>xLuaBaseProxy_GetBlurTarget()
		{
			return null;
		}

		// Token: 0x0403DFD5 RID: 253909
		[Token(Token = "0x403DFD5")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private UIRenderTextureImage _blurImage;

		// Token: 0x0403DFD6 RID: 253910
		[Token(Token = "0x403DFD6")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private RectTransform _backPress;

		// Token: 0x0403DFD7 RID: 253911
		[Token(Token = "0x403DFD7")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Text _name;

		// Token: 0x0403DFD8 RID: 253912
		[Token(Token = "0x403DFD8")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Text _cnt;

		// Token: 0x0403DFD9 RID: 253913
		[Token(Token = "0x403DFD9")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Image _icon;

		// Token: 0x0403DFDA RID: 253914
		[Token(Token = "0x403DFDA")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Text _desc;

		// Token: 0x0403DFDB RID: 253915
		[Token(Token = "0x403DFDB")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private Text _desc2;

		// Token: 0x0403DFDC RID: 253916
		[Token(Token = "0x403DFDC")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private Text _obtain;

		// Token: 0x0403DFDD RID: 253917
		[Token(Token = "0x403DFDD")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private GameObject _btnToUse;

		// Token: 0x0403DFDE RID: 253918
		[Token(Token = "0x403DFDE")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private GameObject _pnlArrowLeft;

		// Token: 0x0403DFDF RID: 253919
		[Token(Token = "0x403DFDF")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private GameObject _pnlArrowRight;

		// Token: 0x0403DFE0 RID: 253920
		[Token(Token = "0x403DFE0")]
		[FieldOffset(Offset = "0xC8")]
		private Act1VHalfIdleStuffDepotItemDetailDialog.Option m_cachedInput;

		// Token: 0x0403DFE1 RID: 253921
		[Token(Token = "0x403DFE1")]
		[FieldOffset(Offset = "0xD0")]
		private int m_selectedIndex;

		// Token: 0x0403DFE2 RID: 253922
		[Token(Token = "0x403DFE2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x0403DFE3 RID: 253923
		[Token(Token = "0x403DFE3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x0403DFE4 RID: 253924
		[Token(Token = "0x403DFE4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__Render;

		// Token: 0x0403DFE5 RID: 253925
		[Token(Token = "0x403DFE5")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetBlurTarget;

		// Token: 0x0403DFE6 RID: 253926
		[Token(Token = "0x403DFE6")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_EventOnClose;

		// Token: 0x0403DFE7 RID: 253927
		[Token(Token = "0x403DFE7")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_EventOnToUse;

		// Token: 0x0403DFE8 RID: 253928
		[Token(Token = "0x403DFE8")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnBtnSwitchItemLeftClicked;

		// Token: 0x0403DFE9 RID: 253929
		[Token(Token = "0x403DFE9")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnBtnSwitchItemRightClicked;

		// Token: 0x0403DFEA RID: 253930
		[Token(Token = "0x403DFEA")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200777C RID: 30588
		[Token(Token = "0x200777C")]
		public class Option
		{
			// Token: 0x0602AF6A RID: 175978 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602AF6A")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Option()
			{
			}

			// Token: 0x0403DFEB RID: 253931
			[Token(Token = "0x403DFEB")]
			[FieldOffset(Offset = "0x10")]
			public Act1VHalfIdleStuffDepotItemViewModel itemViewModel;

			// Token: 0x0403DFEC RID: 253932
			[Token(Token = "0x403DFEC")]
			[FieldOffset(Offset = "0x18")]
			public List<Act1VHalfIdleStuffDepotItemViewModel> itemViewModelList;

			// Token: 0x0403DFED RID: 253933
			[Token(Token = "0x403DFED")]
			[FieldOffset(Offset = "0x20")]
			public string actId;
		}
	}
}
