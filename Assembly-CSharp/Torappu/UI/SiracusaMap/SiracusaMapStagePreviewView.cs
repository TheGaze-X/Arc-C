using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using Torappu.UI.ActivityStage;
using UnityEngine;
using XLua;

namespace Torappu.UI.SiracusaMap
{
	// Token: 0x02003EFF RID: 16127
	[Token(Token = "0x2003EFF")]
	public class SiracusaMapStagePreviewView : DataBinder<SiracusaMapPanelMapProperty>
	{
		// Token: 0x17003BCD RID: 15309
		// (get) Token: 0x0601909E RID: 102558 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003BCD")]
		public TemplateActivityMapPreviewView view
		{
			[Token(Token = "0x601909E")]
			[Address(RVA = "0x11C05C0", Offset = "0x11BF1C0", VA = "0x1811C05C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17003BCE RID: 15310
		// (get) Token: 0x0601909F RID: 102559 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003BCE")]
		private UISwitchTween previewFadeTween
		{
			[Token(Token = "0x601909F")]
			[Address(RVA = "0x11C04E0", Offset = "0x11BF0E0", VA = "0x1811C04E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x060190A0 RID: 102560 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60190A0")]
		[Address(RVA = "0x11C02D0", Offset = "0x11BEED0", VA = "0x1811C02D0", Slot = "7")]
		public override void OnValueChanged(SiracusaMapPanelMapProperty property)
		{
		}

		// Token: 0x060190A1 RID: 102561 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60190A1")]
		[Address(RVA = "0x11C0470", Offset = "0x11BF070", VA = "0x1811C0470")]
		public SiracusaMapStagePreviewView()
		{
		}

		// Token: 0x0401EF5E RID: 126814
		[Token(Token = "0x401EF5E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TemplateActivityMapPreviewView _stagePreviewView;

		// Token: 0x0401EF5F RID: 126815
		[Token(Token = "0x401EF5F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private CanvasGroup _stagePreviewCanvasGroup;

		// Token: 0x0401EF60 RID: 126816
		[Token(Token = "0x401EF60")]
		[FieldOffset(Offset = "0x30")]
		private UISwitchTween m_previewFadeTween;

		// Token: 0x0401EF61 RID: 126817
		[Token(Token = "0x401EF61")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_view;

		// Token: 0x0401EF62 RID: 126818
		[Token(Token = "0x401EF62")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_previewFadeTween;

		// Token: 0x0401EF63 RID: 126819
		[Token(Token = "0x401EF63")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0401EF64 RID: 126820
		[Token(Token = "0x401EF64")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
