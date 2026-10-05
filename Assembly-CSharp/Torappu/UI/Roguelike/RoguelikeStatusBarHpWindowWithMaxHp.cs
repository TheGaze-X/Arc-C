using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x0200532E RID: 21294
	[Token(Token = "0x200532E")]
	public class RoguelikeStatusBarHpWindowWithMaxHp : RoguelikeMenuWindow<RoguelikeStatusBarHpWithMaxHpViewModel>
	{
		// Token: 0x170049A0 RID: 18848
		// (get) Token: 0x0601F68C RID: 128652 RVA: 0x000B1D68 File Offset: 0x000AFF68
		[Token(Token = "0x170049A0")]
		public override RoguelikeMenuType selectType
		{
			[Token(Token = "0x601F68C")]
			[Address(RVA = "0x191B9B0", Offset = "0x191A5B0", VA = "0x18191B9B0", Slot = "4")]
			get
			{
				return RoguelikeMenuType.INIT_SQUAD;
			}
		}

		// Token: 0x0601F68D RID: 128653 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601F68D")]
		[Address(RVA = "0x191B680", Offset = "0x191A280", VA = "0x18191B680", Slot = "9")]
		protected override UISwitchTween GetSwitchTween()
		{
			return null;
		}

		// Token: 0x0601F68E RID: 128654 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F68E")]
		[Address(RVA = "0x191B800", Offset = "0x191A400", VA = "0x18191B800", Slot = "10")]
		public override void Render(RoguelikeStatusBarHpWithMaxHpViewModel viewModel)
		{
		}

		// Token: 0x0601F68F RID: 128655 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F68F")]
		[Address(RVA = "0x191B920", Offset = "0x191A520", VA = "0x18191B920")]
		public RoguelikeStatusBarHpWindowWithMaxHp()
		{
		}

		// Token: 0x0601F691 RID: 128657 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601F691")]
		[Address(RVA = "0x19153C0", Offset = "0x1913FC0", VA = "0x1819153C0")]
		private UISwitchTween <>xLuaBaseProxy_GetSwitchTween()
		{
			return null;
		}

		// Token: 0x0402A3DA RID: 173018
		[Token(Token = "0x402A3DA")]
		[FieldOffset(Offset = "0x0")]
		private new static Vector2 WINDOW_HIDE_POS;

		// Token: 0x0402A3DB RID: 173019
		[Token(Token = "0x402A3DB")]
		[FieldOffset(Offset = "0x8")]
		private new static Vector2 WINDOW_SHOW_POS;

		// Token: 0x0402A3DC RID: 173020
		[Token(Token = "0x402A3DC")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textShield;

		// Token: 0x0402A3DD RID: 173021
		[Token(Token = "0x402A3DD")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_selectType;

		// Token: 0x0402A3DE RID: 173022
		[Token(Token = "0x402A3DE")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetSwitchTween;

		// Token: 0x0402A3DF RID: 173023
		[Token(Token = "0x402A3DF")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402A3E0 RID: 173024
		[Token(Token = "0x402A3E0")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
