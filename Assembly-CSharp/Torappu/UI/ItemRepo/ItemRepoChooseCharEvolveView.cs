using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ItemRepo
{
	// Token: 0x02005E9A RID: 24218
	[Token(Token = "0x2005E9A")]
	public class ItemRepoChooseCharEvolveView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06023158 RID: 143704 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023158")]
		[Address(RVA = "0x1D91AC0", Offset = "0x1D906C0", VA = "0x181D91AC0")]
		public void OnClick()
		{
		}

		// Token: 0x06023159 RID: 143705 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023159")]
		[Address(RVA = "0x1D91B40", Offset = "0x1D90740", VA = "0x181D91B40")]
		public void Render(CharacterCardViewModel charViewModel, bool clickable, CharCardType cardType)
		{
		}

		// Token: 0x0602315A RID: 143706 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602315A")]
		[Address(RVA = "0x1D91FB0", Offset = "0x1D90BB0", VA = "0x181D91FB0")]
		public ItemRepoChooseCharEvolveView()
		{
		}

		// Token: 0x04030537 RID: 197943
		[Token(Token = "0x4030537")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _charProtrait;

		// Token: 0x04030538 RID: 197944
		[Token(Token = "0x4030538")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _professionImg;

		// Token: 0x04030539 RID: 197945
		[Token(Token = "0x4030539")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _eliteImg;

		// Token: 0x0403053A RID: 197946
		[Token(Token = "0x403053A")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _levelTxt;

		// Token: 0x0403053B RID: 197947
		[Token(Token = "0x403053B")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _skillCoverImg;

		// Token: 0x0403053C RID: 197948
		[Token(Token = "0x403053C")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private ItemRepoChooseCharSkillView[] _skillItems;

		// Token: 0x0403053D RID: 197949
		[Token(Token = "0x403053D")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _hotspot;

		// Token: 0x0403053E RID: 197950
		[Token(Token = "0x403053E")]
		[FieldOffset(Offset = "0x50")]
		[NonSerialized]
		public CharClickEvent onClickEvent;

		// Token: 0x0403053F RID: 197951
		[Token(Token = "0x403053F")]
		[FieldOffset(Offset = "0x58")]
		private CharacterCardViewModel m_cacheCharViewModel;

		// Token: 0x04030540 RID: 197952
		[Token(Token = "0x4030540")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x04030541 RID: 197953
		[Token(Token = "0x4030541")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04030542 RID: 197954
		[Token(Token = "0x4030542")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
