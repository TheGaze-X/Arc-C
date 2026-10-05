using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Home
{
	// Token: 0x02004B55 RID: 19285
	[Token(Token = "0x2004B55")]
	public class HomeDisplayMultiFormTimeBasedProvider : HomeDisplayMultiFormRuntimeProvider
	{
		// Token: 0x0601D09F RID: 118943 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D09F")]
		[Address(RVA = "0x1671D80", Offset = "0x1670980", VA = "0x181671D80", Slot = "6")]
		protected override void _Resume()
		{
		}

		// Token: 0x0601D0A0 RID: 118944 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D0A0")]
		[Address(RVA = "0x1671CE0", Offset = "0x16708E0", VA = "0x181671CE0", Slot = "5")]
		protected override void _Pause()
		{
		}

		// Token: 0x0601D0A1 RID: 118945 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D0A1")]
		[Address(RVA = "0x1671BF0", Offset = "0x16707F0", VA = "0x181671BF0")]
		private void _OnTickTime()
		{
		}

		// Token: 0x0601D0A2 RID: 118946 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D0A2")]
		[Address(RVA = "0x1671E80", Offset = "0x1670A80", VA = "0x181671E80")]
		public HomeDisplayMultiFormTimeBasedProvider()
		{
		}

		// Token: 0x0601D0A3 RID: 118947 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D0A3")]
		[Address(RVA = "0x1670B90", Offset = "0x166F790", VA = "0x181670B90")]
		private void <>xLuaBaseProxy__Resume()
		{
		}

		// Token: 0x0601D0A4 RID: 118948 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D0A4")]
		[Address(RVA = "0x1670B30", Offset = "0x166F730", VA = "0x181670B30")]
		private void <>xLuaBaseProxy__Pause()
		{
		}

		// Token: 0x0402616B RID: 156011
		[Token(Token = "0x402616B")]
		private const int TIME_TICK_INTERVAL = 60;

		// Token: 0x0402616C RID: 156012
		[Token(Token = "0x402616C")]
		[FieldOffset(Offset = "0x58")]
		private bool canProcessTask;

		// Token: 0x0402616D RID: 156013
		[Token(Token = "0x402616D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__Resume;

		// Token: 0x0402616E RID: 156014
		[Token(Token = "0x402616E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__Pause;

		// Token: 0x0402616F RID: 156015
		[Token(Token = "0x402616F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__OnTickTime;

		// Token: 0x04026170 RID: 156016
		[Token(Token = "0x4026170")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
