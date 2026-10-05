using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Squad
{
	// Token: 0x02003E1F RID: 15903
	[Token(Token = "0x2003E1F")]
	public class SquadFriendView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06018BA5 RID: 101285 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018BA5")]
		[Address(RVA = "0x113D550", Offset = "0x113C150", VA = "0x18113D550")]
		public void Clear()
		{
		}

		// Token: 0x06018BA6 RID: 101286 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018BA6")]
		[Address(RVA = "0x113DCD0", Offset = "0x113C8D0", VA = "0x18113DCD0")]
		private void _RenderCountDownValue(CountDownTask.TickValue tick)
		{
		}

		// Token: 0x06018BA7 RID: 101287 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018BA7")]
		[Address(RVA = "0x113D420", Offset = "0x113C020", VA = "0x18113D420")]
		public void ApplyTabData(List<ProfessionCategory> professionList, ProfessionCategory selectProfession, Action<ProfessionCategory> clickAction)
		{
		}

		// Token: 0x06018BA8 RID: 101288 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018BA8")]
		[Address(RVA = "0x113D5F0", Offset = "0x113C1F0", VA = "0x18113D5F0")]
		public void UpdateSelectProfessionTab(ProfessionCategory selectProfession)
		{
		}

		// Token: 0x06018BA9 RID: 101289 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018BA9")]
		[Address(RVA = "0x113D180", Offset = "0x113BD80", VA = "0x18113D180")]
		public void ApplyData(List<SquadAssistData> assistList, EvolvePhaseAndLevel maxEvolvePhaseAndLevel, SquadFriendAssistState.IPlugin statePlugin, DateTime allowAstTs)
		{
		}

		// Token: 0x06018BAA RID: 101290 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018BAA")]
		[Address(RVA = "0x113DB90", Offset = "0x113C790", VA = "0x18113DB90")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06018BAB RID: 101291 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018BAB")]
		[Address(RVA = "0x113D6E0", Offset = "0x113C2E0", VA = "0x18113D6E0")]
		private void _ClearFriendList()
		{
		}

		// Token: 0x06018BAC RID: 101292 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018BAC")]
		[Address(RVA = "0x113D750", Offset = "0x113C350", VA = "0x18113D750")]
		private void _DealRefreshStatus(DateTime newAllowTs)
		{
		}

		// Token: 0x06018BAD RID: 101293 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018BAD")]
		[Address(RVA = "0x113DAA0", Offset = "0x113C6A0", VA = "0x18113DAA0")]
		private void _EnableRefreshButton()
		{
		}

		// Token: 0x06018BAE RID: 101294 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018BAE")]
		[Address(RVA = "0x113D670", Offset = "0x113C270", VA = "0x18113D670")]
		private void Update()
		{
		}

		// Token: 0x06018BAF RID: 101295 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018BAF")]
		[Address(RVA = "0x113DC30", Offset = "0x113C830", VA = "0x18113DC30")]
		private void _OnTabSelected(ProfessionCategory profession)
		{
		}

		// Token: 0x06018BB0 RID: 101296 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018BB0")]
		[Address(RVA = "0x113DE80", Offset = "0x113CA80", VA = "0x18113DE80")]
		public SquadFriendView()
		{
		}

		// Token: 0x0401E5F3 RID: 124403
		[Token(Token = "0x401E5F3")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SquadFriendTabGroupView _tabGroupView;

		// Token: 0x0401E5F4 RID: 124404
		[Token(Token = "0x401E5F4")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform _friendContainer;

		// Token: 0x0401E5F5 RID: 124405
		[Token(Token = "0x401E5F5")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private SimpleLayoutContent _simpleLayout;

		// Token: 0x0401E5F6 RID: 124406
		[Token(Token = "0x401E5F6")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UIFriendEvent _applyAssistEvent;

		// Token: 0x0401E5F7 RID: 124407
		[Token(Token = "0x401E5F7")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _titleText;

		// Token: 0x0401E5F8 RID: 124408
		[Token(Token = "0x401E5F8")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _remainRefreshTimes;

		// Token: 0x0401E5F9 RID: 124409
		[Token(Token = "0x401E5F9")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _refreshButton;

		// Token: 0x0401E5FA RID: 124410
		[Token(Token = "0x401E5FA")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _refreshGroup;

		// Token: 0x0401E5FB RID: 124411
		[Token(Token = "0x401E5FB")]
		[FieldOffset(Offset = "0x58")]
		private CountDownTask m_countDownTask;

		// Token: 0x0401E5FC RID: 124412
		[Token(Token = "0x401E5FC")]
		[FieldOffset(Offset = "0x60")]
		private DateTime m_refreshDataTime;

		// Token: 0x0401E5FD RID: 124413
		[Token(Token = "0x401E5FD")]
		[FieldOffset(Offset = "0x68")]
		private Action<ProfessionCategory> m_tabClickAction;

		// Token: 0x0401E5FE RID: 124414
		[Token(Token = "0x401E5FE")]
		[FieldOffset(Offset = "0x70")]
		private bool m_isRefreshPending;

		// Token: 0x0401E5FF RID: 124415
		[Token(Token = "0x401E5FF")]
		[FieldOffset(Offset = "0x78")]
		private SquadFriendView.AssistAdapter m_adapter;

		// Token: 0x0401E600 RID: 124416
		[Token(Token = "0x401E600")]
		[FieldOffset(Offset = "0x80")]
		private bool m_isInited;

		// Token: 0x0401E601 RID: 124417
		[Token(Token = "0x401E601")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Clear;

		// Token: 0x0401E602 RID: 124418
		[Token(Token = "0x401E602")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__RenderCountDownValue;

		// Token: 0x0401E603 RID: 124419
		[Token(Token = "0x401E603")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ApplyTabData;

		// Token: 0x0401E604 RID: 124420
		[Token(Token = "0x401E604")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_UpdateSelectProfessionTab;

		// Token: 0x0401E605 RID: 124421
		[Token(Token = "0x401E605")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_ApplyData;

		// Token: 0x0401E606 RID: 124422
		[Token(Token = "0x401E606")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401E607 RID: 124423
		[Token(Token = "0x401E607")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__ClearFriendList;

		// Token: 0x0401E608 RID: 124424
		[Token(Token = "0x401E608")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__DealRefreshStatus;

		// Token: 0x0401E609 RID: 124425
		[Token(Token = "0x401E609")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__EnableRefreshButton;

		// Token: 0x0401E60A RID: 124426
		[Token(Token = "0x401E60A")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x0401E60B RID: 124427
		[Token(Token = "0x401E60B")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__OnTabSelected;

		// Token: 0x0401E60C RID: 124428
		[Token(Token = "0x401E60C")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003E20 RID: 15904
		[Token(Token = "0x2003E20")]
		public class AssistAdapter : SimpleLayoutAdapter
		{
			// Token: 0x17003AEB RID: 15083
			// (get) Token: 0x06018BB1 RID: 101297 RVA: 0x0009B838 File Offset: 0x00099A38
			[Token(Token = "0x17003AEB")]
			public override int count
			{
				[Token(Token = "0x6018BB1")]
				[Address(RVA = "0x1135680", Offset = "0x1134280", VA = "0x181135680", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06018BB2 RID: 101298 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6018BB2")]
			[Address(RVA = "0x11353E0", Offset = "0x1133FE0", VA = "0x1811353E0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x06018BB3 RID: 101299 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6018BB3")]
			[Address(RVA = "0x1135620", Offset = "0x1134220", VA = "0x181135620")]
			public AssistAdapter()
			{
			}

			// Token: 0x0401E60D RID: 124429
			[Token(Token = "0x401E60D")]
			[FieldOffset(Offset = "0x20")]
			public List<SquadAssistData> assistList;

			// Token: 0x0401E60E RID: 124430
			[Token(Token = "0x401E60E")]
			[FieldOffset(Offset = "0x28")]
			public EvolvePhaseAndLevel maxEvolvePhaseAndLevel;

			// Token: 0x0401E60F RID: 124431
			[Token(Token = "0x401E60F")]
			[FieldOffset(Offset = "0x30")]
			public SquadFriendAssistState.IPlugin statePlugin;

			// Token: 0x0401E610 RID: 124432
			[Token(Token = "0x401E610")]
			[FieldOffset(Offset = "0x38")]
			public UIFriendEvent applyAssistEvent;

			// Token: 0x0401E611 RID: 124433
			[Token(Token = "0x401E611")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0401E612 RID: 124434
			[Token(Token = "0x401E612")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x0401E613 RID: 124435
			[Token(Token = "0x401E613")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
