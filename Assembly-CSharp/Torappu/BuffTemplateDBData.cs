using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle;
using XLua;

namespace Torappu
{
	// Token: 0x02000EDD RID: 3805
	[Token(Token = "0x2000EDD")]
	[Serializable]
	public class BuffTemplateDBData : IHotfixable
	{
		// Token: 0x06006BF6 RID: 27638 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006BF6")]
		[Address(RVA = "0x2006910", Offset = "0x2005510", VA = "0x182006910", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06006BF7 RID: 27639 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006BF7")]
		[Address(RVA = "0x2006970", Offset = "0x2005570", VA = "0x182006970")]
		public BuffTemplateDBData()
		{
		}

		// Token: 0x06006BF8 RID: 27640 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006BF8")]
		[Address(RVA = "0x850A00", Offset = "0x84F600", VA = "0x180850A00")]
		private string <>xLuaBaseProxy_ToString()
		{
			return null;
		}

		// Token: 0x040050C1 RID: 20673
		[Token(Token = "0x40050C1")]
		[FieldOffset(Offset = "0x10")]
		public string templateKey;

		// Token: 0x040050C2 RID: 20674
		[Token(Token = "0x40050C2")]
		[FieldOffset(Offset = "0x18")]
		public string effectKey;

		// Token: 0x040050C3 RID: 20675
		[Token(Token = "0x40050C3")]
		[FieldOffset(Offset = "0x20")]
		public BuffData.OnEventPriority onEventPriority;

		// Token: 0x040050C4 RID: 20676
		[Token(Token = "0x40050C4")]
		[FieldOffset(Offset = "0x28")]
		public Dictionary<Buff.Event, ActionNodeArray> eventToActions;

		// Token: 0x040050C5 RID: 20677
		[Token(Token = "0x40050C5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ToString;

		// Token: 0x040050C6 RID: 20678
		[Token(Token = "0x40050C6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
