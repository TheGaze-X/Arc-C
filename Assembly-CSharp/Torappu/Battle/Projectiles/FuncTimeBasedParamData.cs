using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.Battle.Projectiles
{
	// Token: 0x020029D8 RID: 10712
	[Token(Token = "0x20029D8")]
	[Serializable]
	public class FuncTimeBasedParamData
	{
		// Token: 0x1700272B RID: 10027
		// (get) Token: 0x06011C21 RID: 72737 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700272B")]
		public Blackboard blackboard
		{
			[Token(Token = "0x6011C21")]
			[Address(RVA = "0x99ABD0", Offset = "0x9997D0", VA = "0x18099ABD0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06011C22 RID: 72738 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011C22")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public FuncTimeBasedParamData()
		{
		}

		// Token: 0x04013ECA RID: 81610
		[Token(Token = "0x4013ECA")]
		[FieldOffset(Offset = "0x10")]
		public List<Blackboard.DataPair> data;

		// Token: 0x04013ECB RID: 81611
		[Token(Token = "0x4013ECB")]
		[FieldOffset(Offset = "0x18")]
		[NonSerialized]
		private Blackboard m_blackboard;
	}
}
