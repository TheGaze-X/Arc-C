using System;
using Il2CppDummyDll;
using Torappu.DB;
using UnityEngine;
using XLua;

namespace Torappu
{
	// Token: 0x020005CE RID: 1486
	[Token(Token = "0x20005CE")]
	[CreateAssetMenu(menuName = "Torappu/DB/Table/OpenServerTable")]
	[Serializable]
	public class OpenServerDB : ConstTable<OpenServerSchedule, OpenServerDB>
	{
		// Token: 0x0600615E RID: 24926 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600615E")]
		[Address(RVA = "0x1DEFB60", Offset = "0x1DEE760", VA = "0x181DEFB60")]
		public static OpenServerData GetCurrentOpenServerData()
		{
			return null;
		}

		// Token: 0x0600615F RID: 24927 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600615F")]
		[Address(RVA = "0x1DEFE10", Offset = "0x1DEEA10", VA = "0x181DEFE10")]
		public static OpenServerScheduleItem GetCurrentOpenServerGroupData()
		{
			return null;
		}

		// Token: 0x17000CCA RID: 3274
		// (get) Token: 0x06006160 RID: 24928 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CCA")]
		public static ReturnData returnData
		{
			[Token(Token = "0x6006160")]
			[Address(RVA = "0x1DF00A0", Offset = "0x1DEECA0", VA = "0x181DF00A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06006161 RID: 24929 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006161")]
		[Address(RVA = "0x1DF0030", Offset = "0x1DEEC30", VA = "0x181DF0030")]
		public OpenServerDB()
		{
		}

		// Token: 0x04002B00 RID: 11008
		[Token(Token = "0x4002B00")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCurrentOpenServerData;

		// Token: 0x04002B01 RID: 11009
		[Token(Token = "0x4002B01")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetCurrentOpenServerGroupData;

		// Token: 0x04002B02 RID: 11010
		[Token(Token = "0x4002B02")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_returnData;

		// Token: 0x04002B03 RID: 11011
		[Token(Token = "0x4002B03")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
