using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.Cooperate
{
	// Token: 0x020026E9 RID: 9961
	[Token(Token = "0x20026E9")]
	[Serializable]
	public class CooperateProfessionBuffBlackBoard : IHotfixable
	{
		// Token: 0x06010317 RID: 66327 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010317")]
		[Address(RVA = "0x7E60F0", Offset = "0x7E4CF0", VA = "0x1807E60F0")]
		public CooperateProfessionBuffBlackBoard()
		{
		}

		// Token: 0x04012193 RID: 74131
		[Token(Token = "0x4012193")]
		[FieldOffset(Offset = "0x10")]
		public string key;

		// Token: 0x04012194 RID: 74132
		[Token(Token = "0x4012194")]
		[FieldOffset(Offset = "0x18")]
		public string buffId;

		// Token: 0x04012195 RID: 74133
		[Token(Token = "0x4012195")]
		[FieldOffset(Offset = "0x20")]
		public bool atRoot;

		// Token: 0x04012196 RID: 74134
		[Token(Token = "0x4012196")]
		[FieldOffset(Offset = "0x28")]
		public string title;

		// Token: 0x04012197 RID: 74135
		[Token(Token = "0x4012197")]
		[FieldOffset(Offset = "0x30")]
		public string description;

		// Token: 0x04012198 RID: 74136
		[Token(Token = "0x4012198")]
		[FieldOffset(Offset = "0x38")]
		public Blackboard Blackboard;

		// Token: 0x04012199 RID: 74137
		[Token(Token = "0x4012199")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
