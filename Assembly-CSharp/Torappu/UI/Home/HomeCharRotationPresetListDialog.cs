using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Home
{
	// Token: 0x02004AE9 RID: 19177
	[Token(Token = "0x2004AE9")]
	public class HomeCharRotationPresetListDialog : UICompDialog<HomeCharRotationPresetListDialog.Options>, IHotfixable
	{
		// Token: 0x0601CCE7 RID: 117991 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CCE7")]
		[Address(RVA = "0x16415C0", Offset = "0x16401C0", VA = "0x1816415C0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601CCE8 RID: 117992 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CCE8")]
		[Address(RVA = "0x1641470", Offset = "0x1640070", VA = "0x181641470", Slot = "9")]
		protected override void OnInit()
		{
		}

		// Token: 0x0601CCE9 RID: 117993 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CCE9")]
		[Address(RVA = "0x16414E0", Offset = "0x16400E0", VA = "0x1816414E0", Slot = "18")]
		protected override void OnRender(HomeCharRotationPresetListDialog.Options input)
		{
		}

		// Token: 0x0601CCEA RID: 117994 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601CCEA")]
		[Address(RVA = "0x1641410", Offset = "0x1640010", VA = "0x181641410", Slot = "15")]
		protected override UIRenderTextureImage GetBlurTarget()
		{
			return null;
		}

		// Token: 0x0601CCEB RID: 117995 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CCEB")]
		[Address(RVA = "0x16423B0", Offset = "0x1640FB0", VA = "0x1816423B0")]
		private void _OnBtnNameClick(string presetInstId)
		{
		}

		// Token: 0x0601CCEC RID: 117996 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CCEC")]
		[Address(RVA = "0x1641FA0", Offset = "0x1640BA0", VA = "0x181641FA0")]
		private void _OnBtnDeleteClick(string presetInstId)
		{
		}

		// Token: 0x0601CCED RID: 117997 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CCED")]
		[Address(RVA = "0x1642270", Offset = "0x1640E70", VA = "0x181642270")]
		private void _OnBtnEditClick(string presetInstId)
		{
		}

		// Token: 0x0601CCEE RID: 117998 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CCEE")]
		[Address(RVA = "0x1641990", Offset = "0x1640590", VA = "0x181641990")]
		private void _OnBtnApplyClick(string presetInstId)
		{
		}

		// Token: 0x0601CCEF RID: 117999 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CCEF")]
		[Address(RVA = "0x1641CD0", Offset = "0x16408D0", VA = "0x181641CD0")]
		private void _OnBtnCreatePresetClick()
		{
		}

		// Token: 0x0601CCF0 RID: 118000 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CCF0")]
		[Address(RVA = "0x1641330", Offset = "0x163FF30", VA = "0x181641330")]
		public void EventOnBackBtnClicked()
		{
		}

		// Token: 0x0601CCF1 RID: 118001 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CCF1")]
		[Address(RVA = "0x1642760", Offset = "0x1641360", VA = "0x181642760")]
		public HomeCharRotationPresetListDialog()
		{
		}

		// Token: 0x0601CCF2 RID: 118002 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CCF2")]
		[Address(RVA = "0xE613C0", Offset = "0xE5FFC0", VA = "0x180E613C0")]
		private void <>xLuaBaseProxy_OnInit()
		{
		}

		// Token: 0x0601CCF3 RID: 118003 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601CCF3")]
		[Address(RVA = "0xE613B0", Offset = "0xE5FFB0", VA = "0x180E613B0")]
		private UIRenderTextureImage <>xLuaBaseProxy_GetBlurTarget()
		{
			return null;
		}

		// Token: 0x04025CA8 RID: 154792
		[Token(Token = "0x4025CA8")]
		private const int PRESET_NAME_INPUT_MAX_COUNT = 14;

		// Token: 0x04025CA9 RID: 154793
		[Token(Token = "0x4025CA9")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private UIRenderTextureImage _blurBkg;

		// Token: 0x04025CAA RID: 154794
		[Token(Token = "0x4025CAA")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private HomeCharRotationPresetListView _view;

		// Token: 0x04025CAB RID: 154795
		[Token(Token = "0x4025CAB")]
		[FieldOffset(Offset = "0x80")]
		private HomeCharRotationPresetListViewProperty m_property;

		// Token: 0x04025CAC RID: 154796
		[Token(Token = "0x4025CAC")]
		[FieldOffset(Offset = "0x88")]
		private bool m_inited;

		// Token: 0x04025CAD RID: 154797
		[Token(Token = "0x4025CAD")]
		[FieldOffset(Offset = "0x89")]
		private bool m_isHiding;

		// Token: 0x04025CAE RID: 154798
		[Token(Token = "0x4025CAE")]
		[FieldOffset(Offset = "0x90")]
		private string m_appliedPreset;

		// Token: 0x04025CAF RID: 154799
		[Token(Token = "0x4025CAF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04025CB0 RID: 154800
		[Token(Token = "0x4025CB0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x04025CB1 RID: 154801
		[Token(Token = "0x4025CB1")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x04025CB2 RID: 154802
		[Token(Token = "0x4025CB2")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetBlurTarget;

		// Token: 0x04025CB3 RID: 154803
		[Token(Token = "0x4025CB3")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnBtnNameClick;

		// Token: 0x04025CB4 RID: 154804
		[Token(Token = "0x4025CB4")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnBtnDeleteClick;

		// Token: 0x04025CB5 RID: 154805
		[Token(Token = "0x4025CB5")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__OnBtnEditClick;

		// Token: 0x04025CB6 RID: 154806
		[Token(Token = "0x4025CB6")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__OnBtnApplyClick;

		// Token: 0x04025CB7 RID: 154807
		[Token(Token = "0x4025CB7")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__OnBtnCreatePresetClick;

		// Token: 0x04025CB8 RID: 154808
		[Token(Token = "0x4025CB8")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_EventOnBackBtnClicked;

		// Token: 0x04025CB9 RID: 154809
		[Token(Token = "0x4025CB9")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004AEA RID: 19178
		[Token(Token = "0x2004AEA")]
		public class Options
		{
			// Token: 0x0601CCF4 RID: 118004 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601CCF4")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Options()
			{
			}
		}

		// Token: 0x02004AEB RID: 19179
		[Token(Token = "0x2004AEB")]
		public class PresetRenameConfig : CommonInputDialogServiceConfirmConfig<CharRotationUpdatePresetRequest, CharRotationUpdatePresetResponse>
		{
			// Token: 0x0601CCF5 RID: 118005 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601CCF5")]
			[Address(RVA = "0x164BAE0", Offset = "0x164A6E0", VA = "0x18164BAE0", Slot = "7")]
			protected override CharRotationUpdatePresetRequest ParseRequest(ValueBundle param, string inputText)
			{
				return null;
			}

			// Token: 0x17004400 RID: 17408
			// (get) Token: 0x0601CCF6 RID: 118006 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17004400")]
			protected override string serviceCode
			{
				[Token(Token = "0x601CCF6")]
				[Address(RVA = "0x164BCA0", Offset = "0x164A8A0", VA = "0x18164BCA0", Slot = "8")]
				get
				{
					return null;
				}
			}

			// Token: 0x0601CCF7 RID: 118007 RVA: 0x000A9998 File Offset: 0x000A7B98
			[Token(Token = "0x601CCF7")]
			[Address(RVA = "0x164BA30", Offset = "0x164A630", VA = "0x18164BA30", Slot = "9")]
			protected override bool OnValidateResponse(ValueBundle param, string inputText, CharRotationUpdatePresetResponse response)
			{
				return default(bool);
			}

			// Token: 0x0601CCF8 RID: 118008 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601CCF8")]
			[Address(RVA = "0x164B9C0", Offset = "0x164A5C0", VA = "0x18164B9C0", Slot = "10")]
			public override string OnInputFieldValueChange(string input)
			{
				return null;
			}

			// Token: 0x0601CCF9 RID: 118009 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601CCF9")]
			[Address(RVA = "0x164B950", Offset = "0x164A550", VA = "0x18164B950", Slot = "11")]
			public override string OnInputFieldEndEdit(string input)
			{
				return null;
			}

			// Token: 0x0601CCFA RID: 118010 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601CCFA")]
			[Address(RVA = "0x164BC30", Offset = "0x164A830", VA = "0x18164BC30")]
			public PresetRenameConfig()
			{
			}

			// Token: 0x04025CBA RID: 154810
			[Token(Token = "0x4025CBA")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_ParseRequest;

			// Token: 0x04025CBB RID: 154811
			[Token(Token = "0x4025CBB")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_serviceCode;

			// Token: 0x04025CBC RID: 154812
			[Token(Token = "0x4025CBC")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_OnValidateResponse;

			// Token: 0x04025CBD RID: 154813
			[Token(Token = "0x4025CBD")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_OnInputFieldValueChange;

			// Token: 0x04025CBE RID: 154814
			[Token(Token = "0x4025CBE")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_OnInputFieldEndEdit;

			// Token: 0x04025CBF RID: 154815
			[Token(Token = "0x4025CBF")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
