using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Home
{
	// Token: 0x02004B8F RID: 19343
	[Token(Token = "0x2004B8F")]
	public class ReturnPointModel : ITrackPointModel, IHotfixable
	{
		// Token: 0x17004475 RID: 17525
		// (get) Token: 0x0601D1A6 RID: 119206 RVA: 0x000AA760 File Offset: 0x000A8960
		// (set) Token: 0x0601D1A7 RID: 119207 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004475")]
		public bool isShow
		{
			[Token(Token = "0x601D1A6")]
			[Address(RVA = "0x16AFA00", Offset = "0x16AE600", VA = "0x1816AFA00", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x601D1A7")]
			[Address(RVA = "0x16AFA60", Offset = "0x16AE660", VA = "0x1816AFA60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0601D1A8 RID: 119208 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D1A8")]
		[Address(RVA = "0x16AF8A0", Offset = "0x16AE4A0", VA = "0x1816AF8A0", Slot = "4")]
		public void UpdateState(object param)
		{
		}

		// Token: 0x0601D1A9 RID: 119209 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D1A9")]
		[Address(RVA = "0x16AF9A0", Offset = "0x16AE5A0", VA = "0x1816AF9A0")]
		public ReturnPointModel()
		{
		}

		// Token: 0x0402631F RID: 156447
		[Token(Token = "0x402631F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isShow;

		// Token: 0x04026320 RID: 156448
		[Token(Token = "0x4026320")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_isShow;

		// Token: 0x04026321 RID: 156449
		[Token(Token = "0x4026321")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_UpdateState;

		// Token: 0x04026322 RID: 156450
		[Token(Token = "0x4026322")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
