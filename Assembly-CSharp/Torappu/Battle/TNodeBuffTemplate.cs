using System;
using Il2CppDummyDll;
using Torappu.Battle.Action.TNodeAction;

namespace Torappu.Battle
{
	// Token: 0x02002649 RID: 9801
	[Token(Token = "0x2002649")]
	[Serializable]
	public class TNodeBuffTemplate
	{
		// Token: 0x06010059 RID: 65625 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6010059")]
		[Address(RVA = "0x784AC0", Offset = "0x7836C0", VA = "0x180784AC0")]
		public BuffTemplate ConvertToBuffTemplate()
		{
			return null;
		}

		// Token: 0x0601005A RID: 65626 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601005A")]
		[Address(RVA = "0x784B60", Offset = "0x783760", VA = "0x180784B60")]
		public BuffTemplate.EventToActionMap GetEventToActionMap()
		{
			return null;
		}

		// Token: 0x0601005B RID: 65627 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601005B")]
		[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0601005C RID: 65628 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601005C")]
		[Address(RVA = "0x7850A0", Offset = "0x783CA0", VA = "0x1807850A0")]
		public TNodeBuffTemplate()
		{
		}

		// Token: 0x04011D13 RID: 72979
		[Token(Token = "0x4011D13")]
		[FieldOffset(Offset = "0x10")]
		public string templateKey;

		// Token: 0x04011D14 RID: 72980
		[Token(Token = "0x4011D14")]
		[FieldOffset(Offset = "0x18")]
		public string effectKey;

		// Token: 0x04011D15 RID: 72981
		[Token(Token = "0x4011D15")]
		[FieldOffset(Offset = "0x20")]
		public BuffData.OnEventPriority onEventPriority;

		// Token: 0x04011D16 RID: 72982
		[Token(Token = "0x4011D16")]
		[FieldOffset(Offset = "0x28")]
		public TNodeBuffTemplate.IDToTNodeDataActionMap nodeDataActionDict;

		// Token: 0x0200264A RID: 9802
		[Token(Token = "0x200264A")]
		[Serializable]
		public class IDToNodeDataAction : TNodeDataActionKV<string>
		{
			// Token: 0x0601005D RID: 65629 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601005D")]
			[Address(RVA = "0x780040", Offset = "0x77EC40", VA = "0x180780040")]
			public IDToNodeDataAction()
			{
			}
		}

		// Token: 0x0200264B RID: 9803
		[Token(Token = "0x200264B")]
		[Serializable]
		public class IDToTNodeDataActionMap : TNodeDataActionDict<string, TNodeBuffTemplate.IDToNodeDataAction>
		{
			// Token: 0x0601005E RID: 65630 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601005E")]
			[Address(RVA = "0x780080", Offset = "0x77EC80", VA = "0x180780080")]
			public IDToTNodeDataActionMap()
			{
			}
		}
	}
}
