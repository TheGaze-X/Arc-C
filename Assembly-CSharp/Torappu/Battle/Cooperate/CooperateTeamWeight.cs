using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.Cooperate
{
	// Token: 0x020026E6 RID: 9958
	[Token(Token = "0x20026E6")]
	[Serializable]
	public class CooperateTeamWeight : IHotfixable, IItemWithWeight
	{
		// Token: 0x1700234D RID: 9037
		// (get) Token: 0x06010312 RID: 66322 RVA: 0x00062BE0 File Offset: 0x00060DE0
		[Token(Token = "0x1700234D")]
		public float weightValue
		{
			[Token(Token = "0x6010312")]
			[Address(RVA = "0x7E6210", Offset = "0x7E4E10", VA = "0x1807E6210", Slot = "4")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x06010313 RID: 66323 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010313")]
		[Address(RVA = "0x7E61B0", Offset = "0x7E4DB0", VA = "0x1807E61B0")]
		public CooperateTeamWeight()
		{
		}

		// Token: 0x04012188 RID: 74120
		[Token(Token = "0x4012188")]
		[FieldOffset(Offset = "0x10")]
		public string teamName;

		// Token: 0x04012189 RID: 74121
		[Token(Token = "0x4012189")]
		[FieldOffset(Offset = "0x18")]
		public int weight;

		// Token: 0x0401218A RID: 74122
		[Token(Token = "0x401218A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_weightValue;

		// Token: 0x0401218B RID: 74123
		[Token(Token = "0x401218B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
