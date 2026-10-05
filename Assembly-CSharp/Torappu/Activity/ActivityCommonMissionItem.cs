using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.Mission;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.Activity
{
	// Token: 0x02006DB9 RID: 28089
	[Token(Token = "0x2006DB9")]
	public class ActivityCommonMissionItem : MonoBehaviour
	{
		// Token: 0x06027FF1 RID: 163825 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027FF1")]
		[Address(RVA = "0x233B040", Offset = "0x2339C40", VA = "0x18233B040")]
		public void Render(MissionViewModel missionData)
		{
		}

		// Token: 0x06027FF2 RID: 163826 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027FF2")]
		[Address(RVA = "0x233AFF0", Offset = "0x2339BF0", VA = "0x18233AFF0")]
		public void OnClick()
		{
		}

		// Token: 0x06027FF3 RID: 163827 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027FF3")]
		[Address(RVA = "0x233B540", Offset = "0x233A140", VA = "0x18233B540")]
		private void _OnItemCardClicked(int position)
		{
		}

		// Token: 0x06027FF4 RID: 163828 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027FF4")]
		[Address(RVA = "0x233B610", Offset = "0x233A210", VA = "0x18233B610")]
		public ActivityCommonMissionItem()
		{
		}

		// Token: 0x04038B40 RID: 232256
		[Token(Token = "0x4038B40")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _missionDetail;

		// Token: 0x04038B41 RID: 232257
		[Token(Token = "0x4038B41")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _coinCount;

		// Token: 0x04038B42 RID: 232258
		[Token(Token = "0x4038B42")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform _itemContainer;

		// Token: 0x04038B43 RID: 232259
		[Token(Token = "0x4038B43")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _canAchievePart;

		// Token: 0x04038B44 RID: 232260
		[Token(Token = "0x4038B44")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _onUsingPart;

		// Token: 0x04038B45 RID: 232261
		[Token(Token = "0x4038B45")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _stateText;

		// Token: 0x04038B46 RID: 232262
		[Token(Token = "0x4038B46")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private float _itemCardScaleFactor;

		// Token: 0x04038B47 RID: 232263
		[Token(Token = "0x4038B47")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private RectTransform _lineBar;

		// Token: 0x04038B48 RID: 232264
		[Token(Token = "0x4038B48")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private float _lineLength;

		// Token: 0x04038B49 RID: 232265
		[Token(Token = "0x4038B49")]
		[FieldOffset(Offset = "0x60")]
		[NonSerialized]
		public UIStringEvent sendEvent;

		// Token: 0x04038B4A RID: 232266
		[Token(Token = "0x4038B4A")]
		[FieldOffset(Offset = "0x68")]
		private UIItemCard m_itemCard;

		// Token: 0x04038B4B RID: 232267
		[Token(Token = "0x4038B4B")]
		[FieldOffset(Offset = "0x70")]
		private List<UIItemCard> m_itemCardList;

		// Token: 0x04038B4C RID: 232268
		[Token(Token = "0x4038B4C")]
		[FieldOffset(Offset = "0x78")]
		private string m_missionId;
	}
}
