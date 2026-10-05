using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Tuning
{
	// Token: 0x02003CAB RID: 15531
	[Token(Token = "0x2003CAB")]
	public class TuningHomeFragItemViewModel : IHotfixable, IComparable
	{
		// Token: 0x060183CD RID: 99277 RVA: 0x00099BE8 File Offset: 0x00097DE8
		[Token(Token = "0x60183CD")]
		[Address(RVA = "0x10BBAC0", Offset = "0x10BA6C0", VA = "0x1810BBAC0", Slot = "4")]
		public int CompareTo(object obj)
		{
			return 0;
		}

		// Token: 0x060183CE RID: 99278 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60183CE")]
		[Address(RVA = "0x10BBBC0", Offset = "0x10BA7C0", VA = "0x1810BBBC0")]
		public TuningHomeFragItemViewModel()
		{
		}

		// Token: 0x0401D8CA RID: 121034
		[Token(Token = "0x401D8CA")]
		[FieldOffset(Offset = "0x10")]
		public string itemId;

		// Token: 0x0401D8CB RID: 121035
		[Token(Token = "0x401D8CB")]
		[FieldOffset(Offset = "0x18")]
		public string iconId;

		// Token: 0x0401D8CC RID: 121036
		[Token(Token = "0x401D8CC")]
		[FieldOffset(Offset = "0x20")]
		public int itemCount;

		// Token: 0x0401D8CD RID: 121037
		[Token(Token = "0x401D8CD")]
		[FieldOffset(Offset = "0x24")]
		public int sortId;

		// Token: 0x0401D8CE RID: 121038
		[Token(Token = "0x401D8CE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CompareTo;

		// Token: 0x0401D8CF RID: 121039
		[Token(Token = "0x401D8CF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
