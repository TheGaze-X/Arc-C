using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006ABD RID: 27325
	[Token(Token = "0x2006ABD")]
	public class LogProxy : ActArchiveCompProxy<ArchiveLogController>
	{
		// Token: 0x17005C60 RID: 23648
		// (get) Token: 0x06027167 RID: 160103 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005C60")]
		protected override string compType
		{
			[Token(Token = "0x6027167")]
			[Address(RVA = "0x223A950", Offset = "0x2239550", VA = "0x18223A950", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x06027168 RID: 160104 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027168")]
		[Address(RVA = "0x223A340", Offset = "0x2238F40", VA = "0x18223A340", Slot = "10")]
		protected override string GetPrefabPath()
		{
			return null;
		}

		// Token: 0x06027169 RID: 160105 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027169")]
		[Address(RVA = "0x223A410", Offset = "0x2239010", VA = "0x18223A410", Slot = "9")]
		protected override void InitComp()
		{
		}

		// Token: 0x0602716A RID: 160106 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602716A")]
		[Address(RVA = "0x223A780", Offset = "0x2239380", VA = "0x18223A780")]
		private void _OnLogItemClicked(ActArchiveType type, string landmarkID)
		{
		}

		// Token: 0x0602716B RID: 160107 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602716B")]
		[Address(RVA = "0x223A8E0", Offset = "0x22394E0", VA = "0x18223A8E0")]
		public LogProxy()
		{
		}

		// Token: 0x040374D5 RID: 226517
		[Token(Token = "0x40374D5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_compType;

		// Token: 0x040374D6 RID: 226518
		[Token(Token = "0x40374D6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetPrefabPath;

		// Token: 0x040374D7 RID: 226519
		[Token(Token = "0x40374D7")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_InitComp;

		// Token: 0x040374D8 RID: 226520
		[Token(Token = "0x40374D8")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnLogItemClicked;

		// Token: 0x040374D9 RID: 226521
		[Token(Token = "0x40374D9")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
