using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Effects
{
	// Token: 0x02003257 RID: 12887
	[Token(Token = "0x2003257")]
	public class AutoChessRefreshBehaviour : Effect.Behaviour
	{
		// Token: 0x1700305D RID: 12381
		// (get) Token: 0x060146FF RID: 83711 RVA: 0x00086D78 File Offset: 0x00084F78
		[Token(Token = "0x1700305D")]
		private bool isSpecialEffect
		{
			[Token(Token = "0x60146FF")]
			[Address(RVA = "0xCAF910", Offset = "0xCAE510", VA = "0x180CAF910")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06014700 RID: 83712 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014700")]
		[Address(RVA = "0xCAF760", Offset = "0xCAE360", VA = "0x180CAF760", Slot = "5")]
		public override void OnPlay()
		{
		}

		// Token: 0x06014701 RID: 83713 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014701")]
		[Address(RVA = "0xCAF830", Offset = "0xCAE430", VA = "0x180CAF830")]
		private void Update()
		{
		}

		// Token: 0x06014702 RID: 83714 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014702")]
		[Address(RVA = "0xCAF8B0", Offset = "0xCAE4B0", VA = "0x180CAF8B0")]
		public AutoChessRefreshBehaviour()
		{
		}

		// Token: 0x06014703 RID: 83715 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014703")]
		[Address(RVA = "0xC99160", Offset = "0xC97D60", VA = "0x180C99160")]
		private void <>xLuaBaseProxy_OnPlay()
		{
		}

		// Token: 0x04018248 RID: 98888
		[Token(Token = "0x4018248")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool _isCastEffect;

		// Token: 0x04018249 RID: 98889
		[Token(Token = "0x4018249")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isSpecialEffect;

		// Token: 0x0401824A RID: 98890
		[Token(Token = "0x401824A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnPlay;

		// Token: 0x0401824B RID: 98891
		[Token(Token = "0x401824B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x0401824C RID: 98892
		[Token(Token = "0x401824C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
