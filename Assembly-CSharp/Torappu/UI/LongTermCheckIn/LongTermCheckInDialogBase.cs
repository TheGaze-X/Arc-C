using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.LongTermCheckIn
{
	// Token: 0x020049B5 RID: 18869
	[Token(Token = "0x20049B5")]
	public abstract class LongTermCheckInDialogBase : UISimpleCompDialog, IHotfixable
	{
		// Token: 0x0601C6DD RID: 116445 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C6DD")]
		[Address(RVA = "0x15E34D0", Offset = "0x15E20D0", VA = "0x1815E34D0", Slot = "9")]
		protected sealed override void OnInit()
		{
		}

		// Token: 0x0601C6DE RID: 116446 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C6DE")]
		[Address(RVA = "0x15E3470", Offset = "0x15E2070", VA = "0x1815E3470", Slot = "15")]
		protected sealed override UIRenderTextureImage GetBlurTarget()
		{
			return null;
		}

		// Token: 0x0601C6DF RID: 116447 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C6DF")]
		[Address(RVA = "0x15E3380", Offset = "0x15E1F80", VA = "0x1815E3380", Slot = "14")]
		public sealed override UISwitchTween GenerateShowTween()
		{
			return null;
		}

		// Token: 0x0601C6E0 RID: 116448
		[Token(Token = "0x601C6E0")]
		protected abstract void Init();

		// Token: 0x0601C6E1 RID: 116449
		[Token(Token = "0x601C6E1")]
		protected abstract void EventOnBackPressed();

		// Token: 0x0601C6E2 RID: 116450 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C6E2")]
		[Address(RVA = "0x15E3670", Offset = "0x15E2270", VA = "0x1815E3670")]
		protected LongTermCheckInDialogBase()
		{
		}

		// Token: 0x0601C6E3 RID: 116451 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C6E3")]
		[Address(RVA = "0xE613C0", Offset = "0xE5FFC0", VA = "0x180E613C0")]
		private void <>xLuaBaseProxy_OnInit()
		{
		}

		// Token: 0x0601C6E4 RID: 116452 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C6E4")]
		[Address(RVA = "0xE613B0", Offset = "0xE5FFB0", VA = "0x180E613B0")]
		private UIRenderTextureImage <>xLuaBaseProxy_GetBlurTarget()
		{
			return null;
		}

		// Token: 0x0601C6E5 RID: 116453 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C6E5")]
		[Address(RVA = "0xE0F010", Offset = "0xE0DC10", VA = "0x180E0F010")]
		private UISwitchTween <>xLuaBaseProxy_GenerateShowTween()
		{
			return null;
		}

		// Token: 0x040253E4 RID: 152548
		[Token(Token = "0x40253E4")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private RectTransform _backRt;

		// Token: 0x040253E5 RID: 152549
		[Token(Token = "0x40253E5")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private UIRenderTextureImage _blurBkg;

		// Token: 0x040253E6 RID: 152550
		[Token(Token = "0x40253E6")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		// Token: 0x040253E7 RID: 152551
		[Token(Token = "0x40253E7")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private UIAnimationLocation _enterAnim;

		// Token: 0x040253E8 RID: 152552
		[Token(Token = "0x40253E8")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private LongTermCheckInGroupView _groupView;

		// Token: 0x040253E9 RID: 152553
		[Token(Token = "0x40253E9")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private RectTransform _groupViewContainer;

		// Token: 0x040253EA RID: 152554
		[Token(Token = "0x40253EA")]
		[FieldOffset(Offset = "0xA8")]
		protected LongTermCheckInGroupView groupView;

		// Token: 0x040253EB RID: 152555
		[Token(Token = "0x40253EB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x040253EC RID: 152556
		[Token(Token = "0x40253EC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetBlurTarget;

		// Token: 0x040253ED RID: 152557
		[Token(Token = "0x40253ED")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GenerateShowTween;

		// Token: 0x040253EE RID: 152558
		[Token(Token = "0x40253EE")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020049B6 RID: 18870
		[Token(Token = "0x20049B6")]
		private class SwitchTween : UISwitchTween, IHotfixable
		{
			// Token: 0x0601C6E6 RID: 116454 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601C6E6")]
			[Address(RVA = "0x15F0DF0", Offset = "0x15EF9F0", VA = "0x1815F0DF0")]
			public SwitchTween(LongTermCheckInDialogBase closure)
			{
			}

			// Token: 0x0601C6E7 RID: 116455 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601C6E7")]
			[Address(RVA = "0x15F09B0", Offset = "0x15EF5B0", VA = "0x1815F09B0", Slot = "5")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfHide()
			{
				return null;
			}

			// Token: 0x0601C6E8 RID: 116456 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601C6E8")]
			[Address(RVA = "0x15F0AC0", Offset = "0x15EF6C0", VA = "0x1815F0AC0", Slot = "4")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfShow()
			{
				return null;
			}

			// Token: 0x0601C6E9 RID: 116457 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601C6E9")]
			[Address(RVA = "0x15F0CD0", Offset = "0x15EF8D0", VA = "0x1815F0CD0", Slot = "10")]
			protected override void ResetToState(bool isShow)
			{
			}

			// Token: 0x0601C6EA RID: 116458 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601C6EA")]
			[Address(RVA = "0x15F08E0", Offset = "0x15EF4E0", VA = "0x1815F08E0", Slot = "6")]
			protected override void BeforeShowEffect()
			{
			}

			// Token: 0x0601C6EB RID: 116459 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601C6EB")]
			[Address(RVA = "0x9B38B0", Offset = "0x9B24B0", VA = "0x1809B38B0")]
			private void <>xLuaBaseProxy_ResetToState(bool P0)
			{
			}

			// Token: 0x0601C6EC RID: 116460 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601C6EC")]
			[Address(RVA = "0xDFAF10", Offset = "0xDF9B10", VA = "0x180DFAF10")]
			private void <>xLuaBaseProxy_BeforeShowEffect()
			{
			}

			// Token: 0x040253EF RID: 152559
			[Token(Token = "0x40253EF")]
			[FieldOffset(Offset = "0x48")]
			private LongTermCheckInDialogBase m_closure;

			// Token: 0x040253F0 RID: 152560
			[Token(Token = "0x40253F0")]
			[FieldOffset(Offset = "0x50")]
			private float m_duration;

			// Token: 0x040253F1 RID: 152561
			[Token(Token = "0x40253F1")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x040253F2 RID: 152562
			[Token(Token = "0x40253F2")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfHide;

			// Token: 0x040253F3 RID: 152563
			[Token(Token = "0x40253F3")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfShow;

			// Token: 0x040253F4 RID: 152564
			[Token(Token = "0x40253F4")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_ResetToState;

			// Token: 0x040253F5 RID: 152565
			[Token(Token = "0x40253F5")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_BeforeShowEffect;
		}
	}
}
