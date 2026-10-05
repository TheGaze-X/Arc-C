using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.CrossAppShare
{
	// Token: 0x020058C5 RID: 22725
	[Token(Token = "0x20058C5")]
	public class CrossAppShareImageModel : CrossAppShareComponentBaseModel
	{
		// Token: 0x0602128D RID: 135821 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602128D")]
		[Address(RVA = "0x1B74100", Offset = "0x1B72D00", VA = "0x181B74100")]
		public void InitModel(Image iImage)
		{
		}

		// Token: 0x0602128E RID: 135822 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602128E")]
		[Address(RVA = "0x1B74260", Offset = "0x1B72E60", VA = "0x181B74260")]
		public CrossAppShareImageModel()
		{
		}

		// Token: 0x0402D294 RID: 184980
		[Token(Token = "0x402D294")]
		[FieldOffset(Offset = "0x18")]
		public Sprite sprite;

		// Token: 0x0402D295 RID: 184981
		[Token(Token = "0x402D295")]
		[FieldOffset(Offset = "0x20")]
		public Color color;

		// Token: 0x0402D296 RID: 184982
		[Token(Token = "0x402D296")]
		[FieldOffset(Offset = "0x30")]
		public Material material;

		// Token: 0x0402D297 RID: 184983
		[Token(Token = "0x402D297")]
		[FieldOffset(Offset = "0x38")]
		public float fillAmount;

		// Token: 0x0402D298 RID: 184984
		[Token(Token = "0x402D298")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_InitModel;

		// Token: 0x0402D299 RID: 184985
		[Token(Token = "0x402D299")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
