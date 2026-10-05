using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003474 RID: 13428
	[Token(Token = "0x2003474")]
	[CSharpCallLua]
	public interface ILuaActivityUtil
	{
		// Token: 0x060156E8 RID: 87784
		[Token(Token = "0x60156E8")]
		void FindValidHomeActs(List<ActivityUtil.SortableActivity> validActs, List<ActivityUtil.SortableActivity> uncompleteActs, List<ActivityUtil.SortableActivity> unfinishedActs, List<ActivityUtil.SortableActivity> finishedActs);

		// Token: 0x060156E9 RID: 87785
		[Token(Token = "0x60156E9")]
		string EnsureActivityDialogClass(LuaActClsConfig config);

		// Token: 0x060156EA RID: 87786
		[Token(Token = "0x60156EA")]
		bool CheckIfActivityUncomplete(ActivityType type, string actId);
	}
}
