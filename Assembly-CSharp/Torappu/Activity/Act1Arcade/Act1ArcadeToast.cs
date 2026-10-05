using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act1Arcade
{
	// Token: 0x02007960 RID: 31072
	[Token(Token = "0x2007960")]
	public class Act1ArcadeToast : UINotifyView<Act1ArcadeToast.Param>
	{
		// Token: 0x0602B97B RID: 178555 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B97B")]
		[Address(RVA = "0x2791290", Offset = "0x278FE90", VA = "0x182791290", Slot = "9")]
		protected override void Render(Act1ArcadeToast.Param param)
		{
		}

		// Token: 0x0602B97C RID: 178556 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B97C")]
		[Address(RVA = "0x2791360", Offset = "0x278FF60", VA = "0x182791360")]
		public Act1ArcadeToast()
		{
		}

		// Token: 0x0403F0E9 RID: 258281
		[Token(Token = "0x403F0E9")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _mainContent;

		// Token: 0x0403F0EA RID: 258282
		[Token(Token = "0x403F0EA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403F0EB RID: 258283
		[Token(Token = "0x403F0EB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02007961 RID: 31073
		[Token(Token = "0x2007961")]
		public class Param : NotifyViewParam
		{
			// Token: 0x0602B97D RID: 178557 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602B97D")]
			[Address(RVA = "0x2791A20", Offset = "0x2790620", VA = "0x182791A20", Slot = "4")]
			public override string GenerateSignature()
			{
				return null;
			}

			// Token: 0x0602B97E RID: 178558 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602B97E")]
			[Address(RVA = "0x1535180", Offset = "0x1533D80", VA = "0x181535180")]
			public Param()
			{
			}

			// Token: 0x0403F0EC RID: 258284
			[Token(Token = "0x403F0EC")]
			[FieldOffset(Offset = "0x10")]
			public string mainContent;

			// Token: 0x0403F0ED RID: 258285
			[Token(Token = "0x403F0ED")]
			[FieldOffset(Offset = "0x18")]
			public bool useDeduplicate;
		}
	}
}
