using System;
using Il2CppDummyDll;
using Torappu.Activity;
using Torappu.UI.Stage;
using XLua;

namespace Torappu.UI.SiracusaMap
{
	// Token: 0x02003F5D RID: 16221
	[Token(Token = "0x2003F5D")]
	public class SiracusaMapRoutePolicy : CustomActivityStageRoutePolicy<SiracusaMapPage.Param>
	{
		// Token: 0x060192FD RID: 103165 RVA: 0x0009D320 File Offset: 0x0009B520
		[Token(Token = "0x60192FD")]
		[Address(RVA = "0x11F2F60", Offset = "0x11F1B60", VA = "0x1811F2F60", Slot = "12")]
		protected override ActivityType GetActType()
		{
			return ActivityType.DEFAULT;
		}

		// Token: 0x17003C31 RID: 15409
		// (get) Token: 0x060192FE RID: 103166 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003C31")]
		protected override string pageName
		{
			[Token(Token = "0x60192FE")]
			[Address(RVA = "0x11F30E0", Offset = "0x11F1CE0", VA = "0x1811F30E0", Slot = "13")]
			get
			{
				return null;
			}
		}

		// Token: 0x060192FF RID: 103167 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60192FF")]
		[Address(RVA = "0x11F2D70", Offset = "0x11F1970", VA = "0x1811F2D70", Slot = "14")]
		protected override SiracusaMapPage.Param CreateParamFromStage(ActivityStageRoutePolicy.ActRouteTarget input)
		{
			return null;
		}

		// Token: 0x06019300 RID: 103168 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6019300")]
		[Address(RVA = "0x11F2C50", Offset = "0x11F1850", VA = "0x1811F2C50", Slot = "15")]
		protected override SiracusaMapPage.Param CreateParamFromDataBundle(RoutePolicy.BattleOutRouteInput input)
		{
			return null;
		}

		// Token: 0x06019301 RID: 103169 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6019301")]
		[Address(RVA = "0x11F2FC0", Offset = "0x11F1BC0", VA = "0x1811F2FC0")]
		private string _TryGetNormalStageId(string stageId)
		{
			return null;
		}

		// Token: 0x06019302 RID: 103170 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019302")]
		[Address(RVA = "0x11F3070", Offset = "0x11F1C70", VA = "0x1811F3070")]
		public SiracusaMapRoutePolicy()
		{
		}

		// Token: 0x0401F3AB RID: 127915
		[Token(Token = "0x401F3AB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetActType;

		// Token: 0x0401F3AC RID: 127916
		[Token(Token = "0x401F3AC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_pageName;

		// Token: 0x0401F3AD RID: 127917
		[Token(Token = "0x401F3AD")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_CreateParamFromStage;

		// Token: 0x0401F3AE RID: 127918
		[Token(Token = "0x401F3AE")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_CreateParamFromDataBundle;

		// Token: 0x0401F3AF RID: 127919
		[Token(Token = "0x401F3AF")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__TryGetNormalStageId;

		// Token: 0x0401F3B0 RID: 127920
		[Token(Token = "0x401F3B0")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
