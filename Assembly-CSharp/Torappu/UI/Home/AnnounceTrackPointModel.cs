using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Home
{
	// Token: 0x02004B87 RID: 19335
	[Token(Token = "0x2004B87")]
	public class AnnounceTrackPointModel : ITrackPointModel, IHotfixable
	{
		// Token: 0x1700446B RID: 17515
		// (get) Token: 0x0601D18C RID: 119180 RVA: 0x000AA688 File Offset: 0x000A8888
		[Token(Token = "0x1700446B")]
		public bool isShow
		{
			[Token(Token = "0x601D18C")]
			[Address(RVA = "0x16991C0", Offset = "0x1697DC0", VA = "0x1816991C0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0601D18D RID: 119181 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D18D")]
		[Address(RVA = "0x1699100", Offset = "0x1697D00", VA = "0x181699100", Slot = "4")]
		public void UpdateState(object param)
		{
		}

		// Token: 0x0601D18E RID: 119182 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D18E")]
		[Address(RVA = "0x1699160", Offset = "0x1697D60", VA = "0x181699160")]
		public AnnounceTrackPointModel()
		{
		}

		// Token: 0x040262FC RID: 156412
		[Token(Token = "0x40262FC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isShow;

		// Token: 0x040262FD RID: 156413
		[Token(Token = "0x40262FD")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateState;

		// Token: 0x040262FE RID: 156414
		[Token(Token = "0x40262FE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
