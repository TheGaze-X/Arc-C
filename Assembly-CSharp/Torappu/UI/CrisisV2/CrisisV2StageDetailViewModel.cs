using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.CrisisV2
{
	// Token: 0x02005985 RID: 22917
	[Token(Token = "0x2005985")]
	public class CrisisV2StageDetailViewModel : IHotfixable
	{
		// Token: 0x060216B0 RID: 136880 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60216B0")]
		[Address(RVA = "0x1BCF800", Offset = "0x1BCE400", VA = "0x181BCF800")]
		public void LoadData(string mapId)
		{
		}

		// Token: 0x060216B1 RID: 136881 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60216B1")]
		[Address(RVA = "0x1BCF9B0", Offset = "0x1BCE5B0", VA = "0x181BCF9B0")]
		public CrisisV2StageDetailViewModel()
		{
		}

		// Token: 0x0402D94C RID: 186700
		[Token(Token = "0x402D94C")]
		[FieldOffset(Offset = "0x10")]
		public string seasonId;

		// Token: 0x0402D94D RID: 186701
		[Token(Token = "0x402D94D")]
		[FieldOffset(Offset = "0x18")]
		public string mapId;

		// Token: 0x0402D94E RID: 186702
		[Token(Token = "0x402D94E")]
		[FieldOffset(Offset = "0x20")]
		public string levelId;

		// Token: 0x0402D94F RID: 186703
		[Token(Token = "0x402D94F")]
		[FieldOffset(Offset = "0x28")]
		public string stageLogoId;

		// Token: 0x0402D950 RID: 186704
		[Token(Token = "0x402D950")]
		[FieldOffset(Offset = "0x30")]
		public string stageCode;

		// Token: 0x0402D951 RID: 186705
		[Token(Token = "0x402D951")]
		[FieldOffset(Offset = "0x38")]
		public string stageName;

		// Token: 0x0402D952 RID: 186706
		[Token(Token = "0x402D952")]
		[FieldOffset(Offset = "0x40")]
		public string stageDesc;

		// Token: 0x0402D953 RID: 186707
		[Token(Token = "0x402D953")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0402D954 RID: 186708
		[Token(Token = "0x402D954")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
