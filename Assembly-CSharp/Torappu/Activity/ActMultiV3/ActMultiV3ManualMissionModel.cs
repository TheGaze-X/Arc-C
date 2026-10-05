using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.ActMultiV3
{
	// Token: 0x02006F7E RID: 28542
	[Token(Token = "0x2006F7E")]
	public class ActMultiV3ManualMissionModel : IHotfixable
	{
		// Token: 0x06028831 RID: 165937 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028831")]
		[Address(RVA = "0x23D4A70", Offset = "0x23D3670", VA = "0x1823D4A70")]
		public void InitData(string actId)
		{
		}

		// Token: 0x06028832 RID: 165938 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028832")]
		[Address(RVA = "0x23D4F00", Offset = "0x23D3B00", VA = "0x1823D4F00")]
		public void LoadData(string actId)
		{
		}

		// Token: 0x06028833 RID: 165939 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028833")]
		[Address(RVA = "0x23D5300", Offset = "0x23D3F00", VA = "0x1823D5300")]
		public ActMultiV3ManualMissionModel()
		{
		}

		// Token: 0x04039AE3 RID: 236259
		[Token(Token = "0x4039AE3")]
		[FieldOffset(Offset = "0x10")]
		public List<ActMultiV3MissionViewModel> missionModelList;

		// Token: 0x04039AE4 RID: 236260
		[Token(Token = "0x4039AE4")]
		[FieldOffset(Offset = "0x18")]
		public int completedMissionCount;

		// Token: 0x04039AE5 RID: 236261
		[Token(Token = "0x4039AE5")]
		[FieldOffset(Offset = "0x1C")]
		public bool hasUnconfirmedMission;

		// Token: 0x04039AE6 RID: 236262
		[Token(Token = "0x4039AE6")]
		[FieldOffset(Offset = "0x20")]
		public int loadSeqNum;

		// Token: 0x04039AE7 RID: 236263
		[Token(Token = "0x4039AE7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_InitData;

		// Token: 0x04039AE8 RID: 236264
		[Token(Token = "0x4039AE8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04039AE9 RID: 236265
		[Token(Token = "0x4039AE9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
