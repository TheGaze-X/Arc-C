using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Medal
{
	// Token: 0x0200491D RID: 18717
	[Token(Token = "0x200491D")]
	public class DIYMedalModel : IHotfixable
	{
		// Token: 0x0601C382 RID: 115586 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C382")]
		[Address(RVA = "0x15ABC80", Offset = "0x15AA880", VA = "0x1815ABC80")]
		public void LoadData(MedalPerData data)
		{
		}

		// Token: 0x0601C383 RID: 115587 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C383")]
		[Address(RVA = "0x15ABD50", Offset = "0x15AA950", VA = "0x1815ABD50")]
		public DIYMedalModel()
		{
		}

		// Token: 0x04024E84 RID: 151172
		[Token(Token = "0x4024E84")]
		[FieldOffset(Offset = "0x10")]
		public string id;

		// Token: 0x04024E85 RID: 151173
		[Token(Token = "0x4024E85")]
		[FieldOffset(Offset = "0x18")]
		public string name;

		// Token: 0x04024E86 RID: 151174
		[Token(Token = "0x4024E86")]
		[FieldOffset(Offset = "0x20")]
		public MedalSize size;

		// Token: 0x04024E87 RID: 151175
		[Token(Token = "0x4024E87")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04024E88 RID: 151176
		[Token(Token = "0x4024E88")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
