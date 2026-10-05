using System;
using Il2CppDummyDll;

namespace Torappu.UI.Roguelike.RL05
{
	// Token: 0x020055DB RID: 21979
	[Token(Token = "0x20055DB")]
	public class RL05NodeFreeUnlockStrategy : ICheckNodeUnlockStrategy
	{
		// Token: 0x17004B9E RID: 19358
		// (get) Token: 0x06020428 RID: 132136 RVA: 0x000B51A0 File Offset: 0x000B33A0
		[Token(Token = "0x17004B9E")]
		public int priority
		{
			[Token(Token = "0x6020428")]
			[Address(RVA = "0x13A8070", Offset = "0x13A6C70", VA = "0x1813A8070", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06020429 RID: 132137 RVA: 0x000B51B8 File Offset: 0x000B33B8
		[Token(Token = "0x6020429")]
		[Address(RVA = "0x1A6BF90", Offset = "0x1A6AB90", VA = "0x181A6BF90", Slot = "5")]
		public bool CanHandle(string topicId, RoguelikeTopicDetail detail)
		{
			return default(bool);
		}

		// Token: 0x0602042A RID: 132138 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602042A")]
		[Address(RVA = "0x1A6BFB0", Offset = "0x1A6ABB0", VA = "0x181A6BFB0", Slot = "6")]
		public void Execute(string topicId, UIPage page, Action onSuccess)
		{
		}

		// Token: 0x0602042B RID: 132139 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602042B")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public RL05NodeFreeUnlockStrategy()
		{
		}

		// Token: 0x0402BA43 RID: 178755
		[Token(Token = "0x402BA43")]
		[FieldOffset(Offset = "0x10")]
		private int m_leftTime;

		// Token: 0x0402BA44 RID: 178756
		[Token(Token = "0x402BA44")]
		private const int PRIORITY_FREE = 100;
	}
}
