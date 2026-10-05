using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using EaseFunctions;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x020038CD RID: 14541
	[Token(Token = "0x20038CD")]
	public abstract class UICustomAdapterLayout<TData, TView> : MonoBehaviour, IHotfixable where TView : MonoBehaviour
	{
		// Token: 0x06016FF1 RID: 94193 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016FF1")]
		protected virtual void OnEnable()
		{
		}

		// Token: 0x06016FF2 RID: 94194 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016FF2")]
		protected virtual void OnDisable()
		{
		}

		// Token: 0x170036E4 RID: 14052
		// (get) Token: 0x06016FF3 RID: 94195 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170036E4")]
		public RectTransform viewContainer
		{
			[Token(Token = "0x6016FF3")]
			get
			{
				return null;
			}
		}

		// Token: 0x06016FF4 RID: 94196 RVA: 0x00094398 File Offset: 0x00092598
		[Token(Token = "0x6016FF4")]
		public KeyValuePair<TData, TView> GetActiveViewOrDefault(string id)
		{
			return default(KeyValuePair<TData, TView>);
		}

		// Token: 0x06016FF5 RID: 94197 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6016FF5")]
		public IEnumerator<TView> GetActiveViews()
		{
			return null;
		}

		// Token: 0x06016FF6 RID: 94198 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016FF6")]
		public void Init(UICustomAdapterLayout<TData, TView>.Adapter adapter, UICustomAdapterLayout<TData, TView>.Layouter layouter)
		{
		}

		// Token: 0x06016FF7 RID: 94199 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016FF7")]
		private void _ClearLayoutCoroutine()
		{
		}

		// Token: 0x06016FF8 RID: 94200 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016FF8")]
		private void _UpdateStatus()
		{
		}

		// Token: 0x06016FF9 RID: 94201 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6016FF9")]
		private IEnumerator _LayoutCoroutine()
		{
			return null;
		}

		// Token: 0x06016FFA RID: 94202 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016FFA")]
		private void _RebuildLayout()
		{
		}

		// Token: 0x06016FFB RID: 94203 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016FFB")]
		private void _FinishLayoutImmediately()
		{
		}

		// Token: 0x06016FFC RID: 94204 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016FFC")]
		private void _OnLayoutFinished()
		{
		}

		// Token: 0x06016FFD RID: 94205 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016FFD")]
		private void OnDestroy()
		{
		}

		// Token: 0x06016FFE RID: 94206 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016FFE")]
		private void _SyncAndDiffStatus(IList<TData> dataList)
		{
		}

		// Token: 0x06016FFF RID: 94207 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016FFF")]
		private void _RenderViews()
		{
		}

		// Token: 0x06017000 RID: 94208 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017000")]
		protected UICustomAdapterLayout()
		{
		}

		// Token: 0x0401BC28 RID: 113704
		[Token(Token = "0x401BC28")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private RectTransform _viewContainer;

		// Token: 0x0401BC29 RID: 113705
		[Token(Token = "0x401BC29")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private bool _isInterruptible;

		// Token: 0x0401BC2A RID: 113706
		[Token(Token = "0x401BC2A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private UICustomAdapterLayout<TData, TView>.Adapter m_adapter;

		// Token: 0x0401BC2B RID: 113707
		[Token(Token = "0x401BC2B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private UICustomAdapterLayout<TData, TView>.Layouter m_layouter;

		// Token: 0x0401BC2C RID: 113708
		[Token(Token = "0x401BC2C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Dictionary<string, UICustomAdapterLayout<TData, TView>.ViewHolder> m_viewMap;

		// Token: 0x0401BC2D RID: 113709
		[Token(Token = "0x401BC2D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private bool m_isUpdateingStatus;

		// Token: 0x0401BC2E RID: 113710
		[Token(Token = "0x401BC2E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private bool m_hasPendingChanges;

		// Token: 0x0401BC2F RID: 113711
		[Token(Token = "0x401BC2F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private bool m_isViewInited;

		// Token: 0x0401BC30 RID: 113712
		[Token(Token = "0x401BC30")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Coroutine m_layoutCoroutine;

		// Token: 0x0401BC31 RID: 113713
		[Token(Token = "0x401BC31")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private IEnumerator m_cachedLayoutRoutine;

		// Token: 0x0401BC32 RID: 113714
		[Token(Token = "0x401BC32")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private List<string> m_sharedIdList;

		// Token: 0x0401BC33 RID: 113715
		[Token(Token = "0x401BC33")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private HashSet<string> m_sharedIdSet;

		// Token: 0x0401BC34 RID: 113716
		[Token(Token = "0x401BC34")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private HashSet<string> m_addedIds;

		// Token: 0x0401BC35 RID: 113717
		[Token(Token = "0x401BC35")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private HashSet<string> m_removedIds;

		// Token: 0x0401BC36 RID: 113718
		[Token(Token = "0x401BC36")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnEnable;

		// Token: 0x0401BC37 RID: 113719
		[Token(Token = "0x401BC37")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnDisable;

		// Token: 0x0401BC38 RID: 113720
		[Token(Token = "0x401BC38")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_viewContainer;

		// Token: 0x0401BC39 RID: 113721
		[Token(Token = "0x401BC39")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetActiveViewOrDefault;

		// Token: 0x0401BC3A RID: 113722
		[Token(Token = "0x401BC3A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetActiveViews;

		// Token: 0x0401BC3B RID: 113723
		[Token(Token = "0x401BC3B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0401BC3C RID: 113724
		[Token(Token = "0x401BC3C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__ClearLayoutCoroutine;

		// Token: 0x0401BC3D RID: 113725
		[Token(Token = "0x401BC3D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__UpdateStatus;

		// Token: 0x0401BC3E RID: 113726
		[Token(Token = "0x401BC3E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__LayoutCoroutine;

		// Token: 0x0401BC3F RID: 113727
		[Token(Token = "0x401BC3F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__RebuildLayout;

		// Token: 0x0401BC40 RID: 113728
		[Token(Token = "0x401BC40")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__FinishLayoutImmediately;

		// Token: 0x0401BC41 RID: 113729
		[Token(Token = "0x401BC41")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__OnLayoutFinished;

		// Token: 0x0401BC42 RID: 113730
		[Token(Token = "0x401BC42")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0401BC43 RID: 113731
		[Token(Token = "0x401BC43")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__SyncAndDiffStatus;

		// Token: 0x0401BC44 RID: 113732
		[Token(Token = "0x401BC44")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__RenderViews;

		// Token: 0x0401BC45 RID: 113733
		[Token(Token = "0x401BC45")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020038CE RID: 14542
		[Token(Token = "0x20038CE")]
		public abstract class Adapter : IHotfixable
		{
			// Token: 0x06017001 RID: 94209
			[Token(Token = "0x6017001")]
			public abstract IList<TData> GetData();

			// Token: 0x06017002 RID: 94210
			[Token(Token = "0x6017002")]
			public abstract string GetId(TData data);

			// Token: 0x06017003 RID: 94211
			[Token(Token = "0x6017003")]
			public abstract TView CreateInst(TData data, RectTransform parent);

			// Token: 0x06017004 RID: 94212
			[Token(Token = "0x6017004")]
			public abstract void UpdateView(TView view, TData data);

			// Token: 0x06017005 RID: 94213 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017005")]
			public virtual void NotifyDataSetChanged()
			{
			}

			// Token: 0x06017006 RID: 94214 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017006")]
			public virtual void NotifyRebuild()
			{
			}

			// Token: 0x06017007 RID: 94215 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017007")]
			public virtual void DestroyView(TView view)
			{
			}

			// Token: 0x06017008 RID: 94216 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017008")]
			protected Adapter()
			{
			}

			// Token: 0x0401BC46 RID: 113734
			[Token(Token = "0x401BC46")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Action layoutOnlyObserver;

			// Token: 0x0401BC47 RID: 113735
			[Token(Token = "0x401BC47")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Action layoutOnlyRebuildObserver;

			// Token: 0x0401BC48 RID: 113736
			[Token(Token = "0x401BC48")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_NotifyDataSetChanged;

			// Token: 0x0401BC49 RID: 113737
			[Token(Token = "0x401BC49")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_NotifyRebuild;

			// Token: 0x0401BC4A RID: 113738
			[Token(Token = "0x401BC4A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_DestroyView;

			// Token: 0x0401BC4B RID: 113739
			[Token(Token = "0x401BC4B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x020038CF RID: 14543
		[Token(Token = "0x20038CF")]
		public abstract class Layouter : IHotfixable
		{
			// Token: 0x170036E5 RID: 14053
			// (get) Token: 0x06017009 RID: 94217 RVA: 0x000943B0 File Offset: 0x000925B0
			// (set) Token: 0x0601700A RID: 94218 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170036E5")]
			public bool isInterruptible
			{
				[Token(Token = "0x6017009")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x601700A")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x0601700B RID: 94219 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601700B")]
			public IEnumerator DoLayout(UICustomAdapterLayout<TData, TView> layout)
			{
				return null;
			}

			// Token: 0x0601700C RID: 94220 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601700C")]
			public void DoLayoutImmediately(UICustomAdapterLayout<TData, TView> layout)
			{
			}

			// Token: 0x0601700D RID: 94221 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601700D")]
			public void Interrupt()
			{
			}

			// Token: 0x0601700E RID: 94222 RVA: 0x000943C8 File Offset: 0x000925C8
			[Token(Token = "0x601700E")]
			public bool IsPreservedView(string id)
			{
				return default(bool);
			}

			// Token: 0x0601700F RID: 94223 RVA: 0x000943E0 File Offset: 0x000925E0
			[Token(Token = "0x601700F")]
			protected bool IsNewlyAddedView(string id)
			{
				return default(bool);
			}

			// Token: 0x06017010 RID: 94224 RVA: 0x000943F8 File Offset: 0x000925F8
			[Token(Token = "0x6017010")]
			protected bool IsToBeRemmovedView(string id)
			{
				return default(bool);
			}

			// Token: 0x06017011 RID: 94225
			[Token(Token = "0x6017011")]
			protected abstract void LayoutInternal();

			// Token: 0x06017012 RID: 94226
			[Token(Token = "0x6017012")]
			protected abstract void LayoutImmediatelyInternal();

			// Token: 0x06017013 RID: 94227 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017013")]
			protected void StartTransTween(Action<float> setter, float duration, float delay, Interpolator.EaseType easeType, [Optional] string preserveId)
			{
			}

			// Token: 0x06017014 RID: 94228 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017014")]
			protected void ClearPreservedTween(string preserveId)
			{
			}

			// Token: 0x06017015 RID: 94229 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017015")]
			private void _UpdateLayoutElements(UICustomAdapterLayout<TData, TView> layout)
			{
			}

			// Token: 0x06017016 RID: 94230 RVA: 0x00094410 File Offset: 0x00092610
			[Token(Token = "0x6017016")]
			private bool _TickTransTweens(UICustomAdapterLayout<TData, TView>.Layouter.TransTween tween, long curTs)
			{
				return default(bool);
			}

			// Token: 0x06017017 RID: 94231 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6017017")]
			private IEnumerator _UpdateTransTweens()
			{
				return null;
			}

			// Token: 0x06017018 RID: 94232 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017018")]
			protected Layouter()
			{
			}

			// Token: 0x0401BC4C RID: 113740
			[Token(Token = "0x401BC4C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			protected List<UICustomAdapterLayout<TData, TView>.Layouter.LayoutElement> layoutElements;

			// Token: 0x0401BC4D RID: 113741
			[Token(Token = "0x401BC4D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			protected RectTransform container;

			// Token: 0x0401BC4E RID: 113742
			[Token(Token = "0x401BC4E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private HashSet<string> m_newlyAddedViews;

			// Token: 0x0401BC4F RID: 113743
			[Token(Token = "0x401BC4F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private HashSet<string> m_viewsToRemove;

			// Token: 0x0401BC50 RID: 113744
			[Token(Token = "0x401BC50")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private List<UICustomAdapterLayout<TData, TView>.Layouter.TransTween> m_transTweens;

			// Token: 0x0401BC51 RID: 113745
			[Token(Token = "0x401BC51")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private ListDict<string, UICustomAdapterLayout<TData, TView>.Layouter.TransTween> m_preservedTransTweens;

			// Token: 0x0401BC53 RID: 113747
			[Token(Token = "0x401BC53")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_isInterruptible;

			// Token: 0x0401BC54 RID: 113748
			[Token(Token = "0x401BC54")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_set_isInterruptible;

			// Token: 0x0401BC55 RID: 113749
			[Token(Token = "0x401BC55")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_DoLayout;

			// Token: 0x0401BC56 RID: 113750
			[Token(Token = "0x401BC56")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_DoLayoutImmediately;

			// Token: 0x0401BC57 RID: 113751
			[Token(Token = "0x401BC57")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_Interrupt;

			// Token: 0x0401BC58 RID: 113752
			[Token(Token = "0x401BC58")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_IsPreservedView;

			// Token: 0x0401BC59 RID: 113753
			[Token(Token = "0x401BC59")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_IsNewlyAddedView;

			// Token: 0x0401BC5A RID: 113754
			[Token(Token = "0x401BC5A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_IsToBeRemmovedView;

			// Token: 0x0401BC5B RID: 113755
			[Token(Token = "0x401BC5B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_StartTransTween;

			// Token: 0x0401BC5C RID: 113756
			[Token(Token = "0x401BC5C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_ClearPreservedTween;

			// Token: 0x0401BC5D RID: 113757
			[Token(Token = "0x401BC5D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0__UpdateLayoutElements;

			// Token: 0x0401BC5E RID: 113758
			[Token(Token = "0x401BC5E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0__TickTransTweens;

			// Token: 0x0401BC5F RID: 113759
			[Token(Token = "0x401BC5F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0__UpdateTransTweens;

			// Token: 0x0401BC60 RID: 113760
			[Token(Token = "0x401BC60")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x020038D0 RID: 14544
			[Token(Token = "0x20038D0")]
			protected struct LayoutElement
			{
				// Token: 0x0401BC61 RID: 113761
				[Token(Token = "0x401BC61")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public string id;

				// Token: 0x0401BC62 RID: 113762
				[Token(Token = "0x401BC62")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public TData data;

				// Token: 0x0401BC63 RID: 113763
				[Token(Token = "0x401BC63")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public TView view;
			}

			// Token: 0x020038D1 RID: 14545
			[Token(Token = "0x20038D1")]
			private struct TransTween
			{
				// Token: 0x0401BC64 RID: 113764
				[Token(Token = "0x401BC64")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public Action<float> setter;

				// Token: 0x0401BC65 RID: 113765
				[Token(Token = "0x401BC65")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public long startTick;

				// Token: 0x0401BC66 RID: 113766
				[Token(Token = "0x401BC66")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public long endTick;

				// Token: 0x0401BC67 RID: 113767
				[Token(Token = "0x401BC67")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public Interpolator.EasingFunction easeFunc;

				// Token: 0x0401BC68 RID: 113768
				[Token(Token = "0x401BC68")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public string preserveId;
			}
		}

		// Token: 0x020038D4 RID: 14548
		[Token(Token = "0x20038D4")]
		private class ViewHolder
		{
			// Token: 0x06017025 RID: 94245 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017025")]
			public ViewHolder()
			{
			}

			// Token: 0x0401BC70 RID: 113776
			[Token(Token = "0x401BC70")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public TData data;

			// Token: 0x0401BC71 RID: 113777
			[Token(Token = "0x401BC71")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public TView view;

			// Token: 0x0401BC72 RID: 113778
			[Token(Token = "0x401BC72")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public bool preservedForRemove;
		}
	}
}
