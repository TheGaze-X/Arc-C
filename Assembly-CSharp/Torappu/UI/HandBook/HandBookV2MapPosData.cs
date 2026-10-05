using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.HandBook
{
	// Token: 0x020066D6 RID: 26326
	[Token(Token = "0x20066D6")]
	[Serializable]
	public class HandBookV2MapPosData : IHotfixable
	{
		// Token: 0x06025C93 RID: 154771 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025C93")]
		[Address(RVA = "0x20C8120", Offset = "0x20C6D20", VA = "0x1820C8120")]
		public HandBookV2MapPosData()
		{
		}

		// Token: 0x04035200 RID: 217600
		[Token(Token = "0x4035200")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<string, HandBookV2GroupPosData> groupList;

		// Token: 0x04035201 RID: 217601
		[Token(Token = "0x4035201")]
		[FieldOffset(Offset = "0x18")]
		public Dictionary<string, string> forceToGroupDict;

		// Token: 0x04035202 RID: 217602
		[Token(Token = "0x4035202")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
