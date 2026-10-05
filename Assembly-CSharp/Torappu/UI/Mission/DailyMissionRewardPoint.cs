using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.UI.Mission
{
	// Token: 0x02004883 RID: 18563
	[Token(Token = "0x2004883")]
	public class DailyMissionRewardPoint : MonoBehaviour
	{
		// Token: 0x0601C06F RID: 114799 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C06F")]
		[Address(RVA = "0x1562EF0", Offset = "0x1561AF0", VA = "0x181562EF0")]
		public void InitState(bool existFlag, bool getFlag = false, string hashCodeFlag = "", int id = 0)
		{
		}

		// Token: 0x0601C070 RID: 114800 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C070")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public DailyMissionRewardPoint()
		{
		}

		// Token: 0x04024911 RID: 149777
		[Token(Token = "0x4024911")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _getObj;

		// Token: 0x04024912 RID: 149778
		[Token(Token = "0x4024912")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _emptyObj;

		// Token: 0x04024913 RID: 149779
		[Token(Token = "0x4024913")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _lockedObj;
	}
}
