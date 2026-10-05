using System;
using Il2CppDummyDll;
using Torappu.Battle;
using Torappu.DataStream;
using Torappu.ObjectPool;

namespace Torappu.Multiplayer
{
	// Token: 0x02001538 RID: 5432
	[Token(Token = "0x2001538")]
	public class GameMarkData : IReusable
	{
		// Token: 0x06007CA0 RID: 31904 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007CA0")]
		[Address(RVA = "0x28415A0", Offset = "0x28401A0", VA = "0x1828415A0")]
		public GameMarkData()
		{
		}

		// Token: 0x06007CA1 RID: 31905 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007CA1")]
		[Address(RVA = "0x2841090", Offset = "0x283FC90", VA = "0x182841090")]
		public void AssignPinData(PinType pinType, GridPosition grid)
		{
		}

		// Token: 0x06007CA2 RID: 31906 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007CA2")]
		[Address(RVA = "0x2841060", Offset = "0x283FC60", VA = "0x182841060")]
		public void AssignDummyDragData(BattleCharacterData.Signiture sig, GridPosition grid, SharedConsts.Direction dir)
		{
		}

		// Token: 0x06007CA3 RID: 31907 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007CA3")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "4")]
		public void OnAllocate()
		{
		}

		// Token: 0x06007CA4 RID: 31908 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007CA4")]
		[Address(RVA = "0x2841120", Offset = "0x283FD20", VA = "0x182841120", Slot = "5")]
		public void OnRecycle()
		{
		}

		// Token: 0x06007CA5 RID: 31909 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007CA5")]
		[Address(RVA = "0x2841190", Offset = "0x283FD90", VA = "0x182841190")]
		public void ReadFrom(IStreamReader data)
		{
		}

		// Token: 0x06007CA6 RID: 31910 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007CA6")]
		[Address(RVA = "0x28413B0", Offset = "0x283FFB0", VA = "0x1828413B0")]
		public void WriteTo(IStreamWriter data)
		{
		}

		// Token: 0x06007CA7 RID: 31911 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007CA7")]
		[Address(RVA = "0x28410A0", Offset = "0x283FCA0", VA = "0x1828410A0")]
		public void CopyFrom(GameMarkData data)
		{
		}

		// Token: 0x04007CAC RID: 31916
		[Token(Token = "0x4007CAC")]
		private const int PIN_INT_PARAM_CNT = 3;

		// Token: 0x04007CAD RID: 31917
		[Token(Token = "0x4007CAD")]
		private const int NONE_PARAM_CNT = 0;

		// Token: 0x04007CAE RID: 31918
		[Token(Token = "0x4007CAE")]
		private const int DUMMY_INT_PARAM_CNT = 4;

		// Token: 0x04007CAF RID: 31919
		[Token(Token = "0x4007CAF")]
		private const int DUMMY_STRING_PARAM_CNT = 1;

		// Token: 0x04007CB0 RID: 31920
		[Token(Token = "0x4007CB0")]
		private const int EMOJI_STRING_PARAM_CNT = 2;

		// Token: 0x04007CB1 RID: 31921
		[Token(Token = "0x4007CB1")]
		[FieldOffset(Offset = "0x10")]
		public PlayerSide side;

		// Token: 0x04007CB2 RID: 31922
		[Token(Token = "0x4007CB2")]
		[FieldOffset(Offset = "0x14")]
		public PlayerMarkType opr;

		// Token: 0x04007CB3 RID: 31923
		[Token(Token = "0x4007CB3")]
		[FieldOffset(Offset = "0x18")]
		public PinType pinType;

		// Token: 0x04007CB4 RID: 31924
		[Token(Token = "0x4007CB4")]
		[FieldOffset(Offset = "0x1C")]
		public GridPosition grid;

		// Token: 0x04007CB5 RID: 31925
		[Token(Token = "0x4007CB5")]
		[FieldOffset(Offset = "0x24")]
		public SharedConsts.Direction dir;

		// Token: 0x04007CB6 RID: 31926
		[Token(Token = "0x4007CB6")]
		[FieldOffset(Offset = "0x28")]
		public BattleCharacterData.Signiture sig;

		// Token: 0x04007CB7 RID: 31927
		[Token(Token = "0x4007CB7")]
		[FieldOffset(Offset = "0x38")]
		public string emojiGroup;

		// Token: 0x04007CB8 RID: 31928
		[Token(Token = "0x4007CB8")]
		[FieldOffset(Offset = "0x40")]
		public string emojiId;
	}
}
