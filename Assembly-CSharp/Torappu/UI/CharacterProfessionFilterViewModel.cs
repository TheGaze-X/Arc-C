using System;
using Il2CppDummyDll;
using Torappu.UI.TemplateCharSelect;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003508 RID: 13576
	[Token(Token = "0x2003508")]
	public class CharacterProfessionFilterViewModel : IHotfixable
	{
		// Token: 0x06015A93 RID: 88723 RVA: 0x0008D510 File Offset: 0x0008B710
		[Token(Token = "0x6015A93")]
		[Address(RVA = "0xE363E0", Offset = "0xE34FE0", VA = "0x180E363E0")]
		private bool _IsProfessionIncluded(ProfessionCategory prof)
		{
			return default(bool);
		}

		// Token: 0x06015A94 RID: 88724 RVA: 0x0008D528 File Offset: 0x0008B728
		[Token(Token = "0x6015A94")]
		[Address(RVA = "0xE36470", Offset = "0xE35070", VA = "0x180E36470")]
		private bool _IsSubProfessionIncluded(string id)
		{
			return default(bool);
		}

		// Token: 0x06015A95 RID: 88725 RVA: 0x0008D540 File Offset: 0x0008B740
		[Token(Token = "0x6015A95")]
		[Address(RVA = "0xE36060", Offset = "0xE34C60", VA = "0x180E36060")]
		public bool IsIncluded(CharacterCardViewModel viewModel)
		{
			return default(bool);
		}

		// Token: 0x06015A96 RID: 88726 RVA: 0x0008D558 File Offset: 0x0008B758
		[Token(Token = "0x6015A96")]
		public bool IsIncluded<T>(T viewModel) where T : TemplateCharSelectCardViewModel
		{
			return default(bool);
		}

		// Token: 0x06015A97 RID: 88727 RVA: 0x0008D570 File Offset: 0x0008B770
		[Token(Token = "0x6015A97")]
		[Address(RVA = "0xE36260", Offset = "0xE34E60", VA = "0x180E36260")]
		public bool IsIncluded(ProfessionCategory prof, string subProfId)
		{
			return default(bool);
		}

		// Token: 0x06015A98 RID: 88728 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015A98")]
		[Address(RVA = "0xE36500", Offset = "0xE35100", VA = "0x180E36500")]
		public CharacterProfessionFilterViewModel()
		{
		}

		// Token: 0x04019F89 RID: 106377
		[Token(Token = "0x4019F89")]
		[FieldOffset(Offset = "0x10")]
		public bool isAll;

		// Token: 0x04019F8A RID: 106378
		[Token(Token = "0x4019F8A")]
		[FieldOffset(Offset = "0x14")]
		public ProfessionCategory profession;

		// Token: 0x04019F8B RID: 106379
		[Token(Token = "0x4019F8B")]
		[FieldOffset(Offset = "0x18")]
		public string subProfessionId;

		// Token: 0x04019F8C RID: 106380
		[Token(Token = "0x4019F8C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__IsProfessionIncluded;

		// Token: 0x04019F8D RID: 106381
		[Token(Token = "0x4019F8D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__IsSubProfessionIncluded;

		// Token: 0x04019F8E RID: 106382
		[Token(Token = "0x4019F8E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_IsIncluded;

		// Token: 0x04019F8F RID: 106383
		[Token(Token = "0x4019F8F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix1_IsIncluded;

		// Token: 0x04019F90 RID: 106384
		[Token(Token = "0x4019F90")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix2_IsIncluded;

		// Token: 0x04019F91 RID: 106385
		[Token(Token = "0x4019F91")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
