using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using Torappu.Resource;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.DeepSeaRP
{
	// Token: 0x0200510C RID: 20748
	[Token(Token = "0x200510C")]
	public class DeepSeaRPBattleDetailView : DataBinder<DeepSeaRPBattleNodeDetailProperty>, IHotfixable
	{
		// Token: 0x0601EA33 RID: 125491 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EA33")]
		[Address(RVA = "0x184F6F0", Offset = "0x184E2F0", VA = "0x18184F6F0")]
		public void OnEnter()
		{
		}

		// Token: 0x0601EA34 RID: 125492 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EA34")]
		[Address(RVA = "0x184F770", Offset = "0x184E370", VA = "0x18184F770", Slot = "7")]
		public override void OnValueChanged(DeepSeaRPBattleNodeDetailProperty property)
		{
		}

		// Token: 0x0601EA35 RID: 125493 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EA35")]
		[Address(RVA = "0x184FB00", Offset = "0x184E700", VA = "0x18184FB00")]
		private void _LoadMapPreview(string stageId)
		{
		}

		// Token: 0x0601EA36 RID: 125494 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EA36")]
		[Address(RVA = "0x184FC80", Offset = "0x184E880", VA = "0x18184FC80")]
		private void _UnloadStagePreviewMap()
		{
		}

		// Token: 0x0601EA37 RID: 125495 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EA37")]
		[Address(RVA = "0x184F9E0", Offset = "0x184E5E0", VA = "0x18184F9E0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601EA38 RID: 125496 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EA38")]
		[Address(RVA = "0x184FD60", Offset = "0x184E960", VA = "0x18184FD60")]
		public DeepSeaRPBattleDetailView()
		{
		}

		// Token: 0x04029153 RID: 168275
		[Token(Token = "0x4029153")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _imgMapPreview;

		// Token: 0x04029154 RID: 168276
		[Token(Token = "0x4029154")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private CanvasGroup _selfCanvas;

		// Token: 0x04029155 RID: 168277
		[Token(Token = "0x4029155")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _mapDesc;

		// Token: 0x04029156 RID: 168278
		[Token(Token = "0x4029156")]
		[FieldOffset(Offset = "0x38")]
		private Sprite m_stagePreviewMap;

		// Token: 0x04029157 RID: 168279
		[Token(Token = "0x4029157")]
		[FieldOffset(Offset = "0x40")]
		private DirectAssetLoader m_stagePreviewMapLoader;

		// Token: 0x04029158 RID: 168280
		[Token(Token = "0x4029158")]
		[FieldOffset(Offset = "0x48")]
		private DeepSeaRPBattleDetailView.DetailViewSwitchTween m_switchTween;

		// Token: 0x04029159 RID: 168281
		[Token(Token = "0x4029159")]
		[FieldOffset(Offset = "0x50")]
		private bool m_isInited;

		// Token: 0x0402915A RID: 168282
		[Token(Token = "0x402915A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0402915B RID: 168283
		[Token(Token = "0x402915B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0402915C RID: 168284
		[Token(Token = "0x402915C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__LoadMapPreview;

		// Token: 0x0402915D RID: 168285
		[Token(Token = "0x402915D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__UnloadStagePreviewMap;

		// Token: 0x0402915E RID: 168286
		[Token(Token = "0x402915E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402915F RID: 168287
		[Token(Token = "0x402915F")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200510D RID: 20749
		[Token(Token = "0x200510D")]
		private class DetailViewSwitchTween : UISwitchTween
		{
			// Token: 0x0601EA39 RID: 125497 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601EA39")]
			[Address(RVA = "0x1860E90", Offset = "0x185FA90", VA = "0x181860E90")]
			public DetailViewSwitchTween(DeepSeaRPBattleDetailView closure)
			{
			}

			// Token: 0x0601EA3A RID: 125498 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601EA3A")]
			[Address(RVA = "0x18609F0", Offset = "0x185F5F0", VA = "0x1818609F0", Slot = "5")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfHide()
			{
				return null;
			}

			// Token: 0x0601EA3B RID: 125499 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601EA3B")]
			[Address(RVA = "0x1860740", Offset = "0x185F340", VA = "0x181860740", Slot = "9")]
			protected override void AfterHideEffect()
			{
			}

			// Token: 0x0601EA3C RID: 125500 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601EA3C")]
			[Address(RVA = "0x1860B80", Offset = "0x185F780", VA = "0x181860B80", Slot = "4")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfShow()
			{
				return null;
			}

			// Token: 0x0601EA3D RID: 125501 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601EA3D")]
			[Address(RVA = "0x1860870", Offset = "0x185F470", VA = "0x181860870", Slot = "8")]
			protected override void AfterShowEffect()
			{
			}

			// Token: 0x0601EA3E RID: 125502 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601EA3E")]
			[Address(RVA = "0x1860970", Offset = "0x185F570", VA = "0x181860970", Slot = "6")]
			protected override void BeforeShowEffect()
			{
			}

			// Token: 0x0601EA3F RID: 125503 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601EA3F")]
			[Address(RVA = "0x1860D00", Offset = "0x185F900", VA = "0x181860D00", Slot = "10")]
			protected override void ResetToState(bool isShow)
			{
			}

			// Token: 0x0601EA40 RID: 125504 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601EA40")]
			[Address(RVA = "0x9C2DA0", Offset = "0x9C19A0", VA = "0x1809C2DA0")]
			private void <>xLuaBaseProxy_AfterHideEffect()
			{
			}

			// Token: 0x0601EA41 RID: 125505 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601EA41")]
			[Address(RVA = "0xECEC90", Offset = "0xECD890", VA = "0x180ECEC90")]
			private void <>xLuaBaseProxy_AfterShowEffect()
			{
			}

			// Token: 0x0601EA42 RID: 125506 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601EA42")]
			[Address(RVA = "0xDFAF10", Offset = "0xDF9B10", VA = "0x180DFAF10")]
			private void <>xLuaBaseProxy_BeforeShowEffect()
			{
			}

			// Token: 0x0601EA43 RID: 125507 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601EA43")]
			[Address(RVA = "0x9B38B0", Offset = "0x9B24B0", VA = "0x1809B38B0")]
			private void <>xLuaBaseProxy_ResetToState(bool P0)
			{
			}

			// Token: 0x04029160 RID: 168288
			[Token(Token = "0x4029160")]
			private const float FADE_POS_Y = 30f;

			// Token: 0x04029161 RID: 168289
			[Token(Token = "0x4029161")]
			[FieldOffset(Offset = "0x48")]
			private DeepSeaRPBattleDetailView m_closure;

			// Token: 0x04029162 RID: 168290
			[Token(Token = "0x4029162")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04029163 RID: 168291
			[Token(Token = "0x4029163")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfHide;

			// Token: 0x04029164 RID: 168292
			[Token(Token = "0x4029164")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_AfterHideEffect;

			// Token: 0x04029165 RID: 168293
			[Token(Token = "0x4029165")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfShow;

			// Token: 0x04029166 RID: 168294
			[Token(Token = "0x4029166")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_AfterShowEffect;

			// Token: 0x04029167 RID: 168295
			[Token(Token = "0x4029167")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_BeforeShowEffect;

			// Token: 0x04029168 RID: 168296
			[Token(Token = "0x4029168")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_ResetToState;
		}
	}
}
