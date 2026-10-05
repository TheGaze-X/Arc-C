using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.Battle.UI
{
	// Token: 0x02003305 RID: 13061
	[Token(Token = "0x2003305")]
	public class UIBattleSystemMenuReward : MonoBehaviour
	{
		// Token: 0x1700311B RID: 12571
		// (get) Token: 0x06014BDF RID: 84959 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06014BE0 RID: 84960 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700311B")]
		public string text
		{
			[Token(Token = "0x6014BDF")]
			[Address(RVA = "0xD23170", Offset = "0xD21D70", VA = "0x180D23170")]
			get
			{
				return null;
			}
			[Token(Token = "0x6014BE0")]
			[Address(RVA = "0xD231C0", Offset = "0xD21DC0", VA = "0x180D231C0")]
			set
			{
			}
		}

		// Token: 0x06014BE1 RID: 84961 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014BE1")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public UIBattleSystemMenuReward()
		{
		}

		// Token: 0x04018A8A RID: 101002
		[Token(Token = "0x4018A8A")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _text;
	}
}
