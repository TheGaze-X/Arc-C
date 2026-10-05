using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act5D0
{
	// Token: 0x020071FB RID: 29179
	[Token(Token = "0x20071FB")]
	public class Act5D0MissionStateBean : MonoBehaviour, IStateBean, IHotfixable
	{
		// Token: 0x06029625 RID: 169509 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029625")]
		[Address(RVA = "0x24C2E00", Offset = "0x24C1A00", VA = "0x1824C2E00")]
		public void InitInfo()
		{
		}

		// Token: 0x06029626 RID: 169510 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029626")]
		[Address(RVA = "0x24C3460", Offset = "0x24C2060", VA = "0x1824C3460")]
		private void _InitStoneTokenCount()
		{
		}

		// Token: 0x06029627 RID: 169511 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029627")]
		[Address(RVA = "0x24C2F60", Offset = "0x24C1B60", VA = "0x1824C2F60")]
		private void _InitMissionList()
		{
		}

		// Token: 0x06029628 RID: 169512 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029628")]
		[Address(RVA = "0x24C3560", Offset = "0x24C2160", VA = "0x1824C3560")]
		public Act5D0MissionStateBean()
		{
		}

		// Token: 0x0403B1C4 RID: 242116
		[Token(Token = "0x403B1C4")]
		[FieldOffset(Offset = "0x18")]
		[NonSerialized]
		public List<Act5D0MissionViewModel> missionList;

		// Token: 0x0403B1C5 RID: 242117
		[Token(Token = "0x403B1C5")]
		[FieldOffset(Offset = "0x20")]
		[NonSerialized]
		public int curStoneToken;

		// Token: 0x0403B1C6 RID: 242118
		[Token(Token = "0x403B1C6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_InitInfo;

		// Token: 0x0403B1C7 RID: 242119
		[Token(Token = "0x403B1C7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitStoneTokenCount;

		// Token: 0x0403B1C8 RID: 242120
		[Token(Token = "0x403B1C8")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitMissionList;

		// Token: 0x0403B1C9 RID: 242121
		[Token(Token = "0x403B1C9")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
