using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x020041FE RID: 16894
	[Token(Token = "0x20041FE")]
	public class SandboxV2DungeonExpeditionEffectFloatPanel : SandboxV2FloatPanel
	{
		// Token: 0x0601A12B RID: 106795 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A12B")]
		[Address(RVA = "0x12EA720", Offset = "0x12E9320", VA = "0x1812EA720", Slot = "4")]
		protected override void SetShowStatus(bool isShow, bool fastMode = false)
		{
		}

		// Token: 0x0601A12C RID: 106796 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A12C")]
		[Address(RVA = "0x12EA670", Offset = "0x12E9270", VA = "0x1812EA670")]
		public void Render(SandboxV2DungeonMiscExpeditionViewModel expeditionViewModel)
		{
		}

		// Token: 0x0601A12D RID: 106797 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A12D")]
		[Address(RVA = "0x12EA7F0", Offset = "0x12E93F0", VA = "0x1812EA7F0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601A12E RID: 106798 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A12E")]
		[Address(RVA = "0x12EA9B0", Offset = "0x12E95B0", VA = "0x1812EA9B0")]
		public SandboxV2DungeonExpeditionEffectFloatPanel()
		{
		}

		// Token: 0x04020D82 RID: 134530
		[Token(Token = "0x4020D82")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private CanvasGroup _rootCanvasGroup;

		// Token: 0x04020D83 RID: 134531
		[Token(Token = "0x4020D83")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private RectTransform _rootRectTrans;

		// Token: 0x04020D84 RID: 134532
		[Token(Token = "0x4020D84")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Vector2 _detailShowPos;

		// Token: 0x04020D85 RID: 134533
		[Token(Token = "0x4020D85")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Vector2 _detailHidePos;

		// Token: 0x04020D86 RID: 134534
		[Token(Token = "0x4020D86")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private SandboxV2DungeonExpeditionEffectView _viewPrefab;

		// Token: 0x04020D87 RID: 134535
		[Token(Token = "0x4020D87")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Transform _viewContainer;

		// Token: 0x04020D88 RID: 134536
		[Token(Token = "0x4020D88")]
		[FieldOffset(Offset = "0x60")]
		private bool m_isInited;

		// Token: 0x04020D89 RID: 134537
		[Token(Token = "0x4020D89")]
		[FieldOffset(Offset = "0x68")]
		private FadeTranslationSwitchTween m_showTween;

		// Token: 0x04020D8A RID: 134538
		[Token(Token = "0x4020D8A")]
		[FieldOffset(Offset = "0x70")]
		private SandboxV2DungeonExpeditionEffectView m_view;

		// Token: 0x04020D8B RID: 134539
		[Token(Token = "0x4020D8B")]
		[FieldOffset(Offset = "0x78")]
		private SandboxV2DungeonMiscExpeditionViewModel m_cachedViewModel;

		// Token: 0x04020D8C RID: 134540
		[Token(Token = "0x4020D8C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_SetShowStatus;

		// Token: 0x04020D8D RID: 134541
		[Token(Token = "0x4020D8D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04020D8E RID: 134542
		[Token(Token = "0x4020D8E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04020D8F RID: 134543
		[Token(Token = "0x4020D8F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
