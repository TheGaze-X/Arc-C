using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.AVG
{
	// Token: 0x02001E75 RID: 7797
	[Token(Token = "0x2001E75")]
	public abstract class AbstractResRefCollecter
	{
		// Token: 0x0600C132 RID: 49458
		[Token(Token = "0x600C132")]
		public abstract void GatherResRefs(Command command, HashSet<string> references);

		// Token: 0x0600C133 RID: 49459 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C133")]
		[Address(RVA = "0x33E6C20", Offset = "0x33E5820", VA = "0x1833E6C20", Slot = "5")]
		public virtual void GatherResFilenames(Command command, HashSet<string> filenames)
		{
		}

		// Token: 0x17001739 RID: 5945
		// (get) Token: 0x0600C134 RID: 49460 RVA: 0x00047028 File Offset: 0x00045228
		[Token(Token = "0x17001739")]
		public virtual bool useForResBan
		{
			[Token(Token = "0x600C134")]
			[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600C135 RID: 49461 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C135")]
		[Address(RVA = "0x33E6B40", Offset = "0x33E5740", VA = "0x1833E6B40")]
		protected void CollectParamRefFromCommand(HashSet<string> refs, Command cmd, string paramName, Func<string, string> paramToPath)
		{
		}

		// Token: 0x0600C136 RID: 49462 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C136")]
		[Address(RVA = "0x33E69B0", Offset = "0x33E55B0", VA = "0x1833E69B0")]
		protected void CollectParamRefFromCommandWithSplit(HashSet<string> refs, Command cmd, string paramName, char splitor, Func<string, string> paramToPath)
		{
		}

		// Token: 0x0600C137 RID: 49463 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C137")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected AbstractResRefCollecter()
		{
		}
	}
}
