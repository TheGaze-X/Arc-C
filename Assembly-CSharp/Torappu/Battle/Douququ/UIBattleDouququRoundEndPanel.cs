using System;
using Il2CppDummyDll;
using Torappu.Battle.GameMode;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Battle.Douququ
{
	// Token: 0x02002A3E RID: 10814
	[Token(Token = "0x2002A3E")]
	public class UIBattleDouququRoundEndPanel : MonoBehaviour, IHotfixable
	{
		// Token: 0x06011F46 RID: 73542 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011F46")]
		[Address(RVA = "0x9D1A20", Offset = "0x9D0620", VA = "0x1809D1A20")]
		public void Init(DouququUIRoundEndState announceState)
		{
		}

		// Token: 0x06011F47 RID: 73543 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011F47")]
		[Address(RVA = "0x9D1B20", Offset = "0x9D0720", VA = "0x1809D1B20")]
		public void Show(GameModeFactory.DouququGameMode manager)
		{
		}

		// Token: 0x06011F48 RID: 73544 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011F48")]
		[Address(RVA = "0x9D1AA0", Offset = "0x9D06A0", VA = "0x1809D1AA0")]
		public void OnRoundEndOver()
		{
		}

		// Token: 0x06011F49 RID: 73545 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011F49")]
		[Address(RVA = "0x9D2790", Offset = "0x9D1390", VA = "0x1809D2790")]
		private void _ShowResult()
		{
		}

		// Token: 0x06011F4A RID: 73546 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011F4A")]
		[Address(RVA = "0x9D1E10", Offset = "0x9D0A10", VA = "0x1809D1E10")]
		private void _ShowDetails()
		{
		}

		// Token: 0x06011F4B RID: 73547 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011F4B")]
		[Address(RVA = "0x9D2950", Offset = "0x9D1550", VA = "0x1809D2950")]
		public UIBattleDouququRoundEndPanel()
		{
		}

		// Token: 0x04014440 RID: 83008
		[Token(Token = "0x4014440")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _objResultPart;

		// Token: 0x04014441 RID: 83009
		[Token(Token = "0x4014441")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _objDetailPart;

		// Token: 0x04014442 RID: 83010
		[Token(Token = "0x4014442")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _leftWin;

		// Token: 0x04014443 RID: 83011
		[Token(Token = "0x4014443")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _leftLost;

		// Token: 0x04014444 RID: 83012
		[Token(Token = "0x4014444")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _rightWin;

		// Token: 0x04014445 RID: 83013
		[Token(Token = "0x4014445")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _rightLost;

		// Token: 0x04014446 RID: 83014
		[Token(Token = "0x4014446")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _curBalence;

		// Token: 0x04014447 RID: 83015
		[Token(Token = "0x4014447")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _balanceMax;

		// Token: 0x04014448 RID: 83016
		[Token(Token = "0x4014448")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _addPart;

		// Token: 0x04014449 RID: 83017
		[Token(Token = "0x4014449")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _subPart;

		// Token: 0x0401444A RID: 83018
		[Token(Token = "0x401444A")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Text _addBalence;

		// Token: 0x0401444B RID: 83019
		[Token(Token = "0x401444B")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Text _subBalence;

		// Token: 0x0401444C RID: 83020
		[Token(Token = "0x401444C")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private GameObject _btnNext;

		// Token: 0x0401444D RID: 83021
		[Token(Token = "0x401444D")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private GameObject _btnFinish;

		// Token: 0x0401444E RID: 83022
		[Token(Token = "0x401444E")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private CanvasGroup _detailCanvasGroup;

		// Token: 0x0401444F RID: 83023
		[Token(Token = "0x401444F")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private AnimationWrapper _roundEndAnim;

		// Token: 0x04014450 RID: 83024
		[Token(Token = "0x4014450")]
		[FieldOffset(Offset = "0x98")]
		private DouququUIRoundEndState m_state;

		// Token: 0x04014451 RID: 83025
		[Token(Token = "0x4014451")]
		[FieldOffset(Offset = "0xA0")]
		private GameModeFactory.DouququGameMode m_manager;

		// Token: 0x04014452 RID: 83026
		[Token(Token = "0x4014452")]
		[FieldOffset(Offset = "0xA8")]
		private bool m_gameFinish;

		// Token: 0x04014453 RID: 83027
		[Token(Token = "0x4014453")]
		private const string DOUQUQU_ROUND_RESULT_ANIM = "douququ_round_end_result";

		// Token: 0x04014454 RID: 83028
		[Token(Token = "0x4014454")]
		private const string DOUQUQU_ROUND_DETAIL_ANIM = "douququ_round_end_detail";

		// Token: 0x04014455 RID: 83029
		[Token(Token = "0x4014455")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04014456 RID: 83030
		[Token(Token = "0x4014456")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Show;

		// Token: 0x04014457 RID: 83031
		[Token(Token = "0x4014457")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnRoundEndOver;

		// Token: 0x04014458 RID: 83032
		[Token(Token = "0x4014458")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__ShowResult;

		// Token: 0x04014459 RID: 83033
		[Token(Token = "0x4014459")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__ShowDetails;

		// Token: 0x0401445A RID: 83034
		[Token(Token = "0x401445A")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
