using System;
using Il2CppDummyDll;

namespace Torappu.Battle.Effects
{
	// Token: 0x02003275 RID: 12917
	[Token(Token = "0x2003275")]
	[Serializable]
	public struct EquipmentEffectHookSchema
	{
		// Token: 0x04018367 RID: 99175
		[Token(Token = "0x4018367")]
		[FieldOffset(Offset = "0x0")]
		public CharacterData.UniqueEquipPair equipmentPair;

		// Token: 0x04018368 RID: 99176
		[Token(Token = "0x4018368")]
		[FieldOffset(Offset = "0x10")]
		public string hookEffectKey;
	}
}
