using System;
using Il2CppDummyDll;
using Torappu.DataStream;
using Torappu.ObjectPool;

namespace Torappu.UI.EnemyDuel.Service
{
	// Token: 0x02005093 RID: 20627
	[Token(Token = "0x2005093")]
	public class EnemyDuelEmojiData : IReusable
	{
		// Token: 0x0601E89E RID: 125086 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E89E")]
		[Address(RVA = "0x183F3B0", Offset = "0x183DFB0", VA = "0x18183F3B0")]
		public void Read(IStreamReader from)
		{
		}

		// Token: 0x0601E89F RID: 125087 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E89F")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "4")]
		public void OnAllocate()
		{
		}

		// Token: 0x0601E8A0 RID: 125088 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E8A0")]
		[Address(RVA = "0x183F320", Offset = "0x183DF20", VA = "0x18183F320", Slot = "5")]
		public void OnRecycle()
		{
		}

		// Token: 0x0601E8A1 RID: 125089 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E8A1")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public EnemyDuelEmojiData()
		{
		}

		// Token: 0x04028EA6 RID: 167590
		[Token(Token = "0x4028EA6")]
		[FieldOffset(Offset = "0x10")]
		public string id;

		// Token: 0x04028EA7 RID: 167591
		[Token(Token = "0x4028EA7")]
		[FieldOffset(Offset = "0x18")]
		public string emojiGroup;

		// Token: 0x04028EA8 RID: 167592
		[Token(Token = "0x4028EA8")]
		[FieldOffset(Offset = "0x20")]
		public string emojiId;
	}
}
