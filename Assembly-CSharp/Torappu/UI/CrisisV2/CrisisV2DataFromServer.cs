using System;
using Il2CppDummyDll;
using Torappu.DataFromServer;
using XLua;

namespace Torappu.UI.CrisisV2
{
	// Token: 0x02005907 RID: 22791
	[Token(Token = "0x2005907")]
	public class CrisisV2DataFromServer : DataFromServer<CrisisV2ServerDataWrapper>
	{
		// Token: 0x06021363 RID: 136035 RVA: 0x000B8E90 File Offset: 0x000B7090
		[Token(Token = "0x6021363")]
		[Address(RVA = "0x1B8DBC0", Offset = "0x1B8C7C0", VA = "0x181B8DBC0", Slot = "9")]
		protected override bool OnCustomDataValidCheck(DataFromServerStorage.DataChunk chunk)
		{
			return default(bool);
		}

		// Token: 0x06021364 RID: 136036 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6021364")]
		[Address(RVA = "0x1B8DB50", Offset = "0x1B8C750", VA = "0x181B8DB50", Slot = "6")]
		public override string GetDataId()
		{
			return null;
		}

		// Token: 0x06021365 RID: 136037 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021365")]
		[Address(RVA = "0x1B8DD50", Offset = "0x1B8C950", VA = "0x181B8DD50")]
		public CrisisV2DataFromServer()
		{
		}

		// Token: 0x0402D3CF RID: 185295
		[Token(Token = "0x402D3CF")]
		private const string CRISIS_V2_DATA_ID = "CRISIS_V2_DATA_FROM_SERVER";

		// Token: 0x0402D3D0 RID: 185296
		[Token(Token = "0x402D3D0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnCustomDataValidCheck;

		// Token: 0x0402D3D1 RID: 185297
		[Token(Token = "0x402D3D1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetDataId;

		// Token: 0x0402D3D2 RID: 185298
		[Token(Token = "0x402D3D2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
