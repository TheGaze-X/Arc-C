using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.Act25side
{
	// Token: 0x02007534 RID: 30004
	[Token(Token = "0x2007534")]
	public class Act25sideMapDecorMissionViewModel : IHotfixable
	{
		// Token: 0x17006392 RID: 25490
		// (get) Token: 0x0602A459 RID: 173145 RVA: 0x000D7E80 File Offset: 0x000D6080
		[Token(Token = "0x17006392")]
		public bool isCompleted
		{
			[Token(Token = "0x602A459")]
			[Address(RVA = "0x25DF940", Offset = "0x25DE540", VA = "0x1825DF940")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0602A45A RID: 173146 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A45A")]
		[Address(RVA = "0x25DF730", Offset = "0x25DE330", VA = "0x1825DF730")]
		public void LoadData(string areaId, string missionId, PlayerActivity.PlayerAct25SideActivity.Mission playerMission, Act25SideData tableData)
		{
		}

		// Token: 0x0602A45B RID: 173147 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A45B")]
		[Address(RVA = "0x25DF8E0", Offset = "0x25DE4E0", VA = "0x1825DF8E0")]
		public Act25sideMapDecorMissionViewModel()
		{
		}

		// Token: 0x0403CC75 RID: 248949
		[Token(Token = "0x403CC75")]
		[FieldOffset(Offset = "0x10")]
		public string areaId;

		// Token: 0x0403CC76 RID: 248950
		[Token(Token = "0x403CC76")]
		[FieldOffset(Offset = "0x18")]
		public string missionId;

		// Token: 0x0403CC77 RID: 248951
		[Token(Token = "0x403CC77")]
		[FieldOffset(Offset = "0x20")]
		public string missionDesc;

		// Token: 0x0403CC78 RID: 248952
		[Token(Token = "0x403CC78")]
		[FieldOffset(Offset = "0x28")]
		public int totalProgress;

		// Token: 0x0403CC79 RID: 248953
		[Token(Token = "0x403CC79")]
		[FieldOffset(Offset = "0x2C")]
		public int currProgress;

		// Token: 0x0403CC7A RID: 248954
		[Token(Token = "0x403CC7A")]
		[FieldOffset(Offset = "0x30")]
		public PlayerActivity.PlayerAct25SideActivity.MissionState missionState;

		// Token: 0x0403CC7B RID: 248955
		[Token(Token = "0x403CC7B")]
		[FieldOffset(Offset = "0x38")]
		public string areaName;

		// Token: 0x0403CC7C RID: 248956
		[Token(Token = "0x403CC7C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isCompleted;

		// Token: 0x0403CC7D RID: 248957
		[Token(Token = "0x403CC7D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0403CC7E RID: 248958
		[Token(Token = "0x403CC7E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
