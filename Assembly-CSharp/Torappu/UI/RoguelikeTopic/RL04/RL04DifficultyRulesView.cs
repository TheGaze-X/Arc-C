using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.RoguelikeTopic.RL04
{
	// Token: 0x020046CA RID: 18122
	[Token(Token = "0x20046CA")]
	public class RL04DifficultyRulesView : MonoBehaviour, IHotfixable
	{
		// Token: 0x1700416A RID: 16746
		// (get) Token: 0x0601B7A3 RID: 112547 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601B7A4 RID: 112548 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700416A")]
		public Func<string, Sprite> funcLoadBuffIcon
		{
			[Token(Token = "0x601B7A3")]
			[Address(RVA = "0x14C5600", Offset = "0x14C4200", VA = "0x1814C5600")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601B7A4")]
			[Address(RVA = "0x14C5720", Offset = "0x14C4320", VA = "0x1814C5720")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700416B RID: 16747
		// (get) Token: 0x0601B7A5 RID: 112549 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601B7A6 RID: 112550 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700416B")]
		public Action funcOpenOuterBuff
		{
			[Token(Token = "0x601B7A5")]
			[Address(RVA = "0x14C56C0", Offset = "0x14C42C0", VA = "0x1814C56C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601B7A6")]
			[Address(RVA = "0x14C5820", Offset = "0x14C4420", VA = "0x1814C5820")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700416C RID: 16748
		// (get) Token: 0x0601B7A7 RID: 112551 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601B7A8 RID: 112552 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700416C")]
		public Action funcOpenColection
		{
			[Token(Token = "0x601B7A7")]
			[Address(RVA = "0x14C5660", Offset = "0x14C4260", VA = "0x1814C5660")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601B7A8")]
			[Address(RVA = "0x14C57A0", Offset = "0x14C43A0", VA = "0x1814C57A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0601B7A9 RID: 112553 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B7A9")]
		[Address(RVA = "0x14C5480", Offset = "0x14C4080", VA = "0x1814C5480")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601B7AA RID: 112554 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B7AA")]
		[Address(RVA = "0x14C4C70", Offset = "0x14C3870", VA = "0x1814C4C70")]
		public void Render(RoguelikeTopicModeViewProperty property)
		{
		}

		// Token: 0x0601B7AB RID: 112555 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B7AB")]
		[Address(RVA = "0x14C5010", Offset = "0x14C3C10", VA = "0x1814C5010")]
		public void SetVisible(bool showRules)
		{
		}

		// Token: 0x0601B7AC RID: 112556 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601B7AC")]
		[Address(RVA = "0x14C53D0", Offset = "0x14C3FD0", VA = "0x1814C53D0")]
		private IEnumerator _DoHide()
		{
			return null;
		}

		// Token: 0x0601B7AD RID: 112557 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B7AD")]
		[Address(RVA = "0x14C5280", Offset = "0x14C3E80", VA = "0x1814C5280")]
		private void _CleanRT()
		{
		}

		// Token: 0x0601B7AE RID: 112558 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B7AE")]
		[Address(RVA = "0x14C4C10", Offset = "0x14C3810", VA = "0x1814C4C10")]
		private void OnDestroy()
		{
		}

		// Token: 0x0601B7AF RID: 112559 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B7AF")]
		[Address(RVA = "0x14C4B00", Offset = "0x14C3700", VA = "0x1814C4B00")]
		public void EventOpenOuterBuff()
		{
		}

		// Token: 0x0601B7B0 RID: 112560 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B7B0")]
		[Address(RVA = "0x14C49F0", Offset = "0x14C35F0", VA = "0x1814C49F0")]
		public void EventOpenCollection()
		{
		}

		// Token: 0x0601B7B1 RID: 112561 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B7B1")]
		[Address(RVA = "0x14C4940", Offset = "0x14C3540", VA = "0x1814C4940")]
		public void EventCloseView()
		{
		}

		// Token: 0x0601B7B2 RID: 112562 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B7B2")]
		[Address(RVA = "0x14C55A0", Offset = "0x14C41A0", VA = "0x1814C55A0")]
		public RL04DifficultyRulesView()
		{
		}

		// Token: 0x0402395A RID: 145754
		[Token(Token = "0x402395A")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIFadeFloatPanel _fadePanel;

		// Token: 0x0402395B RID: 145755
		[Token(Token = "0x402395B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIFullScreenImage _background;

		// Token: 0x0402395C RID: 145756
		[Token(Token = "0x402395C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _relicDesc;

		// Token: 0x0402395D RID: 145757
		[Token(Token = "0x402395D")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _buffDesc;

		// Token: 0x0402395E RID: 145758
		[Token(Token = "0x402395E")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private SimpleLayoutContent _buffList;

		// Token: 0x0402395F RID: 145759
		[Token(Token = "0x402395F")]
		[FieldOffset(Offset = "0x40")]
		private RL04DifficultyRulesView.BuffListAdapter m_buffListAdapter;

		// Token: 0x04023960 RID: 145760
		[Token(Token = "0x4023960")]
		[FieldOffset(Offset = "0x48")]
		private RoguelikeTopicModeViewProperty m_cachedProp;

		// Token: 0x04023961 RID: 145761
		[Token(Token = "0x4023961")]
		[FieldOffset(Offset = "0x50")]
		private Coroutine m_hideCo;

		// Token: 0x04023965 RID: 145765
		[Token(Token = "0x4023965")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_funcLoadBuffIcon;

		// Token: 0x04023966 RID: 145766
		[Token(Token = "0x4023966")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_funcLoadBuffIcon;

		// Token: 0x04023967 RID: 145767
		[Token(Token = "0x4023967")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_funcOpenOuterBuff;

		// Token: 0x04023968 RID: 145768
		[Token(Token = "0x4023968")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_funcOpenOuterBuff;

		// Token: 0x04023969 RID: 145769
		[Token(Token = "0x4023969")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_funcOpenColection;

		// Token: 0x0402396A RID: 145770
		[Token(Token = "0x402396A")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_funcOpenColection;

		// Token: 0x0402396B RID: 145771
		[Token(Token = "0x402396B")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402396C RID: 145772
		[Token(Token = "0x402396C")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402396D RID: 145773
		[Token(Token = "0x402396D")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_SetVisible;

		// Token: 0x0402396E RID: 145774
		[Token(Token = "0x402396E")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__DoHide;

		// Token: 0x0402396F RID: 145775
		[Token(Token = "0x402396F")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__CleanRT;

		// Token: 0x04023970 RID: 145776
		[Token(Token = "0x4023970")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x04023971 RID: 145777
		[Token(Token = "0x4023971")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_EventOpenOuterBuff;

		// Token: 0x04023972 RID: 145778
		[Token(Token = "0x4023972")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_EventOpenCollection;

		// Token: 0x04023973 RID: 145779
		[Token(Token = "0x4023973")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_EventCloseView;

		// Token: 0x04023974 RID: 145780
		[Token(Token = "0x4023974")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020046CB RID: 18123
		[Token(Token = "0x20046CB")]
		private class BuffListAdapter : SimpleLayoutAdapter
		{
			// Token: 0x1700416D RID: 16749
			// (get) Token: 0x0601B7B3 RID: 112563 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0601B7B4 RID: 112564 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x1700416D")]
			public List<RL04DifficultyRulesBuffModel> buffList
			{
				[Token(Token = "0x601B7B3")]
				[Address(RVA = "0x14C1C60", Offset = "0x14C0860", VA = "0x1814C1C60")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x601B7B4")]
				[Address(RVA = "0x14C1DD0", Offset = "0x14C09D0", VA = "0x1814C1DD0")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x0601B7B5 RID: 112565 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B7B5")]
			[Address(RVA = "0x14C1BE0", Offset = "0x14C07E0", VA = "0x1814C1BE0")]
			public BuffListAdapter(RL04DifficultyRulesView view)
			{
			}

			// Token: 0x1700416E RID: 16750
			// (get) Token: 0x0601B7B6 RID: 112566 RVA: 0x000A5570 File Offset: 0x000A3770
			[Token(Token = "0x1700416E")]
			public override int count
			{
				[Token(Token = "0x601B7B6")]
				[Address(RVA = "0x14C1CC0", Offset = "0x14C08C0", VA = "0x1814C1CC0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601B7B7 RID: 112567 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601B7B7")]
			[Address(RVA = "0x14C1980", Offset = "0x14C0580", VA = "0x1814C1980", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x04023975 RID: 145781
			[Token(Token = "0x4023975")]
			[FieldOffset(Offset = "0x20")]
			private RL04DifficultyRulesView m_view;

			// Token: 0x04023977 RID: 145783
			[Token(Token = "0x4023977")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_buffList;

			// Token: 0x04023978 RID: 145784
			[Token(Token = "0x4023978")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_set_buffList;

			// Token: 0x04023979 RID: 145785
			[Token(Token = "0x4023979")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402397A RID: 145786
			[Token(Token = "0x402397A")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0402397B RID: 145787
			[Token(Token = "0x402397B")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
