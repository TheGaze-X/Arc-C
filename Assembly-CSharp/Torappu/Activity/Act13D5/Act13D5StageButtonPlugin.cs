using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.Stage;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act13D5
{
	// Token: 0x02007A53 RID: 31315
	[Token(Token = "0x2007A53")]
	public class Act13D5StageButtonPlugin : StageButtonHolderPlugin
	{
		// Token: 0x0602BDE7 RID: 179687 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BDE7")]
		[Address(RVA = "0x27C92E0", Offset = "0x27C7EE0", VA = "0x1827C92E0", Slot = "4")]
		protected override void OnInit()
		{
		}

		// Token: 0x0602BDE8 RID: 179688 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BDE8")]
		[Address(RVA = "0x27C9350", Offset = "0x27C7F50", VA = "0x1827C9350", Slot = "5")]
		protected override void OnRenderStage(StageViewModel model)
		{
		}

		// Token: 0x0602BDE9 RID: 179689 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BDE9")]
		[Address(RVA = "0x27C96C0", Offset = "0x27C82C0", VA = "0x1827C96C0")]
		private void _StatusBegin()
		{
		}

		// Token: 0x0602BDEA RID: 179690 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BDEA")]
		[Address(RVA = "0x27C97A0", Offset = "0x27C83A0", VA = "0x1827C97A0")]
		private void _StatusEnd()
		{
		}

		// Token: 0x0602BDEB RID: 179691 RVA: 0x000DD748 File Offset: 0x000DB948
		[Token(Token = "0x602BDEB")]
		[Address(RVA = "0x27C9590", Offset = "0x27C8190", VA = "0x1827C9590")]
		private bool _CheckIfTriggerShowEffect()
		{
			return default(bool);
		}

		// Token: 0x0602BDEC RID: 179692 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602BDEC")]
		[Address(RVA = "0x27C9610", Offset = "0x27C8210", VA = "0x1827C9610")]
		private IEnumerator _DisplayCoroutine()
		{
			return null;
		}

		// Token: 0x0602BDED RID: 179693 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BDED")]
		[Address(RVA = "0x27C91C0", Offset = "0x27C7DC0", VA = "0x1827C91C0")]
		private void OnEnable()
		{
		}

		// Token: 0x0602BDEE RID: 179694 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BDEE")]
		[Address(RVA = "0x27C9150", Offset = "0x27C7D50", VA = "0x1827C9150")]
		private void OnDisable()
		{
		}

		// Token: 0x0602BDEF RID: 179695 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BDEF")]
		[Address(RVA = "0x27C98A0", Offset = "0x27C84A0", VA = "0x1827C98A0")]
		public Act13D5StageButtonPlugin()
		{
		}

		// Token: 0x0403F881 RID: 260225
		[Token(Token = "0x403F881")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private List<Act13D5LineFiller> _lines;

		// Token: 0x0403F882 RID: 260226
		[Token(Token = "0x403F882")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _lineDuration;

		// Token: 0x0403F883 RID: 260227
		[Token(Token = "0x403F883")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UIAnimationLocation _showAnim;

		// Token: 0x0403F884 RID: 260228
		[Token(Token = "0x403F884")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private float _allDelay;

		// Token: 0x0403F885 RID: 260229
		[Token(Token = "0x403F885")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _pluginObj;

		// Token: 0x0403F886 RID: 260230
		[Token(Token = "0x403F886")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _panelEmpty;

		// Token: 0x0403F887 RID: 260231
		[Token(Token = "0x403F887")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private bool _enableShowEffect;

		// Token: 0x0403F888 RID: 260232
		[Token(Token = "0x403F888")]
		[FieldOffset(Offset = "0x61")]
		private bool m_isFirstShow;

		// Token: 0x0403F889 RID: 260233
		[Token(Token = "0x403F889")]
		[FieldOffset(Offset = "0x62")]
		private bool m_isEnabled;

		// Token: 0x0403F88A RID: 260234
		[Token(Token = "0x403F88A")]
		[FieldOffset(Offset = "0x68")]
		private StageViewModel m_model;

		// Token: 0x0403F88B RID: 260235
		[Token(Token = "0x403F88B")]
		[FieldOffset(Offset = "0x70")]
		private CoroutineOnEnable m_displayCoroutine;

		// Token: 0x0403F88C RID: 260236
		[Token(Token = "0x403F88C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x0403F88D RID: 260237
		[Token(Token = "0x403F88D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnRenderStage;

		// Token: 0x0403F88E RID: 260238
		[Token(Token = "0x403F88E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__StatusBegin;

		// Token: 0x0403F88F RID: 260239
		[Token(Token = "0x403F88F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__StatusEnd;

		// Token: 0x0403F890 RID: 260240
		[Token(Token = "0x403F890")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__CheckIfTriggerShowEffect;

		// Token: 0x0403F891 RID: 260241
		[Token(Token = "0x403F891")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__DisplayCoroutine;

		// Token: 0x0403F892 RID: 260242
		[Token(Token = "0x403F892")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnEnable;

		// Token: 0x0403F893 RID: 260243
		[Token(Token = "0x403F893")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnDisable;

		// Token: 0x0403F894 RID: 260244
		[Token(Token = "0x403F894")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
