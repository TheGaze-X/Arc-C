using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006B88 RID: 27528
	[Token(Token = "0x2006B88")]
	public class ArchiveFragmentInfoView : DataBinder<FragmentProperty>, IHotfixable
	{
		// Token: 0x06027537 RID: 161079 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027537")]
		[Address(RVA = "0x22818D0", Offset = "0x22804D0", VA = "0x1822818D0", Slot = "7")]
		public override void OnValueChanged(FragmentProperty property)
		{
		}

		// Token: 0x06027538 RID: 161080 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027538")]
		[Address(RVA = "0x2281D70", Offset = "0x2280970", VA = "0x182281D70")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06027539 RID: 161081 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027539")]
		[Address(RVA = "0x2281E90", Offset = "0x2280A90", VA = "0x182281E90")]
		public ArchiveFragmentInfoView()
		{
		}

		// Token: 0x04037B45 RID: 228165
		[Token(Token = "0x4037B45")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ArchiveFragmentInfoView.TitleConfig[] _configList;

		// Token: 0x04037B46 RID: 228166
		[Token(Token = "0x4037B46")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject[] _panelLocked;

		// Token: 0x04037B47 RID: 228167
		[Token(Token = "0x4037B47")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject[] _panelUnlock;

		// Token: 0x04037B48 RID: 228168
		[Token(Token = "0x4037B48")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _panelUnattained;

		// Token: 0x04037B49 RID: 228169
		[Token(Token = "0x4037B49")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _textName;

		// Token: 0x04037B4A RID: 228170
		[Token(Token = "0x4037B4A")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _textWeight;

		// Token: 0x04037B4B RID: 228171
		[Token(Token = "0x4037B4B")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private SimpleLayoutContent _weightContent;

		// Token: 0x04037B4C RID: 228172
		[Token(Token = "0x4037B4C")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _textUsage;

		// Token: 0x04037B4D RID: 228173
		[Token(Token = "0x4037B4D")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Text _textDesc;

		// Token: 0x04037B4E RID: 228174
		[Token(Token = "0x4037B4E")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Image _imgIcon;

		// Token: 0x04037B4F RID: 228175
		[Token(Token = "0x4037B4F")]
		[FieldOffset(Offset = "0x70")]
		private bool m_hasInited;

		// Token: 0x04037B50 RID: 228176
		[Token(Token = "0x4037B50")]
		[FieldOffset(Offset = "0x78")]
		private ArchiveFragmentInfoView.Adapter m_adapter;

		// Token: 0x04037B51 RID: 228177
		[Token(Token = "0x4037B51")]
		[FieldOffset(Offset = "0x80")]
		private int m_cachedValue;

		// Token: 0x04037B52 RID: 228178
		[Token(Token = "0x4037B52")]
		[FieldOffset(Offset = "0x88")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04037B53 RID: 228179
		[Token(Token = "0x4037B53")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04037B54 RID: 228180
		[Token(Token = "0x4037B54")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04037B55 RID: 228181
		[Token(Token = "0x4037B55")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006B89 RID: 27529
		[Token(Token = "0x2006B89")]
		[Serializable]
		private struct TitleConfig
		{
			// Token: 0x04037B56 RID: 228182
			[Token(Token = "0x4037B56")]
			[FieldOffset(Offset = "0x0")]
			public RoguelikeFragmentType type;

			// Token: 0x04037B57 RID: 228183
			[Token(Token = "0x4037B57")]
			[FieldOffset(Offset = "0x8")]
			public GameObject[] panelObj;
		}

		// Token: 0x02006B8A RID: 27530
		[Token(Token = "0x2006B8A")]
		private class Adapter : SimpleLayoutAdapter, IHotfixable
		{
			// Token: 0x0602753A RID: 161082 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602753A")]
			[Address(RVA = "0x2278F20", Offset = "0x2277B20", VA = "0x182278F20")]
			public Adapter(ArchiveFragmentInfoView closure)
			{
			}

			// Token: 0x17005CE3 RID: 23779
			// (get) Token: 0x0602753B RID: 161083 RVA: 0x000CE0E8 File Offset: 0x000CC2E8
			[Token(Token = "0x17005CE3")]
			public override int count
			{
				[Token(Token = "0x602753B")]
				[Address(RVA = "0x22790A0", Offset = "0x2277CA0", VA = "0x1822790A0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0602753C RID: 161084 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602753C")]
			[Address(RVA = "0x22788F0", Offset = "0x22774F0", VA = "0x1822788F0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x04037B58 RID: 228184
			[Token(Token = "0x4037B58")]
			[FieldOffset(Offset = "0x20")]
			private ArchiveFragmentInfoView m_closure;

			// Token: 0x04037B59 RID: 228185
			[Token(Token = "0x4037B59")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04037B5A RID: 228186
			[Token(Token = "0x4037B5A")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04037B5B RID: 228187
			[Token(Token = "0x4037B5B")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
