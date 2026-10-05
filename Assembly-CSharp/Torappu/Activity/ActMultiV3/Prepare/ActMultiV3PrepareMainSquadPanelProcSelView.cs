using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.ActMultiV3.Prepare
{
	// Token: 0x02007072 RID: 28786
	[Token(Token = "0x2007072")]
	public class ActMultiV3PrepareMainSquadPanelProcSelView : ActMultiV3PrepareMainSquadPanelProcViewBase
	{
		// Token: 0x170060AD RID: 24749
		// (get) Token: 0x06028E22 RID: 167458 RVA: 0x000D37A0 File Offset: 0x000D19A0
		[Token(Token = "0x170060AD")]
		public override ActMultiV3PrepareMainSquadProc procType
		{
			[Token(Token = "0x6028E22")]
			[Address(RVA = "0x245A020", Offset = "0x2458C20", VA = "0x18245A020", Slot = "9")]
			get
			{
				return ActMultiV3PrepareMainSquadProc.NONE;
			}
		}

		// Token: 0x06028E23 RID: 167459 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028E23")]
		[Address(RVA = "0x2459650", Offset = "0x2458250", VA = "0x182459650", Slot = "10")]
		protected override void OnUpdate(ActMultiV3PrepareMainSquadPanelViewModel model)
		{
		}

		// Token: 0x06028E24 RID: 167460 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028E24")]
		[Address(RVA = "0x2459CD0", Offset = "0x24588D0", VA = "0x182459CD0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06028E25 RID: 167461 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028E25")]
		[Address(RVA = "0x2459590", Offset = "0x2458190", VA = "0x182459590")]
		public void EventOnNext()
		{
		}

		// Token: 0x06028E26 RID: 167462 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028E26")]
		[Address(RVA = "0x2459AF0", Offset = "0x24586F0", VA = "0x182459AF0")]
		private void _EventAddToSquad(int instId)
		{
		}

		// Token: 0x06028E27 RID: 167463 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028E27")]
		[Address(RVA = "0x2459BE0", Offset = "0x24587E0", VA = "0x182459BE0")]
		private void _EventRemoveFromSquad(int instId)
		{
		}

		// Token: 0x06028E28 RID: 167464 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028E28")]
		[Address(RVA = "0x2459FC0", Offset = "0x2458BC0", VA = "0x182459FC0")]
		public ActMultiV3PrepareMainSquadPanelProcSelView()
		{
		}

		// Token: 0x06028E29 RID: 167465 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028E29")]
		[Address(RVA = "0x2459360", Offset = "0x2457F60", VA = "0x182459360")]
		private void <>xLuaBaseProxy_OnUpdate(ActMultiV3PrepareMainSquadPanelViewModel P0)
		{
		}

		// Token: 0x0403A505 RID: 238853
		[Token(Token = "0x403A505")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private PrefabMark _invertTips;

		// Token: 0x0403A506 RID: 238854
		[Token(Token = "0x403A506")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private TwoStateToggle _btnNext;

		// Token: 0x0403A507 RID: 238855
		[Token(Token = "0x403A507")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _cnt;

		// Token: 0x0403A508 RID: 238856
		[Token(Token = "0x403A508")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _minCntTips;

		// Token: 0x0403A509 RID: 238857
		[Token(Token = "0x403A509")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private SimpleLayoutContent _squad;

		// Token: 0x0403A50A RID: 238858
		[Token(Token = "0x403A50A")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private SimpleLayoutContent _reserveList;

		// Token: 0x0403A50B RID: 238859
		[Token(Token = "0x403A50B")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private UIAnimationLocation _reserveAnim;

		// Token: 0x0403A50C RID: 238860
		[Token(Token = "0x403A50C")]
		[FieldOffset(Offset = "0x80")]
		private int m_cachedTempHelpSeq;

		// Token: 0x0403A50D RID: 238861
		[Token(Token = "0x403A50D")]
		[FieldOffset(Offset = "0x88")]
		private ActMultiV3PrepareMainSquadPanelProcSelView.SquadAdapter m_squadAdapter;

		// Token: 0x0403A50E RID: 238862
		[Token(Token = "0x403A50E")]
		[FieldOffset(Offset = "0x90")]
		private ActMultiV3PrepareMainSquadPanelProcSelView.ReserveAdapter m_reserveAdapter;

		// Token: 0x0403A50F RID: 238863
		[Token(Token = "0x403A50F")]
		[FieldOffset(Offset = "0x98")]
		private AnimationSwitchTween m_reserveSwitch;

		// Token: 0x0403A510 RID: 238864
		[Token(Token = "0x403A510")]
		private const string CNT_NORMAL_FMT = "<color=#a0a0a0>{0}/</color>{1}";

		// Token: 0x0403A511 RID: 238865
		[Token(Token = "0x403A511")]
		private const string CNT_LOW_FMT = "<color=#d80230>{0}/</color>{1}";

		// Token: 0x0403A512 RID: 238866
		[Token(Token = "0x403A512")]
		private const string CNT_FULL_FMT = "{0}<color=#a0a0a0>/</color>{1}";

		// Token: 0x0403A513 RID: 238867
		[Token(Token = "0x403A513")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_procType;

		// Token: 0x0403A514 RID: 238868
		[Token(Token = "0x403A514")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnUpdate;

		// Token: 0x0403A515 RID: 238869
		[Token(Token = "0x403A515")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403A516 RID: 238870
		[Token(Token = "0x403A516")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventOnNext;

		// Token: 0x0403A517 RID: 238871
		[Token(Token = "0x403A517")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__EventAddToSquad;

		// Token: 0x0403A518 RID: 238872
		[Token(Token = "0x403A518")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__EventRemoveFromSquad;

		// Token: 0x0403A519 RID: 238873
		[Token(Token = "0x403A519")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02007073 RID: 28787
		[Token(Token = "0x2007073")]
		private class SquadAdapter : SimpleLayoutAdapter
		{
			// Token: 0x170060AE RID: 24750
			// (get) Token: 0x06028E2A RID: 167466 RVA: 0x000D37B8 File Offset: 0x000D19B8
			[Token(Token = "0x170060AE")]
			public override int count
			{
				[Token(Token = "0x6028E2A")]
				[Address(RVA = "0x2462580", Offset = "0x2461180", VA = "0x182462580", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06028E2B RID: 167467 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6028E2B")]
			[Address(RVA = "0x2462150", Offset = "0x2460D50", VA = "0x182462150", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x06028E2C RID: 167468 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6028E2C")]
			[Address(RVA = "0x24624B0", Offset = "0x24610B0", VA = "0x1824624B0")]
			public SquadAdapter()
			{
			}

			// Token: 0x0403A51A RID: 238874
			[Token(Token = "0x403A51A")]
			[FieldOffset(Offset = "0x20")]
			public List<ActMultiV3PrepareMainSmallCharCardModel> squad;

			// Token: 0x0403A51B RID: 238875
			[Token(Token = "0x403A51B")]
			[FieldOffset(Offset = "0x28")]
			public Action<int> cardClick;

			// Token: 0x0403A51C RID: 238876
			[Token(Token = "0x403A51C")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0403A51D RID: 238877
			[Token(Token = "0x403A51D")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x0403A51E RID: 238878
			[Token(Token = "0x403A51E")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02007074 RID: 28788
		[Token(Token = "0x2007074")]
		private class ReserveAdapter : SimpleLayoutAdapter
		{
			// Token: 0x170060AF RID: 24751
			// (get) Token: 0x06028E2D RID: 167469 RVA: 0x000D37D0 File Offset: 0x000D19D0
			[Token(Token = "0x170060AF")]
			public override int count
			{
				[Token(Token = "0x6028E2D")]
				[Address(RVA = "0x24620E0", Offset = "0x2460CE0", VA = "0x1824620E0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06028E2E RID: 167470 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6028E2E")]
			[Address(RVA = "0x2461EA0", Offset = "0x2460AA0", VA = "0x182461EA0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x06028E2F RID: 167471 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6028E2F")]
			[Address(RVA = "0x2462080", Offset = "0x2460C80", VA = "0x182462080")]
			public ReserveAdapter()
			{
			}

			// Token: 0x0403A51F RID: 238879
			[Token(Token = "0x403A51F")]
			[FieldOffset(Offset = "0x20")]
			public List<ActMultiV3PrepareMainSquadPanelReserveCharCardModel> charList;

			// Token: 0x0403A520 RID: 238880
			[Token(Token = "0x403A520")]
			[FieldOffset(Offset = "0x28")]
			public Action<int> cardClick;

			// Token: 0x0403A521 RID: 238881
			[Token(Token = "0x403A521")]
			[FieldOffset(Offset = "0x30")]
			public bool isPlayAudio;

			// Token: 0x0403A522 RID: 238882
			[Token(Token = "0x403A522")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0403A523 RID: 238883
			[Token(Token = "0x403A523")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x0403A524 RID: 238884
			[Token(Token = "0x403A524")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
