using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu;
using Torappu.UI;

namespace XLua.CSObjectWrap
{
	// Token: 0x020003E2 RID: 994
	[Token(Token = "0x20003E2")]
	public class TorappuUIILuaActivityUtilBridge : LuaBase, ILuaActivityUtil
	{
		// Token: 0x06004340 RID: 17216 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004340")]
		[Address(RVA = "0xF27B00", Offset = "0xF26700", VA = "0x180F27B00")]
		public static LuaBase __Create(int reference, LuaEnv luaenv)
		{
			return null;
		}

		// Token: 0x06004341 RID: 17217 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004341")]
		[Address(RVA = "0x64EA20", Offset = "0x64D620", VA = "0x18064EA20")]
		public TorappuUIILuaActivityUtilBridge(int reference, LuaEnv luaenv)
		{
		}

		// Token: 0x06004342 RID: 17218 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004342")]
		[Address(RVA = "0xF27850", Offset = "0xF26450", VA = "0x180F27850", Slot = "7")]
		private void FindValidHomeActs(List<ActivityUtil.SortableActivity> validActs, List<ActivityUtil.SortableActivity> uncompleteActs, List<ActivityUtil.SortableActivity> unfinishedActs, List<ActivityUtil.SortableActivity> finishedActs)
		{
		}

		// Token: 0x06004343 RID: 17219 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004343")]
		[Address(RVA = "0xF27580", Offset = "0xF26180", VA = "0x180F27580", Slot = "8")]
		private string EnsureActivityDialogClass(LuaActClsConfig config)
		{
			return null;
		}

		// Token: 0x06004344 RID: 17220 RVA: 0x00023F28 File Offset: 0x00022128
		[Token(Token = "0x6004344")]
		[Address(RVA = "0xF272B0", Offset = "0xF25EB0", VA = "0x180F272B0", Slot = "9")]
		private bool CheckIfActivityUncomplete(ActivityType type, string actId)
		{
			return default(bool);
		}
	}
}
