using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.DataStream;
using Torappu.ObjectPool;

namespace Torappu.Multiplayer
{
	// Token: 0x02001536 RID: 5430
	[Token(Token = "0x2001536")]
	public class StepData : IReusable
	{
		// Token: 0x06007C97 RID: 31895 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C97")]
		[Address(RVA = "0x284D540", Offset = "0x284C140", VA = "0x18284D540")]
		public StepData()
		{
		}

		// Token: 0x06007C98 RID: 31896 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C98")]
		[Address(RVA = "0x284D370", Offset = "0x284BF70", VA = "0x18284D370")]
		public void ReadFrom(IStreamReader from)
		{
		}

		// Token: 0x06007C99 RID: 31897 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C99")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "4")]
		public void OnAllocate()
		{
		}

		// Token: 0x06007C9A RID: 31898 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C9A")]
		[Address(RVA = "0x284D250", Offset = "0x284BE50", VA = "0x18284D250", Slot = "5")]
		public void OnRecycle()
		{
		}

		// Token: 0x04007C9C RID: 31900
		[Token(Token = "0x4007C9C")]
		[FieldOffset(Offset = "0x10")]
		public uint index;

		// Token: 0x04007C9D RID: 31901
		[Token(Token = "0x4007C9D")]
		[FieldOffset(Offset = "0x14")]
		public uint duration;

		// Token: 0x04007C9E RID: 31902
		[Token(Token = "0x4007C9E")]
		[FieldOffset(Offset = "0x18")]
		public List<PlayerOprtData> oprts;

		// Token: 0x04007C9F RID: 31903
		[Token(Token = "0x4007C9F")]
		[FieldOffset(Offset = "0x20")]
		public int checkSeq;

		// Token: 0x04007CA0 RID: 31904
		[Token(Token = "0x4007CA0")]
		[FieldOffset(Offset = "0x24")]
		public byte pause;
	}
}
