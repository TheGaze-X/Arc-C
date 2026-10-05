using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act25side
{
	// Token: 0x020074F7 RID: 29943
	[Token(Token = "0x20074F7")]
	public class Act25sideResearchAddTokenState : PopupFloatState
	{
		// Token: 0x0602A336 RID: 172854 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A336")]
		[Address(RVA = "0x25CC300", Offset = "0x25CAF00", VA = "0x1825CC300", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0602A337 RID: 172855 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A337")]
		[Address(RVA = "0x25CC360", Offset = "0x25CAF60", VA = "0x1825CC360", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0602A338 RID: 172856 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A338")]
		[Address(RVA = "0x25CC5B0", Offset = "0x25CB1B0", VA = "0x1825CC5B0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602A339 RID: 172857 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A339")]
		[Address(RVA = "0x25CC6D0", Offset = "0x25CB2D0", VA = "0x1825CC6D0")]
		public Act25sideResearchAddTokenState()
		{
		}

		// Token: 0x0602A33A RID: 172858 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A33A")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0403CA40 RID: 248384
		[Token(Token = "0x403CA40")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Act25sideResearchAddTokenView _view;

		// Token: 0x0403CA41 RID: 248385
		[Token(Token = "0x403CA41")]
		[FieldOffset(Offset = "0x78")]
		private bool m_isInited;

		// Token: 0x0403CA42 RID: 248386
		[Token(Token = "0x403CA42")]
		[FieldOffset(Offset = "0x80")]
		private Act25sideResearchAddTokenStateBean m_stateBean;

		// Token: 0x0403CA43 RID: 248387
		[Token(Token = "0x403CA43")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0403CA44 RID: 248388
		[Token(Token = "0x403CA44")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0403CA45 RID: 248389
		[Token(Token = "0x403CA45")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403CA46 RID: 248390
		[Token(Token = "0x403CA46")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
