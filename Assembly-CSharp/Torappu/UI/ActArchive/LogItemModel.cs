using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006BA5 RID: 27557
	[Token(Token = "0x2006BA5")]
	public class LogItemModel : ArchiveItemModel
	{
		// Token: 0x060275A7 RID: 161191 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60275A7")]
		[Address(RVA = "0x228E1A0", Offset = "0x228CDA0", VA = "0x18228E1A0", Slot = "4")]
		public override string GetFuncId()
		{
			return null;
		}

		// Token: 0x060275A8 RID: 161192 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60275A8")]
		[Address(RVA = "0x228E140", Offset = "0x228CD40", VA = "0x18228E140", Slot = "5")]
		public override string GetDesc()
		{
			return null;
		}

		// Token: 0x060275A9 RID: 161193 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60275A9")]
		[Address(RVA = "0x228E200", Offset = "0x228CE00", VA = "0x18228E200")]
		public LogItemModel()
		{
		}

		// Token: 0x04037C15 RID: 228373
		[Token(Token = "0x4037C15")]
		[FieldOffset(Offset = "0x30")]
		public List<ActArchiveResData.LogArchiveResItemData> logItemData;

		// Token: 0x04037C16 RID: 228374
		[Token(Token = "0x4037C16")]
		[FieldOffset(Offset = "0x38")]
		public string chapterId;

		// Token: 0x04037C17 RID: 228375
		[Token(Token = "0x4037C17")]
		[FieldOffset(Offset = "0x40")]
		public string displayId;

		// Token: 0x04037C18 RID: 228376
		[Token(Token = "0x4037C18")]
		[FieldOffset(Offset = "0x48")]
		public string chapterName;

		// Token: 0x04037C19 RID: 228377
		[Token(Token = "0x4037C19")]
		[FieldOffset(Offset = "0x50")]
		public Act17sideData.ChapterIconType chapterIcon;

		// Token: 0x04037C1A RID: 228378
		[Token(Token = "0x4037C1A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetFuncId;

		// Token: 0x04037C1B RID: 228379
		[Token(Token = "0x4037C1B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetDesc;

		// Token: 0x04037C1C RID: 228380
		[Token(Token = "0x4037C1C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
