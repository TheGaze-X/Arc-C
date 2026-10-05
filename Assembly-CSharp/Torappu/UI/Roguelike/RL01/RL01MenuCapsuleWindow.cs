using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike.RL01
{
	// Token: 0x020057BC RID: 22460
	[Token(Token = "0x20057BC")]
	public class RL01MenuCapsuleWindow : RoguelikeMenuWindow<RL01CapsuleViewModel>
	{
		// Token: 0x17004D09 RID: 19721
		// (get) Token: 0x06020DA7 RID: 134567 RVA: 0x000B78E8 File Offset: 0x000B5AE8
		[Token(Token = "0x17004D09")]
		public override RoguelikeMenuType selectType
		{
			[Token(Token = "0x6020DA7")]
			[Address(RVA = "0x1B1C430", Offset = "0x1B1B030", VA = "0x181B1C430", Slot = "4")]
			get
			{
				return RoguelikeMenuType.INIT_SQUAD;
			}
		}

		// Token: 0x06020DA8 RID: 134568 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020DA8")]
		[Address(RVA = "0x1B1C110", Offset = "0x1B1AD10", VA = "0x181B1C110", Slot = "10")]
		public override void Render(RL01CapsuleViewModel viewModel)
		{
		}

		// Token: 0x06020DA9 RID: 134569 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020DA9")]
		[Address(RVA = "0x1B1C3C0", Offset = "0x1B1AFC0", VA = "0x181B1C3C0")]
		public RL01MenuCapsuleWindow()
		{
		}

		// Token: 0x0402CA3E RID: 182846
		[Token(Token = "0x402CA3E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _imageIcon;

		// Token: 0x0402CA3F RID: 182847
		[Token(Token = "0x402CA3F")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textName;

		// Token: 0x0402CA40 RID: 182848
		[Token(Token = "0x402CA40")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _textUsage;

		// Token: 0x0402CA41 RID: 182849
		[Token(Token = "0x402CA41")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Image _imageBkg;

		// Token: 0x0402CA42 RID: 182850
		[Token(Token = "0x402CA42")]
		[FieldOffset(Offset = "0x48")]
		private RoguelikeCapsuleViewModel m_cachedModel;

		// Token: 0x0402CA43 RID: 182851
		[Token(Token = "0x402CA43")]
		[FieldOffset(Offset = "0x50")]
		private string m_cachedItemId;

		// Token: 0x0402CA44 RID: 182852
		[Token(Token = "0x402CA44")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_selectType;

		// Token: 0x0402CA45 RID: 182853
		[Token(Token = "0x402CA45")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402CA46 RID: 182854
		[Token(Token = "0x402CA46")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
