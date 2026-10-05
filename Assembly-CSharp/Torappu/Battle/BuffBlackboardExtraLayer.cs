using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002104 RID: 8452
	[Token(Token = "0x2002104")]
	public class BuffBlackboardExtraLayer : SpineMixExtraLayer.LayerAnimPlayer
	{
		// Token: 0x0600CF29 RID: 53033 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CF29")]
		[Address(RVA = "0x35094F0", Offset = "0x35080F0", VA = "0x1835094F0", Slot = "5")]
		public override void Init(SpineMixExtraLayer layer, ObjectPtr<Unit> owner)
		{
		}

		// Token: 0x0600CF2A RID: 53034 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CF2A")]
		[Address(RVA = "0x35095B0", Offset = "0x35081B0", VA = "0x1835095B0", Slot = "4")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x0600CF2B RID: 53035 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CF2B")]
		[Address(RVA = "0x35099C0", Offset = "0x35085C0", VA = "0x1835099C0")]
		private void _TryUpdateNewAnimConfig(Unit ownerObj)
		{
		}

		// Token: 0x0600CF2C RID: 53036 RVA: 0x0004ACE8 File Offset: 0x00048EE8
		[Token(Token = "0x600CF2C")]
		[Address(RVA = "0x3509880", Offset = "0x3508480", VA = "0x183509880")]
		private bool _KeepOldAnimState()
		{
			return default(bool);
		}

		// Token: 0x0600CF2D RID: 53037 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CF2D")]
		[Address(RVA = "0x3509C40", Offset = "0x3508840", VA = "0x183509C40")]
		public BuffBlackboardExtraLayer()
		{
		}

		// Token: 0x0600CF2E RID: 53038 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CF2E")]
		[Address(RVA = "0x3509850", Offset = "0x3508450", VA = "0x183509850")]
		private void <>xLuaBaseProxy_Init(SpineMixExtraLayer P0, ObjectPtr<Unit> P1)
		{
		}

		// Token: 0x0600CF2F RID: 53039 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CF2F")]
		[Address(RVA = "0x3509870", Offset = "0x3508470", VA = "0x183509870")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x0400DCEF RID: 56559
		[Token(Token = "0x400DCEF")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private List<BuffBlackboardExtraLayer.AnimConfig> _animConfigs;

		// Token: 0x0400DCF0 RID: 56560
		[Token(Token = "0x400DCF0")]
		[FieldOffset(Offset = "0x58")]
		private ObjectPtr<Buff> m_lastBuff;

		// Token: 0x0400DCF1 RID: 56561
		[Token(Token = "0x400DCF1")]
		[FieldOffset(Offset = "0x68")]
		private BuffBlackboardExtraLayer.AnimConfig m_lastConfig;

		// Token: 0x0400DCF2 RID: 56562
		[Token(Token = "0x400DCF2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0400DCF3 RID: 56563
		[Token(Token = "0x400DCF3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x0400DCF4 RID: 56564
		[Token(Token = "0x400DCF4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__TryUpdateNewAnimConfig;

		// Token: 0x0400DCF5 RID: 56565
		[Token(Token = "0x400DCF5")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__KeepOldAnimState;

		// Token: 0x0400DCF6 RID: 56566
		[Token(Token = "0x400DCF6")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02002105 RID: 8453
		[Token(Token = "0x2002105")]
		[Serializable]
		public class AnimConfig
		{
			// Token: 0x1700189A RID: 6298
			// (get) Token: 0x0600CF30 RID: 53040 RVA: 0x0004AD00 File Offset: 0x00048F00
			[Token(Token = "0x1700189A")]
			public bool needUpdateAlpha
			{
				[Token(Token = "0x600CF30")]
				[Address(RVA = "0x20086A0", Offset = "0x20072A0", VA = "0x1820086A0")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x0600CF31 RID: 53041 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600CF31")]
			[Address(RVA = "0x3509420", Offset = "0x3508020", VA = "0x183509420")]
			public AnimConfig()
			{
			}

			// Token: 0x0400DCF7 RID: 56567
			[Token(Token = "0x400DCF7")]
			[FieldOffset(Offset = "0x10")]
			public string buff;

			// Token: 0x0400DCF8 RID: 56568
			[Token(Token = "0x400DCF8")]
			[FieldOffset(Offset = "0x18")]
			public string alphaBlackboardKey;

			// Token: 0x0400DCF9 RID: 56569
			[Token(Token = "0x400DCF9")]
			[FieldOffset(Offset = "0x20")]
			public string animKey;

			// Token: 0x0400DCFA RID: 56570
			[Token(Token = "0x400DCFA")]
			[FieldOffset(Offset = "0x28")]
			public bool isLoop;

			// Token: 0x0400DCFB RID: 56571
			[Token(Token = "0x400DCFB")]
			[FieldOffset(Offset = "0x29")]
			public bool checkUpdateNextAnim;
		}
	}
}
