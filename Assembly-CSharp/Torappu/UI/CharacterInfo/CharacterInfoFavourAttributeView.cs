using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.UI.CharacterInfo
{
	// Token: 0x02005F32 RID: 24370
	[Token(Token = "0x2005F32")]
	public class CharacterInfoFavourAttributeView : MonoBehaviour
	{
		// Token: 0x060234B6 RID: 144566 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60234B6")]
		[Address(RVA = "0x1DD74E0", Offset = "0x1DD60E0", VA = "0x181DD74E0")]
		public void Apply(string attrName, int attrValue)
		{
		}

		// Token: 0x060234B7 RID: 144567 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60234B7")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public CharacterInfoFavourAttributeView()
		{
		}

		// Token: 0x04030AC8 RID: 199368
		[Token(Token = "0x4030AC8")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _attrName;

		// Token: 0x04030AC9 RID: 199369
		[Token(Token = "0x4030AC9")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _attrValue;
	}
}
