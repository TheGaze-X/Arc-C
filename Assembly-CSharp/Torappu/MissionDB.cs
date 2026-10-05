using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.DB;
using UnityEngine;
using XLua;

namespace Torappu
{
	// Token: 0x020005CC RID: 1484
	[Token(Token = "0x20005CC")]
	[CreateAssetMenu(menuName = "Torappu/DB/Table/MissionTable")]
	[Serializable]
	public class MissionDB : ConstTable<MissionTable, MissionDB>
	{
		// Token: 0x06006155 RID: 24917 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006155")]
		[Address(RVA = "0x1DEF8C0", Offset = "0x1DEE4C0", VA = "0x181DEF8C0")]
		public static string GetCurrentDailyMissionState()
		{
			return null;
		}

		// Token: 0x06006156 RID: 24918 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006156")]
		[Address(RVA = "0x1DEFA40", Offset = "0x1DEE640", VA = "0x181DEFA40")]
		public IEnumerator<MissionData> GetMissionEnumerator(string groupId)
		{
			return null;
		}

		// Token: 0x06006157 RID: 24919 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006157")]
		[Address(RVA = "0x1DEFAF0", Offset = "0x1DEE6F0", VA = "0x181DEFAF0")]
		public MissionDB()
		{
		}

		// Token: 0x04002AF7 RID: 10999
		[Token(Token = "0x4002AF7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCurrentDailyMissionState;

		// Token: 0x04002AF8 RID: 11000
		[Token(Token = "0x4002AF8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetMissionEnumerator;

		// Token: 0x04002AF9 RID: 11001
		[Token(Token = "0x4002AF9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
