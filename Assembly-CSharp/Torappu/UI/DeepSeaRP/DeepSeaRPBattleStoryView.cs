using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.DeepSeaRP
{
	// Token: 0x02005117 RID: 20759
	[Token(Token = "0x2005117")]
	public class DeepSeaRPBattleStoryView : DataBinder<DeepSeaRPBattleNodeDetailProperty>, IHotfixable
	{
		// Token: 0x0601EA89 RID: 125577 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EA89")]
		[Address(RVA = "0x1853E80", Offset = "0x1852A80", VA = "0x181853E80")]
		public void OnEnter()
		{
		}

		// Token: 0x0601EA8A RID: 125578 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EA8A")]
		[Address(RVA = "0x1853F00", Offset = "0x1852B00", VA = "0x181853F00", Slot = "7")]
		public override void OnValueChanged(DeepSeaRPBattleNodeDetailProperty property)
		{
		}

		// Token: 0x0601EA8B RID: 125579 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EA8B")]
		[Address(RVA = "0x1854270", Offset = "0x1852E70", VA = "0x181854270")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601EA8C RID: 125580 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EA8C")]
		[Address(RVA = "0x18543A0", Offset = "0x1852FA0", VA = "0x1818543A0")]
		public DeepSeaRPBattleStoryView()
		{
		}

		// Token: 0x040291CB RID: 168395
		[Token(Token = "0x40291CB")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private DeepSeaRPBattleStoryViewObject[] _btnPanelGroup;

		// Token: 0x040291CC RID: 168396
		[Token(Token = "0x40291CC")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RectTransform _leftPanel;

		// Token: 0x040291CD RID: 168397
		[Token(Token = "0x40291CD")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private RectTransform _rightPanel;

		// Token: 0x040291CE RID: 168398
		[Token(Token = "0x40291CE")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private RectTransform _centerIcon;

		// Token: 0x040291CF RID: 168399
		[Token(Token = "0x40291CF")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private CanvasGroup _selfCanvas;

		// Token: 0x040291D0 RID: 168400
		[Token(Token = "0x40291D0")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private CanvasGroup _leftCanvas;

		// Token: 0x040291D1 RID: 168401
		[Token(Token = "0x40291D1")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private CanvasGroup _rightCanvas;

		// Token: 0x040291D2 RID: 168402
		[Token(Token = "0x40291D2")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private CanvasGroup _leftTextCanvas;

		// Token: 0x040291D3 RID: 168403
		[Token(Token = "0x40291D3")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private CanvasGroup _rightTextCanvas;

		// Token: 0x040291D4 RID: 168404
		[Token(Token = "0x40291D4")]
		[FieldOffset(Offset = "0x68")]
		private bool m_isInited;

		// Token: 0x040291D5 RID: 168405
		[Token(Token = "0x40291D5")]
		[FieldOffset(Offset = "0x70")]
		private DeepSeaRPBattleStoryView.StorySwitchTween m_switchTween;

		// Token: 0x040291D6 RID: 168406
		[Token(Token = "0x40291D6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x040291D7 RID: 168407
		[Token(Token = "0x40291D7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x040291D8 RID: 168408
		[Token(Token = "0x40291D8")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040291D9 RID: 168409
		[Token(Token = "0x40291D9")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005118 RID: 20760
		[Token(Token = "0x2005118")]
		private class StorySwitchTween : UISwitchTween
		{
			// Token: 0x0601EA8D RID: 125581 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601EA8D")]
			[Address(RVA = "0x1863F60", Offset = "0x1862B60", VA = "0x181863F60")]
			public StorySwitchTween(DeepSeaRPBattleStoryView closure)
			{
			}

			// Token: 0x0601EA8E RID: 125582 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601EA8E")]
			[Address(RVA = "0x18635D0", Offset = "0x18621D0", VA = "0x1818635D0", Slot = "5")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfHide()
			{
				return null;
			}

			// Token: 0x0601EA8F RID: 125583 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601EA8F")]
			[Address(RVA = "0x1863870", Offset = "0x1862470", VA = "0x181863870", Slot = "4")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfShow()
			{
				return null;
			}

			// Token: 0x0601EA90 RID: 125584 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601EA90")]
			[Address(RVA = "0x1863540", Offset = "0x1862140", VA = "0x181863540", Slot = "6")]
			protected override void BeforeShowEffect()
			{
			}

			// Token: 0x0601EA91 RID: 125585 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601EA91")]
			[Address(RVA = "0x1863480", Offset = "0x1862080", VA = "0x181863480", Slot = "9")]
			protected override void AfterHideEffect()
			{
			}

			// Token: 0x0601EA92 RID: 125586 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601EA92")]
			[Address(RVA = "0x1863BC0", Offset = "0x18627C0", VA = "0x181863BC0", Slot = "10")]
			protected override void ResetToState(bool isShow)
			{
			}

			// Token: 0x0601EA94 RID: 125588 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601EA94")]
			[Address(RVA = "0xDFAF10", Offset = "0xDF9B10", VA = "0x180DFAF10")]
			private void <>xLuaBaseProxy_BeforeShowEffect()
			{
			}

			// Token: 0x0601EA95 RID: 125589 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601EA95")]
			[Address(RVA = "0x9C2DA0", Offset = "0x9C19A0", VA = "0x1809C2DA0")]
			private void <>xLuaBaseProxy_AfterHideEffect()
			{
			}

			// Token: 0x0601EA96 RID: 125590 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601EA96")]
			[Address(RVA = "0x9B38B0", Offset = "0x9B24B0", VA = "0x1809B38B0")]
			private void <>xLuaBaseProxy_ResetToState(bool P0)
			{
			}

			// Token: 0x040291DA RID: 168410
			[Token(Token = "0x40291DA")]
			[FieldOffset(Offset = "0x0")]
			private static readonly Vector2 LEFT_START_POS;

			// Token: 0x040291DB RID: 168411
			[Token(Token = "0x40291DB")]
			[FieldOffset(Offset = "0x8")]
			private static readonly Vector2 LEFT_END_POS;

			// Token: 0x040291DC RID: 168412
			[Token(Token = "0x40291DC")]
			[FieldOffset(Offset = "0x10")]
			private static readonly Vector2 RIGHT_START_POS;

			// Token: 0x040291DD RID: 168413
			[Token(Token = "0x40291DD")]
			[FieldOffset(Offset = "0x18")]
			private static readonly Vector2 RIGHT_END_POS;

			// Token: 0x040291DE RID: 168414
			[Token(Token = "0x40291DE")]
			[FieldOffset(Offset = "0x48")]
			private DeepSeaRPBattleStoryView m_closure;

			// Token: 0x040291DF RID: 168415
			[Token(Token = "0x40291DF")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x040291E0 RID: 168416
			[Token(Token = "0x40291E0")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfHide;

			// Token: 0x040291E1 RID: 168417
			[Token(Token = "0x40291E1")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfShow;

			// Token: 0x040291E2 RID: 168418
			[Token(Token = "0x40291E2")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_BeforeShowEffect;

			// Token: 0x040291E3 RID: 168419
			[Token(Token = "0x40291E3")]
			[FieldOffset(Offset = "0x40")]
			private static DelegateBridge __Hotfix0_AfterHideEffect;

			// Token: 0x040291E4 RID: 168420
			[Token(Token = "0x40291E4")]
			[FieldOffset(Offset = "0x48")]
			private static DelegateBridge __Hotfix0_ResetToState;
		}
	}
}
