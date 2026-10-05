using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike.RL04
{
	// Token: 0x02005719 RID: 22297
	[Token(Token = "0x2005719")]
	public class RL04AlchemyInDisasterToastView : UINotifyView<RL04AlchemyInDisasterToastView.Param>, IHotfixable
	{
		// Token: 0x06020B04 RID: 133892 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020B04")]
		[Address(RVA = "0x1B0EB50", Offset = "0x1B0D750", VA = "0x181B0EB50", Slot = "9")]
		protected override void Render(RL04AlchemyInDisasterToastView.Param param)
		{
		}

		// Token: 0x06020B05 RID: 133893 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020B05")]
		[Address(RVA = "0x1B0EC00", Offset = "0x1B0D800", VA = "0x181B0EC00")]
		public RL04AlchemyInDisasterToastView()
		{
		}

		// Token: 0x0402C5C5 RID: 181701
		[Token(Token = "0x402C5C5")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _desc;

		// Token: 0x0402C5C6 RID: 181702
		[Token(Token = "0x402C5C6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402C5C7 RID: 181703
		[Token(Token = "0x402C5C7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200571A RID: 22298
		[Token(Token = "0x200571A")]
		public class Param : NotifyViewParam
		{
			// Token: 0x06020B06 RID: 133894 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6020B06")]
			[Address(RVA = "0x1B042F0", Offset = "0x1B02EF0", VA = "0x181B042F0", Slot = "4")]
			public override string GenerateSignature()
			{
				return null;
			}

			// Token: 0x06020B07 RID: 133895 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6020B07")]
			[Address(RVA = "0x1535180", Offset = "0x1533D80", VA = "0x181535180")]
			public Param()
			{
			}

			// Token: 0x0402C5C8 RID: 181704
			[Token(Token = "0x402C5C8")]
			[FieldOffset(Offset = "0x10")]
			public string notifyTips;

			// Token: 0x0402C5C9 RID: 181705
			[Token(Token = "0x402C5C9")]
			[FieldOffset(Offset = "0x18")]
			public bool useDeduplicate;
		}
	}
}
