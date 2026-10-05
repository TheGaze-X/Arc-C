using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020051DD RID: 20957
	[Token(Token = "0x20051DD")]
	public class RoguelikeDrawCopperStateBean : IStateBean, IHotfixable
	{
		// Token: 0x17004847 RID: 18503
		// (get) Token: 0x0601EF3B RID: 126779 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004847")]
		public RoguelikeDrawCopperProperty prop
		{
			[Token(Token = "0x601EF3B")]
			[Address(RVA = "0x18B54C0", Offset = "0x18B40C0", VA = "0x1818B54C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601EF3C RID: 126780 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EF3C")]
		[Address(RVA = "0x18B5110", Offset = "0x18B3D10", VA = "0x1818B5110")]
		public void LoadData(string topicId)
		{
		}

		// Token: 0x0601EF3D RID: 126781 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EF3D")]
		[Address(RVA = "0x18B53D0", Offset = "0x18B3FD0", VA = "0x1818B53D0")]
		public RoguelikeDrawCopperStateBean()
		{
		}

		// Token: 0x04029897 RID: 170135
		[Token(Token = "0x4029897")]
		[FieldOffset(Offset = "0x10")]
		public string topicId;

		// Token: 0x04029898 RID: 170136
		[Token(Token = "0x4029898")]
		[FieldOffset(Offset = "0x18")]
		private RoguelikeDrawCopperProperty m_prop;

		// Token: 0x04029899 RID: 170137
		[Token(Token = "0x4029899")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_prop;

		// Token: 0x0402989A RID: 170138
		[Token(Token = "0x402989A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0402989B RID: 170139
		[Token(Token = "0x402989B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
