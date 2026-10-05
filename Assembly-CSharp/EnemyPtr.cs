using System;
using Il2CppDummyDll;
using Torappu;
using Torappu.Battle;

// Token: 0x02000025 RID: 37
[Token(Token = "0x2000025")]
[Serializable]
public struct EnemyPtr
{
	// Token: 0x06000099 RID: 153 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000099")]
	[Address(RVA = "0x4F7EA0", Offset = "0x4F6AA0", VA = "0x1804F7EA0")]
	public EnemyPtr(ObjectPtr<Enemy> enemy)
	{
	}

	// Token: 0x0600009A RID: 154 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600009A")]
	[Address(RVA = "0x508780", Offset = "0x507380", VA = "0x180508780")]
	public Enemy GetEnemy()
	{
		return null;
	}

	// Token: 0x04000090 RID: 144
	[Token(Token = "0x4000090")]
	[FieldOffset(Offset = "0x0")]
	private ObjectPtr<Enemy> m_enemyPtr;
}
