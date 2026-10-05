using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.Carving
{
	// Token: 0x0200605A RID: 24666
	[Token(Token = "0x200605A")]
	public class CarvingMainCardDetailBlocker : DataBinder<CarvingMainProperty>
	{
		// Token: 0x06023AAA RID: 146090 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023AAA")]
		[Address(RVA = "0x1E4BA30", Offset = "0x1E4A630", VA = "0x181E4BA30", Slot = "7")]
		public override void OnValueChanged(CarvingMainProperty property)
		{
		}

		// Token: 0x06023AAB RID: 146091 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023AAB")]
		[Address(RVA = "0x1E4B990", Offset = "0x1E4A590", VA = "0x181E4B990")]
		public void OnClickUnselect()
		{
		}

		// Token: 0x06023AAC RID: 146092 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023AAC")]
		[Address(RVA = "0x1E4BB20", Offset = "0x1E4A720", VA = "0x181E4BB20")]
		public CarvingMainCardDetailBlocker()
		{
		}

		// Token: 0x04031692 RID: 202386
		[Token(Token = "0x4031692")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _blocker;

		// Token: 0x04031693 RID: 202387
		[Token(Token = "0x4031693")]
		[FieldOffset(Offset = "0x28")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04031694 RID: 202388
		[Token(Token = "0x4031694")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04031695 RID: 202389
		[Token(Token = "0x4031695")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnClickUnselect;

		// Token: 0x04031696 RID: 202390
		[Token(Token = "0x4031696")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
