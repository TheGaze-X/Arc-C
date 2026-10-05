using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act42side
{
	// Token: 0x02007300 RID: 29440
	[Token(Token = "0x2007300")]
	public class Act42sideRewardDetailView : DataBinder<Act42sideRewardDetailProperty>
	{
		// Token: 0x06029A66 RID: 170598 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029A66")]
		[Address(RVA = "0x251AF50", Offset = "0x2519B50", VA = "0x18251AF50")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06029A67 RID: 170599 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029A67")]
		[Address(RVA = "0x251AD00", Offset = "0x2519900", VA = "0x18251AD00", Slot = "7")]
		public override void OnValueChanged(Act42sideRewardDetailProperty property)
		{
		}

		// Token: 0x06029A68 RID: 170600 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029A68")]
		[Address(RVA = "0x251B080", Offset = "0x2519C80", VA = "0x18251B080")]
		public Act42sideRewardDetailView()
		{
		}

		// Token: 0x0403B93C RID: 244028
		[Token(Token = "0x403B93C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SimpleLayoutContent _content;

		// Token: 0x0403B93D RID: 244029
		[Token(Token = "0x403B93D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _text;

		// Token: 0x0403B93E RID: 244030
		[Token(Token = "0x403B93E")]
		[FieldOffset(Offset = "0x30")]
		private bool m_isInited;

		// Token: 0x0403B93F RID: 244031
		[Token(Token = "0x403B93F")]
		[FieldOffset(Offset = "0x38")]
		private Act42sideRewardDetailView.Adapter m_adapter;

		// Token: 0x0403B940 RID: 244032
		[Token(Token = "0x403B940")]
		[FieldOffset(Offset = "0x40")]
		private Act42sideRewardDetailViewModel m_cachedModel;

		// Token: 0x0403B941 RID: 244033
		[Token(Token = "0x403B941")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403B942 RID: 244034
		[Token(Token = "0x403B942")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0403B943 RID: 244035
		[Token(Token = "0x403B943")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02007301 RID: 29441
		[Token(Token = "0x2007301")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x06029A69 RID: 170601 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6029A69")]
			[Address(RVA = "0x251B6C0", Offset = "0x251A2C0", VA = "0x18251B6C0")]
			public Adapter(Act42sideRewardDetailView closure)
			{
			}

			// Token: 0x17006271 RID: 25201
			// (get) Token: 0x06029A6A RID: 170602 RVA: 0x000D6230 File Offset: 0x000D4430
			[Token(Token = "0x17006271")]
			public override int count
			{
				[Token(Token = "0x6029A6A")]
				[Address(RVA = "0x251B740", Offset = "0x251A340", VA = "0x18251B740", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06029A6B RID: 170603 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6029A6B")]
			[Address(RVA = "0x251B400", Offset = "0x251A000", VA = "0x18251B400", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0403B944 RID: 244036
			[Token(Token = "0x403B944")]
			[FieldOffset(Offset = "0x20")]
			private Act42sideRewardDetailView m_closure;

			// Token: 0x0403B945 RID: 244037
			[Token(Token = "0x403B945")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0403B946 RID: 244038
			[Token(Token = "0x403B946")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0403B947 RID: 244039
			[Token(Token = "0x403B947")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
