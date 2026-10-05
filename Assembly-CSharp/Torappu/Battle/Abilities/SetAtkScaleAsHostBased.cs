using System;
using Il2CppDummyDll;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002C27 RID: 11303
	[Token(Token = "0x2002C27")]
	[Obsolete("Use SetAtkScaleAsHostBasedFixed instead")]
	public class SetAtkScaleAsHostBased : AbilityStandard.Behaviour
	{
		// Token: 0x0601316B RID: 78187 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601316B")]
		[Address(RVA = "0xB24570", Offset = "0xB23170", VA = "0x180B24570", Slot = "6")]
		public override void SetData(Blackboard blackboard)
		{
		}

		// Token: 0x0601316C RID: 78188 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601316C")]
		[Address(RVA = "0xB24330", Offset = "0xB22F30", VA = "0x180B24330", Slot = "7")]
		public override void OnCastStart()
		{
		}

		// Token: 0x0601316D RID: 78189 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601316D")]
		[Address(RVA = "0xB245F0", Offset = "0xB231F0", VA = "0x180B245F0")]
		public SetAtkScaleAsHostBased()
		{
		}

		// Token: 0x040158E0 RID: 88288
		[Token(Token = "0x40158E0")]
		[FieldOffset(Offset = "0x20")]
		private float m_atkScale;
	}
}
