using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.HandBook
{
	// Token: 0x02006660 RID: 26208
	[Token(Token = "0x2006660")]
	public class HandBookInfoStagePage : StateEnginePage
	{
		// Token: 0x1700592E RID: 22830
		// (get) Token: 0x06025A24 RID: 154148 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06025A25 RID: 154149 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700592E")]
		public HandBookJumpParam jumpParam
		{
			[Token(Token = "0x6025A24")]
			[Address(RVA = "0x2093EC0", Offset = "0x2092AC0", VA = "0x182093EC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6025A25")]
			[Address(RVA = "0x2093F80", Offset = "0x2092B80", VA = "0x182093F80")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700592F RID: 22831
		// (get) Token: 0x06025A26 RID: 154150 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700592F")]
		public HandBookInfoStageProperty property
		{
			[Token(Token = "0x6025A26")]
			[Address(RVA = "0x2093F20", Offset = "0x2092B20", VA = "0x182093F20")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005930 RID: 22832
		// (get) Token: 0x06025A27 RID: 154151 RVA: 0x000C89A0 File Offset: 0x000C6BA0
		[Token(Token = "0x17005930")]
		public bool isPlaying
		{
			[Token(Token = "0x6025A27")]
			[Address(RVA = "0x2093E50", Offset = "0x2092A50", VA = "0x182093E50")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06025A28 RID: 154152 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025A28")]
		[Address(RVA = "0x20938C0", Offset = "0x20924C0", VA = "0x1820938C0", Slot = "8")]
		protected override void OnCreate(DataBundle savedInst)
		{
		}

		// Token: 0x06025A29 RID: 154153 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6025A29")]
		[Address(RVA = "0x2093810", Offset = "0x2092410", VA = "0x182093810", Slot = "25")]
		protected override IEnumerator EffectsOnShow(bool isFromStack)
		{
			return null;
		}

		// Token: 0x06025A2A RID: 154154 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025A2A")]
		[Address(RVA = "0x2093C00", Offset = "0x2092800", VA = "0x182093C00")]
		private void _PlayEnterAnim()
		{
		}

		// Token: 0x06025A2B RID: 154155 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025A2B")]
		[Address(RVA = "0x2093D60", Offset = "0x2092960", VA = "0x182093D60")]
		public HandBookInfoStagePage()
		{
		}

		// Token: 0x06025A2C RID: 154156 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025A2C")]
		[Address(RVA = "0xE66190", Offset = "0xE64D90", VA = "0x180E66190")]
		private void <>xLuaBaseProxy_OnCreate(DataBundle P0)
		{
		}

		// Token: 0x06025A2D RID: 154157 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6025A2D")]
		[Address(RVA = "0x119B2F0", Offset = "0x1199EF0", VA = "0x18119B2F0")]
		private IEnumerator <>xLuaBaseProxy_EffectsOnShow(bool P0)
		{
			return null;
		}

		// Token: 0x04034DE2 RID: 216546
		[Token(Token = "0x4034DE2")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private UIAnimationLocation _enterAnim;

		// Token: 0x04034DE3 RID: 216547
		[Token(Token = "0x4034DE3")]
		[FieldOffset(Offset = "0x100")]
		private Tween m_enterAnim;

		// Token: 0x04034DE5 RID: 216549
		[Token(Token = "0x4034DE5")]
		[FieldOffset(Offset = "0x110")]
		private HandBookInfoStageProperty m_stageProperty;

		// Token: 0x04034DE6 RID: 216550
		[Token(Token = "0x4034DE6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_jumpParam;

		// Token: 0x04034DE7 RID: 216551
		[Token(Token = "0x4034DE7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_jumpParam;

		// Token: 0x04034DE8 RID: 216552
		[Token(Token = "0x4034DE8")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_property;

		// Token: 0x04034DE9 RID: 216553
		[Token(Token = "0x4034DE9")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_isPlaying;

		// Token: 0x04034DEA RID: 216554
		[Token(Token = "0x4034DEA")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnCreate;

		// Token: 0x04034DEB RID: 216555
		[Token(Token = "0x4034DEB")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_EffectsOnShow;

		// Token: 0x04034DEC RID: 216556
		[Token(Token = "0x4034DEC")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__PlayEnterAnim;

		// Token: 0x04034DED RID: 216557
		[Token(Token = "0x4034DED")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006661 RID: 26209
		[Token(Token = "0x2006661")]
		public class Params
		{
			// Token: 0x06025A2E RID: 154158 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6025A2E")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Params()
			{
			}

			// Token: 0x04034DEE RID: 216558
			[Token(Token = "0x4034DEE")]
			[FieldOffset(Offset = "0x10")]
			public HandBookStageViewModel stageViewModel;

			// Token: 0x04034DEF RID: 216559
			[Token(Token = "0x4034DEF")]
			[FieldOffset(Offset = "0x18")]
			public List<int> charList;
		}
	}
}
