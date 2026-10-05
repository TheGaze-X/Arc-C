using System;
using System.Collections.Generic;
using System.Threading;
using Il2CppDummyDll;
using Moments.Encoder;

namespace Moments
{
	// Token: 0x020000F6 RID: 246
	[Token(Token = "0x20000F6")]
	internal sealed class Worker
	{
		// Token: 0x0600041E RID: 1054 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600041E")]
		[Address(RVA = "0x5435E70", Offset = "0x5434A70", VA = "0x185435E70")]
		internal Worker(ThreadPriority priority)
		{
		}

		// Token: 0x0600041F RID: 1055 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600041F")]
		[Address(RVA = "0x5435E10", Offset = "0x5434A10", VA = "0x185435E10")]
		internal void Start()
		{
		}

		// Token: 0x06000420 RID: 1056 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000420")]
		[Address(RVA = "0x5435CF0", Offset = "0x54348F0", VA = "0x185435CF0")]
		private void Run()
		{
		}

		// Token: 0x0400056A RID: 1386
		[Token(Token = "0x400056A")]
		[FieldOffset(Offset = "0x0")]
		private static int workerId;

		// Token: 0x0400056B RID: 1387
		[Token(Token = "0x400056B")]
		[FieldOffset(Offset = "0x10")]
		private Thread m_Thread;

		// Token: 0x0400056C RID: 1388
		[Token(Token = "0x400056C")]
		[FieldOffset(Offset = "0x18")]
		private int m_Id;

		// Token: 0x0400056D RID: 1389
		[Token(Token = "0x400056D")]
		[FieldOffset(Offset = "0x20")]
		internal List<GifFrame> m_Frames;

		// Token: 0x0400056E RID: 1390
		[Token(Token = "0x400056E")]
		[FieldOffset(Offset = "0x28")]
		internal GifEncoder m_Encoder;

		// Token: 0x0400056F RID: 1391
		[Token(Token = "0x400056F")]
		[FieldOffset(Offset = "0x30")]
		internal string m_FilePath;

		// Token: 0x04000570 RID: 1392
		[Token(Token = "0x4000570")]
		[FieldOffset(Offset = "0x38")]
		internal Action<int, string> m_OnFileSaved;

		// Token: 0x04000571 RID: 1393
		[Token(Token = "0x4000571")]
		[FieldOffset(Offset = "0x40")]
		internal Action<int, float> m_OnFileSaveProgress;
	}
}
