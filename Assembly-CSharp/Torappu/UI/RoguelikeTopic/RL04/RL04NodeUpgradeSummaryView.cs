using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.DataBind;
using Torappu.UI.Roguelike.RL04;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.RoguelikeTopic.RL04
{
	// Token: 0x020046BB RID: 18107
	[Token(Token = "0x20046BB")]
	public class RL04NodeUpgradeSummaryView : DataBinder<RL04NodeUpgradeSummaryProp>
	{
		// Token: 0x17004162 RID: 16738
		// (get) Token: 0x0601B765 RID: 112485 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601B766 RID: 112486 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004162")]
		public Action<RoguelikeEventType> onBtnTypeClick
		{
			[Token(Token = "0x601B765")]
			[Address(RVA = "0x14CD470", Offset = "0x14CC070", VA = "0x1814CD470")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601B766")]
			[Address(RVA = "0x14CD4D0", Offset = "0x14CC0D0", VA = "0x1814CD4D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0601B767 RID: 112487 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B767")]
		[Address(RVA = "0x14CC220", Offset = "0x14CAE20", VA = "0x1814CC220", Slot = "7")]
		public override void OnValueChanged(RL04NodeUpgradeSummaryProp property)
		{
		}

		// Token: 0x0601B768 RID: 112488 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B768")]
		[Address(RVA = "0x14CCD50", Offset = "0x14CB950", VA = "0x1814CCD50")]
		private void _RenderView(RL04NodeUpgradeConfig nodeConfig)
		{
		}

		// Token: 0x0601B769 RID: 112489 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601B769")]
		[Address(RVA = "0x14CC420", Offset = "0x14CB020", VA = "0x1814CC420")]
		private List<int> _GenerateShowAnimIdxList()
		{
			return null;
		}

		// Token: 0x0601B76A RID: 112490 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B76A")]
		[Address(RVA = "0x14CC980", Offset = "0x14CB580", VA = "0x1814CC980")]
		private void _PlayEnterAnimIfNeed()
		{
		}

		// Token: 0x0601B76B RID: 112491 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B76B")]
		[Address(RVA = "0x14CCB50", Offset = "0x14CB750", VA = "0x1814CCB50")]
		private void _PlaySwitchAnimIfNeed()
		{
		}

		// Token: 0x0601B76C RID: 112492 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B76C")]
		[Address(RVA = "0x14CC680", Offset = "0x14CB280", VA = "0x1814CC680")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601B76D RID: 112493 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B76D")]
		[Address(RVA = "0x14CC3A0", Offset = "0x14CAFA0", VA = "0x1814CC3A0")]
		public void SetConfigFetcher(INodeConfigFetcher configFetcher)
		{
		}

		// Token: 0x0601B76E RID: 112494 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B76E")]
		[Address(RVA = "0x14CD3A0", Offset = "0x14CBFA0", VA = "0x1814CD3A0")]
		public RL04NodeUpgradeSummaryView()
		{
		}

		// Token: 0x040238C7 RID: 145607
		[Token(Token = "0x40238C7")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _imgTitle;

		// Token: 0x040238C8 RID: 145608
		[Token(Token = "0x40238C8")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textTypeName;

		// Token: 0x040238C9 RID: 145609
		[Token(Token = "0x40238C9")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private RL04NodeUpgradeMuralView _muralPrefab;

		// Token: 0x040238CA RID: 145610
		[Token(Token = "0x40238CA")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private RectTransform _muralContainer;

		// Token: 0x040238CB RID: 145611
		[Token(Token = "0x40238CB")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float _muralPermCompleteDuration;

		// Token: 0x040238CC RID: 145612
		[Token(Token = "0x40238CC")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private ScrollRect _scrollRect;

		// Token: 0x040238CD RID: 145613
		[Token(Token = "0x40238CD")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private SimpleLayoutContent _btnTypeList;

		// Token: 0x040238CE RID: 145614
		[Token(Token = "0x40238CE")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private SimpleLayoutContent _permList;

		// Token: 0x040238CF RID: 145615
		[Token(Token = "0x40238CF")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private SimpleLayoutContent _tempList;

		// Token: 0x040238D0 RID: 145616
		[Token(Token = "0x40238D0")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private UIAtlasImage _imgTempCaptionLine;

		// Token: 0x040238D1 RID: 145617
		[Token(Token = "0x40238D1")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private UIAtlasImage _imgTempInfoLine;

		// Token: 0x040238D2 RID: 145618
		[Token(Token = "0x40238D2")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Text _textTempCaption1;

		// Token: 0x040238D3 RID: 145619
		[Token(Token = "0x40238D3")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Text _textTempCaption2;

		// Token: 0x040238D4 RID: 145620
		[Token(Token = "0x40238D4")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private GameObject _lockTempIconGo;

		// Token: 0x040238D5 RID: 145621
		[Token(Token = "0x40238D5")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private GameObject _todoTempIconGo;

		// Token: 0x040238D6 RID: 145622
		[Token(Token = "0x40238D6")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Text _textTempCost;

		// Token: 0x040238D7 RID: 145623
		[Token(Token = "0x40238D7")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private UIAnimationLocation _animEnter;

		// Token: 0x040238D8 RID: 145624
		[Token(Token = "0x40238D8")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private UIAnimationLocation _animSwitch;

		// Token: 0x040238D9 RID: 145625
		[Token(Token = "0x40238D9")]
		[FieldOffset(Offset = "0xC0")]
		private INodeConfigFetcher m_configFetcher;

		// Token: 0x040238DA RID: 145626
		[Token(Token = "0x40238DA")]
		[FieldOffset(Offset = "0xC8")]
		private bool m_hasInited;

		// Token: 0x040238DB RID: 145627
		[Token(Token = "0x40238DB")]
		[FieldOffset(Offset = "0xD0")]
		private RL04NodeUpgradeMuralView m_muralView;

		// Token: 0x040238DC RID: 145628
		[Token(Token = "0x40238DC")]
		[FieldOffset(Offset = "0xD8")]
		private RL04NodeUpgradeModel m_currUpgradeModel;

		// Token: 0x040238DD RID: 145629
		[Token(Token = "0x40238DD")]
		[FieldOffset(Offset = "0xE0")]
		private RL04NodeUpgradeSummaryModel m_summaryModel;

		// Token: 0x040238DE RID: 145630
		[Token(Token = "0x40238DE")]
		[FieldOffset(Offset = "0xE8")]
		private RL04NodeUpgradeSummaryView.BtnTypeListAdapter m_btnTypeListAdapter;

		// Token: 0x040238DF RID: 145631
		[Token(Token = "0x40238DF")]
		[FieldOffset(Offset = "0xF0")]
		private RL04NodeUpgradeSummaryView.PermListAdapter m_permListAdapter;

		// Token: 0x040238E0 RID: 145632
		[Token(Token = "0x40238E0")]
		[FieldOffset(Offset = "0xF8")]
		private RL04NodeUpgradeSummaryView.TempListAdapter m_tempListAdapter;

		// Token: 0x040238E1 RID: 145633
		[Token(Token = "0x40238E1")]
		[FieldOffset(Offset = "0x100")]
		private Tween m_enterTween;

		// Token: 0x040238E2 RID: 145634
		[Token(Token = "0x40238E2")]
		[FieldOffset(Offset = "0x108")]
		private Tween m_switchTween;

		// Token: 0x040238E3 RID: 145635
		[Token(Token = "0x40238E3")]
		[FieldOffset(Offset = "0x110")]
		private int m_cacheEnterSeq;

		// Token: 0x040238E4 RID: 145636
		[Token(Token = "0x40238E4")]
		[FieldOffset(Offset = "0x114")]
		private int m_cacheSwitchSeq;

		// Token: 0x040238E5 RID: 145637
		[Token(Token = "0x40238E5")]
		[FieldOffset(Offset = "0x118")]
		private Dictionary<int, int> m_cacheMuralShowSeqNumDict;

		// Token: 0x040238E7 RID: 145639
		[Token(Token = "0x40238E7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onBtnTypeClick;

		// Token: 0x040238E8 RID: 145640
		[Token(Token = "0x40238E8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onBtnTypeClick;

		// Token: 0x040238E9 RID: 145641
		[Token(Token = "0x40238E9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x040238EA RID: 145642
		[Token(Token = "0x40238EA")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__RenderView;

		// Token: 0x040238EB RID: 145643
		[Token(Token = "0x40238EB")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__GenerateShowAnimIdxList;

		// Token: 0x040238EC RID: 145644
		[Token(Token = "0x40238EC")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__PlayEnterAnimIfNeed;

		// Token: 0x040238ED RID: 145645
		[Token(Token = "0x40238ED")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__PlaySwitchAnimIfNeed;

		// Token: 0x040238EE RID: 145646
		[Token(Token = "0x40238EE")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040238EF RID: 145647
		[Token(Token = "0x40238EF")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_SetConfigFetcher;

		// Token: 0x040238F0 RID: 145648
		[Token(Token = "0x40238F0")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020046BC RID: 18108
		[Token(Token = "0x20046BC")]
		private class PermListAdapter : SimpleLayoutAdapter
		{
			// Token: 0x0601B76F RID: 112495 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B76F")]
			[Address(RVA = "0x14C2EC0", Offset = "0x14C1AC0", VA = "0x1814C2EC0")]
			public PermListAdapter(RL04NodeUpgradeSummaryView closure)
			{
			}

			// Token: 0x17004163 RID: 16739
			// (get) Token: 0x0601B770 RID: 112496 RVA: 0x000A54B0 File Offset: 0x000A36B0
			[Token(Token = "0x17004163")]
			public override int count
			{
				[Token(Token = "0x601B770")]
				[Address(RVA = "0x14C2F40", Offset = "0x14C1B40", VA = "0x1814C2F40", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601B771 RID: 112497 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601B771")]
			[Address(RVA = "0x14C2B60", Offset = "0x14C1760", VA = "0x1814C2B60", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x040238F1 RID: 145649
			[Token(Token = "0x40238F1")]
			[FieldOffset(Offset = "0x20")]
			private RL04NodeUpgradeSummaryView m_closure;

			// Token: 0x040238F2 RID: 145650
			[Token(Token = "0x40238F2")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x040238F3 RID: 145651
			[Token(Token = "0x40238F3")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x040238F4 RID: 145652
			[Token(Token = "0x40238F4")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}

		// Token: 0x020046BD RID: 18109
		[Token(Token = "0x20046BD")]
		private class TempListAdapter : SimpleLayoutAdapter
		{
			// Token: 0x0601B772 RID: 112498 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B772")]
			[Address(RVA = "0x14D81A0", Offset = "0x14D6DA0", VA = "0x1814D81A0")]
			public TempListAdapter(RL04NodeUpgradeSummaryView closure)
			{
			}

			// Token: 0x17004164 RID: 16740
			// (get) Token: 0x0601B773 RID: 112499 RVA: 0x000A54C8 File Offset: 0x000A36C8
			[Token(Token = "0x17004164")]
			public override int count
			{
				[Token(Token = "0x601B773")]
				[Address(RVA = "0x14D8220", Offset = "0x14D6E20", VA = "0x1814D8220", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601B774 RID: 112500 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601B774")]
			[Address(RVA = "0x14D7EF0", Offset = "0x14D6AF0", VA = "0x1814D7EF0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x040238F5 RID: 145653
			[Token(Token = "0x40238F5")]
			[FieldOffset(Offset = "0x20")]
			private RL04NodeUpgradeSummaryView m_closure;

			// Token: 0x040238F6 RID: 145654
			[Token(Token = "0x40238F6")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x040238F7 RID: 145655
			[Token(Token = "0x40238F7")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x040238F8 RID: 145656
			[Token(Token = "0x40238F8")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}

		// Token: 0x020046BE RID: 18110
		[Token(Token = "0x20046BE")]
		private class BtnTypeListAdapter : SimpleLayoutAdapter
		{
			// Token: 0x0601B775 RID: 112501 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B775")]
			[Address(RVA = "0x14C1810", Offset = "0x14C0410", VA = "0x1814C1810")]
			public BtnTypeListAdapter(RL04NodeUpgradeSummaryView closure)
			{
			}

			// Token: 0x17004165 RID: 16741
			// (get) Token: 0x0601B776 RID: 112502 RVA: 0x000A54E0 File Offset: 0x000A36E0
			[Token(Token = "0x17004165")]
			public override int count
			{
				[Token(Token = "0x601B776")]
				[Address(RVA = "0x14C1890", Offset = "0x14C0490", VA = "0x1814C1890", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601B777 RID: 112503 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601B777")]
			[Address(RVA = "0x14C1410", Offset = "0x14C0010", VA = "0x1814C1410", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x040238F9 RID: 145657
			[Token(Token = "0x40238F9")]
			[FieldOffset(Offset = "0x20")]
			private RL04NodeUpgradeSummaryView m_closure;

			// Token: 0x040238FA RID: 145658
			[Token(Token = "0x40238FA")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x040238FB RID: 145659
			[Token(Token = "0x40238FB")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x040238FC RID: 145660
			[Token(Token = "0x40238FC")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
