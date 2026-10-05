using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x0200436D RID: 17261
	[Token(Token = "0x200436D")]
	public class SandboxV2RacerMedalDialog : UICompDialog<SandboxV2RacerMedalDialog.Options>, IHotfixable
	{
		// Token: 0x0601A7C3 RID: 108483 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A7C3")]
		[Address(RVA = "0x1395B40", Offset = "0x1394740", VA = "0x181395B40", Slot = "9")]
		protected override void OnInit()
		{
		}

		// Token: 0x0601A7C4 RID: 108484 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A7C4")]
		[Address(RVA = "0x1395BB0", Offset = "0x13947B0", VA = "0x181395BB0", Slot = "18")]
		protected override void OnRender(SandboxV2RacerMedalDialog.Options input)
		{
		}

		// Token: 0x0601A7C5 RID: 108485 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A7C5")]
		[Address(RVA = "0x1395A80", Offset = "0x1394680", VA = "0x181395A80")]
		public void EventOnBackClicked()
		{
		}

		// Token: 0x0601A7C6 RID: 108486 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A7C6")]
		[Address(RVA = "0x1395DF0", Offset = "0x13949F0", VA = "0x181395DF0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601A7C7 RID: 108487 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A7C7")]
		[Address(RVA = "0x1395FC0", Offset = "0x1394BC0", VA = "0x181395FC0")]
		public SandboxV2RacerMedalDialog()
		{
		}

		// Token: 0x0601A7C8 RID: 108488 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A7C8")]
		[Address(RVA = "0xE613C0", Offset = "0xE5FFC0", VA = "0x180E613C0")]
		private void <>xLuaBaseProxy_OnInit()
		{
		}

		// Token: 0x04021B56 RID: 138070
		[Token(Token = "0x4021B56")]
		private const int MEDAL_COUNT_PER_ROW = 5;

		// Token: 0x04021B57 RID: 138071
		[Token(Token = "0x4021B57")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private RectTransform _rectBack;

		// Token: 0x04021B58 RID: 138072
		[Token(Token = "0x4021B58")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private SimpleLayoutContent _content;

		// Token: 0x04021B59 RID: 138073
		[Token(Token = "0x4021B59")]
		[FieldOffset(Offset = "0x80")]
		private SandboxV2RacerMedalDialog.Adapter m_adapter;

		// Token: 0x04021B5A RID: 138074
		[Token(Token = "0x4021B5A")]
		[FieldOffset(Offset = "0x88")]
		private bool m_hasInited;

		// Token: 0x04021B5B RID: 138075
		[Token(Token = "0x4021B5B")]
		[FieldOffset(Offset = "0x90")]
		private List<List<SandboxV2RacerMedalModel>> m_medalList;

		// Token: 0x04021B5C RID: 138076
		[Token(Token = "0x4021B5C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x04021B5D RID: 138077
		[Token(Token = "0x4021B5D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x04021B5E RID: 138078
		[Token(Token = "0x4021B5E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_EventOnBackClicked;

		// Token: 0x04021B5F RID: 138079
		[Token(Token = "0x4021B5F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04021B60 RID: 138080
		[Token(Token = "0x4021B60")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200436E RID: 17262
		[Token(Token = "0x200436E")]
		public class Options
		{
			// Token: 0x0601A7C9 RID: 108489 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601A7C9")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Options()
			{
			}

			// Token: 0x04021B61 RID: 138081
			[Token(Token = "0x4021B61")]
			[FieldOffset(Offset = "0x10")]
			public List<SandboxV2RacerMedalModel> medalList;
		}

		// Token: 0x0200436F RID: 17263
		[Token(Token = "0x200436F")]
		private class Adapter : SimpleLayoutAdapter, IHotfixable
		{
			// Token: 0x0601A7CA RID: 108490 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601A7CA")]
			[Address(RVA = "0x13838A0", Offset = "0x13824A0", VA = "0x1813838A0")]
			public Adapter(SandboxV2RacerMedalDialog closure)
			{
			}

			// Token: 0x17003EE6 RID: 16102
			// (get) Token: 0x0601A7CB RID: 108491 RVA: 0x000A1F88 File Offset: 0x000A0188
			[Token(Token = "0x17003EE6")]
			public override int count
			{
				[Token(Token = "0x601A7CB")]
				[Address(RVA = "0x1383A90", Offset = "0x1382690", VA = "0x181383A90", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601A7CC RID: 108492 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601A7CC")]
			[Address(RVA = "0x13834F0", Offset = "0x13820F0", VA = "0x1813834F0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x04021B62 RID: 138082
			[Token(Token = "0x4021B62")]
			[FieldOffset(Offset = "0x20")]
			private SandboxV2RacerMedalDialog m_closure;

			// Token: 0x04021B63 RID: 138083
			[Token(Token = "0x4021B63")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04021B64 RID: 138084
			[Token(Token = "0x4021B64")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04021B65 RID: 138085
			[Token(Token = "0x4021B65")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
