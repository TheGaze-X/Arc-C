using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Birthday
{
	// Token: 0x020061D8 RID: 25048
	[Token(Token = "0x20061D8")]
	public class BirthdaySettingViewModel : IHotfixable
	{
		// Token: 0x06024244 RID: 148036 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024244")]
		[Address(RVA = "0x1EDD7D0", Offset = "0x1EDC3D0", VA = "0x181EDD7D0")]
		public void InitData()
		{
		}

		// Token: 0x06024245 RID: 148037 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024245")]
		[Address(RVA = "0x1EDDA20", Offset = "0x1EDC620", VA = "0x181EDDA20")]
		public BirthdaySettingViewModel()
		{
		}

		// Token: 0x04032415 RID: 205845
		[Token(Token = "0x4032415")]
		[FieldOffset(Offset = "0x10")]
		public int day;

		// Token: 0x04032416 RID: 205846
		[Token(Token = "0x4032416")]
		[FieldOffset(Offset = "0x14")]
		public int month;

		// Token: 0x04032417 RID: 205847
		[Token(Token = "0x4032417")]
		[FieldOffset(Offset = "0x18")]
		public int startDay;

		// Token: 0x04032418 RID: 205848
		[Token(Token = "0x4032418")]
		[FieldOffset(Offset = "0x1C")]
		public int startMonth;

		// Token: 0x04032419 RID: 205849
		[Token(Token = "0x4032419")]
		[FieldOffset(Offset = "0x20")]
		public string name;

		// Token: 0x0403241A RID: 205850
		[Token(Token = "0x403241A")]
		[FieldOffset(Offset = "0x28")]
		public string desc;

		// Token: 0x0403241B RID: 205851
		[Token(Token = "0x403241B")]
		[FieldOffset(Offset = "0x30")]
		public string confirmDesc;

		// Token: 0x0403241C RID: 205852
		[Token(Token = "0x403241C")]
		[FieldOffset(Offset = "0x38")]
		public string leapBirthdayConfirmDesc;

		// Token: 0x0403241D RID: 205853
		[Token(Token = "0x403241D")]
		[FieldOffset(Offset = "0x40")]
		public int leapBirthdayRewardMonth;

		// Token: 0x0403241E RID: 205854
		[Token(Token = "0x403241E")]
		[FieldOffset(Offset = "0x44")]
		public int leapBirthdayRewardDay;

		// Token: 0x0403241F RID: 205855
		[Token(Token = "0x403241F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_InitData;

		// Token: 0x04032420 RID: 205856
		[Token(Token = "0x4032420")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
