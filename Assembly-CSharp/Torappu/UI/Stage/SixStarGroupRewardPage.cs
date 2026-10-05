using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x0200681F RID: 26655
	[Token(Token = "0x200681F")]
	public class SixStarGroupRewardPage : StateEnginePage, IFadeInPushWithBlurBkg, IHotfixable
	{
		// Token: 0x17005A47 RID: 23111
		// (get) Token: 0x060262EF RID: 156399 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005A47")]
		public List<StageViewModel> stageModelList
		{
			[Token(Token = "0x60262EF")]
			[Address(RVA = "0x2138910", Offset = "0x2137510", VA = "0x182138910")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005A48 RID: 23112
		// (get) Token: 0x060262F0 RID: 156400 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005A48")]
		public string selectStageId
		{
			[Token(Token = "0x60262F0")]
			[Address(RVA = "0x21388B0", Offset = "0x21374B0", VA = "0x1821388B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x060262F1 RID: 156401 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60262F1")]
		[Address(RVA = "0x21386B0", Offset = "0x21372B0", VA = "0x1821386B0", Slot = "8")]
		protected override void OnCreate(DataBundle savedInst)
		{
		}

		// Token: 0x060262F2 RID: 156402 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60262F2")]
		[Address(RVA = "0x2138650", Offset = "0x2137250", VA = "0x182138650", Slot = "29")]
		public UIRenderTextureImage GetBlurBkg()
		{
			return null;
		}

		// Token: 0x060262F3 RID: 156403 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60262F3")]
		[Address(RVA = "0x21387F0", Offset = "0x21373F0", VA = "0x1821387F0")]
		public SixStarGroupRewardPage()
		{
		}

		// Token: 0x060262F4 RID: 156404 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60262F4")]
		[Address(RVA = "0xE66190", Offset = "0xE64D90", VA = "0x180E66190")]
		private void <>xLuaBaseProxy_OnCreate(DataBundle P0)
		{
		}

		// Token: 0x04035CC1 RID: 220353
		[Token(Token = "0x4035CC1")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private UIRenderTextureImage _imgBlurBkg;

		// Token: 0x04035CC2 RID: 220354
		[Token(Token = "0x4035CC2")]
		[FieldOffset(Offset = "0xF8")]
		private List<StageViewModel> m_stageModelList;

		// Token: 0x04035CC3 RID: 220355
		[Token(Token = "0x4035CC3")]
		[FieldOffset(Offset = "0x100")]
		private string m_selectStageId;

		// Token: 0x04035CC4 RID: 220356
		[Token(Token = "0x4035CC4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_stageModelList;

		// Token: 0x04035CC5 RID: 220357
		[Token(Token = "0x4035CC5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_selectStageId;

		// Token: 0x04035CC6 RID: 220358
		[Token(Token = "0x4035CC6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnCreate;

		// Token: 0x04035CC7 RID: 220359
		[Token(Token = "0x4035CC7")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetBlurBkg;

		// Token: 0x04035CC8 RID: 220360
		[Token(Token = "0x4035CC8")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006820 RID: 26656
		[Token(Token = "0x2006820")]
		public class Param
		{
			// Token: 0x060262F5 RID: 156405 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60262F5")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Param()
			{
			}

			// Token: 0x04035CC9 RID: 220361
			[Token(Token = "0x4035CC9")]
			[FieldOffset(Offset = "0x10")]
			public StageViewModel normalStageModel;

			// Token: 0x04035CCA RID: 220362
			[Token(Token = "0x4035CCA")]
			[FieldOffset(Offset = "0x18")]
			public StageViewModel sixStarStageModel;

			// Token: 0x04035CCB RID: 220363
			[Token(Token = "0x4035CCB")]
			[FieldOffset(Offset = "0x20")]
			public string selectStageId;
		}
	}
}
