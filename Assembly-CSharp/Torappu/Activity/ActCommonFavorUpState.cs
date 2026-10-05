using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity
{
	// Token: 0x02006D7A RID: 28026
	[Token(Token = "0x2006D7A")]
	public class ActCommonFavorUpState : PopupFloatState
	{
		// Token: 0x06027EDF RID: 163551 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027EDF")]
		[Address(RVA = "0x232CC10", Offset = "0x232B810", VA = "0x18232CC10", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06027EE0 RID: 163552 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027EE0")]
		[Address(RVA = "0x232CC70", Offset = "0x232B870", VA = "0x18232CC70", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x06027EE1 RID: 163553 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027EE1")]
		[Address(RVA = "0x232CB60", Offset = "0x232B760", VA = "0x18232CB60")]
		public void EventOnBackgroundClicked()
		{
		}

		// Token: 0x06027EE2 RID: 163554 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027EE2")]
		[Address(RVA = "0x232CE10", Offset = "0x232BA10", VA = "0x18232CE10")]
		private void _InitTopMenu()
		{
		}

		// Token: 0x06027EE3 RID: 163555 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027EE3")]
		[Address(RVA = "0x232CF30", Offset = "0x232BB30", VA = "0x18232CF30")]
		public ActCommonFavorUpState()
		{
		}

		// Token: 0x06027EE5 RID: 163557 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027EE5")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0403897B RID: 231803
		[Token(Token = "0x403897B")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private ActCommonFavorUpView _view;

		// Token: 0x0403897C RID: 231804
		[Token(Token = "0x403897C")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private RectTransform _topMenuContainer;

		// Token: 0x0403897D RID: 231805
		[Token(Token = "0x403897D")]
		[FieldOffset(Offset = "0x80")]
		private CommonTopMenu m_topMenu;

		// Token: 0x0403897E RID: 231806
		[Token(Token = "0x403897E")]
		[FieldOffset(Offset = "0x88")]
		private ActCommonFavorUpStateBean m_stateBean;

		// Token: 0x0403897F RID: 231807
		[Token(Token = "0x403897F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04038980 RID: 231808
		[Token(Token = "0x4038980")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04038981 RID: 231809
		[Token(Token = "0x4038981")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_EventOnBackgroundClicked;

		// Token: 0x04038982 RID: 231810
		[Token(Token = "0x4038982")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitTopMenu;

		// Token: 0x04038983 RID: 231811
		[Token(Token = "0x4038983")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
