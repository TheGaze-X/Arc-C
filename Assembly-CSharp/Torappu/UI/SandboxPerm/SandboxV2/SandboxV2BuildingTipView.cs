using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004119 RID: 16665
	[Token(Token = "0x2004119")]
	public class SandboxV2BuildingTipView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06019C0E RID: 105486 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019C0E")]
		[Address(RVA = "0x1296FC0", Offset = "0x1295BC0", VA = "0x181296FC0")]
		public void Render(SandboxV2BuildingTipView.Param param)
		{
		}

		// Token: 0x06019C0F RID: 105487 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019C0F")]
		[Address(RVA = "0x12973E0", Offset = "0x1295FE0", VA = "0x1812973E0")]
		private void _SetIcons(SandboxV2ConstructTipType tipType)
		{
		}

		// Token: 0x06019C10 RID: 105488 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019C10")]
		[Address(RVA = "0x12974E0", Offset = "0x12960E0", VA = "0x1812974E0")]
		private void _SetTipText(SandboxV2ConstructTipType tipType, string nodeTypeName)
		{
		}

		// Token: 0x06019C11 RID: 105489 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019C11")]
		[Address(RVA = "0x1296F50", Offset = "0x1295B50", VA = "0x181296F50")]
		public void OnClicked()
		{
		}

		// Token: 0x06019C12 RID: 105490 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019C12")]
		[Address(RVA = "0x12976A0", Offset = "0x12962A0", VA = "0x1812976A0")]
		public SandboxV2BuildingTipView()
		{
		}

		// Token: 0x04020462 RID: 132194
		[Token(Token = "0x4020462")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _noticeInfo;

		// Token: 0x04020463 RID: 132195
		[Token(Token = "0x4020463")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _noticeCount;

		// Token: 0x04020464 RID: 132196
		[Token(Token = "0x4020464")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIAtlasImage _bkgImage;

		// Token: 0x04020465 RID: 132197
		[Token(Token = "0x4020465")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UIAtlasImage _imgSevereDamaged;

		// Token: 0x04020466 RID: 132198
		[Token(Token = "0x4020466")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UIAtlasImage _imgBuildingDamaged;

		// Token: 0x04020467 RID: 132199
		[Token(Token = "0x4020467")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UIAtlasImage _imgBuildingCanUpgrade;

		// Token: 0x04020468 RID: 132200
		[Token(Token = "0x4020468")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Color[] _foregroundSelectedColors;

		// Token: 0x04020469 RID: 132201
		[Token(Token = "0x4020469")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Color[] _foregroundUnselectedColors;

		// Token: 0x0402046A RID: 132202
		[Token(Token = "0x402046A")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Color[] _bkgSelectedColors;

		// Token: 0x0402046B RID: 132203
		[Token(Token = "0x402046B")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Color[] _bkgUnselectedColors;

		// Token: 0x0402046C RID: 132204
		[Token(Token = "0x402046C")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		// Token: 0x0402046D RID: 132205
		[Token(Token = "0x402046D")]
		[FieldOffset(Offset = "0x70")]
		private SandboxV2ConstructTipType m_cachedTipType;

		// Token: 0x0402046E RID: 132206
		[Token(Token = "0x402046E")]
		[FieldOffset(Offset = "0x78")]
		private Action<SandboxV2ConstructTipType> m_onClicked;

		// Token: 0x0402046F RID: 132207
		[Token(Token = "0x402046F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04020470 RID: 132208
		[Token(Token = "0x4020470")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__SetIcons;

		// Token: 0x04020471 RID: 132209
		[Token(Token = "0x4020471")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__SetTipText;

		// Token: 0x04020472 RID: 132210
		[Token(Token = "0x4020472")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnClicked;

		// Token: 0x04020473 RID: 132211
		[Token(Token = "0x4020473")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200411A RID: 16666
		[Token(Token = "0x200411A")]
		public class Param
		{
			// Token: 0x06019C13 RID: 105491 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6019C13")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Param()
			{
			}

			// Token: 0x04020474 RID: 132212
			[Token(Token = "0x4020474")]
			[FieldOffset(Offset = "0x10")]
			public SandboxV2BuildingTipView prefab;

			// Token: 0x04020475 RID: 132213
			[Token(Token = "0x4020475")]
			[FieldOffset(Offset = "0x18")]
			public SandboxV2ConstructTipType tipType;

			// Token: 0x04020476 RID: 132214
			[Token(Token = "0x4020476")]
			[FieldOffset(Offset = "0x1C")]
			public int tipCount;

			// Token: 0x04020477 RID: 132215
			[Token(Token = "0x4020477")]
			[FieldOffset(Offset = "0x20")]
			public bool tipSelected;

			// Token: 0x04020478 RID: 132216
			[Token(Token = "0x4020478")]
			[FieldOffset(Offset = "0x24")]
			public float preferredHeight;

			// Token: 0x04020479 RID: 132217
			[Token(Token = "0x4020479")]
			[FieldOffset(Offset = "0x28")]
			public Action<SandboxV2ConstructTipType> onClicked;

			// Token: 0x0402047A RID: 132218
			[Token(Token = "0x402047A")]
			[FieldOffset(Offset = "0x30")]
			public string nodeTypeName;
		}

		// Token: 0x0200411B RID: 16667
		[Token(Token = "0x200411B")]
		public class VirtualView : UIRecycleLayoutAdapter.VirtualView<SandboxV2BuildingTipView>
		{
			// Token: 0x06019C14 RID: 105492 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6019C14")]
			[Address(RVA = "0x12A03E0", Offset = "0x129EFE0", VA = "0x1812A03E0")]
			public VirtualView(SandboxV2BuildingTipView.Param param)
			{
			}

			// Token: 0x06019C15 RID: 105493 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6019C15")]
			[Address(RVA = "0x12A01D0", Offset = "0x129EDD0", VA = "0x1812A01D0", Slot = "10")]
			protected override void OnViewAttached()
			{
			}

			// Token: 0x06019C16 RID: 105494 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6019C16")]
			[Address(RVA = "0x12A0320", Offset = "0x129EF20", VA = "0x1812A0320", Slot = "11")]
			protected override void OnViewDetached()
			{
			}

			// Token: 0x06019C17 RID: 105495 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6019C17")]
			[Address(RVA = "0x12A0070", Offset = "0x129EC70", VA = "0x1812A0070", Slot = "12")]
			public override GameObject GetPrefab()
			{
				return null;
			}

			// Token: 0x06019C18 RID: 105496 RVA: 0x0009F4F8 File Offset: 0x0009D6F8
			[Token(Token = "0x6019C18")]
			[Address(RVA = "0x12A0160", Offset = "0x129ED60", VA = "0x1812A0160", Slot = "13")]
			public override float GetPreferSize()
			{
				return 0f;
			}

			// Token: 0x0402047B RID: 132219
			[Token(Token = "0x402047B")]
			[FieldOffset(Offset = "0x20")]
			private SandboxV2BuildingTipView.Param m_param;

			// Token: 0x0402047C RID: 132220
			[Token(Token = "0x402047C")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402047D RID: 132221
			[Token(Token = "0x402047D")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OnViewAttached;

			// Token: 0x0402047E RID: 132222
			[Token(Token = "0x402047E")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_OnViewDetached;

			// Token: 0x0402047F RID: 132223
			[Token(Token = "0x402047F")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_GetPrefab;

			// Token: 0x04020480 RID: 132224
			[Token(Token = "0x4020480")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_GetPreferSize;
		}
	}
}
