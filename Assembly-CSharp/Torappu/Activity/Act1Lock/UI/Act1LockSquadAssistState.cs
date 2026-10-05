using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act1Lock.UI
{
	// Token: 0x0200788E RID: 30862
	[Token(Token = "0x200788E")]
	public class Act1LockSquadAssistState : PopupFadeState
	{
		// Token: 0x0602B433 RID: 177203 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B433")]
		[Address(RVA = "0x2713020", Offset = "0x2711C20", VA = "0x182713020", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0602B434 RID: 177204 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B434")]
		[Address(RVA = "0x2713080", Offset = "0x2711C80", VA = "0x182713080", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0602B435 RID: 177205 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B435")]
		[Address(RVA = "0x2713100", Offset = "0x2711D00", VA = "0x182713100")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602B436 RID: 177206 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B436")]
		[Address(RVA = "0x2713420", Offset = "0x2712020", VA = "0x182713420")]
		private void _OnSkillClick(int index)
		{
		}

		// Token: 0x0602B437 RID: 177207 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B437")]
		[Address(RVA = "0x2713360", Offset = "0x2711F60", VA = "0x182713360")]
		private void _OnConfirmBtnClick()
		{
		}

		// Token: 0x0602B438 RID: 177208 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B438")]
		[Address(RVA = "0x27134A0", Offset = "0x27120A0", VA = "0x1827134A0")]
		public Act1LockSquadAssistState()
		{
		}

		// Token: 0x0602B43A RID: 177210 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B43A")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0403E869 RID: 256105
		[Token(Token = "0x403E869")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private UIBlurFloatPanel _blurPanel;

		// Token: 0x0403E86A RID: 256106
		[Token(Token = "0x403E86A")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private RectTransform _topMenuContainer;

		// Token: 0x0403E86B RID: 256107
		[Token(Token = "0x403E86B")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Act1LockAssistView _assistView;

		// Token: 0x0403E86C RID: 256108
		[Token(Token = "0x403E86C")]
		[FieldOffset(Offset = "0x88")]
		private bool m_isInited;

		// Token: 0x0403E86D RID: 256109
		[Token(Token = "0x403E86D")]
		[FieldOffset(Offset = "0x90")]
		private Act1LockSquadAssistStateBean m_stateBean;

		// Token: 0x0403E86E RID: 256110
		[Token(Token = "0x403E86E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0403E86F RID: 256111
		[Token(Token = "0x403E86F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0403E870 RID: 256112
		[Token(Token = "0x403E870")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403E871 RID: 256113
		[Token(Token = "0x403E871")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnSkillClick;

		// Token: 0x0403E872 RID: 256114
		[Token(Token = "0x403E872")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnConfirmBtnClick;

		// Token: 0x0403E873 RID: 256115
		[Token(Token = "0x403E873")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
