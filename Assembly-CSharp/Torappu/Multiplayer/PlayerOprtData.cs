using System;
using Il2CppDummyDll;
using Torappu.Battle;
using Torappu.DataStream;
using Torappu.ObjectPool;

namespace Torappu.Multiplayer
{
	// Token: 0x02001537 RID: 5431
	[Token(Token = "0x2001537")]
	public class PlayerOprtData : IReusable
	{
		// Token: 0x06007C9B RID: 31899 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C9B")]
		[Address(RVA = "0x284A870", Offset = "0x2849470", VA = "0x18284A870")]
		public PlayerOprtData()
		{
		}

		// Token: 0x06007C9C RID: 31900 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C9C")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "4")]
		public void OnAllocate()
		{
		}

		// Token: 0x06007C9D RID: 31901 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C9D")]
		[Address(RVA = "0x284A510", Offset = "0x2849110", VA = "0x18284A510", Slot = "5")]
		public void OnRecycle()
		{
		}

		// Token: 0x06007C9E RID: 31902 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C9E")]
		[Address(RVA = "0x284A570", Offset = "0x2849170", VA = "0x18284A570")]
		public void ReadFrom(IStreamReader data)
		{
		}

		// Token: 0x06007C9F RID: 31903 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C9F")]
		[Address(RVA = "0x284A6F0", Offset = "0x28492F0", VA = "0x18284A6F0")]
		public void WriteTo(IStreamWriter data)
		{
		}

		// Token: 0x04007CA1 RID: 31905
		[Token(Token = "0x4007CA1")]
		private const int CHARATCER_INT_PARAM_CNT = 5;

		// Token: 0x04007CA2 RID: 31906
		[Token(Token = "0x4007CA2")]
		private const int CHARATCER_STRING_PARAM_CNT = 1;

		// Token: 0x04007CA3 RID: 31907
		[Token(Token = "0x4007CA3")]
		private const int OTHER_INT_PARAM_CNT = 1;

		// Token: 0x04007CA4 RID: 31908
		[Token(Token = "0x4007CA4")]
		private const int OTHER_STRING_PARAM_CNT = 0;

		// Token: 0x04007CA5 RID: 31909
		[Token(Token = "0x4007CA5")]
		[FieldOffset(Offset = "0x10")]
		public PlayerSide side;

		// Token: 0x04007CA6 RID: 31910
		[Token(Token = "0x4007CA6")]
		[FieldOffset(Offset = "0x14")]
		public PlayerOperator oprt;

		// Token: 0x04007CA7 RID: 31911
		[Token(Token = "0x4007CA7")]
		[FieldOffset(Offset = "0x18")]
		public CharacterAction action;

		// Token: 0x04007CA8 RID: 31912
		[Token(Token = "0x4007CA8")]
		[FieldOffset(Offset = "0x1C")]
		public SharedConsts.Direction dir;

		// Token: 0x04007CA9 RID: 31913
		[Token(Token = "0x4007CA9")]
		[FieldOffset(Offset = "0x20")]
		public GridPosition grid;

		// Token: 0x04007CAA RID: 31914
		[Token(Token = "0x4007CAA")]
		[FieldOffset(Offset = "0x28")]
		public BattleCharacterData.Signiture sig;

		// Token: 0x04007CAB RID: 31915
		[Token(Token = "0x4007CAB")]
		[FieldOffset(Offset = "0x38")]
		public int status;
	}
}
