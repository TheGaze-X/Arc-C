using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.LevelScript
{
	// Token: 0x02002842 RID: 10306
	[Token(Token = "0x2002842")]
	public class GetterNodeBase : LevelScriptNodeBase
	{
		// Token: 0x06011292 RID: 70290 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011292")]
		[Address(RVA = "0x90D170", Offset = "0x90BD70", VA = "0x18090D170", Slot = "6")]
		public virtual void CollectParams(ref List<IParamBindable> paramList)
		{
		}

		// Token: 0x06011293 RID: 70291 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011293")]
		[Address(RVA = "0x90EE70", Offset = "0x90DA70", VA = "0x18090EE70")]
		public GetterNodeBase()
		{
		}

		// Token: 0x04013383 RID: 78723
		[Token(Token = "0x4013383")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CollectParams;

		// Token: 0x04013384 RID: 78724
		[Token(Token = "0x4013384")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
