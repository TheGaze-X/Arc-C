using System;
using Il2CppDummyDll;
using Torappu.DataFromServer;
using XLua;

namespace Torappu.UI.CrisisV2
{
	// Token: 0x02005916 RID: 22806
	[Token(Token = "0x2005916")]
	public class CrisisV2SnapshotDataFromServer : DataFromServer<CrisisV2SnapshotDataWrapper>
	{
		// Token: 0x060213BD RID: 136125 RVA: 0x000B8FE0 File Offset: 0x000B71E0
		[Token(Token = "0x60213BD")]
		[Address(RVA = "0x1B97BA0", Offset = "0x1B967A0", VA = "0x181B97BA0", Slot = "9")]
		protected override bool OnCustomDataValidCheck(DataFromServerStorage.DataChunk chunk)
		{
			return default(bool);
		}

		// Token: 0x060213BE RID: 136126 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60213BE")]
		[Address(RVA = "0x1B97B30", Offset = "0x1B96730", VA = "0x181B97B30", Slot = "6")]
		public override string GetDataId()
		{
			return null;
		}

		// Token: 0x060213BF RID: 136127 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60213BF")]
		[Address(RVA = "0x1B97CD0", Offset = "0x1B968D0", VA = "0x181B97CD0")]
		public CrisisV2SnapshotDataFromServer()
		{
		}

		// Token: 0x0402D426 RID: 185382
		[Token(Token = "0x402D426")]
		private const string CRISIS_V2_SNAPSHOT_DATA_ID = "CRISIS_V2_SNAPSHOT_DATA_FROM_SERVER";

		// Token: 0x0402D427 RID: 185383
		[Token(Token = "0x402D427")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnCustomDataValidCheck;

		// Token: 0x0402D428 RID: 185384
		[Token(Token = "0x402D428")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetDataId;

		// Token: 0x0402D429 RID: 185385
		[Token(Token = "0x402D429")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
