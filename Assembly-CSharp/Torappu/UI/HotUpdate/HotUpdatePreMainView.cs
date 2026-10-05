using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.HotUpdate
{
	// Token: 0x02004A8C RID: 19084
	[Token(Token = "0x2004A8C")]
	public class HotUpdatePreMainView : DataBinder<HotUpdatePreMainProperty>
	{
		// Token: 0x170043A7 RID: 17319
		// (get) Token: 0x0601CADA RID: 117466 RVA: 0x000A90B0 File Offset: 0x000A72B0
		[Token(Token = "0x170043A7")]
		public PreMainState currentState
		{
			[Token(Token = "0x601CADA")]
			[Address(RVA = "0x16250F0", Offset = "0x1623CF0", VA = "0x1816250F0")]
			get
			{
				return PreMainState.NONE;
			}
		}

		// Token: 0x0601CADB RID: 117467 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CADB")]
		[Address(RVA = "0x1624F20", Offset = "0x1623B20", VA = "0x181624F20")]
		public void SetContext(HotUpdateWorkflow.IContext context)
		{
		}

		// Token: 0x0601CADC RID: 117468 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CADC")]
		[Address(RVA = "0x1624EA0", Offset = "0x1623AA0", VA = "0x181624EA0")]
		public void SetAssets(UIAssetLoader.Assets assets)
		{
		}

		// Token: 0x0601CADD RID: 117469 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CADD")]
		[Address(RVA = "0x1624930", Offset = "0x1623530", VA = "0x181624930")]
		public void InitHide()
		{
		}

		// Token: 0x0601CADE RID: 117470 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CADE")]
		[Address(RVA = "0x1624B90", Offset = "0x1623790", VA = "0x181624B90", Slot = "7")]
		public override void OnValueChanged(HotUpdatePreMainProperty property)
		{
		}

		// Token: 0x0601CADF RID: 117471 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CADF")]
		[Address(RVA = "0x1624AA0", Offset = "0x16236A0", VA = "0x181624AA0")]
		public void OnClear()
		{
		}

		// Token: 0x0601CAE0 RID: 117472 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CAE0")]
		[Address(RVA = "0x1625080", Offset = "0x1623C80", VA = "0x181625080")]
		public HotUpdatePreMainView()
		{
		}

		// Token: 0x04025A47 RID: 154183
		[Token(Token = "0x4025A47")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<AbstractHotUpdatePreMainFadeInView> _preMainList;

		// Token: 0x04025A48 RID: 154184
		[Token(Token = "0x4025A48")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private List<GameObject> _backImgList;

		// Token: 0x04025A49 RID: 154185
		[Token(Token = "0x4025A49")]
		[FieldOffset(Offset = "0x30")]
		private HotUpdateWorkflow.IContext m_context;

		// Token: 0x04025A4A RID: 154186
		[Token(Token = "0x4025A4A")]
		[FieldOffset(Offset = "0x38")]
		private UIAssetLoader.Assets m_assets;

		// Token: 0x04025A4B RID: 154187
		[Token(Token = "0x4025A4B")]
		[FieldOffset(Offset = "0x40")]
		private PreMainState m_currentState;

		// Token: 0x04025A4C RID: 154188
		[Token(Token = "0x4025A4C")]
		[FieldOffset(Offset = "0x48")]
		private FadeSwitchTween m_picSwitchTween;

		// Token: 0x04025A4D RID: 154189
		[Token(Token = "0x4025A4D")]
		[FieldOffset(Offset = "0x50")]
		private bool m_isInited;

		// Token: 0x04025A4E RID: 154190
		[Token(Token = "0x4025A4E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_currentState;

		// Token: 0x04025A4F RID: 154191
		[Token(Token = "0x4025A4F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SetContext;

		// Token: 0x04025A50 RID: 154192
		[Token(Token = "0x4025A50")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SetAssets;

		// Token: 0x04025A51 RID: 154193
		[Token(Token = "0x4025A51")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_InitHide;

		// Token: 0x04025A52 RID: 154194
		[Token(Token = "0x4025A52")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04025A53 RID: 154195
		[Token(Token = "0x4025A53")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnClear;

		// Token: 0x04025A54 RID: 154196
		[Token(Token = "0x4025A54")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
