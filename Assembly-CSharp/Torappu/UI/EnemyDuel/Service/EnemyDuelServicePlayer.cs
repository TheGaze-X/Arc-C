using System;
using Il2CppDummyDll;
using Torappu.DataStream;
using XLua;

namespace Torappu.UI.EnemyDuel.Service
{
	// Token: 0x0200508D RID: 20621
	[Token(Token = "0x200508D")]
	public class EnemyDuelServicePlayer : IStreamDeserialize, IPlayerStatus, IHotfixable
	{
		// Token: 0x0601E88F RID: 125071 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E88F")]
		[Address(RVA = "0x1845020", Offset = "0x1843C20", VA = "0x181845020", Slot = "4")]
		public void Read(IStreamReader from)
		{
		}

		// Token: 0x0601E890 RID: 125072 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601E890")]
		[Address(RVA = "0x1844EB0", Offset = "0x1843AB0", VA = "0x181844EB0", Slot = "5")]
		public AvatarInfo GetAvatarInfo()
		{
			return null;
		}

		// Token: 0x0601E891 RID: 125073 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601E891")]
		[Address(RVA = "0x1844F60", Offset = "0x1843B60", VA = "0x181844F60", Slot = "6")]
		public string GetSecretarySkinId()
		{
			return null;
		}

		// Token: 0x0601E892 RID: 125074 RVA: 0x000AEC78 File Offset: 0x000ACE78
		[Token(Token = "0x601E892")]
		[Address(RVA = "0x1844FC0", Offset = "0x1843BC0", VA = "0x181844FC0", Slot = "7")]
		public bool GetSecretarySkinSp()
		{
			return default(bool);
		}

		// Token: 0x0601E893 RID: 125075 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E893")]
		[Address(RVA = "0x18451A0", Offset = "0x1843DA0", VA = "0x1818451A0")]
		public EnemyDuelServicePlayer()
		{
		}

		// Token: 0x04028E84 RID: 167556
		[Token(Token = "0x4028E84")]
		[FieldOffset(Offset = "0x10")]
		public string uid;

		// Token: 0x04028E85 RID: 167557
		[Token(Token = "0x4028E85")]
		[FieldOffset(Offset = "0x18")]
		public string avatarId;

		// Token: 0x04028E86 RID: 167558
		[Token(Token = "0x4028E86")]
		[FieldOffset(Offset = "0x20")]
		public string nickName;

		// Token: 0x04028E87 RID: 167559
		[Token(Token = "0x4028E87")]
		[FieldOffset(Offset = "0x28")]
		public PlayerAvatarType avatarType;

		// Token: 0x04028E88 RID: 167560
		[Token(Token = "0x4028E88")]
		[FieldOffset(Offset = "0x30")]
		public string secretary;

		// Token: 0x04028E89 RID: 167561
		[Token(Token = "0x4028E89")]
		[FieldOffset(Offset = "0x38")]
		public string secretarySkinId;

		// Token: 0x04028E8A RID: 167562
		[Token(Token = "0x4028E8A")]
		[FieldOffset(Offset = "0x40")]
		public bool secretarySkinSp;

		// Token: 0x04028E8B RID: 167563
		[Token(Token = "0x4028E8B")]
		[FieldOffset(Offset = "0x41")]
		public bool haveShield;

		// Token: 0x04028E8C RID: 167564
		[Token(Token = "0x4028E8C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Read;

		// Token: 0x04028E8D RID: 167565
		[Token(Token = "0x4028E8D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetAvatarInfo;

		// Token: 0x04028E8E RID: 167566
		[Token(Token = "0x4028E8E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetSecretarySkinId;

		// Token: 0x04028E8F RID: 167567
		[Token(Token = "0x4028E8F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetSecretarySkinSp;

		// Token: 0x04028E90 RID: 167568
		[Token(Token = "0x4028E90")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
