using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.TemplateCharSelect
{
	// Token: 0x02005BF3 RID: 23539
	[Token(Token = "0x2005BF3")]
	public class TemplateCharSelectController : MonoBehaviour, ITemplateCharSelectCtrl, IHotfixable
	{
		// Token: 0x060221F3 RID: 139763 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60221F3")]
		[Address(RVA = "0x1C9B920", Offset = "0x1C9A520", VA = "0x181C9B920")]
		public void TriggerResume()
		{
		}

		// Token: 0x060221F4 RID: 139764 RVA: 0x000BC610 File Offset: 0x000BA810
		[Token(Token = "0x60221F4")]
		[Address(RVA = "0x1C9BBC0", Offset = "0x1C9A7C0", VA = "0x181C9BBC0")]
		public bool TryInitTemplateCharController(TemplateCharSelectController.InputParam inputParam, ITemplateCharSelectCtrlHost host, ITemplateCharSelectCustomization resHolder)
		{
			return default(bool);
		}

		// Token: 0x060221F5 RID: 139765 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60221F5")]
		[Address(RVA = "0x1C9C730", Offset = "0x1C9B330", VA = "0x181C9C730")]
		private void _TryInitPlugin(TemplateCharSelectController.InputParam inputParam, ITemplateCharSelectCtrlHost host)
		{
		}

		// Token: 0x060221F6 RID: 139766 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60221F6")]
		[Address(RVA = "0x1C9AB90", Offset = "0x1C99790", VA = "0x181C9AB90")]
		public void ApplySelectInput(TemplateCharSelectController.InputParam inputParam)
		{
		}

		// Token: 0x060221F7 RID: 139767 RVA: 0x000BC628 File Offset: 0x000BA828
		[Token(Token = "0x60221F7")]
		[Address(RVA = "0x1C9C520", Offset = "0x1C9B120", VA = "0x181C9C520")]
		private bool _CheckPropValid()
		{
			return default(bool);
		}

		// Token: 0x17004FE1 RID: 20449
		// (get) Token: 0x060221F8 RID: 139768 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004FE1")]
		public TemplateCharSelectCardView charCardPrefab
		{
			[Token(Token = "0x60221F8")]
			[Address(RVA = "0x1C9C990", Offset = "0x1C9B590", VA = "0x181C9C990", Slot = "11")]
			get
			{
				return null;
			}
		}

		// Token: 0x060221F9 RID: 139769 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60221F9")]
		[Address(RVA = "0x1C9B0D0", Offset = "0x1C99CD0", VA = "0x181C9B0D0", Slot = "4")]
		public void OnCharClick(int instId)
		{
		}

		// Token: 0x060221FA RID: 139770 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60221FA")]
		[Address(RVA = "0x1C9B540", Offset = "0x1C9A140", VA = "0x181C9B540", Slot = "5")]
		public void OnEnsureClick()
		{
		}

		// Token: 0x060221FB RID: 139771 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60221FB")]
		[Address(RVA = "0x1C9C660", Offset = "0x1C9B260", VA = "0x181C9C660")]
		private void _OnEnsure()
		{
		}

		// Token: 0x060221FC RID: 139772 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60221FC")]
		[Address(RVA = "0x1C9B3C0", Offset = "0x1C99FC0", VA = "0x181C9B3C0", Slot = "7")]
		public void OnClearClick()
		{
		}

		// Token: 0x060221FD RID: 139773 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60221FD")]
		[Address(RVA = "0x1C9B700", Offset = "0x1C9A300", VA = "0x181C9B700", Slot = "8")]
		public void OnSetCharAttribute(TemplateCharSelectCardViewModel targetChar, int key, ValueBundle value)
		{
		}

		// Token: 0x060221FE RID: 139774 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60221FE")]
		[Address(RVA = "0x1C9AEA0", Offset = "0x1C99AA0", VA = "0x181C9AEA0", Slot = "9")]
		public void NotifyUpdate()
		{
		}

		// Token: 0x060221FF RID: 139775 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60221FF")]
		[Address(RVA = "0x1C9ACC0", Offset = "0x1C998C0", VA = "0x181C9ACC0", Slot = "10")]
		public void NotifyShuffleUpdate()
		{
		}

		// Token: 0x06022200 RID: 139776 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022200")]
		[Address(RVA = "0x1C9AF60", Offset = "0x1C99B60", VA = "0x181C9AF60", Slot = "6")]
		public void OnCancelClick()
		{
		}

		// Token: 0x06022201 RID: 139777 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022201")]
		[Address(RVA = "0x1C9C5E0", Offset = "0x1C9B1E0", VA = "0x181C9C5E0")]
		private void _OnCancel()
		{
		}

		// Token: 0x06022202 RID: 139778 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022202")]
		[Address(RVA = "0x1C9B7F0", Offset = "0x1C9A3F0", VA = "0x181C9B7F0")]
		public void RegisterTutorialGO()
		{
		}

		// Token: 0x06022203 RID: 139779 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022203")]
		[Address(RVA = "0x1C9C930", Offset = "0x1C9B530", VA = "0x181C9C930")]
		public TemplateCharSelectController()
		{
		}

		// Token: 0x0402EC90 RID: 191632
		[Token(Token = "0x402EC90")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform _poolViewContainer;

		// Token: 0x0402EC91 RID: 191633
		[Token(Token = "0x402EC91")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform _shuffleViewContainer;

		// Token: 0x0402EC92 RID: 191634
		[Token(Token = "0x402EC92")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform _ensureContainer;

		// Token: 0x0402EC93 RID: 191635
		[Token(Token = "0x402EC93")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Transform _customTopMenuContainer;

		// Token: 0x0402EC94 RID: 191636
		[Token(Token = "0x402EC94")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Transform _detailContainer;

		// Token: 0x0402EC95 RID: 191637
		[Token(Token = "0x402EC95")]
		[FieldOffset(Offset = "0x40")]
		private TemplateCharSelectCardView m_charCardPrefab;

		// Token: 0x0402EC96 RID: 191638
		[Token(Token = "0x402EC96")]
		[FieldOffset(Offset = "0x48")]
		private TemplateCharSelectPoolView m_poolView;

		// Token: 0x0402EC97 RID: 191639
		[Token(Token = "0x402EC97")]
		[FieldOffset(Offset = "0x50")]
		private TemplateCharSelectDetailView m_detailView;

		// Token: 0x0402EC98 RID: 191640
		[Token(Token = "0x402EC98")]
		[FieldOffset(Offset = "0x58")]
		private TemplateCharSelectShuffleView m_shuffleView;

		// Token: 0x0402EC99 RID: 191641
		[Token(Token = "0x402EC99")]
		[FieldOffset(Offset = "0x60")]
		private TemplateCharSelectEnsureView m_ensureView;

		// Token: 0x0402EC9A RID: 191642
		[Token(Token = "0x402EC9A")]
		[FieldOffset(Offset = "0x68")]
		private TemplateCharSelectTopMenuView m_topMenuView;

		// Token: 0x0402EC9B RID: 191643
		[Token(Token = "0x402EC9B")]
		[FieldOffset(Offset = "0x70")]
		private List<TemplateCharSelectSubViewBase> m_views;

		// Token: 0x0402EC9C RID: 191644
		[Token(Token = "0x402EC9C")]
		[FieldOffset(Offset = "0x78")]
		private ITemplateCharSelectPlugin m_plugin;

		// Token: 0x0402EC9D RID: 191645
		[Token(Token = "0x402EC9D")]
		[FieldOffset(Offset = "0x80")]
		private ITemplateCharSelectCtrlHost m_host;

		// Token: 0x0402EC9E RID: 191646
		[Token(Token = "0x402EC9E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_TriggerResume;

		// Token: 0x0402EC9F RID: 191647
		[Token(Token = "0x402EC9F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_TryInitTemplateCharController;

		// Token: 0x0402ECA0 RID: 191648
		[Token(Token = "0x402ECA0")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__TryInitPlugin;

		// Token: 0x0402ECA1 RID: 191649
		[Token(Token = "0x402ECA1")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_ApplySelectInput;

		// Token: 0x0402ECA2 RID: 191650
		[Token(Token = "0x402ECA2")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__CheckPropValid;

		// Token: 0x0402ECA3 RID: 191651
		[Token(Token = "0x402ECA3")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_charCardPrefab;

		// Token: 0x0402ECA4 RID: 191652
		[Token(Token = "0x402ECA4")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnCharClick;

		// Token: 0x0402ECA5 RID: 191653
		[Token(Token = "0x402ECA5")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnEnsureClick;

		// Token: 0x0402ECA6 RID: 191654
		[Token(Token = "0x402ECA6")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__OnEnsure;

		// Token: 0x0402ECA7 RID: 191655
		[Token(Token = "0x402ECA7")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnClearClick;

		// Token: 0x0402ECA8 RID: 191656
		[Token(Token = "0x402ECA8")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnSetCharAttribute;

		// Token: 0x0402ECA9 RID: 191657
		[Token(Token = "0x402ECA9")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_NotifyUpdate;

		// Token: 0x0402ECAA RID: 191658
		[Token(Token = "0x402ECAA")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_NotifyShuffleUpdate;

		// Token: 0x0402ECAB RID: 191659
		[Token(Token = "0x402ECAB")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_OnCancelClick;

		// Token: 0x0402ECAC RID: 191660
		[Token(Token = "0x402ECAC")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__OnCancel;

		// Token: 0x0402ECAD RID: 191661
		[Token(Token = "0x402ECAD")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_RegisterTutorialGO;

		// Token: 0x0402ECAE RID: 191662
		[Token(Token = "0x402ECAE")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005BF4 RID: 23540
		[Token(Token = "0x2005BF4")]
		public class InputParam
		{
			// Token: 0x17004FE2 RID: 20450
			// (get) Token: 0x06022204 RID: 139780 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06022205 RID: 139781 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17004FE2")]
			public Type pluginType
			{
				[Token(Token = "0x6022204")]
				[Address(RVA = "0x4EA8A0", Offset = "0x4E94A0", VA = "0x1804EA8A0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6022205")]
				[Address(RVA = "0x4EAC30", Offset = "0x4E9830", VA = "0x1804EAC30")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x06022206 RID: 139782 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6022206")]
			public void BindPlugin<T>() where T : ITemplateCharSelectPlugin
			{
			}

			// Token: 0x06022207 RID: 139783 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6022207")]
			[Address(RVA = "0x1C96DC0", Offset = "0x1C959C0", VA = "0x181C96DC0")]
			public InputParam()
			{
			}

			// Token: 0x0402ECAF RID: 191663
			[Token(Token = "0x402ECAF")]
			[FieldOffset(Offset = "0x10")]
			public string actId;

			// Token: 0x0402ECB0 RID: 191664
			[Token(Token = "0x402ECB0")]
			[FieldOffset(Offset = "0x18")]
			public TemplateCharSelectMode mode;

			// Token: 0x0402ECB1 RID: 191665
			[Token(Token = "0x402ECB1")]
			[FieldOffset(Offset = "0x20")]
			public List<TemplateCharSelectCharInputData> alreadySelectList;

			// Token: 0x0402ECB2 RID: 191666
			[Token(Token = "0x402ECB2")]
			[FieldOffset(Offset = "0x28")]
			public int maxSelectCount;

			// Token: 0x0402ECB4 RID: 191668
			[Token(Token = "0x402ECB4")]
			[FieldOffset(Offset = "0x38")]
			public int singleTargetInstId;

			// Token: 0x0402ECB5 RID: 191669
			[Token(Token = "0x402ECB5")]
			[FieldOffset(Offset = "0x40")]
			public Action<TemplateCharSelectController.InputParam> OnFull;

			// Token: 0x0402ECB6 RID: 191670
			[Token(Token = "0x402ECB6")]
			[FieldOffset(Offset = "0x48")]
			public bool needScroll;

			// Token: 0x0402ECB7 RID: 191671
			[Token(Token = "0x402ECB7")]
			[FieldOffset(Offset = "0x50")]
			public List<int> blackList;

			// Token: 0x0402ECB8 RID: 191672
			[Token(Token = "0x402ECB8")]
			[FieldOffset(Offset = "0x58")]
			public bool synCharWithPlayerData;

			// Token: 0x0402ECB9 RID: 191673
			[Token(Token = "0x402ECB9")]
			[FieldOffset(Offset = "0x59")]
			public bool hasTopMenuInState;

			// Token: 0x0402ECBA RID: 191674
			[Token(Token = "0x402ECBA")]
			[FieldOffset(Offset = "0x60")]
			public List<CharacterSortTypePair> customSortTypePairs;

			// Token: 0x0402ECBB RID: 191675
			[Token(Token = "0x402ECBB")]
			[FieldOffset(Offset = "0x68")]
			public TemplateCharSelectController.TemplateCustomInput customInput;
		}

		// Token: 0x02005BF5 RID: 23541
		[Token(Token = "0x2005BF5")]
		public abstract class TemplateCustomInput
		{
			// Token: 0x06022208 RID: 139784 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6022208")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			protected TemplateCustomInput()
			{
			}
		}
	}
}
