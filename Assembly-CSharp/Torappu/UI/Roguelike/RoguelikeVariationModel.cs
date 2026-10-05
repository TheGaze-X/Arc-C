using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x02005355 RID: 21333
	[Token(Token = "0x2005355")]
	public struct RoguelikeVariationModel : IHotfixable
	{
		// Token: 0x170049BD RID: 18877
		// (get) Token: 0x0601F735 RID: 128821 RVA: 0x000B1F48 File Offset: 0x000B0148
		[Token(Token = "0x170049BD")]
		public bool isEmpty
		{
			[Token(Token = "0x601F735")]
			[Address(RVA = "0x19367D0", Offset = "0x19353D0", VA = "0x1819367D0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0601F736 RID: 128822 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F736")]
		[Address(RVA = "0x1936500", Offset = "0x1935100", VA = "0x181936500")]
		public void LoadData(string topicId, string variationId)
		{
		}

		// Token: 0x0402A50C RID: 173324
		[Token(Token = "0x402A50C")]
		[FieldOffset(Offset = "0x0")]
		public string id;

		// Token: 0x0402A50D RID: 173325
		[Token(Token = "0x402A50D")]
		[FieldOffset(Offset = "0x8")]
		public string outerName;

		// Token: 0x0402A50E RID: 173326
		[Token(Token = "0x402A50E")]
		[FieldOffset(Offset = "0x10")]
		public string innerName;

		// Token: 0x0402A50F RID: 173327
		[Token(Token = "0x402A50F")]
		[FieldOffset(Offset = "0x18")]
		public string effect;

		// Token: 0x0402A510 RID: 173328
		[Token(Token = "0x402A510")]
		[FieldOffset(Offset = "0x20")]
		public string desc;

		// Token: 0x0402A511 RID: 173329
		[Token(Token = "0x402A511")]
		[FieldOffset(Offset = "0x28")]
		public string icon;

		// Token: 0x0402A512 RID: 173330
		[Token(Token = "0x402A512")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isEmpty;

		// Token: 0x0402A513 RID: 173331
		[Token(Token = "0x402A513")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LoadData;
	}
}
