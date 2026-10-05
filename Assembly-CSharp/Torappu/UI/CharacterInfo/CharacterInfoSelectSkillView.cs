using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.UI.CharacterInfo
{
	// Token: 0x02005FB2 RID: 24498
	[Token(Token = "0x2005FB2")]
	public class CharacterInfoSelectSkillView : MonoBehaviour
	{
		// Token: 0x06023702 RID: 145154 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023702")]
		[Address(RVA = "0x1E1F930", Offset = "0x1E1E530", VA = "0x181E1F930", Slot = "4")]
		public virtual void Render(SkillItemViewModel viewModel, int index, bool isSelected)
		{
		}

		// Token: 0x06023703 RID: 145155 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023703")]
		[Address(RVA = "0x1E1F910", Offset = "0x1E1E510", VA = "0x181E1F910")]
		public void EventOnToggleButtonClick()
		{
		}

		// Token: 0x06023704 RID: 145156 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023704")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public CharacterInfoSelectSkillView()
		{
		}

		// Token: 0x04030FD0 RID: 200656
		[Token(Token = "0x4030FD0")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		protected CharacterInfoSkillView _skillView;

		// Token: 0x04030FD1 RID: 200657
		[Token(Token = "0x4030FD1")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _onSelected;

		// Token: 0x04030FD2 RID: 200658
		[Token(Token = "0x4030FD2")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _onNotSelected;

		// Token: 0x04030FD3 RID: 200659
		[Token(Token = "0x4030FD3")]
		[FieldOffset(Offset = "0x30")]
		protected int m_indexCache;

		// Token: 0x04030FD4 RID: 200660
		[Token(Token = "0x4030FD4")]
		[FieldOffset(Offset = "0x38")]
		[NonSerialized]
		public Action<int> onToggleClick;
	}
}
