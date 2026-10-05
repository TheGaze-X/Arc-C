using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.UI
{
	// Token: 0x02003763 RID: 14179
	[Token(Token = "0x2003763")]
	public class UISkillTagView : MonoBehaviour
	{
		// Token: 0x170035EF RID: 13807
		// (get) Token: 0x0601682C RID: 92204 RVA: 0x000916B0 File Offset: 0x0008F8B0
		[Token(Token = "0x170035EF")]
		public SkillTagType tagType
		{
			[Token(Token = "0x601682C")]
			[Address(RVA = "0x4EA860", Offset = "0x4E9460", VA = "0x1804EA860")]
			get
			{
				return SkillTagType.TEXT;
			}
		}

		// Token: 0x0601682D RID: 92205 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601682D")]
		[Address(RVA = "0xF02BA0", Offset = "0xF017A0", VA = "0x180F02BA0")]
		public void RenderTag(SkillTagViewModel tagModel)
		{
		}

		// Token: 0x0601682E RID: 92206 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601682E")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public UISkillTagView()
		{
		}

		// Token: 0x0401B1F5 RID: 111093
		[Token(Token = "0x401B1F5")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SkillTagType _tagType;

		// Token: 0x0401B1F6 RID: 111094
		[Token(Token = "0x401B1F6")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _colorTarget;

		// Token: 0x0401B1F7 RID: 111095
		[Token(Token = "0x401B1F7")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _contentTarget;
	}
}
