using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Recruit
{
	// Token: 0x02004742 RID: 18242
	[Token(Token = "0x2004742")]
	public class RecruitFesClassicCharPortObj : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601BA30 RID: 113200 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BA30")]
		[Address(RVA = "0x14FE7E0", Offset = "0x14FD3E0", VA = "0x1814FE7E0")]
		public void Render(JArrayWrapper upCharIdList, RarityRank rarityRank, string titleText, bool isEnd, bool isPortrait, [Optional] List<string> limitList)
		{
		}

		// Token: 0x0601BA31 RID: 113201 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BA31")]
		[Address(RVA = "0x14FEBC0", Offset = "0x14FD7C0", VA = "0x1814FEBC0")]
		public RecruitFesClassicCharPortObj()
		{
		}

		// Token: 0x04023D91 RID: 146833
		[Token(Token = "0x4023D91")]
		private const float CHAR_PORT_CELL_HEIGHT = 210.6f;

		// Token: 0x04023D92 RID: 146834
		[Token(Token = "0x4023D92")]
		private const float CHAR_CELL_HEIGHT = 100f;

		// Token: 0x04023D93 RID: 146835
		[Token(Token = "0x4023D93")]
		private const int CHAR_PORT_ROW_CELL_COUNT = 6;

		// Token: 0x04023D94 RID: 146836
		[Token(Token = "0x4023D94")]
		private const int CHAR_ROW_CELL_COUNT = 8;

		// Token: 0x04023D95 RID: 146837
		[Token(Token = "0x4023D95")]
		private const float CHAR_PORT_SCALE_SIZE = 1f;

		// Token: 0x04023D96 RID: 146838
		[Token(Token = "0x4023D96")]
		private const float CHAR_SCALE_SIZE = 1.2f;

		// Token: 0x04023D97 RID: 146839
		[Token(Token = "0x4023D97")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RectTransform _container;

		// Token: 0x04023D98 RID: 146840
		[Token(Token = "0x4023D98")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RecruitCharDetailObj _charObj;

		// Token: 0x04023D99 RID: 146841
		[Token(Token = "0x4023D99")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RecruitUpCharDetailPortraitObj _portraitObj;

		// Token: 0x04023D9A RID: 146842
		[Token(Token = "0x4023D9A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _title;

		// Token: 0x04023D9B RID: 146843
		[Token(Token = "0x4023D9B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image _starIcon;

		// Token: 0x04023D9C RID: 146844
		[Token(Token = "0x4023D9C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _endLine;

		// Token: 0x04023D9D RID: 146845
		[Token(Token = "0x4023D9D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GridLayoutGroup _containerLayoutGroup;

		// Token: 0x04023D9E RID: 146846
		[Token(Token = "0x4023D9E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04023D9F RID: 146847
		[Token(Token = "0x4023D9F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
