using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu
{
	// Token: 0x0200048E RID: 1166
	[Token(Token = "0x200048E")]
	[CreateAssetMenu(menuName = "Torappu/Tools/Character Inst Config")]
	public class CharacterInstConfig : ScriptableObject
	{
		// Token: 0x06004CC7 RID: 19655 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CC7")]
		[Address(RVA = "0x1790110", Offset = "0x178ED10", VA = "0x181790110")]
		public void Clear()
		{
		}

		// Token: 0x06004CC8 RID: 19656 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004CC8")]
		[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
		public List<AdvancedCharacterInst> GetSlots()
		{
			return null;
		}

		// Token: 0x06004CC9 RID: 19657 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CC9")]
		[Address(RVA = "0x1790170", Offset = "0x178ED70", VA = "0x181790170")]
		public void SetSlot(TextAsset squadJson)
		{
		}

		// Token: 0x06004CCA RID: 19658 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CCA")]
		[Address(RVA = "0x1790200", Offset = "0x178EE00", VA = "0x181790200")]
		public CharacterInstConfig()
		{
		}

		// Token: 0x0400109D RID: 4253
		[Token(Token = "0x400109D")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<AdvancedCharacterInst> _slots;
	}
}
