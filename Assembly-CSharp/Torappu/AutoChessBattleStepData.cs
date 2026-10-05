using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.DataStream;
using Torappu.ObjectPool;
using Torappu.SocketNetwork.SvrCom;
using XLua;

namespace Torappu
{
	// Token: 0x020005F3 RID: 1523
	[Token(Token = "0x20005F3")]
	public class AutoChessBattleStepData : IStreamDeserialize, IReusable, ServerStepModeHelper.IStepData, IHotfixable
	{
		// Token: 0x060061EE RID: 25070 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60061EE")]
		[Address(RVA = "0x1DE7C90", Offset = "0x1DE6890", VA = "0x181DE7C90")]
		public AutoChessBattleStepData()
		{
		}

		// Token: 0x060061EF RID: 25071 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60061EF")]
		[Address(RVA = "0x1DE7B50", Offset = "0x1DE6750", VA = "0x181DE7B50", Slot = "4")]
		public void Read(IStreamReader from)
		{
		}

		// Token: 0x060061F0 RID: 25072 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60061F0")]
		[Address(RVA = "0x1DE79E0", Offset = "0x1DE65E0", VA = "0x181DE79E0", Slot = "5")]
		public void OnAllocate()
		{
		}

		// Token: 0x060061F1 RID: 25073 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60061F1")]
		[Address(RVA = "0x1DE7A40", Offset = "0x1DE6640", VA = "0x181DE7A40", Slot = "6")]
		public void OnRecycle()
		{
		}

		// Token: 0x060061F2 RID: 25074 RVA: 0x0002FF58 File Offset: 0x0002E158
		[Token(Token = "0x60061F2")]
		[Address(RVA = "0x1DE7980", Offset = "0x1DE6580", VA = "0x181DE7980", Slot = "7")]
		public int GetSeq()
		{
			return 0;
		}

		// Token: 0x060061F3 RID: 25075 RVA: 0x0002FF70 File Offset: 0x0002E170
		[Token(Token = "0x60061F3")]
		[Address(RVA = "0x1DE7920", Offset = "0x1DE6520", VA = "0x181DE7920", Slot = "8")]
		public int GetDuration()
		{
			return 0;
		}

		// Token: 0x04002BFF RID: 11263
		[Token(Token = "0x4002BFF")]
		[FieldOffset(Offset = "0x10")]
		public int seq;

		// Token: 0x04002C00 RID: 11264
		[Token(Token = "0x4002C00")]
		[FieldOffset(Offset = "0x14")]
		public int duration;

		// Token: 0x04002C01 RID: 11265
		[Token(Token = "0x4002C01")]
		[FieldOffset(Offset = "0x18")]
		public List<AutoChessBattleStepActionData> actions;

		// Token: 0x04002C02 RID: 11266
		[Token(Token = "0x4002C02")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x04002C03 RID: 11267
		[Token(Token = "0x4002C03")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Read;

		// Token: 0x04002C04 RID: 11268
		[Token(Token = "0x4002C04")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnAllocate;

		// Token: 0x04002C05 RID: 11269
		[Token(Token = "0x4002C05")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnRecycle;

		// Token: 0x04002C06 RID: 11270
		[Token(Token = "0x4002C06")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetSeq;

		// Token: 0x04002C07 RID: 11271
		[Token(Token = "0x4002C07")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetDuration;
	}
}
