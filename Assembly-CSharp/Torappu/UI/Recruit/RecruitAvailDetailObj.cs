using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Recruit
{
	// Token: 0x0200473C RID: 18236
	[Token(Token = "0x200473C")]
	public class RecruitAvailDetailObj : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601BA25 RID: 113189 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BA25")]
		[Address(RVA = "0x14F4FF0", Offset = "0x14F3BF0", VA = "0x1814F4FF0")]
		public void Render(GachaDetailData.GachaAvailChar.GachaPerAvail perObj, bool isEnd, string recruit6StarHint)
		{
		}

		// Token: 0x0601BA26 RID: 113190 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BA26")]
		[Address(RVA = "0x14F5390", Offset = "0x14F3F90", VA = "0x1814F5390")]
		public RecruitAvailDetailObj()
		{
		}

		// Token: 0x04023D70 RID: 146800
		[Token(Token = "0x4023D70")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _rarityImg;

		// Token: 0x04023D71 RID: 146801
		[Token(Token = "0x4023D71")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _upTxt;

		// Token: 0x04023D72 RID: 146802
		[Token(Token = "0x4023D72")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _availChar;

		// Token: 0x04023D73 RID: 146803
		[Token(Token = "0x4023D73")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _endLine;

		// Token: 0x04023D74 RID: 146804
		[Token(Token = "0x4023D74")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _holder6StarHint;

		// Token: 0x04023D75 RID: 146805
		[Token(Token = "0x4023D75")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _text6StarHintLabel;

		// Token: 0x04023D76 RID: 146806
		[Token(Token = "0x4023D76")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04023D77 RID: 146807
		[Token(Token = "0x4023D77")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
