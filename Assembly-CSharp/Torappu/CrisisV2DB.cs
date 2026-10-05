using System;
using Il2CppDummyDll;
using Torappu.DB;
using UnityEngine;
using XLua;

namespace Torappu
{
	// Token: 0x020005BC RID: 1468
	[Token(Token = "0x20005BC")]
	[CreateAssetMenu(menuName = "Torappu/DB/Table/CrisisV2DB")]
	[Serializable]
	public class CrisisV2DB : ConstTable<CrisisV2SharedData, CrisisV2DB>
	{
		// Token: 0x06006100 RID: 24832 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006100")]
		[Address(RVA = "0x1CEC090", Offset = "0x1CEAC90", VA = "0x181CEC090")]
		public CrisisV2SeasonInfo FindSeasonInfo(string seasonId)
		{
			return null;
		}

		// Token: 0x06006101 RID: 24833 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006101")]
		[Address(RVA = "0x1CEC190", Offset = "0x1CEAD90", VA = "0x181CEC190")]
		public CrisisV2DB()
		{
		}

		// Token: 0x04002A89 RID: 10889
		[Token(Token = "0x4002A89")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_FindSeasonInfo;

		// Token: 0x04002A8A RID: 10890
		[Token(Token = "0x4002A8A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
