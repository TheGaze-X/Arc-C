using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI.ActivityStage;
using UnityEngine;
using XLua;

namespace Torappu.UI.ActivityPage
{
	// Token: 0x02006773 RID: 26483
	[Token(Token = "0x2006773")]
	public class ActivityEntryPageComponentHolder : PageSingleComponent
	{
		// Token: 0x06025FE0 RID: 155616 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025FE0")]
		[Address(RVA = "0x20EA870", Offset = "0x20E9470", VA = "0x1820EA870", Slot = "5")]
		protected override void OnCreate()
		{
		}

		// Token: 0x06025FE1 RID: 155617 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025FE1")]
		[Address(RVA = "0x20EA9A0", Offset = "0x20E95A0", VA = "0x1820EA9A0", Slot = "11")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x06025FE2 RID: 155618 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025FE2")]
		[Address(RVA = "0x20EAA10", Offset = "0x20E9610", VA = "0x1820EAA10")]
		private void _BindPlugins()
		{
		}

		// Token: 0x06025FE3 RID: 155619 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025FE3")]
		[Address(RVA = "0x20EAC70", Offset = "0x20E9870", VA = "0x1820EAC70")]
		private void _UnBindPlugins()
		{
		}

		// Token: 0x06025FE4 RID: 155620 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025FE4")]
		[Address(RVA = "0x20EAE90", Offset = "0x20E9A90", VA = "0x1820EAE90")]
		public ActivityEntryPageComponentHolder()
		{
		}

		// Token: 0x06025FE5 RID: 155621 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025FE5")]
		[Address(RVA = "0xEE5F30", Offset = "0xEE4B30", VA = "0x180EE5F30")]
		private void <>xLuaBaseProxy_OnCreate()
		{
		}

		// Token: 0x06025FE6 RID: 155622 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025FE6")]
		[Address(RVA = "0xEDDC40", Offset = "0xEDC840", VA = "0x180EDDC40")]
		private void <>xLuaBaseProxy_OnDestroy()
		{
		}

		// Token: 0x04035748 RID: 218952
		[Token(Token = "0x4035748")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<TemplateActivityCommonPlugin> _pluginList;

		// Token: 0x04035749 RID: 218953
		[Token(Token = "0x4035749")]
		[FieldOffset(Offset = "0x28")]
		protected ActivityEntryPage m_page;

		// Token: 0x0403574A RID: 218954
		[Token(Token = "0x403574A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnCreate;

		// Token: 0x0403574B RID: 218955
		[Token(Token = "0x403574B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0403574C RID: 218956
		[Token(Token = "0x403574C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__BindPlugins;

		// Token: 0x0403574D RID: 218957
		[Token(Token = "0x403574D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__UnBindPlugins;

		// Token: 0x0403574E RID: 218958
		[Token(Token = "0x403574E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
