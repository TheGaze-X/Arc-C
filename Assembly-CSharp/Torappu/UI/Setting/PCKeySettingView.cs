using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.Setting
{
	// Token: 0x02003FDC RID: 16348
	[Token(Token = "0x2003FDC")]
	public class PCKeySettingView : DataBinder<PCKeySettingProperty>, IHotfixable
	{
		// Token: 0x06019553 RID: 103763 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019553")]
		[Address(RVA = "0x11FE4F0", Offset = "0x11FD0F0", VA = "0x1811FE4F0", Slot = "7")]
		public override void OnValueChanged(PCKeySettingProperty property)
		{
		}

		// Token: 0x06019554 RID: 103764 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019554")]
		[Address(RVA = "0x11FE9D0", Offset = "0x11FD5D0", VA = "0x1811FE9D0")]
		private void _ForceRebuildLayout()
		{
		}

		// Token: 0x06019555 RID: 103765 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019555")]
		[Address(RVA = "0x11FEA70", Offset = "0x11FD670", VA = "0x1811FEA70")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06019556 RID: 103766 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019556")]
		[Address(RVA = "0x11FEC90", Offset = "0x11FD890", VA = "0x1811FEC90")]
		public PCKeySettingView()
		{
		}

		// Token: 0x0401F7EA RID: 129002
		[Token(Token = "0x401F7EA")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UISimpleRecycleLayoutItemView[] _prefabList;

		// Token: 0x0401F7EB RID: 129003
		[Token(Token = "0x401F7EB")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RectTransform _rectNormal;

		// Token: 0x0401F7EC RID: 129004
		[Token(Token = "0x401F7EC")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UIRecycleVerticalLayoutGroup _normalGroup;

		// Token: 0x0401F7ED RID: 129005
		[Token(Token = "0x401F7ED")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private RectTransform _rectAct;

		// Token: 0x0401F7EE RID: 129006
		[Token(Token = "0x401F7EE")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UIRecycleVerticalLayoutGroup _actGroup;

		// Token: 0x0401F7EF RID: 129007
		[Token(Token = "0x401F7EF")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _panelTab;

		// Token: 0x0401F7F0 RID: 129008
		[Token(Token = "0x401F7F0")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private PCKeySettingTabView[] _tabList;

		// Token: 0x0401F7F1 RID: 129009
		[Token(Token = "0x401F7F1")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private CanvasGroup _canvasNormalGroup;

		// Token: 0x0401F7F2 RID: 129010
		[Token(Token = "0x401F7F2")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private CanvasGroup _canvasActGroup;

		// Token: 0x0401F7F3 RID: 129011
		[Token(Token = "0x401F7F3")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private UILayoutDimensionListener _listener;

		// Token: 0x0401F7F4 RID: 129012
		[Token(Token = "0x401F7F4")]
		[FieldOffset(Offset = "0x70")]
		private UISwitchTween m_normalSwitchTween;

		// Token: 0x0401F7F5 RID: 129013
		[Token(Token = "0x401F7F5")]
		[FieldOffset(Offset = "0x78")]
		private UISwitchTween m_actSwitchTween;

		// Token: 0x0401F7F6 RID: 129014
		[Token(Token = "0x401F7F6")]
		[FieldOffset(Offset = "0x80")]
		private bool m_hasInited;

		// Token: 0x0401F7F7 RID: 129015
		[Token(Token = "0x401F7F7")]
		[FieldOffset(Offset = "0x88")]
		private UISimpleRecycleLayoutAdapter m_normalAdapter;

		// Token: 0x0401F7F8 RID: 129016
		[Token(Token = "0x401F7F8")]
		[FieldOffset(Offset = "0x90")]
		private UISimpleRecycleLayoutAdapter m_actAdapter;

		// Token: 0x0401F7F9 RID: 129017
		[Token(Token = "0x401F7F9")]
		[FieldOffset(Offset = "0x98")]
		private int m_cachedSequenceNum;

		// Token: 0x0401F7FA RID: 129018
		[Token(Token = "0x401F7FA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0401F7FB RID: 129019
		[Token(Token = "0x401F7FB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__ForceRebuildLayout;

		// Token: 0x0401F7FC RID: 129020
		[Token(Token = "0x401F7FC")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401F7FD RID: 129021
		[Token(Token = "0x401F7FD")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003FDD RID: 16349
		[Token(Token = "0x2003FDD")]
		private class OnPostLayoutAction : UILayoutDimensionListener.IAction
		{
			// Token: 0x06019557 RID: 103767 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6019557")]
			[Address(RVA = "0x557D40", Offset = "0x556940", VA = "0x180557D40")]
			public OnPostLayoutAction(PCKeySettingView closure)
			{
			}

			// Token: 0x06019558 RID: 103768 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6019558")]
			[Address(RVA = "0x11F8190", Offset = "0x11F6D90", VA = "0x1811F8190", Slot = "4")]
			public void DoAction()
			{
			}

			// Token: 0x0401F7FE RID: 129022
			[Token(Token = "0x401F7FE")]
			[FieldOffset(Offset = "0x10")]
			private PCKeySettingView m_closure;
		}
	}
}
