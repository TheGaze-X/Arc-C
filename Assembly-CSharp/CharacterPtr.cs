using System;
using Il2CppDummyDll;
using Torappu;
using Torappu.Battle;

// Token: 0x02000026 RID: 38
[Token(Token = "0x2000026")]
[Serializable]
public struct CharacterPtr
{
	// Token: 0x0600009B RID: 155 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600009B")]
	[Address(RVA = "0x4F7EA0", Offset = "0x4F6AA0", VA = "0x1804F7EA0")]
	public CharacterPtr(ObjectPtr<Character> character)
	{
	}

	// Token: 0x0600009C RID: 156 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600009C")]
	[Address(RVA = "0x4F7DE0", Offset = "0x4F69E0", VA = "0x1804F7DE0")]
	public Character GetCharacter()
	{
		return null;
	}

	// Token: 0x04000091 RID: 145
	[Token(Token = "0x4000091")]
	[FieldOffset(Offset = "0x0")]
	private ObjectPtr<Character> m_characterPtr;
}
