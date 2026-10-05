using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act25side
{
	// Token: 0x020074F8 RID: 29944
	[Token(Token = "0x20074F8")]
	public class Act25sideResearchConfirmState : PopupFloatState
	{
		// Token: 0x0602A33B RID: 172859 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A33B")]
		[Address(RVA = "0x25CC780", Offset = "0x25CB380", VA = "0x1825CC780", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0602A33C RID: 172860 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A33C")]
		[Address(RVA = "0x25CC7E0", Offset = "0x25CB3E0", VA = "0x1825CC7E0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0602A33D RID: 172861 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A33D")]
		[Address(RVA = "0x25CCF20", Offset = "0x25CBB20", VA = "0x1825CCF20")]
		private void _UpdateProp()
		{
		}

		// Token: 0x0602A33E RID: 172862 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A33E")]
		[Address(RVA = "0x25CCC60", Offset = "0x25CB860", VA = "0x1825CCC60")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602A33F RID: 172863 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A33F")]
		[Address(RVA = "0x25CC900", Offset = "0x25CB500", VA = "0x1825CC900")]
		private void _EventOnConfirm()
		{
		}

		// Token: 0x0602A340 RID: 172864 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A340")]
		[Address(RVA = "0x25CCFF0", Offset = "0x25CBBF0", VA = "0x1825CCFF0")]
		public Act25sideResearchConfirmState()
		{
		}

		// Token: 0x0602A342 RID: 172866 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A342")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0403CA47 RID: 248391
		[Token(Token = "0x403CA47")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Act25sideResearchConfirmView _view;

		// Token: 0x0403CA48 RID: 248392
		[Token(Token = "0x403CA48")]
		[FieldOffset(Offset = "0x78")]
		private bool m_isInited;

		// Token: 0x0403CA49 RID: 248393
		[Token(Token = "0x403CA49")]
		[FieldOffset(Offset = "0x80")]
		private string m_cachedActId;

		// Token: 0x0403CA4A RID: 248394
		[Token(Token = "0x403CA4A")]
		[FieldOffset(Offset = "0x88")]
		private Act25sideResearchConfirmProperty m_researchConfirmProp;

		// Token: 0x0403CA4B RID: 248395
		[Token(Token = "0x403CA4B")]
		[FieldOffset(Offset = "0x90")]
		private Act25sideResearchConfirmStateBean m_stateBean;

		// Token: 0x0403CA4C RID: 248396
		[Token(Token = "0x403CA4C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0403CA4D RID: 248397
		[Token(Token = "0x403CA4D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0403CA4E RID: 248398
		[Token(Token = "0x403CA4E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__UpdateProp;

		// Token: 0x0403CA4F RID: 248399
		[Token(Token = "0x403CA4F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403CA50 RID: 248400
		[Token(Token = "0x403CA50")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__EventOnConfirm;

		// Token: 0x0403CA51 RID: 248401
		[Token(Token = "0x403CA51")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
