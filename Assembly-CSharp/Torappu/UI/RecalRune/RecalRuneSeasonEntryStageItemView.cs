using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.RecalRune
{
	// Token: 0x020047A9 RID: 18345
	[Token(Token = "0x20047A9")]
	public class RecalRuneSeasonEntryStageItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601BC7A RID: 113786 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BC7A")]
		[Address(RVA = "0x152D590", Offset = "0x152C190", VA = "0x18152D590")]
		public void Render(RecalRuneSeasonEntryStageModel viewModel)
		{
		}

		// Token: 0x0601BC7B RID: 113787 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BC7B")]
		[Address(RVA = "0x152D4A0", Offset = "0x152C0A0", VA = "0x18152D4A0")]
		public void OnStageClicked()
		{
		}

		// Token: 0x0601BC7C RID: 113788 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BC7C")]
		[Address(RVA = "0x152D8D0", Offset = "0x152C4D0", VA = "0x18152D8D0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601BC7D RID: 113789 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BC7D")]
		[Address(RVA = "0x152D970", Offset = "0x152C570", VA = "0x18152D970")]
		public RecalRuneSeasonEntryStageItemView()
		{
		}

		// Token: 0x040241DD RID: 147933
		[Token(Token = "0x40241DD")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _bg;

		// Token: 0x040241DE RID: 147934
		[Token(Token = "0x40241DE")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _icon;

		// Token: 0x040241DF RID: 147935
		[Token(Token = "0x40241DF")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _medal;

		// Token: 0x040241E0 RID: 147936
		[Token(Token = "0x40241E0")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private TwoStateToggle _toggleFrame;

		// Token: 0x040241E1 RID: 147937
		[Token(Token = "0x40241E1")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private ThreeStateToggle _toggleRecord;

		// Token: 0x040241E2 RID: 147938
		[Token(Token = "0x40241E2")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _record;

		// Token: 0x040241E3 RID: 147939
		[Token(Token = "0x40241E3")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _textFrom;

		// Token: 0x040241E4 RID: 147940
		[Token(Token = "0x40241E4")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _textFromType;

		// Token: 0x040241E5 RID: 147941
		[Token(Token = "0x40241E5")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _textCode;

		// Token: 0x040241E6 RID: 147942
		[Token(Token = "0x40241E6")]
		[FieldOffset(Offset = "0x60")]
		private UIPageFinder m_pageFinder;

		// Token: 0x040241E7 RID: 147943
		[Token(Token = "0x40241E7")]
		[FieldOffset(Offset = "0x70")]
		private UIStateFinder m_stateFinder;

		// Token: 0x040241E8 RID: 147944
		[Token(Token = "0x40241E8")]
		[FieldOffset(Offset = "0x80")]
		private ILoadAsset m_assetLoader;

		// Token: 0x040241E9 RID: 147945
		[Token(Token = "0x40241E9")]
		[FieldOffset(Offset = "0x88")]
		private bool m_hasInited;

		// Token: 0x040241EA RID: 147946
		[Token(Token = "0x40241EA")]
		[FieldOffset(Offset = "0x90")]
		private string m_cachedStageId;

		// Token: 0x040241EB RID: 147947
		[Token(Token = "0x40241EB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040241EC RID: 147948
		[Token(Token = "0x40241EC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnStageClicked;

		// Token: 0x040241ED RID: 147949
		[Token(Token = "0x40241ED")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040241EE RID: 147950
		[Token(Token = "0x40241EE")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
