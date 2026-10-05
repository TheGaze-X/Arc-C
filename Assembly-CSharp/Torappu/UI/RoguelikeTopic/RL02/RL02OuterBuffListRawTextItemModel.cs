using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.RoguelikeTopic.RL02
{
	// Token: 0x0200462D RID: 17965
	[Token(Token = "0x200462D")]
	public class RL02OuterBuffListRawTextItemModel : IHotfixable
	{
		// Token: 0x0601B4B1 RID: 111793 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B4B1")]
		[Address(RVA = "0x149E5A0", Offset = "0x149D1A0", VA = "0x18149E5A0")]
		public RL02OuterBuffListRawTextItemModel()
		{
		}

		// Token: 0x040233D7 RID: 144343
		[Token(Token = "0x40233D7")]
		[FieldOffset(Offset = "0x10")]
		public string nodeId;

		// Token: 0x040233D8 RID: 144344
		[Token(Token = "0x40233D8")]
		[FieldOffset(Offset = "0x18")]
		public string desc;

		// Token: 0x040233D9 RID: 144345
		[Token(Token = "0x40233D9")]
		[FieldOffset(Offset = "0x20")]
		public bool isLocked;

		// Token: 0x040233DA RID: 144346
		[Token(Token = "0x40233DA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
