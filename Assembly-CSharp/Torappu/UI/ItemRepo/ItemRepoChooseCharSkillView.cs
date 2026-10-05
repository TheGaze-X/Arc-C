using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ItemRepo
{
	// Token: 0x02005E9B RID: 24219
	[Token(Token = "0x2005E9B")]
	public class ItemRepoChooseCharSkillView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602315B RID: 143707 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602315B")]
		[Address(RVA = "0x1D92010", Offset = "0x1D90C10", VA = "0x181D92010")]
		public void Render(PlayerCharSkill skillInfo)
		{
		}

		// Token: 0x0602315C RID: 143708 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602315C")]
		[Address(RVA = "0x1D92130", Offset = "0x1D90D30", VA = "0x181D92130")]
		public ItemRepoChooseCharSkillView()
		{
		}

		// Token: 0x04030543 RID: 197955
		[Token(Token = "0x4030543")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _imgSkill;

		// Token: 0x04030544 RID: 197956
		[Token(Token = "0x4030544")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _imgSpecializeLv;

		// Token: 0x04030545 RID: 197957
		[Token(Token = "0x4030545")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _skillIconFrame;

		// Token: 0x04030546 RID: 197958
		[Token(Token = "0x4030546")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _skillIconCover;

		// Token: 0x04030547 RID: 197959
		[Token(Token = "0x4030547")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _specializeCover;

		// Token: 0x04030548 RID: 197960
		[Token(Token = "0x4030548")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Sprite[] _specializeImages;

		// Token: 0x04030549 RID: 197961
		[Token(Token = "0x4030549")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403054A RID: 197962
		[Token(Token = "0x403054A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
