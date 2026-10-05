using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.Act38side
{
	// Token: 0x0200743A RID: 29754
	[Token(Token = "0x200743A")]
	public class Act38sideFireworkSquadPluginItemViewModel : IHotfixable, IComparable
	{
		// Token: 0x06029FD8 RID: 171992 RVA: 0x000D7238 File Offset: 0x000D5438
		[Token(Token = "0x6029FD8")]
		[Address(RVA = "0x25A6320", Offset = "0x25A4F20", VA = "0x1825A6320", Slot = "4")]
		public int CompareTo(object obj)
		{
			return 0;
		}

		// Token: 0x06029FD9 RID: 171993 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029FD9")]
		[Address(RVA = "0x25A6420", Offset = "0x25A5020", VA = "0x1825A6420")]
		public Act38sideFireworkSquadPluginItemViewModel()
		{
		}

		// Token: 0x0403C36B RID: 246635
		[Token(Token = "0x403C36B")]
		[FieldOffset(Offset = "0x10")]
		public string animalId;

		// Token: 0x0403C36C RID: 246636
		[Token(Token = "0x403C36C")]
		[FieldOffset(Offset = "0x18")]
		public string selectIconId;

		// Token: 0x0403C36D RID: 246637
		[Token(Token = "0x403C36D")]
		[FieldOffset(Offset = "0x20")]
		public string unselectIconId;

		// Token: 0x0403C36E RID: 246638
		[Token(Token = "0x403C36E")]
		[FieldOffset(Offset = "0x28")]
		public bool isUnlock;

		// Token: 0x0403C36F RID: 246639
		[Token(Token = "0x403C36F")]
		[FieldOffset(Offset = "0x30")]
		public string changedToast;

		// Token: 0x0403C370 RID: 246640
		[Token(Token = "0x403C370")]
		[FieldOffset(Offset = "0x38")]
		public int sortId;

		// Token: 0x0403C371 RID: 246641
		[Token(Token = "0x403C371")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CompareTo;

		// Token: 0x0403C372 RID: 246642
		[Token(Token = "0x403C372")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
