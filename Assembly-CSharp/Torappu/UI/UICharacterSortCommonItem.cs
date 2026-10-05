using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x0200354C RID: 13644
	[Token(Token = "0x200354C")]
	[RequireComponent(typeof(ThreeStateToggle))]
	public abstract class UICharacterSortCommonItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x06015BE3 RID: 89059
		[Token(Token = "0x6015BE3")]
		public abstract void RenderSortItem(CharacterSortTypePair sortPair, bool lightMode);

		// Token: 0x06015BE4 RID: 89060
		[Token(Token = "0x6015BE4")]
		public abstract void NotifySortTypeChanged(CharacterSortType sortType);

		// Token: 0x06015BE5 RID: 89061 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015BE5")]
		[Address(RVA = "0xE51820", Offset = "0xE50420", VA = "0x180E51820")]
		protected UICharacterSortCommonItem()
		{
		}

		// Token: 0x0401A224 RID: 107044
		[Token(Token = "0x401A224")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
