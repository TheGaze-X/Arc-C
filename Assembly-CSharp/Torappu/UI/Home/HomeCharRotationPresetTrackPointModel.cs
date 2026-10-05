using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Home
{
	// Token: 0x02004B9B RID: 19355
	[Token(Token = "0x2004B9B")]
	public class HomeCharRotationPresetTrackPointModel : ITrackPointModel, IHotfixable
	{
		// Token: 0x17004482 RID: 17538
		// (get) Token: 0x0601D1D8 RID: 119256 RVA: 0x000AA8F8 File Offset: 0x000A8AF8
		[Token(Token = "0x17004482")]
		public bool isShow
		{
			[Token(Token = "0x601D1D8")]
			[Address(RVA = "0x169B5F0", Offset = "0x169A1F0", VA = "0x18169B5F0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0601D1D9 RID: 119257 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D1D9")]
		[Address(RVA = "0x169B4D0", Offset = "0x169A0D0", VA = "0x18169B4D0", Slot = "4")]
		public void UpdateState(object param)
		{
		}

		// Token: 0x0601D1DA RID: 119258 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D1DA")]
		[Address(RVA = "0x169B590", Offset = "0x169A190", VA = "0x18169B590")]
		public HomeCharRotationPresetTrackPointModel()
		{
		}

		// Token: 0x0402634D RID: 156493
		[Token(Token = "0x402634D")]
		[FieldOffset(Offset = "0x10")]
		private bool m_isShow;

		// Token: 0x0402634E RID: 156494
		[Token(Token = "0x402634E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isShow;

		// Token: 0x0402634F RID: 156495
		[Token(Token = "0x402634F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateState;

		// Token: 0x04026350 RID: 156496
		[Token(Token = "0x4026350")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
