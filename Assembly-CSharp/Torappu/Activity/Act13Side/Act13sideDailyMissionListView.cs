using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.DataBind;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act13Side
{
	// Token: 0x02007A27 RID: 31271
	[Token(Token = "0x2007A27")]
	public class Act13sideDailyMissionListView : DataBinder<Act13sideDailyMissionProperty>
	{
		// Token: 0x170066C2 RID: 26306
		// (get) Token: 0x0602BD25 RID: 179493 RVA: 0x000DD568 File Offset: 0x000DB768
		[Token(Token = "0x170066C2")]
		private int boardMax
		{
			[Token(Token = "0x602BD25")]
			[Address(RVA = "0x27AE5C0", Offset = "0x27AD1C0", VA = "0x1827AE5C0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0602BD26 RID: 179494 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BD26")]
		[Address(RVA = "0x27AD890", Offset = "0x27AC490", VA = "0x1827AD890")]
		public void Init(string actId, Action<int> onMissionCancel, Action<int> onMissionCommit, Action onNavToPool, Action<string> onNavToStage)
		{
		}

		// Token: 0x0602BD27 RID: 179495 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BD27")]
		[Address(RVA = "0x27AD9A0", Offset = "0x27AC5A0", VA = "0x1827AD9A0", Slot = "7")]
		public override void OnValueChanged(Act13sideDailyMissionProperty property)
		{
		}

		// Token: 0x0602BD28 RID: 179496 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BD28")]
		[Address(RVA = "0x27AE2D0", Offset = "0x27ACED0", VA = "0x1827AE2D0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602BD29 RID: 179497 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BD29")]
		[Address(RVA = "0x27AE140", Offset = "0x27ACD40", VA = "0x1827AE140")]
		public void RegisterTutorialGo()
		{
		}

		// Token: 0x0602BD2A RID: 179498 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BD2A")]
		[Address(RVA = "0x27ADEE0", Offset = "0x27ACAE0", VA = "0x1827ADEE0")]
		public void PlayCompleteAnim(int boardIdx, Action onComplete)
		{
		}

		// Token: 0x0602BD2B RID: 179499 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BD2B")]
		[Address(RVA = "0x27AE550", Offset = "0x27AD150", VA = "0x1827AE550")]
		public Act13sideDailyMissionListView()
		{
		}

		// Token: 0x0403F685 RID: 259717
		[Token(Token = "0x403F685")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform[] _missionItemParentList;

		// Token: 0x0403F686 RID: 259718
		[Token(Token = "0x403F686")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Act13sideDailyMissionItemView _missionItemTemplate;

		// Token: 0x0403F687 RID: 259719
		[Token(Token = "0x403F687")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textAgenda;

		// Token: 0x0403F688 RID: 259720
		[Token(Token = "0x403F688")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _textAgendaMax;

		// Token: 0x0403F689 RID: 259721
		[Token(Token = "0x403F689")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Color _hintColor;

		// Token: 0x0403F68A RID: 259722
		[Token(Token = "0x403F68A")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private UICommonTrackPoint _dailyMissionTrackPoint;

		// Token: 0x0403F68B RID: 259723
		[Token(Token = "0x403F68B")]
		[FieldOffset(Offset = "0x58")]
		private string m_actId;

		// Token: 0x0403F68C RID: 259724
		[Token(Token = "0x403F68C")]
		[FieldOffset(Offset = "0x60")]
		private bool m_hasInited;

		// Token: 0x0403F68D RID: 259725
		[Token(Token = "0x403F68D")]
		[FieldOffset(Offset = "0x68")]
		private Act13SideData m_actData;

		// Token: 0x0403F68E RID: 259726
		[Token(Token = "0x403F68E")]
		[FieldOffset(Offset = "0x70")]
		private Action<int> m_onMissionCancel;

		// Token: 0x0403F68F RID: 259727
		[Token(Token = "0x403F68F")]
		[FieldOffset(Offset = "0x78")]
		private Action<int> m_onMissionCommit;

		// Token: 0x0403F690 RID: 259728
		[Token(Token = "0x403F690")]
		[FieldOffset(Offset = "0x80")]
		private Action m_onNavToPool;

		// Token: 0x0403F691 RID: 259729
		[Token(Token = "0x403F691")]
		[FieldOffset(Offset = "0x88")]
		private Action<string> m_onNavToStage;

		// Token: 0x0403F692 RID: 259730
		[Token(Token = "0x403F692")]
		[FieldOffset(Offset = "0x90")]
		private Act13sideDailyMissionViewModel m_viewModel;

		// Token: 0x0403F693 RID: 259731
		[Token(Token = "0x403F693")]
		[FieldOffset(Offset = "0x98")]
		private List<Act13sideDailyMissionItemView> m_missionItemList;

		// Token: 0x0403F694 RID: 259732
		[Token(Token = "0x403F694")]
		[FieldOffset(Offset = "0xA0")]
		private TrackPointViewProperty m_trackPointProp;

		// Token: 0x0403F695 RID: 259733
		[Token(Token = "0x403F695")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_boardMax;

		// Token: 0x0403F696 RID: 259734
		[Token(Token = "0x403F696")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0403F697 RID: 259735
		[Token(Token = "0x403F697")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0403F698 RID: 259736
		[Token(Token = "0x403F698")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403F699 RID: 259737
		[Token(Token = "0x403F699")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_RegisterTutorialGo;

		// Token: 0x0403F69A RID: 259738
		[Token(Token = "0x403F69A")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_PlayCompleteAnim;

		// Token: 0x0403F69B RID: 259739
		[Token(Token = "0x403F69B")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
