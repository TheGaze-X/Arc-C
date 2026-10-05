using System;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Building.UI
{
	// Token: 0x02001B21 RID: 6945
	[Token(Token = "0x2001B21")]
	public class BuildingUIFloatStationItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x0600AED9 RID: 44761 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AED9")]
		[Address(RVA = "0x3294480", Offset = "0x3293080", VA = "0x183294480")]
		private void _Init()
		{
		}

		// Token: 0x170014B7 RID: 5303
		// (get) Token: 0x0600AEDA RID: 44762 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600AEDB RID: 44763 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170014B7")]
		public string stationText
		{
			[Token(Token = "0x600AEDA")]
			[Address(RVA = "0x3295540", Offset = "0x3294140", VA = "0x183295540")]
			get
			{
				return null;
			}
			[Token(Token = "0x600AEDB")]
			[Address(RVA = "0x32955D0", Offset = "0x32941D0", VA = "0x1832955D0")]
			set
			{
			}
		}

		// Token: 0x0600AEDC RID: 44764 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AEDC")]
		[Address(RVA = "0x3294060", Offset = "0x3292C60", VA = "0x183294060")]
		public void Render(BuildingCharModel charModel, int index)
		{
		}

		// Token: 0x0600AEDD RID: 44765 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AEDD")]
		[Address(RVA = "0x3294670", Offset = "0x3293270", VA = "0x183294670")]
		private void _OnAvatarClicked()
		{
		}

		// Token: 0x0600AEDE RID: 44766 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AEDE")]
		[Address(RVA = "0x3294370", Offset = "0x3292F70", VA = "0x183294370")]
		private void Start()
		{
		}

		// Token: 0x0600AEDF RID: 44767 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AEDF")]
		[Address(RVA = "0x3294400", Offset = "0x3293000", VA = "0x183294400")]
		private void Update()
		{
		}

		// Token: 0x0600AEE0 RID: 44768 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AEE0")]
		[Address(RVA = "0x32952A0", Offset = "0x3293EA0", VA = "0x1832952A0")]
		private void _UpdateWorkTime(CountDownTask.TickValue tick)
		{
		}

		// Token: 0x0600AEE1 RID: 44769 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AEE1")]
		[Address(RVA = "0x3293F50", Offset = "0x3292B50", VA = "0x183293F50")]
		public void EventOnRemoveBtnClicked()
		{
		}

		// Token: 0x0600AEE2 RID: 44770 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AEE2")]
		[Address(RVA = "0x3293ED0", Offset = "0x3292AD0", VA = "0x183293ED0")]
		public void EventOnPanelClicked()
		{
		}

		// Token: 0x0600AEE3 RID: 44771 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AEE3")]
		[Address(RVA = "0x3294760", Offset = "0x3293360", VA = "0x183294760")]
		private void _OnCharItemClicked()
		{
		}

		// Token: 0x0600AEE4 RID: 44772 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AEE4")]
		[Address(RVA = "0x3294850", Offset = "0x3293450", VA = "0x183294850")]
		private void _RenderActive()
		{
		}

		// Token: 0x0600AEE5 RID: 44773 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AEE5")]
		[Address(RVA = "0x3294B70", Offset = "0x3293770", VA = "0x183294B70")]
		private void _UpdateAp()
		{
		}

		// Token: 0x0600AEE6 RID: 44774 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AEE6")]
		[Address(RVA = "0x3294EB0", Offset = "0x3293AB0", VA = "0x183294EB0")]
		private void _UpdateWorkFinish()
		{
		}

		// Token: 0x0600AEE7 RID: 44775 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AEE7")]
		[Address(RVA = "0x3295430", Offset = "0x3294030", VA = "0x183295430")]
		public BuildingUIFloatStationItem()
		{
		}

		// Token: 0x0400A805 RID: 43013
		[Token(Token = "0x400A805")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _panelActive;

		// Token: 0x0400A806 RID: 43014
		[Token(Token = "0x400A806")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _panelEmpty;

		// Token: 0x0400A807 RID: 43015
		[Token(Token = "0x400A807")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private BuildingCharAvatar _avatarPrefab;

		// Token: 0x0400A808 RID: 43016
		[Token(Token = "0x400A808")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private RectTransform _avatarContainer;

		// Token: 0x0400A809 RID: 43017
		[Token(Token = "0x400A809")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _textName;

		// Token: 0x0400A80A RID: 43018
		[Token(Token = "0x400A80A")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _textAp;

		// Token: 0x0400A80B RID: 43019
		[Token(Token = "0x400A80B")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _textMaxAp;

		// Token: 0x0400A80C RID: 43020
		[Token(Token = "0x400A80C")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private FillProgressBar _apProgress;

		// Token: 0x0400A80D RID: 43021
		[Token(Token = "0x400A80D")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _textStatus;

		// Token: 0x0400A80E RID: 43022
		[Token(Token = "0x400A80E")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Text _textTime;

		// Token: 0x0400A80F RID: 43023
		[Token(Token = "0x400A80F")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private RectTransform _lineAp;

		// Token: 0x0400A810 RID: 43024
		[Token(Token = "0x400A810")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Text _textStation;

		// Token: 0x0400A811 RID: 43025
		[Token(Token = "0x400A811")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		[Group("Dorm Lock")]
		private GameObject _dormLockFrame;

		// Token: 0x0400A812 RID: 43026
		[Token(Token = "0x400A812")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		[Group("Dorm Lock")]
		private GameObject _dormLockIcon;

		// Token: 0x0400A813 RID: 43027
		[Token(Token = "0x400A813")]
		[FieldOffset(Offset = "0x88")]
		private int m_index;

		// Token: 0x0400A814 RID: 43028
		[Token(Token = "0x400A814")]
		[FieldOffset(Offset = "0x90")]
		private BuildingCharModel m_charModel;

		// Token: 0x0400A815 RID: 43029
		[Token(Token = "0x400A815")]
		[FieldOffset(Offset = "0x108")]
		private BuildingCharAvatar m_avatarView;

		// Token: 0x0400A816 RID: 43030
		[Token(Token = "0x400A816")]
		[FieldOffset(Offset = "0x110")]
		private CountDownTask m_apCountDown;

		// Token: 0x0400A817 RID: 43031
		[Token(Token = "0x400A817")]
		[FieldOffset(Offset = "0x118")]
		private CountDownTask m_workFinishCountDown;

		// Token: 0x0400A818 RID: 43032
		[Token(Token = "0x400A818")]
		[FieldOffset(Offset = "0x120")]
		private bool m_isInited;

		// Token: 0x0400A819 RID: 43033
		[Token(Token = "0x400A819")]
		[FieldOffset(Offset = "0x128")]
		[NonSerialized]
		public Action<BuildingCharModel, int> onItemClicked;

		// Token: 0x0400A81A RID: 43034
		[Token(Token = "0x400A81A")]
		[FieldOffset(Offset = "0x130")]
		[NonSerialized]
		public Action<BuildingCharModel, int> onRemoveClicked;

		// Token: 0x0400A81B RID: 43035
		[Token(Token = "0x400A81B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__Init;

		// Token: 0x0400A81C RID: 43036
		[Token(Token = "0x400A81C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_stationText;

		// Token: 0x0400A81D RID: 43037
		[Token(Token = "0x400A81D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_set_stationText;

		// Token: 0x0400A81E RID: 43038
		[Token(Token = "0x400A81E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0400A81F RID: 43039
		[Token(Token = "0x400A81F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnAvatarClicked;

		// Token: 0x0400A820 RID: 43040
		[Token(Token = "0x400A820")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_Start;

		// Token: 0x0400A821 RID: 43041
		[Token(Token = "0x400A821")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x0400A822 RID: 43042
		[Token(Token = "0x400A822")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__UpdateWorkTime;

		// Token: 0x0400A823 RID: 43043
		[Token(Token = "0x400A823")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_EventOnRemoveBtnClicked;

		// Token: 0x0400A824 RID: 43044
		[Token(Token = "0x400A824")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_EventOnPanelClicked;

		// Token: 0x0400A825 RID: 43045
		[Token(Token = "0x400A825")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__OnCharItemClicked;

		// Token: 0x0400A826 RID: 43046
		[Token(Token = "0x400A826")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__RenderActive;

		// Token: 0x0400A827 RID: 43047
		[Token(Token = "0x400A827")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__UpdateAp;

		// Token: 0x0400A828 RID: 43048
		[Token(Token = "0x400A828")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__UpdateWorkFinish;

		// Token: 0x0400A829 RID: 43049
		[Token(Token = "0x400A829")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
