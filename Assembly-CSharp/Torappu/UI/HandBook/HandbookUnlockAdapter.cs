using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.HandBook
{
	// Token: 0x020066A9 RID: 26281
	[Token(Token = "0x20066A9")]
	public class HandbookUnlockAdapter : SimpleLayoutAdapter
	{
		// Token: 0x1700596C RID: 22892
		// (get) Token: 0x06025BFF RID: 154623 RVA: 0x000C8E20 File Offset: 0x000C7020
		[Token(Token = "0x1700596C")]
		public override int count
		{
			[Token(Token = "0x6025BFF")]
			[Address(RVA = "0x20B5090", Offset = "0x20B3C90", VA = "0x1820B5090", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06025C00 RID: 154624 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6025C00")]
		[Address(RVA = "0x20B4E50", Offset = "0x20B3A50", VA = "0x1820B4E50", Slot = "5")]
		public override GameObject RenderView(int position, GameObject prefab, Transform parent)
		{
			return null;
		}

		// Token: 0x06025C01 RID: 154625 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025C01")]
		[Address(RVA = "0x20B5030", Offset = "0x20B3C30", VA = "0x1820B5030")]
		public HandbookUnlockAdapter()
		{
		}

		// Token: 0x040350F0 RID: 217328
		[Token(Token = "0x40350F0")]
		[FieldOffset(Offset = "0x20")]
		public List<HandBookUnlockInfo> unlockInfoList;

		// Token: 0x040350F1 RID: 217329
		[Token(Token = "0x40350F1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_count;

		// Token: 0x040350F2 RID: 217330
		[Token(Token = "0x40350F2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RenderView;

		// Token: 0x040350F3 RID: 217331
		[Token(Token = "0x40350F3")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
