using System;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.TemplateTrap;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act46Side
{
	// Token: 0x020072AF RID: 29359
	[Token(Token = "0x20072AF")]
	public class Act46SideTrapView : TemplateTrapView
	{
		// Token: 0x17006248 RID: 25160
		// (get) Token: 0x060298FA RID: 170234 RVA: 0x000D5EE8 File Offset: 0x000D40E8
		[Token(Token = "0x17006248")]
		public override TemplateTrapState.TemplateTrapSaveType saveType
		{
			[Token(Token = "0x60298FA")]
			[Address(RVA = "0x2500C20", Offset = "0x24FF820", VA = "0x182500C20", Slot = "8")]
			get
			{
				return TemplateTrapState.TemplateTrapSaveType.NONE;
			}
		}

		// Token: 0x060298FB RID: 170235 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60298FB")]
		[Address(RVA = "0x2500A20", Offset = "0x24FF620", VA = "0x182500A20")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060298FC RID: 170236 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60298FC")]
		[Address(RVA = "0x2500B40", Offset = "0x24FF740", VA = "0x182500B40")]
		private void _OnItemClicked(string trapId)
		{
		}

		// Token: 0x060298FD RID: 170237 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60298FD")]
		[Address(RVA = "0x25006C0", Offset = "0x24FF2C0", VA = "0x1825006C0", Slot = "7")]
		public override void OnValueChanged(TemplateTrapProperty property)
		{
		}

		// Token: 0x060298FE RID: 170238 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60298FE")]
		[Address(RVA = "0x2500950", Offset = "0x24FF550", VA = "0x182500950", Slot = "9")]
		public override Tween StartFadeInTween()
		{
			return null;
		}

		// Token: 0x060298FF RID: 170239 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60298FF")]
		[Address(RVA = "0x25008A0", Offset = "0x24FF4A0", VA = "0x1825008A0", Slot = "10")]
		public override void SetAction(TemplateTrapState.ActionConfig action)
		{
		}

		// Token: 0x06029900 RID: 170240 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029900")]
		[Address(RVA = "0x2500650", Offset = "0x24FF250", VA = "0x182500650")]
		public void OnBackClicked()
		{
		}

		// Token: 0x06029901 RID: 170241 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029901")]
		[Address(RVA = "0x2500BC0", Offset = "0x24FF7C0", VA = "0x182500BC0")]
		public Act46SideTrapView()
		{
		}

		// Token: 0x0403B6DB RID: 243419
		[Token(Token = "0x403B6DB")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIAnimationLocation _animShow;

		// Token: 0x0403B6DC RID: 243420
		[Token(Token = "0x403B6DC")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private SimpleLayoutContent _trapList;

		// Token: 0x0403B6DD RID: 243421
		[Token(Token = "0x403B6DD")]
		[FieldOffset(Offset = "0x38")]
		private bool m_inited;

		// Token: 0x0403B6DE RID: 243422
		[Token(Token = "0x403B6DE")]
		[FieldOffset(Offset = "0x40")]
		private Act46SideTrapView.Adapter m_adapter;

		// Token: 0x0403B6DF RID: 243423
		[Token(Token = "0x403B6DF")]
		[FieldOffset(Offset = "0x48")]
		private ListDict<string, TemplateTrapViewModel> m_cachedTrapList;

		// Token: 0x0403B6E0 RID: 243424
		[Token(Token = "0x403B6E0")]
		[FieldOffset(Offset = "0x50")]
		private Action<string> m_onItemClicked;

		// Token: 0x0403B6E1 RID: 243425
		[Token(Token = "0x403B6E1")]
		[FieldOffset(Offset = "0x58")]
		private Action m_onBackClicked;

		// Token: 0x0403B6E2 RID: 243426
		[Token(Token = "0x403B6E2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_saveType;

		// Token: 0x0403B6E3 RID: 243427
		[Token(Token = "0x403B6E3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403B6E4 RID: 243428
		[Token(Token = "0x403B6E4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__OnItemClicked;

		// Token: 0x0403B6E5 RID: 243429
		[Token(Token = "0x403B6E5")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0403B6E6 RID: 243430
		[Token(Token = "0x403B6E6")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_StartFadeInTween;

		// Token: 0x0403B6E7 RID: 243431
		[Token(Token = "0x403B6E7")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_SetAction;

		// Token: 0x0403B6E8 RID: 243432
		[Token(Token = "0x403B6E8")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnBackClicked;

		// Token: 0x0403B6E9 RID: 243433
		[Token(Token = "0x403B6E9")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020072B0 RID: 29360
		[Token(Token = "0x20072B0")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x06029902 RID: 170242 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6029902")]
			[Address(RVA = "0x2501140", Offset = "0x24FFD40", VA = "0x182501140")]
			public Adapter(Act46SideTrapView closure)
			{
			}

			// Token: 0x17006249 RID: 25161
			// (get) Token: 0x06029903 RID: 170243 RVA: 0x000D5F00 File Offset: 0x000D4100
			[Token(Token = "0x17006249")]
			public override int count
			{
				[Token(Token = "0x6029903")]
				[Address(RVA = "0x2501240", Offset = "0x24FFE40", VA = "0x182501240", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06029904 RID: 170244 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6029904")]
			[Address(RVA = "0x2500EE0", Offset = "0x24FFAE0", VA = "0x182500EE0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0403B6EA RID: 243434
			[Token(Token = "0x403B6EA")]
			[FieldOffset(Offset = "0x20")]
			private Act46SideTrapView m_closure;

			// Token: 0x0403B6EB RID: 243435
			[Token(Token = "0x403B6EB")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0403B6EC RID: 243436
			[Token(Token = "0x403B6EC")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0403B6ED RID: 243437
			[Token(Token = "0x403B6ED")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
