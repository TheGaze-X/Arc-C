using System;
using Il2CppDummyDll;
using Torappu.Setting;
using XLua;

namespace Torappu.UI
{
	// Token: 0x0200347E RID: 13438
	[Token(Token = "0x200347E")]
	public class StandaloneCanvasScaleHelper : IHotfixable
	{
		// Token: 0x0601570C RID: 87820 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601570C")]
		[Address(RVA = "0xDEC080", Offset = "0xDEAC80", VA = "0x180DEC080")]
		public void Init()
		{
		}

		// Token: 0x0601570D RID: 87821 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601570D")]
		[Address(RVA = "0xDEBEB0", Offset = "0xDEAAB0", VA = "0x180DEBEB0")]
		public void Clear()
		{
		}

		// Token: 0x0601570E RID: 87822 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601570E")]
		[Address(RVA = "0xDEC330", Offset = "0xDEAF30", VA = "0x180DEC330")]
		public static void Reset()
		{
		}

		// Token: 0x0601570F RID: 87823 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601570F")]
		[Address(RVA = "0xDEC2B0", Offset = "0xDEAEB0", VA = "0x180DEC2B0")]
		private void NotifySettingChange(SettingConstVars.SettingType settingType)
		{
		}

		// Token: 0x06015710 RID: 87824 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015710")]
		[Address(RVA = "0xDEC3B0", Offset = "0xDEAFB0", VA = "0x180DEC3B0")]
		private void _SetAllCanvasScale()
		{
		}

		// Token: 0x06015711 RID: 87825 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015711")]
		[Address(RVA = "0xDEC4C0", Offset = "0xDEB0C0", VA = "0x180DEC4C0")]
		public StandaloneCanvasScaleHelper()
		{
		}

		// Token: 0x04019AB5 RID: 105141
		[Token(Token = "0x4019AB5")]
		private const float MIN_SCALE_FACTOR = 0.9f;

		// Token: 0x04019AB6 RID: 105142
		[Token(Token = "0x4019AB6")]
		private const float MAX_SCALE_FACTOR = 1f;

		// Token: 0x04019AB7 RID: 105143
		[Token(Token = "0x4019AB7")]
		private const float DEFAULT_SCALE_FACTOR = 1f;

		// Token: 0x04019AB8 RID: 105144
		[Token(Token = "0x4019AB8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04019AB9 RID: 105145
		[Token(Token = "0x4019AB9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Clear;

		// Token: 0x04019ABA RID: 105146
		[Token(Token = "0x4019ABA")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Reset;

		// Token: 0x04019ABB RID: 105147
		[Token(Token = "0x4019ABB")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_NotifySettingChange;

		// Token: 0x04019ABC RID: 105148
		[Token(Token = "0x4019ABC")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__SetAllCanvasScale;

		// Token: 0x04019ABD RID: 105149
		[Token(Token = "0x4019ABD")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
