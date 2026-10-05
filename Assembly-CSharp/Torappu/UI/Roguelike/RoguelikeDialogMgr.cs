using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x0200521D RID: 21021
	[Token(Token = "0x200521D")]
	public abstract class RoguelikeDialogMgr : IHotfixable
	{
		// Token: 0x0601F046 RID: 127046
		[Token(Token = "0x601F046")]
		public abstract IEnumerator OnShowDialog(UICompDialogMgr compDialogMgr, string topicId);

		// Token: 0x0601F047 RID: 127047
		[Token(Token = "0x601F047")]
		public abstract bool OnCheckNeedShowDialog(string topicId, List<SortableString> sortableList);

		// Token: 0x0601F048 RID: 127048 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F048")]
		[Address(RVA = "0x18B18D0", Offset = "0x18B04D0", VA = "0x1818B18D0")]
		protected RoguelikeDialogMgr()
		{
		}

		// Token: 0x040299BF RID: 170431
		[Token(Token = "0x40299BF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
