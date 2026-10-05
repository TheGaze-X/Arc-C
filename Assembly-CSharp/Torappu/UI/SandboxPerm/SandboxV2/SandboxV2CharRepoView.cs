using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004424 RID: 17444
	[Token(Token = "0x2004424")]
	public class SandboxV2CharRepoView : DataBinder<SandboxV2SquadGroupProp>
	{
		// Token: 0x17003F22 RID: 16162
		// (get) Token: 0x0601AA45 RID: 109125 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601AA46 RID: 109126 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003F22")]
		public Action<int> onSlotClick
		{
			[Token(Token = "0x601AA45")]
			[Address(RVA = "0x13C1EC0", Offset = "0x13C0AC0", VA = "0x1813C1EC0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601AA46")]
			[Address(RVA = "0x13C2080", Offset = "0x13C0C80", VA = "0x1813C2080")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17003F23 RID: 16163
		// (get) Token: 0x0601AA47 RID: 109127 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601AA48 RID: 109128 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003F23")]
		public Action<int> onCharDineClick
		{
			[Token(Token = "0x601AA47")]
			[Address(RVA = "0x13C1E00", Offset = "0x13C0A00", VA = "0x1813C1E00")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601AA48")]
			[Address(RVA = "0x13C1F80", Offset = "0x13C0B80", VA = "0x1813C1F80")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17003F24 RID: 16164
		// (get) Token: 0x0601AA49 RID: 109129 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601AA4A RID: 109130 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003F24")]
		public Action<ProfessionCategory> onProfessionFilterClick
		{
			[Token(Token = "0x601AA49")]
			[Address(RVA = "0x13C1E60", Offset = "0x13C0A60", VA = "0x1813C1E60")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601AA4A")]
			[Address(RVA = "0x13C2000", Offset = "0x13C0C00", VA = "0x1813C2000")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17003F25 RID: 16165
		// (get) Token: 0x0601AA4B RID: 109131 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601AA4C RID: 109132 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003F25")]
		public Action<SandboxV2CharFilter> onStatusFilterClick
		{
			[Token(Token = "0x601AA4B")]
			[Address(RVA = "0x13C1F20", Offset = "0x13C0B20", VA = "0x1813C1F20")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601AA4C")]
			[Address(RVA = "0x13C2100", Offset = "0x13C0D00", VA = "0x1813C2100")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0601AA4D RID: 109133 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AA4D")]
		[Address(RVA = "0x13C1390", Offset = "0x13BFF90", VA = "0x1813C1390", Slot = "7")]
		public override void OnValueChanged(SandboxV2SquadGroupProp property)
		{
		}

		// Token: 0x0601AA4E RID: 109134 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AA4E")]
		[Address(RVA = "0x13C1870", Offset = "0x13C0470", VA = "0x1813C1870")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601AA4F RID: 109135 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AA4F")]
		[Address(RVA = "0x13C1D70", Offset = "0x13C0970", VA = "0x1813C1D70")]
		public SandboxV2CharRepoView()
		{
		}

		// Token: 0x04021FC0 RID: 139200
		[Token(Token = "0x4021FC0")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SandboxV2CharRepoListAdapter _charListAdapter;

		// Token: 0x04021FC1 RID: 139201
		[Token(Token = "0x4021FC1")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private SimpleLayoutContent _professionFilterList;

		// Token: 0x04021FC2 RID: 139202
		[Token(Token = "0x4021FC2")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private SimpleLayoutContent _statusFilterList;

		// Token: 0x04021FC3 RID: 139203
		[Token(Token = "0x4021FC3")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private CanvasGroup _alphaHandler;

		// Token: 0x04021FC4 RID: 139204
		[Token(Token = "0x4021FC4")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float _fadeDuraton;

		// Token: 0x04021FC5 RID: 139205
		[Token(Token = "0x4021FC5")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private CanvasGroup _professionFilterAlphaHandler;

		// Token: 0x04021FC6 RID: 139206
		[Token(Token = "0x4021FC6")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private float _professionFilterSwitchDuration;

		// Token: 0x04021FC7 RID: 139207
		[Token(Token = "0x4021FC7")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private CanvasGroup _statusFilterAlphaHandler;

		// Token: 0x04021FC8 RID: 139208
		[Token(Token = "0x4021FC8")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private float _statusFilterSwitchDuration;

		// Token: 0x04021FC9 RID: 139209
		[Token(Token = "0x4021FC9")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Text _textProfessionAll;

		// Token: 0x04021FCA RID: 139210
		[Token(Token = "0x4021FCA")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Color _colorFilterAllUnselect;

		// Token: 0x04021FCB RID: 139211
		[Token(Token = "0x4021FCB")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Color _colorFilterAllSelect;

		// Token: 0x04021FCC RID: 139212
		[Token(Token = "0x4021FCC")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private GameObject _filterProfHideGo;

		// Token: 0x04021FCD RID: 139213
		[Token(Token = "0x4021FCD")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private GameObject _filterProfShowGo;

		// Token: 0x04021FCE RID: 139214
		[Token(Token = "0x4021FCE")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private GameObject _filterProfDetailPartGo;

		// Token: 0x04021FCF RID: 139215
		[Token(Token = "0x4021FCF")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private GameObject _filterProfNonePartGo;

		// Token: 0x04021FD0 RID: 139216
		[Token(Token = "0x4021FD0")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private Text _textFilterProfDetail;

		// Token: 0x04021FD1 RID: 139217
		[Token(Token = "0x4021FD1")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private GameObject _filterStatusHideGo;

		// Token: 0x04021FD2 RID: 139218
		[Token(Token = "0x4021FD2")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private GameObject _filterStatusShowGo;

		// Token: 0x04021FD3 RID: 139219
		[Token(Token = "0x4021FD3")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private Text _textSelectStatus;

		// Token: 0x04021FD4 RID: 139220
		[Token(Token = "0x4021FD4")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private GameObject _emptyPanelGo;

		// Token: 0x04021FD5 RID: 139221
		[Token(Token = "0x4021FD5")]
		[FieldOffset(Offset = "0xD8")]
		private bool m_hasInited;

		// Token: 0x04021FD6 RID: 139222
		[Token(Token = "0x4021FD6")]
		[FieldOffset(Offset = "0xE0")]
		private FadeSwitchTween m_switchTween;

		// Token: 0x04021FD7 RID: 139223
		[Token(Token = "0x4021FD7")]
		[FieldOffset(Offset = "0xE8")]
		private FadeSwitchTween m_professionFilterSwitchTween;

		// Token: 0x04021FD8 RID: 139224
		[Token(Token = "0x4021FD8")]
		[FieldOffset(Offset = "0xF0")]
		private FadeSwitchTween m_statusFilterSwitchTween;

		// Token: 0x04021FD9 RID: 139225
		[Token(Token = "0x4021FD9")]
		[FieldOffset(Offset = "0xF8")]
		private SandboxCharShuffleProfessionListAdapter m_sandboxCharShuffleProfessionListAdapter;

		// Token: 0x04021FDA RID: 139226
		[Token(Token = "0x4021FDA")]
		[FieldOffset(Offset = "0x100")]
		private SandboxShuffleStatusListAdapter m_sandboxShuffleStatusListAdapter;

		// Token: 0x04021FDB RID: 139227
		[Token(Token = "0x4021FDB")]
		[FieldOffset(Offset = "0x108")]
		private SandboxV2CharRepoModel m_repoModel;

		// Token: 0x04021FE0 RID: 139232
		[Token(Token = "0x4021FE0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onSlotClick;

		// Token: 0x04021FE1 RID: 139233
		[Token(Token = "0x4021FE1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onSlotClick;

		// Token: 0x04021FE2 RID: 139234
		[Token(Token = "0x4021FE2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_onCharDineClick;

		// Token: 0x04021FE3 RID: 139235
		[Token(Token = "0x4021FE3")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_onCharDineClick;

		// Token: 0x04021FE4 RID: 139236
		[Token(Token = "0x4021FE4")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_onProfessionFilterClick;

		// Token: 0x04021FE5 RID: 139237
		[Token(Token = "0x4021FE5")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_onProfessionFilterClick;

		// Token: 0x04021FE6 RID: 139238
		[Token(Token = "0x4021FE6")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_onStatusFilterClick;

		// Token: 0x04021FE7 RID: 139239
		[Token(Token = "0x4021FE7")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_set_onStatusFilterClick;

		// Token: 0x04021FE8 RID: 139240
		[Token(Token = "0x4021FE8")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04021FE9 RID: 139241
		[Token(Token = "0x4021FE9")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04021FEA RID: 139242
		[Token(Token = "0x4021FEA")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
