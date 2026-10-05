using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004215 RID: 16917
	[Token(Token = "0x2004215")]
	public class SandboxV2DungeonSphereFloatPanel : SandboxV2FloatPanel
	{
		// Token: 0x0601A18C RID: 106892 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A18C")]
		[Address(RVA = "0x1301750", Offset = "0x1300350", VA = "0x181301750", Slot = "4")]
		protected override void SetShowStatus(bool isShow, bool fastMode = false)
		{
		}

		// Token: 0x0601A18D RID: 106893 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A18D")]
		[Address(RVA = "0x13014F0", Offset = "0x13000F0", VA = "0x1813014F0")]
		public void Render(SandboxV2DungeonViewModel viewModel)
		{
		}

		// Token: 0x0601A18E RID: 106894 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A18E")]
		[Address(RVA = "0x1301B90", Offset = "0x1300790", VA = "0x181301B90")]
		private void _SetShowButton(SandboxV2DungeonViewModel viewModel, bool isShow, bool fastMode)
		{
		}

		// Token: 0x0601A18F RID: 106895 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A18F")]
		[Address(RVA = "0x1301840", Offset = "0x1300440", VA = "0x181301840")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601A190 RID: 106896 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A190")]
		[Address(RVA = "0x1301D10", Offset = "0x1300910", VA = "0x181301D10")]
		private void _TutorialOnly_TryRaiseAVGSignalOnShown()
		{
		}

		// Token: 0x0601A191 RID: 106897 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A191")]
		[Address(RVA = "0x1301C80", Offset = "0x1300880", VA = "0x181301C80")]
		private void _TutorialOnly_TryRaiseAVGSignalOnHidden()
		{
		}

		// Token: 0x0601A192 RID: 106898 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A192")]
		[Address(RVA = "0x1301F50", Offset = "0x1300B50", VA = "0x181301F50")]
		public SandboxV2DungeonSphereFloatPanel()
		{
		}

		// Token: 0x04020E88 RID: 134792
		[Token(Token = "0x4020E88")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private CanvasGroup _rootCanvasGroup;

		// Token: 0x04020E89 RID: 134793
		[Token(Token = "0x4020E89")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private RectTransform _rootRectTrans;

		// Token: 0x04020E8A RID: 134794
		[Token(Token = "0x4020E8A")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Vector2 _detailShowPos;

		// Token: 0x04020E8B RID: 134795
		[Token(Token = "0x4020E8B")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Vector2 _detailHidePos;

		// Token: 0x04020E8C RID: 134796
		[Token(Token = "0x4020E8C")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private SandboxV2DungeonSphereFloatView _viewPrefab;

		// Token: 0x04020E8D RID: 134797
		[Token(Token = "0x4020E8D")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Transform _viewContainer;

		// Token: 0x04020E8E RID: 134798
		[Token(Token = "0x4020E8E")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private CanvasGroup _sphereButtonCanvasGroup;

		// Token: 0x04020E8F RID: 134799
		[Token(Token = "0x4020E8F")]
		[FieldOffset(Offset = "0x68")]
		private bool m_isInited;

		// Token: 0x04020E90 RID: 134800
		[Token(Token = "0x4020E90")]
		[FieldOffset(Offset = "0x70")]
		private FadeSwitchTween m_buttonTween;

		// Token: 0x04020E91 RID: 134801
		[Token(Token = "0x4020E91")]
		[FieldOffset(Offset = "0x78")]
		private FadeTranslationSwitchTween m_showTween;

		// Token: 0x04020E92 RID: 134802
		[Token(Token = "0x4020E92")]
		[FieldOffset(Offset = "0x80")]
		private SandboxV2DungeonSphereFloatView m_view;

		// Token: 0x04020E93 RID: 134803
		[Token(Token = "0x4020E93")]
		[FieldOffset(Offset = "0x88")]
		private SandboxV2DungeonViewModel m_cachedViewModel;

		// Token: 0x04020E94 RID: 134804
		[Token(Token = "0x4020E94")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_SetShowStatus;

		// Token: 0x04020E95 RID: 134805
		[Token(Token = "0x4020E95")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04020E96 RID: 134806
		[Token(Token = "0x4020E96")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__SetShowButton;

		// Token: 0x04020E97 RID: 134807
		[Token(Token = "0x4020E97")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04020E98 RID: 134808
		[Token(Token = "0x4020E98")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__TutorialOnly_TryRaiseAVGSignalOnShown;

		// Token: 0x04020E99 RID: 134809
		[Token(Token = "0x4020E99")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__TutorialOnly_TryRaiseAVGSignalOnHidden;

		// Token: 0x04020E9A RID: 134810
		[Token(Token = "0x4020E9A")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
