using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.Mission;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act1
{
	// Token: 0x02007B5A RID: 31578
	[Token(Token = "0x2007B5A")]
	public class ActivityFirstMissionItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602C337 RID: 181047 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C337")]
		[Address(RVA = "0x281DF60", Offset = "0x281CB60", VA = "0x18281DF60")]
		public void Render(MissionViewModel missionData)
		{
		}

		// Token: 0x0602C338 RID: 181048 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C338")]
		[Address(RVA = "0x281DEE0", Offset = "0x281CAE0", VA = "0x18281DEE0")]
		public void OnClick()
		{
		}

		// Token: 0x0602C339 RID: 181049 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C339")]
		[Address(RVA = "0x281E440", Offset = "0x281D040", VA = "0x18281E440")]
		private void _OnItemCardClicked(int position)
		{
		}

		// Token: 0x0602C33A RID: 181050 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C33A")]
		[Address(RVA = "0x281E550", Offset = "0x281D150", VA = "0x18281E550")]
		public ActivityFirstMissionItem()
		{
		}

		// Token: 0x04040135 RID: 262453
		[Token(Token = "0x4040135")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _missionDetail;

		// Token: 0x04040136 RID: 262454
		[Token(Token = "0x4040136")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _coinCount;

		// Token: 0x04040137 RID: 262455
		[Token(Token = "0x4040137")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform _itemContainer;

		// Token: 0x04040138 RID: 262456
		[Token(Token = "0x4040138")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _canAchievePart;

		// Token: 0x04040139 RID: 262457
		[Token(Token = "0x4040139")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _onUsingPart;

		// Token: 0x0404013A RID: 262458
		[Token(Token = "0x404013A")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _stateText;

		// Token: 0x0404013B RID: 262459
		[Token(Token = "0x404013B")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private float _itemCardScaleFactor;

		// Token: 0x0404013C RID: 262460
		[Token(Token = "0x404013C")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private RectTransform _lineBar;

		// Token: 0x0404013D RID: 262461
		[Token(Token = "0x404013D")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private float _lineLength;

		// Token: 0x0404013E RID: 262462
		[Token(Token = "0x404013E")]
		[FieldOffset(Offset = "0x60")]
		[NonSerialized]
		public UIStringEvent sendEvent;

		// Token: 0x0404013F RID: 262463
		[Token(Token = "0x404013F")]
		[FieldOffset(Offset = "0x68")]
		private UIItemCard m_itemCard;

		// Token: 0x04040140 RID: 262464
		[Token(Token = "0x4040140")]
		[FieldOffset(Offset = "0x70")]
		private List<UIItemCard> m_itemCardList;

		// Token: 0x04040141 RID: 262465
		[Token(Token = "0x4040141")]
		[FieldOffset(Offset = "0x78")]
		private string m_missionId;

		// Token: 0x04040142 RID: 262466
		[Token(Token = "0x4040142")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04040143 RID: 262467
		[Token(Token = "0x4040143")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x04040144 RID: 262468
		[Token(Token = "0x4040144")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__OnItemCardClicked;

		// Token: 0x04040145 RID: 262469
		[Token(Token = "0x4040145")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
