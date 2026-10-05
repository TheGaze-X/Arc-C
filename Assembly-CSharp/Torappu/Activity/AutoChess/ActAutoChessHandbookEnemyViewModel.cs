using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI.EnemyHandBook;
using XLua;

namespace Torappu.Activity.AutoChess
{
	// Token: 0x0200710A RID: 28938
	[Token(Token = "0x200710A")]
	public class ActAutoChessHandbookEnemyViewModel : ActAutoChessHandbookItemModelBase, IComparable
	{
		// Token: 0x060291EA RID: 168426 RVA: 0x000D48C8 File Offset: 0x000D2AC8
		[Token(Token = "0x60291EA")]
		[Address(RVA = "0x2485180", Offset = "0x2483D80", VA = "0x182485180", Slot = "4")]
		public int CompareTo(object obj)
		{
			return 0;
		}

		// Token: 0x060291EB RID: 168427 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60291EB")]
		[Address(RVA = "0x24852E0", Offset = "0x2483EE0", VA = "0x1824852E0")]
		public ActAutoChessHandbookEnemyViewModel()
		{
		}

		// Token: 0x0403AB57 RID: 240471
		[Token(Token = "0x403AB57")]
		[FieldOffset(Offset = "0x20")]
		public ActAutoChessHandbookEnemyType type;

		// Token: 0x0403AB58 RID: 240472
		[Token(Token = "0x403AB58")]
		[FieldOffset(Offset = "0x28")]
		public string name;

		// Token: 0x0403AB59 RID: 240473
		[Token(Token = "0x403AB59")]
		[FieldOffset(Offset = "0x30")]
		public string iconId;

		// Token: 0x0403AB5A RID: 240474
		[Token(Token = "0x403AB5A")]
		[FieldOffset(Offset = "0x38")]
		public string desc;

		// Token: 0x0403AB5B RID: 240475
		[Token(Token = "0x403AB5B")]
		[FieldOffset(Offset = "0x40")]
		public int sortId;

		// Token: 0x0403AB5C RID: 240476
		[Token(Token = "0x403AB5C")]
		[FieldOffset(Offset = "0x48")]
		public List<EnemyHandBookEverViewModel> enemyList;

		// Token: 0x0403AB5D RID: 240477
		[Token(Token = "0x403AB5D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CompareTo;

		// Token: 0x0403AB5E RID: 240478
		[Token(Token = "0x403AB5E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
