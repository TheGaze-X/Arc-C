using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.ActivityStage;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act13Side
{
	// Token: 0x02007A02 RID: 31234
	[Token(Token = "0x2007A02")]
	public class Act13sideNormalMissionOneView : MonoBehaviour, IBaseActViewBinder, IHotfixable
	{
		// Token: 0x0602BC94 RID: 179348 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BC94")]
		[Address(RVA = "0x27BC7E0", Offset = "0x27BB3E0", VA = "0x1827BC7E0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602BC95 RID: 179349 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BC95")]
		[Address(RVA = "0x27BB9A0", Offset = "0x27BA5A0", VA = "0x1827BB9A0", Slot = "4")]
		public void OnViewModelRefresh(TemplateActivityViewModel viewModel)
		{
		}

		// Token: 0x0602BC96 RID: 179350 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BC96")]
		[Address(RVA = "0x27BCC10", Offset = "0x27BB810", VA = "0x1827BCC10")]
		public Act13sideNormalMissionOneView()
		{
		}

		// Token: 0x0403F581 RID: 259457
		[Token(Token = "0x403F581")]
		private const float ANIM_FRAME_COUNT = 10f;

		// Token: 0x0403F582 RID: 259458
		[Token(Token = "0x403F582")]
		private const string FADE_IN_PARAM = "fade_in";

		// Token: 0x0403F583 RID: 259459
		[Token(Token = "0x403F583")]
		private const string FADE_OUT_PARAM = "fade_out";

		// Token: 0x0403F584 RID: 259460
		[Token(Token = "0x403F584")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TemplateActivityMissionItem _item;

		// Token: 0x0403F585 RID: 259461
		[Token(Token = "0x403F585")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform _container1;

		// Token: 0x0403F586 RID: 259462
		[Token(Token = "0x403F586")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform _container2;

		// Token: 0x0403F587 RID: 259463
		[Token(Token = "0x403F587")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private SimpleLayoutContent _content;

		// Token: 0x0403F588 RID: 259464
		[Token(Token = "0x403F588")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Act13sidePrestigeProgressView _progressView;

		// Token: 0x0403F589 RID: 259465
		[Token(Token = "0x403F589")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Transform _progressViewContainer;

		// Token: 0x0403F58A RID: 259466
		[Token(Token = "0x403F58A")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private UICommonTrackPoint _longTermTrackPoint;

		// Token: 0x0403F58B RID: 259467
		[Token(Token = "0x403F58B")]
		[FieldOffset(Offset = "0x50")]
		private TrackPointViewProperty m_longTermTrackPointProperty;

		// Token: 0x0403F58C RID: 259468
		[Token(Token = "0x403F58C")]
		[FieldOffset(Offset = "0x58")]
		private Act13sidePrestigeProgressView m_progressView;

		// Token: 0x0403F58D RID: 259469
		[Token(Token = "0x403F58D")]
		[FieldOffset(Offset = "0x60")]
		private Act13sideNormalMissionOneView.OrgAdapter m_adapter;

		// Token: 0x0403F58E RID: 259470
		[Token(Token = "0x403F58E")]
		[FieldOffset(Offset = "0x68")]
		[NonSerialized]
		public Action<string> missionGroupClick;

		// Token: 0x0403F58F RID: 259471
		[Token(Token = "0x403F58F")]
		[FieldOffset(Offset = "0x70")]
		[NonSerialized]
		public Action<string> receiveAllMissionGroupClick;

		// Token: 0x0403F590 RID: 259472
		[Token(Token = "0x403F590")]
		[FieldOffset(Offset = "0x78")]
		[NonSerialized]
		public UIStringEvent receiveClick;

		// Token: 0x0403F591 RID: 259473
		[Token(Token = "0x403F591")]
		[FieldOffset(Offset = "0x80")]
		private TemplateActivityMissionItem m_item1;

		// Token: 0x0403F592 RID: 259474
		[Token(Token = "0x403F592")]
		[FieldOffset(Offset = "0x88")]
		private TemplateActivityMissionItem m_item2;

		// Token: 0x0403F593 RID: 259475
		[Token(Token = "0x403F593")]
		[FieldOffset(Offset = "0x90")]
		private bool m_initFlag;

		// Token: 0x0403F594 RID: 259476
		[Token(Token = "0x403F594")]
		[FieldOffset(Offset = "0x98")]
		private string m_groupId1;

		// Token: 0x0403F595 RID: 259477
		[Token(Token = "0x403F595")]
		[FieldOffset(Offset = "0xA0")]
		private string m_groupId2;

		// Token: 0x0403F596 RID: 259478
		[Token(Token = "0x403F596")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403F597 RID: 259479
		[Token(Token = "0x403F597")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnViewModelRefresh;

		// Token: 0x0403F598 RID: 259480
		[Token(Token = "0x403F598")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02007A03 RID: 31235
		[Token(Token = "0x2007A03")]
		private enum MissionCardState
		{
			// Token: 0x0403F59A RID: 259482
			[Token(Token = "0x403F59A")]
			MISSION,
			// Token: 0x0403F59B RID: 259483
			[Token(Token = "0x403F59B")]
			ALLCLEAR,
			// Token: 0x0403F59C RID: 259484
			[Token(Token = "0x403F59C")]
			NOMISSIONGROUP
		}

		// Token: 0x02007A04 RID: 31236
		[Token(Token = "0x2007A04")]
		private class OrgAdapter : SimpleLayoutAdapter
		{
			// Token: 0x17006699 RID: 26265
			// (get) Token: 0x0602BC97 RID: 179351 RVA: 0x000DD310 File Offset: 0x000DB510
			[Token(Token = "0x17006699")]
			public override int count
			{
				[Token(Token = "0x602BC97")]
				[Address(RVA = "0x27C0480", Offset = "0x27BF080", VA = "0x1827C0480", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0602BC98 RID: 179352 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602BC98")]
			[Address(RVA = "0x27C01C0", Offset = "0x27BEDC0", VA = "0x1827C01C0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0602BC99 RID: 179353 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602BC99")]
			[Address(RVA = "0x27C0420", Offset = "0x27BF020", VA = "0x1827C0420")]
			public OrgAdapter()
			{
			}

			// Token: 0x0403F59D RID: 259485
			[Token(Token = "0x403F59D")]
			[FieldOffset(Offset = "0x20")]
			public UIStringEvent onOrgClick;

			// Token: 0x0403F59E RID: 259486
			[Token(Token = "0x403F59E")]
			[FieldOffset(Offset = "0x28")]
			public List<Act13sideNormalMissionOneView.OrgAdapter.OrgInput> orgList;

			// Token: 0x0403F59F RID: 259487
			[Token(Token = "0x403F59F")]
			[FieldOffset(Offset = "0x30")]
			public string selectOrg;

			// Token: 0x0403F5A0 RID: 259488
			[Token(Token = "0x403F5A0")]
			[FieldOffset(Offset = "0x38")]
			public string actId;

			// Token: 0x0403F5A1 RID: 259489
			[Token(Token = "0x403F5A1")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0403F5A2 RID: 259490
			[Token(Token = "0x403F5A2")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x0403F5A3 RID: 259491
			[Token(Token = "0x403F5A3")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x02007A05 RID: 31237
			[Token(Token = "0x2007A05")]
			public class OrgInput
			{
				// Token: 0x0602BC9A RID: 179354 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x602BC9A")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public OrgInput()
				{
				}

				// Token: 0x0403F5A4 RID: 259492
				[Token(Token = "0x403F5A4")]
				[FieldOffset(Offset = "0x10")]
				public Act13SideData.OrgData orgData;

				// Token: 0x0403F5A5 RID: 259493
				[Token(Token = "0x403F5A5")]
				[FieldOffset(Offset = "0x18")]
				public bool isFlag;
			}
		}
	}
}
