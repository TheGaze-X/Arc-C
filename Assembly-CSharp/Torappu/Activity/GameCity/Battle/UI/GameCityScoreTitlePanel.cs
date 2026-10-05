using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.GameCity.Battle.UI
{
	// Token: 0x0200790B RID: 30987
	[Token(Token = "0x200790B")]
	public class GameCityScoreTitlePanel : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602B77E RID: 178046 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B77E")]
		[Address(RVA = "0x275BE30", Offset = "0x275AA30", VA = "0x18275BE30")]
		public void InitPanel()
		{
		}

		// Token: 0x0602B77F RID: 178047 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B77F")]
		[Address(RVA = "0x275BF40", Offset = "0x275AB40", VA = "0x18275BF40")]
		public GameCityScoreTitlePanel()
		{
		}

		// Token: 0x0403ED8F RID: 257423
		[Token(Token = "0x403ED8F")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _scoreTitleText;

		// Token: 0x0403ED90 RID: 257424
		[Token(Token = "0x403ED90")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _scoreMaxTitleText;

		// Token: 0x0403ED91 RID: 257425
		[Token(Token = "0x403ED91")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_InitPanel;

		// Token: 0x0403ED92 RID: 257426
		[Token(Token = "0x403ED92")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
