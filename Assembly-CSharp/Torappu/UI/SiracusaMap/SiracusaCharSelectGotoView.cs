using System;
using Il2CppDummyDll;
using Torappu.AVG;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SiracusaMap
{
	// Token: 0x02003F20 RID: 16160
	[Token(Token = "0x2003F20")]
	public class SiracusaCharSelectGotoView : DataBinder<SiracusaMapPanelMapProperty>
	{
		// Token: 0x06019178 RID: 102776 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019178")]
		[Address(RVA = "0x11C6D00", Offset = "0x11C5900", VA = "0x1811C6D00")]
		private void _PlayEntryAnim()
		{
		}

		// Token: 0x06019179 RID: 102777 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019179")]
		[Address(RVA = "0x11C6C00", Offset = "0x11C5800", VA = "0x1811C6C00")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601917A RID: 102778 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601917A")]
		[Address(RVA = "0x11C6DB0", Offset = "0x11C59B0", VA = "0x1811C6DB0")]
		private void _Render(SiracusaCharCardModel viewModel)
		{
		}

		// Token: 0x0601917B RID: 102779 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601917B")]
		[Address(RVA = "0x11C6B40", Offset = "0x11C5740", VA = "0x1811C6B40", Slot = "7")]
		public override void OnValueChanged(SiracusaMapPanelMapProperty property)
		{
		}

		// Token: 0x0601917C RID: 102780 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601917C")]
		[Address(RVA = "0x11C7280", Offset = "0x11C5E80", VA = "0x1811C7280")]
		public SiracusaCharSelectGotoView()
		{
		}

		// Token: 0x0401F0BD RID: 127165
		[Token(Token = "0x401F0BD")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIAtlasImage _imgCharIcon;

		// Token: 0x0401F0BE RID: 127166
		[Token(Token = "0x401F0BE")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIAtlasImage _imgMissionIcon;

		// Token: 0x0401F0BF RID: 127167
		[Token(Token = "0x401F0BF")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UIAtlasImage _imgBgTheme;

		// Token: 0x0401F0C0 RID: 127168
		[Token(Token = "0x401F0C0")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _textDialogue;

		// Token: 0x0401F0C1 RID: 127169
		[Token(Token = "0x401F0C1")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _txtCharName;

		// Token: 0x0401F0C2 RID: 127170
		[Token(Token = "0x401F0C2")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private RectTransform _transAvgContainer;

		// Token: 0x0401F0C3 RID: 127171
		[Token(Token = "0x401F0C3")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private UIAVGCharacter _uiAVGCharacter;

		// Token: 0x0401F0C4 RID: 127172
		[Token(Token = "0x401F0C4")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private AnimationWrapper _enterAnimWrapper;

		// Token: 0x0401F0C5 RID: 127173
		[Token(Token = "0x401F0C5")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Text _txtCloseTip;

		// Token: 0x0401F0C6 RID: 127174
		[Token(Token = "0x401F0C6")]
		[FieldOffset(Offset = "0x68")]
		private string m_cachedCharId;

		// Token: 0x0401F0C7 RID: 127175
		[Token(Token = "0x401F0C7")]
		[FieldOffset(Offset = "0x70")]
		private bool m_hasInited;

		// Token: 0x0401F0C8 RID: 127176
		[Token(Token = "0x401F0C8")]
		[FieldOffset(Offset = "0x74")]
		private Vector2 m_defaultAvgContainerPos;

		// Token: 0x0401F0C9 RID: 127177
		[Token(Token = "0x401F0C9")]
		private const string ANIM_NAME = "siracusa_char_select_goto";

		// Token: 0x0401F0CA RID: 127178
		[Token(Token = "0x401F0CA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__PlayEntryAnim;

		// Token: 0x0401F0CB RID: 127179
		[Token(Token = "0x401F0CB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401F0CC RID: 127180
		[Token(Token = "0x401F0CC")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__Render;

		// Token: 0x0401F0CD RID: 127181
		[Token(Token = "0x401F0CD")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0401F0CE RID: 127182
		[Token(Token = "0x401F0CE")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
