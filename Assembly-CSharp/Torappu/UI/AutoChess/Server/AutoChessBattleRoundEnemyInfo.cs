using System;
using Il2CppDummyDll;
using Torappu.DataStream;
using XLua;

namespace Torappu.UI.AutoChess.Server
{
	// Token: 0x0200641D RID: 25629
	[Token(Token = "0x200641D")]
	public class AutoChessBattleRoundEnemyInfo : IStreamDeserialize, IStreamSerialize, IHotfixable
	{
		// Token: 0x06024E96 RID: 151190 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024E96")]
		[Address(RVA = "0x1FB0970", Offset = "0x1FAF570", VA = "0x181FB0970", Slot = "4")]
		public void Read(IStreamReader from)
		{
		}

		// Token: 0x06024E97 RID: 151191 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024E97")]
		[Address(RVA = "0x1FB0A80", Offset = "0x1FAF680", VA = "0x181FB0A80", Slot = "5")]
		public void Write(IStreamWriter to)
		{
		}

		// Token: 0x06024E98 RID: 151192 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024E98")]
		[Address(RVA = "0x1FB0B80", Offset = "0x1FAF780", VA = "0x181FB0B80")]
		public AutoChessBattleRoundEnemyInfo()
		{
		}

		// Token: 0x040339C5 RID: 211397
		[Token(Token = "0x40339C5")]
		[FieldOffset(Offset = "0x10")]
		public int enemyType;

		// Token: 0x040339C6 RID: 211398
		[Token(Token = "0x40339C6")]
		[FieldOffset(Offset = "0x18")]
		public string enemyKey;

		// Token: 0x040339C7 RID: 211399
		[Token(Token = "0x40339C7")]
		[FieldOffset(Offset = "0x20")]
		public int actionIndex;

		// Token: 0x040339C8 RID: 211400
		[Token(Token = "0x40339C8")]
		[FieldOffset(Offset = "0x24")]
		public int count;

		// Token: 0x040339C9 RID: 211401
		[Token(Token = "0x40339C9")]
		[FieldOffset(Offset = "0x28")]
		public int round;

		// Token: 0x040339CA RID: 211402
		[Token(Token = "0x40339CA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Read;

		// Token: 0x040339CB RID: 211403
		[Token(Token = "0x40339CB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Write;

		// Token: 0x040339CC RID: 211404
		[Token(Token = "0x40339CC")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
