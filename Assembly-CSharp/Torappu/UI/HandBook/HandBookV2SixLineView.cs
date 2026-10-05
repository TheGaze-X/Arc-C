using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.HandBook
{
	// Token: 0x02006717 RID: 26391
	[Token(Token = "0x2006717")]
	public class HandBookV2SixLineView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06025DE3 RID: 155107 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025DE3")]
		[Address(RVA = "0x20E6D10", Offset = "0x20E5910", VA = "0x1820E6D10")]
		public void Init(HandBookV2GroupCharViewModel viewModel)
		{
		}

		// Token: 0x06025DE4 RID: 155108 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025DE4")]
		[Address(RVA = "0x20E6FE0", Offset = "0x20E5BE0", VA = "0x1820E6FE0")]
		public void Init(HandBookV2GroupColorBlockViewModel viewModel)
		{
		}

		// Token: 0x06025DE5 RID: 155109 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025DE5")]
		[Address(RVA = "0x20E72D0", Offset = "0x20E5ED0", VA = "0x1820E72D0")]
		public HandBookV2SixLineView()
		{
		}

		// Token: 0x0403542D RID: 218157
		[Token(Token = "0x403542D")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image[] _sixLine;

		// Token: 0x0403542E RID: 218158
		[Token(Token = "0x403542E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Sprite[] _sixLineSprite;

		// Token: 0x0403542F RID: 218159
		[Token(Token = "0x403542F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04035430 RID: 218160
		[Token(Token = "0x4035430")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix1_Init;

		// Token: 0x04035431 RID: 218161
		[Token(Token = "0x4035431")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
