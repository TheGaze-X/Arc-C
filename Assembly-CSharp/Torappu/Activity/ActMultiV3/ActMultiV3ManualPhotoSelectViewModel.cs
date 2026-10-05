using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.ActMultiV3
{
	// Token: 0x02006F72 RID: 28530
	[Token(Token = "0x2006F72")]
	public class ActMultiV3ManualPhotoSelectViewModel : IHotfixable
	{
		// Token: 0x17005F76 RID: 24438
		// (get) Token: 0x0602880B RID: 165899 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005F76")]
		public ActMultiV3PhotoDetailViewModel selectedPhoto
		{
			[Token(Token = "0x602880B")]
			[Address(RVA = "0x23C3AF0", Offset = "0x23C26F0", VA = "0x1823C3AF0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0602880C RID: 165900 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602880C")]
		[Address(RVA = "0x23C2DD0", Offset = "0x23C19D0", VA = "0x1823C2DD0")]
		public void InitData(ActMultiV3ManualPhotoSelectStateBean.Input input)
		{
		}

		// Token: 0x0602880D RID: 165901 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602880D")]
		[Address(RVA = "0x23C3220", Offset = "0x23C1E20", VA = "0x1823C3220")]
		public void UpdateFriendStatus(Dictionary<string, string> cachedFriendStatus)
		{
		}

		// Token: 0x0602880E RID: 165902 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602880E")]
		[Address(RVA = "0x23C3010", Offset = "0x23C1C10", VA = "0x1823C3010")]
		public void SelectPhoto(int photoIdx, bool firstSelect)
		{
		}

		// Token: 0x0602880F RID: 165903 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602880F")]
		[Address(RVA = "0x23C34C0", Offset = "0x23C20C0", VA = "0x1823C34C0")]
		private void _LoadData(ActMultiV3PhotoTypeData photoTypeData)
		{
		}

		// Token: 0x06028810 RID: 165904 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028810")]
		[Address(RVA = "0x23C3380", Offset = "0x23C1F80", VA = "0x1823C3380")]
		private void _FindSelectedIdx()
		{
		}

		// Token: 0x06028811 RID: 165905 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028811")]
		[Address(RVA = "0x23C3A40", Offset = "0x23C2640", VA = "0x1823C3A40")]
		public ActMultiV3ManualPhotoSelectViewModel()
		{
		}

		// Token: 0x04039A72 RID: 236146
		[Token(Token = "0x4039A72")]
		[FieldOffset(Offset = "0x10")]
		public string actId;

		// Token: 0x04039A73 RID: 236147
		[Token(Token = "0x4039A73")]
		[FieldOffset(Offset = "0x18")]
		public string weekRewardId;

		// Token: 0x04039A74 RID: 236148
		[Token(Token = "0x4039A74")]
		[FieldOffset(Offset = "0x20")]
		public string templateId;

		// Token: 0x04039A75 RID: 236149
		[Token(Token = "0x4039A75")]
		[FieldOffset(Offset = "0x28")]
		public int selectedIdx;

		// Token: 0x04039A76 RID: 236150
		[Token(Token = "0x4039A76")]
		[FieldOffset(Offset = "0x2C")]
		public bool showDetail;

		// Token: 0x04039A77 RID: 236151
		[Token(Token = "0x4039A77")]
		[FieldOffset(Offset = "0x30")]
		public int collectionLimit;

		// Token: 0x04039A78 RID: 236152
		[Token(Token = "0x4039A78")]
		[FieldOffset(Offset = "0x34")]
		public int photoTypeIdx;

		// Token: 0x04039A79 RID: 236153
		[Token(Token = "0x4039A79")]
		[FieldOffset(Offset = "0x38")]
		public string photoTypeName;

		// Token: 0x04039A7A RID: 236154
		[Token(Token = "0x4039A7A")]
		[FieldOffset(Offset = "0x40")]
		public string photoBg;

		// Token: 0x04039A7B RID: 236155
		[Token(Token = "0x4039A7B")]
		[FieldOffset(Offset = "0x48")]
		public string photoDesc;

		// Token: 0x04039A7C RID: 236156
		[Token(Token = "0x4039A7C")]
		[FieldOffset(Offset = "0x50")]
		public string initSelectedInstId;

		// Token: 0x04039A7D RID: 236157
		[Token(Token = "0x4039A7D")]
		[FieldOffset(Offset = "0x58")]
		public bool isWeekComitted;

		// Token: 0x04039A7E RID: 236158
		[Token(Token = "0x4039A7E")]
		[FieldOffset(Offset = "0x5C")]
		public int initSeqNum;

		// Token: 0x04039A7F RID: 236159
		[Token(Token = "0x4039A7F")]
		[FieldOffset(Offset = "0x60")]
		public List<ActMultiV3PhotoDetailViewModel> photoModels;

		// Token: 0x04039A80 RID: 236160
		[Token(Token = "0x4039A80")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_selectedPhoto;

		// Token: 0x04039A81 RID: 236161
		[Token(Token = "0x4039A81")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_InitData;

		// Token: 0x04039A82 RID: 236162
		[Token(Token = "0x4039A82")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_UpdateFriendStatus;

		// Token: 0x04039A83 RID: 236163
		[Token(Token = "0x4039A83")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_SelectPhoto;

		// Token: 0x04039A84 RID: 236164
		[Token(Token = "0x4039A84")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__LoadData;

		// Token: 0x04039A85 RID: 236165
		[Token(Token = "0x4039A85")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__FindSelectedIdx;

		// Token: 0x04039A86 RID: 236166
		[Token(Token = "0x4039A86")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
