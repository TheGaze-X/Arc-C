using System;
using Il2CppDummyDll;

namespace Torappu.UI.Roguelike
{
	// Token: 0x02005242 RID: 21058
	[Token(Token = "0x2005242")]
	public class RoguelikeCommonNodeCostItemUnlockStrategy : ICheckNodeUnlockStrategy
	{
		// Token: 0x170048AC RID: 18604
		// (get) Token: 0x0601F12E RID: 127278 RVA: 0x000B0D30 File Offset: 0x000AEF30
		[Token(Token = "0x170048AC")]
		public int priority
		{
			[Token(Token = "0x601F12E")]
			[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0601F12F RID: 127279 RVA: 0x000B0D48 File Offset: 0x000AEF48
		[Token(Token = "0x601F12F")]
		[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "5")]
		public bool CanHandle(string topicId, RoguelikeTopicDetail detail)
		{
			return default(bool);
		}

		// Token: 0x0601F130 RID: 127280 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F130")]
		[Address(RVA = "0x18C8290", Offset = "0x18C6E90", VA = "0x1818C8290", Slot = "6")]
		public void Execute(string topicId, UIPage page, Action onSuccess)
		{
		}

		// Token: 0x0601F131 RID: 127281 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F131")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public RoguelikeCommonNodeCostItemUnlockStrategy()
		{
		}

		// Token: 0x04029AC4 RID: 170692
		[Token(Token = "0x4029AC4")]
		private const int PRIORITY_COMMON = 0;
	}
}
