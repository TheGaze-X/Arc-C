using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Home
{
	// Token: 0x02004B86 RID: 19334
	[Token(Token = "0x2004B86")]
	public class CheckInTrackPointModel : ITrackPointModel, IHotfixable
	{
		// Token: 0x1700446A RID: 17514
		// (get) Token: 0x0601D189 RID: 119177 RVA: 0x000AA670 File Offset: 0x000A8870
		[Token(Token = "0x1700446A")]
		public bool isShow
		{
			[Token(Token = "0x601D189")]
			[Address(RVA = "0x1699980", Offset = "0x1698580", VA = "0x181699980", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0601D18A RID: 119178 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D18A")]
		[Address(RVA = "0x16998C0", Offset = "0x16984C0", VA = "0x1816998C0", Slot = "4")]
		public void UpdateState(object param)
		{
		}

		// Token: 0x0601D18B RID: 119179 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D18B")]
		[Address(RVA = "0x1699920", Offset = "0x1698520", VA = "0x181699920")]
		public CheckInTrackPointModel()
		{
		}

		// Token: 0x040262F9 RID: 156409
		[Token(Token = "0x40262F9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isShow;

		// Token: 0x040262FA RID: 156410
		[Token(Token = "0x40262FA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateState;

		// Token: 0x040262FB RID: 156411
		[Token(Token = "0x40262FB")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
