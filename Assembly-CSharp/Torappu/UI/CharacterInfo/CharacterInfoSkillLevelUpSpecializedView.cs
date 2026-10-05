using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.UI.CharacterInfo
{
	// Token: 0x02005FB9 RID: 24505
	[Token(Token = "0x2005FB9")]
	public class CharacterInfoSkillLevelUpSpecializedView : MonoBehaviour
	{
		// Token: 0x06023716 RID: 145174 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023716")]
		[Address(RVA = "0x1E1FFF0", Offset = "0x1E1EBF0", VA = "0x181E1FFF0")]
		public void Render(SkillItemViewModel viewModel, CharQuery charQuery, int levelDelta)
		{
		}

		// Token: 0x06023717 RID: 145175 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023717")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public CharacterInfoSkillLevelUpSpecializedView()
		{
		}

		// Token: 0x04031015 RID: 200725
		[Token(Token = "0x4031015")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CharacterInfoSkillView _skillView;

		// Token: 0x04031016 RID: 200726
		[Token(Token = "0x4031016")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _specialIcon;

		// Token: 0x04031017 RID: 200727
		[Token(Token = "0x4031017")]
		[FieldOffset(Offset = "0x28")]
		private UIPageFinder m_pageFinder;
	}
}
