using System;
using Il2CppDummyDll;
using Torappu.UI.CharacterCommon;
using UnityEngine;
using XLua;

namespace Torappu.UI.CharSelect
{
	// Token: 0x02005E26 RID: 24102
	[Token(Token = "0x2005E26")]
	public class CharSelectTalentGroup : MonoBehaviour, IHotfixable
	{
		// Token: 0x06022EBD RID: 143037 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022EBD")]
		[Address(RVA = "0x1D77210", Offset = "0x1D75E10", VA = "0x181D77210")]
		public void RenderTalent(CharacterTalentViewModel[] talents)
		{
		}

		// Token: 0x06022EBE RID: 143038 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022EBE")]
		[Address(RVA = "0x1D773F0", Offset = "0x1D75FF0", VA = "0x181D773F0")]
		public CharSelectTalentGroup()
		{
		}

		// Token: 0x040301C7 RID: 197063
		[Token(Token = "0x40301C7")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform _talentContainer;

		// Token: 0x040301C8 RID: 197064
		[Token(Token = "0x40301C8")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _contentItemPrefab;

		// Token: 0x040301C9 RID: 197065
		[Token(Token = "0x40301C9")]
		[FieldOffset(Offset = "0x28")]
		private CharacterTalentViewModel[] m_talentsCache;

		// Token: 0x040301CA RID: 197066
		[Token(Token = "0x40301CA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_RenderTalent;

		// Token: 0x040301CB RID: 197067
		[Token(Token = "0x40301CB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
