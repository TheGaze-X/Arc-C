using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act1mainss
{
	// Token: 0x0200783C RID: 30780
	[Token(Token = "0x200783C")]
	public class Act1MainSSActDetailState : PopupFloatState
	{
		// Token: 0x0602B2CA RID: 176842 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B2CA")]
		[Address(RVA = "0x26EE5B0", Offset = "0x26ED1B0", VA = "0x1826EE5B0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0602B2CB RID: 176843 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B2CB")]
		[Address(RVA = "0x26EE610", Offset = "0x26ED210", VA = "0x1826EE610")]
		public void OnBackgroundClickEvent()
		{
		}

		// Token: 0x0602B2CC RID: 176844 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B2CC")]
		[Address(RVA = "0x26EE6C0", Offset = "0x26ED2C0", VA = "0x1826EE6C0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0602B2CD RID: 176845 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B2CD")]
		[Address(RVA = "0x26EEB80", Offset = "0x26ED780", VA = "0x1826EEB80")]
		private void _InitTopMenu()
		{
		}

		// Token: 0x0602B2CE RID: 176846 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B2CE")]
		[Address(RVA = "0x26EECA0", Offset = "0x26ED8A0", VA = "0x1826EECA0")]
		public Act1MainSSActDetailState()
		{
		}

		// Token: 0x0602B2CF RID: 176847 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B2CF")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0403E68E RID: 255630
		[Token(Token = "0x403E68E")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Act1MainSSActDetaiView _view;

		// Token: 0x0403E68F RID: 255631
		[Token(Token = "0x403E68F")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private RectTransform _topMenuContainer;

		// Token: 0x0403E690 RID: 255632
		[Token(Token = "0x403E690")]
		[FieldOffset(Offset = "0x80")]
		private CommonTopMenu m_topMenu;

		// Token: 0x0403E691 RID: 255633
		[Token(Token = "0x403E691")]
		[FieldOffset(Offset = "0x88")]
		private string m_cachedActivityId;

		// Token: 0x0403E692 RID: 255634
		[Token(Token = "0x403E692")]
		[FieldOffset(Offset = "0x90")]
		private Act1MainSSActDetaiView.Param m_cachedParam;

		// Token: 0x0403E693 RID: 255635
		[Token(Token = "0x403E693")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0403E694 RID: 255636
		[Token(Token = "0x403E694")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnBackgroundClickEvent;

		// Token: 0x0403E695 RID: 255637
		[Token(Token = "0x403E695")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0403E696 RID: 255638
		[Token(Token = "0x403E696")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitTopMenu;

		// Token: 0x0403E697 RID: 255639
		[Token(Token = "0x403E697")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
