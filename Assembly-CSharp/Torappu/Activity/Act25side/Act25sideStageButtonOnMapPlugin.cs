using System;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.Atlas;
using Torappu.UI.Stage;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act25side
{
	// Token: 0x020074DD RID: 29917
	[Token(Token = "0x20074DD")]
	public class Act25sideStageButtonOnMapPlugin : SimpleActivityStageButtonOnMapPlugin
	{
		// Token: 0x0602A2CD RID: 172749 RVA: 0x000D7A00 File Offset: 0x000D5C00
		[Token(Token = "0x602A2CD")]
		[Address(RVA = "0x25CE480", Offset = "0x25CD080", VA = "0x1825CE480")]
		private SpriteRenderData _GetStageButtonSprite(string stageId)
		{
			return default(SpriteRenderData);
		}

		// Token: 0x0602A2CE RID: 172750 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A2CE")]
		[Address(RVA = "0x25CE2F0", Offset = "0x25CCEF0", VA = "0x1825CE2F0", Slot = "4")]
		public override void RenderStage(StageButtonOnMapHolder holder, StageViewModel viewModel, ZoneViewModel zoneViewModel, bool isSelected)
		{
		}

		// Token: 0x0602A2CF RID: 172751 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A2CF")]
		[Address(RVA = "0x25CE540", Offset = "0x25CD140", VA = "0x1825CE540")]
		public Act25sideStageButtonOnMapPlugin()
		{
		}

		// Token: 0x0403C970 RID: 248176
		[Token(Token = "0x403C970")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIAtlasObject _atlasObject;

		// Token: 0x0403C971 RID: 248177
		[Token(Token = "0x403C971")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIAtlasImage _stageButtonImage;

		// Token: 0x0403C972 RID: 248178
		[Token(Token = "0x403C972")]
		[FieldOffset(Offset = "0x28")]
		private string m_cachedStageId;

		// Token: 0x0403C973 RID: 248179
		[Token(Token = "0x403C973")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__GetStageButtonSprite;

		// Token: 0x0403C974 RID: 248180
		[Token(Token = "0x403C974")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RenderStage;

		// Token: 0x0403C975 RID: 248181
		[Token(Token = "0x403C975")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
