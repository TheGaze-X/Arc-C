using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI.CrisisV2;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x020067D7 RID: 26583
	[Token(Token = "0x20067D7")]
	public class ZoneHomeToDoGroupModel : IHotfixable
	{
		// Token: 0x060261CF RID: 156111 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60261CF")]
		[Address(RVA = "0x212FBA0", Offset = "0x212E7A0", VA = "0x18212FBA0")]
		public void LoadData(CrisisV2ServerDataWrapper crisisData)
		{
		}

		// Token: 0x060261D0 RID: 156112 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60261D0")]
		[Address(RVA = "0x212FFE0", Offset = "0x212EBE0", VA = "0x18212FFE0")]
		private void _UpdateViewIndex()
		{
		}

		// Token: 0x060261D1 RID: 156113 RVA: 0x000CA188 File Offset: 0x000C8388
		[Token(Token = "0x60261D1")]
		[Address(RVA = "0x212FE60", Offset = "0x212EA60", VA = "0x18212FE60")]
		private static int _CompareToDo(ZoneHomeToDoItemModel lhs, ZoneHomeToDoItemModel rhs)
		{
			return 0;
		}

		// Token: 0x060261D2 RID: 156114 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60261D2")]
		[Address(RVA = "0x21300A0", Offset = "0x212ECA0", VA = "0x1821300A0")]
		public ZoneHomeToDoGroupModel()
		{
		}

		// Token: 0x04035A9E RID: 219806
		[Token(Token = "0x4035A9E")]
		[FieldOffset(Offset = "0x10")]
		public List<ZoneHomeToDoItemModel> todoList;

		// Token: 0x04035A9F RID: 219807
		[Token(Token = "0x4035A9F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04035AA0 RID: 219808
		[Token(Token = "0x4035AA0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__UpdateViewIndex;

		// Token: 0x04035AA1 RID: 219809
		[Token(Token = "0x4035AA1")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__CompareToDo;

		// Token: 0x04035AA2 RID: 219810
		[Token(Token = "0x4035AA2")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
