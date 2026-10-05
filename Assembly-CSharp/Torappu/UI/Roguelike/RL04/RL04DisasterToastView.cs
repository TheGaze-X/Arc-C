using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike.RL04
{
	// Token: 0x0200571F RID: 22303
	[Token(Token = "0x200571F")]
	public class RL04DisasterToastView : UINotifyView<RL04DisasterToastView.Param>
	{
		// Token: 0x06020B0E RID: 133902 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020B0E")]
		[Address(RVA = "0x1B0F030", Offset = "0x1B0DC30", VA = "0x181B0F030", Slot = "9")]
		protected override void Render(RL04DisasterToastView.Param param)
		{
		}

		// Token: 0x06020B0F RID: 133903 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020B0F")]
		[Address(RVA = "0x1B0F210", Offset = "0x1B0DE10", VA = "0x181B0F210")]
		public RL04DisasterToastView()
		{
		}

		// Token: 0x0402C5D5 RID: 181717
		[Token(Token = "0x402C5D5")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _panelStart;

		// Token: 0x0402C5D6 RID: 181718
		[Token(Token = "0x402C5D6")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _panelEnd;

		// Token: 0x0402C5D7 RID: 181719
		[Token(Token = "0x402C5D7")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Image _disasterIcon;

		// Token: 0x0402C5D8 RID: 181720
		[Token(Token = "0x402C5D8")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _txtDisasterName;

		// Token: 0x0402C5D9 RID: 181721
		[Token(Token = "0x402C5D9")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private UIAtlasImage[] _levelLines;

		// Token: 0x0402C5DA RID: 181722
		[Token(Token = "0x402C5DA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402C5DB RID: 181723
		[Token(Token = "0x402C5DB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005720 RID: 22304
		[Token(Token = "0x2005720")]
		public class Param : NotifyViewParam
		{
			// Token: 0x06020B10 RID: 133904 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6020B10")]
			[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
			public Param()
			{
			}

			// Token: 0x0402C5DC RID: 181724
			[Token(Token = "0x402C5DC")]
			[FieldOffset(Offset = "0x10")]
			public string disasterName;

			// Token: 0x0402C5DD RID: 181725
			[Token(Token = "0x402C5DD")]
			[FieldOffset(Offset = "0x18")]
			public Sprite disasterIcon;

			// Token: 0x0402C5DE RID: 181726
			[Token(Token = "0x402C5DE")]
			[FieldOffset(Offset = "0x20")]
			public int disasterLevel;

			// Token: 0x0402C5DF RID: 181727
			[Token(Token = "0x402C5DF")]
			[FieldOffset(Offset = "0x24")]
			public bool start;
		}
	}
}
