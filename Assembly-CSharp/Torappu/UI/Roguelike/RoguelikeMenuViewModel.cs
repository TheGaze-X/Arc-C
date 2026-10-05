using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x0200535C RID: 21340
	[Token(Token = "0x200535C")]
	public class RoguelikeMenuViewModel : IHotfixable
	{
		// Token: 0x170049C0 RID: 18880
		// (set) Token: 0x0601F74C RID: 128844 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170049C0")]
		public bool isInit
		{
			[Token(Token = "0x601F74C")]
			[Address(RVA = "0x192B190", Offset = "0x1929D90", VA = "0x18192B190")]
			set
			{
			}
		}

		// Token: 0x0601F74D RID: 128845 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F74D")]
		[Address(RVA = "0x192AF70", Offset = "0x1929B70", VA = "0x18192AF70")]
		public void LoadData(string topicId)
		{
		}

		// Token: 0x0601F74E RID: 128846 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F74E")]
		[Address(RVA = "0x192ADA0", Offset = "0x19299A0", VA = "0x18192ADA0")]
		public void AddCompViewModel(Type type)
		{
		}

		// Token: 0x0601F74F RID: 128847 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601F74F")]
		[Address(RVA = "0x192AEE0", Offset = "0x1929AE0", VA = "0x18192AEE0")]
		public RoguelikeMenuCompViewModel GetCompViewModel(Type type)
		{
			return null;
		}

		// Token: 0x0601F750 RID: 128848 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F750")]
		[Address(RVA = "0x192B0E0", Offset = "0x1929CE0", VA = "0x18192B0E0")]
		public RoguelikeMenuViewModel()
		{
		}

		// Token: 0x0402A538 RID: 173368
		[Token(Token = "0x402A538")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<Type, RoguelikeMenuCompViewModel> data;

		// Token: 0x0402A539 RID: 173369
		[Token(Token = "0x402A539")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_set_isInit;

		// Token: 0x0402A53A RID: 173370
		[Token(Token = "0x402A53A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0402A53B RID: 173371
		[Token(Token = "0x402A53B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_AddCompViewModel;

		// Token: 0x0402A53C RID: 173372
		[Token(Token = "0x402A53C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetCompViewModel;

		// Token: 0x0402A53D RID: 173373
		[Token(Token = "0x402A53D")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
