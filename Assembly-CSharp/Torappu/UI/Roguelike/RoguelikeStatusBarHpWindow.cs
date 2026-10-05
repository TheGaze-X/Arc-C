using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x0200532D RID: 21293
	[Token(Token = "0x200532D")]
	public class RoguelikeStatusBarHpWindow : RoguelikeMenuWindow<RoguelikeMenuHpViewModel>
	{
		// Token: 0x1700499F RID: 18847
		// (get) Token: 0x0601F686 RID: 128646 RVA: 0x000B1D50 File Offset: 0x000AFF50
		[Token(Token = "0x1700499F")]
		public override RoguelikeMenuType selectType
		{
			[Token(Token = "0x601F686")]
			[Address(RVA = "0x191BD50", Offset = "0x191A950", VA = "0x18191BD50", Slot = "4")]
			get
			{
				return RoguelikeMenuType.INIT_SQUAD;
			}
		}

		// Token: 0x0601F687 RID: 128647 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601F687")]
		[Address(RVA = "0x191BA20", Offset = "0x191A620", VA = "0x18191BA20", Slot = "9")]
		protected override UISwitchTween GetSwitchTween()
		{
			return null;
		}

		// Token: 0x0601F688 RID: 128648 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F688")]
		[Address(RVA = "0x191BBA0", Offset = "0x191A7A0", VA = "0x18191BBA0", Slot = "10")]
		public override void Render(RoguelikeMenuHpViewModel viewModel)
		{
		}

		// Token: 0x0601F689 RID: 128649 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F689")]
		[Address(RVA = "0x191BCC0", Offset = "0x191A8C0", VA = "0x18191BCC0")]
		public RoguelikeStatusBarHpWindow()
		{
		}

		// Token: 0x0601F68B RID: 128651 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601F68B")]
		[Address(RVA = "0x19153C0", Offset = "0x1913FC0", VA = "0x1819153C0")]
		private UISwitchTween <>xLuaBaseProxy_GetSwitchTween()
		{
			return null;
		}

		// Token: 0x0402A3D3 RID: 173011
		[Token(Token = "0x402A3D3")]
		[FieldOffset(Offset = "0x0")]
		private new static Vector2 WINDOW_HIDE_POS;

		// Token: 0x0402A3D4 RID: 173012
		[Token(Token = "0x402A3D4")]
		[FieldOffset(Offset = "0x8")]
		private new static Vector2 WINDOW_SHOW_POS;

		// Token: 0x0402A3D5 RID: 173013
		[Token(Token = "0x402A3D5")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textShieldHpDesc;

		// Token: 0x0402A3D6 RID: 173014
		[Token(Token = "0x402A3D6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_selectType;

		// Token: 0x0402A3D7 RID: 173015
		[Token(Token = "0x402A3D7")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetSwitchTween;

		// Token: 0x0402A3D8 RID: 173016
		[Token(Token = "0x402A3D8")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402A3D9 RID: 173017
		[Token(Token = "0x402A3D9")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
