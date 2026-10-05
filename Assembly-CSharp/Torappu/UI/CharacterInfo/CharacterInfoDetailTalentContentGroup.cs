using System;
using Il2CppDummyDll;
using Torappu.UI.CharacterCommon;
using UnityEngine;
using XLua;

namespace Torappu.UI.CharacterInfo
{
	// Token: 0x02005FC2 RID: 24514
	[Token(Token = "0x2005FC2")]
	public class CharacterInfoDetailTalentContentGroup : MonoBehaviour, IHotfixable
	{
		// Token: 0x06023745 RID: 145221 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023745")]
		[Address(RVA = "0x1E1EBA0", Offset = "0x1E1D7A0", VA = "0x181E1EBA0")]
		public void Render(CharacterTalentViewModel[] talents)
		{
		}

		// Token: 0x06023746 RID: 145222 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023746")]
		[Address(RVA = "0x1E1ED80", Offset = "0x1E1D980", VA = "0x181E1ED80")]
		public CharacterInfoDetailTalentContentGroup()
		{
		}

		// Token: 0x04031091 RID: 200849
		[Token(Token = "0x4031091")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform _talentContainer;

		// Token: 0x04031092 RID: 200850
		[Token(Token = "0x4031092")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _contentItemPrefab;

		// Token: 0x04031093 RID: 200851
		[Token(Token = "0x4031093")]
		[FieldOffset(Offset = "0x28")]
		private CharacterTalentViewModel[] m_talentsCache;

		// Token: 0x04031094 RID: 200852
		[Token(Token = "0x4031094")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04031095 RID: 200853
		[Token(Token = "0x4031095")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
