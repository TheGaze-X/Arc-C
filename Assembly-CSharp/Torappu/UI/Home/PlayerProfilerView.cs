using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.UI.Home
{
	// Token: 0x02004C46 RID: 19526
	[Token(Token = "0x2004C46")]
	public class PlayerProfilerView : MonoBehaviour
	{
		// Token: 0x0601D4FB RID: 120059 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D4FB")]
		[Address(RVA = "0x16F3730", Offset = "0x16F2330", VA = "0x1816F3730")]
		private void Start()
		{
		}

		// Token: 0x0601D4FC RID: 120060 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D4FC")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public PlayerProfilerView()
		{
		}

		// Token: 0x0402690F RID: 157967
		[Token(Token = "0x402690F")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _uidLabel;

		// Token: 0x04026910 RID: 157968
		[Token(Token = "0x4026910")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _playerLevel;

		// Token: 0x04026911 RID: 157969
		[Token(Token = "0x4026911")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _expCircle;
	}
}
