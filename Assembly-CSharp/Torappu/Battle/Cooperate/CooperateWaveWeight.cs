using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.Cooperate
{
	// Token: 0x020026E7 RID: 9959
	[Token(Token = "0x20026E7")]
	[Serializable]
	public class CooperateWaveWeight : IHotfixable, IItemWithWeight
	{
		// Token: 0x1700234E RID: 9038
		// (get) Token: 0x06010314 RID: 66324 RVA: 0x00062BF8 File Offset: 0x00060DF8
		[Token(Token = "0x1700234E")]
		public float weightValue
		{
			[Token(Token = "0x6010314")]
			[Address(RVA = "0x7E62D0", Offset = "0x7E4ED0", VA = "0x1807E62D0", Slot = "4")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x06010315 RID: 66325 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010315")]
		[Address(RVA = "0x7E6270", Offset = "0x7E4E70", VA = "0x1807E6270")]
		public CooperateWaveWeight()
		{
		}

		// Token: 0x0401218C RID: 74124
		[Token(Token = "0x401218C")]
		[FieldOffset(Offset = "0x10")]
		public int wave;

		// Token: 0x0401218D RID: 74125
		[Token(Token = "0x401218D")]
		[FieldOffset(Offset = "0x14")]
		public int weight;

		// Token: 0x0401218E RID: 74126
		[Token(Token = "0x401218E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_weightValue;

		// Token: 0x0401218F RID: 74127
		[Token(Token = "0x401218F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
