using System;
using Il2CppDummyDll;
using Torappu.DataStream;
using XLua;

namespace Torappu.UI.EnemyDuel.Service
{
	// Token: 0x02005087 RID: 20615
	[Token(Token = "0x2005087")]
	public class STDuelPlayerStatus : IStreamDeserialize, IPlayerStatus, IHotfixable
	{
		// Token: 0x0601E887 RID: 125063 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E887")]
		[Address(RVA = "0x184D330", Offset = "0x184BF30", VA = "0x18184D330", Slot = "4")]
		public void Read(IStreamReader from)
		{
		}

		// Token: 0x0601E888 RID: 125064 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E888")]
		[Address(RVA = "0x184D0D0", Offset = "0x184BCD0", VA = "0x18184D0D0")]
		public void Copy(STDuelPlayerStatus from)
		{
		}

		// Token: 0x0601E889 RID: 125065 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601E889")]
		[Address(RVA = "0x184D1C0", Offset = "0x184BDC0", VA = "0x18184D1C0", Slot = "5")]
		public AvatarInfo GetAvatarInfo()
		{
			return null;
		}

		// Token: 0x0601E88A RID: 125066 RVA: 0x000AEC60 File Offset: 0x000ACE60
		[Token(Token = "0x601E88A")]
		[Address(RVA = "0x184D2D0", Offset = "0x184BED0", VA = "0x18184D2D0", Slot = "7")]
		public bool GetSecretarySkinSp()
		{
			return default(bool);
		}

		// Token: 0x0601E88B RID: 125067 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601E88B")]
		[Address(RVA = "0x184D270", Offset = "0x184BE70", VA = "0x18184D270", Slot = "6")]
		public string GetSecretarySkinId()
		{
			return null;
		}

		// Token: 0x0601E88C RID: 125068 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E88C")]
		[Address(RVA = "0x184D4E0", Offset = "0x184C0E0", VA = "0x18184D4E0")]
		public STDuelPlayerStatus()
		{
		}

		// Token: 0x04028E66 RID: 167526
		[Token(Token = "0x4028E66")]
		[FieldOffset(Offset = "0x10")]
		public string uid;

		// Token: 0x04028E67 RID: 167527
		[Token(Token = "0x4028E67")]
		[FieldOffset(Offset = "0x18")]
		public string nickName;

		// Token: 0x04028E68 RID: 167528
		[Token(Token = "0x4028E68")]
		[FieldOffset(Offset = "0x20")]
		public PlayerAvatarType avatarType;

		// Token: 0x04028E69 RID: 167529
		[Token(Token = "0x4028E69")]
		[FieldOffset(Offset = "0x28")]
		public string avatarId;

		// Token: 0x04028E6A RID: 167530
		[Token(Token = "0x4028E6A")]
		[FieldOffset(Offset = "0x30")]
		public string secretary;

		// Token: 0x04028E6B RID: 167531
		[Token(Token = "0x4028E6B")]
		[FieldOffset(Offset = "0x38")]
		public string secretarySkinId;

		// Token: 0x04028E6C RID: 167532
		[Token(Token = "0x4028E6C")]
		[FieldOffset(Offset = "0x40")]
		public bool secretarySkinSp;

		// Token: 0x04028E6D RID: 167533
		[Token(Token = "0x4028E6D")]
		[FieldOffset(Offset = "0x44")]
		public STDuelPlayerStatus.State state;

		// Token: 0x04028E6E RID: 167534
		[Token(Token = "0x4028E6E")]
		[FieldOffset(Offset = "0x48")]
		public bool connLeave;

		// Token: 0x04028E6F RID: 167535
		[Token(Token = "0x4028E6F")]
		[FieldOffset(Offset = "0x50")]
		public long joinTs;

		// Token: 0x04028E70 RID: 167536
		[Token(Token = "0x4028E70")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Read;

		// Token: 0x04028E71 RID: 167537
		[Token(Token = "0x4028E71")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Copy;

		// Token: 0x04028E72 RID: 167538
		[Token(Token = "0x4028E72")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetAvatarInfo;

		// Token: 0x04028E73 RID: 167539
		[Token(Token = "0x4028E73")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetSecretarySkinSp;

		// Token: 0x04028E74 RID: 167540
		[Token(Token = "0x4028E74")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetSecretarySkinId;

		// Token: 0x04028E75 RID: 167541
		[Token(Token = "0x4028E75")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005088 RID: 20616
		[Token(Token = "0x2005088")]
		public enum State
		{
			// Token: 0x04028E77 RID: 167543
			[Token(Token = "0x4028E77")]
			UNREADY,
			// Token: 0x04028E78 RID: 167544
			[Token(Token = "0x4028E78")]
			READY,
			// Token: 0x04028E79 RID: 167545
			[Token(Token = "0x4028E79")]
			IN_BATTE
		}
	}
}
