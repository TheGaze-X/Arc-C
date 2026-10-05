using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.Act7fun
{
	// Token: 0x0200719C RID: 29084
	[Token(Token = "0x200719C")]
	public class Act7FunSpineDisplayModel : IHotfixable
	{
		// Token: 0x06029443 RID: 169027 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029443")]
		[Address(RVA = "0x24BD8B0", Offset = "0x24BC4B0", VA = "0x1824BD8B0")]
		public static Act7FunSpineDisplayModel CreateSpineDisplayModel(string spineGroupId, bool isFail = false)
		{
			return null;
		}

		// Token: 0x06029444 RID: 169028 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029444")]
		[Address(RVA = "0x24BDC20", Offset = "0x24BC820", VA = "0x1824BDC20")]
		public Act7FunSpineDisplayModel()
		{
		}

		// Token: 0x0403AEFD RID: 241405
		[Token(Token = "0x403AEFD")]
		[FieldOffset(Offset = "0x10")]
		public List<Act7FunSpineDisplayItemModel> itemModels;

		// Token: 0x0403AEFE RID: 241406
		[Token(Token = "0x403AEFE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CreateSpineDisplayModel;

		// Token: 0x0403AEFF RID: 241407
		[Token(Token = "0x403AEFF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
