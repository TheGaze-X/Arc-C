using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act5D1
{
	// Token: 0x02007235 RID: 29237
	[Token(Token = "0x2007235")]
	public class Act5D1ShowAdapter : SimpleLayoutAdapter, IHotfixable
	{
		// Token: 0x17006223 RID: 25123
		// (get) Token: 0x060296E5 RID: 169701 RVA: 0x000D5A98 File Offset: 0x000D3C98
		[Token(Token = "0x17006223")]
		public override int count
		{
			[Token(Token = "0x60296E5")]
			[Address(RVA = "0x24D1980", Offset = "0x24D0580", VA = "0x1824D1980", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060296E6 RID: 169702 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60296E6")]
		[Address(RVA = "0x24D16F0", Offset = "0x24D02F0", VA = "0x1824D16F0", Slot = "5")]
		public override GameObject RenderView(int position, GameObject prefab, Transform parent)
		{
			return null;
		}

		// Token: 0x060296E7 RID: 169703 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60296E7")]
		[Address(RVA = "0x24D18D0", Offset = "0x24D04D0", VA = "0x1824D18D0")]
		public Act5D1ShowAdapter()
		{
		}

		// Token: 0x0403B2F7 RID: 242423
		[Token(Token = "0x403B2F7")]
		[FieldOffset(Offset = "0x20")]
		[NonSerialized]
		public List<RuneShowInfo> runeShowList;

		// Token: 0x0403B2F8 RID: 242424
		[Token(Token = "0x403B2F8")]
		[FieldOffset(Offset = "0x28")]
		[NonSerialized]
		public bool canUnlockFlag;

		// Token: 0x0403B2F9 RID: 242425
		[Token(Token = "0x403B2F9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_count;

		// Token: 0x0403B2FA RID: 242426
		[Token(Token = "0x403B2FA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RenderView;

		// Token: 0x0403B2FB RID: 242427
		[Token(Token = "0x403B2FB")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
