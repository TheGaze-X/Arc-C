using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Danmaku
{
	// Token: 0x020028AB RID: 10411
	[Token(Token = "0x20028AB")]
	public class Act3FunProjectileEnemy : FixedDirectionEnemy
	{
		// Token: 0x17002645 RID: 9797
		// (get) Token: 0x060114FD RID: 70909 RVA: 0x0006A980 File Offset: 0x00068B80
		[Token(Token = "0x17002645")]
		protected override int initState
		{
			[Token(Token = "0x60114FD")]
			[Address(RVA = "0x91BDD0", Offset = "0x91A9D0", VA = "0x18091BDD0", Slot = "68")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17002646 RID: 9798
		// (get) Token: 0x060114FE RID: 70910 RVA: 0x0006A998 File Offset: 0x00068B98
		[Token(Token = "0x17002646")]
		public override bool disableUIUnitHud
		{
			[Token(Token = "0x60114FE")]
			[Address(RVA = "0x91B9A0", Offset = "0x91A5A0", VA = "0x18091B9A0", Slot = "196")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17002647 RID: 9799
		// (get) Token: 0x060114FF RID: 70911 RVA: 0x0006A9B0 File Offset: 0x00068BB0
		[Token(Token = "0x17002647")]
		public override int preloadCnt
		{
			[Token(Token = "0x60114FF")]
			[Address(RVA = "0x91BE30", Offset = "0x91AA30", VA = "0x18091BE30", Slot = "208")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17002648 RID: 9800
		// (get) Token: 0x06011500 RID: 70912 RVA: 0x0006A9C8 File Offset: 0x00068BC8
		[Token(Token = "0x17002648")]
		public override FP hatred
		{
			[Token(Token = "0x6011500")]
			[Address(RVA = "0x91BC70", Offset = "0x91A870", VA = "0x18091BC70", Slot = "46")]
			get
			{
				return default(FP);
			}
		}

		// Token: 0x17002649 RID: 9801
		// (get) Token: 0x06011501 RID: 70913 RVA: 0x0006A9E0 File Offset: 0x00068BE0
		[Token(Token = "0x17002649")]
		public FP distToAircraft
		{
			[Token(Token = "0x6011501")]
			[Address(RVA = "0x91BA00", Offset = "0x91A600", VA = "0x18091BA00")]
			get
			{
				return default(FP);
			}
		}

		// Token: 0x06011502 RID: 70914 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011502")]
		[Address(RVA = "0x91B940", Offset = "0x91A540", VA = "0x18091B940")]
		public Act3FunProjectileEnemy()
		{
		}

		// Token: 0x06011503 RID: 70915 RVA: 0x0006A9F8 File Offset: 0x00068BF8
		[Token(Token = "0x6011503")]
		[Address(RVA = "0x91B920", Offset = "0x91A520", VA = "0x18091B920")]
		private int <>xLuaBaseProxy_get_initState()
		{
			return 0;
		}

		// Token: 0x06011504 RID: 70916 RVA: 0x0006AA10 File Offset: 0x00068C10
		[Token(Token = "0x6011504")]
		[Address(RVA = "0x6F2E20", Offset = "0x6F1A20", VA = "0x1806F2E20")]
		private bool <>xLuaBaseProxy_get_disableUIUnitHud()
		{
			return default(bool);
		}

		// Token: 0x06011505 RID: 70917 RVA: 0x0006AA28 File Offset: 0x00068C28
		[Token(Token = "0x6011505")]
		[Address(RVA = "0x91B930", Offset = "0x91A530", VA = "0x18091B930")]
		private int <>xLuaBaseProxy_get_preloadCnt()
		{
			return 0;
		}

		// Token: 0x06011506 RID: 70918 RVA: 0x0006AA40 File Offset: 0x00068C40
		[Token(Token = "0x6011506")]
		[Address(RVA = "0x91B910", Offset = "0x91A510", VA = "0x18091B910")]
		private FP <>xLuaBaseProxy_get_hatred()
		{
			return default(FP);
		}

		// Token: 0x0401357C RID: 79228
		[Token(Token = "0x401357C")]
		[FieldOffset(Offset = "0x530")]
		[SerializeField]
		private int _overridePreloadCnt;

		// Token: 0x0401357D RID: 79229
		[Token(Token = "0x401357D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_initState;

		// Token: 0x0401357E RID: 79230
		[Token(Token = "0x401357E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_disableUIUnitHud;

		// Token: 0x0401357F RID: 79231
		[Token(Token = "0x401357F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_preloadCnt;

		// Token: 0x04013580 RID: 79232
		[Token(Token = "0x4013580")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_hatred;

		// Token: 0x04013581 RID: 79233
		[Token(Token = "0x4013581")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_distToAircraft;

		// Token: 0x04013582 RID: 79234
		[Token(Token = "0x4013582")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
