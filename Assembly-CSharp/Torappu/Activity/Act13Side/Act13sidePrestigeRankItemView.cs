using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act13Side
{
	// Token: 0x02007A45 RID: 31301
	[Token(Token = "0x2007A45")]
	public class Act13sidePrestigeRankItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602BDA9 RID: 179625 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BDA9")]
		[Address(RVA = "0x27D0020", Offset = "0x27CEC20", VA = "0x1827D0020")]
		public void Render(int position, string actId, Act13SideData.OrgData orgData, Act13SideData.PrestigeData prestigeData, Act13SideData.PrestigeRank currentRank)
		{
		}

		// Token: 0x0602BDAA RID: 179626 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BDAA")]
		[Address(RVA = "0x27D0540", Offset = "0x27CF140", VA = "0x1827D0540")]
		public Act13sidePrestigeRankItemView()
		{
		}

		// Token: 0x0403F7F6 RID: 260086
		[Token(Token = "0x403F7F6")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Color[] _gradientColorList;

		// Token: 0x0403F7F7 RID: 260087
		[Token(Token = "0x403F7F7")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _imgGradientBg;

		// Token: 0x0403F7F8 RID: 260088
		[Token(Token = "0x403F7F8")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _imgOrg;

		// Token: 0x0403F7F9 RID: 260089
		[Token(Token = "0x403F7F9")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _imgEmoji;

		// Token: 0x0403F7FA RID: 260090
		[Token(Token = "0x403F7FA")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _textPrestigeRank;

		// Token: 0x0403F7FB RID: 260091
		[Token(Token = "0x403F7FB")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _docItemGo;

		// Token: 0x0403F7FC RID: 260092
		[Token(Token = "0x403F7FC")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _textDocCount;

		// Token: 0x0403F7FD RID: 260093
		[Token(Token = "0x403F7FD")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _newsItemGo;

		// Token: 0x0403F7FE RID: 260094
		[Token(Token = "0x403F7FE")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _textNewsCount;

		// Token: 0x0403F7FF RID: 260095
		[Token(Token = "0x403F7FF")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _avgItemGo;

		// Token: 0x0403F800 RID: 260096
		[Token(Token = "0x403F800")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Text _textAvgCount;

		// Token: 0x0403F801 RID: 260097
		[Token(Token = "0x403F801")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _keyItemGo;

		// Token: 0x0403F802 RID: 260098
		[Token(Token = "0x403F802")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Text _textKeyName;

		// Token: 0x0403F803 RID: 260099
		[Token(Token = "0x403F803")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private GameObject _completedGo;

		// Token: 0x0403F804 RID: 260100
		[Token(Token = "0x403F804")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private GameObject _incomeGo;

		// Token: 0x0403F805 RID: 260101
		[Token(Token = "0x403F805")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Text _textUnlockHint;

		// Token: 0x0403F806 RID: 260102
		[Token(Token = "0x403F806")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private GameObject _currentRankSignGo;

		// Token: 0x0403F807 RID: 260103
		[Token(Token = "0x403F807")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403F808 RID: 260104
		[Token(Token = "0x403F808")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
