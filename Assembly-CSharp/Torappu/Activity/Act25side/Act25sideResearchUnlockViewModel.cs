using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.Act25side
{
	// Token: 0x02007529 RID: 29993
	[Token(Token = "0x2007529")]
	public class Act25sideResearchUnlockViewModel : IHotfixable
	{
		// Token: 0x0602A423 RID: 173091 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A423")]
		[Address(RVA = "0x25EA020", Offset = "0x25E8C20", VA = "0x1825EA020")]
		public void LoadData(string actId, string missionId)
		{
		}

		// Token: 0x0602A424 RID: 173092 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A424")]
		[Address(RVA = "0x25EA3E0", Offset = "0x25E8FE0", VA = "0x1825EA3E0")]
		public Act25sideResearchUnlockViewModel()
		{
		}

		// Token: 0x0403CC11 RID: 248849
		[Token(Token = "0x403CC11")]
		[FieldOffset(Offset = "0x10")]
		public List<string> unlockDesc;

		// Token: 0x0403CC12 RID: 248850
		[Token(Token = "0x403CC12")]
		[FieldOffset(Offset = "0x18")]
		public ListDict<string, int> unlockPic;

		// Token: 0x0403CC13 RID: 248851
		[Token(Token = "0x403CC13")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0403CC14 RID: 248852
		[Token(Token = "0x403CC14")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
