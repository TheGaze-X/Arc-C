using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.EnemyHandBook
{
	// Token: 0x02004F42 RID: 20290
	[Token(Token = "0x2004F42")]
	public class RaceAdatper : SimpleLayoutAdapter
	{
		// Token: 0x170046DB RID: 18139
		// (get) Token: 0x0601E36F RID: 123759 RVA: 0x000ADEB0 File Offset: 0x000AC0B0
		[Token(Token = "0x170046DB")]
		public override int count
		{
			[Token(Token = "0x601E36F")]
			[Address(RVA = "0x17F4E40", Offset = "0x17F3A40", VA = "0x1817F4E40", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0601E370 RID: 123760 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601E370")]
		[Address(RVA = "0x17F4B90", Offset = "0x17F3790", VA = "0x1817F4B90", Slot = "5")]
		public override GameObject RenderView(int position, GameObject prefab, Transform parent)
		{
			return null;
		}

		// Token: 0x0601E371 RID: 123761 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E371")]
		[Address(RVA = "0x17F4DE0", Offset = "0x17F39E0", VA = "0x1817F4DE0")]
		public RaceAdatper()
		{
		}

		// Token: 0x04028462 RID: 164962
		[Token(Token = "0x4028462")]
		[FieldOffset(Offset = "0x20")]
		public UIIntEvent clickEvent;

		// Token: 0x04028463 RID: 164963
		[Token(Token = "0x4028463")]
		[FieldOffset(Offset = "0x28")]
		public List<EnemyHandbookShuffleViewModel.RaceShuffleItem> raceList;

		// Token: 0x04028464 RID: 164964
		[Token(Token = "0x4028464")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_count;

		// Token: 0x04028465 RID: 164965
		[Token(Token = "0x4028465")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RenderView;

		// Token: 0x04028466 RID: 164966
		[Token(Token = "0x4028466")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
