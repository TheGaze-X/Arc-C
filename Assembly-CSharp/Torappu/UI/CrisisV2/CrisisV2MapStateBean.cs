using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.CrisisV2
{
	// Token: 0x02005966 RID: 22886
	[Token(Token = "0x2005966")]
	public class CrisisV2MapStateBean : IStateBean, IHotfixable
	{
		// Token: 0x17004E56 RID: 20054
		// (get) Token: 0x060215AA RID: 136618 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004E56")]
		public CrisisV2MapProp mapProp
		{
			[Token(Token = "0x60215AA")]
			[Address(RVA = "0x1BB0DE0", Offset = "0x1BAF9E0", VA = "0x181BB0DE0")]
			get
			{
				return null;
			}
		}

		// Token: 0x060215AB RID: 136619 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60215AB")]
		[Address(RVA = "0x1BB0D40", Offset = "0x1BAF940", VA = "0x181BB0D40")]
		public CrisisV2MapStateBean()
		{
		}

		// Token: 0x0402D7C2 RID: 186306
		[Token(Token = "0x402D7C2")]
		[FieldOffset(Offset = "0x10")]
		public string targetMapId;

		// Token: 0x0402D7C3 RID: 186307
		[Token(Token = "0x402D7C3")]
		[FieldOffset(Offset = "0x18")]
		public string previewNodeIdFromMissionState;

		// Token: 0x0402D7C4 RID: 186308
		[Token(Token = "0x402D7C4")]
		[FieldOffset(Offset = "0x20")]
		public CrisisV2MapModel.ViewType targetViewTypeFromMissionState;

		// Token: 0x0402D7C5 RID: 186309
		[Token(Token = "0x402D7C5")]
		[FieldOffset(Offset = "0x28")]
		public CrisisV2MapPreviewParams previewParams;

		// Token: 0x0402D7C6 RID: 186310
		[Token(Token = "0x402D7C6")]
		[FieldOffset(Offset = "0x38")]
		private CrisisV2MapProp m_mapProp;

		// Token: 0x0402D7C7 RID: 186311
		[Token(Token = "0x402D7C7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_mapProp;

		// Token: 0x0402D7C8 RID: 186312
		[Token(Token = "0x402D7C8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
