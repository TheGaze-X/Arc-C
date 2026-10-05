using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.CrisisV2
{
	// Token: 0x02005994 RID: 22932
	[Token(Token = "0x2005994")]
	public class CrisisV2EntryTempButtonAdapter : SimpleLayoutAdapter
	{
		// Token: 0x17004EA0 RID: 20128
		// (get) Token: 0x060216DA RID: 136922 RVA: 0x000BA3F0 File Offset: 0x000B85F0
		[Token(Token = "0x17004EA0")]
		public override int count
		{
			[Token(Token = "0x60216DA")]
			[Address(RVA = "0x1BC0C00", Offset = "0x1BBF800", VA = "0x181BC0C00", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060216DB RID: 136923 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60216DB")]
		[Address(RVA = "0x1BC0A00", Offset = "0x1BBF600", VA = "0x181BC0A00", Slot = "5")]
		public override GameObject RenderView(int position, GameObject prefab, Transform parent)
		{
			return null;
		}

		// Token: 0x060216DC RID: 136924 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60216DC")]
		[Address(RVA = "0x1BC0BA0", Offset = "0x1BBF7A0", VA = "0x181BC0BA0")]
		public CrisisV2EntryTempButtonAdapter()
		{
		}

		// Token: 0x0402D9C6 RID: 186822
		[Token(Token = "0x402D9C6")]
		[FieldOffset(Offset = "0x20")]
		public List<CrisisV2EntryViewModel.TempPart> tempList;

		// Token: 0x0402D9C7 RID: 186823
		[Token(Token = "0x402D9C7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_count;

		// Token: 0x0402D9C8 RID: 186824
		[Token(Token = "0x402D9C8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RenderView;

		// Token: 0x0402D9C9 RID: 186825
		[Token(Token = "0x402D9C9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
