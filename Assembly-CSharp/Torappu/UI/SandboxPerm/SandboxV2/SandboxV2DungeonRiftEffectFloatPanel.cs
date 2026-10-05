using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004207 RID: 16903
	[Token(Token = "0x2004207")]
	public class SandboxV2DungeonRiftEffectFloatPanel : SandboxV2FloatPanel
	{
		// Token: 0x0601A148 RID: 106824 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A148")]
		[Address(RVA = "0x12F2560", Offset = "0x12F1160", VA = "0x1812F2560", Slot = "4")]
		protected override void SetShowStatus(bool isShow, bool fastMode = false)
		{
		}

		// Token: 0x0601A149 RID: 106825 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A149")]
		[Address(RVA = "0x12F24D0", Offset = "0x12F10D0", VA = "0x1812F24D0")]
		public void Render(SandboxV2DungeonMiscRiftViewModel viewModel)
		{
		}

		// Token: 0x0601A14A RID: 106826 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A14A")]
		[Address(RVA = "0x12F2670", Offset = "0x12F1270", VA = "0x1812F2670")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601A14B RID: 106827 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A14B")]
		[Address(RVA = "0x12F28B0", Offset = "0x12F14B0", VA = "0x1812F28B0")]
		public SandboxV2DungeonRiftEffectFloatPanel()
		{
		}

		// Token: 0x04020DCE RID: 134606
		[Token(Token = "0x4020DCE")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private CanvasGroup _rootCanvasGroup;

		// Token: 0x04020DCF RID: 134607
		[Token(Token = "0x4020DCF")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private RectTransform _rootRectTrans;

		// Token: 0x04020DD0 RID: 134608
		[Token(Token = "0x4020DD0")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Vector2 _detailShowPos;

		// Token: 0x04020DD1 RID: 134609
		[Token(Token = "0x4020DD1")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Vector2 _detailHidePos;

		// Token: 0x04020DD2 RID: 134610
		[Token(Token = "0x4020DD2")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private SandboxV2DungeonRiftEffectView _viewPrefab;

		// Token: 0x04020DD3 RID: 134611
		[Token(Token = "0x4020DD3")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Transform _viewContainer;

		// Token: 0x04020DD4 RID: 134612
		[Token(Token = "0x4020DD4")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private CanvasGroup _canvasSelectTag;

		// Token: 0x04020DD5 RID: 134613
		[Token(Token = "0x4020DD5")]
		[FieldOffset(Offset = "0x68")]
		private bool m_isInited;

		// Token: 0x04020DD6 RID: 134614
		[Token(Token = "0x4020DD6")]
		[FieldOffset(Offset = "0x70")]
		private FadeTranslationSwitchTween m_showTween;

		// Token: 0x04020DD7 RID: 134615
		[Token(Token = "0x4020DD7")]
		[FieldOffset(Offset = "0x78")]
		private SandboxV2DungeonRiftEffectView m_view;

		// Token: 0x04020DD8 RID: 134616
		[Token(Token = "0x4020DD8")]
		[FieldOffset(Offset = "0x80")]
		private FadeSwitchTween m_tweenSelectTag;

		// Token: 0x04020DD9 RID: 134617
		[Token(Token = "0x4020DD9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_SetShowStatus;

		// Token: 0x04020DDA RID: 134618
		[Token(Token = "0x4020DDA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04020DDB RID: 134619
		[Token(Token = "0x4020DDB")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04020DDC RID: 134620
		[Token(Token = "0x4020DDC")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
