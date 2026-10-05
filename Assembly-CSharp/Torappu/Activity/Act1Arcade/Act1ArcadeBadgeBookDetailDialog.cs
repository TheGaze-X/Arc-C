using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act1Arcade
{
	// Token: 0x02007921 RID: 31009
	[Token(Token = "0x2007921")]
	public class Act1ArcadeBadgeBookDetailDialog : UICompDialog<Act1ArcadeBadgeBookDetailDialog.Input>
	{
		// Token: 0x0602B811 RID: 178193 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B811")]
		[Address(RVA = "0x2766A40", Offset = "0x2765640", VA = "0x182766A40")]
		private void _OnCloseEvent()
		{
		}

		// Token: 0x0602B812 RID: 178194 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B812")]
		[Address(RVA = "0x2766C30", Offset = "0x2765830", VA = "0x182766C30")]
		private void _OnSwitchForwardEvent()
		{
		}

		// Token: 0x0602B813 RID: 178195 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B813")]
		[Address(RVA = "0x2766B00", Offset = "0x2765700", VA = "0x182766B00")]
		private void _OnSwitchBackwardEvent()
		{
		}

		// Token: 0x0602B814 RID: 178196 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B814")]
		[Address(RVA = "0x2766650", Offset = "0x2765250", VA = "0x182766650", Slot = "9")]
		protected override void OnInit()
		{
		}

		// Token: 0x0602B815 RID: 178197 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B815")]
		[Address(RVA = "0x2766920", Offset = "0x2765520", VA = "0x182766920", Slot = "18")]
		protected override void OnRender(Act1ArcadeBadgeBookDetailDialog.Input input)
		{
		}

		// Token: 0x0602B816 RID: 178198 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B816")]
		[Address(RVA = "0x2766D60", Offset = "0x2765960", VA = "0x182766D60")]
		public Act1ArcadeBadgeBookDetailDialog()
		{
		}

		// Token: 0x0602B817 RID: 178199 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B817")]
		[Address(RVA = "0xE613C0", Offset = "0xE5FFC0", VA = "0x180E613C0")]
		private void <>xLuaBaseProxy_OnInit()
		{
		}

		// Token: 0x0403EE68 RID: 257640
		[Token(Token = "0x403EE68")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Act1ArcadeBadgeBookDetailView _badgeBookDetailView;

		// Token: 0x0403EE69 RID: 257641
		[Token(Token = "0x403EE69")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private RectTransform _backRect;

		// Token: 0x0403EE6A RID: 257642
		[Token(Token = "0x403EE6A")]
		[FieldOffset(Offset = "0x80")]
		private Act1ArcadeBadgeBookDetailProperty m_property;

		// Token: 0x0403EE6B RID: 257643
		[Token(Token = "0x403EE6B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__OnCloseEvent;

		// Token: 0x0403EE6C RID: 257644
		[Token(Token = "0x403EE6C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__OnSwitchForwardEvent;

		// Token: 0x0403EE6D RID: 257645
		[Token(Token = "0x403EE6D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__OnSwitchBackwardEvent;

		// Token: 0x0403EE6E RID: 257646
		[Token(Token = "0x403EE6E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x0403EE6F RID: 257647
		[Token(Token = "0x403EE6F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x0403EE70 RID: 257648
		[Token(Token = "0x403EE70")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02007922 RID: 31010
		[Token(Token = "0x2007922")]
		public class Input
		{
			// Token: 0x0602B818 RID: 178200 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602B818")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Input()
			{
			}

			// Token: 0x0403EE71 RID: 257649
			[Token(Token = "0x403EE71")]
			[FieldOffset(Offset = "0x10")]
			public string actId;

			// Token: 0x0403EE72 RID: 257650
			[Token(Token = "0x403EE72")]
			[FieldOffset(Offset = "0x18")]
			public Act1ArcadeBadgeBookItemViewModel ultimateItem;

			// Token: 0x0403EE73 RID: 257651
			[Token(Token = "0x403EE73")]
			[FieldOffset(Offset = "0x20")]
			public Dictionary<string, Act1ArcadeBadgeBookGroupViewModel> badgeGroups;

			// Token: 0x0403EE74 RID: 257652
			[Token(Token = "0x403EE74")]
			[FieldOffset(Offset = "0x28")]
			public string presentingBadgeId;
		}
	}
}
