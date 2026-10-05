using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.UI.Home
{
	// Token: 0x02004C0F RID: 19471
	[Token(Token = "0x2004C0F")]
	public class HomeMainInventoryCountDownView : MonoBehaviour
	{
		// Token: 0x0601D415 RID: 119829 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D415")]
		[Address(RVA = "0x16D4FE0", Offset = "0x16D3BE0", VA = "0x1816D4FE0")]
		public void _InitIfNot()
		{
		}

		// Token: 0x0601D416 RID: 119830 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D416")]
		[Address(RVA = "0x16D4D10", Offset = "0x16D3910", VA = "0x1816D4D10")]
		public void RefreshState()
		{
		}

		// Token: 0x0601D417 RID: 119831 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D417")]
		[Address(RVA = "0x16D50A0", Offset = "0x16D3CA0", VA = "0x1816D50A0")]
		private void _OnTimeExceed()
		{
		}

		// Token: 0x0601D418 RID: 119832 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D418")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public HomeMainInventoryCountDownView()
		{
		}

		// Token: 0x04026746 RID: 157510
		[Token(Token = "0x4026746")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform _onTimeContainer;

		// Token: 0x04026747 RID: 157511
		[Token(Token = "0x4026747")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIItemTimeCountDown _countDown;

		// Token: 0x04026748 RID: 157512
		[Token(Token = "0x4026748")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _itemScaler;

		// Token: 0x04026749 RID: 157513
		[Token(Token = "0x4026749")]
		[FieldOffset(Offset = "0x30")]
		private UIItemTimeCountDown m_countDown;

		// Token: 0x0402674A RID: 157514
		[Token(Token = "0x402674A")]
		[FieldOffset(Offset = "0x38")]
		private bool m_initFlag;

		// Token: 0x0402674B RID: 157515
		[Token(Token = "0x402674B")]
		private const int TWO_WEEK_THRES = 1209600;
	}
}
