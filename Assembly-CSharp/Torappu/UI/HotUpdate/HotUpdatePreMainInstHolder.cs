using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.HotUpdate
{
	// Token: 0x02004A89 RID: 19081
	[Token(Token = "0x2004A89")]
	public class HotUpdatePreMainInstHolder : DataBinder<HotUpdateViewProp>
	{
		// Token: 0x170043A6 RID: 17318
		// (get) Token: 0x0601CACF RID: 117455 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170043A6")]
		public HotUpdatePreMainProperty property
		{
			[Token(Token = "0x601CACF")]
			[Address(RVA = "0x1623E10", Offset = "0x1622A10", VA = "0x181623E10")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601CAD0 RID: 117456 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CAD0")]
		[Address(RVA = "0x1623700", Offset = "0x1622300", VA = "0x181623700", Slot = "7")]
		public override void OnValueChanged(HotUpdateViewProp property)
		{
		}

		// Token: 0x0601CAD1 RID: 117457 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CAD1")]
		[Address(RVA = "0x1623660", Offset = "0x1622260", VA = "0x181623660")]
		public void InitView(HotUpdateWorkflow.IContext context)
		{
		}

		// Token: 0x0601CAD2 RID: 117458 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CAD2")]
		[Address(RVA = "0x16238E0", Offset = "0x16224E0", VA = "0x1816238E0")]
		private void _TryInstPreMainView(HotUpdateViewProp property)
		{
		}

		// Token: 0x0601CAD3 RID: 117459 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CAD3")]
		[Address(RVA = "0x1623540", Offset = "0x1622140", VA = "0x181623540")]
		public void ClearViewIfNotNull(HotUpdateViewProp property)
		{
		}

		// Token: 0x0601CAD4 RID: 117460 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CAD4")]
		[Address(RVA = "0x1623DA0", Offset = "0x16229A0", VA = "0x181623DA0")]
		public HotUpdatePreMainInstHolder()
		{
		}

		// Token: 0x04025A2E RID: 154158
		[Token(Token = "0x4025A2E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform _transform;

		// Token: 0x04025A2F RID: 154159
		[Token(Token = "0x4025A2F")]
		[FieldOffset(Offset = "0x28")]
		private HotUpdatePreMainView m_preMainView;

		// Token: 0x04025A30 RID: 154160
		[Token(Token = "0x4025A30")]
		[FieldOffset(Offset = "0x30")]
		private UIAssetLoader.Assets m_assets;

		// Token: 0x04025A31 RID: 154161
		[Token(Token = "0x4025A31")]
		[FieldOffset(Offset = "0x38")]
		private HotUpdatePreMainProperty m_permainProperty;

		// Token: 0x04025A32 RID: 154162
		[Token(Token = "0x4025A32")]
		[FieldOffset(Offset = "0x40")]
		private HotUpdateWorkflow.IContext m_context;

		// Token: 0x04025A33 RID: 154163
		[Token(Token = "0x4025A33")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_property;

		// Token: 0x04025A34 RID: 154164
		[Token(Token = "0x4025A34")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04025A35 RID: 154165
		[Token(Token = "0x4025A35")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_InitView;

		// Token: 0x04025A36 RID: 154166
		[Token(Token = "0x4025A36")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__TryInstPreMainView;

		// Token: 0x04025A37 RID: 154167
		[Token(Token = "0x4025A37")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_ClearViewIfNotNull;

		// Token: 0x04025A38 RID: 154168
		[Token(Token = "0x4025A38")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
