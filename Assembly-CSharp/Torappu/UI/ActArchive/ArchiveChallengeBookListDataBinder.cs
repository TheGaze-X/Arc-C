using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006B2B RID: 27435
	[Token(Token = "0x2006B2B")]
	public class ArchiveChallengeBookListDataBinder : DataBinder<ChallengeBookProperty>
	{
		// Token: 0x17005CAB RID: 23723
		// (get) Token: 0x06027379 RID: 160633 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602737A RID: 160634 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005CAB")]
		public ArchiveChallengeBookController controller
		{
			[Token(Token = "0x6027379")]
			[Address(RVA = "0x2266CD0", Offset = "0x22658D0", VA = "0x182266CD0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x602737A")]
			[Address(RVA = "0x2266D30", Offset = "0x2265930", VA = "0x182266D30")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0602737B RID: 160635 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602737B")]
		[Address(RVA = "0x2266540", Offset = "0x2265140", VA = "0x182266540", Slot = "7")]
		public override void OnValueChanged(ChallengeBookProperty property)
		{
		}

		// Token: 0x0602737C RID: 160636 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602737C")]
		[Address(RVA = "0x22669F0", Offset = "0x22655F0", VA = "0x1822669F0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602737D RID: 160637 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602737D")]
		[Address(RVA = "0x2266B10", Offset = "0x2265710", VA = "0x182266B10")]
		private string _LoadTextContent(string textId)
		{
			return null;
		}

		// Token: 0x0602737E RID: 160638 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602737E")]
		[Address(RVA = "0x2266C60", Offset = "0x2265860", VA = "0x182266C60")]
		public ArchiveChallengeBookListDataBinder()
		{
		}

		// Token: 0x040377C8 RID: 227272
		[Token(Token = "0x40377C8")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _storyNameText;

		// Token: 0x040377C9 RID: 227273
		[Token(Token = "0x40377C9")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _storyContentText;

		// Token: 0x040377CA RID: 227274
		[Token(Token = "0x40377CA")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private ScrollRect _storyContentScrollRect;

		// Token: 0x040377CB RID: 227275
		[Token(Token = "0x40377CB")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private SimpleLayoutContent _itemContent;

		// Token: 0x040377CC RID: 227276
		[Token(Token = "0x40377CC")]
		[FieldOffset(Offset = "0x40")]
		private bool m_hasInited;

		// Token: 0x040377CD RID: 227277
		[Token(Token = "0x40377CD")]
		[FieldOffset(Offset = "0x48")]
		private ArchiveChallengeBookListDataBinder.Adapter m_adapter;

		// Token: 0x040377CE RID: 227278
		[Token(Token = "0x40377CE")]
		[FieldOffset(Offset = "0x50")]
		private List<ChallengeBookItemModel> m_cachedItems;

		// Token: 0x040377CF RID: 227279
		[Token(Token = "0x40377CF")]
		[FieldOffset(Offset = "0x58")]
		private bool m_cachedShowTween;

		// Token: 0x040377D0 RID: 227280
		[Token(Token = "0x40377D0")]
		[FieldOffset(Offset = "0x60")]
		private ChallengeBookItemModel m_cachedSelectedItem;

		// Token: 0x040377D2 RID: 227282
		[Token(Token = "0x40377D2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_controller;

		// Token: 0x040377D3 RID: 227283
		[Token(Token = "0x40377D3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_controller;

		// Token: 0x040377D4 RID: 227284
		[Token(Token = "0x40377D4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x040377D5 RID: 227285
		[Token(Token = "0x40377D5")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040377D6 RID: 227286
		[Token(Token = "0x40377D6")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__LoadTextContent;

		// Token: 0x040377D7 RID: 227287
		[Token(Token = "0x40377D7")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006B2C RID: 27436
		[Token(Token = "0x2006B2C")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x17005CAC RID: 23724
			// (get) Token: 0x0602737F RID: 160639 RVA: 0x000CDB48 File Offset: 0x000CBD48
			[Token(Token = "0x17005CAC")]
			public override int count
			{
				[Token(Token = "0x602737F")]
				[Address(RVA = "0x2262760", Offset = "0x2261360", VA = "0x182262760", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06027380 RID: 160640 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6027380")]
			[Address(RVA = "0x2262470", Offset = "0x2261070", VA = "0x182262470")]
			public Adapter(ArchiveChallengeBookListDataBinder closure)
			{
			}

			// Token: 0x06027381 RID: 160641 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6027381")]
			[Address(RVA = "0x2261B20", Offset = "0x2260720", VA = "0x182261B20", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x040377D8 RID: 227288
			[Token(Token = "0x40377D8")]
			[FieldOffset(Offset = "0x20")]
			private ArchiveChallengeBookListDataBinder m_closure;

			// Token: 0x040377D9 RID: 227289
			[Token(Token = "0x40377D9")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x040377DA RID: 227290
			[Token(Token = "0x40377DA")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x040377DB RID: 227291
			[Token(Token = "0x40377DB")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
