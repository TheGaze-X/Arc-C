using System;
using Il2CppDummyDll;

namespace Torappu.ObjectPool
{
	// Token: 0x02001487 RID: 5255
	[Token(Token = "0x2001487")]
	public class BattleEffectPolicyAssigner : ReleasePolicyAssigner
	{
		// Token: 0x06007991 RID: 31121 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007991")]
		[Address(RVA = "0x2636570", Offset = "0x2635170", VA = "0x182636570", Slot = "4")]
		public override void Assign(ref GameObjectPool.Options option)
		{
		}

		// Token: 0x06007992 RID: 31122 RVA: 0x000369D8 File Offset: 0x00034BD8
		[Token(Token = "0x6007992")]
		[Address(RVA = "0x2636620", Offset = "0x2635220", VA = "0x182636620", Slot = "5")]
		public override bool TryMatch(string poolName)
		{
			return default(bool);
		}

		// Token: 0x06007993 RID: 31123 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007993")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public BattleEffectPolicyAssigner()
		{
		}

		// Token: 0x040077C3 RID: 30659
		[Token(Token = "0x40077C3")]
		private const string BATTLE_EFFECT_PATTERN = "^battle/prefabs/effects";

		// Token: 0x040077C4 RID: 30660
		[Token(Token = "0x40077C4")]
		[FieldOffset(Offset = "0x10")]
		private BattleEffectReleasePolicy m_policy;
	}
}
