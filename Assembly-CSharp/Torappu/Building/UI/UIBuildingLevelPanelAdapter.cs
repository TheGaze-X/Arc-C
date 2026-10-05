using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Building.UI
{
	// Token: 0x02001B5E RID: 7006
	[Token(Token = "0x2001B5E")]
	public class UIBuildingLevelPanelAdapter : SimpleLayoutAdapter
	{
		// Token: 0x170014D9 RID: 5337
		// (get) Token: 0x0600AFE8 RID: 45032 RVA: 0x00043548 File Offset: 0x00041748
		[Token(Token = "0x170014D9")]
		public override int count
		{
			[Token(Token = "0x600AFE8")]
			[Address(RVA = "0x32B9B40", Offset = "0x32B8740", VA = "0x1832B9B40", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600AFE9 RID: 45033 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600AFE9")]
		[Address(RVA = "0x32B9910", Offset = "0x32B8510", VA = "0x1832B9910", Slot = "5")]
		public override GameObject RenderView(int position, GameObject prefab, Transform parent)
		{
			return null;
		}

		// Token: 0x0600AFEA RID: 45034 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AFEA")]
		[Address(RVA = "0x32B9AC0", Offset = "0x32B86C0", VA = "0x1832B9AC0")]
		public UIBuildingLevelPanelAdapter()
		{
		}

		// Token: 0x0400AA27 RID: 43559
		[Token(Token = "0x400AA27")]
		[FieldOffset(Offset = "0x20")]
		public int level;

		// Token: 0x0400AA28 RID: 43560
		[Token(Token = "0x400AA28")]
		[FieldOffset(Offset = "0x24")]
		public int maxLevel;

		// Token: 0x0400AA29 RID: 43561
		[Token(Token = "0x400AA29")]
		[FieldOffset(Offset = "0x28")]
		public Color color;

		// Token: 0x0400AA2A RID: 43562
		[Token(Token = "0x400AA2A")]
		[FieldOffset(Offset = "0x38")]
		public Color emptyColor;

		// Token: 0x0400AA2B RID: 43563
		[Token(Token = "0x400AA2B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_count;

		// Token: 0x0400AA2C RID: 43564
		[Token(Token = "0x400AA2C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RenderView;

		// Token: 0x0400AA2D RID: 43565
		[Token(Token = "0x400AA2D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
