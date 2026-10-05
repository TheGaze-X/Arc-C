using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Monopoly
{
	// Token: 0x0200480E RID: 18446
	[Token(Token = "0x200480E")]
	public class MonopolyMissionItemViewModel : IHotfixable
	{
		// Token: 0x0601BE42 RID: 114242 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BE42")]
		[Address(RVA = "0x1543C00", Offset = "0x1542800", VA = "0x181543C00")]
		public void LoadData(PlayerActivity.PlayerAct46SideActivity.PlayerMonopolyTask playerTask)
		{
		}

		// Token: 0x0601BE43 RID: 114243 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BE43")]
		[Address(RVA = "0x1543E00", Offset = "0x1542A00", VA = "0x181543E00")]
		public MonopolyMissionItemViewModel()
		{
		}

		// Token: 0x04024594 RID: 148884
		[Token(Token = "0x4024594")]
		[FieldOffset(Offset = "0x10")]
		public string missionId;

		// Token: 0x04024595 RID: 148885
		[Token(Token = "0x4024595")]
		[FieldOffset(Offset = "0x18")]
		public int missionScore;

		// Token: 0x04024596 RID: 148886
		[Token(Token = "0x4024596")]
		[FieldOffset(Offset = "0x20")]
		public List<MonopolyMissionMaterialViewModel> missionMaterialList;

		// Token: 0x04024597 RID: 148887
		[Token(Token = "0x4024597")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04024598 RID: 148888
		[Token(Token = "0x4024598")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
