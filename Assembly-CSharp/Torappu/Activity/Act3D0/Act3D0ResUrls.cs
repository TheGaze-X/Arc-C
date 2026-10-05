using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.Act3D0
{
	// Token: 0x020073E8 RID: 29672
	[Token(Token = "0x20073E8")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class Act3D0ResUrls
	{
		// Token: 0x06029E93 RID: 171667 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029E93")]
		[Address(RVA = "0x2590F20", Offset = "0x258FB20", VA = "0x182590F20")]
		public static string GetPanelCampSelectPath(string activityId)
		{
			return null;
		}

		// Token: 0x06029E94 RID: 171668 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029E94")]
		[Address(RVA = "0x2590EA0", Offset = "0x258FAA0", VA = "0x182590EA0")]
		public static string GetCampResPath(string faction, string activityId)
		{
			return null;
		}

		// Token: 0x0403C102 RID: 246018
		[Token(Token = "0x403C102")]
		private const string PANEL_CAMP_SELECT_PATH = "Activity/[UC]{0}/Prefabs/{0}_camp_select";

		// Token: 0x0403C103 RID: 246019
		[Token(Token = "0x403C103")]
		private const string PANEL_CAMP_RES_PATH = "Activity/[UC]{1}/Camp/{0}";

		// Token: 0x0403C104 RID: 246020
		[Token(Token = "0x403C104")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetPanelCampSelectPath;

		// Token: 0x0403C105 RID: 246021
		[Token(Token = "0x403C105")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetCampResPath;
	}
}
