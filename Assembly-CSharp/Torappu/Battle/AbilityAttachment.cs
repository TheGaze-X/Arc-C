using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.Battle
{
	// Token: 0x020020EA RID: 8426
	[Token(Token = "0x20020EA")]
	[Serializable]
	public class AbilityAttachment : IAbilityAttachment
	{
		// Token: 0x0600CE51 RID: 52817 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CE51")]
		[Address(RVA = "0x4EAC30", Offset = "0x4E9830", VA = "0x1804EAC30")]
		public void Init(TargetValidator targetValidator)
		{
		}

		// Token: 0x0600CE52 RID: 52818 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CE52")]
		[Address(RVA = "0x34ED630", Offset = "0x34EC230", VA = "0x1834ED630", Slot = "4")]
		public void Apply(Entity target, Entity owner, Ability ability, Blackboard blackboard)
		{
		}

		// Token: 0x0600CE53 RID: 52819 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CE53")]
		[Address(RVA = "0x34ED820", Offset = "0x34EC420", VA = "0x1834ED820")]
		public static void Apply(IList<IAbilityAttachment> attachments, Entity target, Entity owner, Ability ability, Blackboard blackboard)
		{
		}

		// Token: 0x0600CE54 RID: 52820 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CE54")]
		[Address(RVA = "0xA3D790", Offset = "0xA3C390", VA = "0x180A3D790")]
		public AbilityAttachment()
		{
		}

		// Token: 0x0400DBDB RID: 56283
		[Token(Token = "0x400DBDB")]
		[FieldOffset(Offset = "0x10")]
		public Entity source;

		// Token: 0x0400DBDC RID: 56284
		[Token(Token = "0x400DBDC")]
		[FieldOffset(Offset = "0x18")]
		public BuffData[] activeBuffData;

		// Token: 0x0400DBDD RID: 56285
		[Token(Token = "0x400DBDD")]
		[FieldOffset(Offset = "0x20")]
		public Blackboard extraBlackboard;

		// Token: 0x0400DBDE RID: 56286
		[Token(Token = "0x400DBDE")]
		[FieldOffset(Offset = "0x28")]
		public float prob;

		// Token: 0x0400DBDF RID: 56287
		[Token(Token = "0x400DBDF")]
		[FieldOffset(Offset = "0x30")]
		private TargetValidator m_targetValidator;
	}
}
