using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Friend
{
	// Token: 0x02004D77 RID: 19831
	[Token(Token = "0x2004D77")]
	public class NameCardSkinListItemViewModel : IHotfixable
	{
		// Token: 0x0601DAED RID: 121581 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DAED")]
		[Address(RVA = "0x1744D10", Offset = "0x1743910", VA = "0x181744D10")]
		public void LoadDataForSkinList(string skinId)
		{
		}

		// Token: 0x0601DAEE RID: 121582 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DAEE")]
		[Address(RVA = "0x1744DE0", Offset = "0x17439E0", VA = "0x181744DE0")]
		public void LoadDataForSkinTmplList(string skinId, int skinTmpl)
		{
		}

		// Token: 0x0601DAEF RID: 121583 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DAEF")]
		[Address(RVA = "0x1744E80", Offset = "0x1743A80", VA = "0x181744E80")]
		public void UpdateData()
		{
		}

		// Token: 0x0601DAF0 RID: 121584 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DAF0")]
		[Address(RVA = "0x1744FB0", Offset = "0x1743BB0", VA = "0x181744FB0")]
		private void _LoadCommon()
		{
		}

		// Token: 0x0601DAF1 RID: 121585 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DAF1")]
		[Address(RVA = "0x17450D0", Offset = "0x1743CD0", VA = "0x1817450D0")]
		public NameCardSkinListItemViewModel()
		{
		}

		// Token: 0x0402736B RID: 160619
		[Token(Token = "0x402736B")]
		[FieldOffset(Offset = "0x10")]
		public string skinId;

		// Token: 0x0402736C RID: 160620
		[Token(Token = "0x402736C")]
		[FieldOffset(Offset = "0x18")]
		public int skinTmpl;

		// Token: 0x0402736D RID: 160621
		[Token(Token = "0x402736D")]
		[FieldOffset(Offset = "0x20")]
		public string nickName;

		// Token: 0x0402736E RID: 160622
		[Token(Token = "0x402736E")]
		[FieldOffset(Offset = "0x28")]
		public string nickNameId;

		// Token: 0x0402736F RID: 160623
		[Token(Token = "0x402736F")]
		[FieldOffset(Offset = "0x30")]
		public string uid;

		// Token: 0x04027370 RID: 160624
		[Token(Token = "0x4027370")]
		[FieldOffset(Offset = "0x38")]
		public AvatarInfo avatarInfo;

		// Token: 0x04027371 RID: 160625
		[Token(Token = "0x4027371")]
		[FieldOffset(Offset = "0x40")]
		public bool isSkinUnlock;

		// Token: 0x04027372 RID: 160626
		[Token(Token = "0x4027372")]
		[FieldOffset(Offset = "0x41")]
		public bool canChangeTmpl;

		// Token: 0x04027373 RID: 160627
		[Token(Token = "0x4027373")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadDataForSkinList;

		// Token: 0x04027374 RID: 160628
		[Token(Token = "0x4027374")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LoadDataForSkinTmplList;

		// Token: 0x04027375 RID: 160629
		[Token(Token = "0x4027375")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_UpdateData;

		// Token: 0x04027376 RID: 160630
		[Token(Token = "0x4027376")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__LoadCommon;

		// Token: 0x04027377 RID: 160631
		[Token(Token = "0x4027377")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
