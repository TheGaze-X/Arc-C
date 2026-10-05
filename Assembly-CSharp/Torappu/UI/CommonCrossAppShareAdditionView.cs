using System;
using Il2CppDummyDll;
using Torappu.UI.CrossAppShare;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003A52 RID: 14930
	[Token(Token = "0x2003A52")]
	public class CommonCrossAppShareAdditionView : CrossAppShareRemakeAdditionBaseView
	{
		// Token: 0x06017999 RID: 96665 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017999")]
		[Address(RVA = "0xFE15E0", Offset = "0xFE01E0", VA = "0x180FE15E0", Slot = "4")]
		public override void Render(ICrossAppShareRemakeAdditionBaseModel model)
		{
		}

		// Token: 0x0601799A RID: 96666 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601799A")]
		[Address(RVA = "0xFE1880", Offset = "0xFE0480", VA = "0x180FE1880")]
		public CommonCrossAppShareAdditionView()
		{
		}

		// Token: 0x0601799B RID: 96667 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601799B")]
		[Address(RVA = "0xFE1870", Offset = "0xFE0470", VA = "0x180FE1870")]
		private void <>xLuaBaseProxy_Render(ICrossAppShareRemakeAdditionBaseModel P0)
		{
		}

		// Token: 0x0401C7A6 RID: 116646
		[Token(Token = "0x401C7A6")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _shareTimeDay;

		// Token: 0x0401C7A7 RID: 116647
		[Token(Token = "0x401C7A7")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _shareTimeSecond;

		// Token: 0x0401C7A8 RID: 116648
		[Token(Token = "0x401C7A8")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _nickName;

		// Token: 0x0401C7A9 RID: 116649
		[Token(Token = "0x401C7A9")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _nickNumber;

		// Token: 0x0401C7AA RID: 116650
		[Token(Token = "0x401C7AA")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _uid;

		// Token: 0x0401C7AB RID: 116651
		[Token(Token = "0x401C7AB")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UIStyleProvider _styleProvider;

		// Token: 0x0401C7AC RID: 116652
		[Token(Token = "0x401C7AC")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _uidObject;

		// Token: 0x0401C7AD RID: 116653
		[Token(Token = "0x401C7AD")]
		[FieldOffset(Offset = "0x50")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0401C7AE RID: 116654
		[Token(Token = "0x401C7AE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401C7AF RID: 116655
		[Token(Token = "0x401C7AF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
