using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Home.Theme
{
	// Token: 0x02004C4F RID: 19535
	[Token(Token = "0x2004C4F")]
	public class HomeThemeApNumbersView : HomeThemeApView, IHotfixable
	{
		// Token: 0x0601D519 RID: 120089 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D519")]
		[Address(RVA = "0x16E3F60", Offset = "0x16E2B60", VA = "0x1816E3F60")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601D51A RID: 120090 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D51A")]
		[Address(RVA = "0x16E3BA0", Offset = "0x16E27A0", VA = "0x1816E3BA0", Slot = "7")]
		public override void OnValueChanged(APInfoProperty property)
		{
		}

		// Token: 0x0601D51B RID: 120091 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D51B")]
		[Address(RVA = "0x16E40D0", Offset = "0x16E2CD0", VA = "0x1816E40D0")]
		public HomeThemeApNumbersView()
		{
		}

		// Token: 0x04026931 RID: 158001
		[Token(Token = "0x4026931")]
		private const string AP_MAX_FORMAT = "/{0}";

		// Token: 0x04026932 RID: 158002
		[Token(Token = "0x4026932")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private SimpleLayoutContent _content;

		// Token: 0x04026933 RID: 158003
		[Token(Token = "0x4026933")]
		[FieldOffset(Offset = "0x38")]
		private List<string> m_numberList;

		// Token: 0x04026934 RID: 158004
		[Token(Token = "0x4026934")]
		[FieldOffset(Offset = "0x40")]
		private HomeThemeApNumbersView.Adapter m_adapter;

		// Token: 0x04026935 RID: 158005
		[Token(Token = "0x4026935")]
		[FieldOffset(Offset = "0x48")]
		private bool m_Init;

		// Token: 0x04026936 RID: 158006
		[Token(Token = "0x4026936")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04026937 RID: 158007
		[Token(Token = "0x4026937")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04026938 RID: 158008
		[Token(Token = "0x4026938")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004C50 RID: 19536
		[Token(Token = "0x2004C50")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x0601D51C RID: 120092 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601D51C")]
			[Address(RVA = "0x16DD610", Offset = "0x16DC210", VA = "0x1816DD610")]
			public Adapter(HomeThemeApNumbersView closure)
			{
			}

			// Token: 0x170044E0 RID: 17632
			// (get) Token: 0x0601D51D RID: 120093 RVA: 0x000AB2E8 File Offset: 0x000A94E8
			[Token(Token = "0x170044E0")]
			public override int count
			{
				[Token(Token = "0x601D51D")]
				[Address(RVA = "0x16DD890", Offset = "0x16DC490", VA = "0x1816DD890", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601D51E RID: 120094 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601D51E")]
			[Address(RVA = "0x16DCFA0", Offset = "0x16DBBA0", VA = "0x1816DCFA0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x04026939 RID: 158009
			[Token(Token = "0x4026939")]
			[FieldOffset(Offset = "0x20")]
			private HomeThemeApNumbersView m_closure;

			// Token: 0x0402693A RID: 158010
			[Token(Token = "0x402693A")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402693B RID: 158011
			[Token(Token = "0x402693B")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0402693C RID: 158012
			[Token(Token = "0x402693C")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
