using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x02005198 RID: 20888
	[Token(Token = "0x2005198")]
	public class UIRoguelikeFinishMissionDialog : UICustomDialog<UIRoguelikeFinishMissionDialog.Options>
	{
		// Token: 0x0601EDC0 RID: 126400 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EDC0")]
		[Address(RVA = "0x18ACF30", Offset = "0x18ABB30", VA = "0x1818ACF30", Slot = "7")]
		protected override void OnRender(UIRoguelikeFinishMissionDialog.Options options)
		{
		}

		// Token: 0x0601EDC1 RID: 126401 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EDC1")]
		[Address(RVA = "0x18AD000", Offset = "0x18ABC00", VA = "0x1818AD000")]
		private void _Render(RoguelikeTaskCompleteModel taskModel)
		{
		}

		// Token: 0x0601EDC2 RID: 126402 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EDC2")]
		[Address(RVA = "0x18ACEB0", Offset = "0x18ABAB0", VA = "0x1818ACEB0")]
		public void OnFinishMission()
		{
		}

		// Token: 0x0601EDC3 RID: 126403 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EDC3")]
		[Address(RVA = "0x18AD3A0", Offset = "0x18ABFA0", VA = "0x1818AD3A0")]
		public UIRoguelikeFinishMissionDialog()
		{
		}

		// Token: 0x04029666 RID: 169574
		[Token(Token = "0x4029666")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _textProgress;

		// Token: 0x04029667 RID: 169575
		[Token(Token = "0x4029667")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private float _alphaComplted;

		// Token: 0x04029668 RID: 169576
		[Token(Token = "0x4029668")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Slider _sliderProgress;

		// Token: 0x04029669 RID: 169577
		[Token(Token = "0x4029669")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Text _textTaskName;

		// Token: 0x0402966A RID: 169578
		[Token(Token = "0x402966A")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Text _textTaskDesc;

		// Token: 0x0402966B RID: 169579
		[Token(Token = "0x402966B")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private UIAtlasImage _imgRarity;

		// Token: 0x0402966C RID: 169580
		[Token(Token = "0x402966C")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private UIAtlasObject _atlas;

		// Token: 0x0402966D RID: 169581
		[Token(Token = "0x402966D")]
		[FieldOffset(Offset = "0x80")]
		private RoguelikeTaskCompleteModel m_taskModel;

		// Token: 0x0402966E RID: 169582
		[Token(Token = "0x402966E")]
		[FieldOffset(Offset = "0x88")]
		private UIRoguelikeFinishMissionDialog.Options m_options;

		// Token: 0x0402966F RID: 169583
		[Token(Token = "0x402966F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x04029670 RID: 169584
		[Token(Token = "0x4029670")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__Render;

		// Token: 0x04029671 RID: 169585
		[Token(Token = "0x4029671")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnFinishMission;

		// Token: 0x04029672 RID: 169586
		[Token(Token = "0x4029672")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005199 RID: 20889
		[Token(Token = "0x2005199")]
		public struct Options
		{
			// Token: 0x04029673 RID: 169587
			[Token(Token = "0x4029673")]
			[FieldOffset(Offset = "0x0")]
			public Action onConfirm;

			// Token: 0x04029674 RID: 169588
			[Token(Token = "0x4029674")]
			[FieldOffset(Offset = "0x8")]
			public string topicId;
		}
	}
}
