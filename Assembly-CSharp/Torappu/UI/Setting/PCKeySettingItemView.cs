using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Setting
{
	// Token: 0x02003FD7 RID: 16343
	[Token(Token = "0x2003FD7")]
	public class PCKeySettingItemView : UISimpleRecycleLayoutItemView<PCKeySettingItemModel>, IHotfixable
	{
		// Token: 0x06019542 RID: 103746 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6019542")]
		[Address(RVA = "0x11FB0D0", Offset = "0x11F9CD0", VA = "0x1811FB0D0", Slot = "4")]
		public override string GetViewType()
		{
			return null;
		}

		// Token: 0x06019543 RID: 103747 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019543")]
		[Address(RVA = "0x11FB140", Offset = "0x11F9D40", VA = "0x1811FB140", Slot = "6")]
		protected override void OnRender(PCKeySettingItemModel viewModel, ValueBundle value)
		{
		}

		// Token: 0x06019544 RID: 103748 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019544")]
		[Address(RVA = "0x11FB5F0", Offset = "0x11FA1F0", VA = "0x1811FB5F0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06019545 RID: 103749 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019545")]
		[Address(RVA = "0x11FB7E0", Offset = "0x11FA3E0", VA = "0x1811FB7E0")]
		private void _OnKeyBtnClicked()
		{
		}

		// Token: 0x06019546 RID: 103750 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019546")]
		[Address(RVA = "0x11FB980", Offset = "0x11FA580", VA = "0x1811FB980")]
		public PCKeySettingItemView()
		{
		}

		// Token: 0x0401F7BE RID: 128958
		[Token(Token = "0x401F7BE")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RectTransform _rectTransform;

		// Token: 0x0401F7BF RID: 128959
		[Token(Token = "0x401F7BF")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _funcName;

		// Token: 0x0401F7C0 RID: 128960
		[Token(Token = "0x401F7C0")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Transform _keyCardHolder;

		// Token: 0x0401F7C1 RID: 128961
		[Token(Token = "0x401F7C1")]
		[FieldOffset(Offset = "0x40")]
		private bool m_hasInited;

		// Token: 0x0401F7C2 RID: 128962
		[Token(Token = "0x401F7C2")]
		[FieldOffset(Offset = "0x48")]
		private KeyBoardVirtualButtonConfig m_cachedConfig;

		// Token: 0x0401F7C3 RID: 128963
		[Token(Token = "0x401F7C3")]
		[FieldOffset(Offset = "0x50")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0401F7C4 RID: 128964
		[Token(Token = "0x401F7C4")]
		[FieldOffset(Offset = "0x60")]
		private PCKeyCard m_keyCard;

		// Token: 0x0401F7C5 RID: 128965
		[Token(Token = "0x401F7C5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetViewType;

		// Token: 0x0401F7C6 RID: 128966
		[Token(Token = "0x401F7C6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x0401F7C7 RID: 128967
		[Token(Token = "0x401F7C7")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401F7C8 RID: 128968
		[Token(Token = "0x401F7C8")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnKeyBtnClicked;

		// Token: 0x0401F7C9 RID: 128969
		[Token(Token = "0x401F7C9")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
