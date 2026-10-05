using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act10D5
{
	// Token: 0x02007B25 RID: 31525
	[Token(Token = "0x2007B25")]
	public class Act10D5FavorUpState : PopupFloatState
	{
		// Token: 0x0602C229 RID: 180777 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C229")]
		[Address(RVA = "0x2805DF0", Offset = "0x28049F0", VA = "0x182805DF0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0602C22A RID: 180778 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C22A")]
		[Address(RVA = "0x2805E50", Offset = "0x2804A50", VA = "0x182805E50", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0602C22B RID: 180779 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C22B")]
		[Address(RVA = "0x2805FD0", Offset = "0x2804BD0", VA = "0x182805FD0", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x0602C22C RID: 180780 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C22C")]
		[Address(RVA = "0x2805CA0", Offset = "0x28048A0", VA = "0x182805CA0")]
		public void EventOnBackgroundClicked()
		{
		}

		// Token: 0x0602C22D RID: 180781 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C22D")]
		[Address(RVA = "0x2806150", Offset = "0x2804D50", VA = "0x182806150")]
		private void _InitTopMenu()
		{
		}

		// Token: 0x0602C22E RID: 180782 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C22E")]
		[Address(RVA = "0x2806270", Offset = "0x2804E70", VA = "0x182806270")]
		public Act10D5FavorUpState()
		{
		}

		// Token: 0x0602C230 RID: 180784 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C230")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0602C231 RID: 180785 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C231")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x0403FFA9 RID: 262057
		[Token(Token = "0x403FFA9")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Act10D5FavorUpView _view;

		// Token: 0x0403FFAA RID: 262058
		[Token(Token = "0x403FFAA")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private RectTransform _topMenuContainer;

		// Token: 0x0403FFAB RID: 262059
		[Token(Token = "0x403FFAB")]
		[FieldOffset(Offset = "0x80")]
		private CommonTopMenu m_topMenu;

		// Token: 0x0403FFAC RID: 262060
		[Token(Token = "0x403FFAC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0403FFAD RID: 262061
		[Token(Token = "0x403FFAD")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0403FFAE RID: 262062
		[Token(Token = "0x403FFAE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x0403FFAF RID: 262063
		[Token(Token = "0x403FFAF")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventOnBackgroundClicked;

		// Token: 0x0403FFB0 RID: 262064
		[Token(Token = "0x403FFB0")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__InitTopMenu;

		// Token: 0x0403FFB1 RID: 262065
		[Token(Token = "0x403FFB1")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
