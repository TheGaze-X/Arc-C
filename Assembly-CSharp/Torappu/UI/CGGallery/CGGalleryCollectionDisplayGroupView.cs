using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.CGGallery
{
	// Token: 0x02005FF6 RID: 24566
	[Token(Token = "0x2005FF6")]
	public class CGGalleryCollectionDisplayGroupView : MonoBehaviour, IUIIntegerLocateRegistry, IUILocateRegistry, IHotfixable
	{
		// Token: 0x0602382A RID: 145450 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602382A")]
		[Address(RVA = "0x1E14EE0", Offset = "0x1E13AE0", VA = "0x181E14EE0")]
		public void Render(CGGalleryViewModel model)
		{
		}

		// Token: 0x0602382B RID: 145451 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602382B")]
		[Address(RVA = "0x1E14D30", Offset = "0x1E13930", VA = "0x181E14D30")]
		public void MarkFavouriteDirty()
		{
		}

		// Token: 0x0602382C RID: 145452 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602382C")]
		[Address(RVA = "0x1E14A70", Offset = "0x1E13670", VA = "0x181E14A70")]
		public void FocusDisplayOnLayout(string displayId)
		{
		}

		// Token: 0x0602382D RID: 145453 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602382D")]
		[Address(RVA = "0x1E14AF0", Offset = "0x1E136F0", VA = "0x181E14AF0")]
		public void GetLocatedInfo(out string storySetId, out string displayId)
		{
		}

		// Token: 0x170053E7 RID: 21479
		// (get) Token: 0x0602382E RID: 145454 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170053E7")]
		public IReadOnlyCollection<int> metasObserved
		{
			[Token(Token = "0x602382E")]
			[Address(RVA = "0x1E16370", Offset = "0x1E14F70", VA = "0x181E16370", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x0602382F RID: 145455 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602382F")]
		[Address(RVA = "0x1E14E60", Offset = "0x1E13A60", VA = "0x181E14E60", Slot = "5")]
		public void OnMetaChange(int id, object meta)
		{
		}

		// Token: 0x06023830 RID: 145456 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023830")]
		[Address(RVA = "0x1E14D90", Offset = "0x1E13990", VA = "0x181E14D90", Slot = "6")]
		public void OnLocatedChange(int located)
		{
		}

		// Token: 0x06023831 RID: 145457 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023831")]
		[Address(RVA = "0x1E14E00", Offset = "0x1E13A00", VA = "0x181E14E00", Slot = "7")]
		public void OnLocatingStateChange(bool locating)
		{
		}

		// Token: 0x1400008B RID: 139
		// (add) Token: 0x06023832 RID: 145458 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06023833 RID: 145459 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1400008B")]
		public event Action<int> requestLocate
		{
			[Token(Token = "0x6023832")]
			[Address(RVA = "0x1E16270", Offset = "0x1E14E70", VA = "0x181E16270", Slot = "8")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6023833")]
			[Address(RVA = "0x1E163D0", Offset = "0x1E14FD0", VA = "0x181E163D0", Slot = "9")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06023834 RID: 145460 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023834")]
		[Address(RVA = "0x1E155D0", Offset = "0x1E141D0", VA = "0x181E155D0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06023835 RID: 145461 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023835")]
		[Address(RVA = "0x1E16070", Offset = "0x1E14C70", VA = "0x181E16070")]
		private void _UpdateVirtualModelsIfNeeded(CGGalleryViewModel model)
		{
		}

		// Token: 0x06023836 RID: 145462 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023836")]
		[Address(RVA = "0x1E159C0", Offset = "0x1E145C0", VA = "0x181E159C0")]
		private static void _PackGroups(IReadOnlyList<CGGalleryDisplayGroupViewModel> groups, bool filter, out List<UISimpleRecycleLayoutItemViewModel> displayVirtualModels, out List<CGGalleryCollectionDisplayGroupView.GroupIndexModel> groupIndexModels)
		{
		}

		// Token: 0x06023837 RID: 145463 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023837")]
		[Address(RVA = "0x1E16000", Offset = "0x1E14C00", VA = "0x181E16000")]
		private void _UnregisterLine()
		{
		}

		// Token: 0x06023838 RID: 145464 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023838")]
		[Address(RVA = "0x1E15F80", Offset = "0x1E14B80", VA = "0x181E15F80")]
		private void _ResetAndRegisterLine()
		{
		}

		// Token: 0x06023839 RID: 145465 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023839")]
		[Address(RVA = "0x1E15920", Offset = "0x1E14520", VA = "0x181E15920")]
		private void _LockAndRegisterLine(int lockPosition)
		{
		}

		// Token: 0x0602383A RID: 145466 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602383A")]
		[Address(RVA = "0x1E15520", Offset = "0x1E14120", VA = "0x181E15520")]
		private IEnumerator _DelayedFocusAction()
		{
			return null;
		}

		// Token: 0x0602383B RID: 145467 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602383B")]
		[Address(RVA = "0x1E161E0", Offset = "0x1E14DE0", VA = "0x181E161E0")]
		public CGGalleryCollectionDisplayGroupView()
		{
		}

		// Token: 0x04031201 RID: 201217
		[Token(Token = "0x4031201")]
		[NonSerialized]
		public const string HEAD_PREFAB_TYPE = "head";

		// Token: 0x04031202 RID: 201218
		[Token(Token = "0x4031202")]
		[NonSerialized]
		public const string COLUMN_PREFAB_TYPE = "column";

		// Token: 0x04031203 RID: 201219
		[Token(Token = "0x4031203")]
		private const int COLUMN_DISPLAY_MAX_COUNT = 3;

		// Token: 0x04031204 RID: 201220
		[Token(Token = "0x4031204")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CGGalleryCollectionLayoutGroup _displayGroup;

		// Token: 0x04031205 RID: 201221
		[Token(Token = "0x4031205")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UISimpleRecycleLayoutItemView[] _itemPrefabs;

		// Token: 0x04031206 RID: 201222
		[Token(Token = "0x4031206")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _headSize;

		// Token: 0x04031207 RID: 201223
		[Token(Token = "0x4031207")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float _columnSize;

		// Token: 0x04031208 RID: 201224
		[Token(Token = "0x4031208")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UIWrappedScrollRect _displayScrollRect;

		// Token: 0x04031209 RID: 201225
		[Token(Token = "0x4031209")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UILayoutDimensionListener _displayLayoutListener;

		// Token: 0x0403120A RID: 201226
		[Token(Token = "0x403120A")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private RectTransform _locateRect;

		// Token: 0x0403120B RID: 201227
		[Token(Token = "0x403120B")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Ease _locateEase;

		// Token: 0x0403120C RID: 201228
		[Token(Token = "0x403120C")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private float _locateDuration;

		// Token: 0x0403120D RID: 201229
		[Token(Token = "0x403120D")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private int _locateMaxDistance;

		// Token: 0x0403120E RID: 201230
		[Token(Token = "0x403120E")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private TwoStateBiAnimationSwitcher _titleSwitcher;

		// Token: 0x0403120F RID: 201231
		[Token(Token = "0x403120F")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _favouriteValidPanel;

		// Token: 0x04031210 RID: 201232
		[Token(Token = "0x4031210")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _favouriteEmptyPanel;

		// Token: 0x04031211 RID: 201233
		[Token(Token = "0x4031211")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private CGGalleryCollectionLineView _lineView;

		// Token: 0x04031212 RID: 201234
		[Token(Token = "0x4031212")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private CGGalleryCollectionLineEffectView _lineEffectView;

		// Token: 0x04031213 RID: 201235
		[Token(Token = "0x4031213")]
		[FieldOffset(Offset = "0x80")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04031214 RID: 201236
		[Token(Token = "0x4031214")]
		[FieldOffset(Offset = "0x90")]
		private bool m_inited;

		// Token: 0x04031215 RID: 201237
		[Token(Token = "0x4031215")]
		[FieldOffset(Offset = "0x98")]
		private CGGalleryCollectionDisplayGroupView.DisplayLayoutAdapter m_adapter;

		// Token: 0x04031216 RID: 201238
		[Token(Token = "0x4031216")]
		[FieldOffset(Offset = "0xA0")]
		private CGGalleryCollectionDisplayGroupView.DisplayLayoutHelper m_helper;

		// Token: 0x04031217 RID: 201239
		[Token(Token = "0x4031217")]
		[FieldOffset(Offset = "0xA8")]
		private UIWrappedScrollRect.Wrapper m_scrollWrapper;

		// Token: 0x04031218 RID: 201240
		[Token(Token = "0x4031218")]
		[FieldOffset(Offset = "0xB0")]
		private UIIntegerLocatableCoordinator m_coordinator;

		// Token: 0x04031219 RID: 201241
		[Token(Token = "0x4031219")]
		[FieldOffset(Offset = "0xB8")]
		private CGGalleryCollectionDisplayGroupView.DisplayAdapterBridge m_displayAdapterBridge;

		// Token: 0x0403121A RID: 201242
		[Token(Token = "0x403121A")]
		[FieldOffset(Offset = "0xC0")]
		private List<UISimpleRecycleLayoutItemViewModel> m_storylineDisplayVirtualModels;

		// Token: 0x0403121B RID: 201243
		[Token(Token = "0x403121B")]
		[FieldOffset(Offset = "0xC8")]
		private List<CGGalleryCollectionDisplayGroupView.GroupIndexModel> m_storylineGroupIndexModels;

		// Token: 0x0403121C RID: 201244
		[Token(Token = "0x403121C")]
		[FieldOffset(Offset = "0xD0")]
		private bool m_favouriteDirty;

		// Token: 0x0403121D RID: 201245
		[Token(Token = "0x403121D")]
		[FieldOffset(Offset = "0xD8")]
		private List<UISimpleRecycleLayoutItemViewModel> m_favouriteDisplayVirtualModels;

		// Token: 0x0403121E RID: 201246
		[Token(Token = "0x403121E")]
		[FieldOffset(Offset = "0xE0")]
		private List<CGGalleryCollectionDisplayGroupView.GroupIndexModel> m_favouriteGroupIndexModels;

		// Token: 0x0403121F RID: 201247
		[Token(Token = "0x403121F")]
		[FieldOffset(Offset = "0xE8")]
		private int m_located;

		// Token: 0x04031220 RID: 201248
		[Token(Token = "0x4031220")]
		[FieldOffset(Offset = "0xEC")]
		private CGGalleryFilterMode m_filterMode;

		// Token: 0x04031221 RID: 201249
		[Token(Token = "0x4031221")]
		[FieldOffset(Offset = "0xF0")]
		private string m_focusOnRebuild;

		// Token: 0x04031222 RID: 201250
		[Token(Token = "0x4031222")]
		[FieldOffset(Offset = "0xF8")]
		private Coroutine m_focusCoroutine;

		// Token: 0x04031224 RID: 201252
		[Token(Token = "0x4031224")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04031225 RID: 201253
		[Token(Token = "0x4031225")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_MarkFavouriteDirty;

		// Token: 0x04031226 RID: 201254
		[Token(Token = "0x4031226")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_FocusDisplayOnLayout;

		// Token: 0x04031227 RID: 201255
		[Token(Token = "0x4031227")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetLocatedInfo;

		// Token: 0x04031228 RID: 201256
		[Token(Token = "0x4031228")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_metasObserved;

		// Token: 0x04031229 RID: 201257
		[Token(Token = "0x4031229")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnMetaChange;

		// Token: 0x0403122A RID: 201258
		[Token(Token = "0x403122A")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnLocatedChange;

		// Token: 0x0403122B RID: 201259
		[Token(Token = "0x403122B")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnLocatingStateChange;

		// Token: 0x0403122C RID: 201260
		[Token(Token = "0x403122C")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_add_requestLocate;

		// Token: 0x0403122D RID: 201261
		[Token(Token = "0x403122D")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_remove_requestLocate;

		// Token: 0x0403122E RID: 201262
		[Token(Token = "0x403122E")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403122F RID: 201263
		[Token(Token = "0x403122F")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__UpdateVirtualModelsIfNeeded;

		// Token: 0x04031230 RID: 201264
		[Token(Token = "0x4031230")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__PackGroups;

		// Token: 0x04031231 RID: 201265
		[Token(Token = "0x4031231")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__UnregisterLine;

		// Token: 0x04031232 RID: 201266
		[Token(Token = "0x4031232")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__ResetAndRegisterLine;

		// Token: 0x04031233 RID: 201267
		[Token(Token = "0x4031233")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__LockAndRegisterLine;

		// Token: 0x04031234 RID: 201268
		[Token(Token = "0x4031234")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__DelayedFocusAction;

		// Token: 0x04031235 RID: 201269
		[Token(Token = "0x4031235")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005FF7 RID: 24567
		[Token(Token = "0x2005FF7")]
		public class DisplayAdapterBridge
		{
			// Token: 0x0602383C RID: 145468 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602383C")]
			[Address(RVA = "0x557D40", Offset = "0x556940", VA = "0x180557D40")]
			public DisplayAdapterBridge(UIIntegerLocatableCoordinator coordinator)
			{
			}

			// Token: 0x0602383D RID: 145469 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602383D")]
			[Address(RVA = "0x1E3DED0", Offset = "0x1E3CAD0", VA = "0x181E3DED0")]
			public void Register(IUIIntegerLocateRegistry registry)
			{
			}

			// Token: 0x0602383E RID: 145470 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602383E")]
			[Address(RVA = "0x1E3DEF0", Offset = "0x1E3CAF0", VA = "0x181E3DEF0")]
			public void Unregister(IUIIntegerLocateRegistry registry)
			{
			}

			// Token: 0x04031236 RID: 201270
			[Token(Token = "0x4031236")]
			[FieldOffset(Offset = "0x10")]
			private readonly UIIntegerLocatableCoordinator m_coordinator;

			// Token: 0x04031237 RID: 201271
			[Token(Token = "0x4031237")]
			[FieldOffset(Offset = "0x18")]
			public CGGalleryFilterMode filterMode;
		}

		// Token: 0x02005FF8 RID: 24568
		[Token(Token = "0x2005FF8")]
		public class DisplayHeadVirtualModel : UISimpleRecycleLayoutItemViewModel
		{
			// Token: 0x0602383F RID: 145471 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602383F")]
			[Address(RVA = "0x1E3E430", Offset = "0x1E3D030", VA = "0x181E3E430")]
			public DisplayHeadVirtualModel(CGGalleryDisplayViewModel display)
			{
			}

			// Token: 0x06023840 RID: 145472 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6023840")]
			[Address(RVA = "0x1E3E3C0", Offset = "0x1E3CFC0", VA = "0x181E3E3C0", Slot = "4")]
			public override string GetViewType()
			{
				return null;
			}

			// Token: 0x04031238 RID: 201272
			[Token(Token = "0x4031238")]
			[FieldOffset(Offset = "0x10")]
			public readonly CGGalleryDisplayViewModel display;

			// Token: 0x04031239 RID: 201273
			[Token(Token = "0x4031239")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0403123A RID: 201274
			[Token(Token = "0x403123A")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GetViewType;
		}

		// Token: 0x02005FF9 RID: 24569
		[Token(Token = "0x2005FF9")]
		public class DisplayColumnVirtualModel : UISimpleRecycleLayoutItemViewModel
		{
			// Token: 0x06023841 RID: 145473 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6023841")]
			[Address(RVA = "0x1E3DF80", Offset = "0x1E3CB80", VA = "0x181E3DF80")]
			public DisplayColumnVirtualModel(List<CGGalleryDisplayViewModel> displays)
			{
			}

			// Token: 0x06023842 RID: 145474 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6023842")]
			[Address(RVA = "0x1E3DF10", Offset = "0x1E3CB10", VA = "0x181E3DF10", Slot = "4")]
			public override string GetViewType()
			{
				return null;
			}

			// Token: 0x0403123B RID: 201275
			[Token(Token = "0x403123B")]
			[FieldOffset(Offset = "0x10")]
			public readonly List<CGGalleryDisplayViewModel> displays;

			// Token: 0x0403123C RID: 201276
			[Token(Token = "0x403123C")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0403123D RID: 201277
			[Token(Token = "0x403123D")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GetViewType;
		}

		// Token: 0x02005FFA RID: 24570
		[Token(Token = "0x2005FFA")]
		public class GroupIndexModel : IHotfixable
		{
			// Token: 0x06023843 RID: 145475 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6023843")]
			[Address(RVA = "0x1E3E7A0", Offset = "0x1E3D3A0", VA = "0x181E3E7A0")]
			public GroupIndexModel(CGGalleryDisplayGroupViewModel group, RangeInt virtualRange)
			{
			}

			// Token: 0x0403123E RID: 201278
			[Token(Token = "0x403123E")]
			[FieldOffset(Offset = "0x10")]
			public readonly CGGalleryDisplayGroupViewModel group;

			// Token: 0x0403123F RID: 201279
			[Token(Token = "0x403123F")]
			[FieldOffset(Offset = "0x18")]
			public readonly RangeInt virtualRange;

			// Token: 0x04031240 RID: 201280
			[Token(Token = "0x4031240")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02005FFB RID: 24571
		[Token(Token = "0x2005FFB")]
		private class DisplayLayoutAdapter : UISimpleRecycleLayoutAdapter
		{
			// Token: 0x06023844 RID: 145476 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6023844")]
			[Address(RVA = "0x1E3E580", Offset = "0x1E3D180", VA = "0x181E3E580")]
			public DisplayLayoutAdapter(IList<UISimpleRecycleLayoutItemView> prefabList)
			{
			}

			// Token: 0x06023845 RID: 145477 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6023845")]
			[Address(RVA = "0x1E3E4B0", Offset = "0x1E3D0B0", VA = "0x181E3E4B0")]
			public void InitializeHelper(CGGalleryCollectionDisplayGroupView.DisplayLayoutHelper helper, LocatableRecycleLayoutHelper.LocateParam locateParam)
			{
			}

			// Token: 0x04031241 RID: 201281
			[Token(Token = "0x4031241")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04031242 RID: 201282
			[Token(Token = "0x4031242")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_InitializeHelper;
		}

		// Token: 0x02005FFC RID: 24572
		[Token(Token = "0x2005FFC")]
		private class DisplayLayoutHelper : LocatableRecycleLayoutHelper
		{
			// Token: 0x06023846 RID: 145478 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6023846")]
			[Address(RVA = "0x1E3E720", Offset = "0x1E3D320", VA = "0x181E3E720")]
			public DisplayLayoutHelper(CGGalleryCollectionDisplayGroupView closure)
			{
			}

			// Token: 0x06023847 RID: 145479 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6023847")]
			[Address(RVA = "0x1E3E670", Offset = "0x1E3D270", VA = "0x181E3E670", Slot = "12")]
			public override void OnLocatingStateChange(bool locating)
			{
			}

			// Token: 0x06023848 RID: 145480 RVA: 0x000C1248 File Offset: 0x000BF448
			[Token(Token = "0x6023848")]
			[Address(RVA = "0x1E3E5F0", Offset = "0x1E3D1F0", VA = "0x181E3E5F0", Slot = "14")]
			protected override Vector2 GetItemPivot(int index)
			{
				return default(Vector2);
			}

			// Token: 0x04031243 RID: 201283
			[Token(Token = "0x4031243")]
			[FieldOffset(Offset = "0x68")]
			private readonly CGGalleryCollectionDisplayGroupView m_closure;

			// Token: 0x04031244 RID: 201284
			[Token(Token = "0x4031244")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04031245 RID: 201285
			[Token(Token = "0x4031245")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OnLocatingStateChange;

			// Token: 0x04031246 RID: 201286
			[Token(Token = "0x4031246")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GetItemPivot;
		}

		// Token: 0x02005FFD RID: 24573
		[Token(Token = "0x2005FFD")]
		private class DisplayFocusAction : UILayoutDimensionListener.IAction
		{
			// Token: 0x06023849 RID: 145481 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6023849")]
			[Address(RVA = "0x1E3E000", Offset = "0x1E3CC00", VA = "0x181E3E000", Slot = "4")]
			public void DoAction()
			{
			}

			// Token: 0x0602384A RID: 145482 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602384A")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public DisplayFocusAction()
			{
			}

			// Token: 0x04031247 RID: 201287
			[Token(Token = "0x4031247")]
			[FieldOffset(Offset = "0x10")]
			public CGGalleryCollectionDisplayGroupView closure;

			// Token: 0x04031248 RID: 201288
			[Token(Token = "0x4031248")]
			[FieldOffset(Offset = "0x18")]
			public string displayId;
		}
	}
}
