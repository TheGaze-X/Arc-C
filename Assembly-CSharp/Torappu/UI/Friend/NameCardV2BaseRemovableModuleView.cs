using System;
using System.Runtime.CompilerServices;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Friend
{
	// Token: 0x02004E00 RID: 19968
	[Token(Token = "0x2004E00")]
	public abstract class NameCardV2BaseRemovableModuleView : NameCardV2BaseModuleView
	{
		// Token: 0x17004605 RID: 17925
		// (get) Token: 0x0601DD76 RID: 122230 RVA: 0x000AC7B8 File Offset: 0x000AA9B8
		[Token(Token = "0x17004605")]
		public float inRightPanelHeight
		{
			[Token(Token = "0x601DD76")]
			[Address(RVA = "0x1773510", Offset = "0x1772110", VA = "0x181773510")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17004606 RID: 17926
		// (get) Token: 0x0601DD77 RID: 122231 RVA: 0x000AC7D0 File Offset: 0x000AA9D0
		[Token(Token = "0x17004606")]
		public float inNameCardHeight
		{
			[Token(Token = "0x601DD77")]
			[Address(RVA = "0x1773470", Offset = "0x1772070", VA = "0x181773470")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17004607 RID: 17927
		// (get) Token: 0x0601DD78 RID: 122232 RVA: 0x000AC7E8 File Offset: 0x000AA9E8
		[Token(Token = "0x17004607")]
		public float tweenDuration
		{
			[Token(Token = "0x601DD78")]
			[Address(RVA = "0x17735B0", Offset = "0x17721B0", VA = "0x1817735B0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x0601DD79 RID: 122233 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DD79")]
		[Address(RVA = "0x1772EE0", Offset = "0x1771AE0", VA = "0x181772EE0")]
		public void SelectModule()
		{
		}

		// Token: 0x0601DD7A RID: 122234 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DD7A")]
		[Address(RVA = "0x17730C0", Offset = "0x1771CC0", VA = "0x1817730C0")]
		public void UnselectMoudle()
		{
		}

		// Token: 0x0601DD7B RID: 122235 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DD7B")]
		[Address(RVA = "0x1773000", Offset = "0x1771C00", VA = "0x181773000")]
		public void SetTweenHideOption(Action onHiden)
		{
		}

		// Token: 0x0601DD7C RID: 122236 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DD7C")]
		[Address(RVA = "0x1772D40", Offset = "0x1771940", VA = "0x181772D40")]
		public void PlaySelectTween(bool isShow, bool isInNameCard = false)
		{
		}

		// Token: 0x0601DD7D RID: 122237 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DD7D")]
		[Address(RVA = "0x1772E10", Offset = "0x1771A10", VA = "0x181772E10")]
		public void ResetSelectTween(bool isShow, bool isInNameCard = false)
		{
		}

		// Token: 0x0601DD7E RID: 122238 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DD7E")]
		[Address(RVA = "0x17731E0", Offset = "0x1771DE0", VA = "0x1817731E0")]
		private void _InitSelectTweenIfNot()
		{
		}

		// Token: 0x0601DD7F RID: 122239 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DD7F")]
		[Address(RVA = "0x1773390", Offset = "0x1771F90", VA = "0x181773390")]
		protected NameCardV2BaseRemovableModuleView()
		{
		}

		// Token: 0x040278A7 RID: 161959
		[Token(Token = "0x40278A7")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("Removable Module")]
		protected GameObject _unselectItem;

		// Token: 0x040278A8 RID: 161960
		[Token(Token = "0x40278A8")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("Removable Module")]
		protected GameObject _selectItem;

		// Token: 0x040278A9 RID: 161961
		[Token(Token = "0x40278A9")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Group("Removable Module")]
		protected Text _moduleName;

		// Token: 0x040278AA RID: 161962
		[Token(Token = "0x40278AA")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Group("Removable Module")]
		protected GameObject _moduleNameLayout;

		// Token: 0x040278AB RID: 161963
		[Token(Token = "0x40278AB")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		[Group("Select Tween")]
		private LayoutElement _moduleVirtualSize;

		// Token: 0x040278AC RID: 161964
		[Token(Token = "0x40278AC")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		[Group("Select Tween")]
		private LayoutElement _modulePartElement;

		// Token: 0x040278AD RID: 161965
		[Token(Token = "0x40278AD")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		[Group("Select Tween")]
		private RectTransform _moduleRealRect;

		// Token: 0x040278AE RID: 161966
		[Token(Token = "0x40278AE")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		[Group("Select Tween")]
		private CanvasGroup _moduleRealCanvasGroup;

		// Token: 0x040278AF RID: 161967
		[Token(Token = "0x40278AF")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		[Group("Select Tween")]
		private float _leftTweenDelta;

		// Token: 0x040278B0 RID: 161968
		[Token(Token = "0x40278B0")]
		[FieldOffset(Offset = "0x94")]
		[SerializeField]
		[Group("Select Tween")]
		private float _tweenDuration;

		// Token: 0x040278B1 RID: 161969
		[Token(Token = "0x40278B1")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		[Group("Select Tween")]
		private float _padding;

		// Token: 0x040278B2 RID: 161970
		[Token(Token = "0x40278B2")]
		[FieldOffset(Offset = "0x9C")]
		[SerializeField]
		[Group("Select Tween")]
		private float _nameLayoutHeight;

		// Token: 0x040278B3 RID: 161971
		[Token(Token = "0x40278B3")]
		[FieldOffset(Offset = "0xA0")]
		protected bool m_isSelected;

		// Token: 0x040278B4 RID: 161972
		[Token(Token = "0x40278B4")]
		[FieldOffset(Offset = "0xA8")]
		private NameCardV2BaseRemovableModuleView.SelectTween m_selectTween;

		// Token: 0x040278B5 RID: 161973
		[Token(Token = "0x40278B5")]
		[FieldOffset(Offset = "0xB0")]
		private bool m_hasSelectTweenInited;

		// Token: 0x040278B6 RID: 161974
		[Token(Token = "0x40278B6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_inRightPanelHeight;

		// Token: 0x040278B7 RID: 161975
		[Token(Token = "0x40278B7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_inNameCardHeight;

		// Token: 0x040278B8 RID: 161976
		[Token(Token = "0x40278B8")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_tweenDuration;

		// Token: 0x040278B9 RID: 161977
		[Token(Token = "0x40278B9")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_SelectModule;

		// Token: 0x040278BA RID: 161978
		[Token(Token = "0x40278BA")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_UnselectMoudle;

		// Token: 0x040278BB RID: 161979
		[Token(Token = "0x40278BB")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_SetTweenHideOption;

		// Token: 0x040278BC RID: 161980
		[Token(Token = "0x40278BC")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_PlaySelectTween;

		// Token: 0x040278BD RID: 161981
		[Token(Token = "0x40278BD")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_ResetSelectTween;

		// Token: 0x040278BE RID: 161982
		[Token(Token = "0x40278BE")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__InitSelectTweenIfNot;

		// Token: 0x040278BF RID: 161983
		[Token(Token = "0x40278BF")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004E01 RID: 19969
		[Token(Token = "0x2004E01")]
		private class SelectTween : UISwitchTween
		{
			// Token: 0x17004608 RID: 17928
			// (get) Token: 0x0601DD80 RID: 122240 RVA: 0x000AC800 File Offset: 0x000AAA00
			// (set) Token: 0x0601DD81 RID: 122241 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17004608")]
			public bool isInNameCard
			{
				[Token(Token = "0x601DD80")]
				[Address(RVA = "0x177DDC0", Offset = "0x177C9C0", VA = "0x18177DDC0")]
				[CompilerGenerated]
				private get
				{
					return default(bool);
				}
				[Token(Token = "0x601DD81")]
				[Address(RVA = "0x177DE20", Offset = "0x177CA20", VA = "0x18177DE20")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x0601DD82 RID: 122242 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601DD82")]
			[Address(RVA = "0x177DCB0", Offset = "0x177C8B0", VA = "0x18177DCB0")]
			public SelectTween(NameCardV2BaseRemovableModuleView view)
			{
			}

			// Token: 0x0601DD83 RID: 122243 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601DD83")]
			[Address(RVA = "0x177D510", Offset = "0x177C110", VA = "0x18177D510", Slot = "5")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfHide()
			{
				return null;
			}

			// Token: 0x0601DD84 RID: 122244 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601DD84")]
			[Address(RVA = "0x177D6E0", Offset = "0x177C2E0", VA = "0x18177D6E0", Slot = "4")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfShow()
			{
				return null;
			}

			// Token: 0x0601DD85 RID: 122245 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601DD85")]
			[Address(RVA = "0x177D8B0", Offset = "0x177C4B0", VA = "0x18177D8B0", Slot = "10")]
			protected override void ResetToState(bool isShow)
			{
			}

			// Token: 0x0601DD86 RID: 122246 RVA: 0x000AC818 File Offset: 0x000AAA18
			[Token(Token = "0x601DD86")]
			[Address(RVA = "0x177DAB0", Offset = "0x177C6B0", VA = "0x18177DAB0")]
			private float _GetValue()
			{
				return 0f;
			}

			// Token: 0x0601DD87 RID: 122247 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601DD87")]
			[Address(RVA = "0x177DB10", Offset = "0x177C710", VA = "0x18177DB10")]
			private void _SetValue(float value)
			{
			}

			// Token: 0x0601DD88 RID: 122248 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601DD88")]
			[Address(RVA = "0x9B38B0", Offset = "0x9B24B0", VA = "0x1809B38B0")]
			private void <>xLuaBaseProxy_ResetToState(bool P0)
			{
			}

			// Token: 0x040278C0 RID: 161984
			[Token(Token = "0x40278C0")]
			[FieldOffset(Offset = "0x48")]
			private NameCardV2BaseRemovableModuleView m_view;

			// Token: 0x040278C1 RID: 161985
			[Token(Token = "0x40278C1")]
			[FieldOffset(Offset = "0x50")]
			private float m_value;

			// Token: 0x040278C2 RID: 161986
			[Token(Token = "0x40278C2")]
			[FieldOffset(Offset = "0x54")]
			private float m_cachedInNameCardHeight;

			// Token: 0x040278C4 RID: 161988
			[Token(Token = "0x40278C4")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_isInNameCard;

			// Token: 0x040278C5 RID: 161989
			[Token(Token = "0x40278C5")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_set_isInNameCard;

			// Token: 0x040278C6 RID: 161990
			[Token(Token = "0x40278C6")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x040278C7 RID: 161991
			[Token(Token = "0x40278C7")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfHide;

			// Token: 0x040278C8 RID: 161992
			[Token(Token = "0x40278C8")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfShow;

			// Token: 0x040278C9 RID: 161993
			[Token(Token = "0x40278C9")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_ResetToState;

			// Token: 0x040278CA RID: 161994
			[Token(Token = "0x40278CA")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0__GetValue;

			// Token: 0x040278CB RID: 161995
			[Token(Token = "0x40278CB")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0__SetValue;
		}
	}
}
