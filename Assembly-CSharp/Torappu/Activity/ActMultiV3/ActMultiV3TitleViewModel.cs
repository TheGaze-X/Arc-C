using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.ActMultiV3
{
	// Token: 0x02006F7D RID: 28541
	[Token(Token = "0x2006F7D")]
	public class ActMultiV3TitleViewModel : IHotfixable, IComparable<ActMultiV3TitleViewModel>
	{
		// Token: 0x0602882F RID: 165935 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602882F")]
		[Address(RVA = "0x23D1AF0", Offset = "0x23D06F0", VA = "0x1823D1AF0")]
		public ActMultiV3TitleViewModel(string actId, string titleId, ActMultiV3TitleData titleData, int unlockIndex = -1)
		{
		}

		// Token: 0x06028830 RID: 165936 RVA: 0x000D1EE0 File Offset: 0x000D00E0
		[Token(Token = "0x6028830")]
		[Address(RVA = "0x23D1A30", Offset = "0x23D0630", VA = "0x1823D1A30", Slot = "4")]
		public int CompareTo(ActMultiV3TitleViewModel other)
		{
			return 0;
		}

		// Token: 0x04039ADA RID: 236250
		[Token(Token = "0x4039ADA")]
		[FieldOffset(Offset = "0x10")]
		private int m_sortId;

		// Token: 0x04039ADB RID: 236251
		[Token(Token = "0x4039ADB")]
		[FieldOffset(Offset = "0x14")]
		private int m_unlockIndex;

		// Token: 0x04039ADC RID: 236252
		[Token(Token = "0x4039ADC")]
		[FieldOffset(Offset = "0x18")]
		public string actId;

		// Token: 0x04039ADD RID: 236253
		[Token(Token = "0x4039ADD")]
		[FieldOffset(Offset = "0x20")]
		public string titleId;

		// Token: 0x04039ADE RID: 236254
		[Token(Token = "0x4039ADE")]
		[FieldOffset(Offset = "0x28")]
		public string titleDesc;

		// Token: 0x04039ADF RID: 236255
		[Token(Token = "0x4039ADF")]
		[FieldOffset(Offset = "0x30")]
		public bool isBack;

		// Token: 0x04039AE0 RID: 236256
		[Token(Token = "0x4039AE0")]
		[FieldOffset(Offset = "0x31")]
		public bool isUnlocked;

		// Token: 0x04039AE1 RID: 236257
		[Token(Token = "0x4039AE1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x04039AE2 RID: 236258
		[Token(Token = "0x4039AE2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_CompareTo;
	}
}
