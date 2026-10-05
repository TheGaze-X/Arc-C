using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004223 RID: 16931
	[Token(Token = "0x2004223")]
	public class SandboxV2OtherTrackerView : DataBinder<SandboxV2OtherTrackerViewModelProperty>, IHotfixable
	{
		// Token: 0x0601A1E0 RID: 106976 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A1E0")]
		[Address(RVA = "0x130C380", Offset = "0x130AF80", VA = "0x18130C380", Slot = "7")]
		public override void OnValueChanged(SandboxV2OtherTrackerViewModelProperty property)
		{
		}

		// Token: 0x0601A1E1 RID: 106977 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A1E1")]
		[Address(RVA = "0x130C560", Offset = "0x130B160", VA = "0x18130C560")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601A1E2 RID: 106978 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A1E2")]
		[Address(RVA = "0x130C680", Offset = "0x130B280", VA = "0x18130C680")]
		public SandboxV2OtherTrackerView()
		{
		}

		// Token: 0x04020F52 RID: 134994
		[Token(Token = "0x4020F52")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SimpleLayoutContent _content;

		// Token: 0x04020F53 RID: 134995
		[Token(Token = "0x4020F53")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private ScrollRect _scrollRect;

		// Token: 0x04020F54 RID: 134996
		[Token(Token = "0x4020F54")]
		[FieldOffset(Offset = "0x30")]
		private bool m_isInited;

		// Token: 0x04020F55 RID: 134997
		[Token(Token = "0x4020F55")]
		[FieldOffset(Offset = "0x38")]
		private SandboxV2OtherTrackerView.Adapter m_adapter;

		// Token: 0x04020F56 RID: 134998
		[Token(Token = "0x4020F56")]
		[FieldOffset(Offset = "0x40")]
		private SandboxV2OtherTrackerViewModel m_cachedViewModel;

		// Token: 0x04020F57 RID: 134999
		[Token(Token = "0x4020F57")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04020F58 RID: 135000
		[Token(Token = "0x4020F58")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04020F59 RID: 135001
		[Token(Token = "0x4020F59")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004224 RID: 16932
		[Token(Token = "0x2004224")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x0601A1E3 RID: 106979 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601A1E3")]
			[Address(RVA = "0x12FD240", Offset = "0x12FBE40", VA = "0x1812FD240")]
			public Adapter(SandboxV2OtherTrackerView closure)
			{
			}

			// Token: 0x17003E19 RID: 15897
			// (get) Token: 0x0601A1E4 RID: 106980 RVA: 0x000A04A0 File Offset: 0x0009E6A0
			[Token(Token = "0x17003E19")]
			public override int count
			{
				[Token(Token = "0x601A1E4")]
				[Address(RVA = "0x12FD340", Offset = "0x12FBF40", VA = "0x1812FD340", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601A1E5 RID: 106981 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601A1E5")]
			[Address(RVA = "0x12FC510", Offset = "0x12FB110", VA = "0x1812FC510", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x04020F5A RID: 135002
			[Token(Token = "0x4020F5A")]
			[FieldOffset(Offset = "0x20")]
			private SandboxV2OtherTrackerView m_closure;

			// Token: 0x04020F5B RID: 135003
			[Token(Token = "0x4020F5B")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04020F5C RID: 135004
			[Token(Token = "0x4020F5C")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04020F5D RID: 135005
			[Token(Token = "0x4020F5D")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
