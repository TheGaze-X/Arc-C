using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.AutoChess
{
	// Token: 0x0200622E RID: 25134
	[Token(Token = "0x200622E")]
	public class AutoChessCountDownView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602442F RID: 148527 RVA: 0x000C39D8 File Offset: 0x000C1BD8
		[Token(Token = "0x602442F")]
		[Address(RVA = "0x1F04E30", Offset = "0x1F03A30", VA = "0x181F04E30")]
		public bool SetCountDownNum(TimeSpan remains, int totalSecs, int emergencyHintSec)
		{
			return default(bool);
		}

		// Token: 0x06024430 RID: 148528 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6024430")]
		[Address(RVA = "0x1F05340", Offset = "0x1F03F40", VA = "0x181F05340")]
		private string _GetNumStr(int number)
		{
			return null;
		}

		// Token: 0x06024431 RID: 148529 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024431")]
		[Address(RVA = "0x1F05420", Offset = "0x1F04020", VA = "0x181F05420")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06024432 RID: 148530 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024432")]
		[Address(RVA = "0x1F054A0", Offset = "0x1F040A0", VA = "0x181F054A0")]
		public AutoChessCountDownView()
		{
		}

		// Token: 0x040326B0 RID: 206512
		[Token(Token = "0x40326B0")]
		private const int ADD_ZERO_CNT = 10;

		// Token: 0x040326B1 RID: 206513
		[Token(Token = "0x40326B1")]
		private const int COUNT_DOWN_MAX_NUM = 999;

		// Token: 0x040326B2 RID: 206514
		[Token(Token = "0x40326B2")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _textCountDown;

		// Token: 0x040326B3 RID: 206515
		[Token(Token = "0x40326B3")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Font _textCountDownFont;

		// Token: 0x040326B4 RID: 206516
		[Token(Token = "0x40326B4")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _objLightGreen;

		// Token: 0x040326B5 RID: 206517
		[Token(Token = "0x40326B5")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _objLightOrange;

		// Token: 0x040326B6 RID: 206518
		[Token(Token = "0x40326B6")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Slider _progressBar;

		// Token: 0x040326B7 RID: 206519
		[Token(Token = "0x40326B7")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Image _imgProgress;

		// Token: 0x040326B8 RID: 206520
		[Token(Token = "0x40326B8")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Color _colGreen;

		// Token: 0x040326B9 RID: 206521
		[Token(Token = "0x40326B9")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Color _colOrange;

		// Token: 0x040326BA RID: 206522
		[Token(Token = "0x40326BA")]
		[FieldOffset(Offset = "0x68")]
		private bool m_hasInited;

		// Token: 0x040326BB RID: 206523
		[Token(Token = "0x40326BB")]
		[FieldOffset(Offset = "0x6C")]
		private int m_cachedRemainSecs;

		// Token: 0x040326BC RID: 206524
		[Token(Token = "0x40326BC")]
		[FieldOffset(Offset = "0x70")]
		private bool m_cachedIsInEmergency;

		// Token: 0x040326BD RID: 206525
		[Token(Token = "0x40326BD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_SetCountDownNum;

		// Token: 0x040326BE RID: 206526
		[Token(Token = "0x40326BE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__GetNumStr;

		// Token: 0x040326BF RID: 206527
		[Token(Token = "0x40326BF")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040326C0 RID: 206528
		[Token(Token = "0x40326C0")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
