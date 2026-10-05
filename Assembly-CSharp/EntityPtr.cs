using System;
using Il2CppDummyDll;
using Torappu;
using Torappu.Battle;

// Token: 0x02000024 RID: 36
[Token(Token = "0x2000024")]
[Serializable]
public struct EntityPtr
{
	// Token: 0x06000097 RID: 151 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000097")]
	[Address(RVA = "0x4F7EA0", Offset = "0x4F6AA0", VA = "0x1804F7EA0")]
	public EntityPtr(ObjectPtr<Entity> entity)
	{
	}

	// Token: 0x06000098 RID: 152 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000098")]
	[Address(RVA = "0x508840", Offset = "0x507440", VA = "0x180508840")]
	public Entity GetEntity()
	{
		return null;
	}

	// Token: 0x0400008F RID: 143
	[Token(Token = "0x400008F")]
	[FieldOffset(Offset = "0x0")]
	private ObjectPtr<Entity> m_entityPtr;
}
