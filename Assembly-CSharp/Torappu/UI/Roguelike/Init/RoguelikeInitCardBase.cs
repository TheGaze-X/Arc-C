using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike.Init
{
	// Token: 0x020057D4 RID: 22484
	[Token(Token = "0x20057D4")]
	public abstract class RoguelikeInitCardBase : MonoBehaviour, IHotfixable
	{
		// Token: 0x17004D26 RID: 19750
		// (get) Token: 0x06020E2B RID: 134699 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004D26")]
		protected AnimationWrapper animWrap
		{
			[Token(Token = "0x6020E2B")]
			[Address(RVA = "0x1B38620", Offset = "0x1B37220", VA = "0x181B38620")]
			get
			{
				return null;
			}
		}

		// Token: 0x06020E2C RID: 134700 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020E2C")]
		[Address(RVA = "0x1B381A0", Offset = "0x1B36DA0", VA = "0x181B381A0")]
		private void OnDisable()
		{
		}

		// Token: 0x06020E2D RID: 134701 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020E2D")]
		[Address(RVA = "0x1B38240", Offset = "0x1B36E40", VA = "0x181B38240")]
		public void PlayAnim_Born(float delay, [Optional] Action onComplete)
		{
		}

		// Token: 0x06020E2E RID: 134702 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020E2E")]
		[Address(RVA = "0x1B384A0", Offset = "0x1B370A0", VA = "0x181B384A0")]
		private void _PlayBorn()
		{
		}

		// Token: 0x06020E2F RID: 134703 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020E2F")]
		[Address(RVA = "0x1B38420", Offset = "0x1B37020", VA = "0x181B38420")]
		private void _NotifyEnd()
		{
		}

		// Token: 0x06020E30 RID: 134704 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020E30")]
		[Address(RVA = "0x1B385C0", Offset = "0x1B371C0", VA = "0x181B385C0")]
		protected RoguelikeInitCardBase()
		{
		}

		// Token: 0x0402CAF0 RID: 183024
		[Token(Token = "0x402CAF0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private AnimationWrapper _animWrap;

		// Token: 0x0402CAF1 RID: 183025
		[Token(Token = "0x402CAF1")]
		private const string ANIM_BORN = "init_card_born";

		// Token: 0x0402CAF2 RID: 183026
		[Token(Token = "0x402CAF2")]
		private const string FUNC_PLAY_BORN = "_PlayBorn";

		// Token: 0x0402CAF3 RID: 183027
		[Token(Token = "0x402CAF3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Action m_playEndCallback;

		// Token: 0x0402CAF4 RID: 183028
		[Token(Token = "0x402CAF4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_animWrap;

		// Token: 0x0402CAF5 RID: 183029
		[Token(Token = "0x402CAF5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnDisable;

		// Token: 0x0402CAF6 RID: 183030
		[Token(Token = "0x402CAF6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_PlayAnim_Born;

		// Token: 0x0402CAF7 RID: 183031
		[Token(Token = "0x402CAF7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__PlayBorn;

		// Token: 0x0402CAF8 RID: 183032
		[Token(Token = "0x402CAF8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__NotifyEnd;

		// Token: 0x0402CAF9 RID: 183033
		[Token(Token = "0x402CAF9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
