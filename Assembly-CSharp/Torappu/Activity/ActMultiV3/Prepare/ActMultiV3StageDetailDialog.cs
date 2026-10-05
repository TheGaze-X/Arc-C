using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.ActMultiV3.Prepare
{
	// Token: 0x0200701F RID: 28703
	[Token(Token = "0x200701F")]
	public class ActMultiV3StageDetailDialog : UICompDialog<ActMultiV3StageDetailDialog.Option>
	{
		// Token: 0x06028BC4 RID: 166852 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028BC4")]
		[Address(RVA = "0x240E980", Offset = "0x240D580", VA = "0x18240E980")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06028BC5 RID: 166853 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028BC5")]
		[Address(RVA = "0x240E750", Offset = "0x240D350", VA = "0x18240E750", Slot = "18")]
		protected override void OnRender(ActMultiV3StageDetailDialog.Option input)
		{
		}

		// Token: 0x06028BC6 RID: 166854 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028BC6")]
		[Address(RVA = "0x240E690", Offset = "0x240D290", VA = "0x18240E690")]
		public void Close()
		{
		}

		// Token: 0x06028BC7 RID: 166855 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028BC7")]
		[Address(RVA = "0x240EA50", Offset = "0x240D650", VA = "0x18240EA50")]
		public ActMultiV3StageDetailDialog()
		{
		}

		// Token: 0x0403A15B RID: 237915
		[Token(Token = "0x403A15B")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private ActMultiV3StageDetailView _viewPrefab;

		// Token: 0x0403A15C RID: 237916
		[Token(Token = "0x403A15C")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Transform _viewContainer;

		// Token: 0x0403A15D RID: 237917
		[Token(Token = "0x403A15D")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private RectTransform _backBtnRect;

		// Token: 0x0403A15E RID: 237918
		[Token(Token = "0x403A15E")]
		[FieldOffset(Offset = "0x88")]
		private ActMultiV3StageDetailView m_view;

		// Token: 0x0403A15F RID: 237919
		[Token(Token = "0x403A15F")]
		[FieldOffset(Offset = "0x90")]
		private bool m_isInited;

		// Token: 0x0403A160 RID: 237920
		[Token(Token = "0x403A160")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403A161 RID: 237921
		[Token(Token = "0x403A161")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x0403A162 RID: 237922
		[Token(Token = "0x403A162")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Close;

		// Token: 0x0403A163 RID: 237923
		[Token(Token = "0x403A163")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02007020 RID: 28704
		[Token(Token = "0x2007020")]
		public class Option
		{
			// Token: 0x06028BC8 RID: 166856 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6028BC8")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Option()
			{
			}

			// Token: 0x0403A164 RID: 237924
			[Token(Token = "0x403A164")]
			[FieldOffset(Offset = "0x10")]
			public string actId;

			// Token: 0x0403A165 RID: 237925
			[Token(Token = "0x403A165")]
			[FieldOffset(Offset = "0x18")]
			public string stageId;
		}
	}
}
