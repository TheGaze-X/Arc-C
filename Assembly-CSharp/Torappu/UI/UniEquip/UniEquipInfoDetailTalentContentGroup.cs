using System;
using Il2CppDummyDll;
using Torappu.UI.CharacterCommon;
using UnityEngine;
using XLua;

namespace Torappu.UI.UniEquip
{
	// Token: 0x02003C24 RID: 15396
	[Token(Token = "0x2003C24")]
	public class UniEquipInfoDetailTalentContentGroup : MonoBehaviour, IHotfixable
	{
		// Token: 0x06018157 RID: 98647 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018157")]
		[Address(RVA = "0x1087820", Offset = "0x1086420", VA = "0x181087820")]
		public void Render(CharacterTalentViewModel[] talents)
		{
		}

		// Token: 0x06018158 RID: 98648 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018158")]
		[Address(RVA = "0x1087A00", Offset = "0x1086600", VA = "0x181087A00")]
		public UniEquipInfoDetailTalentContentGroup()
		{
		}

		// Token: 0x0401D376 RID: 119670
		[Token(Token = "0x401D376")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform _talentContainer;

		// Token: 0x0401D377 RID: 119671
		[Token(Token = "0x401D377")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _contentItemPrefab;

		// Token: 0x0401D378 RID: 119672
		[Token(Token = "0x401D378")]
		[FieldOffset(Offset = "0x28")]
		private CharacterTalentViewModel[] m_talentsCache;

		// Token: 0x0401D379 RID: 119673
		[Token(Token = "0x401D379")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401D37A RID: 119674
		[Token(Token = "0x401D37A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
