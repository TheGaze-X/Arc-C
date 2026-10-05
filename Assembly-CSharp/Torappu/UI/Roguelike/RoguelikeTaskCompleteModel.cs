using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x02005552 RID: 21842
	[Token(Token = "0x2005552")]
	public class RoguelikeTaskCompleteModel : IHotfixable
	{
		// Token: 0x17004B5F RID: 19295
		// (get) Token: 0x060201E6 RID: 131558 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004B5F")]
		public RoguelikeTaskData taskData
		{
			[Token(Token = "0x60201E6")]
			[Address(RVA = "0x1A43B70", Offset = "0x1A42770", VA = "0x181A43B70")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004B60 RID: 19296
		// (get) Token: 0x060201E7 RID: 131559 RVA: 0x000B4AB0 File Offset: 0x000B2CB0
		[Token(Token = "0x17004B60")]
		public int currentVal
		{
			[Token(Token = "0x60201E7")]
			[Address(RVA = "0x1A43A50", Offset = "0x1A42650", VA = "0x181A43A50")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17004B61 RID: 19297
		// (get) Token: 0x060201E8 RID: 131560 RVA: 0x000B4AC8 File Offset: 0x000B2CC8
		[Token(Token = "0x17004B61")]
		public int targetVal
		{
			[Token(Token = "0x60201E8")]
			[Address(RVA = "0x1A43B10", Offset = "0x1A42710", VA = "0x181A43B10")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17004B62 RID: 19298
		// (get) Token: 0x060201E9 RID: 131561 RVA: 0x000B4AE0 File Offset: 0x000B2CE0
		[Token(Token = "0x17004B62")]
		public bool isComplted
		{
			[Token(Token = "0x60201E9")]
			[Address(RVA = "0x1A43AB0", Offset = "0x1A426B0", VA = "0x181A43AB0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060201EA RID: 131562 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60201EA")]
		[Address(RVA = "0x1A43890", Offset = "0x1A42490", VA = "0x181A43890")]
		public void LoadData(string topicId)
		{
		}

		// Token: 0x060201EB RID: 131563 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60201EB")]
		[Address(RVA = "0x1A439F0", Offset = "0x1A425F0", VA = "0x181A439F0")]
		public RoguelikeTaskCompleteModel()
		{
		}

		// Token: 0x0402B635 RID: 177717
		[Token(Token = "0x402B635")]
		[FieldOffset(Offset = "0x10")]
		private RoguelikeTaskData m_taskData;

		// Token: 0x0402B636 RID: 177718
		[Token(Token = "0x402B636")]
		[FieldOffset(Offset = "0x18")]
		private int m_curerntVal;

		// Token: 0x0402B637 RID: 177719
		[Token(Token = "0x402B637")]
		[FieldOffset(Offset = "0x1C")]
		private int m_targetVal;

		// Token: 0x0402B638 RID: 177720
		[Token(Token = "0x402B638")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_taskData;

		// Token: 0x0402B639 RID: 177721
		[Token(Token = "0x402B639")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_currentVal;

		// Token: 0x0402B63A RID: 177722
		[Token(Token = "0x402B63A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_targetVal;

		// Token: 0x0402B63B RID: 177723
		[Token(Token = "0x402B63B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_isComplted;

		// Token: 0x0402B63C RID: 177724
		[Token(Token = "0x402B63C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0402B63D RID: 177725
		[Token(Token = "0x402B63D")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
