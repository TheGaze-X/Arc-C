using System;
using System.Collections.Generic;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Stage.MixStory
{
	// Token: 0x02006A90 RID: 27280
	[Token(Token = "0x2006A90")]
	public class StageMixStoryOverallGroupItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06027079 RID: 159865 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027079")]
		[Address(RVA = "0x2240310", Offset = "0x223EF10", VA = "0x182240310")]
		public void OnItemClickEvent()
		{
		}

		// Token: 0x0602707A RID: 159866 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602707A")]
		[Address(RVA = "0x2240420", Offset = "0x223F020", VA = "0x182240420")]
		public void Render(StageStorylineStorySetViewModel model, StageMixStoryOverallItemStateHandler itemStateHandler)
		{
		}

		// Token: 0x0602707B RID: 159867 RVA: 0x000CD500 File Offset: 0x000CB700
		[Token(Token = "0x602707B")]
		[Address(RVA = "0x2240270", Offset = "0x223EE70", VA = "0x182240270")]
		public float GetWidthOfType(StorylineStorySetType type)
		{
			return 0f;
		}

		// Token: 0x0602707C RID: 159868 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602707C")]
		[Address(RVA = "0x2240C20", Offset = "0x223F820", VA = "0x182240C20")]
		private void _InitIfNeed()
		{
		}

		// Token: 0x0602707D RID: 159869 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602707D")]
		[Address(RVA = "0x2240B20", Offset = "0x223F720", VA = "0x182240B20")]
		private void _FitSizeWithType()
		{
		}

		// Token: 0x0602707E RID: 159870 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602707E")]
		[Address(RVA = "0x2241020", Offset = "0x223FC20", VA = "0x182241020")]
		private void _SetTypePanelStatus()
		{
		}

		// Token: 0x0602707F RID: 159871 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602707F")]
		[Address(RVA = "0x2240DF0", Offset = "0x223F9F0", VA = "0x182240DF0")]
		private void _RenderIconViews()
		{
		}

		// Token: 0x06027080 RID: 159872 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027080")]
		[Address(RVA = "0x2240CC0", Offset = "0x223F8C0", VA = "0x182240CC0")]
		private void _RenderFeaturePanels(StageMixStoryOverallItemStateHandler itemStateHandler)
		{
		}

		// Token: 0x06027081 RID: 159873 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027081")]
		[Address(RVA = "0x2240F30", Offset = "0x223FB30", VA = "0x182240F30")]
		private void _RenderPluginContainers(StageMixStoryOverallItemStateHandler itemStateHandler)
		{
		}

		// Token: 0x06027082 RID: 159874 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027082")]
		[Address(RVA = "0x2241200", Offset = "0x223FE00", VA = "0x182241200")]
		public StageMixStoryOverallGroupItemView()
		{
		}

		// Token: 0x0403738B RID: 226187
		[Token(Token = "0x403738B")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIAnimationLocation _validDarkenAnimation;

		// Token: 0x0403738C RID: 226188
		[Token(Token = "0x403738C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIAnimationLocation _invalidDarkAnimation;

		// Token: 0x0403738D RID: 226189
		[Token(Token = "0x403738D")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private List<StageMixStoryOverallGroupItemView.TypePanel> _typePanels;

		// Token: 0x0403738E RID: 226190
		[Token(Token = "0x403738E")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private List<StageMixStoryStorySetCommonIconView> _iconViews;

		// Token: 0x0403738F RID: 226191
		[Token(Token = "0x403738F")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private List<StageMixStoryOverallGroupItemView.FeaturePanel> _featurePanels;

		// Token: 0x04037390 RID: 226192
		[Token(Token = "0x4037390")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private List<StageMixStoryOverallGroupItemView.PluginContainer> _pluginContainers;

		// Token: 0x04037391 RID: 226193
		[Token(Token = "0x4037391")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private float _mainlineWidth;

		// Token: 0x04037392 RID: 226194
		[Token(Token = "0x4037392")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private float _ssWidth;

		// Token: 0x04037393 RID: 226195
		[Token(Token = "0x4037393")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private float _collectWidth;

		// Token: 0x04037394 RID: 226196
		[Token(Token = "0x4037394")]
		[FieldOffset(Offset = "0x64")]
		private bool m_hasInited;

		// Token: 0x04037395 RID: 226197
		[Token(Token = "0x4037395")]
		[FieldOffset(Offset = "0x68")]
		private UIStateFinder m_stateFinder;

		// Token: 0x04037396 RID: 226198
		[Token(Token = "0x4037396")]
		[FieldOffset(Offset = "0x78")]
		private ILoadAsset m_iLoadAsset;

		// Token: 0x04037397 RID: 226199
		[Token(Token = "0x4037397")]
		[FieldOffset(Offset = "0x80")]
		private StageStorylineStorySetViewModel m_cachedModel;

		// Token: 0x04037398 RID: 226200
		[Token(Token = "0x4037398")]
		[FieldOffset(Offset = "0x88")]
		private Tween m_darkenTween;

		// Token: 0x04037399 RID: 226201
		[Token(Token = "0x4037399")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnItemClickEvent;

		// Token: 0x0403739A RID: 226202
		[Token(Token = "0x403739A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403739B RID: 226203
		[Token(Token = "0x403739B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetWidthOfType;

		// Token: 0x0403739C RID: 226204
		[Token(Token = "0x403739C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNeed;

		// Token: 0x0403739D RID: 226205
		[Token(Token = "0x403739D")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__FitSizeWithType;

		// Token: 0x0403739E RID: 226206
		[Token(Token = "0x403739E")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__SetTypePanelStatus;

		// Token: 0x0403739F RID: 226207
		[Token(Token = "0x403739F")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__RenderIconViews;

		// Token: 0x040373A0 RID: 226208
		[Token(Token = "0x40373A0")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__RenderFeaturePanels;

		// Token: 0x040373A1 RID: 226209
		[Token(Token = "0x40373A1")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__RenderPluginContainers;

		// Token: 0x040373A2 RID: 226210
		[Token(Token = "0x40373A2")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006A91 RID: 27281
		[Token(Token = "0x2006A91")]
		[Serializable]
		private class TypePanel
		{
			// Token: 0x06027083 RID: 159875 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6027083")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public TypePanel()
			{
			}

			// Token: 0x040373A3 RID: 226211
			[Token(Token = "0x40373A3")]
			[FieldOffset(Offset = "0x10")]
			public List<StorylineStorySetType> matches;

			// Token: 0x040373A4 RID: 226212
			[Token(Token = "0x40373A4")]
			[FieldOffset(Offset = "0x18")]
			public GameObject panel;
		}

		// Token: 0x02006A92 RID: 27282
		[Token(Token = "0x2006A92")]
		[Serializable]
		private class FeaturePanel
		{
			// Token: 0x06027084 RID: 159876 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6027084")]
			[Address(RVA = "0x2239C20", Offset = "0x2238820", VA = "0x182239C20")]
			public void Sync(StageMixStoryOverallItemStateHandler handler)
			{
			}

			// Token: 0x06027085 RID: 159877 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6027085")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public FeaturePanel()
			{
			}

			// Token: 0x040373A5 RID: 226213
			[Token(Token = "0x40373A5")]
			[FieldOffset(Offset = "0x10")]
			public StageMixStoryOverallView.OverallDisplayFeature feature;

			// Token: 0x040373A6 RID: 226214
			[Token(Token = "0x40373A6")]
			[FieldOffset(Offset = "0x18")]
			public CanvasGroup group;

			// Token: 0x040373A7 RID: 226215
			[Token(Token = "0x40373A7")]
			[FieldOffset(Offset = "0x20")]
			private Tween m_tween;
		}

		// Token: 0x02006A93 RID: 27283
		[Token(Token = "0x2006A93")]
		[Serializable]
		private class PluginContainer : IHotfixable
		{
			// Token: 0x06027086 RID: 159878 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6027086")]
			[Address(RVA = "0x223A9C0", Offset = "0x22395C0", VA = "0x18223A9C0")]
			public void Render(StageStorylineStorySetViewModel model, StageMixStoryOverallItemStateHandler itemStateHandler)
			{
			}

			// Token: 0x06027087 RID: 159879 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6027087")]
			[Address(RVA = "0x223AC40", Offset = "0x2239840", VA = "0x18223AC40")]
			public PluginContainer()
			{
			}

			// Token: 0x040373A8 RID: 226216
			[Token(Token = "0x40373A8")]
			[FieldOffset(Offset = "0x10")]
			public StageMixStoryOverallGroupItemPlugin prefab;

			// Token: 0x040373A9 RID: 226217
			[Token(Token = "0x40373A9")]
			[FieldOffset(Offset = "0x18")]
			public Transform container;

			// Token: 0x040373AA RID: 226218
			[Token(Token = "0x40373AA")]
			[FieldOffset(Offset = "0x20")]
			private StageMixStoryOverallGroupItemPlugin m_instance;

			// Token: 0x040373AB RID: 226219
			[Token(Token = "0x40373AB")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_Render;

			// Token: 0x040373AC RID: 226220
			[Token(Token = "0x40373AC")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
