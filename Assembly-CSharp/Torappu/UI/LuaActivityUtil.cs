using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003475 RID: 13429
	[Token(Token = "0x2003475")]
	public class LuaActivityUtil : Singleton<LuaActivityUtil>
	{
		// Token: 0x060156EB RID: 87787 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60156EB")]
		[Address(RVA = "0xDEB300", Offset = "0xDE9F00", VA = "0x180DEB300")]
		private LuaActivityUtil()
		{
		}

		// Token: 0x060156EC RID: 87788 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60156EC")]
		[Address(RVA = "0xDEAE50", Offset = "0xDE9A50", VA = "0x180DEAE50")]
		public static void BindInterface(ILuaActivityUtil impl)
		{
		}

		// Token: 0x060156ED RID: 87789 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60156ED")]
		[Address(RVA = "0xDEB190", Offset = "0xDE9D90", VA = "0x180DEB190")]
		public void FindValidHomeActs(List<ActivityUtil.SortableActivity> validActs, List<ActivityUtil.SortableActivity> uncompleteActs, List<ActivityUtil.SortableActivity> unfinishedActs, List<ActivityUtil.SortableActivity> finishedActs)
		{
		}

		// Token: 0x060156EE RID: 87790 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60156EE")]
		[Address(RVA = "0xDEB030", Offset = "0xDE9C30", VA = "0x180DEB030")]
		public string EnsureActivityDialogClass(LuaActClsConfig config)
		{
			return null;
		}

		// Token: 0x060156EF RID: 87791 RVA: 0x0008BEA8 File Offset: 0x0008A0A8
		[Token(Token = "0x60156EF")]
		[Address(RVA = "0xDEAEE0", Offset = "0xDE9AE0", VA = "0x180DEAEE0")]
		public bool CheckIfActivityUncomplete(ActivityType type, string actId)
		{
			return default(bool);
		}

		// Token: 0x04019A8F RID: 105103
		[Token(Token = "0x4019A8F")]
		[FieldOffset(Offset = "0x10")]
		private ILuaActivityUtil m_impl;

		// Token: 0x04019A90 RID: 105104
		[Token(Token = "0x4019A90")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x04019A91 RID: 105105
		[Token(Token = "0x4019A91")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_BindInterface;

		// Token: 0x04019A92 RID: 105106
		[Token(Token = "0x4019A92")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_FindValidHomeActs;

		// Token: 0x04019A93 RID: 105107
		[Token(Token = "0x4019A93")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EnsureActivityDialogClass;

		// Token: 0x04019A94 RID: 105108
		[Token(Token = "0x4019A94")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_CheckIfActivityUncomplete;
	}
}
