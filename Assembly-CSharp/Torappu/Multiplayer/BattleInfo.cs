using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Multiplayer.Servers;

namespace Torappu.Multiplayer
{
	// Token: 0x02001531 RID: 5425
	[Token(Token = "0x2001531")]
	public class BattleInfo
	{
		// Token: 0x17000ED3 RID: 3795
		// (get) Token: 0x06007C90 RID: 31888 RVA: 0x000375A8 File Offset: 0x000357A8
		[Token(Token = "0x17000ED3")]
		public bool valid
		{
			[Token(Token = "0x6007C90")]
			[Address(RVA = "0x1FF8AF0", Offset = "0x1FF76F0", VA = "0x181FF8AF0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06007C91 RID: 31889 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C91")]
		[Address(RVA = "0x283D2A0", Offset = "0x283BEA0", VA = "0x18283D2A0")]
		public void Reset()
		{
		}

		// Token: 0x06007C92 RID: 31890 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C92")]
		[Address(RVA = "0x283CF00", Offset = "0x283BB00", VA = "0x18283CF00")]
		public void CopyFrom(BattleProtocol.SceneJoinRet ret)
		{
		}

		// Token: 0x06007C93 RID: 31891 RVA: 0x000375C0 File Offset: 0x000357C0
		[Token(Token = "0x6007C93")]
		[Address(RVA = "0x283D210", Offset = "0x283BE10", VA = "0x18283D210")]
		public BattlePlayerStatus GetLastStatus(string uid)
		{
			return BattlePlayerStatus.Normal;
		}

		// Token: 0x06007C94 RID: 31892 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C94")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public BattleInfo()
		{
		}

		// Token: 0x04007C78 RID: 31864
		[Token(Token = "0x4007C78")]
		[FieldOffset(Offset = "0x0")]
		public static BattleProtocol.GameSettleInfo? s_latestSettle;

		// Token: 0x04007C79 RID: 31865
		[Token(Token = "0x4007C79")]
		[FieldOffset(Offset = "0x10")]
		public long createTs;

		// Token: 0x04007C7A RID: 31866
		[Token(Token = "0x4007C7A")]
		[FieldOffset(Offset = "0x18")]
		public long forceEndTs;

		// Token: 0x04007C7B RID: 31867
		[Token(Token = "0x4007C7B")]
		[FieldOffset(Offset = "0x20")]
		public string actStageID;

		// Token: 0x04007C7C RID: 31868
		[Token(Token = "0x4007C7C")]
		[FieldOffset(Offset = "0x28")]
		public int randomSeed;

		// Token: 0x04007C7D RID: 31869
		[Token(Token = "0x4007C7D")]
		[FieldOffset(Offset = "0x2C")]
		public bool reverse;

		// Token: 0x04007C7E RID: 31870
		[Token(Token = "0x4007C7E")]
		[FieldOffset(Offset = "0x30")]
		public int fail;

		// Token: 0x04007C7F RID: 31871
		[Token(Token = "0x4007C7F")]
		[FieldOffset(Offset = "0x38")]
		public List<BattleProtocol.SceneJoinRet.UserInfo> players;

		// Token: 0x04007C80 RID: 31872
		[Token(Token = "0x4007C80")]
		[FieldOffset(Offset = "0x40")]
		public string sceneID;

		// Token: 0x04007C81 RID: 31873
		[Token(Token = "0x4007C81")]
		[FieldOffset(Offset = "0x48")]
		public bool started;

		// Token: 0x04007C82 RID: 31874
		[Token(Token = "0x4007C82")]
		[FieldOffset(Offset = "0x50")]
		public ListDict<string, BattlePlayerStatus> lastStatus;
	}
}
