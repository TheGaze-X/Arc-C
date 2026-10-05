using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.DataStream;
using Torappu.ObjectPool;

namespace Torappu.UI.EnemyDuel.Service
{
	// Token: 0x02005092 RID: 20626
	[Token(Token = "0x2005092")]
	public class EnemyDuelServiceStepData : IStreamDeserialize, IReusable
	{
		// Token: 0x0601E89A RID: 125082 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E89A")]
		[Address(RVA = "0x1847C00", Offset = "0x1846800", VA = "0x181847C00")]
		public EnemyDuelServiceStepData()
		{
		}

		// Token: 0x0601E89B RID: 125083 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E89B")]
		[Address(RVA = "0x1847AC0", Offset = "0x18466C0", VA = "0x181847AC0", Slot = "4")]
		public void Read(IStreamReader from)
		{
		}

		// Token: 0x0601E89C RID: 125084 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E89C")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "5")]
		public void OnAllocate()
		{
		}

		// Token: 0x0601E89D RID: 125085 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E89D")]
		[Address(RVA = "0x1847970", Offset = "0x1846570", VA = "0x181847970", Slot = "6")]
		public void OnRecycle()
		{
		}

		// Token: 0x04028EA1 RID: 167585
		[Token(Token = "0x4028EA1")]
		[FieldOffset(Offset = "0x10")]
		public int index;

		// Token: 0x04028EA2 RID: 167586
		[Token(Token = "0x4028EA2")]
		[FieldOffset(Offset = "0x14")]
		public int duration;

		// Token: 0x04028EA3 RID: 167587
		[Token(Token = "0x4028EA3")]
		[FieldOffset(Offset = "0x18")]
		public List<EnemyDuelServiceAction> actions;

		// Token: 0x04028EA4 RID: 167588
		[Token(Token = "0x4028EA4")]
		[FieldOffset(Offset = "0x20")]
		public int checkSeq;

		// Token: 0x04028EA5 RID: 167589
		[Token(Token = "0x4028EA5")]
		[FieldOffset(Offset = "0x24")]
		public int round;
	}
}
