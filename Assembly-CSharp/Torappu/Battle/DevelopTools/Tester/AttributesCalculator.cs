using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Battle.DevelopTools.Tester
{
	// Token: 0x020028A0 RID: 10400
	[Token(Token = "0x20028A0")]
	[RequireComponent(typeof(BattleLauncher))]
	public class AttributesCalculator : MonoBehaviour
	{
		// Token: 0x060114E1 RID: 70881 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60114E1")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public AttributesCalculator()
		{
		}

		// Token: 0x04013543 RID: 79171
		[Token(Token = "0x4013543")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CharacterDB _characterDB;

		// Token: 0x04013544 RID: 79172
		[Token(Token = "0x4013544")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private BattleUniEquipDB _uniequipDB;

		// Token: 0x04013545 RID: 79173
		[Token(Token = "0x4013545")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private AdvancedCharacterInst _characterInst;

		// Token: 0x04013546 RID: 79174
		[Token(Token = "0x4013546")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[ReadOnly]
		private AttributesData _characterAttributes;
	}
}
