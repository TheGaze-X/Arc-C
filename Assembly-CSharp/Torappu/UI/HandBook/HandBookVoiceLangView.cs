using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.HandBook
{
	// Token: 0x020066AC RID: 26284
	[Token(Token = "0x20066AC")]
	public class HandBookVoiceLangView : DataBinder<HandBookVoiceLangViewProperty>
	{
		// Token: 0x06025C07 RID: 154631 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025C07")]
		[Address(RVA = "0x20B2F00", Offset = "0x20B1B00", VA = "0x1820B2F00")]
		public void SetClickAction(Action<VoiceLangType> onItemClick)
		{
		}

		// Token: 0x06025C08 RID: 154632 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025C08")]
		[Address(RVA = "0x20B2E20", Offset = "0x20B1A20", VA = "0x1820B2E20", Slot = "7")]
		public override void OnValueChanged(HandBookVoiceLangViewProperty property)
		{
		}

		// Token: 0x06025C09 RID: 154633 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025C09")]
		[Address(RVA = "0x20B3000", Offset = "0x20B1C00", VA = "0x1820B3000")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06025C0A RID: 154634 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025C0A")]
		[Address(RVA = "0x20B2F90", Offset = "0x20B1B90", VA = "0x1820B2F90")]
		public void Show()
		{
		}

		// Token: 0x06025C0B RID: 154635 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025C0B")]
		[Address(RVA = "0x20B2DB0", Offset = "0x20B19B0", VA = "0x1820B2DB0")]
		public void Hide()
		{
		}

		// Token: 0x06025C0C RID: 154636 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025C0C")]
		[Address(RVA = "0x20B31D0", Offset = "0x20B1DD0", VA = "0x1820B31D0")]
		public HandBookVoiceLangView()
		{
		}

		// Token: 0x0403510E RID: 217358
		[Token(Token = "0x403510E")]
		private const float FADE_DURATION = 0.23f;

		// Token: 0x0403510F RID: 217359
		[Token(Token = "0x403510F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CanvasGroup _panelCanvasGroup;

		// Token: 0x04035110 RID: 217360
		[Token(Token = "0x4035110")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private SimpleLayoutContent _simpleLayout;

		// Token: 0x04035111 RID: 217361
		[Token(Token = "0x4035111")]
		[FieldOffset(Offset = "0x30")]
		private bool m_isInited;

		// Token: 0x04035112 RID: 217362
		[Token(Token = "0x4035112")]
		[FieldOffset(Offset = "0x38")]
		private HandBookVoiceLangView.VoiceLangAdapter m_voiceLangAdapter;

		// Token: 0x04035113 RID: 217363
		[Token(Token = "0x4035113")]
		[FieldOffset(Offset = "0x40")]
		private FadeSwitchTween m_tween;

		// Token: 0x04035114 RID: 217364
		[Token(Token = "0x4035114")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_SetClickAction;

		// Token: 0x04035115 RID: 217365
		[Token(Token = "0x4035115")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04035116 RID: 217366
		[Token(Token = "0x4035116")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04035117 RID: 217367
		[Token(Token = "0x4035117")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Show;

		// Token: 0x04035118 RID: 217368
		[Token(Token = "0x4035118")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Hide;

		// Token: 0x04035119 RID: 217369
		[Token(Token = "0x4035119")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020066AD RID: 26285
		[Token(Token = "0x20066AD")]
		private class VoiceLangAdapter : SimpleLayoutAdapter
		{
			// Token: 0x1700596D RID: 22893
			// (get) Token: 0x06025C0D RID: 154637 RVA: 0x000C8E38 File Offset: 0x000C7038
			[Token(Token = "0x1700596D")]
			public override int count
			{
				[Token(Token = "0x6025C0D")]
				[Address(RVA = "0x20B6E40", Offset = "0x20B5A40", VA = "0x1820B6E40", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06025C0E RID: 154638 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6025C0E")]
			[Address(RVA = "0x20B6C80", Offset = "0x20B5880", VA = "0x1820B6C80", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x06025C0F RID: 154639 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6025C0F")]
			[Address(RVA = "0x20B6DE0", Offset = "0x20B59E0", VA = "0x1820B6DE0")]
			public VoiceLangAdapter()
			{
			}

			// Token: 0x0403511A RID: 217370
			[Token(Token = "0x403511A")]
			[FieldOffset(Offset = "0x20")]
			public HandBookVoiceLangViewModel viewModel;

			// Token: 0x0403511B RID: 217371
			[Token(Token = "0x403511B")]
			[FieldOffset(Offset = "0x28")]
			public Action<VoiceLangType> itemClickAction;

			// Token: 0x0403511C RID: 217372
			[Token(Token = "0x403511C")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0403511D RID: 217373
			[Token(Token = "0x403511D")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x0403511E RID: 217374
			[Token(Token = "0x403511E")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
