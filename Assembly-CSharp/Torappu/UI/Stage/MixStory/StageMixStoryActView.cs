using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Stage.MixStory
{
	// Token: 0x02006A54 RID: 27220
	[Token(Token = "0x2006A54")]
	public class StageMixStoryActView : StageMixStoryLocationItem<StageStorylineStorySetLocationViewModel>
	{
		// Token: 0x06026E70 RID: 159344 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026E70")]
		[Address(RVA = "0x221ECF0", Offset = "0x221D8F0", VA = "0x18221ECF0")]
		public void OnClickEvent()
		{
		}

		// Token: 0x06026E71 RID: 159345 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026E71")]
		[Address(RVA = "0x221FE80", Offset = "0x221EA80", VA = "0x18221FE80")]
		private void _ToastLockedMsg(StageStorylineStorySetLocationViewModel location)
		{
		}

		// Token: 0x06026E72 RID: 159346 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026E72")]
		[Address(RVA = "0x221F1E0", Offset = "0x221DDE0", VA = "0x18221F1E0")]
		private void _OnClick(StageStorylineStorySetViewModel storySet)
		{
		}

		// Token: 0x06026E73 RID: 159347 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026E73")]
		[Address(RVA = "0x221F010", Offset = "0x221DC10", VA = "0x18221F010")]
		public void OnSetInfo(StageStorylineStorySetLocationViewModel storySetLocation, bool isClassified)
		{
		}

		// Token: 0x06026E74 RID: 159348 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026E74")]
		[Address(RVA = "0x221F940", Offset = "0x221E540", VA = "0x18221F940")]
		private void _Render(StageStorylineStorySetLocationViewModel storySetLocation, bool isClassified)
		{
		}

		// Token: 0x06026E75 RID: 159349 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026E75")]
		[Address(RVA = "0x221FC20", Offset = "0x221E820", VA = "0x18221FC20")]
		private void _SetTypePanelStatus()
		{
		}

		// Token: 0x06026E76 RID: 159350 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026E76")]
		[Address(RVA = "0x221F0D0", Offset = "0x221DCD0", VA = "0x18221F0D0")]
		private void _ClearIconViews()
		{
		}

		// Token: 0x06026E77 RID: 159351 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026E77")]
		[Address(RVA = "0x221F4F0", Offset = "0x221E0F0", VA = "0x18221F4F0")]
		private void _RenderIconViews()
		{
		}

		// Token: 0x06026E78 RID: 159352 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026E78")]
		[Address(RVA = "0x221F800", Offset = "0x221E400", VA = "0x18221F800")]
		private void _RenderPlugins()
		{
		}

		// Token: 0x06026E79 RID: 159353 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026E79")]
		[Address(RVA = "0x221F330", Offset = "0x221DF30", VA = "0x18221F330")]
		private void _RenderBlockStatus()
		{
		}

		// Token: 0x06026E7A RID: 159354 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026E7A")]
		[Address(RVA = "0x221FFA0", Offset = "0x221EBA0", VA = "0x18221FFA0")]
		public StageMixStoryActView()
		{
		}

		// Token: 0x0403704C RID: 225356
		[Token(Token = "0x403704C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _normalPanel;

		// Token: 0x0403704D RID: 225357
		[Token(Token = "0x403704D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _classifiedPanel;

		// Token: 0x0403704E RID: 225358
		[Token(Token = "0x403704E")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private List<StageMixStoryActView.TypePanel> _typePanels;

		// Token: 0x0403704F RID: 225359
		[Token(Token = "0x403704F")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private List<StageMixStoryActView.PluginContainer> _pluginContainers;

		// Token: 0x04037050 RID: 225360
		[Token(Token = "0x4037050")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private List<StageMixStoryStorySetCommonIconView> _iconViews;

		// Token: 0x04037051 RID: 225361
		[Token(Token = "0x4037051")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Image _ssKvImage;

		// Token: 0x04037052 RID: 225362
		[Token(Token = "0x4037052")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Color _ssKvInvalidColor;

		// Token: 0x04037053 RID: 225363
		[Token(Token = "0x4037053")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private float _mainlineWidth;

		// Token: 0x04037054 RID: 225364
		[Token(Token = "0x4037054")]
		[FieldOffset(Offset = "0x64")]
		[SerializeField]
		private float _ssWidth;

		// Token: 0x04037055 RID: 225365
		[Token(Token = "0x4037055")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float _collectWidth;

		// Token: 0x04037056 RID: 225366
		[Token(Token = "0x4037056")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private UIAnimationLocation _validBlockAnimation;

		// Token: 0x04037057 RID: 225367
		[Token(Token = "0x4037057")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private UIAnimationLocation _invalidBlockAnimation;

		// Token: 0x04037058 RID: 225368
		[Token(Token = "0x4037058")]
		[FieldOffset(Offset = "0x90")]
		private UIStateFinder m_finder;

		// Token: 0x04037059 RID: 225369
		[Token(Token = "0x4037059")]
		[FieldOffset(Offset = "0xA0")]
		private StageStorylineStorySetLocationViewModel m_cachedModel;

		// Token: 0x0403705A RID: 225370
		[Token(Token = "0x403705A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnClickEvent;

		// Token: 0x0403705B RID: 225371
		[Token(Token = "0x403705B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__ToastLockedMsg;

		// Token: 0x0403705C RID: 225372
		[Token(Token = "0x403705C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__OnClick;

		// Token: 0x0403705D RID: 225373
		[Token(Token = "0x403705D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnSetInfo;

		// Token: 0x0403705E RID: 225374
		[Token(Token = "0x403705E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__Render;

		// Token: 0x0403705F RID: 225375
		[Token(Token = "0x403705F")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__SetTypePanelStatus;

		// Token: 0x04037060 RID: 225376
		[Token(Token = "0x4037060")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__ClearIconViews;

		// Token: 0x04037061 RID: 225377
		[Token(Token = "0x4037061")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__RenderIconViews;

		// Token: 0x04037062 RID: 225378
		[Token(Token = "0x4037062")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__RenderPlugins;

		// Token: 0x04037063 RID: 225379
		[Token(Token = "0x4037063")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__RenderBlockStatus;

		// Token: 0x04037064 RID: 225380
		[Token(Token = "0x4037064")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006A55 RID: 27221
		[Token(Token = "0x2006A55")]
		[Serializable]
		private struct TypePanel
		{
			// Token: 0x04037065 RID: 225381
			[Token(Token = "0x4037065")]
			[FieldOffset(Offset = "0x0")]
			public List<StorylineStorySetType> matches;

			// Token: 0x04037066 RID: 225382
			[Token(Token = "0x4037066")]
			[FieldOffset(Offset = "0x8")]
			public GameObject panel;
		}

		// Token: 0x02006A56 RID: 27222
		[Token(Token = "0x2006A56")]
		[Serializable]
		private class PluginContainer : IHotfixable
		{
			// Token: 0x06026E7B RID: 159355 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6026E7B")]
			[Address(RVA = "0x221E070", Offset = "0x221CC70", VA = "0x18221E070")]
			public void Render(StageStorylineStorySetViewModel model)
			{
			}

			// Token: 0x06026E7C RID: 159356 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6026E7C")]
			[Address(RVA = "0x221E200", Offset = "0x221CE00", VA = "0x18221E200")]
			public PluginContainer()
			{
			}

			// Token: 0x04037067 RID: 225383
			[Token(Token = "0x4037067")]
			[FieldOffset(Offset = "0x10")]
			public StageMixStoryStorylineItemPlugin prefab;

			// Token: 0x04037068 RID: 225384
			[Token(Token = "0x4037068")]
			[FieldOffset(Offset = "0x18")]
			public Transform container;

			// Token: 0x04037069 RID: 225385
			[Token(Token = "0x4037069")]
			[FieldOffset(Offset = "0x20")]
			private StageMixStoryStorylineItemPlugin m_instance;

			// Token: 0x0403706A RID: 225386
			[Token(Token = "0x403706A")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_Render;

			// Token: 0x0403706B RID: 225387
			[Token(Token = "0x403706B")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02006A57 RID: 27223
		[Token(Token = "0x2006A57")]
		public class VirtualView : StageMixStoryLocationVirtualView<StageMixStoryActView, StageStorylineStorySetLocationViewModel>
		{
			// Token: 0x06026E7D RID: 159357 RVA: 0x000CCA38 File Offset: 0x000CAC38
			[Token(Token = "0x6026E7D")]
			[Address(RVA = "0x22305D0", Offset = "0x222F1D0", VA = "0x1822305D0", Slot = "13")]
			public override float GetPreferSize()
			{
				return 0f;
			}

			// Token: 0x06026E7E RID: 159358 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6026E7E")]
			[Address(RVA = "0x2230870", Offset = "0x222F470", VA = "0x182230870", Slot = "10")]
			protected override void OnViewAttached()
			{
			}

			// Token: 0x06026E7F RID: 159359 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6026E7F")]
			[Address(RVA = "0x2230B00", Offset = "0x222F700", VA = "0x182230B00")]
			public VirtualView()
			{
			}

			// Token: 0x0403706C RID: 225388
			[Token(Token = "0x403706C")]
			[FieldOffset(Offset = "0x30")]
			public bool isClassified;

			// Token: 0x0403706D RID: 225389
			[Token(Token = "0x403706D")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_GetPreferSize;

			// Token: 0x0403706E RID: 225390
			[Token(Token = "0x403706E")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OnViewAttached;

			// Token: 0x0403706F RID: 225391
			[Token(Token = "0x403706F")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
