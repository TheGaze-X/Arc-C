using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.EnemyDuel.Service
{
	// Token: 0x02005064 RID: 20580
	[Token(Token = "0x2005064")]
	public class EnemyDuelServiceBattleInfo : IHotfixable
	{
		// Token: 0x1700473E RID: 18238
		// (get) Token: 0x0601E82F RID: 124975 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601E830 RID: 124976 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700473E")]
		public string sceneID
		{
			[Token(Token = "0x601E82F")]
			[Address(RVA = "0x1840970", Offset = "0x183F570", VA = "0x181840970")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601E830")]
			[Address(RVA = "0x1840AD0", Offset = "0x183F6D0", VA = "0x181840AD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700473F RID: 18239
		// (get) Token: 0x0601E831 RID: 124977 RVA: 0x000AEA80 File Offset: 0x000ACC80
		[Token(Token = "0x1700473F")]
		public bool valid
		{
			[Token(Token = "0x601E831")]
			[Address(RVA = "0x1840A60", Offset = "0x183F660", VA = "0x181840A60")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17004740 RID: 18240
		// (get) Token: 0x0601E832 RID: 124978 RVA: 0x000AEA98 File Offset: 0x000ACC98
		// (set) Token: 0x0601E833 RID: 124979 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004740")]
		public EnemyDuelBattleStatus status
		{
			[Token(Token = "0x601E832")]
			[Address(RVA = "0x18409D0", Offset = "0x183F5D0", VA = "0x1818409D0")]
			[CompilerGenerated]
			get
			{
				return default(EnemyDuelBattleStatus);
			}
			[Token(Token = "0x601E833")]
			[Address(RVA = "0x1840B50", Offset = "0x183F750", VA = "0x181840B50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0601E834 RID: 124980 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E834")]
		[Address(RVA = "0x1840340", Offset = "0x183EF40", VA = "0x181840340")]
		public void Fill(EnemyDuelServiceSceneJoinData data, string sceneId)
		{
		}

		// Token: 0x0601E835 RID: 124981 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E835")]
		[Address(RVA = "0x1840260", Offset = "0x183EE60", VA = "0x181840260")]
		public void FillBattleStatus(EnemyDuelBattleStatus battleStatus)
		{
		}

		// Token: 0x0601E836 RID: 124982 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E836")]
		[Address(RVA = "0x1840660", Offset = "0x183F260", VA = "0x181840660")]
		public void Reset()
		{
		}

		// Token: 0x0601E837 RID: 124983 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E837")]
		[Address(RVA = "0x1840870", Offset = "0x183F470", VA = "0x181840870")]
		public EnemyDuelServiceBattleInfo()
		{
		}

		// Token: 0x04028DCA RID: 167370
		[Token(Token = "0x4028DCA")]
		[FieldOffset(Offset = "0x10")]
		public bool started;

		// Token: 0x04028DCB RID: 167371
		[Token(Token = "0x4028DCB")]
		[FieldOffset(Offset = "0x18")]
		public string stageId;

		// Token: 0x04028DCC RID: 167372
		[Token(Token = "0x4028DCC")]
		[FieldOffset(Offset = "0x20")]
		public int randomSeed;

		// Token: 0x04028DCD RID: 167373
		[Token(Token = "0x4028DCD")]
		[FieldOffset(Offset = "0x28")]
		public List<EnemyDuelServicePlayer> players;

		// Token: 0x04028DCE RID: 167374
		[Token(Token = "0x4028DCE")]
		[FieldOffset(Offset = "0x30")]
		public List<string> npcIds;

		// Token: 0x04028DD1 RID: 167377
		[Token(Token = "0x4028DD1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_sceneID;

		// Token: 0x04028DD2 RID: 167378
		[Token(Token = "0x4028DD2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_sceneID;

		// Token: 0x04028DD3 RID: 167379
		[Token(Token = "0x4028DD3")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_valid;

		// Token: 0x04028DD4 RID: 167380
		[Token(Token = "0x4028DD4")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_status;

		// Token: 0x04028DD5 RID: 167381
		[Token(Token = "0x4028DD5")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_set_status;

		// Token: 0x04028DD6 RID: 167382
		[Token(Token = "0x4028DD6")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_Fill;

		// Token: 0x04028DD7 RID: 167383
		[Token(Token = "0x4028DD7")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_FillBattleStatus;

		// Token: 0x04028DD8 RID: 167384
		[Token(Token = "0x4028DD8")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_Reset;

		// Token: 0x04028DD9 RID: 167385
		[Token(Token = "0x4028DD9")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
