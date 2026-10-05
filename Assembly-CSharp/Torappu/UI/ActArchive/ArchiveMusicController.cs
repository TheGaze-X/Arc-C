using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006BAF RID: 27567
	[Token(Token = "0x2006BAF")]
	public class ArchiveMusicController : ActArchiveController
	{
		// Token: 0x060275D8 RID: 161240 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60275D8")]
		[Address(RVA = "0x2292100", Offset = "0x2290D00", VA = "0x182292100", Slot = "9")]
		public override void OnItemClick(string funcId)
		{
		}

		// Token: 0x060275D9 RID: 161241 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60275D9")]
		[Address(RVA = "0x22921A0", Offset = "0x2290DA0", VA = "0x1822921A0")]
		public void OnSetHomeTheme()
		{
		}

		// Token: 0x060275DA RID: 161242 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60275DA")]
		[Address(RVA = "0x2291AE0", Offset = "0x22906E0", VA = "0x182291AE0")]
		public List<DataBinder<MusicProperty>> InitAndAchieveDataBinders()
		{
			return null;
		}

		// Token: 0x060275DB RID: 161243 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60275DB")]
		[Address(RVA = "0x2291C10", Offset = "0x2290810", VA = "0x182291C10", Slot = "4")]
		public override void Init(ActArchiveProxy proxy)
		{
		}

		// Token: 0x060275DC RID: 161244 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60275DC")]
		[Address(RVA = "0x2292000", Offset = "0x2290C00", VA = "0x182292000", Slot = "5")]
		public override void OnEnter()
		{
		}

		// Token: 0x060275DD RID: 161245 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60275DD")]
		[Address(RVA = "0x2292080", Offset = "0x2290C80", VA = "0x182292080", Slot = "6")]
		public override void OnExit()
		{
		}

		// Token: 0x060275DE RID: 161246 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60275DE")]
		[Address(RVA = "0x2292210", Offset = "0x2290E10", VA = "0x182292210", Slot = "7")]
		public override IEnumerator Show(bool fastMode)
		{
			return null;
		}

		// Token: 0x060275DF RID: 161247 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60275DF")]
		[Address(RVA = "0x22922D0", Offset = "0x2290ED0", VA = "0x1822922D0")]
		public ArchiveMusicController()
		{
		}

		// Token: 0x060275E0 RID: 161248 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60275E0")]
		[Address(RVA = "0x2263DC0", Offset = "0x22629C0", VA = "0x182263DC0")]
		private void <>xLuaBaseProxy_OnItemClick(string P0)
		{
		}

		// Token: 0x060275E1 RID: 161249 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60275E1")]
		[Address(RVA = "0x2252DF0", Offset = "0x22519F0", VA = "0x182252DF0")]
		private void <>xLuaBaseProxy_Init(ActArchiveProxy P0)
		{
		}

		// Token: 0x060275E2 RID: 161250 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60275E2")]
		[Address(RVA = "0x2252E00", Offset = "0x2251A00", VA = "0x182252E00")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x060275E3 RID: 161251 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60275E3")]
		[Address(RVA = "0x2252E10", Offset = "0x2251A10", VA = "0x182252E10")]
		private void <>xLuaBaseProxy_OnExit()
		{
		}

		// Token: 0x060275E4 RID: 161252 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60275E4")]
		[Address(RVA = "0x227CC90", Offset = "0x227B890", VA = "0x18227CC90")]
		private IEnumerator <>xLuaBaseProxy_Show(bool P0)
		{
			return null;
		}

		// Token: 0x04037C50 RID: 228432
		[Token(Token = "0x4037C50")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private ArchiveMusicListDataBinder _musicListBinder;

		// Token: 0x04037C51 RID: 228433
		[Token(Token = "0x4037C51")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Image _imgBkg;

		// Token: 0x04037C52 RID: 228434
		[Token(Token = "0x4037C52")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Image _imgTitle;

		// Token: 0x04037C53 RID: 228435
		[Token(Token = "0x4037C53")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Image _cdLeft;

		// Token: 0x04037C54 RID: 228436
		[Token(Token = "0x4037C54")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Image _cdLeftLogo;

		// Token: 0x04037C55 RID: 228437
		[Token(Token = "0x4037C55")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Image _cdRight;

		// Token: 0x04037C56 RID: 228438
		[Token(Token = "0x4037C56")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Image _cdRightLogo;

		// Token: 0x04037C57 RID: 228439
		[Token(Token = "0x4037C57")]
		[FieldOffset(Offset = "0x70")]
		[NonSerialized]
		public Action<ActArchiveType, string> onMusicItemClicked;

		// Token: 0x04037C58 RID: 228440
		[Token(Token = "0x4037C58")]
		[FieldOffset(Offset = "0x78")]
		[NonSerialized]
		public Action onSetHomeTheme;

		// Token: 0x04037C59 RID: 228441
		[Token(Token = "0x4037C59")]
		[FieldOffset(Offset = "0x80")]
		private ArchiveMusicController.Handler m_handler;

		// Token: 0x04037C5A RID: 228442
		[Token(Token = "0x4037C5A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnItemClick;

		// Token: 0x04037C5B RID: 228443
		[Token(Token = "0x4037C5B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnSetHomeTheme;

		// Token: 0x04037C5C RID: 228444
		[Token(Token = "0x4037C5C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_InitAndAchieveDataBinders;

		// Token: 0x04037C5D RID: 228445
		[Token(Token = "0x4037C5D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04037C5E RID: 228446
		[Token(Token = "0x4037C5E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04037C5F RID: 228447
		[Token(Token = "0x4037C5F")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnExit;

		// Token: 0x04037C60 RID: 228448
		[Token(Token = "0x4037C60")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_Show;

		// Token: 0x04037C61 RID: 228449
		[Token(Token = "0x4037C61")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006BB0 RID: 27568
		[Token(Token = "0x2006BB0")]
		private class Handler : ArchiveMusicControllerHandler
		{
			// Token: 0x060275E5 RID: 161253 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60275E5")]
			[Address(RVA = "0x22A2170", Offset = "0x22A0D70", VA = "0x1822A2170")]
			public Handler(ArchiveMusicController closure)
			{
			}

			// Token: 0x060275E6 RID: 161254 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60275E6")]
			[Address(RVA = "0x22A1D70", Offset = "0x22A0970", VA = "0x1822A1D70", Slot = "4")]
			public override void OnItemClick(string funcId)
			{
			}

			// Token: 0x04037C62 RID: 228450
			[Token(Token = "0x4037C62")]
			[FieldOffset(Offset = "0x10")]
			private ArchiveMusicController m_closure;

			// Token: 0x04037C63 RID: 228451
			[Token(Token = "0x4037C63")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04037C64 RID: 228452
			[Token(Token = "0x4037C64")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OnItemClick;
		}
	}
}
