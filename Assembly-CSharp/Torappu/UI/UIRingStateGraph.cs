using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI
{
	// Token: 0x020036D9 RID: 14041
	[Token(Token = "0x20036D9")]
	public class UIRingStateGraph : IHotfixable
	{
		// Token: 0x060164F8 RID: 91384 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60164F8")]
		[Address(RVA = "0xEBD700", Offset = "0xEBC300", VA = "0x180EBD700")]
		public void AddNode(string stateId, double start, double end)
		{
		}

		// Token: 0x060164F9 RID: 91385 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60164F9")]
		[Address(RVA = "0xEBD9A0", Offset = "0xEBC5A0", VA = "0x180EBD9A0")]
		public void AssignIndexes()
		{
		}

		// Token: 0x060164FA RID: 91386 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60164FA")]
		[Address(RVA = "0xEBD830", Offset = "0xEBC430", VA = "0x180EBD830")]
		public void AddTask(string stateId, UIRingStateGraph.UIRingClipTask task)
		{
		}

		// Token: 0x060164FB RID: 91387 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60164FB")]
		[Address(RVA = "0xEBDE10", Offset = "0xEBCA10", VA = "0x180EBDE10")]
		public UIRingStateGraph.UIRingStateNode GetNode(string stateId)
		{
			return null;
		}

		// Token: 0x060164FC RID: 91388 RVA: 0x000907C8 File Offset: 0x0008E9C8
		[Token(Token = "0x60164FC")]
		[Address(RVA = "0xEBDD20", Offset = "0xEBC920", VA = "0x180EBDD20")]
		public int GetNodeCountInPath(string fromStateId, string toStateId)
		{
			return 0;
		}

		// Token: 0x060164FD RID: 91389 RVA: 0x000907E0 File Offset: 0x0008E9E0
		[Token(Token = "0x60164FD")]
		[Address(RVA = "0xEBDC20", Offset = "0xEBC820", VA = "0x180EBDC20")]
		public double GetDuration(string fromStateId, string toStateId)
		{
			return 0.0;
		}

		// Token: 0x060164FE RID: 91390 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60164FE")]
		[Address(RVA = "0xEBDBA0", Offset = "0xEBC7A0", VA = "0x180EBDBA0")]
		public void Clear()
		{
		}

		// Token: 0x060164FF RID: 91391 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60164FF")]
		[Address(RVA = "0xEBDEE0", Offset = "0xEBCAE0", VA = "0x180EBDEE0")]
		public UIRingStateGraph()
		{
		}

		// Token: 0x0401AD55 RID: 109909
		[Token(Token = "0x401AD55")]
		[FieldOffset(Offset = "0x10")]
		private Dictionary<string, UIRingStateGraph.UIRingStateNode> m_nodes;

		// Token: 0x0401AD56 RID: 109910
		[Token(Token = "0x401AD56")]
		[FieldOffset(Offset = "0x18")]
		private double m_duration;

		// Token: 0x0401AD57 RID: 109911
		[Token(Token = "0x401AD57")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_AddNode;

		// Token: 0x0401AD58 RID: 109912
		[Token(Token = "0x401AD58")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_AssignIndexes;

		// Token: 0x0401AD59 RID: 109913
		[Token(Token = "0x401AD59")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_AddTask;

		// Token: 0x0401AD5A RID: 109914
		[Token(Token = "0x401AD5A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetNode;

		// Token: 0x0401AD5B RID: 109915
		[Token(Token = "0x401AD5B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetNodeCountInPath;

		// Token: 0x0401AD5C RID: 109916
		[Token(Token = "0x401AD5C")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetDuration;

		// Token: 0x0401AD5D RID: 109917
		[Token(Token = "0x401AD5D")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_Clear;

		// Token: 0x0401AD5E RID: 109918
		[Token(Token = "0x401AD5E")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020036DA RID: 14042
		[Token(Token = "0x20036DA")]
		public class UIRingClipTask
		{
			// Token: 0x06016500 RID: 91392 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6016500")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public UIRingClipTask()
			{
			}

			// Token: 0x0401AD5F RID: 109919
			[Token(Token = "0x401AD5F")]
			[FieldOffset(Offset = "0x10")]
			public bool block;

			// Token: 0x0401AD60 RID: 109920
			[Token(Token = "0x401AD60")]
			[FieldOffset(Offset = "0x18")]
			public Action taskAction;

			// Token: 0x0401AD61 RID: 109921
			[Token(Token = "0x401AD61")]
			[FieldOffset(Offset = "0x20")]
			public IEnumerator taskCoroutine;
		}

		// Token: 0x020036DB RID: 14043
		[Token(Token = "0x20036DB")]
		public class UIRingStateNode
		{
			// Token: 0x06016501 RID: 91393 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6016501")]
			[Address(RVA = "0xED4B00", Offset = "0xED3700", VA = "0x180ED4B00")]
			public UIRingStateNode()
			{
			}

			// Token: 0x0401AD62 RID: 109922
			[Token(Token = "0x401AD62")]
			[FieldOffset(Offset = "0x10")]
			public string stateId;

			// Token: 0x0401AD63 RID: 109923
			[Token(Token = "0x401AD63")]
			[FieldOffset(Offset = "0x18")]
			public double startTime;

			// Token: 0x0401AD64 RID: 109924
			[Token(Token = "0x401AD64")]
			[FieldOffset(Offset = "0x20")]
			public double endTime;

			// Token: 0x0401AD65 RID: 109925
			[Token(Token = "0x401AD65")]
			[FieldOffset(Offset = "0x28")]
			public int ringIndex;

			// Token: 0x0401AD66 RID: 109926
			[Token(Token = "0x401AD66")]
			[FieldOffset(Offset = "0x30")]
			public UIRingStateGraph.UIRingClipTask task;
		}
	}
}
