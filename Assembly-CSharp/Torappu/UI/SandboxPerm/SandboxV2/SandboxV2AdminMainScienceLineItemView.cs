using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x020040C9 RID: 16585
	[Token(Token = "0x20040C9")]
	public class SandboxV2AdminMainScienceLineItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06019A70 RID: 105072 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019A70")]
		[Address(RVA = "0x12783E0", Offset = "0x1276FE0", VA = "0x1812783E0")]
		public void Render(Vector2 fromPos, Vector2 toPos, bool isUnlock, SandboxV2DevelopmentLineStyle style, int level, bool isHalfLine = false)
		{
		}

		// Token: 0x06019A71 RID: 105073 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019A71")]
		[Address(RVA = "0x1278BE0", Offset = "0x12777E0", VA = "0x181278BE0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06019A72 RID: 105074 RVA: 0x0009EEF8 File Offset: 0x0009D0F8
		[Token(Token = "0x6019A72")]
		[Address(RVA = "0x1278A40", Offset = "0x1277640", VA = "0x181278A40")]
		private Vector2 _CalculateMiddlePoint(Vector2 start, Vector2 end)
		{
			return default(Vector2);
		}

		// Token: 0x06019A73 RID: 105075 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019A73")]
		[Address(RVA = "0x1278D00", Offset = "0x1277900", VA = "0x181278D00")]
		public SandboxV2AdminMainScienceLineItemView()
		{
		}

		// Token: 0x040200F0 RID: 131312
		[Token(Token = "0x40200F0")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SandboxV2AdminMainScienceLine _line;

		// Token: 0x040200F1 RID: 131313
		[Token(Token = "0x40200F1")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _levelItem;

		// Token: 0x040200F2 RID: 131314
		[Token(Token = "0x40200F2")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _levelItemBlock;

		// Token: 0x040200F3 RID: 131315
		[Token(Token = "0x40200F3")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _levelTxt;

		// Token: 0x040200F4 RID: 131316
		[Token(Token = "0x40200F4")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Transform _levelItemContainer;

		// Token: 0x040200F5 RID: 131317
		[Token(Token = "0x40200F5")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Color _lineLockedColor;

		// Token: 0x040200F6 RID: 131318
		[Token(Token = "0x40200F6")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Color _lineUnlockColor;

		// Token: 0x040200F7 RID: 131319
		[Token(Token = "0x40200F7")]
		private const float LINE_X_OFFSET = -5f;

		// Token: 0x040200F8 RID: 131320
		[Token(Token = "0x40200F8")]
		[FieldOffset(Offset = "0x60")]
		private SandboxV2AdminMainScienceLineItemView.LineColorSwitchTween m_lineSwitchTween;

		// Token: 0x040200F9 RID: 131321
		[Token(Token = "0x40200F9")]
		[FieldOffset(Offset = "0x68")]
		private bool m_hasInited;

		// Token: 0x040200FA RID: 131322
		[Token(Token = "0x40200FA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040200FB RID: 131323
		[Token(Token = "0x40200FB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040200FC RID: 131324
		[Token(Token = "0x40200FC")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__CalculateMiddlePoint;

		// Token: 0x040200FD RID: 131325
		[Token(Token = "0x40200FD")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020040CA RID: 16586
		[Token(Token = "0x20040CA")]
		private class LineColorSwitchTween : UISwitchTween, IHotfixable
		{
			// Token: 0x06019A74 RID: 105076 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6019A74")]
			[Address(RVA = "0x1272390", Offset = "0x1270F90", VA = "0x181272390")]
			public LineColorSwitchTween(SandboxV2AdminMainScienceLineItemView closure)
			{
			}

			// Token: 0x06019A75 RID: 105077 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6019A75")]
			[Address(RVA = "0x12720C0", Offset = "0x1270CC0", VA = "0x1812720C0", Slot = "5")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfHide()
			{
				return null;
			}

			// Token: 0x06019A76 RID: 105078 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6019A76")]
			[Address(RVA = "0x12721B0", Offset = "0x1270DB0", VA = "0x1812721B0", Slot = "4")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfShow()
			{
				return null;
			}

			// Token: 0x06019A77 RID: 105079 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6019A77")]
			[Address(RVA = "0x12722A0", Offset = "0x1270EA0", VA = "0x1812722A0", Slot = "10")]
			protected override void ResetToState(bool isShow)
			{
			}

			// Token: 0x06019A78 RID: 105080 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6019A78")]
			[Address(RVA = "0x9B38B0", Offset = "0x9B24B0", VA = "0x1809B38B0")]
			private void <>xLuaBaseProxy_ResetToState(bool P0)
			{
			}

			// Token: 0x040200FE RID: 131326
			[Token(Token = "0x40200FE")]
			[FieldOffset(Offset = "0x48")]
			private SandboxV2AdminMainScienceLineItemView m_closure;

			// Token: 0x040200FF RID: 131327
			[Token(Token = "0x40200FF")]
			private const float FADE_TIME = 0.16f;

			// Token: 0x04020100 RID: 131328
			[Token(Token = "0x4020100")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04020101 RID: 131329
			[Token(Token = "0x4020101")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfHide;

			// Token: 0x04020102 RID: 131330
			[Token(Token = "0x4020102")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfShow;

			// Token: 0x04020103 RID: 131331
			[Token(Token = "0x4020103")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_ResetToState;
		}
	}
}
