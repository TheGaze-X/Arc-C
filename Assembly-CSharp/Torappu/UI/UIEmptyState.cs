using System;
using System.Collections;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003680 RID: 13952
	[Token(Token = "0x2003680")]
	public class UIEmptyState : State
	{
		// Token: 0x06016332 RID: 90930 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6016332")]
		[Address(RVA = "0xEA3C90", Offset = "0xEA2890", VA = "0x180EA3C90", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06016333 RID: 90931 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6016333")]
		[Address(RVA = "0xEA3CF0", Offset = "0xEA28F0", VA = "0x180EA3CF0", Slot = "19")]
		protected override IEnumerator OnPreload()
		{
			return null;
		}

		// Token: 0x06016334 RID: 90932 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016334")]
		[Address(RVA = "0xEA3E20", Offset = "0xEA2A20", VA = "0x180EA3E20")]
		public UIEmptyState()
		{
		}

		// Token: 0x06016335 RID: 90933 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6016335")]
		[Address(RVA = "0xEA3D80", Offset = "0xEA2980", VA = "0x180EA3D80")]
		private IEnumerator <>xLuaBaseProxy_OnPreload()
		{
			return null;
		}

		// Token: 0x0401AAE4 RID: 109284
		[Token(Token = "0x401AAE4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0401AAE5 RID: 109285
		[Token(Token = "0x401AAE5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnPreload;

		// Token: 0x0401AAE6 RID: 109286
		[Token(Token = "0x401AAE6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
