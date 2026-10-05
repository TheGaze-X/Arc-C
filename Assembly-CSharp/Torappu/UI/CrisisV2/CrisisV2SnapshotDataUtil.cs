using System;
using Il2CppDummyDll;
using Torappu.DataFromServer;
using XLua;

namespace Torappu.UI.CrisisV2
{
	// Token: 0x02005917 RID: 22807
	[Token(Token = "0x2005917")]
	public class CrisisV2SnapshotDataUtil : Singleton<CrisisV2SnapshotDataUtil>
	{
		// Token: 0x060213C0 RID: 136128 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60213C0")]
		[Address(RVA = "0x1B98430", Offset = "0x1B97030", VA = "0x181B98430")]
		private CrisisV2SnapshotDataUtil()
		{
		}

		// Token: 0x060213C1 RID: 136129 RVA: 0x000B8FF8 File Offset: 0x000B71F8
		[Token(Token = "0x60213C1")]
		[Address(RVA = "0x1B97F10", Offset = "0x1B96B10", VA = "0x181B97F10")]
		public bool RequestCrisisV2SnapshotDataIfNeeded()
		{
			return default(bool);
		}

		// Token: 0x060213C2 RID: 136130 RVA: 0x000B9010 File Offset: 0x000B7210
		[Token(Token = "0x60213C2")]
		[Address(RVA = "0x1B97E50", Offset = "0x1B96A50", VA = "0x181B97E50")]
		public ServerDataValidStatus GetServerDataValidStatus()
		{
			return default(ServerDataValidStatus);
		}

		// Token: 0x060213C3 RID: 136131 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60213C3")]
		[Address(RVA = "0x1B97DC0", Offset = "0x1B969C0", VA = "0x181B97DC0")]
		public CrisisV2SnapshotData GetCacheData()
		{
			return null;
		}

		// Token: 0x060213C4 RID: 136132 RVA: 0x000B9028 File Offset: 0x000B7228
		[Token(Token = "0x60213C4")]
		[Address(RVA = "0x1B97D40", Offset = "0x1B96940", VA = "0x181B97D40")]
		public bool CheckIfDataValid()
		{
			return default(bool);
		}

		// Token: 0x060213C5 RID: 136133 RVA: 0x000B9040 File Offset: 0x000B7240
		[Token(Token = "0x60213C5")]
		[Address(RVA = "0x1B98120", Offset = "0x1B96D20", VA = "0x181B98120")]
		private bool _RequestCrisisV2SnapshotDataIfNeeded()
		{
			return default(bool);
		}

		// Token: 0x060213C6 RID: 136134 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60213C6")]
		[Address(RVA = "0x1B97F70", Offset = "0x1B96B70", VA = "0x181B97F70")]
		private void _OnGetSnapshotProceed(CrisisV2GetSnapshotResponse response)
		{
		}

		// Token: 0x0402D42A RID: 185386
		[Token(Token = "0x402D42A")]
		[FieldOffset(Offset = "0x10")]
		private CrisisV2SnapshotDataFromServer m_dataFromServer;

		// Token: 0x0402D42B RID: 185387
		[Token(Token = "0x402D42B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0402D42C RID: 185388
		[Token(Token = "0x402D42C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RequestCrisisV2SnapshotDataIfNeeded;

		// Token: 0x0402D42D RID: 185389
		[Token(Token = "0x402D42D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetServerDataValidStatus;

		// Token: 0x0402D42E RID: 185390
		[Token(Token = "0x402D42E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetCacheData;

		// Token: 0x0402D42F RID: 185391
		[Token(Token = "0x402D42F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_CheckIfDataValid;

		// Token: 0x0402D430 RID: 185392
		[Token(Token = "0x402D430")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__RequestCrisisV2SnapshotDataIfNeeded;

		// Token: 0x0402D431 RID: 185393
		[Token(Token = "0x402D431")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__OnGetSnapshotProceed;
	}
}
