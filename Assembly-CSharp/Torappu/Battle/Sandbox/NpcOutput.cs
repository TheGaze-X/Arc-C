using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.Sandbox
{
	// Token: 0x02002A72 RID: 10866
	[Token(Token = "0x2002A72")]
	public class NpcOutput : List<NpcOutput.NpcOutputInfo>, IHotfixable
	{
		// Token: 0x06012116 RID: 74006 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012116")]
		[Address(RVA = "0xA27960", Offset = "0xA26560", VA = "0x180A27960")]
		public NpcOutput()
		{
		}

		// Token: 0x0401469C RID: 83612
		[Token(Token = "0x401469C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02002A73 RID: 10867
		[Token(Token = "0x2002A73")]
		public class NpcOutputInfo
		{
			// Token: 0x06012117 RID: 74007 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6012117")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public NpcOutputInfo()
			{
			}

			// Token: 0x0401469D RID: 83613
			[Token(Token = "0x401469D")]
			[FieldOffset(Offset = "0x10")]
			public string npcId;

			// Token: 0x0401469E RID: 83614
			[Token(Token = "0x401469E")]
			[FieldOffset(Offset = "0x18")]
			public int dialogue;

			// Token: 0x0401469F RID: 83615
			[Token(Token = "0x401469F")]
			[FieldOffset(Offset = "0x20")]
			public List<string> choice;

			// Token: 0x040146A0 RID: 83616
			[Token(Token = "0x40146A0")]
			[FieldOffset(Offset = "0x28")]
			public bool isFinished;
		}
	}
}
