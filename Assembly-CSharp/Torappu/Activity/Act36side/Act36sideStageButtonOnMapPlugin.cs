using System;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.Atlas;
using Torappu.UI.Stage;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act36side
{
	// Token: 0x0200745F RID: 29791
	[Token(Token = "0x200745F")]
	public class Act36sideStageButtonOnMapPlugin : SimpleActivityStageButtonOnMapPlugin
	{
		// Token: 0x0602A06C RID: 172140 RVA: 0x000D7448 File Offset: 0x000D5648
		[Token(Token = "0x602A06C")]
		[Address(RVA = "0x25A04E0", Offset = "0x259F0E0", VA = "0x1825A04E0")]
		private SpriteRenderData _GetStageButtonSprite(string stageId)
		{
			return default(SpriteRenderData);
		}

		// Token: 0x0602A06D RID: 172141 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A06D")]
		[Address(RVA = "0x25A0330", Offset = "0x259EF30", VA = "0x1825A0330", Slot = "4")]
		public override void RenderStage(StageButtonOnMapHolder holder, StageViewModel viewModel, ZoneViewModel zoneViewModel, bool isSelected)
		{
		}

		// Token: 0x0602A06E RID: 172142 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A06E")]
		[Address(RVA = "0x25A05A0", Offset = "0x259F1A0", VA = "0x1825A05A0")]
		public Act36sideStageButtonOnMapPlugin()
		{
		}

		// Token: 0x0403C497 RID: 246935
		[Token(Token = "0x403C497")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIAtlasObject _atlasObject;

		// Token: 0x0403C498 RID: 246936
		[Token(Token = "0x403C498")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIAtlasImage _stageButtonImage;

		// Token: 0x0403C499 RID: 246937
		[Token(Token = "0x403C499")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _panelTraining;

		// Token: 0x0403C49A RID: 246938
		[Token(Token = "0x403C49A")]
		[FieldOffset(Offset = "0x30")]
		private string m_cachedStageId;

		// Token: 0x0403C49B RID: 246939
		[Token(Token = "0x403C49B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__GetStageButtonSprite;

		// Token: 0x0403C49C RID: 246940
		[Token(Token = "0x403C49C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RenderStage;

		// Token: 0x0403C49D RID: 246941
		[Token(Token = "0x403C49D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
