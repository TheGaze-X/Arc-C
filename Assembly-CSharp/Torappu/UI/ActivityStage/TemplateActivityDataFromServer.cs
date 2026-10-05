using System;
using Il2CppDummyDll;
using Torappu.DataFromServer;
using XLua;

namespace Torappu.UI.ActivityStage
{
	// Token: 0x02006CDF RID: 27871
	[Token(Token = "0x2006CDF")]
	public abstract class TemplateActivityDataFromServer<DataType> : DataFromServer<DataType>
	{
		// Token: 0x06027C02 RID: 162818 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027C02")]
		public override string GetDataId()
		{
			return null;
		}

		// Token: 0x06027C03 RID: 162819 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027C03")]
		protected TemplateActivityDataFromServer(string activityId)
		{
		}

		// Token: 0x06027C04 RID: 162820 RVA: 0x000CF3A8 File Offset: 0x000CD5A8
		[Token(Token = "0x6027C04")]
		protected override bool OnCustomDataValidCheck(DataFromServerStorage.DataChunk chunk)
		{
			return default(bool);
		}

		// Token: 0x040385F1 RID: 230897
		[Token(Token = "0x40385F1")]
		private const string ACT_DATA_FROM_SERVER = "ACT_{0}";

		// Token: 0x040385F2 RID: 230898
		[Token(Token = "0x40385F2")]
		[FieldOffset(Offset = "0x0")]
		private string m_dataId;

		// Token: 0x040385F3 RID: 230899
		[Token(Token = "0x40385F3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetDataId;

		// Token: 0x040385F4 RID: 230900
		[Token(Token = "0x40385F4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x040385F5 RID: 230901
		[Token(Token = "0x40385F5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnCustomDataValidCheck;
	}
}
