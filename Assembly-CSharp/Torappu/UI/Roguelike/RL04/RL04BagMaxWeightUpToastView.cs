using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike.RL04
{
	// Token: 0x0200571B RID: 22299
	[Token(Token = "0x200571B")]
	public class RL04BagMaxWeightUpToastView : UINotifyView<RL04BagMaxWeightUpToastView.Param>, IHotfixable
	{
		// Token: 0x06020B08 RID: 133896 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020B08")]
		[Address(RVA = "0x1B0EC70", Offset = "0x1B0D870", VA = "0x181B0EC70", Slot = "9")]
		protected override void Render(RL04BagMaxWeightUpToastView.Param param)
		{
		}

		// Token: 0x06020B09 RID: 133897 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020B09")]
		[Address(RVA = "0x1B0ED20", Offset = "0x1B0D920", VA = "0x181B0ED20")]
		public RL04BagMaxWeightUpToastView()
		{
		}

		// Token: 0x0402C5CA RID: 181706
		[Token(Token = "0x402C5CA")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _desc;

		// Token: 0x0402C5CB RID: 181707
		[Token(Token = "0x402C5CB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402C5CC RID: 181708
		[Token(Token = "0x402C5CC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200571C RID: 22300
		[Token(Token = "0x200571C")]
		public class Param : NotifyViewParam
		{
			// Token: 0x06020B0A RID: 133898 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6020B0A")]
			[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
			public Param()
			{
			}

			// Token: 0x0402C5CD RID: 181709
			[Token(Token = "0x402C5CD")]
			[FieldOffset(Offset = "0x10")]
			public string text;
		}
	}
}
