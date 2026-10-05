using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.DB;
using UnityEngine;
using XLua;

namespace Torappu
{
	// Token: 0x020005B7 RID: 1463
	[Token(Token = "0x20005B7")]
	[CreateAssetMenu(menuName = "Torappu/DB/Table/CheckInData")]
	public class CheckInDB : ConstTable<CheckInTable, CheckInDB>
	{
		// Token: 0x060060F1 RID: 24817 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60060F1")]
		[Address(RVA = "0x1CEAFD0", Offset = "0x1CE9BD0", VA = "0x181CEAFD0")]
		public static IList<ItemBundle> GetCurrentMonthlyItem(DateTime dateTime)
		{
			return null;
		}

		// Token: 0x060060F2 RID: 24818 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060F2")]
		[Address(RVA = "0x1CEB200", Offset = "0x1CE9E00", VA = "0x181CEB200")]
		public CheckInDB()
		{
		}

		// Token: 0x04002A76 RID: 10870
		[Token(Token = "0x4002A76")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCurrentMonthlyItem;

		// Token: 0x04002A77 RID: 10871
		[Token(Token = "0x4002A77")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
