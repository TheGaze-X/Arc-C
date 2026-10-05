using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Building.UI
{
	// Token: 0x02001B7C RID: 7036
	[Token(Token = "0x2001B7C")]
	public class BuildingFavorNotifyView : UINotifyView<BuildingFavorNotifyView.Param>
	{
		// Token: 0x0600B03C RID: 45116 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B03C")]
		[Address(RVA = "0x32A3FD0", Offset = "0x32A2BD0", VA = "0x1832A3FD0", Slot = "9")]
		protected override void Render(BuildingFavorNotifyView.Param param)
		{
		}

		// Token: 0x0600B03D RID: 45117 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B03D")]
		[Address(RVA = "0x32A4210", Offset = "0x32A2E10", VA = "0x1832A4210")]
		public BuildingFavorNotifyView()
		{
		}

		// Token: 0x0400AA89 RID: 43657
		[Token(Token = "0x400AA89")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _imgBubble;

		// Token: 0x0400AA8A RID: 43658
		[Token(Token = "0x400AA8A")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private BuildingFavorNotifyView.FavorConfig[] _favorConfigs;

		// Token: 0x0400AA8B RID: 43659
		[Token(Token = "0x400AA8B")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Image _imgBkg;

		// Token: 0x0400AA8C RID: 43660
		[Token(Token = "0x400AA8C")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _textDesc;

		// Token: 0x0400AA8D RID: 43661
		[Token(Token = "0x400AA8D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0400AA8E RID: 43662
		[Token(Token = "0x400AA8E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02001B7D RID: 7037
		[Token(Token = "0x2001B7D")]
		[Serializable]
		public enum FavorType
		{
			// Token: 0x0400AA90 RID: 43664
			[Token(Token = "0x400AA90")]
			NORMAL,
			// Token: 0x0400AA91 RID: 43665
			[Token(Token = "0x400AA91")]
			ASSIST,
			// Token: 0x0400AA92 RID: 43666
			[Token(Token = "0x400AA92")]
			PRIVATE
		}

		// Token: 0x02001B7E RID: 7038
		[Token(Token = "0x2001B7E")]
		[Serializable]
		private class FavorConfig
		{
			// Token: 0x0600B03E RID: 45118 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B03E")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public FavorConfig()
			{
			}

			// Token: 0x0400AA93 RID: 43667
			[Token(Token = "0x400AA93")]
			[FieldOffset(Offset = "0x10")]
			public BuildingFavorNotifyView.FavorType favorType;

			// Token: 0x0400AA94 RID: 43668
			[Token(Token = "0x400AA94")]
			[FieldOffset(Offset = "0x18")]
			public Sprite bubble;

			// Token: 0x0400AA95 RID: 43669
			[Token(Token = "0x400AA95")]
			[FieldOffset(Offset = "0x20")]
			public Sprite bkg;
		}

		// Token: 0x02001B7F RID: 7039
		[Token(Token = "0x2001B7F")]
		public class Param : NotifyViewParam
		{
			// Token: 0x0600B03F RID: 45119 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B03F")]
			[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
			public Param()
			{
			}

			// Token: 0x0400AA96 RID: 43670
			[Token(Token = "0x400AA96")]
			[FieldOffset(Offset = "0x10")]
			public BuildingFavorNotifyView.FavorType favorType;
		}
	}
}
