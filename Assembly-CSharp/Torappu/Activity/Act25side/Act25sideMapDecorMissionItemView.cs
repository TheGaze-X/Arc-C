using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act25side
{
	// Token: 0x020074D9 RID: 29913
	[Token(Token = "0x20074D9")]
	public class Act25sideMapDecorMissionItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602A2BA RID: 172730 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A2BA")]
		[Address(RVA = "0x25C99A0", Offset = "0x25C85A0", VA = "0x1825C99A0")]
		public void Render(Act25sideMapDecorMissionViewModel missionViewModel)
		{
		}

		// Token: 0x0602A2BB RID: 172731 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A2BB")]
		[Address(RVA = "0x25C9C10", Offset = "0x25C8810", VA = "0x1825C9C10")]
		public Act25sideMapDecorMissionItemView()
		{
		}

		// Token: 0x0403C944 RID: 248132
		[Token(Token = "0x403C944")]
		private const string MISSION_PROGRESS_FORMAT = "/{0}";

		// Token: 0x0403C945 RID: 248133
		[Token(Token = "0x403C945")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _areaName;

		// Token: 0x0403C946 RID: 248134
		[Token(Token = "0x403C946")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _missionContent;

		// Token: 0x0403C947 RID: 248135
		[Token(Token = "0x403C947")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _missionTotalProgress;

		// Token: 0x0403C948 RID: 248136
		[Token(Token = "0x403C948")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _missionCurrProgress;

		// Token: 0x0403C949 RID: 248137
		[Token(Token = "0x403C949")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _panelComplete;

		// Token: 0x0403C94A RID: 248138
		[Token(Token = "0x403C94A")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Color _colorNormal;

		// Token: 0x0403C94B RID: 248139
		[Token(Token = "0x403C94B")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Color _colorComplete;

		// Token: 0x0403C94C RID: 248140
		[Token(Token = "0x403C94C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403C94D RID: 248141
		[Token(Token = "0x403C94D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
