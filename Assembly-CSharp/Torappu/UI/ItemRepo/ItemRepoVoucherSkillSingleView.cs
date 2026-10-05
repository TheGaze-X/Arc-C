using System;
using Il2CppDummyDll;
using Torappu.UI.CharacterInfo;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ItemRepo
{
	// Token: 0x02005EB9 RID: 24249
	[Token(Token = "0x2005EB9")]
	public class ItemRepoVoucherSkillSingleView : MonoBehaviour, IHotfixable
	{
		// Token: 0x060231D4 RID: 143828 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60231D4")]
		[Address(RVA = "0x1DB8390", Offset = "0x1DB6F90", VA = "0x181DB8390")]
		public void Render(SkillItemViewModel viewModel, ILoadAsset assetLoader)
		{
		}

		// Token: 0x060231D5 RID: 143829 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60231D5")]
		[Address(RVA = "0x1DB8530", Offset = "0x1DB7130", VA = "0x181DB8530")]
		public ItemRepoVoucherSkillSingleView()
		{
		}

		// Token: 0x04030686 RID: 198278
		[Token(Token = "0x4030686")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _specialIcon;

		// Token: 0x04030687 RID: 198279
		[Token(Token = "0x4030687")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject[] _specLevel;

		// Token: 0x04030688 RID: 198280
		[Token(Token = "0x4030688")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _training;

		// Token: 0x04030689 RID: 198281
		[Token(Token = "0x4030689")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _btnSelect;

		// Token: 0x0403068A RID: 198282
		[Token(Token = "0x403068A")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		protected CharacterInfoSkillView _skillView;

		// Token: 0x0403068B RID: 198283
		[Token(Token = "0x403068B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403068C RID: 198284
		[Token(Token = "0x403068C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
