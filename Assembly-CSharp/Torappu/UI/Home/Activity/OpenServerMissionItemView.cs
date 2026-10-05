using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.UI.Home.Activity
{
	// Token: 0x02004C7A RID: 19578
	[Token(Token = "0x2004C7A")]
	public class OpenServerMissionItemView : MonoBehaviour
	{
		// Token: 0x0601D5C6 RID: 120262 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D5C6")]
		[Address(RVA = "0x16EBF90", Offset = "0x16EAB90", VA = "0x1816EBF90")]
		public void Initialize(string missionID, MissionData missionData, MissionPlayerState missionState)
		{
		}

		// Token: 0x0601D5C7 RID: 120263 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D5C7")]
		[Address(RVA = "0x16EC490", Offset = "0x16EB090", VA = "0x1816EC490")]
		public void OnAnimatorStart()
		{
		}

		// Token: 0x0601D5C8 RID: 120264 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D5C8")]
		[Address(RVA = "0x16EC4E0", Offset = "0x16EB0E0", VA = "0x1816EC4E0")]
		public void OnClick()
		{
		}

		// Token: 0x0601D5C9 RID: 120265 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D5C9")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public OpenServerMissionItemView()
		{
		}

		// Token: 0x04026A25 RID: 158245
		[Token(Token = "0x4026A25")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _missionDetail;

		// Token: 0x04026A26 RID: 158246
		[Token(Token = "0x4026A26")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _itemName;

		// Token: 0x04026A27 RID: 158247
		[Token(Token = "0x4026A27")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _itemIcon;

		// Token: 0x04026A28 RID: 158248
		[Token(Token = "0x4026A28")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _itemCount;

		// Token: 0x04026A29 RID: 158249
		[Token(Token = "0x4026A29")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _missionState;

		// Token: 0x04026A2A RID: 158250
		[Token(Token = "0x4026A2A")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private RectTransform _length;

		// Token: 0x04026A2B RID: 158251
		[Token(Token = "0x4026A2B")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _finishPart;

		// Token: 0x04026A2C RID: 158252
		[Token(Token = "0x4026A2C")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _unfinishPart;

		// Token: 0x04026A2D RID: 158253
		[Token(Token = "0x4026A2D")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private CanvasGroup _rightCanvasGroup;

		// Token: 0x04026A2E RID: 158254
		[Token(Token = "0x4026A2E")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _alreadyGetPart;

		// Token: 0x04026A2F RID: 158255
		[Token(Token = "0x4026A2F")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Animator _onFinish;

		// Token: 0x04026A30 RID: 158256
		[Token(Token = "0x4026A30")]
		[FieldOffset(Offset = "0x70")]
		[NonSerialized]
		public Action<string> onGetMission;

		// Token: 0x04026A31 RID: 158257
		[Token(Token = "0x4026A31")]
		[FieldOffset(Offset = "0x78")]
		private string m_missionID;

		// Token: 0x04026A32 RID: 158258
		[Token(Token = "0x4026A32")]
		private const string MISSION_COMPLETE_ANIMATOR = "mission_complete";
	}
}
