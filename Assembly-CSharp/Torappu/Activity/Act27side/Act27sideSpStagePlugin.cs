using System;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.Atlas;
using Torappu.UI.Stage;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act27side
{
	// Token: 0x020074BD RID: 29885
	[Token(Token = "0x20074BD")]
	public class Act27sideSpStagePlugin : SimpleActivityStageButtonOnMapPlugin, IHotfixable
	{
		// Token: 0x0602A257 RID: 172631 RVA: 0x000D7898 File Offset: 0x000D5A98
		[Token(Token = "0x602A257")]
		[Address(RVA = "0x25D2210", Offset = "0x25D0E10", VA = "0x1825D2210")]
		private SpriteRenderData _GetStageButtonSprite(string stageId)
		{
			return default(SpriteRenderData);
		}

		// Token: 0x0602A258 RID: 172632 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A258")]
		[Address(RVA = "0x25D2080", Offset = "0x25D0C80", VA = "0x1825D2080", Slot = "4")]
		public override void RenderStage(StageButtonOnMapHolder holder, StageViewModel viewModel, ZoneViewModel zoneViewModel, bool isSelected)
		{
		}

		// Token: 0x0602A259 RID: 172633 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A259")]
		[Address(RVA = "0x25D22D0", Offset = "0x25D0ED0", VA = "0x1825D22D0")]
		public Act27sideSpStagePlugin()
		{
		}

		// Token: 0x0403C8BE RID: 247998
		[Token(Token = "0x403C8BE")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIAtlasObject _atlasObject;

		// Token: 0x0403C8BF RID: 247999
		[Token(Token = "0x403C8BF")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIAtlasImage _stageButtonBkg;

		// Token: 0x0403C8C0 RID: 248000
		[Token(Token = "0x403C8C0")]
		[FieldOffset(Offset = "0x28")]
		private string m_cachedStageId;

		// Token: 0x0403C8C1 RID: 248001
		[Token(Token = "0x403C8C1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__GetStageButtonSprite;

		// Token: 0x0403C8C2 RID: 248002
		[Token(Token = "0x403C8C2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RenderStage;

		// Token: 0x0403C8C3 RID: 248003
		[Token(Token = "0x403C8C3")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
