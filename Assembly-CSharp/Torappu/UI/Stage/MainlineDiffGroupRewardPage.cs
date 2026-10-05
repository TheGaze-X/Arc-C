using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x02006782 RID: 26498
	[Token(Token = "0x2006782")]
	public class MainlineDiffGroupRewardPage : StateEnginePage, IFadeInPushWithBlurBkg, IHotfixable
	{
		// Token: 0x06026034 RID: 155700 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6026034")]
		[Address(RVA = "0x20FB690", Offset = "0x20FA290", VA = "0x1820FB690", Slot = "29")]
		public UIRenderTextureImage GetBlurBkg()
		{
			return null;
		}

		// Token: 0x06026035 RID: 155701 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026035")]
		[Address(RVA = "0x20FB6F0", Offset = "0x20FA2F0", VA = "0x1820FB6F0")]
		public MainlineDiffGroupRewardPage()
		{
		}

		// Token: 0x04035798 RID: 219032
		[Token(Token = "0x4035798")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private UIRenderTextureImage _backImage;

		// Token: 0x04035799 RID: 219033
		[Token(Token = "0x4035799")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetBlurBkg;

		// Token: 0x0403579A RID: 219034
		[Token(Token = "0x403579A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006783 RID: 26499
		[Token(Token = "0x2006783")]
		public class Param
		{
			// Token: 0x06026036 RID: 155702 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6026036")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Param()
			{
			}

			// Token: 0x0403579B RID: 219035
			[Token(Token = "0x403579B")]
			[FieldOffset(Offset = "0x10")]
			public StageViewModel stageViewModel;

			// Token: 0x0403579C RID: 219036
			[Token(Token = "0x403579C")]
			[FieldOffset(Offset = "0x18")]
			public bool isToSquad;

			// Token: 0x0403579D RID: 219037
			[Token(Token = "0x403579D")]
			[FieldOffset(Offset = "0x20")]
			public SquadPage.Params squadParam;
		}
	}
}
