using System;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Activity.ActMultiV3
{
	// Token: 0x02006F7C RID: 28540
	[Token(Token = "0x2006F7C")]
	public class ActMultiV3ManualProfileModel : IHotfixable
	{
		// Token: 0x0602882C RID: 165932 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602882C")]
		[Address(RVA = "0x23C3B60", Offset = "0x23C2760", VA = "0x1823C3B60")]
		public void LoadData(string actId)
		{
		}

		// Token: 0x0602882D RID: 165933 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602882D")]
		[Address(RVA = "0x23C3F00", Offset = "0x23C2B00", VA = "0x1823C3F00")]
		public void RefreshStatus(string actId)
		{
		}

		// Token: 0x0602882E RID: 165934 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602882E")]
		[Address(RVA = "0x23C3F80", Offset = "0x23C2B80", VA = "0x1823C3F80")]
		public ActMultiV3ManualProfileModel()
		{
		}

		// Token: 0x04039AC8 RID: 236232
		[Token(Token = "0x4039AC8")]
		[FieldOffset(Offset = "0x10")]
		public string actId;

		// Token: 0x04039AC9 RID: 236233
		[Token(Token = "0x4039AC9")]
		[FieldOffset(Offset = "0x18")]
		public int completeMatchCount;

		// Token: 0x04039ACA RID: 236234
		[Token(Token = "0x4039ACA")]
		[FieldOffset(Offset = "0x1C")]
		public int assistPlayerCount;

		// Token: 0x04039ACB RID: 236235
		[Token(Token = "0x4039ACB")]
		[FieldOffset(Offset = "0x20")]
		public int praisedCount;

		// Token: 0x04039ACC RID: 236236
		[Token(Token = "0x4039ACC")]
		[FieldOffset(Offset = "0x28")]
		public string titlePrefix;

		// Token: 0x04039ACD RID: 236237
		[Token(Token = "0x4039ACD")]
		[FieldOffset(Offset = "0x30")]
		public string titleSuffix;

		// Token: 0x04039ACE RID: 236238
		[Token(Token = "0x4039ACE")]
		[FieldOffset(Offset = "0x38")]
		public string skinId;

		// Token: 0x04039ACF RID: 236239
		[Token(Token = "0x4039ACF")]
		[FieldOffset(Offset = "0x40")]
		public int skinTmpl;

		// Token: 0x04039AD0 RID: 236240
		[Token(Token = "0x4039AD0")]
		[FieldOffset(Offset = "0x48")]
		public string nickName;

		// Token: 0x04039AD1 RID: 236241
		[Token(Token = "0x4039AD1")]
		[FieldOffset(Offset = "0x50")]
		public string nickNameId;

		// Token: 0x04039AD2 RID: 236242
		[Token(Token = "0x4039AD2")]
		[FieldOffset(Offset = "0x58")]
		public int level;

		// Token: 0x04039AD3 RID: 236243
		[Token(Token = "0x4039AD3")]
		[FieldOffset(Offset = "0x60")]
		public string uid;

		// Token: 0x04039AD4 RID: 236244
		[Token(Token = "0x4039AD4")]
		[FieldOffset(Offset = "0x68")]
		public PlayerAvatarQuery avatarQuery;

		// Token: 0x04039AD5 RID: 236245
		[Token(Token = "0x4039AD5")]
		[FieldOffset(Offset = "0x80")]
		public bool hasTrackPoint;

		// Token: 0x04039AD6 RID: 236246
		[Token(Token = "0x4039AD6")]
		[FieldOffset(Offset = "0x84")]
		public int loadSeqNum;

		// Token: 0x04039AD7 RID: 236247
		[Token(Token = "0x4039AD7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04039AD8 RID: 236248
		[Token(Token = "0x4039AD8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RefreshStatus;

		// Token: 0x04039AD9 RID: 236249
		[Token(Token = "0x4039AD9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
