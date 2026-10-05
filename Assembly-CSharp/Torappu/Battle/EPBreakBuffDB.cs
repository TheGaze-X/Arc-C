using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.DB;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002672 RID: 9842
	[Token(Token = "0x2002672")]
	[CreateAssetMenu(fileName = "ep_breakbuff_db", menuName = "Torappu/DB/Table/EPBreakBuffTable")]
	[Serializable]
	public class EPBreakBuffDB : SimpleKVTable<EPBreakBuffData, EPBreakBuffDB>
	{
		// Token: 0x0601017F RID: 65919 RVA: 0x000623D0 File Offset: 0x000605D0
		[Token(Token = "0x601017F")]
		[Address(RVA = "0x7C30D0", Offset = "0x7C1CD0", VA = "0x1807C30D0")]
		public bool GetBreakData(ElementType elementType, out EPBreakBuffData data)
		{
			return default(bool);
		}

		// Token: 0x06010180 RID: 65920 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6010180")]
		[Address(RVA = "0x7C31C0", Offset = "0x7C1DC0", VA = "0x1807C31C0")]
		public List<EPBreakBuffData> GetDataList_Dispose()
		{
			return null;
		}

		// Token: 0x06010181 RID: 65921 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010181")]
		[Address(RVA = "0x7C33B0", Offset = "0x7C1FB0", VA = "0x1807C33B0")]
		public EPBreakBuffDB()
		{
		}

		// Token: 0x04011E6A RID: 73322
		[Token(Token = "0x4011E6A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetBreakData;

		// Token: 0x04011E6B RID: 73323
		[Token(Token = "0x4011E6B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetDataList_Dispose;

		// Token: 0x04011E6C RID: 73324
		[Token(Token = "0x4011E6C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
