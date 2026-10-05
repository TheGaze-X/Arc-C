using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x020035D0 RID: 13776
	[Token(Token = "0x20035D0")]
	public class DefaultCommonSquadTopMenuView : CommonSquadTopMenuViewBase
	{
		// Token: 0x06015EA7 RID: 89767 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015EA7")]
		[Address(RVA = "0xE68C20", Offset = "0xE67820", VA = "0x180E68C20")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06015EA8 RID: 89768 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015EA8")]
		[Address(RVA = "0xE68CF0", Offset = "0xE678F0", VA = "0x180E68CF0")]
		private void _OnInitTopMenu(GameObject topMenuObj)
		{
		}

		// Token: 0x06015EA9 RID: 89769 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015EA9")]
		[Address(RVA = "0xE68EA0", Offset = "0xE67AA0", VA = "0x180E68EA0")]
		private void _OnTopMenuRoutedToOtherPage(UIRouteTarget routeTarget, object param, Action<UIRouteTarget, object> baseHandler)
		{
		}

		// Token: 0x06015EAA RID: 89770 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015EAA")]
		[Address(RVA = "0xE68A90", Offset = "0xE67690", VA = "0x180E68A90", Slot = "7")]
		public override void OnValueChanged(CommonSquadGroupViewProperty property)
		{
		}

		// Token: 0x06015EAB RID: 89771 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015EAB")]
		[Address(RVA = "0xE69010", Offset = "0xE67C10", VA = "0x180E69010")]
		public DefaultCommonSquadTopMenuView()
		{
		}

		// Token: 0x0401A5AC RID: 107948
		[Token(Token = "0x401A5AC")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private TopMenuDynamicPrefabInstHolder _topMenuHolder;

		// Token: 0x0401A5AD RID: 107949
		[Token(Token = "0x401A5AD")]
		[FieldOffset(Offset = "0x38")]
		private bool m_isInited;

		// Token: 0x0401A5AE RID: 107950
		[Token(Token = "0x401A5AE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401A5AF RID: 107951
		[Token(Token = "0x401A5AF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__OnInitTopMenu;

		// Token: 0x0401A5B0 RID: 107952
		[Token(Token = "0x401A5B0")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__OnTopMenuRoutedToOtherPage;

		// Token: 0x0401A5B1 RID: 107953
		[Token(Token = "0x401A5B1")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0401A5B2 RID: 107954
		[Token(Token = "0x401A5B2")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
