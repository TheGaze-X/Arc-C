using System;
using Il2CppDummyDll;
using Torappu.DataFromServer;
using XLua;

namespace Torappu.Activity
{
	// Token: 0x02006D71 RID: 28017
	[Token(Token = "0x2006D71")]
	public class ActivityDataFromServer<DataType> : DataFromServer<DataType>
	{
		// Token: 0x06027ECB RID: 163531 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027ECB")]
		public ActivityDataFromServer(string activityId)
		{
		}

		// Token: 0x06027ECC RID: 163532 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027ECC")]
		public override string GetDataId()
		{
			return null;
		}

		// Token: 0x0403895F RID: 231775
		[Token(Token = "0x403895F")]
		private const string ACT_DATA_FROM_SERVER = "ACTIVITY_{0}";

		// Token: 0x04038960 RID: 231776
		[Token(Token = "0x4038960")]
		[FieldOffset(Offset = "0x0")]
		private string m_dataId;

		// Token: 0x04038961 RID: 231777
		[Token(Token = "0x4038961")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x04038962 RID: 231778
		[Token(Token = "0x4038962")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetDataId;
	}
}
