using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act5D1
{
	// Token: 0x02007237 RID: 29239
	[Token(Token = "0x2007237")]
	public class Act5D1RuneStageDetailContainer : MonoBehaviour, IHotfixable
	{
		// Token: 0x060296F2 RID: 169714 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60296F2")]
		[Address(RVA = "0x24CB820", Offset = "0x24CA420", VA = "0x1824CB820")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060296F3 RID: 169715 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60296F3")]
		[Address(RVA = "0x24CBAB0", Offset = "0x24CA6B0", VA = "0x1824CBAB0")]
		private void _Render(string runeReId, List<RuneInfo> runeList)
		{
		}

		// Token: 0x060296F4 RID: 169716 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60296F4")]
		[Address(RVA = "0x24CBA20", Offset = "0x24CA620", VA = "0x1824CBA20")]
		private void _RenderWarningInfo(bool isWarning)
		{
		}

		// Token: 0x060296F5 RID: 169717 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60296F5")]
		[Address(RVA = "0x24CB720", Offset = "0x24CA320", VA = "0x1824CB720")]
		public void Render(string runeReId, List<RuneInfo> runeInfo, bool isWarning)
		{
		}

		// Token: 0x060296F6 RID: 169718 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60296F6")]
		[Address(RVA = "0x24CBD20", Offset = "0x24CA920", VA = "0x1824CBD20")]
		public Act5D1RuneStageDetailContainer()
		{
		}

		// Token: 0x0403B312 RID: 242450
		[Token(Token = "0x403B312")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Act5D1RuneStageDetailText _detailText;

		// Token: 0x0403B313 RID: 242451
		[Token(Token = "0x403B313")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SimpleLayoutContent _container;

		// Token: 0x0403B314 RID: 242452
		[Token(Token = "0x403B314")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private CanvasGroup _newHandObj;

		// Token: 0x0403B315 RID: 242453
		[Token(Token = "0x403B315")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private CanvasGroup _warningObj;

		// Token: 0x0403B316 RID: 242454
		[Token(Token = "0x403B316")]
		[FieldOffset(Offset = "0x38")]
		private string m_cacheRuneReId;

		// Token: 0x0403B317 RID: 242455
		[Token(Token = "0x403B317")]
		[FieldOffset(Offset = "0x40")]
		private bool m_isInited;

		// Token: 0x0403B318 RID: 242456
		[Token(Token = "0x403B318")]
		[FieldOffset(Offset = "0x48")]
		private FadeSwitchTween m_newHandSwitch;

		// Token: 0x0403B319 RID: 242457
		[Token(Token = "0x403B319")]
		[FieldOffset(Offset = "0x50")]
		private FadeSwitchTween m_warningSwitch;

		// Token: 0x0403B31A RID: 242458
		[Token(Token = "0x403B31A")]
		[FieldOffset(Offset = "0x58")]
		private Act5D1RuneStageDetailContainer.DetailAdapter m_detailAdapter;

		// Token: 0x0403B31B RID: 242459
		[Token(Token = "0x403B31B")]
		[FieldOffset(Offset = "0x60")]
		private List<RuneInfo> m_displayRuneList;

		// Token: 0x0403B31C RID: 242460
		[Token(Token = "0x403B31C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403B31D RID: 242461
		[Token(Token = "0x403B31D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__Render;

		// Token: 0x0403B31E RID: 242462
		[Token(Token = "0x403B31E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__RenderWarningInfo;

		// Token: 0x0403B31F RID: 242463
		[Token(Token = "0x403B31F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403B320 RID: 242464
		[Token(Token = "0x403B320")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02007238 RID: 29240
		[Token(Token = "0x2007238")]
		private class DetailAdapter : SimpleLayoutAdapter
		{
			// Token: 0x060296F7 RID: 169719 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60296F7")]
			[Address(RVA = "0x24D46D0", Offset = "0x24D32D0", VA = "0x1824D46D0")]
			public DetailAdapter(Act5D1RuneStageDetailContainer context)
			{
			}

			// Token: 0x17006224 RID: 25124
			// (get) Token: 0x060296F8 RID: 169720 RVA: 0x000D5AC8 File Offset: 0x000D3CC8
			[Token(Token = "0x17006224")]
			public override int count
			{
				[Token(Token = "0x60296F8")]
				[Address(RVA = "0x24D4750", Offset = "0x24D3350", VA = "0x1824D4750", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x060296F9 RID: 169721 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60296F9")]
			[Address(RVA = "0x24D4510", Offset = "0x24D3110", VA = "0x1824D4510", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0403B321 RID: 242465
			[Token(Token = "0x403B321")]
			[FieldOffset(Offset = "0x20")]
			private Act5D1RuneStageDetailContainer m_context;

			// Token: 0x0403B322 RID: 242466
			[Token(Token = "0x403B322")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0403B323 RID: 242467
			[Token(Token = "0x403B323")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0403B324 RID: 242468
			[Token(Token = "0x403B324")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
