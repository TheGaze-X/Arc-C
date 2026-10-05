using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Home
{
	// Token: 0x02004BED RID: 19437
	[Token(Token = "0x2004BED")]
	public class HomeCheckInProgressGPInfoView : DataBinder<HomeCheckInProperty>, IHotfixable
	{
		// Token: 0x0601D34F RID: 119631 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D34F")]
		[Address(RVA = "0x16C4350", Offset = "0x16C2F50", VA = "0x1816C4350", Slot = "7")]
		public override void OnValueChanged(HomeCheckInProperty property)
		{
		}

		// Token: 0x0601D350 RID: 119632 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D350")]
		[Address(RVA = "0x16C42C0", Offset = "0x16C2EC0", VA = "0x1816C42C0")]
		public void OnClick()
		{
		}

		// Token: 0x0601D351 RID: 119633 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D351")]
		[Address(RVA = "0x16C4710", Offset = "0x16C3310", VA = "0x1816C4710")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601D352 RID: 119634 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D352")]
		[Address(RVA = "0x16C4830", Offset = "0x16C3430", VA = "0x1816C4830")]
		public HomeCheckInProgressGPInfoView()
		{
		}

		// Token: 0x040265C4 RID: 157124
		[Token(Token = "0x40265C4")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textTitle;

		// Token: 0x040265C5 RID: 157125
		[Token(Token = "0x40265C5")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textRemainDay;

		// Token: 0x040265C6 RID: 157126
		[Token(Token = "0x40265C6")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _imgIcon;

		// Token: 0x040265C7 RID: 157127
		[Token(Token = "0x40265C7")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private SimpleLayoutContent _content;

		// Token: 0x040265C8 RID: 157128
		[Token(Token = "0x40265C8")]
		[FieldOffset(Offset = "0x40")]
		private bool m_hasInited;

		// Token: 0x040265C9 RID: 157129
		[Token(Token = "0x40265C9")]
		[FieldOffset(Offset = "0x48")]
		private HomeCheckInProgressGPInfoView.Adapter m_adapter;

		// Token: 0x040265CA RID: 157130
		[Token(Token = "0x40265CA")]
		[FieldOffset(Offset = "0x50")]
		private List<ISharedItemModel> m_itemDataList;

		// Token: 0x040265CB RID: 157131
		[Token(Token = "0x40265CB")]
		[FieldOffset(Offset = "0x58")]
		private UIStateFinder m_stateFinder;

		// Token: 0x040265CC RID: 157132
		[Token(Token = "0x40265CC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x040265CD RID: 157133
		[Token(Token = "0x40265CD")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x040265CE RID: 157134
		[Token(Token = "0x40265CE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040265CF RID: 157135
		[Token(Token = "0x40265CF")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004BEE RID: 19438
		[Token(Token = "0x2004BEE")]
		private class Adapter : SimpleLayoutAdapter, IHotfixable
		{
			// Token: 0x0601D353 RID: 119635 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601D353")]
			[Address(RVA = "0x16B72A0", Offset = "0x16B5EA0", VA = "0x1816B72A0")]
			public Adapter(HomeCheckInProgressGPInfoView closure)
			{
			}

			// Token: 0x170044B1 RID: 17585
			// (get) Token: 0x0601D354 RID: 119636 RVA: 0x000AAE38 File Offset: 0x000A9038
			[Token(Token = "0x170044B1")]
			public override int count
			{
				[Token(Token = "0x601D354")]
				[Address(RVA = "0x16B75A0", Offset = "0x16B61A0", VA = "0x1816B75A0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601D355 RID: 119637 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601D355")]
			[Address(RVA = "0x16B6A50", Offset = "0x16B5650", VA = "0x1816B6A50", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x040265D0 RID: 157136
			[Token(Token = "0x40265D0")]
			[FieldOffset(Offset = "0x20")]
			private HomeCheckInProgressGPInfoView m_closure;

			// Token: 0x040265D1 RID: 157137
			[Token(Token = "0x40265D1")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x040265D2 RID: 157138
			[Token(Token = "0x40265D2")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x040265D3 RID: 157139
			[Token(Token = "0x40265D3")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
