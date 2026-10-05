using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle;
using UnityEngine;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004305 RID: 17157
	[Token(Token = "0x2004305")]
	public class SandboxV2GainItemPage : UIPage, BattleUIBridge.IPauseBattlePage
	{
		// Token: 0x0601A5C2 RID: 107970 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A5C2")]
		[Address(RVA = "0x134BB50", Offset = "0x134A750", VA = "0x18134BB50", Slot = "12")]
		public override IEnumerator ShowCoroutine(bool isFromStack)
		{
			return null;
		}

		// Token: 0x0601A5C3 RID: 107971 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A5C3")]
		[Address(RVA = "0x134B630", Offset = "0x134A230", VA = "0x18134B630", Slot = "13")]
		protected override IEnumerator HideCoroutine(bool isIntoStack, bool isRemoveVirtualTop)
		{
			return null;
		}

		// Token: 0x0601A5C4 RID: 107972 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A5C4")]
		[Address(RVA = "0x134B710", Offset = "0x134A310", VA = "0x18134B710")]
		public void OnClick()
		{
		}

		// Token: 0x0601A5C5 RID: 107973 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A5C5")]
		[Address(RVA = "0x134B7E0", Offset = "0x134A3E0", VA = "0x18134B7E0")]
		private void OnRender(SandboxV2GainItemPage.Options options)
		{
		}

		// Token: 0x0601A5C6 RID: 107974 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A5C6")]
		[Address(RVA = "0x134BC10", Offset = "0x134A810", VA = "0x18134BC10")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601A5C7 RID: 107975 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A5C7")]
		[Address(RVA = "0x134BD30", Offset = "0x134A930", VA = "0x18134BD30")]
		private void _OnItemCardClick(int index)
		{
		}

		// Token: 0x0601A5C8 RID: 107976 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A5C8")]
		[Address(RVA = "0x134BE80", Offset = "0x134AA80", VA = "0x18134BE80")]
		private void _TutorialOnly_TryRaiseAVGSignal()
		{
		}

		// Token: 0x0601A5C9 RID: 107977 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A5C9")]
		[Address(RVA = "0x134BF10", Offset = "0x134AB10", VA = "0x18134BF10")]
		public SandboxV2GainItemPage()
		{
		}

		// Token: 0x0601A5CC RID: 107980 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A5CC")]
		[Address(RVA = "0xE987B0", Offset = "0xE973B0", VA = "0x180E987B0")]
		private IEnumerator <>xLuaBaseProxy_ShowCoroutine(bool P0)
		{
			return null;
		}

		// Token: 0x0601A5CD RID: 107981 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A5CD")]
		[Address(RVA = "0xE98760", Offset = "0xE97360", VA = "0x180E98760")]
		private IEnumerator <>xLuaBaseProxy_HideCoroutine(bool P0, bool P1)
		{
			return null;
		}

		// Token: 0x0402177E RID: 137086
		[Token(Token = "0x402177E")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private RectTransform _viewContainer;

		// Token: 0x0402177F RID: 137087
		[Token(Token = "0x402177F")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private RectTransform _backRt;

		// Token: 0x04021780 RID: 137088
		[Token(Token = "0x4021780")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private UIBlurFloatPanel _blurFloatPanel;

		// Token: 0x04021781 RID: 137089
		[Token(Token = "0x4021781")]
		[FieldOffset(Offset = "0xF0")]
		private SandboxV2GainItemView m_gainItemView;

		// Token: 0x04021782 RID: 137090
		[Token(Token = "0x4021782")]
		[FieldOffset(Offset = "0xF8")]
		private IList<UIItemViewModel> m_cachedItemModels;

		// Token: 0x04021783 RID: 137091
		[Token(Token = "0x4021783")]
		[FieldOffset(Offset = "0x100")]
		private bool m_showItemDetail;

		// Token: 0x04021784 RID: 137092
		[Token(Token = "0x4021784")]
		[FieldOffset(Offset = "0x108")]
		private Action m_cachedCallback;

		// Token: 0x04021785 RID: 137093
		[Token(Token = "0x4021785")]
		[FieldOffset(Offset = "0x110")]
		private bool m_hasInited;

		// Token: 0x04021786 RID: 137094
		[Token(Token = "0x4021786")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ShowCoroutine;

		// Token: 0x04021787 RID: 137095
		[Token(Token = "0x4021787")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_HideCoroutine;

		// Token: 0x04021788 RID: 137096
		[Token(Token = "0x4021788")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x04021789 RID: 137097
		[Token(Token = "0x4021789")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x0402178A RID: 137098
		[Token(Token = "0x402178A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402178B RID: 137099
		[Token(Token = "0x402178B")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnItemCardClick;

		// Token: 0x0402178C RID: 137100
		[Token(Token = "0x402178C")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__TutorialOnly_TryRaiseAVGSignal;

		// Token: 0x0402178D RID: 137101
		[Token(Token = "0x402178D")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004306 RID: 17158
		[Token(Token = "0x2004306")]
		public struct Options : IHotfixable
		{
			// Token: 0x17003E8C RID: 16012
			// (get) Token: 0x0601A5CE RID: 107982 RVA: 0x000A18F8 File Offset: 0x0009FAF8
			[Token(Token = "0x17003E8C")]
			public static SandboxV2GainItemPage.Options DEFAULT
			{
				[Token(Token = "0x601A5CE")]
				[Address(RVA = "0x1340080", Offset = "0x133EC80", VA = "0x181340080")]
				get
				{
					return default(SandboxV2GainItemPage.Options);
				}
			}

			// Token: 0x0402178E RID: 137102
			[Token(Token = "0x402178E")]
			[FieldOffset(Offset = "0x0")]
			public bool showItemDetail;

			// Token: 0x0402178F RID: 137103
			[Token(Token = "0x402178F")]
			[FieldOffset(Offset = "0x8")]
			public Action callback;

			// Token: 0x04021790 RID: 137104
			[Token(Token = "0x4021790")]
			[FieldOffset(Offset = "0x10")]
			public IList<UIItemViewModel> itemModels;

			// Token: 0x04021791 RID: 137105
			[Token(Token = "0x4021791")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_DEFAULT;
		}
	}
}
