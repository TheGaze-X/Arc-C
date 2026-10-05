using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.Act45Side
{
	// Token: 0x020072D6 RID: 29398
	[Token(Token = "0x20072D6")]
	public class Act45SideCharUnlockViewModel : IHotfixable
	{
		// Token: 0x060299BA RID: 170426 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60299BA")]
		[Address(RVA = "0x24F26B0", Offset = "0x24F12B0", VA = "0x1824F26B0")]
		public void LoadData(string actId)
		{
		}

		// Token: 0x060299BB RID: 170427 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60299BB")]
		[Address(RVA = "0x24F2CB0", Offset = "0x24F18B0", VA = "0x1824F2CB0")]
		public Act45SideCharUnlockViewModel()
		{
		}

		// Token: 0x0403B826 RID: 243750
		[Token(Token = "0x403B826")]
		[FieldOffset(Offset = "0x10")]
		public List<Act45SideCharUnlockViewModel.CharInfo> unlockChars;

		// Token: 0x0403B827 RID: 243751
		[Token(Token = "0x403B827")]
		[FieldOffset(Offset = "0x18")]
		public string charUnlockStr;

		// Token: 0x0403B828 RID: 243752
		[Token(Token = "0x403B828")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0403B829 RID: 243753
		[Token(Token = "0x403B829")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020072D7 RID: 29399
		[Token(Token = "0x20072D7")]
		public struct CharInfo
		{
			// Token: 0x0403B82A RID: 243754
			[Token(Token = "0x403B82A")]
			[FieldOffset(Offset = "0x0")]
			public int sortId;

			// Token: 0x0403B82B RID: 243755
			[Token(Token = "0x403B82B")]
			[FieldOffset(Offset = "0x8")]
			public string charName;

			// Token: 0x0403B82C RID: 243756
			[Token(Token = "0x403B82C")]
			[FieldOffset(Offset = "0x10")]
			public string frontImgId;

			// Token: 0x0403B82D RID: 243757
			[Token(Token = "0x403B82D")]
			[FieldOffset(Offset = "0x18")]
			public string backImgId;
		}
	}
}
