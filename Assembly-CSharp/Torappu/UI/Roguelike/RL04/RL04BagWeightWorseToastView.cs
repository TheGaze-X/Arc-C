using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike.RL04
{
	// Token: 0x0200571D RID: 22301
	[Token(Token = "0x200571D")]
	public class RL04BagWeightWorseToastView : UINotifyView<RL04BagWeightWorseToastView.Param>, IHotfixable
	{
		// Token: 0x06020B0B RID: 133899 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020B0B")]
		[Address(RVA = "0x1B0ED90", Offset = "0x1B0D990", VA = "0x181B0ED90", Slot = "9")]
		protected override void Render(RL04BagWeightWorseToastView.Param param)
		{
		}

		// Token: 0x06020B0C RID: 133900 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020B0C")]
		[Address(RVA = "0x1B0EE60", Offset = "0x1B0DA60", VA = "0x181B0EE60")]
		public RL04BagWeightWorseToastView()
		{
		}

		// Token: 0x0402C5CE RID: 181710
		[Token(Token = "0x402C5CE")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _limitPanel;

		// Token: 0x0402C5CF RID: 181711
		[Token(Token = "0x402C5CF")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _overWeightPanel;

		// Token: 0x0402C5D0 RID: 181712
		[Token(Token = "0x402C5D0")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _desc;

		// Token: 0x0402C5D1 RID: 181713
		[Token(Token = "0x402C5D1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402C5D2 RID: 181714
		[Token(Token = "0x402C5D2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200571E RID: 22302
		[Token(Token = "0x200571E")]
		public class Param : NotifyViewParam
		{
			// Token: 0x06020B0D RID: 133901 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6020B0D")]
			[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
			public Param()
			{
			}

			// Token: 0x0402C5D3 RID: 181715
			[Token(Token = "0x402C5D3")]
			[FieldOffset(Offset = "0x10")]
			public FragmentBagStatus status;

			// Token: 0x0402C5D4 RID: 181716
			[Token(Token = "0x402C5D4")]
			[FieldOffset(Offset = "0x18")]
			public string desc;
		}
	}
}
