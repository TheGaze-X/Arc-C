using System;
using System.Collections;
using System.Runtime.CompilerServices;
using AdvancedInspector;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;

namespace Torappu.Building.UI.Trading
{
	// Token: 0x02001C3F RID: 7231
	[Token(Token = "0x2001C3F")]
	public class BuildingTradingOrderView : MonoBehaviour
	{
		// Token: 0x17001595 RID: 5525
		// (get) Token: 0x0600B3FA RID: 46074 RVA: 0x000444C0 File Offset: 0x000426C0
		// (set) Token: 0x0600B3FB RID: 46075 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001595")]
		public bool isInited
		{
			[Token(Token = "0x600B3FA")]
			[Address(RVA = "0x32F71F0", Offset = "0x32F5DF0", VA = "0x1832F71F0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600B3FB")]
			[Address(RVA = "0x32F7210", Offset = "0x32F5E10", VA = "0x1832F7210")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001596 RID: 5526
		// (get) Token: 0x0600B3FC RID: 46076 RVA: 0x000444D8 File Offset: 0x000426D8
		// (set) Token: 0x0600B3FD RID: 46077 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001596")]
		public long orderId
		{
			[Token(Token = "0x600B3FC")]
			[Address(RVA = "0x4FB2F0", Offset = "0x4F9EF0", VA = "0x1804FB2F0")]
			get
			{
				return 0L;
			}
			[Token(Token = "0x600B3FD")]
			[Address(RVA = "0x32F7220", Offset = "0x32F5E20", VA = "0x1832F7220")]
			set
			{
			}
		}

		// Token: 0x17001597 RID: 5527
		// (get) Token: 0x0600B3FE RID: 46078 RVA: 0x000444F0 File Offset: 0x000426F0
		// (set) Token: 0x0600B3FF RID: 46079 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001597")]
		public OrderStatus orderStatus
		{
			[Token(Token = "0x600B3FE")]
			[Address(RVA = "0x32F7200", Offset = "0x32F5E00", VA = "0x1832F7200")]
			[CompilerGenerated]
			get
			{
				return OrderStatus.NONE;
			}
			[Token(Token = "0x600B3FF")]
			[Address(RVA = "0x32F7230", Offset = "0x32F5E30", VA = "0x1832F7230")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001598 RID: 5528
		// (get) Token: 0x0600B400 RID: 46080 RVA: 0x00044508 File Offset: 0x00042708
		[Token(Token = "0x17001598")]
		public bool isVisible
		{
			[Token(Token = "0x600B400")]
			[Address(RVA = "0xFD66E0", Offset = "0xFD52E0", VA = "0x180FD66E0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001599 RID: 5529
		// (get) Token: 0x0600B401 RID: 46081 RVA: 0x00044520 File Offset: 0x00042720
		[Token(Token = "0x17001599")]
		public bool isActing
		{
			[Token(Token = "0x600B401")]
			[Address(RVA = "0x32F7150", Offset = "0x32F5D50", VA = "0x1832F7150")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600B402 RID: 46082 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B402")]
		[Address(RVA = "0x32F5E80", Offset = "0x32F4A80", VA = "0x1832F5E80")]
		public void DoAction(OrderViewAction action, TOrderSlotStruct slotStruct, TradingInfoViewStruct tradingModel)
		{
		}

		// Token: 0x0600B403 RID: 46083 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B403")]
		[Address(RVA = "0x32F6360", Offset = "0x32F4F60", VA = "0x1832F6360")]
		public void RenderImmediately(TOrderSlotStruct slotStruct, TradingInfoViewStruct tradingModel)
		{
		}

		// Token: 0x0600B404 RID: 46084 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B404")]
		[Address(RVA = "0x32F6340", Offset = "0x32F4F40", VA = "0x1832F6340")]
		public void Recycle()
		{
		}

		// Token: 0x0600B405 RID: 46085 RVA: 0x00044538 File Offset: 0x00042738
		[Token(Token = "0x600B405")]
		[Address(RVA = "0x32F6480", Offset = "0x32F5080", VA = "0x1832F6480")]
		public bool ValidationCheck(TOrderSlotStruct slotStruct)
		{
			return default(bool);
		}

		// Token: 0x0600B406 RID: 46086 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B406")]
		[Address(RVA = "0x32F6BC0", Offset = "0x32F57C0", VA = "0x1832F6BC0")]
		private void _Render(TOrderSlotStruct slotStruct, TradingInfoViewStruct tradingModel, bool withTransition)
		{
		}

		// Token: 0x0600B407 RID: 46087 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B407")]
		[Address(RVA = "0x32F7010", Offset = "0x32F5C10", VA = "0x1832F7010")]
		private void _UpdateOrderStatus(OrderStatus newStatus, bool withTransition)
		{
		}

		// Token: 0x0600B408 RID: 46088 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B408")]
		[Address(RVA = "0x32F64E0", Offset = "0x32F50E0", VA = "0x1832F64E0")]
		private void _HaltAllEffects()
		{
		}

		// Token: 0x0600B409 RID: 46089 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B409")]
		[Address(RVA = "0x32F6680", Offset = "0x32F5280", VA = "0x1832F6680")]
		private void _HideAnim()
		{
		}

		// Token: 0x0600B40A RID: 46090 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B40A")]
		[Address(RVA = "0x32F67C0", Offset = "0x32F53C0", VA = "0x1832F67C0")]
		private void _HideImmediately()
		{
		}

		// Token: 0x0600B40B RID: 46091 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B40B")]
		[Address(RVA = "0x32F6EA0", Offset = "0x32F5AA0", VA = "0x1832F6EA0")]
		private void _ShowAnim()
		{
		}

		// Token: 0x0600B40C RID: 46092 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B40C")]
		[Address(RVA = "0x32F6A50", Offset = "0x32F5650", VA = "0x1832F6A50")]
		private void _ReloadWithAnim(TOrderSlotStruct slotStruct, TradingInfoViewStruct tradingModel)
		{
		}

		// Token: 0x0600B40D RID: 46093 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B40D")]
		[Address(RVA = "0x32F6960", Offset = "0x32F5560", VA = "0x1832F6960")]
		private IEnumerator _ReloadCoroutine(TOrderSlotStruct slotStruct, TradingInfoViewStruct tradingModel)
		{
			return null;
		}

		// Token: 0x0600B40E RID: 46094 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B40E")]
		private void _DestroyInst<InstType>(ref InstType inst, bool withTransition) where InstType : UnityEngine.Object
		{
		}

		// Token: 0x0600B40F RID: 46095 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B40F")]
		private void _InitContentIfNeeded<PrefabType>(PrefabType prefab, ref PrefabType inst, bool withTransition) where PrefabType : UnityEngine.Object
		{
		}

		// Token: 0x0600B410 RID: 46096 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B410")]
		private CanvasGroup _EnsureCanvasGroup<TargetType>(TargetType inst) where TargetType : UnityEngine.Object
		{
			return null;
		}

		// Token: 0x0600B411 RID: 46097 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B411")]
		private PrefabType _AllocInstFromPool<PrefabType>(PrefabType prefab) where PrefabType : UnityEngine.Object
		{
			return null;
		}

		// Token: 0x0600B412 RID: 46098 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B412")]
		private void _RecycleInstFromPool<PrefabType>(PrefabType inst)
		{
		}

		// Token: 0x0600B413 RID: 46099 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B413")]
		[Address(RVA = "0x32F6800", Offset = "0x32F5400", VA = "0x1832F6800")]
		private void _OnDeleteClicked()
		{
		}

		// Token: 0x0600B414 RID: 46100 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B414")]
		[Address(RVA = "0x32F6820", Offset = "0x32F5420", VA = "0x1832F6820")]
		private void _OnFinishClicked()
		{
		}

		// Token: 0x0600B415 RID: 46101 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B415")]
		[Address(RVA = "0x32F6940", Offset = "0x32F5540", VA = "0x1832F6940")]
		private void _OnLaborAccelClicked()
		{
		}

		// Token: 0x0600B416 RID: 46102 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B416")]
		[Address(RVA = "0x32F70C0", Offset = "0x32F5CC0", VA = "0x1832F70C0")]
		public BuildingTradingOrderView()
		{
		}

		// Token: 0x0400AF8E RID: 44942
		[Token(Token = "0x400AF8E")]
		private const float CONTENT_ANIM_DUR = 0.18f;

		// Token: 0x0400AF8F RID: 44943
		[Token(Token = "0x400AF8F")]
		private const float RELOAD_ANIM_HIDE_DUR = 0.1f;

		// Token: 0x0400AF90 RID: 44944
		[Token(Token = "0x400AF90")]
		private const float RELOAD_ANIM_SHOW_DUR = 0.23f;

		// Token: 0x0400AF91 RID: 44945
		[Token(Token = "0x400AF91")]
		private const float RELOAD_ANIM_HOLD_DUR = 0f;

		// Token: 0x0400AF92 RID: 44946
		[Token(Token = "0x400AF92")]
		public const float RELOAD_ANIM_DELAY_UNIT = 0.06f;

		// Token: 0x0400AF93 RID: 44947
		[Token(Token = "0x400AF93")]
		private const float RELOAD_ANIM_DELAY_MAX_COUNT = 6f;

		// Token: 0x0400AF94 RID: 44948
		[Token(Token = "0x400AF94")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private BuildingTradingGainedOrderView _gainedPrefab;

		// Token: 0x0400AF95 RID: 44949
		[Token(Token = "0x400AF95")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private BuildingTradingGainingOrderView _gainingPrefab;

		// Token: 0x0400AF96 RID: 44950
		[Token(Token = "0x400AF96")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _emptyPrefab;

		// Token: 0x0400AF97 RID: 44951
		[Token(Token = "0x400AF97")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private RectTransform _container;

		// Token: 0x0400AF98 RID: 44952
		[Token(Token = "0x400AF98")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("Effects")]
		private UIAnimationLocation _hideAnim;

		// Token: 0x0400AF99 RID: 44953
		[Token(Token = "0x400AF99")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("Effects")]
		private UIAnimationLocation _showAnim;

		// Token: 0x0400AF9A RID: 44954
		[Token(Token = "0x400AF9A")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("Effects")]
		private UIAnimationLocation _reloadAnim;

		// Token: 0x0400AF9B RID: 44955
		[Token(Token = "0x400AF9B")]
		[FieldOffset(Offset = "0x68")]
		private GameObject m_emptyInst;

		// Token: 0x0400AF9C RID: 44956
		[Token(Token = "0x400AF9C")]
		[FieldOffset(Offset = "0x70")]
		private BuildingTradingGainedOrderView m_gainedInst;

		// Token: 0x0400AF9D RID: 44957
		[Token(Token = "0x400AF9D")]
		[FieldOffset(Offset = "0x78")]
		private BuildingTradingGainingOrderView m_gainingInst;

		// Token: 0x0400AF9E RID: 44958
		[Token(Token = "0x400AF9E")]
		[FieldOffset(Offset = "0x80")]
		[NonSerialized]
		public Action<long> onDeleteClicked;

		// Token: 0x0400AF9F RID: 44959
		[Token(Token = "0x400AF9F")]
		[FieldOffset(Offset = "0x88")]
		[NonSerialized]
		public Action<long> onFinishClicked;

		// Token: 0x0400AFA0 RID: 44960
		[Token(Token = "0x400AFA0")]
		[FieldOffset(Offset = "0x90")]
		[NonSerialized]
		public Action onLaborAccelClicked;

		// Token: 0x0400AFA1 RID: 44961
		[Token(Token = "0x400AFA1")]
		[FieldOffset(Offset = "0x98")]
		private ListDict<Type, UnityEngine.Object> m_instPool;

		// Token: 0x0400AFA2 RID: 44962
		[Token(Token = "0x400AFA2")]
		[FieldOffset(Offset = "0xA0")]
		private long m_orderId;

		// Token: 0x0400AFA5 RID: 44965
		[Token(Token = "0x400AFA5")]
		[FieldOffset(Offset = "0xB0")]
		private Tween m_destroyInstTween;

		// Token: 0x0400AFA6 RID: 44966
		[Token(Token = "0x400AFA6")]
		[FieldOffset(Offset = "0xB8")]
		private CanvasGroup m_destroyAlpha;

		// Token: 0x0400AFA7 RID: 44967
		[Token(Token = "0x400AFA7")]
		[FieldOffset(Offset = "0xC0")]
		private Tween m_instantInstTween;

		// Token: 0x0400AFA8 RID: 44968
		[Token(Token = "0x400AFA8")]
		[FieldOffset(Offset = "0xC8")]
		private CanvasGroup m_instantAlpha;

		// Token: 0x0400AFA9 RID: 44969
		[Token(Token = "0x400AFA9")]
		[FieldOffset(Offset = "0xD0")]
		private UIAnimationTween m_hideViewAnim;

		// Token: 0x0400AFAA RID: 44970
		[Token(Token = "0x400AFAA")]
		[FieldOffset(Offset = "0xD8")]
		private UIAnimationTween m_showViewAnim;

		// Token: 0x0400AFAB RID: 44971
		[Token(Token = "0x400AFAB")]
		[FieldOffset(Offset = "0xE0")]
		private Coroutine m_reloadCoroutine;
	}
}
