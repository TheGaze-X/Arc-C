using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Building.BP
{
	// Token: 0x02001AC0 RID: 6848
	[Token(Token = "0x2001AC0")]
	public class BRoomLevelAdapter : SimpleLayoutAdapter
	{
		// Token: 0x0600ACFD RID: 44285 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ACFD")]
		[Address(RVA = "0x3274F20", Offset = "0x3273B20", VA = "0x183274F20")]
		public void SetLevel(int level)
		{
		}

		// Token: 0x1700147C RID: 5244
		// (get) Token: 0x0600ACFE RID: 44286 RVA: 0x00042B10 File Offset: 0x00040D10
		[Token(Token = "0x1700147C")]
		public override int count
		{
			[Token(Token = "0x600ACFE")]
			[Address(RVA = "0x3275020", Offset = "0x3273C20", VA = "0x183275020", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600ACFF RID: 44287 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600ACFF")]
		[Address(RVA = "0x3274D70", Offset = "0x3273970", VA = "0x183274D70", Slot = "5")]
		public override GameObject RenderView(int position, GameObject prefab, Transform parent)
		{
			return null;
		}

		// Token: 0x0600AD00 RID: 44288 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AD00")]
		[Address(RVA = "0x3274FB0", Offset = "0x3273BB0", VA = "0x183274FB0")]
		public BRoomLevelAdapter()
		{
		}

		// Token: 0x0400A536 RID: 42294
		[Token(Token = "0x400A536")]
		[FieldOffset(Offset = "0x20")]
		private int m_level;

		// Token: 0x0400A537 RID: 42295
		[Token(Token = "0x400A537")]
		[FieldOffset(Offset = "0x24")]
		public Color mainColor;

		// Token: 0x0400A538 RID: 42296
		[Token(Token = "0x400A538")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_SetLevel;

		// Token: 0x0400A539 RID: 42297
		[Token(Token = "0x400A539")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_count;

		// Token: 0x0400A53A RID: 42298
		[Token(Token = "0x400A53A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_RenderView;

		// Token: 0x0400A53B RID: 42299
		[Token(Token = "0x400A53B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
