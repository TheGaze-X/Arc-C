using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x020041FA RID: 16890
	[Token(Token = "0x20041FA")]
	public class SandboxV2DungeonEventEffectFloatPanel : SandboxV2FloatPanel
	{
		// Token: 0x0601A11F RID: 106783 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A11F")]
		[Address(RVA = "0x12E75B0", Offset = "0x12E61B0", VA = "0x1812E75B0", Slot = "4")]
		protected override void SetShowStatus(bool isShow, bool fastMode = false)
		{
		}

		// Token: 0x0601A120 RID: 106784 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A120")]
		[Address(RVA = "0x12E7520", Offset = "0x12E6120", VA = "0x1812E7520")]
		public void Render(SandboxV2DungeonMiscEventEffectViewModel viewModel)
		{
		}

		// Token: 0x0601A121 RID: 106785 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A121")]
		[Address(RVA = "0x12E7680", Offset = "0x12E6280", VA = "0x1812E7680")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601A122 RID: 106786 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A122")]
		[Address(RVA = "0x12E7840", Offset = "0x12E6440", VA = "0x1812E7840")]
		public SandboxV2DungeonEventEffectFloatPanel()
		{
		}

		// Token: 0x04020D62 RID: 134498
		[Token(Token = "0x4020D62")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private CanvasGroup _rootCanvasGroup;

		// Token: 0x04020D63 RID: 134499
		[Token(Token = "0x4020D63")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private RectTransform _rootRectTrans;

		// Token: 0x04020D64 RID: 134500
		[Token(Token = "0x4020D64")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Vector2 _detailShowPos;

		// Token: 0x04020D65 RID: 134501
		[Token(Token = "0x4020D65")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Vector2 _detailHidePos;

		// Token: 0x04020D66 RID: 134502
		[Token(Token = "0x4020D66")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private SandboxV2DungeonEventEffectView _viewPrefab;

		// Token: 0x04020D67 RID: 134503
		[Token(Token = "0x4020D67")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Transform _viewContainer;

		// Token: 0x04020D68 RID: 134504
		[Token(Token = "0x4020D68")]
		[FieldOffset(Offset = "0x60")]
		private bool m_isInited;

		// Token: 0x04020D69 RID: 134505
		[Token(Token = "0x4020D69")]
		[FieldOffset(Offset = "0x68")]
		private FadeTranslationSwitchTween m_showTween;

		// Token: 0x04020D6A RID: 134506
		[Token(Token = "0x4020D6A")]
		[FieldOffset(Offset = "0x70")]
		private SandboxV2DungeonEventEffectView m_view;

		// Token: 0x04020D6B RID: 134507
		[Token(Token = "0x4020D6B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_SetShowStatus;

		// Token: 0x04020D6C RID: 134508
		[Token(Token = "0x4020D6C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04020D6D RID: 134509
		[Token(Token = "0x4020D6D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04020D6E RID: 134510
		[Token(Token = "0x4020D6E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
