using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.TemplateMission
{
	// Token: 0x02003D98 RID: 15768
	[Token(Token = "0x2003D98")]
	public class TemplateMissionCommonTitleView : TemplateMissionTitleView
	{
		// Token: 0x06018868 RID: 100456 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018868")]
		[Address(RVA = "0x110F9A0", Offset = "0x110E5A0", VA = "0x18110F9A0", Slot = "8")]
		public override void Init(AbstractTemplateMissionViewController ctrl_, TemplateMissionCustomResHolder customResHolder_)
		{
		}

		// Token: 0x06018869 RID: 100457 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018869")]
		[Address(RVA = "0x110FA50", Offset = "0x110E650", VA = "0x18110FA50", Slot = "9")]
		protected override void RenderView()
		{
		}

		// Token: 0x0601886A RID: 100458 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601886A")]
		[Address(RVA = "0x110FBE0", Offset = "0x110E7E0", VA = "0x18110FBE0")]
		public TemplateMissionCommonTitleView()
		{
		}

		// Token: 0x0601886B RID: 100459 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601886B")]
		[Address(RVA = "0x1109AC0", Offset = "0x11086C0", VA = "0x181109AC0")]
		private void <>xLuaBaseProxy_Init(AbstractTemplateMissionViewController P0, TemplateMissionCustomResHolder P1)
		{
		}

		// Token: 0x0401E11B RID: 123163
		[Token(Token = "0x401E11B")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Image _imgTitle;

		// Token: 0x0401E11C RID: 123164
		[Token(Token = "0x401E11C")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private TemplateMissionCommonEntryFadeTween _entryFadeTween;

		// Token: 0x0401E11D RID: 123165
		[Token(Token = "0x401E11D")]
		[FieldOffset(Offset = "0x50")]
		private bool m_isRendered;

		// Token: 0x0401E11E RID: 123166
		[Token(Token = "0x401E11E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0401E11F RID: 123167
		[Token(Token = "0x401E11F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RenderView;

		// Token: 0x0401E120 RID: 123168
		[Token(Token = "0x401E120")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
