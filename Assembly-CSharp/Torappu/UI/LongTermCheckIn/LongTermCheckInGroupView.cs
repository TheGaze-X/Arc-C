using System;
using System.Collections.Generic;
using AdvancedInspector;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.LongTermCheckIn
{
	// Token: 0x020049BA RID: 18874
	[Token(Token = "0x20049BA")]
	public class LongTermCheckInGroupView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601C6FB RID: 116475 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C6FB")]
		[Address(RVA = "0x15E4AD0", Offset = "0x15E36D0", VA = "0x1815E4AD0")]
		public void Render(LongTermCheckInGroupViewModel model)
		{
		}

		// Token: 0x0601C6FC RID: 116476 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C6FC")]
		[Address(RVA = "0x15E4D20", Offset = "0x15E3920", VA = "0x1815E4D20")]
		public Tween ShowEntryAnim()
		{
			return null;
		}

		// Token: 0x0601C6FD RID: 116477 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C6FD")]
		[Address(RVA = "0x15E4DB0", Offset = "0x15E39B0", VA = "0x1815E4DB0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601C6FE RID: 116478 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C6FE")]
		[Address(RVA = "0x15E4F90", Offset = "0x15E3B90", VA = "0x1815E4F90")]
		public LongTermCheckInGroupView()
		{
		}

		// Token: 0x04025410 RID: 152592
		[Token(Token = "0x4025410")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Group("Title")]
		private Image _imgTitle;

		// Token: 0x04025411 RID: 152593
		[Token(Token = "0x4025411")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Group("Title")]
		private Text _textNickName;

		// Token: 0x04025412 RID: 152594
		[Token(Token = "0x4025412")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("Desc")]
		private GameObject _panelDescUncomplete;

		// Token: 0x04025413 RID: 152595
		[Token(Token = "0x4025413")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("Desc")]
		private GameObject _panelDescComplete;

		// Token: 0x04025414 RID: 152596
		[Token(Token = "0x4025414")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("Desc")]
		private Text _textDesc;

		// Token: 0x04025415 RID: 152597
		[Token(Token = "0x4025415")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("Desc")]
		private SimpleLayoutContent _progressContent;

		// Token: 0x04025416 RID: 152598
		[Token(Token = "0x4025416")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("Reward")]
		private Image _imgReward;

		// Token: 0x04025417 RID: 152599
		[Token(Token = "0x4025417")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("Reward")]
		private SimpleLayoutContent _rewardContent;

		// Token: 0x04025418 RID: 152600
		[Token(Token = "0x4025418")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("Reward")]
		private Text _textTip;

		// Token: 0x04025419 RID: 152601
		[Token(Token = "0x4025419")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private UIAnimationLocation _animEntry;

		// Token: 0x0402541A RID: 152602
		[Token(Token = "0x402541A")]
		[FieldOffset(Offset = "0x70")]
		private UICompDialogFinder m_dialogFinder;

		// Token: 0x0402541B RID: 152603
		[Token(Token = "0x402541B")]
		[FieldOffset(Offset = "0x80")]
		private List<LongTermCheckInProgressViewModel> m_cachedProgressList;

		// Token: 0x0402541C RID: 152604
		[Token(Token = "0x402541C")]
		[FieldOffset(Offset = "0x88")]
		private List<ItemBundle> m_cachedReward;

		// Token: 0x0402541D RID: 152605
		[Token(Token = "0x402541D")]
		[FieldOffset(Offset = "0x90")]
		private LongTermCheckInGroupView.ProgressAdapter m_progressAdapter;

		// Token: 0x0402541E RID: 152606
		[Token(Token = "0x402541E")]
		[FieldOffset(Offset = "0x98")]
		private LongTermCheckInGroupView.RewardAdapter m_rewardAdapter;

		// Token: 0x0402541F RID: 152607
		[Token(Token = "0x402541F")]
		[FieldOffset(Offset = "0xA0")]
		private bool m_hasReceived;

		// Token: 0x04025420 RID: 152608
		[Token(Token = "0x4025420")]
		[FieldOffset(Offset = "0xA1")]
		private bool m_hasInited;

		// Token: 0x04025421 RID: 152609
		[Token(Token = "0x4025421")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04025422 RID: 152610
		[Token(Token = "0x4025422")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_ShowEntryAnim;

		// Token: 0x04025423 RID: 152611
		[Token(Token = "0x4025423")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04025424 RID: 152612
		[Token(Token = "0x4025424")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020049BB RID: 18875
		[Token(Token = "0x20049BB")]
		private class ProgressAdapter : SimpleLayoutAdapter, IHotfixable
		{
			// Token: 0x0601C6FF RID: 116479 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601C6FF")]
			[Address(RVA = "0x15F04E0", Offset = "0x15EF0E0", VA = "0x1815F04E0")]
			public ProgressAdapter(LongTermCheckInGroupView closure)
			{
			}

			// Token: 0x1700435A RID: 17242
			// (get) Token: 0x0601C700 RID: 116480 RVA: 0x000A8690 File Offset: 0x000A6890
			[Token(Token = "0x1700435A")]
			public override int count
			{
				[Token(Token = "0x601C700")]
				[Address(RVA = "0x15F0560", Offset = "0x15EF160", VA = "0x1815F0560", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601C701 RID: 116481 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601C701")]
			[Address(RVA = "0x15F0290", Offset = "0x15EEE90", VA = "0x1815F0290", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x04025425 RID: 152613
			[Token(Token = "0x4025425")]
			[FieldOffset(Offset = "0x20")]
			private LongTermCheckInGroupView m_closure;

			// Token: 0x04025426 RID: 152614
			[Token(Token = "0x4025426")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04025427 RID: 152615
			[Token(Token = "0x4025427")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04025428 RID: 152616
			[Token(Token = "0x4025428")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}

		// Token: 0x020049BC RID: 18876
		[Token(Token = "0x20049BC")]
		private class RewardAdapter : SimpleLayoutAdapter, IHotfixable
		{
			// Token: 0x0601C702 RID: 116482 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601C702")]
			[Address(RVA = "0x15F07E0", Offset = "0x15EF3E0", VA = "0x1815F07E0")]
			public RewardAdapter(LongTermCheckInGroupView closure)
			{
			}

			// Token: 0x1700435B RID: 17243
			// (get) Token: 0x0601C703 RID: 116483 RVA: 0x000A86A8 File Offset: 0x000A68A8
			[Token(Token = "0x1700435B")]
			public override int count
			{
				[Token(Token = "0x601C703")]
				[Address(RVA = "0x15F0860", Offset = "0x15EF460", VA = "0x1815F0860", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601C704 RID: 116484 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601C704")]
			[Address(RVA = "0x15F0620", Offset = "0x15EF220", VA = "0x1815F0620", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x04025429 RID: 152617
			[Token(Token = "0x4025429")]
			[FieldOffset(Offset = "0x20")]
			private LongTermCheckInGroupView m_closure;

			// Token: 0x0402542A RID: 152618
			[Token(Token = "0x402542A")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402542B RID: 152619
			[Token(Token = "0x402542B")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0402542C RID: 152620
			[Token(Token = "0x402542C")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
