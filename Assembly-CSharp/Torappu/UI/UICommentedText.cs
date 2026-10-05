using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI
{
	// Token: 0x020039DE RID: 14814
	[Token(Token = "0x20039DE")]
	public class UICommentedText : Text, IHotfixable
	{
		// Token: 0x1700380B RID: 14347
		// (get) Token: 0x06017655 RID: 95829 RVA: 0x000964C8 File Offset: 0x000946C8
		// (set) Token: 0x06017656 RID: 95830 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700380B")]
		public bool useDarkColor
		{
			[Token(Token = "0x6017655")]
			[Address(RVA = "0xFC0840", Offset = "0xFBF440", VA = "0x180FC0840")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6017656")]
			[Address(RVA = "0xFC0920", Offset = "0xFBF520", VA = "0x180FC0920")]
			set
			{
			}
		}

		// Token: 0x1700380C RID: 14348
		// (set) Token: 0x06017657 RID: 95831 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700380C")]
		public override string text
		{
			[Token(Token = "0x6017657")]
			[Address(RVA = "0xFC08A0", Offset = "0xFBF4A0", VA = "0x180FC08A0", Slot = "77")]
			set
			{
			}
		}

		// Token: 0x06017658 RID: 95832 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017658")]
		[Address(RVA = "0xFBE5C0", Offset = "0xFBD1C0", VA = "0x180FBE5C0")]
		public void SetClickableRichTextFromData(string rawRichText)
		{
		}

		// Token: 0x06017659 RID: 95833 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017659")]
		[Address(RVA = "0xFBE4F0", Offset = "0xFBD0F0", VA = "0x180FBE4F0", Slot = "46")]
		protected override void OnPopulateMesh(VertexHelper toFill)
		{
		}

		// Token: 0x0601765A RID: 95834 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601765A")]
		[Address(RVA = "0xFBFB60", Offset = "0xFBE760", VA = "0x180FBFB60")]
		private void _PopulateMeshImpl(VertexHelper toFill)
		{
		}

		// Token: 0x0601765B RID: 95835 RVA: 0x000964E0 File Offset: 0x000946E0
		[Token(Token = "0x601765B")]
		[Address(RVA = "0xFBF690", Offset = "0xFBE290", VA = "0x180FBF690")]
		private bool _IsTempVertexValid()
		{
			return default(bool);
		}

		// Token: 0x0601765C RID: 95836 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601765C")]
		[Address(RVA = "0xFBEC30", Offset = "0xFBD830", VA = "0x180FBEC30")]
		private void _CalculateClickableTextBound(UICommentedTextData clickableTextData, ref Vector4 buttonBound, ref bool buttonBoundInit, ref float lastCharMinY, float xOffset, float yOffset, int stringIndex)
		{
		}

		// Token: 0x0601765D RID: 95837 RVA: 0x000964F8 File Offset: 0x000946F8
		[Token(Token = "0x601765D")]
		[Address(RVA = "0xFBF550", Offset = "0xFBE150", VA = "0x180FBF550")]
		protected Vector4 _GetCharBound()
		{
			return default(Vector4);
		}

		// Token: 0x0601765E RID: 95838 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601765E")]
		[Address(RVA = "0xFBE960", Offset = "0xFBD560", VA = "0x180FBE960")]
		private void Update()
		{
		}

		// Token: 0x0601765F RID: 95839 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601765F")]
		[Address(RVA = "0xFBF3E0", Offset = "0xFBDFE0", VA = "0x180FBF3E0")]
		private void _CreateTag()
		{
		}

		// Token: 0x06017660 RID: 95840 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6017660")]
		[Address(RVA = "0xFC0430", Offset = "0xFBF030", VA = "0x180FC0430")]
		private UICommentedTextButton _TryGetBtnFromPool()
		{
			return null;
		}

		// Token: 0x06017661 RID: 95841 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017661")]
		[Address(RVA = "0xFBF970", Offset = "0xFBE570", VA = "0x180FBF970")]
		private void _PoolBtns()
		{
		}

		// Token: 0x06017662 RID: 95842 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017662")]
		[Address(RVA = "0xFBF750", Offset = "0xFBE350", VA = "0x180FBF750")]
		private void _LoadPrefabIfNeeded()
		{
		}

		// Token: 0x06017663 RID: 95843 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017663")]
		[Address(RVA = "0xFBF0D0", Offset = "0xFBDCD0", VA = "0x180FBF0D0")]
		private void _CreateClickableLink(UICommentedTextData tagData)
		{
		}

		// Token: 0x06017664 RID: 95844 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017664")]
		[Address(RVA = "0xFBF8C0", Offset = "0xFBE4C0", VA = "0x180FBF8C0")]
		private void _OnTextClickEvent(UITermDescDataModel valuePair)
		{
		}

		// Token: 0x06017665 RID: 95845 RVA: 0x00096510 File Offset: 0x00094710
		[Token(Token = "0x6017665")]
		[Address(RVA = "0xFBE7B0", Offset = "0xFBD3B0", VA = "0x180FBE7B0")]
		public static bool SetCommentedText(Text text, string content, bool useDarkColor = false)
		{
			return default(bool);
		}

		// Token: 0x06017666 RID: 95846 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017666")]
		[Address(RVA = "0xFC0720", Offset = "0xFBF320", VA = "0x180FC0720")]
		public UICommentedText()
		{
		}

		// Token: 0x06017667 RID: 95847 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017667")]
		[Address(RVA = "0xFBE950", Offset = "0xFBD550", VA = "0x180FBE950")]
		private void <>xLuaBaseProxy_set_text(string P0)
		{
		}

		// Token: 0x06017668 RID: 95848 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017668")]
		[Address(RVA = "0xFBE940", Offset = "0xFBD540", VA = "0x180FBE940")]
		private void <>xLuaBaseProxy_OnPopulateMesh(VertexHelper P0)
		{
		}

		// Token: 0x0401C415 RID: 115733
		[Token(Token = "0x401C415")]
		[FieldOffset(Offset = "0x150")]
		private UICommentedTextDataBundle m_cachedDataBundle;

		// Token: 0x0401C416 RID: 115734
		[Token(Token = "0x401C416")]
		[FieldOffset(Offset = "0x158")]
		private List<UICommentedTextButton> m_showTextButtonList;

		// Token: 0x0401C417 RID: 115735
		[Token(Token = "0x401C417")]
		[FieldOffset(Offset = "0x160")]
		private List<UICommentedTextButton> m_textButtonPool;

		// Token: 0x0401C418 RID: 115736
		[Token(Token = "0x401C418")]
		[FieldOffset(Offset = "0x168")]
		private Dictionary<int, UICommentedTextData> m_tagDict;

		// Token: 0x0401C419 RID: 115737
		[Token(Token = "0x401C419")]
		[FieldOffset(Offset = "0x170")]
		private bool m_dirty;

		// Token: 0x0401C41A RID: 115738
		[Token(Token = "0x401C41A")]
		[FieldOffset(Offset = "0x178")]
		private string m_lastText;

		// Token: 0x0401C41B RID: 115739
		[Token(Token = "0x401C41B")]
		[FieldOffset(Offset = "0x180")]
		private int m_lastSize;

		// Token: 0x0401C41C RID: 115740
		[Token(Token = "0x401C41C")]
		[FieldOffset(Offset = "0x188")]
		private UICommentedTextButton m_prefab;

		// Token: 0x0401C41D RID: 115741
		[Token(Token = "0x401C41D")]
		[FieldOffset(Offset = "0x190")]
		private bool m_useDarkColor;

		// Token: 0x0401C41E RID: 115742
		[Token(Token = "0x401C41E")]
		private const float HOT_ZONE_SIZE_MULTIFILER = 1.5f;

		// Token: 0x0401C41F RID: 115743
		[Token(Token = "0x401C41F")]
		[FieldOffset(Offset = "0x198")]
		private readonly UIVertex[] m_tempVerts;

		// Token: 0x0401C420 RID: 115744
		[Token(Token = "0x401C420")]
		[FieldOffset(Offset = "0x1A0")]
		private UICommentedTextData m_cachedClickableTextData;

		// Token: 0x0401C421 RID: 115745
		[Token(Token = "0x401C421")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_useDarkColor;

		// Token: 0x0401C422 RID: 115746
		[Token(Token = "0x401C422")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_useDarkColor;

		// Token: 0x0401C423 RID: 115747
		[Token(Token = "0x401C423")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_set_text;

		// Token: 0x0401C424 RID: 115748
		[Token(Token = "0x401C424")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_SetClickableRichTextFromData;

		// Token: 0x0401C425 RID: 115749
		[Token(Token = "0x401C425")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnPopulateMesh;

		// Token: 0x0401C426 RID: 115750
		[Token(Token = "0x401C426")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__PopulateMeshImpl;

		// Token: 0x0401C427 RID: 115751
		[Token(Token = "0x401C427")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__IsTempVertexValid;

		// Token: 0x0401C428 RID: 115752
		[Token(Token = "0x401C428")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__CalculateClickableTextBound;

		// Token: 0x0401C429 RID: 115753
		[Token(Token = "0x401C429")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__GetCharBound;

		// Token: 0x0401C42A RID: 115754
		[Token(Token = "0x401C42A")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x0401C42B RID: 115755
		[Token(Token = "0x401C42B")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__CreateTag;

		// Token: 0x0401C42C RID: 115756
		[Token(Token = "0x401C42C")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__TryGetBtnFromPool;

		// Token: 0x0401C42D RID: 115757
		[Token(Token = "0x401C42D")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__PoolBtns;

		// Token: 0x0401C42E RID: 115758
		[Token(Token = "0x401C42E")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__LoadPrefabIfNeeded;

		// Token: 0x0401C42F RID: 115759
		[Token(Token = "0x401C42F")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__CreateClickableLink;

		// Token: 0x0401C430 RID: 115760
		[Token(Token = "0x401C430")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__OnTextClickEvent;

		// Token: 0x0401C431 RID: 115761
		[Token(Token = "0x401C431")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_SetCommentedText;

		// Token: 0x0401C432 RID: 115762
		[Token(Token = "0x401C432")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
