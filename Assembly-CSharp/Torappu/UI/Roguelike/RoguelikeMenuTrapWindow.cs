using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x0200532C RID: 21292
	[Token(Token = "0x200532C")]
	public class RoguelikeMenuTrapWindow : RoguelikeMenuWindow<RoguelikeMenuRelicViewModel>
	{
		// Token: 0x1700499E RID: 18846
		// (get) Token: 0x0601F683 RID: 128643 RVA: 0x000B1D38 File Offset: 0x000AFF38
		[Token(Token = "0x1700499E")]
		public override RoguelikeMenuType selectType
		{
			[Token(Token = "0x601F683")]
			[Address(RVA = "0x191A390", Offset = "0x1918F90", VA = "0x18191A390", Slot = "4")]
			get
			{
				return RoguelikeMenuType.INIT_SQUAD;
			}
		}

		// Token: 0x0601F684 RID: 128644 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F684")]
		[Address(RVA = "0x191A110", Offset = "0x1918D10", VA = "0x18191A110", Slot = "10")]
		public override void Render(RoguelikeMenuRelicViewModel viewModel)
		{
		}

		// Token: 0x0601F685 RID: 128645 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F685")]
		[Address(RVA = "0x191A320", Offset = "0x1918F20", VA = "0x18191A320")]
		public RoguelikeMenuTrapWindow()
		{
		}

		// Token: 0x0402A3CB RID: 173003
		[Token(Token = "0x402A3CB")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _imageIcon;

		// Token: 0x0402A3CC RID: 173004
		[Token(Token = "0x402A3CC")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textName;

		// Token: 0x0402A3CD RID: 173005
		[Token(Token = "0x402A3CD")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _textUsage;

		// Token: 0x0402A3CE RID: 173006
		[Token(Token = "0x402A3CE")]
		[FieldOffset(Offset = "0x40")]
		private RoguelikeTrapViewModel m_cachedModel;

		// Token: 0x0402A3CF RID: 173007
		[Token(Token = "0x402A3CF")]
		[FieldOffset(Offset = "0x48")]
		private string m_cachedItemId;

		// Token: 0x0402A3D0 RID: 173008
		[Token(Token = "0x402A3D0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_selectType;

		// Token: 0x0402A3D1 RID: 173009
		[Token(Token = "0x402A3D1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402A3D2 RID: 173010
		[Token(Token = "0x402A3D2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
