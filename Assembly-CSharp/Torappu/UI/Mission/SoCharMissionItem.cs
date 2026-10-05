using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Mission
{
	// Token: 0x020048AA RID: 18602
	[Token(Token = "0x20048AA")]
	public class SoCharMissionItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601C120 RID: 114976 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C120")]
		[Address(RVA = "0x1571220", Offset = "0x156FE20", VA = "0x181571220")]
		public void OnRender(MissionViewModel missionModel)
		{
		}

		// Token: 0x0601C121 RID: 114977 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C121")]
		[Address(RVA = "0x15710B0", Offset = "0x156FCB0", VA = "0x1815710B0")]
		public void ApplyMission()
		{
		}

		// Token: 0x0601C122 RID: 114978 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C122")]
		[Address(RVA = "0x1571640", Offset = "0x1570240", VA = "0x181571640")]
		public SoCharMissionItem()
		{
		}

		// Token: 0x04024A9D RID: 150173
		[Token(Token = "0x4024A9D")]
		private const int STATE_COUNT = 3;

		// Token: 0x04024A9E RID: 150174
		[Token(Token = "0x4024A9E")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _alreadyPart;

		// Token: 0x04024A9F RID: 150175
		[Token(Token = "0x4024A9F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _ablePart;

		// Token: 0x04024AA0 RID: 150176
		[Token(Token = "0x4024AA0")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _normalPart;

		// Token: 0x04024AA1 RID: 150177
		[Token(Token = "0x4024AA1")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text[] _descriptions;

		// Token: 0x04024AA2 RID: 150178
		[Token(Token = "0x4024AA2")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image[] _stateBar;

		// Token: 0x04024AA3 RID: 150179
		[Token(Token = "0x4024AA3")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text[] _currentState;

		// Token: 0x04024AA4 RID: 150180
		[Token(Token = "0x4024AA4")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text[] _expList;

		// Token: 0x04024AA5 RID: 150181
		[Token(Token = "0x4024AA5")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Vector2 _barWidth;

		// Token: 0x04024AA6 RID: 150182
		[Token(Token = "0x4024AA6")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Transform _startPos;

		// Token: 0x04024AA7 RID: 150183
		[Token(Token = "0x4024AA7")]
		[FieldOffset(Offset = "0x60")]
		private MissionViewModel m_cacheModel;

		// Token: 0x04024AA8 RID: 150184
		[Token(Token = "0x4024AA8")]
		[FieldOffset(Offset = "0x68")]
		private UIStateFinder m_stateFinder;

		// Token: 0x04024AA9 RID: 150185
		[Token(Token = "0x4024AA9")]
		[FieldOffset(Offset = "0x78")]
		[NonSerialized]
		public Vector3 targetPos;

		// Token: 0x04024AAA RID: 150186
		[Token(Token = "0x4024AAA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x04024AAB RID: 150187
		[Token(Token = "0x4024AAB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_ApplyMission;

		// Token: 0x04024AAC RID: 150188
		[Token(Token = "0x4024AAC")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
