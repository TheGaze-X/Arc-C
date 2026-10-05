using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI.Common;
using UnityEngine;
using XLua;

namespace Torappu.UI.FifthAnnivMainline
{
	// Token: 0x02004E93 RID: 20115
	[Token(Token = "0x2004E93")]
	public class FifthAnnivExploreCarouselGroup : MonoBehaviour, IHotfixable
	{
		// Token: 0x17004667 RID: 18023
		// (get) Token: 0x0601E032 RID: 122930 RVA: 0x000AD2C8 File Offset: 0x000AB4C8
		// (set) Token: 0x0601E033 RID: 122931 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004667")]
		public bool hasAvailRender
		{
			[Token(Token = "0x601E032")]
			[Address(RVA = "0x17B3970", Offset = "0x17B2570", VA = "0x1817B3970")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x601E033")]
			[Address(RVA = "0x17B39D0", Offset = "0x17B25D0", VA = "0x1817B39D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0601E034 RID: 122932 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E034")]
		[Address(RVA = "0x17B3750", Offset = "0x17B2350", VA = "0x1817B3750")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601E035 RID: 122933 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E035")]
		[Address(RVA = "0x17B3250", Offset = "0x17B1E50", VA = "0x1817B3250")]
		public void Refresh()
		{
		}

		// Token: 0x0601E036 RID: 122934 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E036")]
		[Address(RVA = "0x17B3900", Offset = "0x17B2500", VA = "0x1817B3900")]
		public FifthAnnivExploreCarouselGroup()
		{
		}

		// Token: 0x04027E45 RID: 163397
		[Token(Token = "0x4027E45")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private FifthAnnivExploreCarouselItem _item;

		// Token: 0x04027E46 RID: 163398
		[Token(Token = "0x4027E46")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UICommonCarousel _group;

		// Token: 0x04027E47 RID: 163399
		[Token(Token = "0x4027E47")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _speed;

		// Token: 0x04027E48 RID: 163400
		[Token(Token = "0x4027E48")]
		[FieldOffset(Offset = "0x30")]
		private FifthAnnivExploreCarouselViewModel m_viewModel;

		// Token: 0x04027E49 RID: 163401
		[Token(Token = "0x4027E49")]
		[FieldOffset(Offset = "0x38")]
		private List<FifthAnnivExploreCarouselItem> m_itemList;

		// Token: 0x04027E4A RID: 163402
		[Token(Token = "0x4027E4A")]
		[FieldOffset(Offset = "0x40")]
		private bool m_isInited;

		// Token: 0x04027E4B RID: 163403
		[Token(Token = "0x4027E4B")]
		public const int MAX_COUNT = 3;

		// Token: 0x04027E4D RID: 163405
		[Token(Token = "0x4027E4D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_hasAvailRender;

		// Token: 0x04027E4E RID: 163406
		[Token(Token = "0x4027E4E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_hasAvailRender;

		// Token: 0x04027E4F RID: 163407
		[Token(Token = "0x4027E4F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04027E50 RID: 163408
		[Token(Token = "0x4027E50")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Refresh;

		// Token: 0x04027E51 RID: 163409
		[Token(Token = "0x4027E51")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
