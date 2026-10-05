using System;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Activity.Act1VHalfIdle
{
	// Token: 0x02007734 RID: 30516
	[Token(Token = "0x2007734")]
	public class Act1VHalfIdleDepotCharTabViewModel : Act1VHalfIdleDepotTabViewModel
	{
		// Token: 0x0602AE05 RID: 175621 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602AE05")]
		[Address(RVA = "0x26A3720", Offset = "0x26A2320", VA = "0x1826A3720", Slot = "4")]
		public override object GetDialogInput()
		{
			return null;
		}

		// Token: 0x0602AE06 RID: 175622 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AE06")]
		[Address(RVA = "0x26A3920", Offset = "0x26A2520", VA = "0x1826A3920")]
		public Act1VHalfIdleDepotCharTabViewModel()
		{
		}

		// Token: 0x0602AE07 RID: 175623 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602AE07")]
		[Address(RVA = "0x26A37F0", Offset = "0x26A23F0", VA = "0x1826A37F0")]
		private object <>xLuaBaseProxy_GetDialogInput()
		{
			return null;
		}

		// Token: 0x0403DD00 RID: 253184
		[Token(Token = "0x403DD00")]
		[FieldOffset(Offset = "0x38")]
		public string pageName;

		// Token: 0x0403DD01 RID: 253185
		[Token(Token = "0x403DD01")]
		[FieldOffset(Offset = "0x40")]
		public CharacterSortType sortType;

		// Token: 0x0403DD02 RID: 253186
		[Token(Token = "0x403DD02")]
		[FieldOffset(Offset = "0x48")]
		public CharacterProfessionFilterParam filterParam;

		// Token: 0x0403DD03 RID: 253187
		[Token(Token = "0x403DD03")]
		[FieldOffset(Offset = "0x58")]
		public int totGachaTimes;

		// Token: 0x0403DD04 RID: 253188
		[Token(Token = "0x403DD04")]
		[FieldOffset(Offset = "0x5C")]
		public int focusCharInstId;

		// Token: 0x0403DD05 RID: 253189
		[Token(Token = "0x403DD05")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetDialogInput;

		// Token: 0x0403DD06 RID: 253190
		[Token(Token = "0x403DD06")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
