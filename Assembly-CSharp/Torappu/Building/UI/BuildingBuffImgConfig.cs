using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Building.UI
{
	// Token: 0x02001AE3 RID: 6883
	[Token(Token = "0x2001AE3")]
	public class BuildingBuffImgConfig : MonoBehaviour, IHotfixable
	{
		// Token: 0x0600AE01 RID: 44545 RVA: 0x000430E0 File Offset: 0x000412E0
		[Token(Token = "0x600AE01")]
		[Address(RVA = "0x3289970", Offset = "0x3288570", VA = "0x183289970")]
		public Color FindColorTheme(BuildingData.RoomType roomType)
		{
			return default(Color);
		}

		// Token: 0x0600AE02 RID: 44546 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AE02")]
		[Address(RVA = "0x3289B10", Offset = "0x3288710", VA = "0x183289B10")]
		public BuildingBuffImgConfig()
		{
		}

		// Token: 0x0400A656 RID: 42582
		[Token(Token = "0x400A656")]
		public const string IMG_HALO_ID = "[style]halo";

		// Token: 0x0400A657 RID: 42583
		[Token(Token = "0x400A657")]
		public const string IMG_HILIGHT_ID = "[style]hilight";

		// Token: 0x0400A658 RID: 42584
		[Token(Token = "0x400A658")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<BuildingBuffImgConfig.ColorConfig> _colors;

		// Token: 0x0400A659 RID: 42585
		[Token(Token = "0x400A659")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_FindColorTheme;

		// Token: 0x0400A65A RID: 42586
		[Token(Token = "0x400A65A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02001AE4 RID: 6884
		[Token(Token = "0x2001AE4")]
		[Serializable]
		private struct ColorConfig
		{
			// Token: 0x0400A65B RID: 42587
			[Token(Token = "0x400A65B")]
			[FieldOffset(Offset = "0x0")]
			public BuildingData.RoomType roomType;

			// Token: 0x0400A65C RID: 42588
			[Token(Token = "0x400A65C")]
			[FieldOffset(Offset = "0x4")]
			public Color color;
		}
	}
}
