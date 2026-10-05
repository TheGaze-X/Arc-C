using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act5D1
{
	// Token: 0x02007249 RID: 29257
	[Token(Token = "0x2007249")]
	internal class Act5D1RuneMissionItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x06029767 RID: 169831 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029767")]
		[Address(RVA = "0x24C8300", Offset = "0x24C6F00", VA = "0x1824C8300")]
		public void SynMission(MissionData mission, Act5D1RuneMissionPanel owner)
		{
		}

		// Token: 0x06029768 RID: 169832 RVA: 0x000D5BE8 File Offset: 0x000D3DE8
		[Token(Token = "0x6029768")]
		[Address(RVA = "0x24C7BB0", Offset = "0x24C67B0", VA = "0x1824C7BB0")]
		public static MissionHoldingState GetMissionStatus(string missionId, out int v, out int t)
		{
			return MissionHoldingState.NOT_OPEN;
		}

		// Token: 0x06029769 RID: 169833 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029769")]
		[Address(RVA = "0x24C7DA0", Offset = "0x24C69A0", VA = "0x1824C7DA0")]
		public void HandleGetReward()
		{
		}

		// Token: 0x0602976A RID: 169834 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602976A")]
		[Address(RVA = "0x24C9030", Offset = "0x24C7C30", VA = "0x1824C9030")]
		private IEnumerator _ReceiveItemsCoroutine(List<RewardItemModel> rewardList)
		{
			return null;
		}

		// Token: 0x0602976B RID: 169835 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602976B")]
		[Address(RVA = "0x24C80F0", Offset = "0x24C6CF0", VA = "0x1824C80F0")]
		public void ShowRuneDetail()
		{
		}

		// Token: 0x0602976C RID: 169836 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602976C")]
		[Address(RVA = "0x24C8010", Offset = "0x24C6C10", VA = "0x1824C8010")]
		private void OnEnable()
		{
		}

		// Token: 0x0602976D RID: 169837 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602976D")]
		[Address(RVA = "0x24C90E0", Offset = "0x24C7CE0", VA = "0x1824C90E0")]
		public Act5D1RuneMissionItem()
		{
		}

		// Token: 0x0403B3D3 RID: 242643
		[Token(Token = "0x403B3D3")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Sprite _uncomplete;

		// Token: 0x0403B3D4 RID: 242644
		[Token(Token = "0x403B3D4")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Sprite _completed;

		// Token: 0x0403B3D5 RID: 242645
		[Token(Token = "0x403B3D5")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Sprite _goted;

		// Token: 0x0403B3D6 RID: 242646
		[Token(Token = "0x403B3D6")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _bg;

		// Token: 0x0403B3D7 RID: 242647
		[Token(Token = "0x403B3D7")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _missionDesc;

		// Token: 0x0403B3D8 RID: 242648
		[Token(Token = "0x403B3D8")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _runeBtn;

		// Token: 0x0403B3D9 RID: 242649
		[Token(Token = "0x403B3D9")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Transform _itemIconRoot;

		// Token: 0x0403B3DA RID: 242650
		[Token(Token = "0x403B3DA")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _prgText;

		// Token: 0x0403B3DB RID: 242651
		[Token(Token = "0x403B3DB")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Slider _prg;

		// Token: 0x0403B3DC RID: 242652
		[Token(Token = "0x403B3DC")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _btn;

		// Token: 0x0403B3DD RID: 242653
		[Token(Token = "0x403B3DD")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _gotFlag;

		// Token: 0x0403B3DE RID: 242654
		[Token(Token = "0x403B3DE")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private UIChildrenColorGraphic _colorChanger;

		// Token: 0x0403B3DF RID: 242655
		[Token(Token = "0x403B3DF")]
		[FieldOffset(Offset = "0x78")]
		private MissionData m_mission;

		// Token: 0x0403B3E0 RID: 242656
		[Token(Token = "0x403B3E0")]
		[FieldOffset(Offset = "0x80")]
		private UIItemCard[] m_rewardIcon;

		// Token: 0x0403B3E1 RID: 242657
		[Token(Token = "0x403B3E1")]
		[FieldOffset(Offset = "0x88")]
		private Act5D1RuneMissionPanel m_owner;

		// Token: 0x0403B3E2 RID: 242658
		[Token(Token = "0x403B3E2")]
		[FieldOffset(Offset = "0x90")]
		private string[] m_runes;

		// Token: 0x0403B3E3 RID: 242659
		[Token(Token = "0x403B3E3")]
		[FieldOffset(Offset = "0x98")]
		private bool m_cannotFlag;

		// Token: 0x0403B3E4 RID: 242660
		[Token(Token = "0x403B3E4")]
		[FieldOffset(Offset = "0x99")]
		private bool m_hasGot;

		// Token: 0x0403B3E5 RID: 242661
		[Token(Token = "0x403B3E5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_SynMission;

		// Token: 0x0403B3E6 RID: 242662
		[Token(Token = "0x403B3E6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetMissionStatus;

		// Token: 0x0403B3E7 RID: 242663
		[Token(Token = "0x403B3E7")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_HandleGetReward;

		// Token: 0x0403B3E8 RID: 242664
		[Token(Token = "0x403B3E8")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__ReceiveItemsCoroutine;

		// Token: 0x0403B3E9 RID: 242665
		[Token(Token = "0x403B3E9")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_ShowRuneDetail;

		// Token: 0x0403B3EA RID: 242666
		[Token(Token = "0x403B3EA")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnEnable;

		// Token: 0x0403B3EB RID: 242667
		[Token(Token = "0x403B3EB")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
