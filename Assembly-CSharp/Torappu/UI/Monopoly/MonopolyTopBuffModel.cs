using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Monopoly
{
	// Token: 0x0200481D RID: 18461
	[Token(Token = "0x200481D")]
	public class MonopolyTopBuffModel : IHotfixable
	{
		// Token: 0x17004250 RID: 16976
		// (get) Token: 0x0601BE96 RID: 114326 RVA: 0x000A69E0 File Offset: 0x000A4BE0
		[Token(Token = "0x17004250")]
		public bool hasProg
		{
			[Token(Token = "0x601BE96")]
			[Address(RVA = "0x1548730", Offset = "0x1547330", VA = "0x181548730")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0601BE97 RID: 114327 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BE97")]
		[Address(RVA = "0x1548390", Offset = "0x1546F90", VA = "0x181548390")]
		public void LoadData(string actId)
		{
		}

		// Token: 0x0601BE98 RID: 114328 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BE98")]
		[Address(RVA = "0x1548680", Offset = "0x1547280", VA = "0x181548680")]
		public MonopolyTopBuffModel()
		{
		}

		// Token: 0x04024630 RID: 149040
		[Token(Token = "0x4024630")]
		[FieldOffset(Offset = "0x10")]
		public string buffId;

		// Token: 0x04024631 RID: 149041
		[Token(Token = "0x4024631")]
		[FieldOffset(Offset = "0x18")]
		public string buffIconId;

		// Token: 0x04024632 RID: 149042
		[Token(Token = "0x4024632")]
		[FieldOffset(Offset = "0x20")]
		public string buffName;

		// Token: 0x04024633 RID: 149043
		[Token(Token = "0x4024633")]
		[FieldOffset(Offset = "0x28")]
		public List<string> additionBuffDescList;

		// Token: 0x04024634 RID: 149044
		[Token(Token = "0x4024634")]
		[FieldOffset(Offset = "0x30")]
		public string buffDesc;

		// Token: 0x04024635 RID: 149045
		[Token(Token = "0x4024635")]
		[FieldOffset(Offset = "0x38")]
		public int progValue;

		// Token: 0x04024636 RID: 149046
		[Token(Token = "0x4024636")]
		[FieldOffset(Offset = "0x3C")]
		public int progTarget;

		// Token: 0x04024637 RID: 149047
		[Token(Token = "0x4024637")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_hasProg;

		// Token: 0x04024638 RID: 149048
		[Token(Token = "0x4024638")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04024639 RID: 149049
		[Token(Token = "0x4024639")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
