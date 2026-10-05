using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.EnemyHandBook
{
	// Token: 0x02004F45 RID: 20293
	[Token(Token = "0x2004F45")]
	public class MotionTypeAdatper : SimpleLayoutAdapter
	{
		// Token: 0x170046DE RID: 18142
		// (get) Token: 0x0601E378 RID: 123768 RVA: 0x000ADEF8 File Offset: 0x000AC0F8
		[Token(Token = "0x170046DE")]
		public override int count
		{
			[Token(Token = "0x601E378")]
			[Address(RVA = "0x17F48F0", Offset = "0x17F34F0", VA = "0x1817F48F0", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0601E379 RID: 123769 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601E379")]
		[Address(RVA = "0x17F46C0", Offset = "0x17F32C0", VA = "0x1817F46C0", Slot = "5")]
		public override GameObject RenderView(int position, GameObject prefab, Transform parent)
		{
			return null;
		}

		// Token: 0x0601E37A RID: 123770 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E37A")]
		[Address(RVA = "0x17F4890", Offset = "0x17F3490", VA = "0x1817F4890")]
		public MotionTypeAdatper()
		{
		}

		// Token: 0x04028471 RID: 164977
		[Token(Token = "0x4028471")]
		[FieldOffset(Offset = "0x20")]
		public UIIntEvent clickEvent;

		// Token: 0x04028472 RID: 164978
		[Token(Token = "0x4028472")]
		[FieldOffset(Offset = "0x28")]
		public List<EnemyHandbookShuffleViewModel.MotionTypeShuffleItem> motionTypeList;

		// Token: 0x04028473 RID: 164979
		[Token(Token = "0x4028473")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_count;

		// Token: 0x04028474 RID: 164980
		[Token(Token = "0x4028474")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RenderView;

		// Token: 0x04028475 RID: 164981
		[Token(Token = "0x4028475")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
