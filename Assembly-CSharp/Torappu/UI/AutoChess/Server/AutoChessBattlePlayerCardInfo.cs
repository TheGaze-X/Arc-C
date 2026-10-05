using System;
using Il2CppDummyDll;
using Torappu.DataStream;
using XLua;

namespace Torappu.UI.AutoChess.Server
{
	// Token: 0x0200641C RID: 25628
	[Token(Token = "0x200641C")]
	public class AutoChessBattlePlayerCardInfo : IStreamDeserialize, IPlayerStatus, IHotfixable
	{
		// Token: 0x06024E91 RID: 151185 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024E91")]
		[Address(RVA = "0x1FAFFD0", Offset = "0x1FAEBD0", VA = "0x181FAFFD0", Slot = "4")]
		public void Read(IStreamReader from)
		{
		}

		// Token: 0x06024E92 RID: 151186 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6024E92")]
		[Address(RVA = "0x1FAFE30", Offset = "0x1FAEA30", VA = "0x181FAFE30", Slot = "5")]
		public AvatarInfo GetAvatarInfo()
		{
			return null;
		}

		// Token: 0x06024E93 RID: 151187 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6024E93")]
		[Address(RVA = "0x1FAFF10", Offset = "0x1FAEB10", VA = "0x181FAFF10", Slot = "6")]
		public string GetSecretarySkinId()
		{
			return null;
		}

		// Token: 0x06024E94 RID: 151188 RVA: 0x000C5BF8 File Offset: 0x000C3DF8
		[Token(Token = "0x6024E94")]
		[Address(RVA = "0x1FAFF70", Offset = "0x1FAEB70", VA = "0x181FAFF70", Slot = "7")]
		public bool GetSecretarySkinSp()
		{
			return default(bool);
		}

		// Token: 0x06024E95 RID: 151189 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024E95")]
		[Address(RVA = "0x1FB0190", Offset = "0x1FAED90", VA = "0x181FB0190")]
		public AutoChessBattlePlayerCardInfo()
		{
		}

		// Token: 0x040339B6 RID: 211382
		[Token(Token = "0x40339B6")]
		[FieldOffset(Offset = "0x10")]
		public string nickName;

		// Token: 0x040339B7 RID: 211383
		[Token(Token = "0x40339B7")]
		[FieldOffset(Offset = "0x18")]
		public string nickNumber;

		// Token: 0x040339B8 RID: 211384
		[Token(Token = "0x40339B8")]
		[FieldOffset(Offset = "0x20")]
		public string avatarType;

		// Token: 0x040339B9 RID: 211385
		[Token(Token = "0x40339B9")]
		[FieldOffset(Offset = "0x28")]
		public string avatarId;

		// Token: 0x040339BA RID: 211386
		[Token(Token = "0x40339BA")]
		[FieldOffset(Offset = "0x30")]
		public string secretary;

		// Token: 0x040339BB RID: 211387
		[Token(Token = "0x40339BB")]
		[FieldOffset(Offset = "0x38")]
		public string secretarySkinId;

		// Token: 0x040339BC RID: 211388
		[Token(Token = "0x40339BC")]
		[FieldOffset(Offset = "0x40")]
		public bool secretarySkinSp;

		// Token: 0x040339BD RID: 211389
		[Token(Token = "0x40339BD")]
		[FieldOffset(Offset = "0x44")]
		public int level;

		// Token: 0x040339BE RID: 211390
		[Token(Token = "0x40339BE")]
		[FieldOffset(Offset = "0x48")]
		public string nameCardSkin;

		// Token: 0x040339BF RID: 211391
		[Token(Token = "0x40339BF")]
		[FieldOffset(Offset = "0x50")]
		public int nameCardSkinTmpl;

		// Token: 0x040339C0 RID: 211392
		[Token(Token = "0x40339C0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Read;

		// Token: 0x040339C1 RID: 211393
		[Token(Token = "0x40339C1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetAvatarInfo;

		// Token: 0x040339C2 RID: 211394
		[Token(Token = "0x40339C2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetSecretarySkinId;

		// Token: 0x040339C3 RID: 211395
		[Token(Token = "0x40339C3")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetSecretarySkinSp;

		// Token: 0x040339C4 RID: 211396
		[Token(Token = "0x40339C4")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
