using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004220 RID: 16928
	[Token(Token = "0x2004220")]
	public class SandboxV2EnemyRushTrackerView : DataBinder<SandboxV2EnemyRushTrackerProperty>, IHotfixable
	{
		// Token: 0x0601A1D6 RID: 106966 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A1D6")]
		[Address(RVA = "0x1304D10", Offset = "0x1303910", VA = "0x181304D10", Slot = "7")]
		public override void OnValueChanged(SandboxV2EnemyRushTrackerProperty property)
		{
		}

		// Token: 0x0601A1D7 RID: 106967 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A1D7")]
		[Address(RVA = "0x1304FA0", Offset = "0x1303BA0", VA = "0x181304FA0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601A1D8 RID: 106968 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A1D8")]
		[Address(RVA = "0x13050C0", Offset = "0x1303CC0", VA = "0x1813050C0")]
		public SandboxV2EnemyRushTrackerView()
		{
		}

		// Token: 0x04020F2B RID: 134955
		[Token(Token = "0x4020F2B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SimpleLayoutContent _content;

		// Token: 0x04020F2C RID: 134956
		[Token(Token = "0x4020F2C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private ScrollRect _scrollRect;

		// Token: 0x04020F2D RID: 134957
		[Token(Token = "0x4020F2D")]
		[FieldOffset(Offset = "0x30")]
		private bool m_isInited;

		// Token: 0x04020F2E RID: 134958
		[Token(Token = "0x4020F2E")]
		[FieldOffset(Offset = "0x34")]
		private int m_cachedEnterSeq;

		// Token: 0x04020F2F RID: 134959
		[Token(Token = "0x4020F2F")]
		[FieldOffset(Offset = "0x38")]
		private SandboxV2EnemyRushTrackerView.Adapter m_adapter;

		// Token: 0x04020F30 RID: 134960
		[Token(Token = "0x4020F30")]
		[FieldOffset(Offset = "0x40")]
		private SandboxV2EnemyRushTrackerViewModel m_cachedViewModel;

		// Token: 0x04020F31 RID: 134961
		[Token(Token = "0x4020F31")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04020F32 RID: 134962
		[Token(Token = "0x4020F32")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04020F33 RID: 134963
		[Token(Token = "0x4020F33")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004221 RID: 16929
		[Token(Token = "0x2004221")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x0601A1D9 RID: 106969 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601A1D9")]
			[Address(RVA = "0x12FD2C0", Offset = "0x12FBEC0", VA = "0x1812FD2C0")]
			public Adapter(SandboxV2EnemyRushTrackerView closure)
			{
			}

			// Token: 0x17003E18 RID: 15896
			// (get) Token: 0x0601A1DA RID: 106970 RVA: 0x000A0488 File Offset: 0x0009E688
			[Token(Token = "0x17003E18")]
			public override int count
			{
				[Token(Token = "0x601A1DA")]
				[Address(RVA = "0x12FD670", Offset = "0x12FC270", VA = "0x1812FD670", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601A1DB RID: 106971 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601A1DB")]
			[Address(RVA = "0x12FC7F0", Offset = "0x12FB3F0", VA = "0x1812FC7F0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x04020F34 RID: 134964
			[Token(Token = "0x4020F34")]
			[FieldOffset(Offset = "0x20")]
			private SandboxV2EnemyRushTrackerView m_closure;

			// Token: 0x04020F35 RID: 134965
			[Token(Token = "0x4020F35")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04020F36 RID: 134966
			[Token(Token = "0x4020F36")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04020F37 RID: 134967
			[Token(Token = "0x4020F37")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
