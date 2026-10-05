using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act33Sign
{
	// Token: 0x02007485 RID: 29829
	[Token(Token = "0x2007485")]
	public class Act33SignRedpackListAdapter : SimpleLayoutAdapter, IHotfixable
	{
		// Token: 0x1700632C RID: 25388
		// (get) Token: 0x0602A11A RID: 172314 RVA: 0x000D75C8 File Offset: 0x000D57C8
		[Token(Token = "0x1700632C")]
		public override int count
		{
			[Token(Token = "0x602A11A")]
			[Address(RVA = "0x25C1040", Offset = "0x25BFC40", VA = "0x1825C1040", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0602A11B RID: 172315 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A11B")]
		[Address(RVA = "0x25C0DF0", Offset = "0x25BF9F0", VA = "0x1825C0DF0", Slot = "5")]
		public override GameObject RenderView(int position, GameObject prefab, Transform parent)
		{
			return null;
		}

		// Token: 0x0602A11C RID: 172316 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A11C")]
		[Address(RVA = "0x25C0F90", Offset = "0x25BFB90", VA = "0x1825C0F90")]
		public Act33SignRedpackListAdapter()
		{
		}

		// Token: 0x0403C607 RID: 247303
		[Token(Token = "0x403C607")]
		[FieldOffset(Offset = "0x20")]
		public List<Act33SignRedpackItemViewModel> sourceList;

		// Token: 0x0403C608 RID: 247304
		[Token(Token = "0x403C608")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_count;

		// Token: 0x0403C609 RID: 247305
		[Token(Token = "0x403C609")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RenderView;

		// Token: 0x0403C60A RID: 247306
		[Token(Token = "0x403C60A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
