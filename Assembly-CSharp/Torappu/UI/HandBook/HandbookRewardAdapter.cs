using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.HandBook
{
	// Token: 0x02006698 RID: 26264
	[Token(Token = "0x2006698")]
	public class HandbookRewardAdapter : SimpleLayoutAdapter
	{
		// Token: 0x17005962 RID: 22882
		// (get) Token: 0x06025BA2 RID: 154530 RVA: 0x000C8D78 File Offset: 0x000C6F78
		[Token(Token = "0x17005962")]
		public override int count
		{
			[Token(Token = "0x6025BA2")]
			[Address(RVA = "0x20B4A00", Offset = "0x20B3600", VA = "0x1820B4A00", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06025BA3 RID: 154531 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6025BA3")]
		[Address(RVA = "0x20B45B0", Offset = "0x20B31B0", VA = "0x1820B45B0", Slot = "5")]
		public override GameObject RenderView(int position, GameObject prefab, Transform parent)
		{
			return null;
		}

		// Token: 0x06025BA4 RID: 154532 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025BA4")]
		[Address(RVA = "0x20B49A0", Offset = "0x20B35A0", VA = "0x1820B49A0")]
		public HandbookRewardAdapter()
		{
		}

		// Token: 0x0403502B RID: 217131
		[Token(Token = "0x403502B")]
		[FieldOffset(Offset = "0x20")]
		public List<ItemBundle> itemList;

		// Token: 0x0403502C RID: 217132
		[Token(Token = "0x403502C")]
		[FieldOffset(Offset = "0x28")]
		public float scale;

		// Token: 0x0403502D RID: 217133
		[Token(Token = "0x403502D")]
		[FieldOffset(Offset = "0x2C")]
		public bool showItemName;

		// Token: 0x0403502E RID: 217134
		[Token(Token = "0x403502E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_count;

		// Token: 0x0403502F RID: 217135
		[Token(Token = "0x403502F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RenderView;

		// Token: 0x04035030 RID: 217136
		[Token(Token = "0x4035030")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
