using System;
using Il2CppDummyDll;
using Torappu.Battle;
using Torappu.DataStream;
using Torappu.ObjectPool;

namespace Torappu.UI.EnemyDuel.Service
{
	// Token: 0x02005091 RID: 20625
	[Token(Token = "0x2005091")]
	public class EnemyDuelServiceAction : IStreamSerialize, IStreamDeserialize, IReusable
	{
		// Token: 0x0601E895 RID: 125077 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E895")]
		[Address(RVA = "0x183F7B0", Offset = "0x183E3B0", VA = "0x18183F7B0", Slot = "5")]
		public void Read(IStreamReader from)
		{
		}

		// Token: 0x0601E896 RID: 125078 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E896")]
		[Address(RVA = "0x183F890", Offset = "0x183E490", VA = "0x18183F890", Slot = "4")]
		public void Write(IStreamWriter to)
		{
		}

		// Token: 0x0601E897 RID: 125079 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E897")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "6")]
		public void OnAllocate()
		{
		}

		// Token: 0x0601E898 RID: 125080 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E898")]
		[Address(RVA = "0x183F760", Offset = "0x183E360", VA = "0x18183F760", Slot = "7")]
		public void OnRecycle()
		{
		}

		// Token: 0x0601E899 RID: 125081 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E899")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public EnemyDuelServiceAction()
		{
		}

		// Token: 0x04028E9C RID: 167580
		[Token(Token = "0x4028E9C")]
		private const int CHARATCER_INT_PARAM_CNT = 2;

		// Token: 0x04028E9D RID: 167581
		[Token(Token = "0x4028E9D")]
		private const int CHARATCER_STRING_PARAM_CNT = 1;

		// Token: 0x04028E9E RID: 167582
		[Token(Token = "0x4028E9E")]
		[FieldOffset(Offset = "0x10")]
		public EnemyDuelServiceOperate operate;

		// Token: 0x04028E9F RID: 167583
		[Token(Token = "0x4028E9F")]
		[FieldOffset(Offset = "0x14")]
		public EnemyDuelCharacterAction action;

		// Token: 0x04028EA0 RID: 167584
		[Token(Token = "0x4028EA0")]
		[FieldOffset(Offset = "0x18")]
		public BattleCharacterData.Signiture sig;
	}
}
