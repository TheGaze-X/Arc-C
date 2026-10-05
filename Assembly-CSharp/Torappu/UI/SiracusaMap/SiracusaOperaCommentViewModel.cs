using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.SiracusaMap
{
	// Token: 0x02003F4B RID: 16203
	[Token(Token = "0x2003F4B")]
	public class SiracusaOperaCommentViewModel : IHotfixable
	{
		// Token: 0x06019275 RID: 103029 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019275")]
		[Address(RVA = "0x11DA0A0", Offset = "0x11D8CA0", VA = "0x1811DA0A0")]
		public void LoadData(string operaId)
		{
		}

		// Token: 0x06019276 RID: 103030 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019276")]
		[Address(RVA = "0x11DA880", Offset = "0x11D9480", VA = "0x1811DA880")]
		private void _GenerateGroups()
		{
		}

		// Token: 0x06019277 RID: 103031 RVA: 0x0009D1D0 File Offset: 0x0009B3D0
		[Token(Token = "0x6019277")]
		[Address(RVA = "0x11DAB00", Offset = "0x11D9700", VA = "0x1811DAB00")]
		private TimeSpan _GetHoursToNextCrossDay()
		{
			return default(TimeSpan);
		}

		// Token: 0x06019278 RID: 103032 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019278")]
		[Address(RVA = "0x11DABD0", Offset = "0x11D97D0", VA = "0x1811DABD0")]
		public SiracusaOperaCommentViewModel()
		{
		}

		// Token: 0x0401F2D7 RID: 127703
		[Token(Token = "0x401F2D7")]
		[FieldOffset(Offset = "0x10")]
		public List<SiracusaOperaCommentItemViewModel> commentItems;

		// Token: 0x0401F2D8 RID: 127704
		[Token(Token = "0x401F2D8")]
		[FieldOffset(Offset = "0x18")]
		public List<List<SiracusaOperaCommentItemViewModel>> commentGroups;

		// Token: 0x0401F2D9 RID: 127705
		[Token(Token = "0x401F2D9")]
		[FieldOffset(Offset = "0x20")]
		public string operaId;

		// Token: 0x0401F2DA RID: 127706
		[Token(Token = "0x401F2DA")]
		[FieldOffset(Offset = "0x28")]
		public string operaName;

		// Token: 0x0401F2DB RID: 127707
		[Token(Token = "0x401F2DB")]
		[FieldOffset(Offset = "0x30")]
		public string operaSubName;

		// Token: 0x0401F2DC RID: 127708
		[Token(Token = "0x401F2DC")]
		[FieldOffset(Offset = "0x38")]
		public string score;

		// Token: 0x0401F2DD RID: 127709
		[Token(Token = "0x401F2DD")]
		[FieldOffset(Offset = "0x40")]
		public string selectedCommentId;

		// Token: 0x0401F2DE RID: 127710
		[Token(Token = "0x401F2DE")]
		[FieldOffset(Offset = "0x48")]
		public int leftLike;

		// Token: 0x0401F2DF RID: 127711
		[Token(Token = "0x401F2DF")]
		[FieldOffset(Offset = "0x4C")]
		public int totalLike;

		// Token: 0x0401F2E0 RID: 127712
		[Token(Token = "0x401F2E0")]
		[FieldOffset(Offset = "0x50")]
		public string leftTimeNum;

		// Token: 0x0401F2E1 RID: 127713
		[Token(Token = "0x401F2E1")]
		[FieldOffset(Offset = "0x58")]
		public string leftTimeUnit;

		// Token: 0x0401F2E2 RID: 127714
		[Token(Token = "0x401F2E2")]
		[FieldOffset(Offset = "0x60")]
		public bool isAllRelease;

		// Token: 0x0401F2E3 RID: 127715
		[Token(Token = "0x401F2E3")]
		[FieldOffset(Offset = "0x61")]
		public bool isInit;

		// Token: 0x0401F2E4 RID: 127716
		[Token(Token = "0x401F2E4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0401F2E5 RID: 127717
		[Token(Token = "0x401F2E5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__GenerateGroups;

		// Token: 0x0401F2E6 RID: 127718
		[Token(Token = "0x401F2E6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__GetHoursToNextCrossDay;

		// Token: 0x0401F2E7 RID: 127719
		[Token(Token = "0x401F2E7")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
