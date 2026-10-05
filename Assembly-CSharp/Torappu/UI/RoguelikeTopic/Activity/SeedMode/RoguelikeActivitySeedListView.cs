using System;
using System.Collections.Generic;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.RoguelikeTopic.Activity.SeedMode
{
	// Token: 0x020046B0 RID: 18096
	[Token(Token = "0x20046B0")]
	public class RoguelikeActivitySeedListView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601B72F RID: 112431 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B72F")]
		[Address(RVA = "0x14D6050", Offset = "0x14D4C50", VA = "0x1814D6050")]
		public void Render(RoguelikeActivitySeedListModel model, ILoadAsset iLoadAsset)
		{
		}

		// Token: 0x0601B730 RID: 112432 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B730")]
		[Address(RVA = "0x14D65B0", Offset = "0x14D51B0", VA = "0x1814D65B0")]
		private void _Render(RoguelikeActivitySeedListModel model)
		{
		}

		// Token: 0x0601B731 RID: 112433 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B731")]
		[Address(RVA = "0x14D6420", Offset = "0x14D5020", VA = "0x1814D6420")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601B732 RID: 112434 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B732")]
		[Address(RVA = "0x14D6830", Offset = "0x14D5430", VA = "0x1814D6830")]
		public RoguelikeActivitySeedListView()
		{
		}

		// Token: 0x0402386F RID: 145519
		[Token(Token = "0x402386F")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SimpleLayoutContent _itemContent;

		// Token: 0x04023870 RID: 145520
		[Token(Token = "0x4023870")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CanvasGroup _itemGroup;

		// Token: 0x04023871 RID: 145521
		[Token(Token = "0x4023871")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _fadeDuration;

		// Token: 0x04023872 RID: 145522
		[Token(Token = "0x4023872")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private List<RoguelikeActivitySeedListTag> _seedTypeTags;

		// Token: 0x04023873 RID: 145523
		[Token(Token = "0x4023873")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _tipsHistory;

		// Token: 0x04023874 RID: 145524
		[Token(Token = "0x4023874")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _tipsPredefine;

		// Token: 0x04023875 RID: 145525
		[Token(Token = "0x4023875")]
		[FieldOffset(Offset = "0x48")]
		private RoguelikeActivitySeedListView.SeedListAdapter m_adapter;

		// Token: 0x04023876 RID: 145526
		[Token(Token = "0x4023876")]
		[FieldOffset(Offset = "0x50")]
		private bool m_isInited;

		// Token: 0x04023877 RID: 145527
		[Token(Token = "0x4023877")]
		[FieldOffset(Offset = "0x58")]
		private RoguelikeActivitySeedListModel m_cachedModel;

		// Token: 0x04023878 RID: 145528
		[Token(Token = "0x4023878")]
		[FieldOffset(Offset = "0x60")]
		private int m_switchTagSequenceNum;

		// Token: 0x04023879 RID: 145529
		[Token(Token = "0x4023879")]
		[FieldOffset(Offset = "0x68")]
		private Sequence m_switchSequence;

		// Token: 0x0402387A RID: 145530
		[Token(Token = "0x402387A")]
		[FieldOffset(Offset = "0x70")]
		private ILoadAsset m_iLoadAsset;

		// Token: 0x0402387B RID: 145531
		[Token(Token = "0x402387B")]
		[FieldOffset(Offset = "0x78")]
		[NonSerialized]
		public Action<SeedItemType> onClickSwitchTag;

		// Token: 0x0402387C RID: 145532
		[Token(Token = "0x402387C")]
		[FieldOffset(Offset = "0x80")]
		[NonSerialized]
		public Action<string> onClickSelectSeed;

		// Token: 0x0402387D RID: 145533
		[Token(Token = "0x402387D")]
		[FieldOffset(Offset = "0x88")]
		[NonSerialized]
		public Action<string> onClickCopySeed;

		// Token: 0x0402387E RID: 145534
		[Token(Token = "0x402387E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402387F RID: 145535
		[Token(Token = "0x402387F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__Render;

		// Token: 0x04023880 RID: 145536
		[Token(Token = "0x4023880")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04023881 RID: 145537
		[Token(Token = "0x4023881")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020046B1 RID: 18097
		[Token(Token = "0x20046B1")]
		private class SeedListAdapter : SimpleLayoutAdapter
		{
			// Token: 0x0601B733 RID: 112435 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B733")]
			[Address(RVA = "0x14D7D90", Offset = "0x14D6990", VA = "0x1814D7D90")]
			public SeedListAdapter(RoguelikeActivitySeedListView closure)
			{
			}

			// Token: 0x17004156 RID: 16726
			// (get) Token: 0x0601B734 RID: 112436 RVA: 0x000A53A8 File Offset: 0x000A35A8
			[Token(Token = "0x17004156")]
			public override int count
			{
				[Token(Token = "0x601B734")]
				[Address(RVA = "0x14D7E10", Offset = "0x14D6A10", VA = "0x1814D7E10", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601B735 RID: 112437 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601B735")]
			[Address(RVA = "0x14D7B20", Offset = "0x14D6720", VA = "0x1814D7B20", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x04023882 RID: 145538
			[Token(Token = "0x4023882")]
			[FieldOffset(Offset = "0x20")]
			private RoguelikeActivitySeedListView m_closure;

			// Token: 0x04023883 RID: 145539
			[Token(Token = "0x4023883")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04023884 RID: 145540
			[Token(Token = "0x4023884")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04023885 RID: 145541
			[Token(Token = "0x4023885")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
