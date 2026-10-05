using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ArtMagazine
{
	// Token: 0x02006595 RID: 26005
	[Token(Token = "0x2006595")]
	public class ArtMagazineDiyTemplateViewModel : IHotfixable
	{
		// Token: 0x06025649 RID: 153161 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025649")]
		[Address(RVA = "0x2064C70", Offset = "0x2063870", VA = "0x182064C70")]
		public void LoadData(string leafId)
		{
		}

		// Token: 0x0602564A RID: 153162 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602564A")]
		[Address(RVA = "0x20650F0", Offset = "0x2063CF0", VA = "0x1820650F0")]
		private static void _LoadItemViewModel(List<ArtMagazineDiyTemplateItemCardViewModel> target, ArtMagazineLeafElementData leafElemData, out bool isItemValid)
		{
		}

		// Token: 0x0602564B RID: 153163 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602564B")]
		[Address(RVA = "0x2065370", Offset = "0x2063F70", VA = "0x182065370")]
		public ArtMagazineDiyTemplateViewModel()
		{
		}

		// Token: 0x0403478C RID: 214924
		[Token(Token = "0x403478C")]
		[FieldOffset(Offset = "0x10")]
		public string leafId;

		// Token: 0x0403478D RID: 214925
		[Token(Token = "0x403478D")]
		[FieldOffset(Offset = "0x18")]
		public string templateId;

		// Token: 0x0403478E RID: 214926
		[Token(Token = "0x403478E")]
		[FieldOffset(Offset = "0x20")]
		public ArtMagazineLeafViewModel leafViewModel;

		// Token: 0x0403478F RID: 214927
		[Token(Token = "0x403478F")]
		[FieldOffset(Offset = "0x28")]
		public List<ArtMagazineDiyTemplateItemCardViewModel> requireItemModelList;

		// Token: 0x04034790 RID: 214928
		[Token(Token = "0x4034790")]
		[FieldOffset(Offset = "0x30")]
		public Color templateFirstSetColor;

		// Token: 0x04034791 RID: 214929
		[Token(Token = "0x4034791")]
		[FieldOffset(Offset = "0x40")]
		public bool hasSaveAnimPlayed;

		// Token: 0x04034792 RID: 214930
		[Token(Token = "0x4034792")]
		[FieldOffset(Offset = "0x44")]
		public int validItemCount;

		// Token: 0x04034793 RID: 214931
		[Token(Token = "0x4034793")]
		[FieldOffset(Offset = "0x48")]
		public int totalItemCount;

		// Token: 0x04034794 RID: 214932
		[Token(Token = "0x4034794")]
		[FieldOffset(Offset = "0x50")]
		public string typeIconId;

		// Token: 0x04034795 RID: 214933
		[Token(Token = "0x4034795")]
		[FieldOffset(Offset = "0x58")]
		public string typeEngName;

		// Token: 0x04034796 RID: 214934
		[Token(Token = "0x4034796")]
		[FieldOffset(Offset = "0x60")]
		public int enterSeqNum;

		// Token: 0x04034797 RID: 214935
		[Token(Token = "0x4034797")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04034798 RID: 214936
		[Token(Token = "0x4034798")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__LoadItemViewModel;

		// Token: 0x04034799 RID: 214937
		[Token(Token = "0x4034799")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
