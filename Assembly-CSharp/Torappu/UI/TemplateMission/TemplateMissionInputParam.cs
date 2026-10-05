using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.TemplateMission
{
	// Token: 0x02003DAA RID: 15786
	[Token(Token = "0x2003DAA")]
	public class TemplateMissionInputParam : IHotfixable
	{
		// Token: 0x060188B8 RID: 100536 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60188B8")]
		[Address(RVA = "0x1112900", Offset = "0x1111500", VA = "0x181112900")]
		public TemplateMissionInputParam()
		{
		}

		// Token: 0x0401E177 RID: 123255
		[Token(Token = "0x401E177")]
		[FieldOffset(Offset = "0x10")]
		public string displayId;

		// Token: 0x0401E178 RID: 123256
		[Token(Token = "0x401E178")]
		[FieldOffset(Offset = "0x18")]
		public List<TemplateMissionGroupSource> missionGroupList;

		// Token: 0x0401E179 RID: 123257
		[Token(Token = "0x401E179")]
		[FieldOffset(Offset = "0x20")]
		public TemplateMissionLayoutType layoutType;

		// Token: 0x0401E17A RID: 123258
		[Token(Token = "0x401E17A")]
		[FieldOffset(Offset = "0x24")]
		public TemplateMissionDisplaySource source;

		// Token: 0x0401E17B RID: 123259
		[Token(Token = "0x401E17B")]
		[FieldOffset(Offset = "0x28")]
		public TemplateMissionCoinViewModel coinViewModel;

		// Token: 0x0401E17C RID: 123260
		[Token(Token = "0x401E17C")]
		[FieldOffset(Offset = "0x30")]
		public ITemplateMissionViewModelPlugin plugin;

		// Token: 0x0401E17D RID: 123261
		[Token(Token = "0x401E17D")]
		[FieldOffset(Offset = "0x38")]
		public Dictionary<string, DataBundle> missionDataBundleDict;

		// Token: 0x0401E17E RID: 123262
		[Token(Token = "0x401E17E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
