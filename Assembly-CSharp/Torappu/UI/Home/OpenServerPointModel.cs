using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Home
{
	// Token: 0x02004B8E RID: 19342
	[Token(Token = "0x2004B8E")]
	public class OpenServerPointModel : ITrackPointModel, IHotfixable
	{
		// Token: 0x17004474 RID: 17524
		// (get) Token: 0x0601D1A3 RID: 119203 RVA: 0x000AA748 File Offset: 0x000A8948
		[Token(Token = "0x17004474")]
		public bool isShow
		{
			[Token(Token = "0x601D1A3")]
			[Address(RVA = "0x16AD220", Offset = "0x16ABE20", VA = "0x1816AD220", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0601D1A4 RID: 119204 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D1A4")]
		[Address(RVA = "0x16AD150", Offset = "0x16ABD50", VA = "0x1816AD150", Slot = "4")]
		public void UpdateState(object param)
		{
		}

		// Token: 0x0601D1A5 RID: 119205 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D1A5")]
		[Address(RVA = "0x16AD1C0", Offset = "0x16ABDC0", VA = "0x1816AD1C0")]
		public OpenServerPointModel()
		{
		}

		// Token: 0x0402631A RID: 156442
		[Token(Token = "0x402631A")]
		[FieldOffset(Offset = "0x10")]
		private bool m_isShow;

		// Token: 0x0402631B RID: 156443
		[Token(Token = "0x402631B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isShow;

		// Token: 0x0402631C RID: 156444
		[Token(Token = "0x402631C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateState;

		// Token: 0x0402631D RID: 156445
		[Token(Token = "0x402631D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
