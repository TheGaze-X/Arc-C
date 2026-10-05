using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.HotUpdate
{
	// Token: 0x02004AB8 RID: 19128
	[Token(Token = "0x2004AB8")]
	public class HotUpdatePremainViewModel : IHotfixable
	{
		// Token: 0x0601CBA2 RID: 117666 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CBA2")]
		[Address(RVA = "0x1625790", Offset = "0x1624390", VA = "0x181625790")]
		public HotUpdatePremainViewModel()
		{
		}

		// Token: 0x04025B5C RID: 154460
		[Token(Token = "0x4025B5C")]
		[FieldOffset(Offset = "0x10")]
		public PreMainState preMainState;

		// Token: 0x04025B5D RID: 154461
		[Token(Token = "0x4025B5D")]
		[FieldOffset(Offset = "0x18")]
		public HotUpdatePremainViewModel.PvInfo pvInfo;

		// Token: 0x04025B5E RID: 154462
		[Token(Token = "0x4025B5E")]
		[FieldOffset(Offset = "0x20")]
		public List<HotUpdatePremainViewModel.PicInfo> picInfo;

		// Token: 0x04025B5F RID: 154463
		[Token(Token = "0x4025B5F")]
		[FieldOffset(Offset = "0x28")]
		public int picIndex;

		// Token: 0x04025B60 RID: 154464
		[Token(Token = "0x4025B60")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004AB9 RID: 19129
		[Token(Token = "0x2004AB9")]
		public class PvInfo
		{
			// Token: 0x0601CBA3 RID: 117667 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601CBA3")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public PvInfo()
			{
			}

			// Token: 0x04025B61 RID: 154465
			[Token(Token = "0x4025B61")]
			[FieldOffset(Offset = "0x10")]
			public string currentPvPath;
		}

		// Token: 0x02004ABA RID: 19130
		[Token(Token = "0x2004ABA")]
		public class PicInfo
		{
			// Token: 0x0601CBA4 RID: 117668 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601CBA4")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public PicInfo()
			{
			}

			// Token: 0x04025B62 RID: 154466
			[Token(Token = "0x4025B62")]
			[FieldOffset(Offset = "0x10")]
			public string picId;

			// Token: 0x04025B63 RID: 154467
			[Token(Token = "0x4025B63")]
			[FieldOffset(Offset = "0x18")]
			public HotUpdateMetaPicData.PicType picType;

			// Token: 0x04025B64 RID: 154468
			[Token(Token = "0x4025B64")]
			[FieldOffset(Offset = "0x20")]
			public string logoId;

			// Token: 0x04025B65 RID: 154469
			[Token(Token = "0x4025B65")]
			[FieldOffset(Offset = "0x28")]
			public string color;

			// Token: 0x04025B66 RID: 154470
			[Token(Token = "0x4025B66")]
			[FieldOffset(Offset = "0x30")]
			public List<string> textList;
		}
	}
}
