using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity
{
	// Token: 0x02006D91 RID: 28049
	[Token(Token = "0x2006D91")]
	public class ActCommonReplicateState : PopupFloatState
	{
		// Token: 0x06027F45 RID: 163653 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027F45")]
		[Address(RVA = "0x23326E0", Offset = "0x23312E0", VA = "0x1823326E0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06027F46 RID: 163654 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027F46")]
		[Address(RVA = "0x2332420", Offset = "0x2331020", VA = "0x182332420", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x06027F47 RID: 163655 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027F47")]
		[Address(RVA = "0x23323C0", Offset = "0x2330FC0", VA = "0x1823323C0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06027F48 RID: 163656 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027F48")]
		[Address(RVA = "0x2332600", Offset = "0x2331200", VA = "0x182332600")]
		public void ToShopPage()
		{
		}

		// Token: 0x06027F49 RID: 163657 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027F49")]
		[Address(RVA = "0x2332800", Offset = "0x2331400", VA = "0x182332800")]
		public ActCommonReplicateState()
		{
		}

		// Token: 0x06027F4A RID: 163658 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027F4A")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x040389FD RID: 231933
		[Token(Token = "0x40389FD")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private ActCommonReplicateView _view;

		// Token: 0x040389FE RID: 231934
		[Token(Token = "0x40389FE")]
		[FieldOffset(Offset = "0x78")]
		private bool m_isInited;

		// Token: 0x040389FF RID: 231935
		[Token(Token = "0x40389FF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04038A00 RID: 231936
		[Token(Token = "0x4038A00")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04038A01 RID: 231937
		[Token(Token = "0x4038A01")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04038A02 RID: 231938
		[Token(Token = "0x4038A02")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_ToShopPage;

		// Token: 0x04038A03 RID: 231939
		[Token(Token = "0x4038A03")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
